using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Sirenix.OdinInspector;
using Sirenix.Utilities;

using UnityEngine;

namespace BC.Base
{
	public static class TagAndLayer
	{
		#region 미리 정의된 Index
		public static int Ground = GetLayerToIndex(nameof(Ground));

		public static int NavMeshRaycast = GetLayerToIndex(nameof(NavMeshRaycast));
		public static int CharacterDetectorRaycast = GetLayerToIndex(nameof(CharacterDetectorRaycast));
		public static int ShootBulletRaycast = GetLayerToIndex(nameof(ShootBulletRaycast));

		public static int Character = GetLayerToIndex(nameof(Character));
		public static int Bullet = GetLayerToIndex(nameof(Bullet));

		public static int MapAnchor = GetLayerToIndex(nameof(MapAnchor));

		public static int Building = GetLayerToIndex(nameof(Building));
		public static int StaticWall = GetLayerToIndex(nameof(StaticWall));
		public static int DynamicWall = GetLayerToIndex(nameof(DynamicWall));
		#endregion

		// [ValueDropdown("@TagAndLayer.LayerIndexList")] //
		public static IEnumerable LayerIndexList  = new ValueDropdownList<int>()
		{
			{ "Character", TagAndLayer.Character },
			{ "Bullet", TagAndLayer.Bullet },
			{ "Ground", TagAndLayer.Ground },
			{ "Building", TagAndLayer.Building },
			{ "StaticWall", TagAndLayer.StaticWall },
		};

		#region 미리 정의된 Mask
		public static int UnitAgentDetectingMask = GetLayerToMask(nameof(Ground),nameof(StaticWall),nameof(DynamicWall));

		#endregion

		#region Layer <=> Index
		public static int GetLayerToIndex(string name)
		{
			return LayerMask.NameToLayer(name);
		}
		public static string GetIndexToLayer(int index)
		{
			return LayerMask.LayerToName(index);
		}
		#endregion

		#region Layer <=> Mask
		public static int GetLayerToMask(params string[] name)
		{
			return LayerMask.GetMask(name);
		}
		public static List<string> GetMaskToLayer(int maskValue)
		{
			List<string> layerNames = new List<string>();
			for(int i = 0 ; i < 32 ; i++)
			{
				if((maskValue & 1 << i) > 0)
				{
					layerNames.Add(GetIndexToLayer(i));
				}
			}
			return layerNames;
		}
		#endregion

		#region Index <=> Mask
		public static int GetIndexToMask(params int[] index)
		{
			int maskValue = 0;
			for(int i = 0 ; i < index.Length ; i++)
			{
				maskValue |= 1 << index[i];
			}
			return maskValue;
		}
		public static List<int> GetMaskToIndex(int maskValue)
		{
			List<int> layerIndex = new List<int>();
			for(int i = 0 ; i < 32 ; i++)
			{
				if((maskValue & 1 << i) > 0)
				{
					layerIndex.Add(i);
				}
			}
			return layerIndex;
		}
		public static int GetHitLayerMask(int index)
		{
			int maskValue = 0;
			for(int i = 0 ; i < 32 ; i++)
			{
				if(!Physics.GetIgnoreLayerCollision(index, i))
				{
					maskValue |= 1 << i;
				}

			}
			return maskValue;
		}
		public static int GetIgnoreLayerMask(int index)
		{
			int maskValue = 0;
			for(int i = 0 ; i < 32 ; i++)
			{
				if(Physics.GetIgnoreLayerCollision(index, i))
				{
					maskValue |= 1 << i;
				}

			}
			return maskValue;
		}
		#endregion
	}

#if UNITY_EDITOR
	[CreateAssetMenu(fileName = "TagAndLayerData", menuName = "BC/TagAndLayerData")]
	public class TagAndLayerData : SerializedScriptableObject
	{
		[Title("TagAndLayer")]
		[ListDrawerSettings(ShowPaging = false,ShowIndexLabels = true)]
		public List<string> TagThemeAssets;
		[ListDrawerSettings(ShowPaging = false,ShowIndexLabels = true)]
		public List<string> LayerThemeAssets;

		[Title("PhysicsMatrix")]
		public long[] uIntLayerCollisionMatrix = new long[32];
		[TableMatrix(HorizontalTitle = "Custom Cell Drawing", ResizableColumns = false, RowHeight = 16, DrawElementMethod = "DrawColoredEnumElement")]
		public int[,] LayerCollisionMatrix;

		private static Rect oldRect;
		private static int oldValue;
		private static int DrawColoredEnumElement(Rect rect, int value)
		{
			if((Event.current.type == EventType.MouseDown) && rect.Contains(Event.current.mousePosition))
			{
				oldRect = rect;
				oldValue = value;
				GUI.changed = true;
				Event.current.Use();
				if(value > 0)
				{
					value = value == 1 ? 2 : 1;
				}
			}
			else if(Event.current.type == EventType.MouseDrag && rect.Contains(Event.current.mousePosition))
			{
				if(oldRect != rect && oldValue == value)
				{
					GUI.changed = true;
					Event.current.Use();
					oldRect = rect;
					if(value > 0)
					{
						value = value == 1 ? 2 : 1;
					}
				}
			}

			if(value > 0)
			{
				UnityEditor.EditorGUI.DrawRect(rect.Padding(1), value == 2 ? new Color(1f, 1f, 1f) : new Color(0.5f, 0.5f, 0.5f, 0.5f));
			}
			else
			{
				UnityEditor.EditorGUI.DrawRect(rect.Padding(1), new Color(0, 0, 0, 1));
			}
			return value;
		}

