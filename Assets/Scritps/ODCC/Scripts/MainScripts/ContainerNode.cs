using System;
using System.Collections.Generic;
using System.Linq;

using Sirenix.OdinInspector;
using Sirenix.Utilities;

using UnityEngine;

namespace BC.ODCC
{
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
		[SerializeField, HideLabel]
		private ShowInspector showInspector = ShowInspector.ShowComponent|ShowInspector.ShowData;
		bool ShowObject => (showInspector.HasFlag(ShowInspector.ShowObject));
		bool ShowComponent => (showInspector.HasFlag(ShowInspector.ShowComponent));
		bool ShowData => (showInspector.HasFlag(ShowInspector.ShowData));
		bool ShowType => (showInspector.HasFlag(ShowInspector.ShowType));
#endif
		private List<IOdccItem> initOdccItem;

		// 현재 오브젝트
		[ReadOnly, ShowIf("@ShowObject")]
		public IOdccObject thisObject;
		// 부모 오브젝트
		[ReadOnly, ShowIf("@ShowObject")]
		public IOdccObject parent;
		// 자식 오브젝트 배열

		[ReadOnly, ShowInInspector, ShowIf("@ShowObject")]
		public List<IOdccObject> children = new List<IOdccObject>();

		// 컴포넌트 리스트 배열
		[ReadOnly, ShowInInspector, ShowIf("@ShowComponent")]
		public List<IOdccComponent> components = new List < IOdccComponent >();

		// 데이터 리스트 배열
		[SerializeReference, ShowIf("@ShowData")]
		public List<IOdccData> datas = new List < IOdccData >();

		// 타입 인덱스 배열
		[ReadOnly, ShowInInspector, ShowIf("@ShowType")]
		[ValueDropdown("ShowTypeText")]
		internal List<int> typeIndex = new List<int>();

		/// <summary>
		/// 생성자
		/// </summary>
		/// <param name="thisObject">현재 오브젝트</param>
		public ContainerNode(IOdccObject thisObject)
		{
			this.thisObject = thisObject;

			initOdccItem = null;

			children = new List<IOdccObject>();
			components = new List<IOdccComponent>();
			datas = new List<IOdccData>();
			typeIndex = new List<int>();
		}

		/// <summary>
		/// IDisposable 인터페이스 구현
		/// </summary>
		void IDisposable.Dispose()
		{
			thisObject = null;
			parent = null;
			children = null;
			components = null;
			datas = null;
			typeIndex = null;
		}


		internal void AddInit(IOdccItem target)
		{
			if(initOdccItem == null) initOdccItem = new List<IOdccItem>();
			if(initOdccItem.Contains(target)) return;
			initOdccItem.Add(target);
		}
		internal void RemoveInit(IOdccItem target)
		{
			if(initOdccItem == null) return;
			initOdccItem.Remove(target);
		}
		internal void ClearInit()
		{
			if(initOdccItem == null) return;
			initOdccItem.Clear();
			initOdccItem = null;
		}
		internal void CurrentInit()
		{
			if(initOdccItem == null) initOdccItem = new List<IOdccItem>();
			if(thisObject != null) initOdccItem.Add(thisObject);
			if(parent != null) initOdccItem.Add(parent);
			if(children != null && children.Count > 0) initOdccItem.AddRange(children);
			if(components != null && components.Count > 0) initOdccItem.AddRange(components);
			if(datas != null && datas.Count > 0) initOdccItem.AddRange(datas);
		}
		internal void UpdateInit()
		{
			if(initOdccItem == null) return;

			int length = initOdccItem.Count;

			Action addInList = null;
			int resize_children = 0;
			int resize_component = 0;
			int resize_data = 0;

			for(int i = 0 ; i < length ; i++)
			{
				var target = initOdccItem[i];
				if(target == null) continue;

				if(target is IOdccObject _object)
				{
					if(thisObject == _object || parent == _object) continue;

					int index = resize_children;
					addInList += () => children[index] = _object;
					resize_children++;
				}
				else if(target is IOdccComponent component)
				{
					int index = resize_component;
					addInList += () => components[index] = component;
					resize_component++;
				}
				else if(target is IOdccData data)
				{
					int index = resize_data;
					addInList += () => datas[index] = data;
					resize_data++;
				}
			}

			children = new List<IOdccObject>(new IOdccObject[resize_children]);
			components = new List<IOdccComponent>(new IOdccComponent[resize_component]);
			datas = new List<IOdccData>(new IOdccData[resize_data]);

			addInList?.Invoke();

			initOdccItem.Clear();
			initOdccItem = null;

			TypeIndexUpdate();
		}

		internal void AddItem(IOdccObject target)
		{
			AddItem(ref children, target);
		}
		internal void AddItems(List<IOdccObject> targets)
		{
			AddItems(ref children, targets);
		}
		internal void RemoveItem(IOdccObject target)
		{
			RemoveItem(ref children, target);
		}
		internal void RemoveItems(List<IOdccObject> targets)
		{
			RemoveItems(ref children, targets);
		}

		internal void AddItem(IOdccComponent target)
		{
			AddItem(ref components, target);
		}
		internal void AddItems(List<IOdccComponent> targets)
		{
			AddItems(ref components, targets);
		}
		internal void RemoveItem(IOdccComponent target)
		{
			RemoveItem(ref components, target);
		}
		internal void RemoveItems(List<IOdccComponent> targets)
		{
			RemoveItems(ref components, targets);
		}

