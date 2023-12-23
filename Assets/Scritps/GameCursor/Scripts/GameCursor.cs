using System;
using System.Collections.Generic;

using BC.Base;

using Sirenix.OdinInspector;

using UnityEngine;

namespace BC.Base
{
	//[CreateAssetMenu(fileName = "GameCursor", menuName = "BC/GameCursor")]
	public class GameCursor : MonoSingleton<GameCursor>
	{
		[Serializable]
		public struct SpriteGroup
		{
			[HorizontalGroup, PreviewField, HideLabel, LabelWidth(0.1f)]
			public Sprite sprite;
			[Title("Sprite BuiltinPath")]
			[HorizontalGroup, HideLabel, LabelWidth(100)]
			public string name;
		}

		public Canvas cursorCanvas;
		[SerializeField]
		private List<SpriteGroup> list;

		private static GameCursor manager;

		private CursorPointer pointer;
		public static CursorPointer Pointer => Instance(instance => instance.pointer, out CursorPointer cursorPointer) ? cursorPointer : null;
		protected override void CreatedSingleton()
		{
			CanvasGroup canvasGroup = cursorCanvas.GetComponent<CanvasGroup>();
			cursorCanvas.sortingOrder = ConstInt.UICursorOrder;
			pointer = cursorCanvas.GetComponentInChildren<CursorPointer>(true);
			pointer.Init();
			pointer.SetCanvasGroup(canvasGroup);
			Change("");
		}

		protected override void DestroySingleton()
		{

		}

		public void Change(string selectName)
		{
			Instance(Instance =>
			{
				int index = Instance.list.FindIndex(Match);
				if(index >= 0)
				{
					Cursor.visible = false;
					SpriteGroup find = Instance.list[index];
					Instance.pointer.ChangeCursorSprite(find);
				}
				else
				{
					Cursor.visible = true;
				}
				bool Match(SpriteGroup item)
				{
					return item.name.Equals(selectName);
				}
			});
		}
	}
}