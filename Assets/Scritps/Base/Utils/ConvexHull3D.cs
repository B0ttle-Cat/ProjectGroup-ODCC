using System.Collections.Generic;

using UnityEngine;

namespace BC.Base
{
	public class ConvexHull
	{
		public static List<Vector3> ComputeConvexHull2D(List<Vector3> points)
		{
			// 점들을 오름차순으로 정렬
			points.Sort((a, b) =>
			{
				if(a.x != b.x)
					return a.x.CompareTo(b.x);
				else
					return a.z.CompareTo(b.z);
			});

			// Convex Hull 구하기
			List<Vector3> convexHull = new List<Vector3>();
			convexHull.Add(points[0]);
			convexHull.Add(points[1]);

			for(int i = 2 ; i < points.Count ; i++)
			{
				convexHull.Add(points[i]);
				while(convexHull.Count > 2 &&
					   !IsCounterClockwise(convexHull[convexHull.Count - 3],
										   convexHull[convexHull.Count - 2],
										   convexHull[convexHull.Count - 1]))
				{
					convexHull.RemoveAt(convexHull.Count - 2);
				}
			}

			return convexHull;

			bool IsCounterClockwise(Vector3 a, Vector3 b, Vector3 c)
			{
				return ((b.x - a.x) * (c.z - a.z) - (b.z - a.z) * (c.x - a.x)) > 0;
			}
		}



		public static List<Vector3[]> ComputeConvexHull3D(List<Vector3> points)
		{
			// 점들을 오름차순으로 정렬합니다.
			points.Sort((a, b) =>
			{
				if(a.x != b.x)
					return a.x.CompareTo(b.x);
				if(a.y != b.y)
					return a.y.CompareTo(b.y);
				return a.z.CompareTo(b.z);
			});

			// 볼록 껍질을 계산합니다.
			List<Vector3> hull = new List<Vector3>();

			// 가장 왼쪽에 있는 점을 시작점으로 설정합니다.
			Vector3 startPoint = points[0];
			Vector3 currentPoint = startPoint;
			Vector3 nextPoint;

			do
			{
				hull.Add(currentPoint);
				nextPoint = points[0];

				for(int i = 1 ; i < points.Count ; i++)
				{
					if(nextPoint == currentPoint || IsClockwiseTurn(currentPoint, nextPoint, points[i]))
					{
						nextPoint = points[i];
					}
				}

				currentPoint = nextPoint;
			} while(currentPoint != startPoint);

			// 면으로 변환합니다.
			List<Vector3[]> faces = TriangulateConvexHull(hull);

			return faces;


			bool IsClockwiseTurn(Vector3 a, Vector3 b, Vector3 c)
			{
				Vector3 ab = b - a;
				Vector3 ac = c - a;

				Vector3 crossProduct = Vector3.Cross(ab, ac);

				return Vector3.Dot(crossProduct, Vector3.up) < 0;
			}

			static List<Vector3[]> TriangulateConvexHull(List<Vector3> hull)
			{
				List<Vector3[]> faces = new List<Vector3[]>();

				// 첫 번째 점을 기준으로 삼각형을 형성합니다.
				Vector3 pivot = hull[0];

				for(int i = 1 ; i < hull.Count - 1 ; i++)
				{
					Vector3[] face = new Vector3[3];
					face[0] = pivot;
					face[1] = hull[i];
					face[2] = hull[i + 1];

					faces.Add(face);
				}

				return faces;
			}
		}
	}

}
