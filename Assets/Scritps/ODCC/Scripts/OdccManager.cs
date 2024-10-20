using System;
using System.Collections.Generic;
using System.Linq;

using BC.Base;

using UnityEngine;
using UnityEngine.SceneManagement;

using Debug = UnityEngine.Debug;

namespace BC.ODCC
{
	/// <summary>
	/// OdccManager 클래스는 ODCC 시스템의 핵심 관리 클래스로, 싱글톤 패턴을 사용하여 인스턴스를 관리합니다.
	/// </summary>
	[DefaultExecutionOrder(-1)]
	public sealed partial class OdccManager : MonoBehaviour
	{
		public static OdccManager Instance;

		// 파괴가 예약된 오브젝트 집합
		public static HashSet<IOCBehaviour> reservationDestroyObject = new HashSet<IOCBehaviour>();
		public static bool awaitReservationDestroyObject;


		/// <summary>
		/// ODCC 매니저를 초기화하는 메서드입니다. 씬이 로드되기 전에 실행됩니다.
		/// </summary>
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		static void InitOdccManager()
		{
			Instance = new GameObject().AddComponent<OdccManager>();
			DontDestroyOnLoad(Instance.gameObject);

			// 씬이 언로드될 때 호출되는 이벤트 핸들러를 등록합니다.
			SceneManager.sceneUnloaded += Instance.SceneManager_sceneUnloaded;

			// ODCC 컨테이너 트리와 Foreach 시스템을 초기화합니다.
			OdccContainerTree.InitTree();
			OdccForeach.InitForeach();
		}

		private void OnDestroy()
		{
			// 씬이 언로드될 때 호출되는 이벤트 핸들러를 해제합니다.
			SceneManager.sceneUnloaded -= SceneManager_sceneUnloaded;

			// ODCC 컨테이너 트리와 Foreach 시스템을 해제합니다.
			OdccContainerTree.ReleaseTree();
			OdccForeach.ReleaseForeach();

			// 모든 코루틴을 중지합니다.
			StopAllCoroutines();
		}

		/// <summary>
		/// 씬이 언로드될 때 호출되는 메서드입니다.
		/// </summary>
		/// <param name="scene">언로드된 씬</param>
		private void SceneManager_sceneUnloaded(Scene scene)
		{
			// 언로드된 씬의 아이템을 ODCC Foreach 시스템에서 제거합니다.
			OdccForeach.RemoveLifeItemOdccCollectorList(scene);
		}

