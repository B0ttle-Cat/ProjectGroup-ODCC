#if UNITY_EDITOR
using System;

using UnityEditor;

using UnityEngine;

namespace BC.BaseUI
{
	public class CreateUIEditor
	{
		static private GameObject CreateObject(string Name)
		{
			try
			{
				Transform parent = null;
				if(Selection.activeObject != null && Selection.activeObject is GameObject gameObject)
				{
					parent = gameObject.transform;
				}

				GameObject resources = Resources.Load<GameObject>($"BaseUI/{Name}");
				GameObject newObject = GameObject.Instantiate(resources, parent);
				newObject.name = Name;
				return newObject;
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
				return null;
			}
		}
		static private void ActiveObject(GameObject newObject)
		{
			try
			{
				if(newObject == null) return;

				Undo.RegisterCreatedObjectUndo(newObject, newObject.name);
				if(Selection.activeObject != null && Selection.activeObject is GameObject gameObject)
				{
					newObject.transform.parent = gameObject.transform;
				}
				Selection.activeObject = newObject;
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
			}
		}

		[MenuItem("GameObject/BC Object/UI/Canvas", priority = -1)]
		private static void CreateCanvas()
		{
			ActiveObject(CreateObject("Canvas"));
		}
		[MenuItem("GameObject/BC Object/UI/CanvasGroup")]
		private static void CreateCanvasGroup()
		{
			ActiveObject(CreateObject("CanvasGroup"));
		}
		[MenuItem("GameObject/BC Object/UI/Image")]
		private static void CreateImage()
		{
			ActiveObject(CreateObject("Image"));
		}
		[MenuItem("GameObject/BC Object/UI/Text")]
		private static void CreateText()
		{
			ActiveObject(CreateObject("Text"));
		}
		[MenuItem("GameObject/BC Object/UI/Button")]
		private static void CreateButton()
		{
			ActiveObject(CreateObject("Button"));
		}
		[MenuItem("GameObject/BC Object/UI/Toggle")]
		private static void CreateToggle()
		{
			ActiveObject(CreateObject("Toggle"));
		}
		[MenuItem("GameObject/BC Object/UI/Slider")]
		private static void CreateSlider()
		{
			ActiveObject(CreateObject("Slider"));
		}
	}
}
#endif