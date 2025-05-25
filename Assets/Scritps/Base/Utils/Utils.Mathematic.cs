using System.Collections.Generic;

using UnityEngine;

namespace BC.Base
{
	public partial class Utils//.Mathematic 
	{
		public static void SetNaN(ref this Vector3 vector)
		{
			vector.x = float.NaN;
			vector.y = float.NaN;
			vector.z = float.NaN;
		}
		public static bool IsNaN(this Vector3 vector)
		{
			return float.IsNaN(vector.x) || float.IsNaN(vector.y) || float.IsNaN(vector.z);
		}

		public static Vector3 Center(this Vector3 vector, Vector3 other)
		{
			return (vector + other) * 0.5f;
		}

		/// <summary> <code>
		/// 두 백터의 각이 얼마나 일치 하는지
		/// 일치 할수록 1
		/// 불일치 할수록 0
		/// </code> </summary>
		public static float CalculateDirectionalMatch(Vector3 diractionA, Vector3 diractionB)
		{
			// 두 벡터 간의 각도 계산
			// Dot => 1 ~ -1
			// + 1 => 2 ~ 0
			// *.5 => 1 ~ 0
			//float mismatch = Vector3.Dot(diractionA.normalized, diractionB.normalized);
			//mismatch += 1;
			//mismatch *= .5f;
			return (Vector3.Dot(diractionA.normalized, diractionB.normalized) + 1) * 0.5f;
		}
		/// <summary> <code>
		/// 두 백터의 각이 얼마나 불일치 하는지
		/// 일치 할수록 0
		/// 불일치 할수록 1
		/// </code> </summary>
		public static float CalculateDirectionalMissmatch(Vector3 diractionA, Vector3 diractionB)
		{
			return 1f - CalculateDirectionalMatch(diractionA, diractionB);
		}

		/// <summary><code>
		/// Close - Packing of Spheres (https://en.wikipedia.org/wiki/Close-packing_of_equal_spheres)
		/// center : 중심 좌표
		/// size : 영역의 크기
		/// sphereRadius : 공간을 채울 구의 반지름
		/// pattern: 공간을 채우는 방석
		/// pattern == 0 : SC
		/// pattern == 1 : XZ => HCP + Y => SC
		/// pattern == 2 : HCP
		/// pattern == 3 : FCC
		/// </code></summary>
		public static List<Vector3> ClosePackingSpheres(Vector3 center, Vector3 size, float sphereRadius, int pattern, bool onlyPlane)
		{
			List<Vector3> packingPosition = new List<Vector3>();

			if(pattern < 0)
				pattern = 0;
			else if(pattern > 3)
				pattern = 3;
			if(sphereRadius < 0.1f)
				sphereRadius = 0.1f;

			/*readonly*/
			float sphereDiameter = sphereRadius * 2f;
			float root3 = Mathf.Sqrt(3);
			float root6 = Mathf.Sqrt(6);
			float slpit3 = 1f/3f;

			size += -Vector3.one * sphereDiameter;

			float sphereOffsetX = sphereDiameter;
			float sphereOffsetY = sphereDiameter * (pattern < 2 ? 1f : (root6 * slpit3));
			float sphereOffsetZ = sphereRadius * (pattern < 1 ? 1f : root3);

			int stapX = (int)(size.x / sphereOffsetX);
			int stapY = (int)(size.y / sphereOffsetY);
			int stapZ = (int)(size.z / sphereOffsetZ);

			Vector3 minPosition = center - (size * 0.5f) - Vector3.one * float.Epsilon;
			Vector3 maxPosition = center + (size * 0.5f) + Vector3.one * float.Epsilon;
			Vector3 minPoint = maxPosition;
			Vector3 maxPoint = minPosition;

			int startIndex = 1;//// pattern == 0 ? 0 : 2;

			for(int y = -startIndex ; y <= stapY + startIndex ; y++)
			{
				if(onlyPlane) stapY = 0;
				for(int x = -startIndex ; x <= stapX +startIndex ; x++)
				{
					for(int z = -startIndex ; z <= stapZ+startIndex ; z++)
					{
						float xPos = x * sphereDiameter;
						float yPos = pattern < 2 ? y * sphereDiameter : y * root6 * slpit3 *  sphereDiameter;
						float zPos = pattern < 1 ? z * sphereDiameter : z * root3 * sphereRadius;

						if(pattern > 0)
						{
							xPos += (z % 2) * sphereRadius;
						}

						if(pattern > 1)
						{
							xPos += (y % pattern) * sphereRadius;
							zPos += (y % pattern) * sphereDiameter * slpit3;
						}
						Vector3 position = new Vector3(xPos, yPos, zPos) + (center - size * 0.5f);

						if(IsPointInsideBounds(position))
						{
							packingPosition.Add(position);

							if(minPoint.x > position.x)
								minPoint.x = position.x;
							if(minPoint.y > position.y)
								minPoint.y = position.y;
							if(minPoint.z > position.z)
								minPoint.z = position.z;

							if(maxPoint.x < position.x)
								maxPoint.x = position.x;
							if(maxPoint.y < position.y)
								maxPoint.y = position.y;
							if(maxPoint.z < position.z)
								maxPoint.z = position.z;
						}
					}
				}
				if(onlyPlane) break;
			}

			Vector3 boundDelta  = maxPosition - minPosition;
			Vector3 pointDelta = maxPoint - minPoint;
			Vector3 delta = boundDelta - pointDelta;
			delta = delta * 0.5f;

			for(int i = 0 ; i < packingPosition.Count ; i++)
			{
				packingPosition[i] += delta;
			}

			bool IsPointInsideBounds(Vector3 point)
			{
				return point.x >= minPosition.x && point.x <= maxPosition.x &&
					   (onlyPlane || point.y >= minPosition.y && point.y <= maxPosition.y) &&
					   point.z >= minPosition.z && point.z <= maxPosition.z;
			}

			return packingPosition;
		}