		Action beforeAwake;
		internal static void OdccAwake(OCBehaviour ocBehaviour)
		{
			if(ocBehaviour == null) return;

			_OdccAwake(ocBehaviour);
			void _OdccAwake(IOCBehaviour target)
			{
				/// Awake 가 처음인지 검사.
				if(!target._IsCanEnterAwake) return;

				/// 부모가 있을경우 부모가 Awake 한적 있는지 검사 
				Transform parentTr = target.ThisTransform.parent;
				IOCBehaviour parent = parentTr == null ? null : parentTr.gameObject.GetComponentInParent<IOCBehaviour>(true);
				if(parent != null && parent._IsCanEnterAwake) return;

				// 기본 리스트 구성하기
				List<IOCBehaviour> awakeList = CreateAwakeList();
				List<ContainerNode> duplicatesNodeList = ContainerNodeList(in awakeList);
				HashSet<ContainerNode> nodeList = null;
				// ContainerNode 중복 제거
				NodeDuplicatesCheck(in duplicatesNodeList, out nodeList);

				// 노드 Self 연결하기
				LinkNodeSelfObject(in awakeList, in duplicatesNodeList);

				// 노드 Parent/Child 연결하기
				LinkNodeParentObject(in nodeList);
				LinkNodeChildrenObject(in nodeList);

				// 노드 리스트 갱신하기
				UpdateContainerNode(in nodeList);

				// Awake 호출
				OCBehaviourAwake(in awakeList);
				OCBehaviourUpdate(in awakeList);

				// 이벤트 연결하기
				AddEventManager(in awakeList);
				AddOdccCollectorList(in nodeList);

				List<IOCBehaviour> CreateAwakeList()
				{
					List<IOCBehaviour> awakeList = new List<IOCBehaviour>();

					// 순서 중요.
					if(ocBehaviour is ObjectBehaviour)
					{
						awakeList.Add(ocBehaviour);
						awakeList.AddRange(ocBehaviour.gameObject.GetComponentsInChildren<ObjectBehaviour>(true));
						awakeList.AddRange(ocBehaviour.gameObject.GetComponentsInChildren<ComponentBehaviour>(true));
					}
					else
					{
						awakeList.AddRange(ocBehaviour.gameObject.GetComponentsInChildren<ObjectBehaviour>(true));
						awakeList.Add(ocBehaviour);
						awakeList.AddRange(ocBehaviour.gameObject.GetComponentsInChildren<ComponentBehaviour>(true));
					}

					/// Awake 된 객체 제거.
					int length = awakeList.Count;
					for(int i = 0 ; i < length ; i++)
					{
						if(awakeList[i]._IsCanEnterAwake)
						{
							awakeList[i].AwakeState = IOCBehaviour.StateFlag.On;
						}
						else
						{
							awakeList.RemoveAt(i--);
							length--;
						}
					}
					return awakeList;
				}
				List<ContainerNode> ContainerNodeList(in List<IOCBehaviour> awakeList)
				{
					/// Node 없는 객체 제거.
					List<ContainerNode> nodeList = new List<ContainerNode>();
					int length = awakeList.Count;
					for(int i = 0 ; i < length ; i++)
					{
						var target = awakeList[i];
						if(OdccContainerTree.CreateAndConnectSelfContainerNode(target, out ContainerNode node))
						{
							nodeList.Add(node);
						}
						else
						{
							awakeList.RemoveAt(i--);
							length--;
						}
					}
					return nodeList;
				}

				void NodeDuplicatesCheck(in List<ContainerNode> duplicatesNodeList, out HashSet<ContainerNode> nodeList)
				{
					/// 중복된 ContainerNode 제거 하고 전체리스트 갱신
					nodeList = new HashSet<ContainerNode>();
					int length = duplicatesNodeList.Count;
					for(int i = 0 ; i < length ; i++)
					{
						ContainerNode node = duplicatesNodeList[i];
						if(nodeList.Add(node))
						{
							node.CurrentInit();
						}
					}
				}

				void LinkNodeSelfObject(in List<IOCBehaviour> awakeList, in List<ContainerNode> nodeList)
				{
					int length = awakeList.Count;
					for(int i = 0 ; i < length ; i++)
					{
						var awake = awakeList[i];
						ContainerNode node = nodeList[i];
						node.AddInit(awake);
						if(awake is IOdccObject _object)
						{
							node.thisObject = _object;
							node.AddInit(_object);
							var dataList = _object.ThisContainer.DataList;
							int dLength = dataList.Length;
							for(int d = 0 ; d < dLength ; d++)
							{
								if(dataList[d] == null) continue;
								node.AddInit(dataList[d]);
							}
						}
					}
				}

				void LinkNodeParentObject(in HashSet<ContainerNode> nodeList)
				{
					foreach(var node in nodeList)
					{
						var thisTransform = node.thisObject.ThisTransform;
						var parentTransform = thisTransform.parent;
						if(parentTransform == null) continue;
						var parent = parentTransform.GetComponentInParent<ObjectBehaviour>(true);
						if(parent == null) continue;
						var parentNode = OdccContainerTree.GetContainerNode(parent);
						if(parentNode == null) continue;

						node.parent = parentNode.thisObject;

						if(!nodeList.Contains(parentNode))
						{
							parentNode.AddItem(node.thisObject);
						}
					}
				}
				void LinkNodeChildrenObject(in HashSet<ContainerNode> nodeList)
				{
					foreach(var node in nodeList)
					{
						var parentNode = OdccContainerTree.GetContainerNode(node.parent);
						if(parentNode == null) continue;
						parentNode.AddInit(node.thisObject);
					}
				}
				void UpdateContainerNode(in HashSet<ContainerNode> nodeList)
				{
					foreach(var node in nodeList)
					{
						node.UpdateInit();
					}
				}

				void OCBehaviourAwake(in List<IOCBehaviour> awakeList)
				{
					int length = awakeList.Count;
					for(int i = 0 ; i < length ; i++)
					{
						var target =awakeList[i];
						target.OdccAwake();
					}
				}
				void OCBehaviourUpdate(in List<IOCBehaviour> awakeList)
				{
					int length = awakeList.Count;
					for(int i = 0 ; i < length ; i++)
					{
						var target = awakeList[i];
						if(target is IOdccUpdate odccUpdate)
						{
							OdccForeach.AddUpdateBehaviour(odccUpdate);
						}
						if(target is IOdccUpdate.Late odccUpdateLate)
						{
							OdccForeach.AddLateUpdateBehaviour(odccUpdateLate);
						}
					}
				}

				void AddEventManager(in List<IOCBehaviour> awakeList)
				{
					int length = awakeList.Count;
					for(int i = 0 ; i < length ; i++)
					{
						if(awakeList[i] is OCBehaviour behaviour)
							EventManager.AddListener(behaviour);
					}
				}
				void AddOdccCollectorList(in HashSet<ContainerNode> nodeList)
				{
					foreach(var node in nodeList)
					{
						OdccForeach.UpdateOdccCollectorList(node.thisObject);
					}
				}
			}
		}
		/// <summary>
		/// 특정 OCBehaviour가 파괴될 때 호출되는 메서드입니다.
		/// </summary>
		/// <param name="ocBehaviour">파괴되는 OCBehaviour</param>
		internal static void OdccDestroy(OCBehaviour ocBehaviour)
		{
			if(ocBehaviour == null) return;

			_OdccDestroy(ocBehaviour);
			void _OdccDestroy(IOCBehaviour target)
			{
				/// Destroy 가 처음인지 검사.
				if(!target._IsCanEnterDestroy) return;
				target.DestroyState = IOCBehaviour.StateFlag.On;

				//// 삭제 예정 목록에 추가.
				reservationDestroyObject.Add(target);
				awaitReservationDestroyObject = false;
			}
		}
		private static void _OdccDestroy(IOCBehaviour[] deleteList)
		{
			int length = deleteList.Length;
			if(length == 0) return;


			List<IOdccObject> objectList = new List<IOdccObject>();
			Dictionary<ContainerNode, List<IOdccComponent>> nodeComponentList = new Dictionary<ContainerNode, List<IOdccComponent>>();

			CreateDeleteList(ref objectList, ref nodeComponentList);


			OCBehaviourDestroy(in deleteList);
			RemoveOCBehaviourUpdate(in deleteList);

			/// Node 에서 삭제
			RemoveAndReleaseSelfContainerNode(in objectList, in nodeComponentList);
			/// 콜렉터에서 오브젝트 삭제하고 
			RemoveOdccCollectorList(in objectList, in nodeComponentList);
			RemoveEventManager();

			Dispose(in deleteList);

			void CreateDeleteList(ref List<IOdccObject> objectList, ref Dictionary<ContainerNode, List<IOdccComponent>> nodeComponentList)
			{
				for(int i = 0 ; i < length ; i++)
				{
					IOCBehaviour item = deleteList[i];
					if(item is IOdccObject @object)
					{
						objectList.Add(@object);
					}
					else if(item is IOdccComponent component)
					{
						var node = OdccContainerTree.GetContainerNode(component);
						if(!nodeComponentList.TryGetValue(node, out var list))
						{
							list = new List<IOdccComponent>();
							nodeComponentList.Add(node, list);
						}
						list.Add(component);
					}
				}
			}
			void OCBehaviourDestroy(in IOCBehaviour[] deleteList)
			{
				for(int i = 0 ; i < length ; i++)
				{
					var target =deleteList[i];
					target.OdccDestroy();
				}
			}
			void RemoveOCBehaviourUpdate(in IOCBehaviour[] deleteList)
			{
				for(int i = 0 ; i < length ; i++)
				{
					var target = deleteList[i];
					if(target is IOdccUpdate odccUpdate)
					{
						OdccForeach.RemoveUpdateBehaviour(odccUpdate);
					}
					if(target is IOdccUpdate.Late odccUpdateLate)
					{
						OdccForeach.RemoveLateUpdateBehaviour(odccUpdateLate);
					}
				}
			}
			void RemoveAndReleaseSelfContainerNode(in List<IOdccObject> objectList, in Dictionary<ContainerNode, List<IOdccComponent>> componentList)
			{
				foreach(var item in componentList)
				{
					OdccContainerTree.RemoveAndReleaseSelfContainerNode(item.Key, item.Value);
				}
				foreach(var item in objectList)
				{
					OdccContainerTree.RemoveAndReleaseSelfContainerNode(item);
				}
			}
			void RemoveOdccCollectorList(in List<IOdccObject> objectList, in Dictionary<ContainerNode, List<IOdccComponent>> nodeComponentList)
			{
				int length = objectList.Count;
				for(int i = 0 ; i < length ; i++)
				{
					OdccForeach.RemoveOdccCollectorList(objectList[i]);
				}
				foreach(var item in nodeComponentList)
				{
					OdccForeach.UpdateOdccCollectorList(item.Key.thisObject);
				}
			}
			void RemoveEventManager()
			{
				for(int i = 0 ; i < length ; i++)
				{
					if(deleteList[i] is OCBehaviour behaviour)
						EventManager.RemoveListener(behaviour);
				}
			}

			void Dispose(in IOCBehaviour[] deleteList)
			{
				for(int i = 0 ; i < length ; i++)
				{
					var target =deleteList[i];
					try
					{
						target.Dispose();
					}
					catch(Exception ex)
					{
						Debug.LogException(ex);
					}
				}
			}
		}
		/// <summary>
		/// 특정 OCBehaviour가 파괴될 때 호출되는 메서드입니다.
		/// </summary>
		/// <param name="ocBehaviour">파괴되는 OCBehaviour</param>


