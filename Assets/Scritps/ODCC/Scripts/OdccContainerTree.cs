using System;
using System.Collections.Generic;
using System.Linq;

using Sirenix.OdinInspector;
using Sirenix.Utilities;

using UnityEngine;

using Object = UnityEngine.Object;

namespace BC.ODCC
{
	/// <summary>
	/// OdccContainerTree 클래스는 오브젝트 컨테이너 트리를 관리하는 정적 클래스입니다.
	/// 이 클래스는 오브젝트 컨테이너 노드를 생성, 초기화, 갱신, 제거하는 기능을 제공합니다.
	/// </summary>
	public static partial class OdccContainerTree
	{
		// 빈 오브젝트를 저장할 변수
		internal static ObjectBehaviour EmptyObject;

		// ObjectBehaviour를 키로 하는 컨테이너 노드 리스트
		public static Dictionary<ObjectBehaviour, ContainerNode> ContainerNodeList = new Dictionary<ObjectBehaviour, ContainerNode>();

		// 파괴가 예약된 오브젝트 집합
		public static HashSet<OCBehaviour> reservationDestroyObject = new HashSet<OCBehaviour>();
		public static bool awaitReservationDestroyObject;

		/// <summary>
		/// 특정 오브젝트에 대한 컨테이너 노드를 가져오는 메서드
		/// </summary>
		/// <param name="key">오브젝트 키</param>
		/// <returns>해당 오브젝트의 컨테이너 노드</returns>
		internal static ContainerNode GetContainerNode(ObjectBehaviour key)
		{
			return ContainerNodeList.TryGetValue(key??EmptyObject, out var keyNode) ? keyNode : null;
		}

		/// <summary>
		/// 컨테이너 트리를 초기화하는 메서드
		/// </summary>
		private static void ContainerTreeClear()
		{
			// 컨테이너 노드 리스트 초기화
			ContainerNodeList.Clear();
		}

		/// <summary>
		/// 새로운 오브젝트를 컨테이너 노드 리스트에 추가하는 메서드
		/// </summary>
		/// <param name="key">추가할 오브젝트 키</param>
		private static void ContainerNodeListAdd(ObjectBehaviour key)
		{
			// 오브젝트 키가 null인 경우 EmptyObject로 설정
			if(key == null) key = EmptyObject;

			// 컨테이너 노드 리스트에 키가 없는 경우
			if(!ContainerNodeList.ContainsKey(key))
			{
				// 오브젝트의 컨테이너 노드를 가져옴
				ContainerNode _node = key.ThisContainer.ContainerNode;
				if(_node is not null)
				{
					// 노드의 오브젝트가 null인 경우 키로 설정
					if(_node.thisObject == null)
					{
						_node.thisObject = key;
					}
					// 모든 자식 노드를 갱신
					_node.AllRefresh();

					// 컨테이너 노드 리스트에 추가
					ContainerNodeList.Add(key, _node);
				}
			}
		}

		/// <summary>
		/// 특정 오브젝트가 컨테이너 노드 리스트에 있는지 확인하는 메서드
		/// </summary>
		/// <param name="key">확인할 오브젝트 키</param>
		/// <returns>리스트에 존재하면 true, 아니면 false</returns>
		private static bool ContainerNodeListContainsKey(ObjectBehaviour key)
		{
			// 컨테이너 노드가 null이 아닌 경우 true 반환
			return GetContainerNode(key) != null;
		}

		/// <summary>
		/// 특정 오브젝트를 컨테이너 노드 리스트에서 제거하는 메서드
		/// </summary>
		/// <param name="key">제거할 오브젝트 키</param>
		/// <returns>성공적으로 제거되면 true, 아니면 false</returns>
		private static bool ContainerNodeListRemove(ObjectBehaviour key)
		{
			// 오브젝트 키가 null인 경우 EmptyObject로 설정
			if(key == null) key = EmptyObject;
			if(key == null) return true;

			// 컨테이너 노드 리스트에서 제거
			return ContainerNodeList.Remove(key);
		}


