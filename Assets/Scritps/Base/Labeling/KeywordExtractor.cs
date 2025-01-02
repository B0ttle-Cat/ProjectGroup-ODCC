#if UNITY_EDITOR
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

using Sirenix.OdinInspector;

using UnityEngine;
namespace BC.Base
{
	[Serializable]
	public class KeywordExtractor
	{
		[Serializable]
		public struct Keyword
		{
			[HideLabel]
			[InlineButton("RemoveLabel"," - ")]
			[InlineButton("AddLabel"," + ")]
			public string keyword;

			public void AddLabel()
			{
				if(string.IsNullOrWhiteSpace(keyword)) return;
				if(UnityEditor.Selection.activeObject is not LabelTable labelTable) return;

				string _keyword = keyword;
				if(labelTable.List.Any((val) => val.name == _keyword)) return;
				labelTable.EditorAddLabel(keyword);
			}
			public void RemoveLabel()
			{
				if(string.IsNullOrWhiteSpace(keyword)) return;
				if(UnityEditor.Selection.activeObject is not LabelTable labelTable) return;
				string _keyword = keyword;
				labelTable.List = labelTable.List.Where((val) => val.name != _keyword).ToArray();
			}

		}
		[Serializable]
		public struct KeywordReplace
		{
			// (SM_(\w[^_]*))_(\w*)_(\d+)_?(\w*) => $2/$3
			[Multiline(2), LabelText("Old Pattern"),LabelWidth(80)]
			public string oldStringPattern;

			[Multiline(2), LabelText("New Pattern"),LabelWidth(80)]
			public string newStringPattern;
		}
		[LabelText("루트 폴더 경로"), FolderPath]
		public string folderPath = "Assets";
		[LabelText("검색 필터")]
		public string FindAssetsFilter = "t:Prefab";

		[LabelText("최소 반복 횟수")]
		public int frequencyThreshold = 1;
		[LabelText("최소 문자 개수")]
		public int lengthThreshold = 2;
		[LabelText("모든 자식 포함하기")]
		public bool IncludingChildren = false;

		[Title("Keyword String Pattern")]
		[Multiline(2)]
		public string conditionPattern;
		public KeywordReplace[] replaceString = new KeywordReplace[0];
		[Multiline(2)]
		public string splitStringPattern;

		[PropertyOrder(2)]
		[ListDrawerSettings(NumberOfItemsPerPage = 20)]
		public Keyword[] keywords = new Keyword[0];

		[Button("AnalyzeKeywords"), PropertyOrder(1)]
		public void AnalyzeKeywords()
		{
			Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

			var prefabs = UnityEditor.AssetDatabase.FindAssets("t:Prefab", new[] { folderPath });
			foreach(var prefabGUID in prefabs)
			{
				string path = UnityEditor.AssetDatabase.GUIDToAssetPath(prefabGUID);
				GameObject prefab = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>(path);
				if(prefab != null)
				{
					CollectKeywords(prefab.transform, wordFrequency);
				}
			}

			// 조건에 따라 필터링
			var frequentKeywords = wordFrequency
			.Where(kvp => kvp.Value >= frequencyThreshold && kvp.Key.Length >= lengthThreshold)
			.OrderByDescending(kvp => kvp.Value);

			int maxLength = 0;
			foreach(var keyword in frequentKeywords)
			{
				if(maxLength < keyword.Key.Length)
					maxLength = keyword.Key.Length;
			}
			maxLength += 2;

			string keywordsLog = $"📊 반복적으로 등장하는 키워드: (총:{frequentKeywords.Count()})";
			foreach(var keyword in frequentKeywords)
			{
				keywordsLog += string.Format("\n🔑 {0,"+-maxLength+"} 📊 {1}", keyword.Key, keyword.Value);
				//keywordsLog += $"\n🔑 {keyword.Key,-12} 📊 {keyword.Value}";
				if(keywordsLog.Length > 10000)
				{
					Debug.Log(keywordsLog);

					keywordsLog = "📊 반복적으로 등장하는 키워드: (이어서)";
				}
			}
			Debug.Log(keywordsLog);

			keywords = new Keyword[frequentKeywords.Count()];
			int index = 0;
			foreach(var keyword in frequentKeywords)
			{
				keywords[index++] = (new Keyword { keyword = keyword.Key });
			}
			keywords = keywords.OrderBy(k => k.keyword).ToArray();
		}

		private void CollectKeywords(Transform parent, Dictionary<string, int> wordFrequency)
		{
			ProcessName(parent.name, wordFrequency);

			if(!IncludingChildren) return;
			foreach(Transform child in parent)
			{
				CollectKeywords(child, wordFrequency);
			}
		}

		private void ProcessName(string name, Dictionary<string, int> wordFrequency)
		{
			name = name.Trim();
			if(!string.IsNullOrEmpty(conditionPattern))
			{
				if(!Regex.IsMatch(name, conditionPattern)) return;
			}

			int replaceLength = replaceString.Length;
			for(int i = 0 ; i < replaceLength ; i++)
			{
				var replace = replaceString[i];
				name = Regex.Replace(name, replace.oldStringPattern, replace.newStringPattern);
			}
			// SM_Bld_Castle_Archway_Small_
			string[] words = new string[1] { name };
			if(!string.IsNullOrEmpty(splitStringPattern))
			{
				words = Regex.Split(name, splitStringPattern).ToArray();
			}

			foreach(var word in words)
			{
				if(string.IsNullOrWhiteSpace(word))
					continue;

				string processedWord = word;

				// 최소 문자 개수 필터링
				if(processedWord.Length < lengthThreshold)
					continue;

				if(wordFrequency.ContainsKey(processedWord))
					wordFrequency[processedWord]++;
				else
					wordFrequency[processedWord] = 1;
			}
		}
	}
}
#endif