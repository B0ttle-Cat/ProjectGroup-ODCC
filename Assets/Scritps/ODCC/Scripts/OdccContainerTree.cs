using System;
using System.Collections.Generic;
using System.Linq;

using Sirenix.OdinInspector;

using UnityEngine;

using Object = UnityEngine.Object;

namespace BC.ODCC
{
	public static class OdccContainerTree
	{
		private static ObjectBehaviour EmptyObject;
		public static Dictionary<ObjectBehaviour, ContainerNode> ContainerNodeList = new Dictionary<ObjectBehaviour, ContainerNode>();
		public static HashSet<OCBehaviour> IgnoreDestroyObject = new HashSet<OCBehaviour>();

		internal static ContainerNode GetContainerNode(ObjectBehaviour key)
		{
			var node = key == null
				? ContainerNodeList.ContainsKey(EmptyObject) ? ContainerNodeList[EmptyObject] : null
				: ContainerNodeList.ContainsKey(key) ? ContainerNodeList[key] : null;
			return node;
		}

		private static void ContainerTreeClear()
		{
			ContainerNodeList.Clear();
		}

		private static void ContainerNodeListAdd(ObjectBehaviour key)
		{
			if(key == null) key = EmptyObject;
			if(!ContainerNodeList.ContainsKey(key))
			{
				ContainerNode _node = key.ThisContainer.ContainerNode;
				if(_node is not null)
				{
					if(_node.thisObject == null)
					{
						_node.thisObject = key;
					}
					_node.AllUpdate();

					ContainerNodeList.Add(key, _node);
				}
			}
		}
		private static bool ContainerNodeListContainsKey(ObjectBehaviour key)
		{
			return GetContainerNode(key) != null;
		}
		private static bool ContainerNodeListRemove(ObjectBehaviour key)
		{
			if(key == null) key = EmptyObject;
			if(key == null) return true;
			return ContainerNodeList.Remove(key);
		}


		[Serializable]
		public class ContainerNode : IDisposable
		{
			[ReadOnly]
			public ObjectBehaviour thisObject;
			[ReadOnly]
			public ObjectBehaviour parent;
			[ReadOnly, SerializeReference]
			public ObjectBehaviour[] childs = new ObjectBehaviour[0];
			[ReadOnly, SerializeReference]
			public ComponentBehaviour[] componentList = new ComponentBehaviour[0];
			[SerializeReference]
			public DataObject[] dataList = new DataObject[0];
			[ReadOnly, ShowInInspector]
			internal int[] typeIndex = new int[0];

			[HideInInspector] internal Action<ObjectBehaviour>        onUpdateParent;
			[HideInInspector] internal Action<ObjectBehaviour[]>      onUpdateChilds;
			[HideInInspector] internal Action<ComponentBehaviour[]>   onUpdateComponents;
			[HideInInspector] internal Action<DataObject[]>           onUpdateDatas;