		internal void AddItem(IOdccData target)
		{
			if(AddItem(ref datas, target))
			{
				OdccManager.UpdateQuery(thisObject);
			}
		}
		internal void AddItems(List<IOdccData> targets)
		{
			if(AddItems(ref datas, targets))
			{
				OdccManager.UpdateQuery(thisObject);
			}
		}
		internal void RemoveItem(IOdccData target)
		{
			if(RemoveItem(ref datas, target))
			{
				OdccManager.UpdateQuery(thisObject);
			}
		}
		internal void RemoveItems(List<IOdccData> targets)
		{
			if(RemoveItems(ref datas, targets))
			{
				OdccManager.UpdateQuery(thisObject);
			}
		}

		private bool AddItem<T>(ref List<T> tList, T target) where T : IOdccItem
		{
			if(target == null) return false;
			if(tList.Contains(target)) return false;
			if(target is IOdccData) target.OdccItemContainer = thisObject.OdccItemContainer;
			tList.Add(target);
			TypeIndexUpdate();
			return true;
		}
		private bool AddItems<T>(ref List<T> tList, List<T> targets) where T : IOdccItem
		{
			int length = targets.Count;
			if(length == 0) return false;
			bool change = false;
			for(int i = 0 ; i < length ; i++)
			{
				var target = targets[i];
				if(tList.Contains(target)) continue;
				if(target is IOdccData) target.OdccItemContainer = thisObject.OdccItemContainer;
				tList.Add(target);
				change = true;
			}
			TypeIndexUpdate();
			return change;
		}
		private bool RemoveItem<T>(ref List<T> tList, T target) where T : IOdccItem
		{
			if(target == null) return false;
			if(!tList.Contains(target)) return false;
			if(target is IOdccData) target.OdccItemContainer = null;
			bool change = tList.Remove(target);
			TypeIndexUpdate();
			return change;
		}
		private bool RemoveItems<T>(ref List<T> tList, List<T> targets) where T : IOdccItem
		{
			int length = targets.Count;
			if(length == 0) return false;
			bool change = false;
			for(int i = 0 ; i < length ; i++)
			{
				var target = targets[i];
				if(!tList.Contains(target)) continue;
				if(target is IOdccData) target.OdccItemContainer = null;
				if(tList.Remove(target))
				{
					change = true;
				}
			}
			TypeIndexUpdate();
			return change;
		}

		internal bool TryGetObject<T>(out T @object, Func<T, bool> condition)
		{
			@object = default;
			if(thisObject is T _object && condition(_object))
			{
				@object = _object;
				return true;
			}
			return false;
		}
		internal bool TryGetParent<T>(out T parent, Func<T, bool> condition)
		{
			parent = default;
			if(parent is T _object && condition(_object))
			{
				parent = _object;
				return true;
			}
			return false;
		}
		internal bool TryGetChild<T>(out T target, Func<T, bool> condition) where T : IOdccObject
		{
			return TryGetItem(in children, out target, condition);
		}
		internal bool TryGetChild<T>(out List<T> target, Func<T, bool> condition) where T : IOdccObject
		{
			return TryGetItems(in children, out target, condition);
		}
		internal bool TryGetComponent<T>(out T target, Func<T, bool> condition) where T : IOdccComponent
		{
			return TryGetItem(in components, out target, condition);
		}
		internal bool TryGetComponent<T>(out List<T> target, Func<T, bool> condition) where T : IOdccComponent
		{
			return TryGetItems(in components, out target, condition);
		}
		internal bool TryGetData<T>(out T target, Func<T, bool> condition) where T : IOdccData
		{
			return TryGetItem(in datas, out target, condition);
		}
		internal bool TryGetData<T>(out List<T> target, Func<T, bool> condition) where T : IOdccData
		{
			return TryGetItems(in datas, out target, condition);
		}

		private bool TryGetItem<L, T>(in List<L> tList, out T result, Func<T, bool> condition) where L : IOdccItem where T : IOdccItem
		{
			result = default;
			int length = tList.Count;
			for(int i = 0 ; i < length ; i++)
			{
				var find = tList[i];
				if(find == null) continue;
				if(find is T _t && condition(_t))
				{
					result = _t;
					break;
				}
			}
			return result != null;
		}
		private bool TryGetItems<L, T>(in List<L> tList, out List<T> result, Func<T, bool> condition) where L : IOdccItem where T : IOdccItem
		{
			List<T> _result = null;

			int size = 0;
			int length = tList.Count;
			Action addList = null;
			for(int i = 0 ; i < length ; i++)
			{
				var find = tList[i];
				if(find == null) continue;
				if(find is T _t && condition(_t))
				{
					int index = size;
					addList += () => _result[index] = _t;
					size++;
					break;
				}
			}
			if(size == 0)
			{
				_result = new List<T>();
			}
			else
			{
				_result = new List<T>(new T[size]);
				addList?.Invoke();
			}
			result = _result;
			return true;
		}

		[Obsolete("제거됨")]
		public void AllRefresh()
		{

		}


		private void TypeIndexUpdate()
		{
			List<IOdccItem> typeIndexItem = new ();
			if(thisObject != null)
				typeIndexItem.Add(thisObject);
			if(datas != null)
				typeIndexItem.AddRange(datas);
			if(components != null)
				typeIndexItem.AddRange(components);

			typeIndex =  typeIndexItem
				.Select(x => x.OdccTypeIndex)
				.Concat(typeIndexItem.SelectMany(x => x.OdccTypeInheritanceIndex))
				.Distinct()
				.ToList();
		}
#if UNITY_EDITOR
		private IEnumerable<ValueDropdownItem> ShowTypeText()
		{
			if(typeIndex == null) return new List<ValueDropdownItem>();
			return typeIndex.Select(index => new ValueDropdownItem($"{index} : {OdccManager.IntTypeTable[index].Name}", index));
		}
#endif
	}
}
