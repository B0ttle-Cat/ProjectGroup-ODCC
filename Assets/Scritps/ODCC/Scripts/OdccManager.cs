using System.Collections;
using System.Collections.Generic;

using BC.Base;

using UnityEngine;
using UnityEngine.SceneManagement;

namespace BC.ODCC
{
	[DefaultExecutionOrder(ConstInt.FirstExecutionOrder + 1)]
	public sealed partial class OdccManager : MonoSingleton<OdccManager>
	{
		internal Dictionary<int, List<int>> IsAssignableFromList;
		//public Dictionary<OCBehaviour,bool> IsEnableList = new Dictionary<OCBehaviour, bool>();

		protected override void CreatedSingleton()
		{
			SceneManager.sceneUnloaded += SceneManager_sceneUnloaded;
			OdccContainerTree.InitTree();
			OdccForeach.InitForeach();
		}

		private void SceneManager_sceneUnloaded(Scene scene)
		{
			OdccForeach.RemoveLifeItemOdccCollectorList(scene);
		}

		protected override void DestroySingleton()
		{
			OdccContainerTree.ReleaseTree();
			OdccForeach.ReleaseForeach();
			StopAllCoroutines();
		}

		internal static void OdccAwake(OCBehaviour ocBehaviour)
		{
			Instance(Ins => {

				OdccContainerTree.AwakeOCBehaviour(ocBehaviour);
				OdccForeach.AddOdccCollectorList(ocBehaviour);
				EventManager.AddListener(ocBehaviour);

				ocBehaviour.BaseAwake();
				if(ocBehaviour is ObjectBehaviour objectBehaviour)
				{
					OdccContainerTree.ContainerNode containerNode = OdccContainerTree.GetContainerNode(objectBehaviour);

					int Length = containerNode.componentList.Length;
					for(int i = 0 ; i < Length ; i++)
					{
						var component = containerNode.componentList[i];
						if(component.isActiveAndEnabled)
						{
							OdccContainerTree.AwakeOCBehaviour(component);
							OdccForeach.AddOdccCollectorList(component);
							EventManager.AddListener(component);

							component.BaseAwake();
						}
					}
				}
			});
		}
		internal static void OdccDestroy(OCBehaviour ocBehaviour)
		{
			Instance(Ins => {
				ocBehaviour.BaseDestroy();

				OdccContainerTree.DestroyOCBehaviour(ocBehaviour);
				OdccForeach.RemoveOdccCollectorList(ocBehaviour);
				EventManager.RemoveListener(ocBehaviour);
			});
		}
		internal static void OdccEnable(OCBehaviour ocBehaviour)
		{
			Instance(Ins => {
				ocBehaviour.BaseEnable();
			});
		}
		internal static void OdccDisable(OCBehaviour ocBehaviour)
		{
			Instance(Ins => {
				ocBehaviour.BaseDisable();
			});
		}
		internal static void OdccStart(OCBehaviour ocBehaviour)
		{
			Instance(Ins => {
				ocBehaviour.BaseStart();
			});
		}
		internal static void OdccChangeParent(OCBehaviour ocBehaviour)
		{
			Instance(Ins => {
				bool isChangeParent = false;
				if(ocBehaviour is ObjectBehaviour)
				{
					isChangeParent = OdccContainerTree.ChangeParent(ocBehaviour);
				}
				else if(ocBehaviour is ComponentBehaviour componentBehaviour)
				{
					var oldObject = componentBehaviour.ThisObject;
					isChangeParent = OdccContainerTree.ChangeParent(ocBehaviour);
					if(isChangeParent)
					{
						var newObject = componentBehaviour.ThisObject;
						OdccForeach.UpdateObjectInQuery(oldObject);
						OdccForeach.UpdateObjectInQuery(newObject);
					}
				}

				if(isChangeParent)
				{
					ocBehaviour.BaseTransformParentChanged();
				}
			});
		}


		internal static void UpdateData(ObjectBehaviour updateObject)
		{
			Instance(Ins => {
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