		/// <summary>
		/// ContainerNode 클래스는 컨테이너 트리의 각 노드를 나타내며, 
		/// 부모, 자식 오브젝트와 컴포넌트, 데이터 리스트 등을 관리합니다.
		/// </summary>
		[Serializable]
		public class ContainerNode : IDisposable
		{
#if UNITY_EDITOR
			[Flags]
			private enum ShowInspector
			{
				HideAll     = 0,
				ShowComponentAndData = ShowComponent|ShowData,
				ShowObject      = 0b_0001,
				ShowComponent   = 0b_0010,
				ShowData        = 0b_0100,
				ShowType        = 0b_1000,
				ShowAll     = -1,
			}
			[SerializeField,HideLabel]
			private ShowInspector showInspector = ShowInspector.ShowComponent|ShowInspector.ShowData;
			bool ShowObject => (showInspector.HasFlag(ShowInspector.ShowObject));
			bool ShowComponent => (showInspector.HasFlag(ShowInspector.ShowComponent));
			bool ShowData => (showInspector.HasFlag(ShowInspector.ShowData));
			bool ShowType => (showInspector.HasFlag(ShowInspector.ShowType));
#endif
			// 현재 오브젝트
			[ReadOnly, ShowIf("@ShowObject")]
			public ObjectBehaviour thisObject;
			// 부모 오브젝트
			[ReadOnly, ShowIf("@ShowObject")]
			public ObjectBehaviour parent;
			// 자식 오브젝트 배열
			[ReadOnly, SerializeReference, ShowIf("@ShowObject")]
			public ObjectBehaviour[] childs = new ObjectBehaviour[0];

			// 컴포넌트 리스트 배열
			[ReadOnly, SerializeReference, ShowIf("@ShowComponent")]
			public ComponentBehaviour[] componentList = new ComponentBehaviour[0];

			// 데이터 리스트 배열
			[SerializeReference, ShowIf("@ShowData")]
			public DataObject[] dataList = new DataObject[0];

			// 타입 인덱스 배열
			[ReadOnly, ShowInInspector, ShowIf("@ShowType")]
			internal int[] typeIndex = new int[0];
			[ReadOnly, ShowInInspector, ShowIf("@ShowType")]
			internal int[] typeInheritanceIndex = new int[0];

			/// <summary>
			/// 생성자
			/// </summary>
			/// <param name="thisObject">현재 오브젝트</param>
			public ContainerNode(ObjectBehaviour thisObject)
			{
				this.thisObject = thisObject == null ? null : thisObject;
				AllRefresh();
			}

			/// <summary>
			/// IDisposable 인터페이스 구현
			/// </summary>
			void IDisposable.Dispose()
			{
				thisObject = null;
				parent = null;
				childs = null;
				componentList = null;
				dataList = null;
				typeIndex = null;
				typeInheritanceIndex = null;
			}

			/// <summary>
			/// 모든 자식 오브젝트를 리스트에 추가하는 메서드
			/// </summary>
			/// <param name="allList">추가할 리스트</param>
			public void GetAllObjectInChild(ref List<ObjectBehaviour> allList)
			{
				// 현재 오브젝트를 리스트에 추가
				if(thisObject != null) allList.Add(thisObject);

				// 자식 오브젝트들을 순회하며 리스트에 추가
				int count = childs.Length;
				for(int i = 0 ; i < count ; i++)
				{
					ObjectBehaviour child = childs[i];
					if(!reservationDestroyObject.Contains(child))
					{
						GetContainerNode(child)?.GetAllObjectInChild(ref allList);
					}
				}
			}

			/// <summary>
			/// 모든 자식 컴포넌트를 리스트에 추가하는 메서드
			/// </summary>
			/// <param name="allList">추가할 리스트</param>
			public void GetAllComponentInChild(ref List<ComponentBehaviour> allList)
			{
				// 현재 오브젝트의 컴포넌트 리스트를 추가
				if(thisObject != null) allList.AddRange(componentList);

				// 자식 오브젝트들을 순회하며 자식 컴포넌트들을 추가
				int count = childs.Length;
				for(int i = 0 ; i < count ; i++)
				{
					ObjectBehaviour child = childs[i];
					if(!reservationDestroyObject.Contains(child))
					{
						GetContainerNode(child)?.GetAllComponentInChild(ref allList);
					}
				}
			}

