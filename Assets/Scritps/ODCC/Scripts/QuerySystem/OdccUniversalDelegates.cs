/// 이 코드는 <see cref=\"BC.ODCC.OdccUniversalDelegatesGenerator\"/>에서 자동완성 됩니다.
namespace BC.ODCC
{
	using System.Collections.Generic;

#if UNITY_EDITOR
	public class OdccUniversalDelegates { }
#endif

	#region Delegate
	public delegate void D();
	public delegate void D00_V<T0>(OdccQueryLooper.LoopInfo loopInfo, T0 t0) where T0 : class, IOdccItem;
	public delegate void D00_L<T0>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0) where T0 : class, IOdccItem;
	public delegate void D01_VV<T0, T1>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1) where T0 : class, IOdccItem where T1 : class, IOdccItem;
	public delegate void D01_LV<T0, T1>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1) where T0 : class, IOdccItem where T1 : class, IOdccItem;
	public delegate void D01_LL<T0, T1>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1) where T0 : class, IOdccItem where T1 : class, IOdccItem;
	public delegate void D02_VVV<T0, T1, T2>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem;
	public delegate void D02_LVV<T0, T1, T2>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem;
	public delegate void D02_LLV<T0, T1, T2>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem;
	public delegate void D02_LLL<T0, T1, T2>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem;
	public delegate void D03_VVVV<T0, T1, T2, T3>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem;
	public delegate void D03_LVVV<T0, T1, T2, T3>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem;
	public delegate void D03_LLVV<T0, T1, T2, T3>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem;
	public delegate void D03_LLLV<T0, T1, T2, T3>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem;
	public delegate void D03_LLLL<T0, T1, T2, T3>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem;
	public delegate void D04_VVVVV<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate void D04_LVVVV<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate void D04_LLVVV<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate void D04_LLLVV<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate void D04_LLLLV<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate void D04_LLLLL<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate void D05_VVVVVV<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate void D05_LVVVVV<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate void D05_LLVVVV<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate void D05_LLLVVV<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate void D05_LLLLVV<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate void D05_LLLLLV<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate void D05_LLLLLL<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate void D06_VVVVVVV<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate void D06_LVVVVVV<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate void D06_LLVVVVV<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate void D06_LLLVVVV<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate void D06_LLLLVVV<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate void D06_LLLLLVV<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate void D06_LLLLLLV<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate void D06_LLLLLLL<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate void D07_VVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate void D07_LVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate void D07_LLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate void D07_LLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate void D07_LLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate void D07_LLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate void D07_LLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate void D07_LLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate void D07_LLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate void D08_VVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate void D08_LVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate void D08_LLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate void D08_LLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate void D08_LLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate void D08_LLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate void D08_LLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate void D08_LLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate void D08_LLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate void D08_LLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate void D09_VVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate void D09_LVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate void D09_LLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate void D09_LLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate void D09_LLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate void D09_LLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate void D09_LLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate void D09_LLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate void D09_LLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate void D09_LLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate void D09_LLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate void D10_VVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D10_LVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D10_LLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D10_LLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D10_LLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D10_LLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D10_LLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D10_LLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D10_LLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D10_LLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D10_LLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D10_LLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D11_VVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11_LVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11_LLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11_LLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11_LLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11_LLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11_LLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11_LLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11_LLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11_LLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11_LLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11_LLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11_LLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D12_VVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12_LVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12_LLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12_LLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12_LLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12_LLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12_LLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12_LLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12_LLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12_LLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12_LLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12_LLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12_LLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12_LLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D13_VVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13_LVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13_LLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13_LLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13_LLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13_LLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13_LLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13_LLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13_LLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13_LLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13_LLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13_LLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13_LLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13_LLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13_LLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, List<T13> t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D14_VVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14_LVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14_LLVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14_LLLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14_LLLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14_LLLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14_LLLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14_LLLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14_LLLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14_LLLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14_LLLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14_LLLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14_LLLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14_LLLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14_LLLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, List<T13> t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14_LLLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, List<T13> t13, List<T14> t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D15_VVVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15_LVVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15_LLVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15_LLLVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15_LLLLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15_LLLLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15_LLLLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15_LLLLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15_LLLLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15_LLLLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15_LLLLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15_LLLLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15_LLLLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15_LLLLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15_LLLLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, List<T13> t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15_LLLLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, List<T13> t13, List<T14> t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15_LLLLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, List<T13> t13, List<T14> t14, List<T15> t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A();
	public delegate UnityEngine.Awaitable A00_V<T0>(OdccQueryLooper.LoopInfo loopInfo, T0 t0) where T0 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A00_L<T0>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0) where T0 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A01_VV<T0, T1>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1) where T0 : class, IOdccItem where T1 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A01_LV<T0, T1>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1) where T0 : class, IOdccItem where T1 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A01_LL<T0, T1>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1) where T0 : class, IOdccItem where T1 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A02_VVV<T0, T1, T2>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A02_LVV<T0, T1, T2>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A02_LLV<T0, T1, T2>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A02_LLL<T0, T1, T2>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A03_VVVV<T0, T1, T2, T3>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A03_LVVV<T0, T1, T2, T3>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A03_LLVV<T0, T1, T2, T3>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A03_LLLV<T0, T1, T2, T3>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A03_LLLL<T0, T1, T2, T3>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A04_VVVVV<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A04_LVVVV<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A04_LLVVV<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A04_LLLVV<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A04_LLLLV<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A04_LLLLL<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A05_VVVVVV<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A05_LVVVVV<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A05_LLVVVV<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A05_LLLVVV<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A05_LLLLVV<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A05_LLLLLV<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A05_LLLLLL<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A06_VVVVVVV<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A06_LVVVVVV<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A06_LLVVVVV<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A06_LLLVVVV<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A06_LLLLVVV<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A06_LLLLLVV<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A06_LLLLLLV<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A06_LLLLLLL<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A07_VVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A07_LVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A07_LLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A07_LLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A07_LLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A07_LLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A07_LLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A07_LLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A07_LLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A08_VVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A08_LVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A08_LLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A08_LLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A08_LLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A08_LLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A08_LLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A08_LLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A08_LLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A08_LLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A09_VVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A09_LVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A09_LLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A09_LLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A09_LLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A09_LLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A09_LLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A09_LLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A09_LLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A09_LLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A09_LLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10_VVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10_LVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10_LLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10_LLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10_LLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10_LLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10_LLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10_LLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10_LLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10_LLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10_LLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10_LLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11_VVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11_LVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11_LLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11_LLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11_LLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11_LLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11_LLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11_LLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11_LLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11_LLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11_LLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11_LLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11_LLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12_VVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12_LVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12_LLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12_LLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12_LLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12_LLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12_LLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12_LLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12_LLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12_LLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12_LLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12_LLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12_LLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12_LLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13_VVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13_LVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13_LLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13_LLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13_LLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13_LLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13_LLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13_LLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13_LLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13_LLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13_LLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13_LLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13_LLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13_LLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13_LLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, List<T13> t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14_VVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14_LVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14_LLVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14_LLLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14_LLLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14_LLLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14_LLLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14_LLLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14_LLLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14_LLLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14_LLLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14_LLLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14_LLLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14_LLLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14_LLLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, List<T13> t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14_LLLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, List<T13> t13, List<T14> t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15_VVVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15_LVVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15_LLVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15_LLLVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15_LLLLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15_LLLLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15_LLLLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15_LLLLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15_LLLLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15_LLLLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15_LLLLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15_LLLLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15_LLLLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15_LLLLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15_LLLLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, List<T13> t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15_LLLLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, List<T13> t13, List<T14> t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15_LLLLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, List<T13> t13, List<T14> t14, List<T15> t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	#endregion

	#region OdccQueryBuilder
	/// 이 코드는 <see cref=\"BC.ODCC.OdccQueryBuilder\"/>를 확장합니다.
	public partial class OdccQueryBuilder
	{
		public OdccQueryBuilder WithAny<T0>() where T0 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0)));
		public OdccQueryBuilder WithAny<T0, T1>() where T0 : class, IOdccItem where T1 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1)));
		public OdccQueryBuilder WithAny<T0, T1, T2>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2)));
		public OdccQueryBuilder WithAny<T0, T1, T2, T3>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3)));
		public OdccQueryBuilder WithAny<T0, T1, T2, T3, T4>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4)));
		public OdccQueryBuilder WithAny<T0, T1, T2, T3, T4, T5>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5)));
		public OdccQueryBuilder WithAny<T0, T1, T2, T3, T4, T5, T6>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6)));
		public OdccQueryBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7)));
		public OdccQueryBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8)));
		public OdccQueryBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9)));
		public OdccQueryBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10)));
		public OdccQueryBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11)));
		public OdccQueryBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12)));
		public OdccQueryBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13)));
		public OdccQueryBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14)));
		public OdccQueryBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15)));
		public OdccQueryBuilder WithNone<T0>() where T0 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0)));
		public OdccQueryBuilder WithNone<T0, T1>() where T0 : class, IOdccItem where T1 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1)));
		public OdccQueryBuilder WithNone<T0, T1, T2>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2)));
		public OdccQueryBuilder WithNone<T0, T1, T2, T3>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3)));
		public OdccQueryBuilder WithNone<T0, T1, T2, T3, T4>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4)));
		public OdccQueryBuilder WithNone<T0, T1, T2, T3, T4, T5>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5)));
		public OdccQueryBuilder WithNone<T0, T1, T2, T3, T4, T5, T6>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6)));
		public OdccQueryBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7)));
		public OdccQueryBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8)));
		public OdccQueryBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9)));
		public OdccQueryBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10)));
		public OdccQueryBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11)));
		public OdccQueryBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12)));
		public OdccQueryBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13)));
		public OdccQueryBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14)));
		public OdccQueryBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15)));
		public OdccQueryBuilder WithAll<T0>() where T0 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0)));
		public OdccQueryBuilder WithAll<T0, T1>() where T0 : class, IOdccItem where T1 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1)));
		public OdccQueryBuilder WithAll<T0, T1, T2>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2)));
		public OdccQueryBuilder WithAll<T0, T1, T2, T3>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3)));
		public OdccQueryBuilder WithAll<T0, T1, T2, T3, T4>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4)));
		public OdccQueryBuilder WithAll<T0, T1, T2, T3, T4, T5>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5)));
		public OdccQueryBuilder WithAll<T0, T1, T2, T3, T4, T5, T6>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6)));
		public OdccQueryBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7)));
		public OdccQueryBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8)));
		public OdccQueryBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9)));
		public OdccQueryBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10)));
		public OdccQueryBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11)));
		public OdccQueryBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12)));
		public OdccQueryBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13)));
		public OdccQueryBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14)));
		public OdccQueryBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15)));
	}
	#endregion

	#region OdccQueryLooper
	/// 이 코드는 <see cref=\"BC.ODCC.OdccQueryLooper\"/>를 확장합니다.
	public partial class OdccQueryLooper
	{

		public class RunForeachAction_A00_V<T0> : RunForeachAction where T0 : class, IOdccItem
		{
			T0 t0;
			A00_V<T0> delegateA;
			public RunForeachAction_A00_V(A00_V<T0> delegateA, ObjectBehaviour key, T0 t0)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0);
		}
		public OdccQueryLooper CallForeach<T0>(D00_V<T0> t = null) where T0 : class, IOdccItem
		{
			return CallForeach<T0>(async (info, t0) => t(info, t0));
		}
		public OdccQueryLooper CallForeach<T0>(A00_V<T0> t = null) where T0 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A00_V<T0>(t, item, SetForeachItem<T0>(item));
		}

		public class RunForeachAction_A00_L<T0> : RunForeachAction where T0 : class, IOdccItem
		{
			List<T0> t0;
			A00_L<T0> delegateA;
			public RunForeachAction_A00_L(A00_L<T0> delegateA, ObjectBehaviour key, List<T0> t0)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0);
		}
		public OdccQueryLooper CallForeach<T0>(D00_L<T0> t = null) where T0 : class, IOdccItem
		{
			return CallForeach<T0>(async (info, t0) => t(info, t0));
		}
		public OdccQueryLooper CallForeach<T0>(A00_L<T0> t = null) where T0 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A00_L<T0>(t, item, SetForeachItems<T0>(item));
		}

		public class RunForeachAction_A01_VV<T0, T1> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem
		{
			T0 t0; T1 t1;
			A01_VV<T0, T1> delegateA;
			public RunForeachAction_A01_VV(A01_VV<T0, T1> delegateA, ObjectBehaviour key, T0 t0, T1 t1)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1);
		}
		public OdccQueryLooper CallForeach<T0, T1>(D01_VV<T0, T1> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem
		{
			return CallForeach<T0, T1>(async (info, t0, t1) => t(info, t0, t1));
		}
		public OdccQueryLooper CallForeach<T0, T1>(A01_VV<T0, T1> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A01_VV<T0, T1>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item));
		}

		public class RunForeachAction_A01_LV<T0, T1> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem
		{
			List<T0> t0; T1 t1;
			A01_LV<T0, T1> delegateA;
			public RunForeachAction_A01_LV(A01_LV<T0, T1> delegateA, ObjectBehaviour key, List<T0> t0, T1 t1)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1);
		}
		public OdccQueryLooper CallForeach<T0, T1>(D01_LV<T0, T1> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem
		{
			return CallForeach<T0, T1>(async (info, t0, t1) => t(info, t0, t1));
		}
		public OdccQueryLooper CallForeach<T0, T1>(A01_LV<T0, T1> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A01_LV<T0, T1>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item));
		}

		public class RunForeachAction_A01_LL<T0, T1> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1;
			A01_LL<T0, T1> delegateA;
			public RunForeachAction_A01_LL(A01_LL<T0, T1> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1);
		}
		public OdccQueryLooper CallForeach<T0, T1>(D01_LL<T0, T1> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem
		{
			return CallForeach<T0, T1>(async (info, t0, t1) => t(info, t0, t1));
		}
		public OdccQueryLooper CallForeach<T0, T1>(A01_LL<T0, T1> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A01_LL<T0, T1>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item));
		}

		public class RunForeachAction_A02_VVV<T0, T1, T2> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2;
			A02_VVV<T0, T1, T2> delegateA;
			public RunForeachAction_A02_VVV(A02_VVV<T0, T1, T2> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2>(D02_VVV<T0, T1, T2> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2>(async (info, t0, t1, t2) => t(info, t0, t1, t2));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2>(A02_VVV<T0, T1, T2> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A02_VVV<T0, T1, T2>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item));
		}

		public class RunForeachAction_A02_LVV<T0, T1, T2> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem
		{
			List<T0> t0; T1 t1; T2 t2;
			A02_LVV<T0, T1, T2> delegateA;
			public RunForeachAction_A02_LVV(A02_LVV<T0, T1, T2> delegateA, ObjectBehaviour key, List<T0> t0, T1 t1, T2 t2)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2>(D02_LVV<T0, T1, T2> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2>(async (info, t0, t1, t2) => t(info, t0, t1, t2));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2>(A02_LVV<T0, T1, T2> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A02_LVV<T0, T1, T2>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item));
		}

		public class RunForeachAction_A02_LLV<T0, T1, T2> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; T2 t2;
			A02_LLV<T0, T1, T2> delegateA;
			public RunForeachAction_A02_LLV(A02_LLV<T0, T1, T2> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, T2 t2)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2>(D02_LLV<T0, T1, T2> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2>(async (info, t0, t1, t2) => t(info, t0, t1, t2));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2>(A02_LLV<T0, T1, T2> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A02_LLV<T0, T1, T2>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item));
		}

		public class RunForeachAction_A02_LLL<T0, T1, T2> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2;
			A02_LLL<T0, T1, T2> delegateA;
			public RunForeachAction_A02_LLL(A02_LLL<T0, T1, T2> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2>(D02_LLL<T0, T1, T2> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2>(async (info, t0, t1, t2) => t(info, t0, t1, t2));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2>(A02_LLL<T0, T1, T2> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A02_LLL<T0, T1, T2>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item));
		}

		public class RunForeachAction_A03_VVVV<T0, T1, T2, T3> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3;
			A03_VVVV<T0, T1, T2, T3> delegateA;
			public RunForeachAction_A03_VVVV(A03_VVVV<T0, T1, T2, T3> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3>(D03_VVVV<T0, T1, T2, T3> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3>(async (info, t0, t1, t2, t3) => t(info, t0, t1, t2, t3));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3>(A03_VVVV<T0, T1, T2, T3> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A03_VVVV<T0, T1, T2, T3>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item));
		}

		public class RunForeachAction_A03_LVVV<T0, T1, T2, T3> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
		{
			List<T0> t0; T1 t1; T2 t2; T3 t3;
			A03_LVVV<T0, T1, T2, T3> delegateA;
			public RunForeachAction_A03_LVVV(A03_LVVV<T0, T1, T2, T3> delegateA, ObjectBehaviour key, List<T0> t0, T1 t1, T2 t2, T3 t3)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3>(D03_LVVV<T0, T1, T2, T3> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3>(async (info, t0, t1, t2, t3) => t(info, t0, t1, t2, t3));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3>(A03_LVVV<T0, T1, T2, T3> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A03_LVVV<T0, T1, T2, T3>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item));
		}

		public class RunForeachAction_A03_LLVV<T0, T1, T2, T3> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; T2 t2; T3 t3;
			A03_LLVV<T0, T1, T2, T3> delegateA;
			public RunForeachAction_A03_LLVV(A03_LLVV<T0, T1, T2, T3> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, T2 t2, T3 t3)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3>(D03_LLVV<T0, T1, T2, T3> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3>(async (info, t0, t1, t2, t3) => t(info, t0, t1, t2, t3));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3>(A03_LLVV<T0, T1, T2, T3> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A03_LLVV<T0, T1, T2, T3>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item));
		}

		public class RunForeachAction_A03_LLLV<T0, T1, T2, T3> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; T3 t3;
			A03_LLLV<T0, T1, T2, T3> delegateA;
			public RunForeachAction_A03_LLLV(A03_LLLV<T0, T1, T2, T3> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3>(D03_LLLV<T0, T1, T2, T3> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3>(async (info, t0, t1, t2, t3) => t(info, t0, t1, t2, t3));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3>(A03_LLLV<T0, T1, T2, T3> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A03_LLLV<T0, T1, T2, T3>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item));
		}

		public class RunForeachAction_A03_LLLL<T0, T1, T2, T3> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3;
			A03_LLLL<T0, T1, T2, T3> delegateA;
			public RunForeachAction_A03_LLLL(A03_LLLL<T0, T1, T2, T3> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3>(D03_LLLL<T0, T1, T2, T3> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3>(async (info, t0, t1, t2, t3) => t(info, t0, t1, t2, t3));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3>(A03_LLLL<T0, T1, T2, T3> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A03_LLLL<T0, T1, T2, T3>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item));
		}

		public class RunForeachAction_A04_VVVVV<T0, T1, T2, T3, T4> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4;
			A04_VVVVV<T0, T1, T2, T3, T4> delegateA;
			public RunForeachAction_A04_VVVVV(A04_VVVVV<T0, T1, T2, T3, T4> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(D04_VVVVV<T0, T1, T2, T3, T4> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4>(async (info, t0, t1, t2, t3, t4) => t(info, t0, t1, t2, t3, t4));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(A04_VVVVV<T0, T1, T2, T3, T4> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A04_VVVVV<T0, T1, T2, T3, T4>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item));
		}

		public class RunForeachAction_A04_LVVVV<T0, T1, T2, T3, T4> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			List<T0> t0; T1 t1; T2 t2; T3 t3; T4 t4;
			A04_LVVVV<T0, T1, T2, T3, T4> delegateA;
			public RunForeachAction_A04_LVVVV(A04_LVVVV<T0, T1, T2, T3, T4> delegateA, ObjectBehaviour key, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(D04_LVVVV<T0, T1, T2, T3, T4> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4>(async (info, t0, t1, t2, t3, t4) => t(info, t0, t1, t2, t3, t4));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(A04_LVVVV<T0, T1, T2, T3, T4> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A04_LVVVV<T0, T1, T2, T3, T4>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item));
		}

		public class RunForeachAction_A04_LLVVV<T0, T1, T2, T3, T4> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; T2 t2; T3 t3; T4 t4;
			A04_LLVVV<T0, T1, T2, T3, T4> delegateA;
			public RunForeachAction_A04_LLVVV(A04_LLVVV<T0, T1, T2, T3, T4> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(D04_LLVVV<T0, T1, T2, T3, T4> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4>(async (info, t0, t1, t2, t3, t4) => t(info, t0, t1, t2, t3, t4));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(A04_LLVVV<T0, T1, T2, T3, T4> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A04_LLVVV<T0, T1, T2, T3, T4>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item));
		}

		public class RunForeachAction_A04_LLLVV<T0, T1, T2, T3, T4> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; T3 t3; T4 t4;
			A04_LLLVV<T0, T1, T2, T3, T4> delegateA;
			public RunForeachAction_A04_LLLVV(A04_LLLVV<T0, T1, T2, T3, T4> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(D04_LLLVV<T0, T1, T2, T3, T4> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4>(async (info, t0, t1, t2, t3, t4) => t(info, t0, t1, t2, t3, t4));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(A04_LLLVV<T0, T1, T2, T3, T4> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A04_LLLVV<T0, T1, T2, T3, T4>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item));
		}

		public class RunForeachAction_A04_LLLLV<T0, T1, T2, T3, T4> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; T4 t4;
			A04_LLLLV<T0, T1, T2, T3, T4> delegateA;
			public RunForeachAction_A04_LLLLV(A04_LLLLV<T0, T1, T2, T3, T4> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(D04_LLLLV<T0, T1, T2, T3, T4> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4>(async (info, t0, t1, t2, t3, t4) => t(info, t0, t1, t2, t3, t4));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(A04_LLLLV<T0, T1, T2, T3, T4> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A04_LLLLV<T0, T1, T2, T3, T4>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item));
		}

		public class RunForeachAction_A04_LLLLL<T0, T1, T2, T3, T4> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4;
			A04_LLLLL<T0, T1, T2, T3, T4> delegateA;
			public RunForeachAction_A04_LLLLL(A04_LLLLL<T0, T1, T2, T3, T4> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(D04_LLLLL<T0, T1, T2, T3, T4> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4>(async (info, t0, t1, t2, t3, t4) => t(info, t0, t1, t2, t3, t4));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(A04_LLLLL<T0, T1, T2, T3, T4> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A04_LLLLL<T0, T1, T2, T3, T4>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item));
		}

		public class RunForeachAction_A05_VVVVVV<T0, T1, T2, T3, T4, T5> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5;
			A05_VVVVVV<T0, T1, T2, T3, T4, T5> delegateA;
			public RunForeachAction_A05_VVVVVV(A05_VVVVVV<T0, T1, T2, T3, T4, T5> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(D05_VVVVVV<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5>(async (info, t0, t1, t2, t3, t4, t5) => t(info, t0, t1, t2, t3, t4, t5));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(A05_VVVVVV<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A05_VVVVVV<T0, T1, T2, T3, T4, T5>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item));
		}

		public class RunForeachAction_A05_LVVVVV<T0, T1, T2, T3, T4, T5> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			List<T0> t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5;
			A05_LVVVVV<T0, T1, T2, T3, T4, T5> delegateA;
			public RunForeachAction_A05_LVVVVV(A05_LVVVVV<T0, T1, T2, T3, T4, T5> delegateA, ObjectBehaviour key, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(D05_LVVVVV<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5>(async (info, t0, t1, t2, t3, t4, t5) => t(info, t0, t1, t2, t3, t4, t5));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(A05_LVVVVV<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A05_LVVVVV<T0, T1, T2, T3, T4, T5>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item));
		}

		public class RunForeachAction_A05_LLVVVV<T0, T1, T2, T3, T4, T5> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; T2 t2; T3 t3; T4 t4; T5 t5;
			A05_LLVVVV<T0, T1, T2, T3, T4, T5> delegateA;
			public RunForeachAction_A05_LLVVVV(A05_LLVVVV<T0, T1, T2, T3, T4, T5> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(D05_LLVVVV<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5>(async (info, t0, t1, t2, t3, t4, t5) => t(info, t0, t1, t2, t3, t4, t5));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(A05_LLVVVV<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A05_LLVVVV<T0, T1, T2, T3, T4, T5>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item));
		}

		public class RunForeachAction_A05_LLLVVV<T0, T1, T2, T3, T4, T5> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; T3 t3; T4 t4; T5 t5;
			A05_LLLVVV<T0, T1, T2, T3, T4, T5> delegateA;
			public RunForeachAction_A05_LLLVVV(A05_LLLVVV<T0, T1, T2, T3, T4, T5> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(D05_LLLVVV<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5>(async (info, t0, t1, t2, t3, t4, t5) => t(info, t0, t1, t2, t3, t4, t5));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(A05_LLLVVV<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A05_LLLVVV<T0, T1, T2, T3, T4, T5>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item));
		}

		public class RunForeachAction_A05_LLLLVV<T0, T1, T2, T3, T4, T5> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; T4 t4; T5 t5;
			A05_LLLLVV<T0, T1, T2, T3, T4, T5> delegateA;
			public RunForeachAction_A05_LLLLVV(A05_LLLLVV<T0, T1, T2, T3, T4, T5> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(D05_LLLLVV<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5>(async (info, t0, t1, t2, t3, t4, t5) => t(info, t0, t1, t2, t3, t4, t5));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(A05_LLLLVV<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A05_LLLLVV<T0, T1, T2, T3, T4, T5>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item));
		}

		public class RunForeachAction_A05_LLLLLV<T0, T1, T2, T3, T4, T5> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; T5 t5;
			A05_LLLLLV<T0, T1, T2, T3, T4, T5> delegateA;
			public RunForeachAction_A05_LLLLLV(A05_LLLLLV<T0, T1, T2, T3, T4, T5> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(D05_LLLLLV<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5>(async (info, t0, t1, t2, t3, t4, t5) => t(info, t0, t1, t2, t3, t4, t5));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(A05_LLLLLV<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A05_LLLLLV<T0, T1, T2, T3, T4, T5>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item));
		}

		public class RunForeachAction_A05_LLLLLL<T0, T1, T2, T3, T4, T5> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5;
			A05_LLLLLL<T0, T1, T2, T3, T4, T5> delegateA;
			public RunForeachAction_A05_LLLLLL(A05_LLLLLL<T0, T1, T2, T3, T4, T5> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(D05_LLLLLL<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5>(async (info, t0, t1, t2, t3, t4, t5) => t(info, t0, t1, t2, t3, t4, t5));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(A05_LLLLLL<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A05_LLLLLL<T0, T1, T2, T3, T4, T5>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item));
		}

		public class RunForeachAction_A06_VVVVVVV<T0, T1, T2, T3, T4, T5, T6> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6;
			A06_VVVVVVV<T0, T1, T2, T3, T4, T5, T6> delegateA;
			public RunForeachAction_A06_VVVVVVV(A06_VVVVVVV<T0, T1, T2, T3, T4, T5, T6> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(D06_VVVVVVV<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6>(async (info, t0, t1, t2, t3, t4, t5, t6) => t(info, t0, t1, t2, t3, t4, t5, t6));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(A06_VVVVVVV<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A06_VVVVVVV<T0, T1, T2, T3, T4, T5, T6>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item));
		}

		public class RunForeachAction_A06_LVVVVVV<T0, T1, T2, T3, T4, T5, T6> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			List<T0> t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6;
			A06_LVVVVVV<T0, T1, T2, T3, T4, T5, T6> delegateA;
			public RunForeachAction_A06_LVVVVVV(A06_LVVVVVV<T0, T1, T2, T3, T4, T5, T6> delegateA, ObjectBehaviour key, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(D06_LVVVVVV<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6>(async (info, t0, t1, t2, t3, t4, t5, t6) => t(info, t0, t1, t2, t3, t4, t5, t6));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(A06_LVVVVVV<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A06_LVVVVVV<T0, T1, T2, T3, T4, T5, T6>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item));
		}

		public class RunForeachAction_A06_LLVVVVV<T0, T1, T2, T3, T4, T5, T6> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6;
			A06_LLVVVVV<T0, T1, T2, T3, T4, T5, T6> delegateA;
			public RunForeachAction_A06_LLVVVVV(A06_LLVVVVV<T0, T1, T2, T3, T4, T5, T6> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(D06_LLVVVVV<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6>(async (info, t0, t1, t2, t3, t4, t5, t6) => t(info, t0, t1, t2, t3, t4, t5, t6));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(A06_LLVVVVV<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A06_LLVVVVV<T0, T1, T2, T3, T4, T5, T6>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item));
		}

		public class RunForeachAction_A06_LLLVVVV<T0, T1, T2, T3, T4, T5, T6> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; T3 t3; T4 t4; T5 t5; T6 t6;
			A06_LLLVVVV<T0, T1, T2, T3, T4, T5, T6> delegateA;
			public RunForeachAction_A06_LLLVVVV(A06_LLLVVVV<T0, T1, T2, T3, T4, T5, T6> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(D06_LLLVVVV<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6>(async (info, t0, t1, t2, t3, t4, t5, t6) => t(info, t0, t1, t2, t3, t4, t5, t6));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(A06_LLLVVVV<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A06_LLLVVVV<T0, T1, T2, T3, T4, T5, T6>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item));
		}

		public class RunForeachAction_A06_LLLLVVV<T0, T1, T2, T3, T4, T5, T6> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; T4 t4; T5 t5; T6 t6;
			A06_LLLLVVV<T0, T1, T2, T3, T4, T5, T6> delegateA;
			public RunForeachAction_A06_LLLLVVV(A06_LLLLVVV<T0, T1, T2, T3, T4, T5, T6> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(D06_LLLLVVV<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6>(async (info, t0, t1, t2, t3, t4, t5, t6) => t(info, t0, t1, t2, t3, t4, t5, t6));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(A06_LLLLVVV<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A06_LLLLVVV<T0, T1, T2, T3, T4, T5, T6>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item));
		}

		public class RunForeachAction_A06_LLLLLVV<T0, T1, T2, T3, T4, T5, T6> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; T5 t5; T6 t6;
			A06_LLLLLVV<T0, T1, T2, T3, T4, T5, T6> delegateA;
			public RunForeachAction_A06_LLLLLVV(A06_LLLLLVV<T0, T1, T2, T3, T4, T5, T6> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(D06_LLLLLVV<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6>(async (info, t0, t1, t2, t3, t4, t5, t6) => t(info, t0, t1, t2, t3, t4, t5, t6));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(A06_LLLLLVV<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A06_LLLLLVV<T0, T1, T2, T3, T4, T5, T6>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item));
		}

		public class RunForeachAction_A06_LLLLLLV<T0, T1, T2, T3, T4, T5, T6> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; T6 t6;
			A06_LLLLLLV<T0, T1, T2, T3, T4, T5, T6> delegateA;
			public RunForeachAction_A06_LLLLLLV(A06_LLLLLLV<T0, T1, T2, T3, T4, T5, T6> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(D06_LLLLLLV<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6>(async (info, t0, t1, t2, t3, t4, t5, t6) => t(info, t0, t1, t2, t3, t4, t5, t6));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(A06_LLLLLLV<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A06_LLLLLLV<T0, T1, T2, T3, T4, T5, T6>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItem<T6>(item));
		}

		public class RunForeachAction_A06_LLLLLLL<T0, T1, T2, T3, T4, T5, T6> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6;
			A06_LLLLLLL<T0, T1, T2, T3, T4, T5, T6> delegateA;
			public RunForeachAction_A06_LLLLLLL(A06_LLLLLLL<T0, T1, T2, T3, T4, T5, T6> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(D06_LLLLLLL<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6>(async (info, t0, t1, t2, t3, t4, t5, t6) => t(info, t0, t1, t2, t3, t4, t5, t6));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(A06_LLLLLLL<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A06_LLLLLLL<T0, T1, T2, T3, T4, T5, T6>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item));
		}

		public class RunForeachAction_A07_VVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7;
			A07_VVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7> delegateA;
			public RunForeachAction_A07_VVVVVVVV(A07_VVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(D07_VVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(async (info, t0, t1, t2, t3, t4, t5, t6, t7) => t(info, t0, t1, t2, t3, t4, t5, t6, t7));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(A07_VVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A07_VVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item));
		}

		public class RunForeachAction_A07_LVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			List<T0> t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7;
			A07_LVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7> delegateA;
			public RunForeachAction_A07_LVVVVVVV(A07_LVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7> delegateA, ObjectBehaviour key, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(D07_LVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(async (info, t0, t1, t2, t3, t4, t5, t6, t7) => t(info, t0, t1, t2, t3, t4, t5, t6, t7));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(A07_LVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A07_LVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item));
		}

		public class RunForeachAction_A07_LLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7;
			A07_LLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7> delegateA;
			public RunForeachAction_A07_LLVVVVVV(A07_LLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(D07_LLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(async (info, t0, t1, t2, t3, t4, t5, t6, t7) => t(info, t0, t1, t2, t3, t4, t5, t6, t7));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(A07_LLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A07_LLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item));
		}

		public class RunForeachAction_A07_LLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7;
			A07_LLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7> delegateA;
			public RunForeachAction_A07_LLLVVVVV(A07_LLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(D07_LLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(async (info, t0, t1, t2, t3, t4, t5, t6, t7) => t(info, t0, t1, t2, t3, t4, t5, t6, t7));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(A07_LLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A07_LLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item));
		}

		public class RunForeachAction_A07_LLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; T4 t4; T5 t5; T6 t6; T7 t7;
			A07_LLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7> delegateA;
			public RunForeachAction_A07_LLLLVVVV(A07_LLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(D07_LLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(async (info, t0, t1, t2, t3, t4, t5, t6, t7) => t(info, t0, t1, t2, t3, t4, t5, t6, t7));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(A07_LLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A07_LLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item));
		}

		public class RunForeachAction_A07_LLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; T5 t5; T6 t6; T7 t7;
			A07_LLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7> delegateA;
			public RunForeachAction_A07_LLLLLVVV(A07_LLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(D07_LLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(async (info, t0, t1, t2, t3, t4, t5, t6, t7) => t(info, t0, t1, t2, t3, t4, t5, t6, t7));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(A07_LLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A07_LLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item));
		}

		public class RunForeachAction_A07_LLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; T6 t6; T7 t7;
			A07_LLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7> delegateA;
			public RunForeachAction_A07_LLLLLLVV(A07_LLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(D07_LLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(async (info, t0, t1, t2, t3, t4, t5, t6, t7) => t(info, t0, t1, t2, t3, t4, t5, t6, t7));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(A07_LLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A07_LLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item));
		}

		public class RunForeachAction_A07_LLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; T7 t7;
			A07_LLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7> delegateA;
			public RunForeachAction_A07_LLLLLLLV(A07_LLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(D07_LLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(async (info, t0, t1, t2, t3, t4, t5, t6, t7) => t(info, t0, t1, t2, t3, t4, t5, t6, t7));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(A07_LLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A07_LLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItem<T7>(item));
		}

		public class RunForeachAction_A07_LLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7;
			A07_LLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7> delegateA;
			public RunForeachAction_A07_LLLLLLLL(A07_LLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(D07_LLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(async (info, t0, t1, t2, t3, t4, t5, t6, t7) => t(info, t0, t1, t2, t3, t4, t5, t6, t7));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(A07_LLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A07_LLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item));
		}

		public class RunForeachAction_A08_VVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8;
			A08_VVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA;
			public RunForeachAction_A08_VVVVVVVVV(A08_VVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(D08_VVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(A08_VVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A08_VVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item));
		}

		public class RunForeachAction_A08_LVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			List<T0> t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8;
			A08_LVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA;
			public RunForeachAction_A08_LVVVVVVVV(A08_LVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA, ObjectBehaviour key, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(D08_LVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(A08_LVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A08_LVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item));
		}

		public class RunForeachAction_A08_LLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8;
			A08_LLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA;
			public RunForeachAction_A08_LLVVVVVVV(A08_LLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(D08_LLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(A08_LLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A08_LLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item));
		}

		public class RunForeachAction_A08_LLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8;
			A08_LLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA;
			public RunForeachAction_A08_LLLVVVVVV(A08_LLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(D08_LLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(A08_LLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A08_LLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item));
		}

		public class RunForeachAction_A08_LLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8;
			A08_LLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA;
			public RunForeachAction_A08_LLLLVVVVV(A08_LLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(D08_LLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(A08_LLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A08_LLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item));
		}

		public class RunForeachAction_A08_LLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; T5 t5; T6 t6; T7 t7; T8 t8;
			A08_LLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA;
			public RunForeachAction_A08_LLLLLVVVV(A08_LLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(D08_LLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(A08_LLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A08_LLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item));
		}

		public class RunForeachAction_A08_LLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; T6 t6; T7 t7; T8 t8;
			A08_LLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA;
			public RunForeachAction_A08_LLLLLLVVV(A08_LLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(D08_LLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(A08_LLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A08_LLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item));
		}

		public class RunForeachAction_A08_LLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; T7 t7; T8 t8;
			A08_LLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA;
			public RunForeachAction_A08_LLLLLLLVV(A08_LLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(D08_LLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(A08_LLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A08_LLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item));
		}

		public class RunForeachAction_A08_LLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; T8 t8;
			A08_LLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA;
			public RunForeachAction_A08_LLLLLLLLV(A08_LLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(D08_LLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(A08_LLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A08_LLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItem<T8>(item));
		}

		public class RunForeachAction_A08_LLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8;
			A08_LLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA;
			public RunForeachAction_A08_LLLLLLLLL(A08_LLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(D08_LLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(A08_LLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A08_LLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item));
		}

		public class RunForeachAction_A09_VVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9;
			A09_VVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09_VVVVVVVVVV(A09_VVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09_VVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09_VVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09_VVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item));
		}

		public class RunForeachAction_A09_LVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			List<T0> t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9;
			A09_LVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09_LVVVVVVVVV(A09_LVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09_LVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09_LVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09_LVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item));
		}

		public class RunForeachAction_A09_LLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9;
			A09_LLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09_LLVVVVVVVV(A09_LLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09_LLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09_LLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09_LLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item));
		}

		public class RunForeachAction_A09_LLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9;
			A09_LLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09_LLLVVVVVVV(A09_LLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09_LLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09_LLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09_LLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item));
		}

		public class RunForeachAction_A09_LLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9;
			A09_LLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09_LLLLVVVVVV(A09_LLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09_LLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09_LLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09_LLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item));
		}

		public class RunForeachAction_A09_LLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9;
			A09_LLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09_LLLLLVVVVV(A09_LLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09_LLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09_LLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09_LLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item));
		}

		public class RunForeachAction_A09_LLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; T6 t6; T7 t7; T8 t8; T9 t9;
			A09_LLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09_LLLLLLVVVV(A09_LLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09_LLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09_LLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09_LLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item));
		}

		public class RunForeachAction_A09_LLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; T7 t7; T8 t8; T9 t9;
			A09_LLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09_LLLLLLLVVV(A09_LLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09_LLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09_LLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09_LLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item));
		}

		public class RunForeachAction_A09_LLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; T8 t8; T9 t9;
			A09_LLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09_LLLLLLLLVV(A09_LLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09_LLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09_LLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09_LLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item));
		}

		public class RunForeachAction_A09_LLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; T9 t9;
			A09_LLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09_LLLLLLLLLV(A09_LLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09_LLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09_LLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09_LLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItem<T9>(item));
		}

		public class RunForeachAction_A09_LLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9;
			A09_LLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09_LLLLLLLLLL(A09_LLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09_LLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09_LLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09_LLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item));
		}

		public class RunForeachAction_A10_VVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10;
			A10_VVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10_VVVVVVVVVVV(A10_VVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10_VVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10_VVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10_VVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10_LVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			List<T0> t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10;
			A10_LVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10_LVVVVVVVVVV(A10_LVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10_LVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10_LVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10_LVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10_LLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10;
			A10_LLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10_LLVVVVVVVVV(A10_LLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10_LLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10_LLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10_LLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10_LLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10;
			A10_LLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10_LLLVVVVVVVV(A10_LLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10_LLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10_LLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10_LLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10_LLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10;
			A10_LLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10_LLLLVVVVVVV(A10_LLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10_LLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10_LLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10_LLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10_LLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10;
			A10_LLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10_LLLLLVVVVVV(A10_LLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10_LLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10_LLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10_LLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10_LLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10;
			A10_LLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10_LLLLLLVVVVV(A10_LLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10_LLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10_LLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10_LLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10_LLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; T7 t7; T8 t8; T9 t9; T10 t10;
			A10_LLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10_LLLLLLLVVVV(A10_LLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10_LLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10_LLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10_LLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10_LLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; T8 t8; T9 t9; T10 t10;
			A10_LLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10_LLLLLLLLVVV(A10_LLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10_LLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10_LLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10_LLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10_LLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; T9 t9; T10 t10;
			A10_LLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10_LLLLLLLLLVV(A10_LLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10_LLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10_LLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10_LLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10_LLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; T10 t10;
			A10_LLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10_LLLLLLLLLLV(A10_LLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10_LLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10_LLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10_LLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10_LLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; List<T10> t10;
			A10_LLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10_LLLLLLLLLLL(A10_LLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10_LLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10_LLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10_LLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item));
		}

		public class RunForeachAction_A11_VVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11_VVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11_VVVVVVVVVVVV(A11_VVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11_VVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11_VVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11_VVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11_LVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			List<T0> t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11_LVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11_LVVVVVVVVVVV(A11_LVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11_LVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11_LVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11_LVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11_LLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11_LLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11_LLVVVVVVVVVV(A11_LLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11_LLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11_LLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11_LLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11_LLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11_LLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11_LLLVVVVVVVVV(A11_LLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11_LLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11_LLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11_LLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11_LLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11_LLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11_LLLLVVVVVVVV(A11_LLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11_LLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11_LLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11_LLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11_LLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11_LLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11_LLLLLVVVVVVV(A11_LLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11_LLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11_LLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11_LLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11_LLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11_LLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11_LLLLLLVVVVVV(A11_LLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11_LLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11_LLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11_LLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11_LLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11_LLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11_LLLLLLLVVVVV(A11_LLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11_LLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11_LLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11_LLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11_LLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11_LLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11_LLLLLLLLVVVV(A11_LLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11_LLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11_LLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11_LLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11_LLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; T9 t9; T10 t10; T11 t11;
			A11_LLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11_LLLLLLLLLVVV(A11_LLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11_LLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11_LLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11_LLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11_LLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; T10 t10; T11 t11;
			A11_LLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11_LLLLLLLLLLVV(A11_LLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11_LLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11_LLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11_LLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11_LLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; List<T10> t10; T11 t11;
			A11_LLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11_LLLLLLLLLLLV(A11_LLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11_LLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11_LLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11_LLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11_LLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; List<T10> t10; List<T11> t11;
			A11_LLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11_LLLLLLLLLLLL(A11_LLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11_LLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11_LLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11_LLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item));
		}

		public class RunForeachAction_A12_VVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12_VVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12_VVVVVVVVVVVVV(A12_VVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12_VVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12_VVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12_VVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12_LVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			List<T0> t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12_LVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12_LVVVVVVVVVVVV(A12_LVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12_LVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12_LVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12_LVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12_LLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12_LLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12_LLVVVVVVVVVVV(A12_LLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12_LLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12_LLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12_LLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12_LLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12_LLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12_LLLVVVVVVVVVV(A12_LLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12_LLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12_LLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12_LLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12_LLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12_LLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12_LLLLVVVVVVVVV(A12_LLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12_LLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12_LLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12_LLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12_LLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12_LLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12_LLLLLVVVVVVVV(A12_LLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12_LLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12_LLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12_LLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12_LLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12_LLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12_LLLLLLVVVVVVV(A12_LLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12_LLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12_LLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12_LLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12_LLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12_LLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12_LLLLLLLVVVVVV(A12_LLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12_LLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12_LLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12_LLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12_LLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12_LLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12_LLLLLLLLVVVVV(A12_LLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12_LLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12_LLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12_LLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12_LLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12_LLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12_LLLLLLLLLVVVV(A12_LLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12_LLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12_LLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12_LLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12_LLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; T10 t10; T11 t11; T12 t12;
			A12_LLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12_LLLLLLLLLLVVV(A12_LLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12_LLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12_LLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12_LLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12_LLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; List<T10> t10; T11 t11; T12 t12;
			A12_LLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12_LLLLLLLLLLLVV(A12_LLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12_LLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12_LLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12_LLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12_LLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; List<T10> t10; List<T11> t11; T12 t12;
			A12_LLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12_LLLLLLLLLLLLV(A12_LLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12_LLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12_LLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12_LLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12_LLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; List<T10> t10; List<T11> t11; List<T12> t12;
			A12_LLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12_LLLLLLLLLLLLL(A12_LLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12_LLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12_LLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12_LLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItems<T12>(item));
		}

		public class RunForeachAction_A13_VVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13_VVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13_VVVVVVVVVVVVVV(A13_VVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13_VVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13_VVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13_VVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13_LVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			List<T0> t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13_LVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13_LVVVVVVVVVVVVV(A13_LVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13_LVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13_LVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13_LVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13_LLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13_LLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13_LLVVVVVVVVVVVV(A13_LLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13_LLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13_LLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13_LLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13_LLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13_LLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13_LLLVVVVVVVVVVV(A13_LLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13_LLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13_LLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13_LLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13_LLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13_LLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13_LLLLVVVVVVVVVV(A13_LLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13_LLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13_LLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13_LLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13_LLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13_LLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13_LLLLLVVVVVVVVV(A13_LLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13_LLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13_LLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13_LLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13_LLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13_LLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13_LLLLLLVVVVVVVV(A13_LLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13_LLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13_LLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13_LLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13_LLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13_LLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13_LLLLLLLVVVVVVV(A13_LLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13_LLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13_LLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13_LLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13_LLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13_LLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13_LLLLLLLLVVVVVV(A13_LLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13_LLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13_LLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13_LLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13_LLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13_LLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13_LLLLLLLLLVVVVV(A13_LLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13_LLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13_LLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13_LLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13_LLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13_LLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13_LLLLLLLLLLVVVV(A13_LLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13_LLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13_LLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13_LLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13_LLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; List<T10> t10; T11 t11; T12 t12; T13 t13;
			A13_LLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13_LLLLLLLLLLLVVV(A13_LLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13_LLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13_LLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13_LLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13_LLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; List<T10> t10; List<T11> t11; T12 t12; T13 t13;
			A13_LLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13_LLLLLLLLLLLLVV(A13_LLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13_LLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13_LLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13_LLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13_LLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; List<T10> t10; List<T11> t11; List<T12> t12; T13 t13;
			A13_LLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13_LLLLLLLLLLLLLV(A13_LLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13_LLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13_LLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13_LLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItems<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13_LLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; List<T10> t10; List<T11> t11; List<T12> t12; List<T13> t13;
			A13_LLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13_LLLLLLLLLLLLLL(A13_LLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, List<T13> t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13_LLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13_LLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13_LLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItems<T12>(item), SetForeachItems<T13>(item));
		}

		public class RunForeachAction_A14_VVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14_VVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14_VVVVVVVVVVVVVVV(A14_VVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14_VVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14_VVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14_VVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14_LVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			List<T0> t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14_LVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14_LVVVVVVVVVVVVVV(A14_LVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14_LVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14_LVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14_LVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14_LLVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14_LLVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14_LLVVVVVVVVVVVVV(A14_LLVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14_LLVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14_LLVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14_LLVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14_LLLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14_LLLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14_LLLVVVVVVVVVVVV(A14_LLLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14_LLLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14_LLLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14_LLLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14_LLLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14_LLLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14_LLLLVVVVVVVVVVV(A14_LLLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14_LLLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14_LLLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14_LLLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14_LLLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14_LLLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14_LLLLLVVVVVVVVVV(A14_LLLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14_LLLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14_LLLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14_LLLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14_LLLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14_LLLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14_LLLLLLVVVVVVVVV(A14_LLLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14_LLLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14_LLLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14_LLLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14_LLLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14_LLLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14_LLLLLLLVVVVVVVV(A14_LLLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14_LLLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14_LLLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14_LLLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14_LLLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14_LLLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14_LLLLLLLLVVVVVVV(A14_LLLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14_LLLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14_LLLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14_LLLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14_LLLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14_LLLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14_LLLLLLLLLVVVVVV(A14_LLLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14_LLLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14_LLLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14_LLLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14_LLLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14_LLLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14_LLLLLLLLLLVVVVV(A14_LLLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14_LLLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14_LLLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14_LLLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14_LLLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; List<T10> t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14_LLLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14_LLLLLLLLLLLVVVV(A14_LLLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14_LLLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14_LLLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14_LLLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14_LLLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; List<T10> t10; List<T11> t11; T12 t12; T13 t13; T14 t14;
			A14_LLLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14_LLLLLLLLLLLLVVV(A14_LLLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14_LLLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14_LLLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14_LLLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14_LLLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; List<T10> t10; List<T11> t11; List<T12> t12; T13 t13; T14 t14;
			A14_LLLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14_LLLLLLLLLLLLLVV(A14_LLLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14_LLLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14_LLLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14_LLLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItems<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14_LLLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; List<T10> t10; List<T11> t11; List<T12> t12; List<T13> t13; T14 t14;
			A14_LLLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14_LLLLLLLLLLLLLLV(A14_LLLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, List<T13> t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14_LLLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14_LLLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14_LLLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItems<T12>(item), SetForeachItems<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14_LLLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; List<T10> t10; List<T11> t11; List<T12> t12; List<T13> t13; List<T14> t14;
			A14_LLLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14_LLLLLLLLLLLLLLL(A14_LLLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, List<T13> t13, List<T14> t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14_LLLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14_LLLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14_LLLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItems<T12>(item), SetForeachItems<T13>(item), SetForeachItems<T14>(item));
		}

		public class RunForeachAction_A15_VVVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15_VVVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15_VVVVVVVVVVVVVVVV(A15_VVVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15_VVVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15_VVVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15_VVVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15_LVVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			List<T0> t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15_LVVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15_LVVVVVVVVVVVVVVV(A15_LVVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, List<T0> t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15_LVVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15_LVVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15_LVVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15_LLVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15_LLVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15_LLVVVVVVVVVVVVVV(A15_LLVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15_LLVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15_LLVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15_LLVVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15_LLLVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15_LLLVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15_LLLVVVVVVVVVVVVV(A15_LLLVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15_LLLVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15_LLLVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15_LLLVVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15_LLLLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15_LLLLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15_LLLLVVVVVVVVVVVV(A15_LLLLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15_LLLLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15_LLLLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15_LLLLVVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15_LLLLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15_LLLLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15_LLLLLVVVVVVVVVVV(A15_LLLLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15_LLLLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15_LLLLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15_LLLLLVVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15_LLLLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15_LLLLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15_LLLLLLVVVVVVVVVV(A15_LLLLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15_LLLLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15_LLLLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15_LLLLLLVVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15_LLLLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15_LLLLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15_LLLLLLLVVVVVVVVV(A15_LLLLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15_LLLLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15_LLLLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15_LLLLLLLVVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15_LLLLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15_LLLLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15_LLLLLLLLVVVVVVVV(A15_LLLLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15_LLLLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15_LLLLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15_LLLLLLLLVVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15_LLLLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15_LLLLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15_LLLLLLLLLVVVVVVV(A15_LLLLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15_LLLLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15_LLLLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15_LLLLLLLLLVVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15_LLLLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15_LLLLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15_LLLLLLLLLLVVVVVV(A15_LLLLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15_LLLLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15_LLLLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15_LLLLLLLLLLVVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15_LLLLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; List<T10> t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15_LLLLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15_LLLLLLLLLLLVVVVV(A15_LLLLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15_LLLLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15_LLLLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15_LLLLLLLLLLLVVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15_LLLLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; List<T10> t10; List<T11> t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15_LLLLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15_LLLLLLLLLLLLVVVV(A15_LLLLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15_LLLLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15_LLLLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15_LLLLLLLLLLLLVVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15_LLLLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; List<T10> t10; List<T11> t11; List<T12> t12; T13 t13; T14 t14; T15 t15;
			A15_LLLLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15_LLLLLLLLLLLLLVVV(A15_LLLLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15_LLLLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15_LLLLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15_LLLLLLLLLLLLLVVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItems<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15_LLLLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; List<T10> t10; List<T11> t11; List<T12> t12; List<T13> t13; T14 t14; T15 t15;
			A15_LLLLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15_LLLLLLLLLLLLLLVV(A15_LLLLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, List<T13> t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15_LLLLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15_LLLLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15_LLLLLLLLLLLLLLVV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItems<T12>(item), SetForeachItems<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15_LLLLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; List<T10> t10; List<T11> t11; List<T12> t12; List<T13> t13; List<T14> t14; T15 t15;
			A15_LLLLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15_LLLLLLLLLLLLLLLV(A15_LLLLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, List<T13> t13, List<T14> t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15_LLLLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15_LLLLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15_LLLLLLLLLLLLLLLV<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItems<T12>(item), SetForeachItems<T13>(item), SetForeachItems<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15_LLLLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			List<T0> t0; List<T1> t1; List<T2> t2; List<T3> t3; List<T4> t4; List<T5> t5; List<T6> t6; List<T7> t7; List<T8> t8; List<T9> t9; List<T10> t10; List<T11> t11; List<T12> t12; List<T13> t13; List<T14> t14; List<T15> t15;
			A15_LLLLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15_LLLLLLLLLLLLLLLL(A15_LLLLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, List<T0> t0, List<T1> t1, List<T2> t2, List<T3> t3, List<T4> t4, List<T5> t5, List<T6> t6, List<T7> t7, List<T8> t8, List<T9> t9, List<T10> t10, List<T11> t11, List<T12> t12, List<T13> t13, List<T14> t14, List<T15> t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15_LLLLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15_LLLLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15_LLLLLLLLLLLLLLLL<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItems<T12>(item), SetForeachItems<T13>(item), SetForeachItems<T14>(item), SetForeachItems<T15>(item));
		}
	}
	#endregion
}