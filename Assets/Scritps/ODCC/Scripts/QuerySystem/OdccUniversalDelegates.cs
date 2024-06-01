/// 이 코드는 <see cref="BC.ODCC.OdccUniversalDelegatesGenerater"/>에서 자동완성 됩니다.
namespace BC.ODCC
{
	using System.Collections;
	using System.Collections.Generic;

	using UnityEngine;

	#region Delegate
	public delegate void T();
	public delegate void T<T0>(T0 t0) where T0 : class, IOdccItem;
	public delegate void T<T0, T1>(T0 t0, T1 t1) where T0 : class, IOdccItem where T1 : class, IOdccItem;
	public delegate void T<T0, T1, T2>(T0 t0, T1 t1, T2 t2) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem;
	public delegate void T<T0, T1, T2, T3>(T0 t0, T1 t1, T2 t2, T3 t3) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem;
	public delegate void T<T0, T1, T2, T3, T4>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate void T<T0, T1, T2, T3, T4, T5>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate void T<T0, T1, T2, T3, T4, T5, T6>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate void T<T0, T1, T2, T3, T4, T5, T6, T7>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate void T<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate void T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate void T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem;
	public delegate void T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem;
	public delegate void T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem where T18 : class, IOdccItem;
	public delegate void T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem where T18 : class, IOdccItem where T19 : class, IOdccItem;
	public delegate IEnumerator I();
	public delegate IEnumerator I<T0>(T0 t0) where T0 : class, IOdccItem;
	public delegate IEnumerator I<T0, T1>(T0 t0, T1 t1) where T0 : class, IOdccItem where T1 : class, IOdccItem;
	public delegate IEnumerator I<T0, T1, T2>(T0 t0, T1 t1, T2 t2) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem;
	public delegate IEnumerator I<T0, T1, T2, T3>(T0 t0, T1 t1, T2 t2, T3 t3) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem;
	public delegate IEnumerator I<T0, T1, T2, T3, T4>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate IEnumerator I<T0, T1, T2, T3, T4, T5>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate IEnumerator I<T0, T1, T2, T3, T4, T5, T6>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate IEnumerator I<T0, T1, T2, T3, T4, T5, T6, T7>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate IEnumerator I<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate IEnumerator I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate IEnumerator I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate IEnumerator I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate IEnumerator I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate IEnumerator I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate IEnumerator I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate IEnumerator I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate IEnumerator I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem;
	public delegate IEnumerator I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem;
	public delegate IEnumerator I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem where T18 : class, IOdccItem;
	public delegate IEnumerator I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem where T18 : class, IOdccItem where T19 : class, IOdccItem;
	public delegate Awaitable A();
	public delegate Awaitable A<T0>(T0 t0) where T0 : class, IOdccItem;
	public delegate Awaitable A<T0, T1>(T0 t0, T1 t1) where T0 : class, IOdccItem where T1 : class, IOdccItem;
	public delegate Awaitable A<T0, T1, T2>(T0 t0, T1 t1, T2 t2) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem;
	public delegate Awaitable A<T0, T1, T2, T3>(T0 t0, T1 t1, T2 t2, T3 t3) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem;
	public delegate Awaitable A<T0, T1, T2, T3, T4>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate Awaitable A<T0, T1, T2, T3, T4, T5>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate Awaitable A<T0, T1, T2, T3, T4, T5, T6>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate Awaitable A<T0, T1, T2, T3, T4, T5, T6, T7>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate Awaitable A<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate Awaitable A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate Awaitable A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate Awaitable A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate Awaitable A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate Awaitable A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate Awaitable A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate Awaitable A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate Awaitable A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem;
	public delegate Awaitable A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem;
	public delegate Awaitable A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem where T18 : class, IOdccItem;
	public delegate Awaitable A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem where T18 : class, IOdccItem where T19 : class, IOdccItem;
	#endregion