			/// <summary>
			/// 모든 속성을 갱신하는 메서드
			/// </summary>
			public void AllRefresh()
			{
				// 오브젝트가 null인 경우 에러 메시지 출력
				if(thisObject == null) Debug.LogError("ContainerNode ThisObject Is Null!");

				// 속성 초기화
				if(parent == null) parent = null;
				if(childs == null) childs = new ObjectBehaviour[0];
				if(componentList == null) componentList = new ComponentBehaviour[0];
				if(dataList == null) dataList = new DataObject[0];
				if(typeIndex == null) typeIndex = new int[0];
				if(typeInheritanceIndex == null) typeInheritanceIndex = new int[0];

				// 부모, 자식, 컴포넌트 갱신
				RefreshParent();
				RefreshChilds();
				RefreshComponents();
				RefreshDatas();
				RefreshTypeIndexs();
			}

			/// <summary>
			/// 부모 오브젝트를 갱신하는 메서드
			/// </summary>
			internal void RefreshParent()
			{
				// 현재 오브젝트가 null인 경우 반환
				if(thisObject is null) return;

				// 새로운 부모 오브젝트를 가져옴
				var newParent = GetParentObjectBehaviour(thisObject);
				parent = newParent;
			}

			/// <summary>
			/// 자식 오브젝트들을 갱신하는 메서드
			/// </summary>
			internal void RefreshChilds()
			{
				// 현재 오브젝트가 null인 경우 반환
				if(thisObject is null) return;

				// 새로운 자식 오브젝트들을 가져옴
				var newChilds = thisObject.GetComponentsInChildren<ObjectBehaviour>(true)
					.Where(item => !reservationDestroyObject.Contains(item))
					.Where(item => item != thisObject);// && GetParentObjectBehaviour(item) == thisObject);

				// 자식 오브젝트 배열로 설정
				childs = newChilds.ToArray();
			}

			/// <summary>
			/// 컴포넌트 리스트를 갱신하는 메서드
			/// </summary>
			internal void RefreshComponents()
			{
				// 현재 오브젝트가 null인 경우 반환
				if(thisObject is null) return;

				// 새로운 컴포넌트 리스트를 가져옴
				var newComponentList = thisObject.GetComponentsInChildren<ComponentBehaviour>(true)
					.Where(item => !reservationDestroyObject.Contains(item))
					.Where(item => GetParentObjectBehaviour(item) == thisObject);

				// 컴포넌트 리스트 배열로 설정
				componentList = newComponentList.ToArray();

				// 컴포넌트 리스트의 길이를 가져옴
				int length = componentList.Length;

				// 컴포넌트 리스트를 순회하며 각 컴포넌트의 ThisObject를 설정
				for(int i = 0 ; i < length ; i++)
				{
					var component = componentList[i];
					component.ThisObject = thisObject;
				}
			}

			/// <summary>
			/// 자식 오브젝트인지 확인하는 메서드
			/// </summary>
			/// <param name="behaviour">확인할 오브젝트</param>
			/// <returns>자식 오브젝트이면 true, 아니면 false</returns>
			public bool IsChildObject(ObjectBehaviour behaviour) => childs != null && Array.IndexOf(childs, behaviour) >= 0;

			/// <summary>
			/// 자식 컴포넌트인지 확인하는 메서드
			/// </summary>
			/// <param name="behaviour">확인할 컴포넌트</param>
			/// <returns>자식 컴포넌트이면 true, 아니면 false</returns>
			public bool IsChildComponent(ComponentBehaviour behaviour) => componentList != null && Array.IndexOf(componentList, behaviour) >= 0;

			/// <summary>
			/// 자식 데이터인지 확인하는 메서드
			/// </summary>
			/// <param name="dataObject">확인할 데이터</param>
			/// <returns>자식 데이터이면 true, 아니면 false</returns>
			public bool IsChildData(DataObject dataObject) => dataList != null && Array.IndexOf(dataList, dataObject) >= 0;

			/// <summary>
			/// 데이터 리스트에 아이템을 추가하는 메서드
			/// </summary>
			/// <param name="item">추가할 데이터</param>
			internal void DataObjectListAdd(DataObject item)
			{
				// 데이터 리스트를 리스트로 변환
				var list = dataList.ToList();

				// 리스트에 아이템이 없는 경우 추가
				if(!list.Contains(item))
				{
					list.Add(item);
					dataList = list.ToArray();
					RefreshTypeIndexs();

#if UNITY_EDITOR
					if(Application.isPlaying)
#endif
						// 데이터 갱신
						OdccManager.UpdateData(thisObject);
				}
			}