			public ContainerNode(ObjectBehaviour thisObject)
			{
				this.thisObject = thisObject == null ? null : thisObject;
				AllUpdate();
			}
			void IDisposable.Dispose()
			{
				thisObject = null;
				parent = null;
				childs = null;
				componentList = null;
				dataList = null;
				typeIndex = null;

				onUpdateParent = null;
				onUpdateChilds = null;
				onUpdateComponents = null;
				onUpdateDatas = null;
			}
			public void GetAllObjectInChild(ref List<ObjectBehaviour> allList)
			{
				if(thisObject != null) allList.Add(thisObject);

				int count = childs.Length;
				for(int i = 0 ; i < count ; i++)
				{
					ObjectBehaviour child = childs[i];
					if(!IgnoreDestroyObject.Contains(child))
					{
						GetContainerNode(child)?.GetAllObjectInChild(ref allList);
					}
				}
			}
			public void GetAllComponentInChild(ref List<ComponentBehaviour> allList)
			{
				if(thisObject != null) allList.AddRange(componentList);

				int count = childs.Length;
				for(int i = 0 ; i < count ; i++)
				{
					ObjectBehaviour child = childs[i];
					if(!IgnoreDestroyObject.Contains(child))
					{
						GetContainerNode(child)?.GetAllComponentInChild(ref allList);
					}
				}
			}
			public void AllUpdate()
			{
				if(thisObject != null)
				{
					onUpdateParent      = thisObject.OdccUpdateParent;
					onUpdateChilds      = thisObject.OdccUpdateChilds;
					onUpdateComponents  = thisObject.OdccUpdateComponents;
					onUpdateDatas       = thisObject.OdccUpdateDatas;
				}

				UpdateParent();
				UpdateChilds();
				UpdateComponents();

				CallUpdateEvent(true, true, true, true);
			}
			internal bool UpdateParent()
			{
				if(thisObject is null) return false;
				var newParent = GetParentObjectBehaviour(thisObject);

				bool isChange = parent != newParent;
				parent = newParent;
				return isChange;
			}
			internal bool UpdateChilds()
			{
				if(thisObject is null) return false;
				var newChilds = thisObject.GetComponentsInChildren<ObjectBehaviour>(true)
						.Where(item => !IgnoreDestroyObject.Contains(item))
						.Where(item => item != thisObject && GetParentObjectBehaviour(item) == thisObject);

				var isEqual = childs.SequenceEqual(newChilds);
				childs = newChilds.ToArray();
				return !isEqual;
			}
			internal bool UpdateComponents()
			{
				if(thisObject is null) return false;
				var newComponentList = thisObject.GetComponentsInChildren<ComponentBehaviour>(true)
					.Where(item => !IgnoreDestroyObject.Contains(item))
					.Where(item => GetParentObjectBehaviour(item) == thisObject);

				var isEqual = componentList.SequenceEqual(newComponentList);
				componentList = newComponentList.ToArray();

				int length = componentList.Length;
				for(int i = 0 ; i < length ; i++)
				{
					var component = componentList[i];
					component.ThisObject = thisObject;
					if(component != null)
					{
						onUpdateParent      += component.OdccUpdateParent;
						onUpdateChilds      += component.OdccUpdateChilds;
						onUpdateComponents  += component.OdccUpdateComponents;
						onUpdateDatas       += component.OdccUpdateDatas;
					}
				}
				return !isEqual;
			}

			public bool IsChildObject(ObjectBehaviour behaviour)
			{
				int count = childs.Length;
				for(int i = 0 ; i < count ; i++)
				{
					var child = childs[i];
					if(child == behaviour)
					{
						return true;
					}
				}
				return false;
			}
			public bool IsChildComponent(ComponentBehaviour behaviour)
			{
				int count = componentList.Length;
				for(int i = 0 ; i < count ; i++)
				{
					var child = componentList[i];
					if(child == behaviour)
					{
						return true;
					}
				}
				return false;
			}
			public bool IsChildData(DataObject dataObject)
			{
				int count = dataList.Length;
				for(int i = 0 ; i < count ; i++)
				{
					var child = dataList[i];
					if(child == dataObject)
					{
						return true;
					}
				}
				return false;
			}


			internal void DataObjectListAdd(DataObject item)
			{
				var list = dataList.ToList();
				if(!list.Contains(item))
				{
					list.Add(item);
					dataList = list.ToArray();

#if UNITY_EDITOR
					if(Application.isPlaying)
#endif
						OdccManager.UpdateData(thisObject);

					CallUpdateEvent(false, false, false, true);
				}
			}
			internal void DataObjectListRemove(DataObject item)
			{
				var list = dataList.ToList();
				if(list.Remove(item))
				{
					dataList = list.ToArray();
#if UNITY_EDITOR
					if(Application.isPlaying)
#endif
						OdccManager.UpdateData(thisObject);

					CallUpdateEvent(false, false, false, true);
				}
			}

			internal void Clear()
			{
				childs = new ObjectBehaviour[0];
				componentList = new ComponentBehaviour[0];
				dataList = new DataObject[0];
			}



