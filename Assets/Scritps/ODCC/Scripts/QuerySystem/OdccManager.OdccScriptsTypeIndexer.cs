using System;
using System.Collections.Generic;
using System.Linq;

using Sirenix.OdinInspector;

using UnityEngine;

using Debug = UnityEngine.Debug;

namespace BC.ODCC
{
	public sealed partial class OdccManager//.OdccScriptsTypeIndexer : ScriptableObject
	{
		[ShowInInspector, ReadOnly]
		private static Dictionary<Type, int> typeToIntTable;
		[ShowInInspector, ReadOnly]
		private static Dictionary<int, Type> intToTypeTable;
		[ShowInInspector, ReadOnly]
		private static Dictionary<int, int[]> inheritanceTable;
		private static bool IsEmpty => typeToIntTable is null || intToTypeTable is null || inheritanceTable is null;

		public static Dictionary<Type, int> TypeIntTable {
			get {
				if(IsEmpty) SetIsAsisgnable();
				return typeToIntTable;
			}
		}
		public static Dictionary<int, Type> IntTypeTable {
			get {
				if(IsEmpty) SetIsAsisgnable();
				return intToTypeTable;
			}
		}
		public static Dictionary<int, int[]> InheritanceTable {
			get {
				if(IsEmpty) SetIsAsisgnable();
				return inheritanceTable;
			}
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		static void SetIsAsisgnable()
		{
			Debug.Log("SetIsAssignable");
			Type[] typeList = AppDomain.CurrentDomain.GetAssemblies().SelectMany((i) => i.GetTypes())
								.Where(t => typeof(IOdccItem).IsAssignableFrom(t))
								.ToArray();
			Debug.Log($"Odcc Type List\n\t{string.Join("\n\t", typeList.Select((t) => t.FullName))}");

			int length = typeList.Length;
			var typeToIntTable = new Dictionary<Type, int>();
			var intToTypeTable = new Dictionary<int, Type>();
			var inheritanceTable = new Dictionary<int,int[]>();
			for(int i = 0 ; i < length ; i++)
			{
				var type = typeList[i];
				List<int> isAssignables = new List<int>();
				for(int ii = 0 ; ii < length ; ii++)
				{
					if(i==ii) continue;
					Type type2 = typeList[ii];
					if(type2.IsAssignableFrom(type))
					{
						isAssignables.Add(ii);
					}
				}
				var array = isAssignables.ToArray();
				typeToIntTable.Add(type, i);
				intToTypeTable.Add(i, type);
				inheritanceTable.Add(i, array);
			}


			OdccManager.typeToIntTable = typeToIntTable;
			OdccManager.intToTypeTable = intToTypeTable;
			OdccManager.inheritanceTable = inheritanceTable;

			string resultLog = "Odcc Type Indexer Result";

			foreach(var item in inheritanceTable)
			{
				var key = item.Key;
				var list = item.Value;
				resultLog += $"\n\t {key:000}:{intToTypeTable[key].FullName}";
				foreach(var item2 in list)
				{
					resultLog += $"\n\t - {item2:000}:{intToTypeTable[item2].FullName}";
				}
				resultLog += $"\n\t";
			}
			Debug.Log(resultLog);
		}

		public static int GetTypeToIndex(Type type)
		{
			return TypeIntTable.TryGetValue(type, out var table) ? table : -1;
		}
		public static Type GetIndexToType(int type)
		{
			return type >= 0 ? IntTypeTable[type] : null;
		}
		public static int[] GetTypeToIndex(params Type[] types)
		{
			return GetTypeToIndex((IEnumerable<Type>)types);
		}
		public static Type[] GetIndexToType(params int[] types)
		{
			return GetIndexToType((IEnumerable<int>)types);
		}
		public static int[] GetTypeToIndex(IEnumerable<Type> types)
		{
			int count1 = types.Count();
			int[] result = new int[count1];

			int i = 0;
			foreach(var type in types)
			{
				result[i++] = GetTypeToIndex(type);
			}
			return result;
		}
		public static Type[] GetIndexToType(IEnumerable<int> types)
		{
			int count1 = types.Count();
			Type[] result = new Type[count1];

			int i = 0;
			foreach(var index in types)
			{
				result[i++] = GetIndexToType(index);
			}
			return result;
		}
		public static int[] GetTypeToIndex(ObjectBehaviour item)
		{
			return (item is null || item.ThisContainer is null) ? new int[0] : item.ThisContainer.TypeIndex;
		}
		public static bool CheckIsInheritanceType(Type type, Type check)
		{
			return CheckIsInheritanceIndex(GetTypeToIndex(type), GetTypeToIndex(check));
		}
		public static bool CheckIsInheritanceType(Type type, int check)
		{
			return CheckIsInheritanceIndex(GetTypeToIndex(type), check);
		}
		public static bool CheckIsInheritanceType(int type, Type check)
		{
			return CheckIsInheritanceIndex(type, GetTypeToIndex(check));
		}
		public static bool CheckIsInheritanceIndex(int type, int check)
		{
			if(type >= 0 && check >= 0 && InheritanceTable.TryGetValue(type, out int[] inheritanceArray))
			{
				// inheritanceArray 중 일치하는 항목이 있는지 확인
				int Length = inheritanceArray.Length;
				for(int i = 0 ; i < Length ; i++)
				{
					if(inheritanceArray[i] == check)
					{
						return true;
					}
				}
			}
			return false;
		}
		public static bool CheckIsInheritanceType(Type type, params Type[] checkList)
		{
			return CheckIsInheritanceType(type, checkList);
		}
		public static bool CheckIsInheritanceIndex(int type, params int[] checkList)
		{
			return CheckIsInheritanceIndex(type, checkList);
		}
		public static bool CheckIsInheritanceType(Type type, IEnumerable<Type> checkList)
		{
			return CheckIsInheritanceIndex(GetTypeToIndex(type), checkList.Select(t => GetTypeToIndex(t)));
		}
		public static bool CheckIsInheritanceIndex(int type, IEnumerable<int> checkList)
		{
			if(type < 0) return false;
			if(checkList.Contains(type))
			{
				return true;
			}
			if(InheritanceTable.TryGetValue(type, out int[] inheritanceArray))
			{

				// inheritanceArray와 checkList의 중복 항목이 있는지 확인
				int Length = inheritanceArray.Length;
				for(int i = 0 ; i < Length ; i++)
				{
					int item = inheritanceArray[i];
					if(checkList.Contains(item))
					{
						return true;
					}
				}
			}
			return false;
		}
	}
}