			/// <summary>
			/// 데이터 리스트에서 아이템을 제거하는 메서드
			/// </summary>
			/// <param name="item">제거할 데이터</param>
			internal void DataObjectListRemove(DataObject item)
			{
				// 데이터 리스트를 리스트로 변환
				var list = dataList.ToList();

				// 리스트에서 아이템을 제거
				if(list.Remove(item))
				{
					dataList = list.ToArray();
					RefreshTypeIndexs();

#if UNITY_EDITOR
					if(Application.isPlaying)
#endif
						// 데이터 갱신
						OdccManager.UpdateData(thisObject);
				}
			}

			/// <summary>
			/// 모든 속성을 초기화하는 메서드
			/// </summary>
			internal void Clear()
			{
				// 속성 초기화
				childs = new ObjectBehaviour[0];
				componentList = new ComponentBehaviour[0];
				dataList = new DataObject[0];
				typeIndex = new int[0];
				typeInheritanceIndex = new int[0];
			}

			/// <summary>
			/// 부모 노드에서 해당 자식 제거
			/// </summary>
			/// <param name="node">자식 노드</param>
			internal void RemoveFromChildObject(ObjectBehaviour childObj)
			{
				int length = childs.Length;
				if(length == 0) return;


				bool remove = childs[^1] == childObj;
				if(!remove)
				{
					for(int i = 0 ; i < length - 1 ; i++)
					{
						if(!remove && childs[i] == childObj)
						{
							remove = true;
						}
						if(remove)
						{
							childs[i] = childs[i+1];
						}
					}
				}
				if(remove)
				{
					Array.Resize(ref childs, length - 1);
				}
			}
			/// <summary>
			/// 자식 노드에서 부모 노드로 데이터를 추가하는 메서드
			/// </summary>
			/// <param name="node">자식 노드</param>
			internal void AddFromChildToParent(ContainerNode node)
			{
				// 자식 오브젝트, 컴포넌트, 데이터를 부모 노드로 추가
				AddObjectBehaviourFromChildToParent(node.childs);
				AddComponentBehaviourFromChildToParent(node.componentList);
				AddDataObjectFromChildToParent(node.dataList);

				// 타입 인덱스 갱신
				RefreshTypeIndexs();

				void AddObjectBehaviourFromChildToParent(ObjectBehaviour[] childItem)
				{
					// 자식 오브젝트 배열을 리스트로 변환
					var newList = childs.ToList();

					// 리스트에 자식 오브젝트를 추가
					newList.AddRange(childItem);

					// 자식 오브젝트 배열로 설정
					childs = newList.ToArray();
				}

				void AddComponentBehaviourFromChildToParent(ComponentBehaviour[] childItem)
				{
					// 컴포넌트 리스트 배열을 리스트로 변환
					var newList = componentList.ToList();

					// 리스트에 자식 컴포넌트를 추가
					newList.AddRange(childItem);

					// 컴포넌트 리스트 배열로 설정
					componentList = newList.ToArray();

					// 컴포넌트 리스트를 순회하며 각 컴포넌트의 ThisObject를 설정
					int length = componentList.Length;
					for(int i = 0 ; i < length ; i++)
					{
						var component = componentList[i];
						component.ThisObject = thisObject;
					}
				}

				void AddDataObjectFromChildToParent(DataObject[] childItem)
				{
					// 데이터 리스트 배열을 리스트로 변환
					var newList = dataList.ToList();

					// 리스트에 자식 데이터를 추가
					newList.AddRange(childItem);

					// 데이터 리스트 배열로 설정
					dataList = newList.ToArray();
				}
			}