		/// <summary>
		/// Vector3.Distance 의 Sqr 버전
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public static float SqrDistance(Vector3 a, Vector3 b)
		{
			float num = a.x - b.x;
			float num2 = a.y - b.y;
			float num3 = a.z - b.z;
			return (num * num + num2 * num2 + num3 * num3);
		}



		/// <summary>
		/// 주어진 점이 두께를 고려한 삼각형 내부에 있는지 검사하는 함수
		/// </summary>
		public static bool PointInTriangle(Vector3 point, Vector3 vertex1, Vector3 vertex2, Vector3 vertex3, float thickness)
		{
			return IsPointInTriangle() && Mathf.Abs(PointToPlaneDistance()) <= Mathf.Abs(thickness);

			// 주어진 지점과 삼각형의 각 꼭지점으로 만들어진 평면과의 거리를 계산하는 함수
			float PointToPlaneDistance()
			{
				Vector3 normal = Vector3.Cross(vertex2 - vertex1, vertex3 - vertex1).normalized;
				float distance = Vector3.Dot(normal, point - vertex1);
				return distance;
			}

			// 주어진 점이 삼각형 내부에 있는지 검사하는 함수 (2D에서 그대로 사용)
			bool IsPointInTriangle()
			{
				Vector3 v0 = vertex3 - vertex1;
				Vector3 v1 = vertex2 - vertex1;
				Vector3 v2 = point - vertex1;

				float dot00 = Vector3.Dot(v0, v0);
				float dot01 = Vector3.Dot(v0, v1);
				float dot02 = Vector3.Dot(v0, v2);
				float dot11 = Vector3.Dot(v1, v1);
				float dot12 = Vector3.Dot(v1, v2);

				float invDenom = 1.0f / (dot00 * dot11 - dot01 * dot01);
				float u = (dot11 * dot02 - dot01 * dot12) * invDenom;
				float v = (dot00 * dot12 - dot01 * dot02) * invDenom;

				return (u >= 0) && (v >= 0) && (u + v < 1);
			}
		}

		/// <summary>
		/// 선이 Bounds를 가로지르는지 여부를 확인
		/// </summary>
		public static bool IsLineIntersectingBox(Vector3 start, Vector3 end, Vector3 center, Vector3 halfSize)
		{
			Vector3 max = center + halfSize;
			Vector3 min = center - halfSize;

			bool intersectsX = (start.x <= max.x && end.x >= min.x) || (end.x <= max.x && start.x >= min.x);
			bool intersectsY = (start.y <= max.y && end.y >= min.y) || (end.y <= max.y && start.y >= min.y);
			bool intersectsZ = (start.z <= max.z && end.z >= min.z) || (end.z <= max.z && start.z >= min.z);

			return intersectsX && intersectsY && intersectsZ;
		}
	}
}