			internal void AddFromChildToParent(ContainerNode node)
			{
				if(thisObject != null)
				{
					onUpdateParent      = thisObject.OdccUpdateParent;
					onUpdateChilds      = thisObject.OdccUpdateChilds;
					onUpdateComponents  = thisObject.OdccUpdateComponents;
					onUpdateDatas       = thisObject.OdccUpdateDatas;
				}

				bool changeChild = AddObjectBehaviourFromChildToParent(node.childs);
				bool changeComponent = AddComponentBehaviourFromChildToParent(node.componentList);
				bool changeData = AddDataObjectFromChildToParent(node.dataList);

				CallUpdateEvent(false, changeChild, changeComponent, changeData);

				bool AddObjectBehaviourFromChildToParent(ObjectBehaviour[] childItem)
				{
					var newList = childs.ToList();
					newList.AddRange(childItem);

					var isEqual = childs.SequenceEqual(newList);
					childs = newList.ToArray();

					return isEqual;
				}

				bool AddComponentBehaviourFromChildToParent(ComponentBehaviour[] childItem)
				{
					var newList = componentList.ToList();
					newList.AddRange(childItem);

					var isEqual = componentList.SequenceEqual(newList);
					componentList = newList.ToArray();

					int length = componentList.Length;
					for(int i = 0 ; i < length ; i++)
					{
						var component = componentList[i];
						component.ThisObject = thisObject;
						if(component != null)
						{
							onUpdateParent      += component.OdccUpdateParent;
							onUpdateChilds      += component.OdccUpdateChilds;
							onUpdateComponents  += component.OdccUpdateComponents;
							onUpdateDatas       += component.OdccUpdateDatas;
						}
					}
					return isEqual;
				}

				bool AddDataObjectFromChildToParent(DataObject[] childItem)
				{
					var newList = dataList.ToList();
					newList.AddRange(childItem);

					var isEqual = dataList.SequenceEqual(newList);
					dataList = newList.ToArray();

					return isEqual;
				}
			}

			public void CallUpdateEvent(bool parent, bool childs, bool componentList, bool dataList)
			{
				if(parent || childs || componentList || dataList)
				{
					TypeIndexUpdate();
					if(parent) onUpdateParent?.Invoke(this.parent);
					if(childs) onUpdateChilds?.Invoke(this.childs);
					if(componentList) onUpdateComponents?.Invoke(this.componentList);
					if(dataList) onUpdateDatas?.Invoke(this.dataList);
				}

			}
			public void TypeIndexUpdate()
			{
				int compCount = componentList.Length;
				int dataCount = dataList.Length;
				int count = 1 + compCount + dataCount;

				typeIndex = new int[count];

				typeIndex[0] = thisObject.OdccTypeIndex;
				for(int i = 0 ; i < compCount ; i++)
				{
					typeIndex[1 + i] = componentList[i].OdccTypeIndex;
				}
				for(int i = 0 ; i < dataCount ; i++)
				{
					typeIndex[1 + compCount] = dataList[i].OdccTypeIndex;
				}
			}
		}

		internal static void InitTree()
		{
			var emptyObj = new GameObject("[EmptyObject]");
			emptyObj.SetActive(false);
			EmptyObject = emptyObj.AddComponent<ObjectBehaviour>();
#if UNITY_EDITOR
			if(Application.isPlaying)
#endif
				GameObject.DontDestroyOnLoad(EmptyObject.gameObject);
			emptyObj.SetActive(true);

			ContainerTreeClear();
			ContainerNodeListAdd(EmptyObject);

			var objects = Object.FindObjectsByType<ObjectBehaviour>(FindObjectsInactive.Include, FindObjectsSortMode.InstanceID);
			List<ObjectBehaviour> rootObjects = new List<ObjectBehaviour>();
			int count = objects.Length;
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
			var node = GetContainerNode(EmptyObject);
			if(node is not null)
			{
				node.childs = rootObjects.ToArray();
			}

			foreach(var item in ContainerNodeList)
			{
				var initNode = item.Value;
				initNode.AllUpdate();
			}
		}