			public void RefreshDatas()
			{
				dataList = dataList.Where(item => item != null).ToArray();
			}
			/// <summary>
			/// 타입 인덱스를 갱신하는 메서드
			/// </summary>
			public void RefreshTypeIndexs()
			{
				// 컴포넌트 리스트 배열의 길이와 데이터 리스트 배열의 길이를 가져옴
				int compCount = componentList.Length;
				int dataCount = dataList.Length;
				int count = 1 + compCount + dataCount;

				// 타입 인덱스 배열을 초기화
				HashSet<int> _typeIndex = new HashSet<int>();
				HashSet<int> _typeInheritanceIndex = new HashSet<int>();

				// 타입 인덱스 배열을 설정
				if(!thisObject.IsCallDestroy)
				{
					_typeIndex.Add(thisObject.OdccTypeIndex);
					_typeInheritanceIndex.AddRange(thisObject.OdccTypeInheritanceIndex);
					for(int i = 0 ; i < dataCount ; i++)
					{
						_typeIndex.Add(dataList[i].OdccTypeIndex);
						_typeInheritanceIndex.AddRange(dataList[i].OdccTypeInheritanceIndex);
					}
				}
				for(int i = 0 ; i < compCount ; i++)
				{
					if(!componentList[i].IsCallDestroy)
					{
						_typeIndex.Add(componentList[i].OdccTypeIndex);
						_typeInheritanceIndex.AddRange(componentList[i].OdccTypeInheritanceIndex);
					}
				}
				typeIndex = _typeIndex.ToArray();
				typeInheritanceIndex = _typeInheritanceIndex.ToArray();
			}
		}

		/// <summary>
		/// 트리를 초기화하는 메서드
		/// </summary>
		internal static void InitTree()
		{
			// 빈 오브젝트를 생성하고 비활성화
			var emptyObj = new GameObject("[EmptyObject]");
			emptyObj.SetActive(false);

			// 빈 오브젝트에 ObjectBehaviour 컴포넌트를 추가하고 EmptyObject로 설정
			EmptyObject = emptyObj.AddComponent<ObjectBehaviour>();

#if UNITY_EDITOR
			if(Application.isPlaying)
#endif
				// 빈 오브젝트가 파괴되지 않도록 설정
				GameObject.DontDestroyOnLoad(EmptyObject.gameObject);

			// 빈 오브젝트를 활성화
			emptyObj.SetActive(true);

			// 컨테이너 트리를 초기화
			ContainerTreeClear();

			// 빈 오브젝트를 컨테이너 노드 리스트에 추가
			ContainerNodeListAdd(EmptyObject);

			// 모든 ObjectBehaviour를 가져옴
			var objects = Object.FindObjectsByType<ObjectBehaviour>(FindObjectsInactive.Include, FindObjectsSortMode.InstanceID);
			List<ObjectBehaviour> rootObjects = new List<ObjectBehaviour>();

			// ObjectBehaviour 배열의 길이를 가져옴
			int count = objects.Length;

			// ObjectBehaviour 배열을 순회하며 루트 오브젝트를 추가
			for(int i = 0 ; i < count ; i++)
			{
				if(EmptyObject == objects[i]) continue;

				ContainerNode _node = objects[i].ThisContainer.ContainerNode;
				if(_node.parent is null)
				{
					rootObjects.Add(objects[i]);
				}
				ContainerNodeListAdd(objects[i]);
			}

			// 빈 오브젝트의 컨테이너 노드를 가져옴
			var node = GetContainerNode(EmptyObject);
			if(node is not null)
			{
				// 빈 오브젝트의 자식 오브젝트 배열로 설정
				node.childs = rootObjects.ToArray();
			}

			// 컨테이너 노드 리스트를 순회하며 모든 노드를 갱신
			foreach(var item in ContainerNodeList)
			{
				var initNode = item.Value;
				initNode.AllRefresh();
			}
		}

		/// <summary>
		/// 트리를 해제하는 메서드
		/// </summary>
		internal static void ReleaseTree()
		{
			// 컨테이너 트리를 초기화
			ContainerTreeClear();

			// 파괴를 무시할 오브젝트 집합을 초기화
			awaitReservationDestroyObject = true;
			reservationDestroyObject.Clear();

			// 빈 오브젝트가 null이 아닌 경우 파괴
			if(EmptyObject != null)
			{
				GameObject.Destroy(EmptyObject.gameObject);
				EmptyObject = null;
			}
		}

