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

		/// <summary>
		/// 특정 OCBehaviour가 깨어날 때 호출되는 메서드입니다.
		/// </summary>
		/// <param name="ocBehaviour">깨어나는 OCBehaviour</param>
		internal static void OdccAwake(OCBehaviour ocBehaviour)
		{
			// OCBehaviour를 ODCC 컨테이너 트리에 추가하고, Foreach 시스템에 등록하며 이벤트 리스너를 추가합니다.
			if(OdccContainerTree.AwakeOCBehaviour(ocBehaviour))
			{
				if(ocBehaviour.ThisBehaviour.IsAwake) return;
				OdccForeach.AddOdccCollectorList(ocBehaviour);
				EventManager.AddListener(ocBehaviour);

				// OCBehaviour의 BaseAwake 메서드를 호출합니다.
				ocBehaviour.DoBaseAwake();

				// OCBehaviour가 ObjectBehaviour인 경우 추가 작업을 수행합니다.
				if(ocBehaviour is ObjectBehaviour objectBehaviour)
				{
					OdccContainerTree.ContainerNode containerNode = OdccContainerTree.GetContainerNode(objectBehaviour);

					int Length = containerNode.componentList.Length;

					// 각 컴포넌트를 순회하며 활성화된 경우 처리를 수행합니다.
					for(int i = 0 ; i < Length ; i++)
					{
						var component = containerNode.componentList[i];
						if(component.enabled && component.gameObject.activeInHierarchy)
						{
							if(OdccContainerTree.AwakeOCBehaviour(component))
							{
								OdccForeach.AddOdccCollectorList(component);
								EventManager.AddListener(component);

								if(component.ThisBehaviour.IsAwake) continue;
								component.DoBaseAwake();
							}
							else
							{
								Destroy(component);
							}
						}
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
			// OCBehaviour의 BaseDestroy 메서드를 호출합니다.
			ocBehaviour.BaseDestroy();
			bool isObjectBehaviour = ocBehaviour is ObjectBehaviour;

			if(isObjectBehaviour)
			{
				var destroyAll = ocBehaviour.GetComponentsInChildren<OCBehaviour>(true);
				var length = destroyAll.Length;
				for(int i = 0 ; i<length ; i++)
				{
					destroyAll[i].CallDestroy();
				}
			}
			// OCBehaviour를 ODCC 컨테이너 트리와 Foreach 시스템에서 제거하고, 이벤트 리스너를 제거합니다.
			OdccContainerTree.DestroyOCBehaviour(ocBehaviour);
			OdccForeach.RemoveOdccCollectorList(ocBehaviour);
			EventManager.RemoveListener(ocBehaviour);

			if(isObjectBehaviour)
			{
				GameObject.Destroy(ocBehaviour.gameObject);
			}
		}

		/// <summary>
		/// 특정 OCBehaviour가 활성화될 때 호출되는 메서드입니다.
		/// </summary>
		/// <param name="ocBehaviour">활성화되는 OCBehaviour</param>
		internal static void OdccEnable(OCBehaviour ocBehaviour)
		{
			// OCBehaviour의 BaseEnable 메서드를 호출합니다.
			ocBehaviour.BaseEnable();
		}

		/// <summary>
		/// 특정 OCBehaviour가 비활성화될 때 호출되는 메서드입니다.
		/// </summary>
		/// <param name="ocBehaviour">비활성화되는 OCBehaviour</param>
		internal static void OdccDisable(OCBehaviour ocBehaviour)
		{
			// OCBehaviour의 BaseDisable 메서드를 호출합니다.
			ocBehaviour.BaseDisable();
		}

		/// <summary>
		/// 특정 OCBehaviour가 시작될 때 호출되는 메서드입니다.
		/// </summary>
		/// <param name="ocBehaviour">시작되는 OCBehaviour</param>
		internal static void OdccStart(OCBehaviour ocBehaviour)
		{
			// OCBehaviour의 BaseStart 메서드를 호출합니다.
			ocBehaviour.BaseStart();
		}

		/// <summary>
		/// 특정 OCBehaviour의 부모가 변경될 때 호출되는 메서드입니다.
		/// </summary>
		/// <param name="ocBehaviour">부모가 변경되는 OCBehaviour</param>
		internal static void OdccChangeParent(OCBehaviour ocBehaviour)
		{
			// 부모 변경 여부를 저장하는 변수입니다.
			bool isChangeParent = false;

			// OCBehaviour가 ObjectBehaviour인 경우 부모를 변경합니다.
			if(ocBehaviour is ObjectBehaviour)
			{
				isChangeParent = OdccContainerTree.ChangeParent(ocBehaviour);
			}
			// OCBehaviour가 ComponentBehaviour인 경우 부모를 변경합니다.
			else if(ocBehaviour is ComponentBehaviour componentBehaviour)
			{
				var oldObject = componentBehaviour.ThisObject;
				isChangeParent = OdccContainerTree.ChangeParent(ocBehaviour);

				// 부모가 변경된 경우 Foreach 시스템에서 객체를 업데이트합니다.
				if(isChangeParent)
				{
					var newObject = componentBehaviour.ThisObject;
					OdccForeach.UpdateObjectInQuery(oldObject);
					OdccForeach.UpdateObjectInQuery(newObject);
				}
			}

			// 부모가 변경된 경우 BaseTransformParentChanged 메서드를 호출합니다.
			if(isChangeParent)
			{
				ocBehaviour.BaseTransformParentChanged();
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

				while(OdccContainerTree.awaitReservationDestroyObject)
				{
					await Awaitable.NextFrameAsync();
				}
				OdccContainerTree.awaitReservationDestroyObject = true;

				// 예약된 파괴 오브젝트 집합을 초기화합니다.
				var list = OdccContainerTree.reservationDestroyObject;
				OdccContainerTree.reservationDestroyObject.Clear();

				// 예약된 파괴 오브젝트를 순회하며 Dispose를 호출합니다.
				foreach(var item in list)
				{
					try
					{
						item.Dispose();
					}
					catch(System.Exception ex)
					{
						Debug.LogException(ex);
					}
				}
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

