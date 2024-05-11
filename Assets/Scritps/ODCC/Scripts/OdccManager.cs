using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using BC.Base;

using UnityEngine;

using Debug = BC.Base.Debug;

namespace BC.ODCC
{
	[DefaultExecutionOrder(ConstInt.FirstExecutionOrder + 1)]
	public sealed class OdccManager : MonoSingleton<OdccManager>
	{
		private Type[] typeList;
		public List<ObjectBehaviour> OdccObjectList = new List<ObjectBehaviour>();
		public List<DataObject> OdccDataList = new List<DataObject>();
		public List<ComponentBehaviour> OdccComponentList = new List<ComponentBehaviour>();

		public Dictionary<OCBehaviour,bool> IsEnableList = new Dictionary<OCBehaviour, bool>();

		protected override void CreatedSingleton()
		{
			typeList = AppDomain.CurrentDomain.GetAssemblies().SelectMany((i) => i.GetTypes())
							.Where(t => typeof(IOdccItem).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract && !t.IsInterface)
							.ToArray();
			Debug.Log($"QuerySystem Type Binding\n\t{string.Join("\n\t", typeList.Select((t) => t.FullName))}");

			OdccObjectList = new List<ObjectBehaviour>();
			OdccDataList = new List<DataObject>();
			OdccComponentList = new List<ComponentBehaviour>();
			IsEnableList = new Dictionary<OCBehaviour, bool>();
			OdccContainerTree.InitTree();
			OdccForeach.InitForeach();
		}
		protected override void DestroySingleton()
		{
			OdccObjectList.Clear();
			OdccDataList.Clear();
			OdccComponentList.Clear();
			OdccContainerTree.ReleaseTree();
			OdccForeach.ReleaseForeach();
			StopAllCoroutines();
		}
		public static int GetTypeToIndex(Type type)
		{
			return Instance(Ins =>
			{
				Type[] allType = Ins.typeList;
				int count = allType.Length;
				for(int i = 0 ; i < count ; i++)
				{
					if(type.Equals(allType[i]))
					{
						return i;
					}
				}
				return -1;
			});
		}
		public static Type GetIndexToType(int index)
		{
			return Instance(Ins =>
			{
				return index <= 0 ? Ins.typeList[index] : null; ;
			});
		}
		public static int[] GetTypeToIndex(params Type[] types)
		{
			return GetListTypeToIndex(types);
		}
		public static Type[] GetIndexToType(params int[] indexs)
		{
			return GetListIndexToType(indexs);
		}
		public static int[] GetListTypeToIndex(IEnumerable<Type> types)
		{
			return Instance(Ins =>
			{
				int count1 = types.Count();
				int[] result = new int[count1];

				Type[] allType = Ins.typeList;
				int count2 = allType.Length;

				int i = 0;
				foreach(var type in types)
				{
					result[i] = -1;
					for(int ii = 0 ; ii < count2 ; ii++)
					{
						if(type.Equals(allType[ii]))
						{
							result[i] = ii;
							break;
						}
					}
					i++;
				}
				return result;
			});
		}
		public static Type[] GetListIndexToType(IEnumerable<int> indexs)
		{
			return Instance(Ins =>
			{
				int count1 = indexs.Count();
				Type[] result = new Type[count1];
				Type[] allType = Ins.typeList;

				foreach(var index in indexs)
				{
					result[index] = index <= 0 ? allType[index] : null;
				}
				return result;
			});
		}