		/// <summary>
		/// OCBehaviour를 깨우는 메서드
		/// </summary>
		/// <param name="behaviour">OCBehaviour</param>
		public static bool AwakeOCBehaviour(OCBehaviour behaviour)
		{
			// behaviour가 null인 경우 반환
			if(behaviour == null)
			{
				Debug.LogError("AwakeOCBehaviour: behaviour Is Null");
				return false;
			}

			// 파괴를 무시할 오브젝트 집합에 포함된 경우 반환
			if(reservationDestroyObject.Contains(behaviour))
			{
				Debug.LogError("AwakeOCBehaviour: behaviour Is reservationDestroyObject");
				return false;
			}

			// behaviour가 ObjectBehaviour인 경우 처리
			if(behaviour is ObjectBehaviour @object)
			{
				return AwakeOCBehaviour(@object);
			}

			// behaviour가 ComponentBehaviour인 경우 처리
			if(behaviour is ComponentBehaviour component)
			{
				return AwakeOCBehaviour(component);
			}

			Debug.LogError("AwakeOCBehaviour: behaviour Is Not OCBehaviour");
			return false;
		}

		/// <summary>
		/// OCBehaviour를 파괴하는 메서드
		/// </summary>
		/// <param name="behaviour">OCBehaviour</param>
		public static void DestroyOCBehaviour(OCBehaviour behaviour)
		{
			// behaviour가 null인 경우 반환
			if(behaviour == null) return;

			// 파괴를 예약할 오브젝트 집합에 추가
			awaitReservationDestroyObject = false;
			reservationDestroyObject.Add(behaviour);

			// behaviour가 ObjectBehaviour인 경우 처리
			if(behaviour is ObjectBehaviour @object)
			{
				DestroyOCBehaviour(@object);
			}

			// behaviour가 ComponentBehaviour인 경우 처리
			if(behaviour is ComponentBehaviour component)
			{
				DestroyOCBehaviour(component);
			}
		}

		/// <summary>
		/// OCBehaviour의 부모를 변경하는 메서드
		/// </summary>
		/// <param name="behaviour">OCBehaviour</param>
		/// <returns>변경 성공 시 true, 실패 시 false</returns>
		public static bool ChangeParent(OCBehaviour behaviour)
		{
			// behaviour가 null인 경우 반환
			if(behaviour == null) return false;

			// 파괴를 무시할 오브젝트 집합에 포함된 경우 반환
			if(reservationDestroyObject.Contains(behaviour)) return false;

			// behaviour가 ObjectBehaviour인 경우 처리
			if(behaviour is ObjectBehaviour @object)
			{
				return ChangeParent(@object);
			}

			// behaviour가 ComponentBehaviour인 경우 처리
			if(behaviour is ComponentBehaviour component)
			{
				return ChangeParent(component);
			}

			// 기본 반환값 false
			return false;
		}

		/// <summary>
		/// ObjectBehaviour를 깨우는 메서드
		/// </summary>
		/// <param name="behaviour">ObjectBehaviour</param>
		private static bool AwakeOCBehaviour(ObjectBehaviour behaviour)
		{
			// behaviour가 null이 아닌 경우
			if(behaviour != null && !ContainerNodeListContainsKey(behaviour) && !reservationDestroyObject.Contains(behaviour))
			{
				ContainerNode node = behaviour.ThisContainer.ContainerNode;

				// 컨테이너 노드 리스트에 추가
				ContainerNodeListAdd(behaviour);
				var parent = node.parent;

				// 부모가 null인 경우
				if(parent == null)
				{
					var parentNode = GetContainerNode(parent);
					if(parentNode != null)
					{
						// 자식 리스트에 추가하고 타입 인덱스 갱신
						var list = parentNode.childs.ToList();
						list.Add(behaviour);
						parentNode.childs = list.ToArray();
						parentNode.RefreshTypeIndexs();
					}
				}
				else
				{
					// 부모가 컨테이너 노드 리스트에 없는 경우
					if(!ContainerNodeListContainsKey(parent))
					{
						AwakeOCBehaviour(parent);
					}

					// 부모 노드를 갱신
					var parentNode = GetContainerNode(parent);
					if(parentNode != null)
					{
						parentNode.RefreshChilds();
						parentNode.RefreshComponents();
						parentNode.RefreshTypeIndexs();
					}

					// 자식 노드를 순회하며 갱신
					int count = node.childs.Length;
					for(int i = 0 ; i < count ; i++)
					{
						var child = node.childs[i];
						if(!ContainerNodeListContainsKey(child))
						{
							AwakeOCBehaviour(child);
						}
						var childNode = GetContainerNode(child);
						if(childNode != null)
						{
							childNode.RefreshParent();
							childNode.RefreshTypeIndexs();
						}
					}
				}
			}
			return true;
		}