		public void Reset()
		{
			InitValue();
		}
		[ButtonGroup("Button", ButtonHeight = 30), PropertyOrder(-1)]
		public void InitValue()
		{
			InitTagAndLayer();
			InitPhysicsMatrix();
		}
		[ButtonGroup("Button"), PropertyOrder(-1)]
		public void SaveValue()
		{
			SaveTagAndLayer();
			SavePhysicsMatrix();
		}

		#region TagAndLayer
		void InitTagAndLayer()
		{
			UnityEditor.SerializedObject tagManager = new UnityEditor.SerializedObject(UnityEditor.AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset")[0]);
			UnityEditor.SerializedProperty tagsProp = tagManager.FindProperty("tags");
			UnityEditor.SerializedProperty layersProp = tagManager.FindProperty("layers");

			TagThemeAssets = new List<string>();
			LayerThemeAssets = new List<string>();

			try
			{
				for(int i = 0 ; i < tagsProp.arraySize ; i++)
				{
					UnityEditor.SerializedProperty tag = tagsProp.GetArrayElementAtIndex(i);
					TagThemeAssets.Add(tag.stringValue);
				}
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
			}

			try
			{
				for(int i = 0 ; i < layersProp.arraySize ; i++)
				{
					UnityEditor.SerializedProperty layer = layersProp.GetArrayElementAtIndex(i);
					LayerThemeAssets.Add(layer.stringValue);
				}
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
			}
		}
		void SaveTagAndLayer()
		{
			UnityEditor.SerializedObject tagManager = new UnityEditor.SerializedObject(UnityEditor.AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset")[0]);
			UnityEditor.SerializedProperty tagsProp = tagManager.FindProperty("tags");
			UnityEditor.SerializedProperty layersProp = tagManager.FindProperty("layers");

			try
			{
				while(tagsProp.arraySize > 0)
				{
					tagsProp.DeleteArrayElementAtIndex(0);
				}
				TagThemeAssets = TagThemeAssets.Where(where => !string.IsNullOrWhiteSpace(where)).ToList();
				for(int i = 0 ; i < TagThemeAssets.Count ; i++)
				{
					tagsProp.InsertArrayElementAtIndex(i);
					UnityEditor.SerializedProperty newTag = tagsProp.GetArrayElementAtIndex(tagsProp.arraySize - 1);
					newTag.stringValue = TagThemeAssets[i];
				}
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
			}

			try
			{
				for(int i = 0 ; i < layersProp.arraySize ; i++)
				{
					if(i > 31) break;

					UnityEditor.SerializedProperty layer = layersProp.GetArrayElementAtIndex(i);
					if(i >= LayerThemeAssets.Count)
					{
						layer.stringValue = null;
					}
					else
					{
						layer.stringValue = LayerThemeAssets[i];
					}
				}
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
			}

			try
			{
				// Save the changes
				tagManager.ApplyModifiedProperties();

				// Update the editor GUI to reflect the changes
				UnityEditorInternal.InternalEditorUtility.RepaintAllViews();
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
			}

			InitTagAndLayer();
		}
		#endregion
		#region PhysicsMatrix
		void InitPhysicsMatrix()
		{
			int layerCount = 32;
			LayerCollisionMatrix = new int[layerCount, layerCount];
			UnityEditor.SerializedObject physicsManager = new UnityEditor.SerializedObject(UnityEditor.AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/DynamicsManager.asset")[0]);
			UnityEditor.SerializedProperty matrix = physicsManager.FindProperty("m_LayerCollisionMatrix");
			for(int i = 0 ; i < matrix.arraySize ; i++)
			{
				uIntLayerCollisionMatrix[i] = matrix.GetArrayElementAtIndex(i).longValue;
			}

			for(int i = 0 ; i <layerCount ; i++)
			{
				long layer = uIntLayerCollisionMatrix[i];
				for(int ii = 0 ; ii <layerCount ; ii++)
				{
					bool check = (layer & 1 << ii) != 0;
					if(i < ii)
					{
						LayerCollisionMatrix[i, ii] = check ? -2 : -1;
					}
					else
					{
						LayerCollisionMatrix[i, ii] = check ? 2 : 1;
					}

				}
			}
		}
		void SavePhysicsMatrix()
		{
			int layerCount = 32;

			for(int i = 0 ; i <layerCount ; i++)
			{
				long layer = 0;
				for(int ii = 0 ; ii <layerCount ; ii++)
				{
					bool check = false;
					if(i < ii)
					{
						check = LayerCollisionMatrix[ii, i] == 2;
					}
					else
					{
						check = LayerCollisionMatrix[i, ii] == 2;
					}
					if(check)
					{
						layer |= (long)1<<ii;
					}
				}
				uIntLayerCollisionMatrix[i] = layer;
			}


			UnityEditor.SerializedObject physicsManager = new UnityEditor.SerializedObject(UnityEditor.AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/DynamicsManager.asset")[0]);
			UnityEditor.SerializedProperty matrix = physicsManager.FindProperty("m_LayerCollisionMatrix");
			for(int i = 0 ; i < matrix.arraySize ; i++)
			{
				matrix.GetArrayElementAtIndex(i).longValue = uIntLayerCollisionMatrix[i];
			}

			try
			{
				// Save the changes
				physicsManager.ApplyModifiedProperties();

				// Update the editor GUI to reflect the changes
				UnityEditorInternal.InternalEditorUtility.RepaintAllViews();
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
			}
		}
		#endregion
	}
#endif
}