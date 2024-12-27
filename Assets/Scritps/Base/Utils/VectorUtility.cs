using System;

using UnityEngine;

namespace BC.Base
{
	public static partial class VectorUtility
	{
		public static void ForeachXY(this Vector2Int vector2, Action<int, int> @foreach)
		{
			if(@foreach == null) return;
			int xLength = vector2.x;
			int yLength = vector2.y;
			for(int x = 0 ; x < xLength ; x++)
			{
				for(int y = 0 ; y < yLength ; y++)
				{
					@foreach(x, y);
				}
			}
		}
		public static void ForeachXYZ(this Vector3Int vector3, Action<int, int, int> @foreach)
		{
			if(@foreach == null) return;
			int xLength = vector3.x;
			int yLength = vector3.y;
			int zLength = vector3.z;
			for(int x = 0 ; x < xLength ; x++)
			{
				for(int y = 0 ; y < yLength ; y++)
				{
					for(int z = 0 ; z < zLength ; z++)
					{
						@foreach(x, y, z);
					}
				}
			}
		}

		#region Vector2 <=> Vector3
		public static Vector3 XY(this Vector2 vector, float z = 0f)
		{
			return new Vector3(vector.x, vector.y, z);
		}

		public static Vector3 XZ(this Vector2 vector, float y = 0f)
		{
			return new Vector3(vector.x, y, vector.y);
		}

		public static Vector3 YZ(this Vector2 vector, float x = 0f)
		{
			return new Vector3(x, vector.x, vector.y);
		}

		public static Vector3 YX(this Vector2 vector, float z = 0f)
		{
			return new Vector3(vector.y, vector.x, z);
		}

		public static Vector3 ZX(this Vector2 vector, float y = 0f)
		{
			return new Vector3(vector.y, y, vector.x);
		}

		public static Vector3 ZY(this Vector2 vector, float x = 0f)
		{
			return new Vector3(x, vector.y, vector.x);
		}

		public static Vector2 XY(this Vector3 vector)
		{
			return new Vector2(vector.x, vector.y);
		}

		public static Vector2 XZ(this Vector3 vector)
		{
			return new Vector2(vector.x, vector.z);
		}

		public static Vector2 YX(this Vector3 vector)
		{
			return new Vector2(vector.y, vector.x);
		}

		public static Vector2 YZ(this Vector3 vector)
		{
			return new Vector2(vector.y, vector.z);
		}

		public static Vector2 ZX(this Vector3 vector)
		{
			return new Vector2(vector.z, vector.x);
		}

		public static Vector2 ZY(this Vector3 vector)
		{
			return new Vector2(vector.z, vector.y);
		}
		#endregion

		#region Vector2Int <=> Vector3Int
		public static Vector3Int XY(this Vector2Int vector, int z = 0)
		{
			return new Vector3Int(vector.x, vector.y, z);
		}

		public static Vector3Int XZ(this Vector2Int vector, int y = 0)
		{
			return new Vector3Int(vector.x, y, vector.y);
		}

		public static Vector3Int YZ(this Vector2Int vector, int x = 0)
		{
			return new Vector3Int(x, vector.x, vector.y);
		}

		public static Vector3Int YX(this Vector2Int vector, int z = 0)
		{
			return new Vector3Int(vector.y, vector.x, z);
		}

		public static Vector3Int ZX(this Vector2Int vector, int y = 0)
		{
			return new Vector3Int(vector.y, y, vector.x);
		}

		public static Vector3Int ZY(this Vector2Int vector, int x = 0)
		{
			return new Vector3Int(x, vector.y, vector.x);
		}

		public static Vector2Int XY(this Vector3Int vector)
		{
			return new Vector2Int(vector.x, vector.y);
		}

		public static Vector2Int XZ(this Vector3Int vector)
		{
			return new Vector2Int(vector.x, vector.z);
		}

		public static Vector2Int YX(this Vector3Int vector)
		{
			return new Vector2Int(vector.y, vector.x);
		}

		public static Vector2Int YZ(this Vector3Int vector)
		{
			return new Vector2Int(vector.y, vector.z);
		}

		public static Vector2Int ZX(this Vector3Int vector)
		{
			return new Vector2Int(vector.z, vector.x);
		}

		public static Vector2Int ZY(this Vector3Int vector)
		{
			return new Vector2Int(vector.z, vector.y);
		}
		#endregion
	}
}