		/// <summary>
		/// ObjectBehaviour를 파괴하는 메서드
		/// </summary>
		/// <param name="behaviour">ObjectBehaviour</param>
		public static void DestroyOCBehaviour(ObjectBehaviour behaviour)
		{
			// behaviour가 null이 아닌 경우
			if(behaviour != null && ContainerNodeListContainsKey(behaviour))
			{
				var node = GetContainerNode(behaviour);

				// 컨테이너 노드 리스트에서 제거
				ContainerNodeListRemove(behaviour);
				var parentNode = GetContainerNode(node.parent);

				// 부모 노드가 null이 아닌 경우 자식 노드를 부모 노드로 추가
				if(parentNode != null)
				{
					parentNode.RemoveFromChildObject(behaviour);
				}
				else
				{
					node.Clear();
				}

				// 자식 노드를 순회하며 부모를 갱신
				//int childCount = node.childs.Length;
				//for(int i = 0 ; i < childCount ; i++)
				//{
				//	var child = node.childs[i];
				//	if(ContainerNodeListContainsKey(child))
				//	{
				//		var _child = GetContainerNode(child);
				//		if(_child is not null)
				//		{
				//			_child.parent = parentNode?.thisObject;
				//			_child.RefreshTypeIndexs();
				//		}
				//	}
				//}
			}
		}

		/// <summary>
		/// ObjectBehaviour의 부모를 변경하는 메서드
		/// </summary>
		/// <param name="behaviour">ObjectBehaviour</param>
		/// <returns>변경 성공 시 true, 실패 시 false</returns>
		private static bool ChangeParent(ObjectBehaviour behaviour)
		{
			// behaviour가 null이 아닌 경우
			if(behaviour != null && ContainerNodeListContainsKey(behaviour))
			{
				ContainerNode node = GetContainerNode(behaviour);
				var oldParent = node.parent;

				// 부모를 갱신하고 타입 인덱스 갱신
				node.RefreshParent();
				node.RefreshTypeIndexs();
				ObjectBehaviour newParent = node.parent;

				// 부모가 변경되지 않은 경우 false 반환
				if(oldParent == newParent) return false;

				// 기존 부모 노드를 갱신
				if(ContainerNodeListContainsKey(oldParent) && !reservationDestroyObject.Contains(oldParent))
				{
					var oldNode = GetContainerNode(oldParent);
					oldNode.RefreshChilds();
					oldNode.RefreshComponents();
					oldNode.RefreshTypeIndexs();
				}

				// 새로운 부모 노드를 갱신
				if(ContainerNodeListContainsKey(newParent))
				{
					var newNode = GetContainerNode(newParent);
					newNode.RefreshChilds();
					newNode.RefreshComponents();
					newNode.RefreshTypeIndexs();
				}
				return true;
			}
			return false;
		}

		/// <summary>
		/// ComponentBehaviour를 깨우는 메서드
		/// </summary>
		/// <param name="behaviour">ComponentBehaviour</param>
		private static bool AwakeOCBehaviour(ComponentBehaviour behaviour)
		{
			// behaviour가 null인 경우 반환
			if(behaviour == null) return false;

			// 부모 오브젝트를 가져옴
			ObjectBehaviour objectBehaviour = GetParentObjectBehaviour(behaviour);

			// 부모 오브젝트가 컨테이너 노드 리스트에 없는 경우
			if(!ContainerNodeListContainsKey(objectBehaviour))
			{
				AwakeOCBehaviour(objectBehaviour);
			}
			bool isValidation = objectBehaviour.OnAddValidation(behaviour);
			if(!isValidation)
			{
				return false;
			}

			// 부모 오브젝트의 컨테이너 노드를 가져옴
			var node = GetContainerNode(objectBehaviour);

			// 노드가 null이 아니고 자식 컴포넌트가 아닌 경우
			if(node != null && !node.IsChildComponent(behaviour))
			{
				var componentList = node.componentList.ToList();

				// 컴포넌트의 ThisObject를 설정하고 리스트에 추가
				behaviour.ThisObject = node.thisObject;
				componentList.Add(behaviour);
				node.componentList = componentList.ToArray();

				// 타입 인덱스 갱신
				node.RefreshTypeIndexs();
			}

			return true;
		}

