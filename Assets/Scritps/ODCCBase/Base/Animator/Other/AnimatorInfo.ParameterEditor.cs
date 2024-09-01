#if UNITY_EDITOR
using System;
using System.IO;

using Sirenix.OdinInspector;

using UnityEditor;
using UnityEditor.Animations;

using UnityEngine;

namespace BC.OdccBase
{
	public partial class AnimatorInfo : SerializedScriptableObject// ParameterEditor
	{
		public void UpdateScript(AnimatorController animatorController)
		{
			GenerateScript(animatorController, out string scriptPath, out string scriptContent);
			SaveScript(scriptPath, scriptContent);
			return;

			void GenerateScript(AnimatorController animatorController, out string scriptPath, out string scriptContent)
			{

				string scriptName = $"{animatorController.name}_Parameters";
				scriptContent = "";
				scriptContent += "/// 이 코드는 AnimatorInfo.ParameterEditor.cs 에서 자동생성 됩니다.\n";
				scriptContent += $"using Sirenix.OdinInspector;\n\nnamespace BC.OdccBase\n{{\n\tpublic class {scriptName} : AnimatorParameterControler\n\t{{\n";

				AnimatorControllerParameter[] parameters = animatorController.parameters;
				foreach(var parameter in parameters)
				{
					switch(parameter.type)
					{
						case AnimatorControllerParameterType.Bool:
						scriptContent += $"\t\t[ShowInInspector, ReadOnly] public bool {parameter.name} {{ get {{ return GetBool(\"{parameter.name}\"); }} set {{ SetBool(\"{parameter.name}\", value); }} }}\n";
						break;
						case AnimatorControllerParameterType.Float:
						scriptContent += $"\t\t[ShowInInspector, ReadOnly] public float {parameter.name} {{ get {{ return GetFloat(\"{parameter.name}\"); }} set {{ SetFloat(\"{parameter.name}\", value); }} }}\n";
						break;
						case AnimatorControllerParameterType.Int:
						scriptContent += $"\t\t[ShowInInspector, ReadOnly] public int {parameter.name} {{ get {{ return GetInteger(\"{parameter.name}\"); }} set {{ SetInteger(\"{parameter.name}\", value); }} }}\n";
						break;
						case AnimatorControllerParameterType.Trigger:
						scriptContent += $"\t\t[ShowInInspector, ReadOnly] public bool {parameter.name} {{ get {{ return GetBool(\"{parameter.name}\"); }} set {{ SetTrigger(\"{parameter.name}\", value);}} }}\n";
						break;
					}
				}

				scriptContent += "\n";
				scriptContent += "\t\tprivate bool GetBool(string paramName) { return ThisAnimator != null ? ThisAnimator.GetBool(paramName) : default; }\n";
				scriptContent += "\t\tprivate float GetFloat(string paramName) { return ThisAnimator != null ? ThisAnimator.GetFloat(paramName) : default; }\n";
				scriptContent += "\t\tprivate int GetInteger(string paramName) { return ThisAnimator != null ? ThisAnimator.GetInteger(paramName) : default; }\n";
				scriptContent += "\n";
				scriptContent += "\t\tprivate void SetBool(string paramName, bool value) { if(ThisAnimator != null) ThisAnimator.SetBool(paramName, value); }\n";
				scriptContent += "\t\tprivate void SetFloat(string paramName, float value) { if(ThisAnimator != null) ThisAnimator.SetFloat(paramName, value); }\n";
				scriptContent += "\t\tprivate void SetInteger(string paramName, int value) { if(ThisAnimator != null) ThisAnimator.SetInteger(paramName, value); }\n";
				scriptContent += "\t\tprivate void SetTrigger(string paramName, bool value) { if(ThisAnimator != null) { if(value) ThisAnimator.SetTrigger(paramName); else ThisAnimator.ResetTrigger(paramName); } }\n";
				scriptContent += "\n";

				scriptContent += "\t}\n}";

				string animatorControllerPath = AssetDatabase.GetAssetPath(this);
				scriptPath = $"{Path.GetDirectoryName(animatorControllerPath)}/{scriptName}.cs";
			}

			void SaveScript(string scriptPath, string scriptContent)
			{
				if(string.IsNullOrEmpty(scriptPath))
				{
					Debug.LogError("Invalid file path.");
					return;
				}

				try
				{
					File.WriteAllText(scriptPath, scriptContent.Trim());
					AssetDatabase.Refresh(ImportAssetOptions.ForceUpdate);
				}
				catch(Exception e)
				{
					Debug.LogError($"Failed to generate script: {e.Message}");
				}
			}
		}


		void DeleteScript()
		{
			AnimatorController animatorController;
			if(Controller is AnimatorOverrideController isOverride)
			{
				animatorController = isOverride.runtimeAnimatorController as AnimatorController;
			}
			else
			{
				animatorController = Controller as AnimatorController;
			}
			if(animatorController == null) return;

			string scriptName = $"{animatorController.name}_Parameters";
			string animatorControllerPath = AssetDatabase.GetAssetPath(this);
			string scriptPath = $"{Path.GetDirectoryName(animatorControllerPath)}/{scriptName}.cs";

			if(File.Exists(scriptPath))
			{
				File.Delete(scriptPath);
				AssetDatabase.Refresh();
			}
			else
			{
				Debug.LogWarning($"Script '{Path.GetFileName(scriptPath)}' not found.");
			}
		}

	}
}
#endif