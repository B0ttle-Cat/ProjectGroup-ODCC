using System;
using System.Collections.Generic;
using System.Linq;

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
		public static Dictionary<IOdccObject, ContainerNode> ContainerNodeList = new Dictionary<IOdccObject, ContainerNode>();

		/// <summary>
		/// 특정 오브젝트에 대한 컨테이너 노드를 가져오는 메서드
		/// </summary>
		/// <param name="key">오브젝트 키</param>
		/// <returns>해당 오브젝트의 컨테이너 노드</returns>
		internal static ContainerNode GetContainerNode(IOdccObject key)
		{
			return ContainerNodeList.TryGetValue(key??EmptyObject, out var keyNode) ? keyNode : null;
		}
		internal static ContainerNode GetContainerNode(IOdccComponent component)
		{
			return GetContainerNode(component.ThisObject);
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
		private static ContainerNode CreateContainerNode(IOdccObject key)
		{
			// 오브젝트 키가 null인 경우 EmptyObject로 설정
			if(key == null) key = EmptyObject;

			// 컨테이너 노드 리스트에 키가 없는 경우
			if(!ContainerNodeList.TryGetValue(key, out var value))
			{
				// 오브젝트의 컨테이너 노드를 가져옴
				try
				{
					ContainerNode node = key.ThisContainer.ContainerNode ??= new ContainerNode(key);
					node.thisObject = key;

					ContainerNodeList.Add(key, node);
					value = node;
				}
				catch(Exception ex)
				{
					Debug.LogError(key.DetailLog());

					Debug.LogException(ex);
				}
			}
			return value;
		}

		/// <summary>
		/// 특정 오브젝트가 컨테이너 노드 리스트에 있는지 확인하는 메서드
		/// </summary>
		/// <param name="key">확인할 오브젝트 키</param>
		/// <returns>리스트에 존재하면 true, 아니면 false</returns>
		private static bool ContainerNodeListContainsKey(IOdccObject key)
		{
			// 컨테이너 노드가 null이 아닌 경우 true 반환
			return GetContainerNode(key) != null;
		}

		/// <summary>
		/// 특정 오브젝트를 컨테이너 노드 리스트에서 제거하는 메서드
		/// </summary>
		/// <param name="key">제거할 오브젝트 키</param>
		/// <returns>성공적으로 제거되면 true, 아니면 false</returns>
		private static bool ContainerNodeListRemove(IOdccObject key)
		{
			// 오브젝트 키가 null인 경우 EmptyObject로 설정
			if(key == null) return false;
			if((IOdccObject)EmptyObject == key) return false;

			// 컨테이너 노드 리스트에서 제거

			if(ContainerNodeList.TryGetValue(key, out ContainerNode node))
			{
				(node as IDisposable).Dispose();
				ContainerNodeList.Remove(key);
			}
			return true;
		}

		/// <summary>
		/// 특정 오브젝트가 파괴가 예약된 경우를 판단하는 메서드
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		private static bool ContainerNodeListDestroyObject(IOCBehaviour key)
		{
			return OdccManager.reservationDestroyObject.Contains(key);
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
			var emptyContainerNode = CreateContainerNode(EmptyObject);

			// 모든 ObjectBehaviour를 가져옴
			var objects = Object.FindObjectsByType<ObjectBehaviour>(FindObjectsInactive.Include, FindObjectsSortMode.InstanceID);
			var rootObjects = objects.Where(i => i.transform.parent ==null ? true : i.transform.parent.GetComponentInParent<ObjectBehaviour>() == null);
			foreach(var item in rootObjects)
			{
				item.Awake();
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
			OdccManager.awaitReservationDestroyObject = true;
			OdccManager.reservationDestroyObject.Clear();

			// 빈 오브젝트가 null이 아닌 경우 파괴
			if(EmptyObject != null)
			{
				GameObject.Destroy(EmptyObject.gameObject);
				EmptyObject = null;
			}
		}

		public static bool CreateAndConnectSelfContainerNode(IOCBehaviour behaviour, out ContainerNode containerNode)
		{
			containerNode = null;
			if(behaviour == null) return false;
			if(ContainerNodeListDestroyObject(behaviour)) return false;

			if(behaviour is IOdccObject @object)
			{
				var thisContainerNode = GetContainerNode(@object);
				if(thisContainerNode == null)
				{
					thisContainerNode = CreateContainerNode(@object);
				}
				if(thisContainerNode != null)
				{
					thisContainerNode.thisObject = @object;

					containerNode = thisContainerNode;
					@object.CreateThisContainer(thisContainerNode);
					return true;
				}
			}
			else if(behaviour is IOdccComponent component)
			{
				var _object = component.ThisMono.GetComponentInParent<ObjectBehaviour>(true);
				if(_object == null)
				{
					Debug.LogError("이게 호출되면, 올바르지 않은 위치에 생성된 거임!");
					_object = EmptyObject;
				}
				var thisContainerNode = GetContainerNode(_object);
				if(thisContainerNode == null)
				{
					Debug.LogError("예상컨대, 호출돼서는 안됨!");
					thisContainerNode = CreateContainerNode(_object);
					thisContainerNode.thisObject = _object;
				}

				containerNode = thisContainerNode;
				component.ConnectThisObject(thisContainerNode);
				return true;
			}
			return false;
		}
		public static void RemoveAndReleaseSelfContainerNode(IOdccObject @object)
		{
			ContainerNodeListRemove(@object);
		}
		public static void RemoveAndReleaseSelfContainerNode(ContainerNode node, List<IOdccComponent> components)
		{
			node.RemoveItems(components);
		}
	}
}