		/// <summary>
		/// ComponentBehaviour를 파괴하는 메서드
		/// </summary>
		/// <param name="behaviour">ComponentBehaviour</param>
		private static void DestroyOCBehaviour(ComponentBehaviour behaviour)
		{
			// behaviour가 null인 경우 반환
			if(behaviour == null) return;

			// 부모 오브젝트를 가져옴
			ObjectBehaviour objectBehaviour = GetParentObjectBehaviour(behaviour);

			// 부모 오브젝트가 컨테이너 노드 리스트에 있는 경우
			if(ContainerNodeListContainsKey(objectBehaviour))
			{
				var node = GetContainerNode(objectBehaviour);

				// 노드가 null이 아니고 자식 컴포넌트인 경우
				if(node != null && node.IsChildComponent(behaviour))
				{
					var componentList = node.componentList.ToList();

					// 컴포넌트를 리스트에서 제거하고 배열로 설정
					componentList.Remove(behaviour);
					node.componentList = componentList.ToArray();

					// 타입 인덱스 갱신
					node.RefreshTypeIndexs();
				}
			}
		}

		/// <summary>
		/// ComponentBehaviour의 부모를 변경하는 메서드
		/// </summary>
		/// <param name="behaviour">ComponentBehaviour</param>
		/// <returns>변경 성공 시 true, 실패 시 false</returns>
		private static bool ChangeParent(ComponentBehaviour behaviour)
		{
			// behaviour가 null인 경우 반환
			if(behaviour == null) return false;

			// 기존 부모 오브젝트와 새로운 부모 오브젝트를 가져옴
			var oldObject = behaviour.ThisObject;
			var newObject = GetParentObjectBehaviour(behaviour);

			// 부모가 변경되지 않은 경우 false 반환
			if(oldObject == newObject) return false;

			// 기존 부모 노드를 갱신
			if(ContainerNodeListContainsKey(oldObject) && !reservationDestroyObject.Contains(oldObject))
			{
				var oldNode = GetContainerNode(oldObject);
				if(oldNode != null && oldNode.IsChildComponent(behaviour))
				{
					var componentList = oldNode.componentList.ToList();
					componentList.Remove(behaviour);
					oldNode.componentList = componentList.ToArray();
					oldNode.RefreshTypeIndexs();
				}
			}

			// 새로운 부모 노드를 갱신
			if(ContainerNodeListContainsKey(newObject))
			{
				var newNode = GetContainerNode(newObject);
				if(newNode != null && !newNode.IsChildComponent(behaviour))
				{
					var componentList = newNode.componentList.ToList();
					behaviour.ThisObject = newNode.thisObject;
					componentList.Add(behaviour);
					newNode.componentList = componentList.ToArray();
					newNode.RefreshTypeIndexs();
				}
			}
			return true;
		}

		/// <summary>
		/// ComponentBehaviour의 부모 오브젝트를 가져오는 메서드
		/// </summary>
		/// <param name="item">ComponentBehaviour</param>
		/// <returns>부모 오브젝트</returns>
		private static ObjectBehaviour GetParentObjectBehaviour(ComponentBehaviour item)
		{
			// 부모 오브젝트를 가져옴
			var parent = item.GetComponentInParent<ObjectBehaviour>(true);

			// 부모가 파괴를 무시할 오브젝트 집합에 포함된 경우 재귀 호출
			if(parent != null && reservationDestroyObject.Contains(parent))
			{
				return GetParentObjectBehaviour(parent);
			}
			return parent;
		}

		/// <summary>
		/// ObjectBehaviour의 부모 오브젝트를 가져오는 메서드
		/// </summary>
		/// <param name="item">ObjectBehaviour</param>
		/// <returns>부모 오브젝트</returns>
		private static ObjectBehaviour GetParentObjectBehaviour(ObjectBehaviour item)
		{
			// 부모 오브젝트를 가져옴
			var parent = item.transform.parent == null ? null : item.transform.parent.GetComponentInParent<ObjectBehaviour>(true);

			// 부모가 파괴를 무시할 오브젝트 집합에 포함된 경우 재귀 호출
			if(parent != null && reservationDestroyObject.Contains(parent))
			{
				return GetParentObjectBehaviour(parent);
			}
			return parent;
		}
	}
}
