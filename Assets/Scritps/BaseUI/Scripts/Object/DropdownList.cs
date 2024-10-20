using System;

using BC.ODCC;

using UnityEngine;

namespace BC.BaseUI
{
	[RequireComponent(typeof(UnityEngine.Canvas))]
	public class DropdownList : ComponentBehaviour
	{
		UnityEngine.UI.ScrollRect scrollRect;

		private Vector2 initScrollPosition;
		private Action<Vector2> onValueChanged;
		public override void BaseReset()
		{
			base.BaseReset();
		}
		public override void BaseAwake()
		{
			base.BaseAwake();
		}

		protected override void OnTransformParentChanged()
		{
			if(ThisObject is Dropdown ThisDropdown)
			{
				ThisDropdown.OpenDropdownList(this, true);
			}
		}

		public override void BaseDisable()
		{
			if(ThisObject is Dropdown ThisDropdown)
			{
				ThisDropdown.OpenDropdownList(this, false);
			}
		}

		public override void BaseStart()
		{
			StartEvent();
		}
		internal void StartEvent()
		{
			scrollRect = GetComponent<UnityEngine.UI.ScrollRect>();
			if(scrollRect != null)
			{
				scrollRect.onValueChanged.RemoveAllListeners();
				scrollRect.normalizedPosition = initScrollPosition;
				scrollRect.onValueChanged.AddListener((position) => {
					onValueChanged?.Invoke(position);
				});
			}
		}
		internal void SetScrollPosition(Vector2 scrollPosition, System.Action<Vector2> valueChanged)
		{
			initScrollPosition = scrollPosition;
			onValueChanged = valueChanged;
			if(didStart)
			{
				StartEvent();
			}
		}
	}
}