		/// <summary>
		/// 특정 OCBehaviour가 활성화될 때 호출되는 메서드입니다.
		/// </summary>
		/// <param name="ocBehaviour">활성화되는 OCBehaviour</param>
		internal static void OdccEnable(OCBehaviour ocBehaviour)
		{
			// OCBehaviour의 BaseEnable 메서드를 호출합니다.
			if(ocBehaviour is IOCBehaviour iBehaviour)
			{
				iBehaviour.EnableState = IOCBehaviour.StateFlag.On;
				iBehaviour.OdcnEnable();
			}
		}

		/// <summary>
		/// 특정 OCBehaviour가 비활성화될 때 호출되는 메서드입니다.
		/// </summary>
		/// <param name="ocBehaviour">비활성화되는 OCBehaviour</param>
		internal static void OdccDisable(OCBehaviour ocBehaviour)
		{
			// OCBehaviour의 BaseDisable 메서드를 호출합니다.
			if(ocBehaviour is IOCBehaviour iBehaviour)
			{
				iBehaviour.EnableState = IOCBehaviour.StateFlag.Off;
				iBehaviour.OdccDisable();
			}
		}

		/// <summary>
		/// 특정 OCBehaviour가 시작될 때 호출되는 메서드입니다.
		/// </summary>
		/// <param name="ocBehaviour">시작되는 OCBehaviour</param>
		internal static void OdccStart(OCBehaviour ocBehaviour)
		{
			// OCBehaviour의 BaseStart 메서드를 호출합니다.
			if(ocBehaviour is IOCBehaviour iBehaviour)
			{
				iBehaviour.StartState = IOCBehaviour.StateFlag.On;
				iBehaviour.OdccStart();
			}
		}