		internal static void ReleaseTree()
		{
			ContainerTreeClear();
			IgnoreDestroyObject.Clear();

			if(EmptyObject != null)
			{
				GameObject.Destroy(EmptyObject.gameObject);
				EmptyObject = null;
			}
		}

		public static void AwakeOCBehaviour(OCBehaviour behaviour)
		{
			if(behaviour == null) return;

			if(IgnoreDestroyObject.Contains(behaviour)) return;

			if(behaviour is ObjectBehaviour @object)
			{
				AwakeOCBehaviour(@object);
			}
			if(behaviour is ComponentBehaviour component)
			{
				AwakeOCBehaviour(component);
			}
		}
		public static void DestroyOCBehaviour(OCBehaviour behaviour)
		{
			if(behaviour == null) return;

			IgnoreDestroyObject.Add(behaviour);

			if(behaviour is ObjectBehaviour @object)
			{
				DestroyOCBehaviour(@object);
			}
			if(behaviour is ComponentBehaviour component)
			{
				DestroyOCBehaviour(component);
			}
		}
		public static bool ChangeParent(OCBehaviour behaviour)
		{
			if(behaviour == null) return false;

			if(IgnoreDestroyObject.Contains(behaviour)) return false;

			if(behaviour is ObjectBehaviour @object)
			{
				return ChangeParent(@object);
			}
			if(behaviour is ComponentBehaviour component)
			{
				return ChangeParent(component);
			}
			return false;
		}

