#if UNITY_EDITOR
using UnityEditor;

using UnityEngine;
using UnityEngine.SceneManagement;

[InitializeOnLoad]
public class RemoveEditorOnlyObject
{
	static RemoveEditorOnlyObject()
	{
		// Play 모드 진입 시 실행되는 초기화 작업
		EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
		// 씬이 열릴 때 실행되는 초기화 작업
		//EditorApplication.hierarchyChanged += OnHierarchyChanged;
		//EditorSceneManager.sceneSaved += OnSceneSaved;
	}

	private static void OnSceneSaved(Scene scene)
	{
		_RemoveEditorOnlyObject();
	}

	private static void OnPlayModeStateChanged(PlayModeStateChange state)
	{
		if(state == PlayModeStateChange.EnteredPlayMode)
		{
			_RemoveEditorOnlyObject();
		}
	}

	private static void OnHierarchyChanged()
	{
		_RemoveEditorOnlyObject();
	}

	private static void _RemoveEditorOnlyObject()
	{
		GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("EditorOnly");
		foreach(GameObject obj in objectsWithTag)
		{
			GameObject.DestroyImmediate(obj);
		}
	}
}
#endif