	#region QuerySystemBuilder
	/// 이 코드는 <see cref="BC.ODCC.QuerySystemBuilder"/>를 확장합니다.
	public partial class QuerySystemBuilder
	{
		public QuerySystemBuilder WithAny<T0>(bool checkInheritance = false) where T0 : class, IOdccItem => WithAny(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0)));
		public QuerySystemBuilder WithAny<T0, T1>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem => WithAny(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1)));
		public QuerySystemBuilder WithAny<T0, T1, T2>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem => WithAny(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem => WithAny(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem => WithAny(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem => WithAny(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem => WithAny(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem => WithAny(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem => WithAny(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem => WithAny(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem => WithAny(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem => WithAny(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem => WithAny(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem => WithAny(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem => WithAny(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem => WithAny(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem => WithAny(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem => WithAny(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem where T18 : class, IOdccItem => WithAny(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17), typeof(T18)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem where T18 : class, IOdccItem where T19 : class, IOdccItem => WithAny(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17), typeof(T18), typeof(T19)));
		public QuerySystemBuilder WithNone<T0>(bool checkInheritance = false) where T0 : class, IOdccItem => WithNone(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0)));
		public QuerySystemBuilder WithNone<T0, T1>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem => WithNone(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1)));
		public QuerySystemBuilder WithNone<T0, T1, T2>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem => WithNone(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem => WithNone(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem => WithNone(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem => WithNone(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem => WithNone(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem => WithNone(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem => WithNone(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem => WithNone(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem => WithNone(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem => WithNone(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem => WithNone(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem => WithNone(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem => WithNone(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem => WithNone(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem => WithNone(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem => WithNone(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem where T18 : class, IOdccItem => WithNone(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17), typeof(T18)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem where T18 : class, IOdccItem where T19 : class, IOdccItem => WithNone(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17), typeof(T18), typeof(T19)));
		public QuerySystemBuilder WithAll<T0>(bool checkInheritance = false) where T0 : class, IOdccItem => WithAll(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0)));
		public QuerySystemBuilder WithAll<T0, T1>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem => WithAll(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1)));
		public QuerySystemBuilder WithAll<T0, T1, T2>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem => WithAll(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem => WithAll(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem => WithAll(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem => WithAll(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem => WithAll(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem => WithAll(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem => WithAll(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem => WithAll(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem => WithAll(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem => WithAll(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem => WithAll(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem => WithAll(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem => WithAll(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem => WithAll(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem => WithAll(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem => WithAll(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem where T18 : class, IOdccItem => WithAll(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17), typeof(T18)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(bool checkInheritance = false) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem where T18 : class, IOdccItem where T19 : class, IOdccItem => WithAll(checkInheritance, OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15), typeof(T16), typeof(T17), typeof(T18), typeof(T19)));
	}
	#endregion

	#region OdccQueryLooper
	/// 이 코드는 <see cref="BC.ODCC.OdccQueryLooper"/>를 확장합니다.
	public partial class OdccQueryLooper
	{

		public class RunForeachAction<T0> : RunForeachAction where T0 : class, IOdccItem
		{
			T<T0> delegateT;
			I<T0> delegateI;
			A<T0> delegateA;
			T0 t0;
			public RunForeachAction(T<T0> delegateT, ObjectBehaviour key, T0 t0)
			{
				this.key = key;
				this.delegateT=delegateT; this.t0 = t0;
			}
			public RunForeachAction(I<T0> delegateI, ObjectBehaviour key, T0 t0)
			{
				this.key = key;
				this.delegateI=delegateI; this.t0 = t0;
			}
			public RunForeachAction(A<T0> delegateA, ObjectBehaviour key, T0 t0)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0;
			}
			internal override void Run() => delegateT.Invoke(t0);
			internal override IEnumerator IRun() => delegateI.Invoke(t0);
			internal override Awaitable ARun() => delegateA.Invoke(t0);
		}
		public OdccQueryLooper Foreach<T0>(T<T0> t = null) where T0 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, false, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0>(t, item, SetForeachItem<T0>(item));
		}
		public OdccQueryLooper Foreach<T0>(I<T0> t = null) where T0 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0>(t, item, SetForeachItem<T0>(item));
		}
		public OdccQueryLooper Foreach<T0>(A<T0> t = null) where T0 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0>(t, item, SetForeachItem<T0>(item));
		}

		public class RunForeachAction<T0, T1> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem
		{
			T<T0, T1> delegateT;
			I<T0, T1> delegateI;
			A<T0, T1> delegateA;
			T0 t0; T1 t1;
			public RunForeachAction(T<T0, T1> delegateT, ObjectBehaviour key, T0 t0, T1 t1)
			{
				this.key = key;
				this.delegateT=delegateT; this.t0 = t0; this.t1 = t1;
			}
			public RunForeachAction(I<T0, T1> delegateI, ObjectBehaviour key, T0 t0, T1 t1)
			{
				this.key = key;
				this.delegateI=delegateI; this.t0 = t0; this.t1 = t1;
			}
			public RunForeachAction(A<T0, T1> delegateA, ObjectBehaviour key, T0 t0, T1 t1)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1;
			}
			internal override void Run() => delegateT.Invoke(t0, t1);
			internal override IEnumerator IRun() => delegateI.Invoke(t0, t1);
			internal override Awaitable ARun() => delegateA.Invoke(t0, t1);
		}
		public OdccQueryLooper Foreach<T0, T1>(T<T0, T1> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, false, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item));
		}
		public OdccQueryLooper Foreach<T0, T1>(I<T0, T1> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item));
		}
		public OdccQueryLooper Foreach<T0, T1>(A<T0, T1> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item));
		}

		public class RunForeachAction<T0, T1, T2> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem
		{
			T<T0, T1, T2> delegateT;
			I<T0, T1, T2> delegateI;
			A<T0, T1, T2> delegateA;
			T0 t0; T1 t1; T2 t2;
			public RunForeachAction(T<T0, T1, T2> delegateT, ObjectBehaviour key, T0 t0, T1 t1, T2 t2)
			{
				this.key = key;
				this.delegateT=delegateT; this.t0 = t0; this.t1 = t1; this.t2 = t2;
			}
			public RunForeachAction(I<T0, T1, T2> delegateI, ObjectBehaviour key, T0 t0, T1 t1, T2 t2)
			{
				this.key = key;
				this.delegateI=delegateI; this.t0 = t0; this.t1 = t1; this.t2 = t2;
			}
			public RunForeachAction(A<T0, T1, T2> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2;
			}
			internal override void Run() => delegateT.Invoke(t0, t1, t2);
			internal override IEnumerator IRun() => delegateI.Invoke(t0, t1, t2);
			internal override Awaitable ARun() => delegateA.Invoke(t0, t1, t2);
		}
		public OdccQueryLooper Foreach<T0, T1, T2>(T<T0, T1, T2> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, false, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2>(I<T0, T1, T2> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2>(A<T0, T1, T2> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item));
		}

		public class RunForeachAction<T0, T1, T2, T3> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
		{
			T<T0, T1, T2, T3> delegateT;
			I<T0, T1, T2, T3> delegateI;
			A<T0, T1, T2, T3> delegateA;
			T0 t0; T1 t1; T2 t2; T3 t3;
			public RunForeachAction(T<T0, T1, T2, T3> delegateT, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3)
			{
				this.key = key;
				this.delegateT=delegateT; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3;
			}
			public RunForeachAction(I<T0, T1, T2, T3> delegateI, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3)
			{
				this.key = key;
				this.delegateI=delegateI; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3;
			}
			public RunForeachAction(A<T0, T1, T2, T3> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3;
			}
			internal override void Run() => delegateT.Invoke(t0, t1, t2, t3);
			internal override IEnumerator IRun() => delegateI.Invoke(t0, t1, t2, t3);
			internal override Awaitable ARun() => delegateA.Invoke(t0, t1, t2, t3);
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3>(T<T0, T1, T2, T3> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, false, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3>(I<T0, T1, T2, T3> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3>(A<T0, T1, T2, T3> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item));
		}

		public class RunForeachAction<T0, T1, T2, T3, T4> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			T<T0, T1, T2, T3, T4> delegateT;
			I<T0, T1, T2, T3, T4> delegateI;
			A<T0, T1, T2, T3, T4> delegateA;
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4;
			public RunForeachAction(T<T0, T1, T2, T3, T4> delegateT, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4)
			{
				this.key = key;
				this.delegateT=delegateT; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4;
			}
			public RunForeachAction(I<T0, T1, T2, T3, T4> delegateI, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4)
			{
				this.key = key;
				this.delegateI=delegateI; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4;
			}
			public RunForeachAction(A<T0, T1, T2, T3, T4> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4;
			}
			internal override void Run() => delegateT.Invoke(t0, t1, t2, t3, t4);
			internal override IEnumerator IRun() => delegateI.Invoke(t0, t1, t2, t3, t4);
			internal override Awaitable ARun() => delegateA.Invoke(t0, t1, t2, t3, t4);
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4>(T<T0, T1, T2, T3, T4> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, false, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4>(I<T0, T1, T2, T3, T4> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4>(A<T0, T1, T2, T3, T4> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item));
		}

		public class RunForeachAction<T0, T1, T2, T3, T4, T5> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			T<T0, T1, T2, T3, T4, T5> delegateT;
			I<T0, T1, T2, T3, T4, T5> delegateI;
			A<T0, T1, T2, T3, T4, T5> delegateA;
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5;
			public RunForeachAction(T<T0, T1, T2, T3, T4, T5> delegateT, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
			{
				this.key = key;
				this.delegateT=delegateT; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5;
			}
			public RunForeachAction(I<T0, T1, T2, T3, T4, T5> delegateI, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
			{
				this.key = key;
				this.delegateI=delegateI; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5;
			}
			public RunForeachAction(A<T0, T1, T2, T3, T4, T5> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5;
			}
			internal override void Run() => delegateT.Invoke(t0, t1, t2, t3, t4, t5);
			internal override IEnumerator IRun() => delegateI.Invoke(t0, t1, t2, t3, t4, t5);
			internal override Awaitable ARun() => delegateA.Invoke(t0, t1, t2, t3, t4, t5);
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5>(T<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, false, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5>(I<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5>(A<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item));
		}

		public class RunForeachAction<T0, T1, T2, T3, T4, T5, T6> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			T<T0, T1, T2, T3, T4, T5, T6> delegateT;
			I<T0, T1, T2, T3, T4, T5, T6> delegateI;
			A<T0, T1, T2, T3, T4, T5, T6> delegateA;
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6;
			public RunForeachAction(T<T0, T1, T2, T3, T4, T5, T6> delegateT, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
			{
				this.key = key;
				this.delegateT=delegateT; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6;
			}
			public RunForeachAction(I<T0, T1, T2, T3, T4, T5, T6> delegateI, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
			{
				this.key = key;
				this.delegateI=delegateI; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6;
			}
			public RunForeachAction(A<T0, T1, T2, T3, T4, T5, T6> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6;
			}
			internal override void Run() => delegateT.Invoke(t0, t1, t2, t3, t4, t5, t6);
			internal override IEnumerator IRun() => delegateI.Invoke(t0, t1, t2, t3, t4, t5, t6);
			internal override Awaitable ARun() => delegateA.Invoke(t0, t1, t2, t3, t4, t5, t6);
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6>(T<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, false, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6>(I<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6>(A<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item));
		}

		public class RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			T<T0, T1, T2, T3, T4, T5, T6, T7> delegateT;
			I<T0, T1, T2, T3, T4, T5, T6, T7> delegateI;
			A<T0, T1, T2, T3, T4, T5, T6, T7> delegateA;
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7;
			public RunForeachAction(T<T0, T1, T2, T3, T4, T5, T6, T7> delegateT, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
			{
				this.key = key;
				this.delegateT=delegateT; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
			}
			public RunForeachAction(I<T0, T1, T2, T3, T4, T5, T6, T7> delegateI, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
			{
				this.key = key;
				this.delegateI=delegateI; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
			}
			public RunForeachAction(A<T0, T1, T2, T3, T4, T5, T6, T7> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
			}
			internal override void Run() => delegateT.Invoke(t0, t1, t2, t3, t4, t5, t6, t7);
			internal override IEnumerator IRun() => delegateI.Invoke(t0, t1, t2, t3, t4, t5, t6, t7);
			internal override Awaitable ARun() => delegateA.Invoke(t0, t1, t2, t3, t4, t5, t6, t7);
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7>(T<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, false, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7>(I<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7>(A<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item));
		}

		public class RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			T<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateT;
			I<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateI;
			A<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA;
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8;
			public RunForeachAction(T<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateT, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
			{
				this.key = key;
				this.delegateT=delegateT; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			public RunForeachAction(I<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateI, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
			{
				this.key = key;
				this.delegateI=delegateI; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			public RunForeachAction(A<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			internal override void Run() => delegateT.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8);
			internal override IEnumerator IRun() => delegateI.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8);
			internal override Awaitable ARun() => delegateA.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8);
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, false, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(I<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(A<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item));
		}

		public class RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateT;
			I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateI;
			A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9;
			public RunForeachAction(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateT, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateT=delegateT; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			public RunForeachAction(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateI, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateI=delegateI; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			public RunForeachAction(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override void Run() => delegateT.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
			internal override IEnumerator IRun() => delegateI.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
			internal override Awaitable ARun() => delegateA.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, false, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item));
		}

		public class RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateT;
			I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateI;
			A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10;
			public RunForeachAction(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateT, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateT=delegateT; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			public RunForeachAction(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateI, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateI=delegateI; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			public RunForeachAction(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override void Run() => delegateT.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
			internal override IEnumerator IRun() => delegateI.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
			internal override Awaitable ARun() => delegateA.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, false, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateT;
			I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateI;
			A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			public RunForeachAction(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateT, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateT=delegateT; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			public RunForeachAction(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateI, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateI=delegateI; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			public RunForeachAction(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override void Run() => delegateT.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
			internal override IEnumerator IRun() => delegateI.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
			internal override Awaitable ARun() => delegateA.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, false, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateT;
			I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateI;
			A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			public RunForeachAction(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateT, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateT=delegateT; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			public RunForeachAction(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateI, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateI=delegateI; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			public RunForeachAction(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override void Run() => delegateT.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
			internal override IEnumerator IRun() => delegateI.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
			internal override Awaitable ARun() => delegateA.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, false, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateT;
			I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateI;
			A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			public RunForeachAction(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateT, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateT=delegateT; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			public RunForeachAction(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateI, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateI=delegateI; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			public RunForeachAction(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override void Run() => delegateT.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
			internal override IEnumerator IRun() => delegateI.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
			internal override Awaitable ARun() => delegateA.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, false, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateT;
			I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateI;
			A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			public RunForeachAction(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateT, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateT=delegateT; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			public RunForeachAction(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateI, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateI=delegateI; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			public RunForeachAction(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override void Run() => delegateT.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
			internal override IEnumerator IRun() => delegateI.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
			internal override Awaitable ARun() => delegateA.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, false, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateT;
			I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateI;
			A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			public RunForeachAction(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateT, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateT=delegateT; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			public RunForeachAction(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateI, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateI=delegateI; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			public RunForeachAction(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override void Run() => delegateT.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
			internal override IEnumerator IRun() => delegateI.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
			internal override Awaitable ARun() => delegateA.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, false, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem
		{
			T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> delegateT;
			I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> delegateI;
			A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> delegateA;
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15; T16 t16;
			public RunForeachAction(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> delegateT, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
			{
				this.key = key;
				this.delegateT=delegateT; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15; this.t16 = t16;
			}
			public RunForeachAction(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> delegateI, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
			{
				this.key = key;
				this.delegateI=delegateI; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15; this.t16 = t16;
			}
			public RunForeachAction(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15; this.t16 = t16;
			}
			internal override void Run() => delegateT.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
			internal override IEnumerator IRun() => delegateI.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
			internal override Awaitable ARun() => delegateA.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, false, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item), SetForeachItem<T16>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item), SetForeachItem<T16>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item), SetForeachItem<T16>(item));
		}

		public class RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem
		{
			T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> delegateT;
			I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> delegateI;
			A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> delegateA;
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15; T16 t16; T17 t17;
			public RunForeachAction(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> delegateT, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17)
			{
				this.key = key;
				this.delegateT=delegateT; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15; this.t16 = t16; this.t17 = t17;
			}
			public RunForeachAction(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> delegateI, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17)
			{
				this.key = key;
				this.delegateI=delegateI; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15; this.t16 = t16; this.t17 = t17;
			}
			public RunForeachAction(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15; this.t16 = t16; this.t17 = t17;
			}
			internal override void Run() => delegateT.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17);
			internal override IEnumerator IRun() => delegateI.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17);
			internal override Awaitable ARun() => delegateA.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17);
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, false, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item), SetForeachItem<T16>(item), SetForeachItem<T17>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item), SetForeachItem<T16>(item), SetForeachItem<T17>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item), SetForeachItem<T16>(item), SetForeachItem<T17>(item));
		}

		public class RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem where T18 : class, IOdccItem
		{
			T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> delegateT;
			I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> delegateI;
			A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> delegateA;
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15; T16 t16; T17 t17; T18 t18;
			public RunForeachAction(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> delegateT, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18)
			{
				this.key = key;
				this.delegateT=delegateT; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15; this.t16 = t16; this.t17 = t17; this.t18 = t18;
			}
			public RunForeachAction(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> delegateI, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18)
			{
				this.key = key;
				this.delegateI=delegateI; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15; this.t16 = t16; this.t17 = t17; this.t18 = t18;
			}
			public RunForeachAction(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15; this.t16 = t16; this.t17 = t17; this.t18 = t18;
			}
			internal override void Run() => delegateT.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18);
			internal override IEnumerator IRun() => delegateI.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18);
			internal override Awaitable ARun() => delegateA.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18);
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem where T18 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, false, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item), SetForeachItem<T16>(item), SetForeachItem<T17>(item), SetForeachItem<T18>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem where T18 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item), SetForeachItem<T16>(item), SetForeachItem<T17>(item), SetForeachItem<T18>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem where T18 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item), SetForeachItem<T16>(item), SetForeachItem<T17>(item), SetForeachItem<T18>(item));
		}

		public class RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem where T18 : class, IOdccItem where T19 : class, IOdccItem
		{
			T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> delegateT;
			I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> delegateI;
			A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> delegateA;
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15; T16 t16; T17 t17; T18 t18; T19 t19;
			public RunForeachAction(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> delegateT, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19)
			{
				this.key = key;
				this.delegateT=delegateT; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15; this.t16 = t16; this.t17 = t17; this.t18 = t18; this.t19 = t19;
			}
			public RunForeachAction(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> delegateI, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19)
			{
				this.key = key;
				this.delegateI=delegateI; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15; this.t16 = t16; this.t17 = t17; this.t18 = t18; this.t19 = t19;
			}
			public RunForeachAction(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, T17 t17, T18 t18, T19 t19)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15; this.t16 = t16; this.t17 = t17; this.t18 = t18; this.t19 = t19;
			}
			internal override void Run() => delegateT.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19);
			internal override IEnumerator IRun() => delegateI.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19);
			internal override Awaitable ARun() => delegateA.Invoke(t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19);
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem where T18 : class, IOdccItem where T19 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, false, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item), SetForeachItem<T16>(item), SetForeachItem<T17>(item), SetForeachItem<T18>(item), SetForeachItem<T19>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(I<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem where T18 : class, IOdccItem where T19 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item), SetForeachItem<T16>(item), SetForeachItem<T17>(item), SetForeachItem<T18>(item), SetForeachItem<T19>(item));
		}
		public OdccQueryLooper Foreach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(A<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem where T16 : class, IOdccItem where T17 : class, IOdccItem where T18 : class, IOdccItem where T19 : class, IOdccItem
		{
			if(t == null) return this;
			int findIndex = runForeachStructList.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);
			if(findIndex >= 0)
			{
				var runForeachStruct = runForeachStructList[findIndex];
				runForeachStruct.targetDelegate = t;
				runForeachStructList[findIndex] = runForeachStruct;
				return this;
			}
			List<RunForeachAction> actionList = new List<RunForeachAction>();
			foreach(var item in queryCollector.queryItems)
			{
				actionList.Add(CreateRunLoopAction(item));
			}
			runForeachStructList.Add(new RunForeachStruct(t, actionList, true, CreateRunLoopAction));
			return this;
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item), SetForeachItem<T16>(item), SetForeachItem<T17>(item), SetForeachItem<T18>(item), SetForeachItem<T19>(item));
		}
	}
	#endregion
}