		private static void AwakeOCBehaviour(ObjectBehaviour behaviour)
		{
			if(behaviour != null && !ContainerNodeListContainsKey(behaviour) && !IgnoreDestroyObject.Contains(behaviour))
			{
				ContainerNode node = behaviour.ThisContainer.ContainerNode;
				ContainerNodeListAdd(behaviour);
				var parent = node.parent;
				if(parent == null)
				{
					var parentNode = GetContainerNode(parent);
					if(parentNode != null)
					{
						var list = parentNode.childs.ToList();
						list.Add(behaviour);
						parentNode.childs = list.ToArray();
						parentNode?.onUpdateChilds(parentNode.childs);
					}
				}
				else
				{
					if(!ContainerNodeListContainsKey(parent))
					{
						AwakeOCBehaviour(parent);
					}
					var parentNode = GetContainerNode(parent);
					if(parentNode != null)
					{
						bool isUpdateChilds = parentNode.UpdateChilds();
						bool isUpdateComponents = parentNode.UpdateComponents();
						parentNode.CallUpdateEvent(false, isUpdateChilds, isUpdateComponents, false);
					}
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
							if(childNode.UpdateParent())
							{
								childNode.CallUpdateEvent(true, false, false, false);
							}
						}
					}
				}
			}
		}
		public static void DestroyOCBehaviour(ObjectBehaviour behaviour)
		{
			if(behaviour != null && ContainerNodeListContainsKey(behaviour))
			{
				var node = GetContainerNode(behaviour);
				ContainerNodeListRemove(behaviour);
				var parentNode = GetContainerNode(node.parent);


				if(parentNode != null)
				{
					parentNode.AddFromChildToParent(node);
				}
				else
				{
					node.Clear();
				}

				int childCount = node.childs.Length;
				for(int i = 0 ; i < childCount ; i++)
				{
					var child = node.childs[i];
					if(ContainerNodeListContainsKey(child))
					{
						var _child = GetContainerNode(child);
						if(_child is not null)
						{
							_child.parent = parentNode?.thisObject;
							_child.onUpdateParent(_child.parent);
						}
					}
				}
			}
		}
		private static bool ChangeParent(ObjectBehaviour behaviour)
		{
			if(behaviour != null && ContainerNodeListContainsKey(behaviour))
			{
				ContainerNode node = GetContainerNode(behaviour);
				var oldParent = node.parent;
				if(node.UpdateParent())
				{
					node.CallUpdateEvent(true, false, false, false);
				}
				ObjectBehaviour newParent = node.parent;
				if(oldParent == newParent) return false;


				if(ContainerNodeListContainsKey(oldParent) && !IgnoreDestroyObject.Contains(oldParent))
				{
					var oldNode = GetContainerNode(oldParent);
					bool isUpdateChilds = oldNode.UpdateChilds();
					bool isUpdateComponents = oldNode.UpdateComponents();
					oldNode.CallUpdateEvent(false, isUpdateChilds, isUpdateComponents, false);
				}
				if(ContainerNodeListContainsKey(newParent))
				{
					var newNode = GetContainerNode(newParent);
					bool isUpdateChilds = newNode.UpdateChilds();
					bool isUpdateComponents = newNode.UpdateComponents();
					newNode.CallUpdateEvent(false, isUpdateChilds, isUpdateComponents, false);
				}
				return true;
			}
			return false;
		}

		private static void AwakeOCBehaviour(ComponentBehaviour behaviour)
		{
			if(behaviour == null) return;

			ObjectBehaviour objectBehaviour = GetParentObjectBehaviour(behaviour);
			if(!ContainerNodeListContainsKey(objectBehaviour))
			{
				AwakeOCBehaviour(objectBehaviour);
			}

			var node = GetContainerNode(objectBehaviour);

			if(node != null && !node.IsChildComponent(behaviour))
			{
				var componentList = node.componentList.ToList();
				behaviour.ThisObject = node.thisObject;
				componentList.Add(behaviour);
				node.componentList = componentList.ToArray();
				node.onUpdateComponents?.Invoke(node.componentList);
			}
		}
		private static void DestroyOCBehaviour(ComponentBehaviour behaviour)
		{
			if(behaviour == null) return;

			ObjectBehaviour objectBehaviour = GetParentObjectBehaviour(behaviour);
			if(ContainerNodeListContainsKey(objectBehaviour))
			{
				var node = GetContainerNode(objectBehaviour);

				if(node != null && node.IsChildComponent(behaviour))
				{
					var componentList = node.componentList.ToList();
					componentList.Remove(behaviour);
					node.componentList = componentList.ToArray();
					node.onUpdateComponents?.Invoke(node.componentList);
				}
			}
		}
		private static bool ChangeParent(ComponentBehaviour behaviour)
		{
			if(behaviour == null) return false;
			var oldObject = behaviour.ThisObject;
			var newObject = GetParentObjectBehaviour(behaviour);
			if(oldObject == newObject) return false;


			if(ContainerNodeListContainsKey(oldObject) && !IgnoreDestroyObject.Contains(oldObject))
			{
				var oldNode = GetContainerNode(oldObject);
				if(oldNode != null && oldNode.IsChildComponent(behaviour))
				{
					var componentList = oldNode.componentList.ToList();
					componentList.Remove(behaviour);
					oldNode.componentList = componentList.ToArray();
					oldNode.onUpdateComponents?.Invoke(oldNode.componentList);
				}
			}
			if(ContainerNodeListContainsKey(newObject))
			{
				var newNode = GetContainerNode(newObject);
				if(newNode != null && !newNode.IsChildComponent(behaviour))
				{
					var componentList = newNode.componentList.ToList();
					behaviour.ThisObject = newNode.thisObject;
					componentList.Add(behaviour);
					newNode.componentList = componentList.ToArray();
					newNode.onUpdateComponents?.Invoke(newNode.componentList);
				}
			}
			return true;
		}


		private static ObjectBehaviour GetParentObjectBehaviour(ComponentBehaviour item)
		{
			var  parent = item.GetComponentInParent<ObjectBehaviour>(true);
			if(parent != null && IgnoreDestroyObject.Contains(parent))
			{
				return GetParentObjectBehaviour(parent);
			}
			return parent;
		}
		private static ObjectBehaviour GetParentObjectBehaviour(ObjectBehaviour item)
		{
			var  parent = item.transform.parent == null ? null : item.transform.parent.GetComponentInParent<ObjectBehaviour>(true);
			if(parent  != null && IgnoreDestroyObject.Contains(parent))
			{
				return GetParentObjectBehaviour(parent);
			}
			return parent;
		}

	}
}