		/// <summary>
		/// 특정 ObjectBehaviour의 데이터를 업데이트하는 메서드입니다.
		/// </summary>
		/// <param name="updateObject">데이터가 업데이트될 ObjectBehaviour</param>
		internal static void UpdateData(ObjectBehaviour updateObject)
		{
			// Foreach 시스템에서 객체를 업데이트합니다.
			OdccForeach.UpdateObjectInQuery(updateObject);
		}

		// 프로파일러 활성화 여부를 나타내는 변수입니다.
		static public bool isProfilerEnabled = false;

		/// <summary>
		/// MonoBehaviour의 Start 메서드를 오버라이드합니다.
		/// </summary>
		public void Start()
		{
			// EndOfFrameDispose 루프를 시작합니다.
#if USING_AWAITABLE_LOOP
			EndOfFrameDispose();
#else
			StartCoroutine(EndOfFrameDispose());
#endif
		}

		/// <summary>
		/// MonoBehaviour의 Update 메서드를 오버라이드합니다.
		/// </summary>
		public void Update()
		{
#if UNITY_EDITOR
			// 에디터 환경에서 프로파일러 활성화 여부를 설정합니다.
			isProfilerEnabled = UnityEngine.Profiling.Profiler.enabled;
#else
            // 빌드 환경에서는 프로파일러를 비활성화합니다.
            isProfilerEnabled = false;
#endif
			// ODCC Foreach 시스템의 업데이트 메서드를 호출합니다.
			OdccForeach.ForeachUpdate();
		}

