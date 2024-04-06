using System;
using System.Collections.Generic;

using BC.ODCC;

using UnityEngine.UI;

namespace BC.BaseUI
{
	[Serializable]
	public class TapWindowData : DataObject
	{
		public ScrollRect ScrollRect;
		public ToggleGroup ToggleGroup;
		public List<Content> ContentList;

		public int currentIndex;

		[Serializable]
		public class Content
		{
			public Toggle tabToggle;
			public RectUIObject tabItem;
		}
	}
}