		internal static void OdccAwake(OCBehaviour ocBehaviour)
		{
			Instance(Ins =>
			{
				if(ocBehaviour is ObjectBehaviour objectBehaviour)
				{
					Ins.OdccAwake(Ins.OdccObjectList, objectBehaviour);

					OdccContainerTree.ContainerNode containerNode = OdccContainerTree.GetContainerNode(objectBehaviour);

					int Length = containerNode.componentList.Length;
					for(int i = 0 ; i < Length ; i++)
					{
						var component = containerNode.componentList[i];
						if(component.isActiveAndEnabled)
						{
							Ins.OdccAwake(Ins.OdccComponentList, component);
						}
					}
				}
				else if(ocBehaviour is ComponentBehaviour componentBehaviour)
				{
					Ins.OdccAwake(Ins.OdccComponentList, componentBehaviour);
				}
			});
		}
		internal static void OdccDestroy(OCBehaviour ocBehaviour)
		{
			Instance(Ins =>
			{
				if(ocBehaviour is ObjectBehaviour objectBehaviour)
				{
					Ins.OdccDestroy(Ins.OdccObjectList, objectBehaviour);
				}
				else if(ocBehaviour is ComponentBehaviour componentBehaviour)
				{
					Ins.OdccDestroy(Ins.OdccComponentList, componentBehaviour);
				}
			});
		}
		internal static void OdccEnable(OCBehaviour ocBehaviour)
		{
			Instance(Ins =>
			{
				if(ocBehaviour is ObjectBehaviour objectBehaviour)
				{
					Ins.OdccEnable(Ins.OdccObjectList, objectBehaviour);
				}
				else if(ocBehaviour is ComponentBehaviour componentBehaviour)
				{
					Ins.OdccEnable(Ins.OdccComponentList, componentBehaviour);
				}
			});
		}
		internal static void OdccDisable(OCBehaviour ocBehaviour)
		{
			Instance(Ins =>
			{
				if(ocBehaviour is ObjectBehaviour objectBehaviour)
				{
					Ins.OdccDisable(Ins.OdccObjectList, objectBehaviour);
				}
				else if(ocBehaviour is ComponentBehaviour componentBehaviour)
				{
					Ins.OdccDisable(Ins.OdccComponentList, componentBehaviour);
				}
			});
		}
		internal static void OdccStart(OCBehaviour ocBehaviour)
		{
			Instance(Ins =>
			{
				if(ocBehaviour is ObjectBehaviour objectBehaviour)
				{
					Ins.OdccStart(Ins.OdccObjectList, objectBehaviour);
				}
				else if(ocBehaviour is ComponentBehaviour componentBehaviour)
				{
					Ins.OdccStart(Ins.OdccComponentList, componentBehaviour);
				}
			});
		}
		internal static void OdccChangeParent(OCBehaviour ocBehaviour)
		{
			Instance(Ins =>
			{
				if(ocBehaviour is ObjectBehaviour objectBehaviour)
				{
					Ins.OdccChangeParent(Ins.OdccObjectList, objectBehaviour);
				}
				else if(ocBehaviour is ComponentBehaviour componentBehaviour)
				{
					Ins.OdccChangeParent(Ins.OdccComponentList, componentBehaviour);
				}
			});
		}
		private void OdccAwake<T>(List<T> list, T item) where T : OCBehaviour
		{
			if(!list.Contains(item))
			{
				list.Add(item);

				OdccContainerTree.AwakeOCBehaviour(item);
				OdccForeach.AddOdccCollectorList(item);
				EventManager.AddListener(item);

				item.BaseAwake();
			}
		}
		private void OdccDestroy<T>(List<T> list, T item) where T : OCBehaviour
		{
			if(list.Contains(item))
			{
				list.Remove(item);
				item.BaseDestroy();

				OdccContainerTree.DestroyOCBehaviour(item);
				OdccForeach.RemoveOdccCollectorList(item);
				EventManager.RemoveListener(item);
			}
		}
		private void OdccEnable<T>(List<T> list, T behaviour) where T : OCBehaviour
		{
			if(list.Contains(behaviour))
			{
				behaviour.BaseEnable();
			}
		}
		private void OdccDisable<T>(List<T> list, T behaviour) where T : OCBehaviour
		{
			if(list.Contains(behaviour))
			{
				behaviour.BaseDisable();
			}
		}
		private void OdccStart<T>(List<T> list, T behaviour) where T : OCBehaviour
		{
			if(list.Contains(behaviour))
			{
				behaviour.BaseStart();
			}
		}
		private void OdccChangeParent<T>(List<T> list, T behaviour) where T : OCBehaviour
		{
			if(list.Contains(behaviour))
			{
				bool isChangeParent = false;
				if(behaviour is ObjectBehaviour @object)
				{
					isChangeParent = OdccContainerTree.ChangeParent(behaviour);
				}
				else if(behaviour is ComponentBehaviour component)
				{
					var oldObject = component.ThisObject;
					isChangeParent = OdccContainerTree.ChangeParent(behaviour);

					if(isChangeParent)
					{
						var newObject = component.ThisObject;
						OdccForeach.UpdateObjectInQuery(oldObject);
						OdccForeach.UpdateObjectInQuery(newObject);
					}
				}


				if(isChangeParent)
				{
					behaviour.BaseTransformParentChanged();
				}
			}
		}
		internal static void UpdateData(ObjectBehaviour updateObject)
		{
			Instance(Ins =>
			{
				OdccForeach.UpdateObjectInQuery(updateObject);
			});
		}

		static public bool isProfilerEnabled = false;
		public void Start()
		{
			StartCoroutine(EndOfFrame());
		}
		public void Update()
		{
#if UNITY_EDITOR
			isProfilerEnabled = UnityEngine.Profiling.Profiler.enabled;
#else
			isProfilerEnabled = false;
#endif
			OdccForeach.ForeachUpdate();
		}
		public void LateUpdate()
		{
			OdccForeach.ForeachLateUpdate();
		}

		IEnumerator EndOfFrame()
		{
			var waitFrame = new WaitForEndOfFrame();
			while(true)
			{
				yield return waitFrame;
				int count = OdccContainerTree.IgnoreDestroyObject.Count;
				if(count > 0)
				{
					foreach(var item in OdccContainerTree.IgnoreDestroyObject)
					{
						item.Dispose();
					}
					OdccContainerTree.IgnoreDestroyObject.Clear();
				}
			}
		}
	}
}