		/// <summary>
		/// MonoBehaviour의 LateUpdate 메서드를 오버라이드합니다.
		/// </summary>
		public void LateUpdate()
		{
			// ODCC Foreach 시스템의 LateUpdate 메서드를 호출합니다.
			OdccForeach.ForeachLateUpdate();
		}


		public static bool TryFindOdccObject(QuerySystem findQuery, bool findInCash, out ObjectBehaviour find)
		{
			return OdccForeach.TryFindOdccObject(findQuery, findInCash, out find);
		}
		public static bool TryFindOdccObject(QuerySystem findQuery, out ObjectBehaviour find)
		{
			return OdccForeach.TryFindOdccObject(findQuery, out find);
		}
		public static bool TryFindOdccObject<T>(QuerySystem findQuery, bool findInCash, out T find) where T : ObjectBehaviour
		{
			find = null;
			if(TryFindOdccObject(findQuery, findInCash, out var _find))
			{
				find = _find as T;
			}
			return find != null;
		}
		public static bool TryFindOdccObject<T>(QuerySystem findQuery, out T find) where T : ObjectBehaviour
		{
			find = null;
			if(TryFindOdccObject(findQuery, out var _find))
			{
				find = _find as T;
			}
			return find != null;
		}

#if USING_AWAITABLE_LOOP
		/// <summary>
		/// 프레임의 끝에서 실행되는 Awaitable 입니다.
		/// </summary>
		/// 
		async void EndOfFrameDispose()
		{
			while(true)
			{
				// awaitReservationDestroyObject 를 기다립니다.

				while(awaitReservationDestroyObject)
				{
					await Awaitable.EndOfFrameAsync();
				}
				awaitReservationDestroyObject = true;

				// 예약된 파괴 오브젝트 집합을 초기화합니다.
				var list = reservationDestroyObject.ToArray();
				reservationDestroyObject.Clear();

				// 예약된 파괴 오브젝트를 순회하며 Dispose를 호출합니다.
				OdccManager._OdccDestroy(list);

				list = null;
			}
		}
#else
		/// <summary>
		/// 프레임의 끝에서 실행되는 코루틴입니다.
		/// </summary>
		/// <returns>IEnumerator</returns>
		IEnumerator EndOfFrameDispose()
		{
			// 프레임 끝에서 대기하는 WaitForEndOfFrame 객체입니다.
			var waitFrame = new WaitForEndOfFrame();

			while(true)
			{
				yield return waitFrame;

				// 예약된 파괴 오브젝트 집합의 개수를 가져옵니다.
				int count = OdccContainerTree.reservationDestroyObject.Count;

				if(count > 0)
				{
					// 예약된 파괴 오브젝트를 순회하며 Dispose를 호출합니다.
					foreach(var item in OdccContainerTree.reservationDestroyObject)
					{
						item.Dispose();
					}

					// 예약된 파괴 오브젝트 집합을 초기화합니다.
					OdccContainerTree.reservationDestroyObject.Clear();
				}
			}
		}
#endif
	}
}

