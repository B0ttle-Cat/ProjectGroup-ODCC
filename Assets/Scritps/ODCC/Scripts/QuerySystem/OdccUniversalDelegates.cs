/// 이 코드는 <see cref=\"BC.ODCC.OdccUniversalDelegatesGenerator\"/>에서 자동완성 됩니다.
namespace BC.ODCC
{
	using System.Collections.Generic;

#if UNITY_EDITOR
	public class OdccUniversalDelegates { }
#endif

	#region Delegate
	public delegate void D();
	public delegate void D00I00<T0>(OdccQueryLooper.LoopInfo loopInfo, T0 t0) where T0 : class, IOdccItem;
	public delegate void D00I01<T0>(OdccQueryLooper.LoopInfo loopInfo, T0 t0) where T0 : class, ICollection<IOdccAttach>, new();
	public delegate void D01I00<T0, T1>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1) where T0 : class, IOdccItem where T1 : class, IOdccItem;
	public delegate void D01I01<T0, T1>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem;
	public delegate void D01I02<T0, T1>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new();
	public delegate void D02I00<T0, T1, T2>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem;
	public delegate void D02I01<T0, T1, T2>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem;
	public delegate void D02I02<T0, T1, T2>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem;
	public delegate void D02I03<T0, T1, T2>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new();
	public delegate void D03I00<T0, T1, T2, T3>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem;
	public delegate void D03I01<T0, T1, T2, T3>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem;
	public delegate void D03I02<T0, T1, T2, T3>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem;
	public delegate void D03I03<T0, T1, T2, T3>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem;
	public delegate void D03I04<T0, T1, T2, T3>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new();
	public delegate void D04I00<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate void D04I01<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate void D04I02<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate void D04I03<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate void D04I04<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem;
	public delegate void D04I05<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new();
	public delegate void D05I00<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate void D05I01<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate void D05I02<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate void D05I03<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate void D05I04<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate void D05I05<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem;
	public delegate void D05I06<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new();
	public delegate void D06I00<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate void D06I01<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate void D06I02<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate void D06I03<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate void D06I04<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate void D06I05<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate void D06I06<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem;
	public delegate void D06I07<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new();
	public delegate void D07I00<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate void D07I01<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate void D07I02<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate void D07I03<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate void D07I04<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate void D07I05<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate void D07I06<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate void D07I07<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem;
	public delegate void D07I08<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new();
	public delegate void D08I00<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate void D08I01<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate void D08I02<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate void D08I03<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate void D08I04<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate void D08I05<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate void D08I06<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate void D08I07<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate void D08I08<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem;
	public delegate void D08I09<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new();
	public delegate void D09I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate void D09I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate void D09I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate void D09I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate void D09I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate void D09I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate void D09I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate void D09I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate void D09I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate void D09I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem;
	public delegate void D09I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new();
	public delegate void D10I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D10I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D10I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D10I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D10I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D10I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D10I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D10I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D10I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D10I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate void D10I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem;
	public delegate void D10I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new();
	public delegate void D11I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate void D11I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem;
	public delegate void D11I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new();
	public delegate void D12I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate void D12I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, IOdccItem;
	public delegate void D12I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new();
	public delegate void D13I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate void D13I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, IOdccItem;
	public delegate void D13I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new();
	public delegate void D14I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate void D14I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, IOdccItem;
	public delegate void D14I15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, ICollection<IOdccAttach>, new();
	public delegate void D15I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate void D15I15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, ICollection<IOdccAttach>, new() where T15 : class, IOdccItem;
	public delegate void D15I16<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, ICollection<IOdccAttach>, new() where T15 : class, ICollection<IOdccAttach>, new();
	public delegate UnityEngine.Awaitable A();
	public delegate UnityEngine.Awaitable A00I00<T0>(OdccQueryLooper.LoopInfo loopInfo, T0 t0) where T0 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A00I01<T0>(OdccQueryLooper.LoopInfo loopInfo, T0 t0) where T0 : class, ICollection<IOdccAttach>, new();
	public delegate UnityEngine.Awaitable A01I00<T0, T1>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1) where T0 : class, IOdccItem where T1 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A01I01<T0, T1>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A01I02<T0, T1>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new();
	public delegate UnityEngine.Awaitable A02I00<T0, T1, T2>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A02I01<T0, T1, T2>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A02I02<T0, T1, T2>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A02I03<T0, T1, T2>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new();
	public delegate UnityEngine.Awaitable A03I00<T0, T1, T2, T3>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A03I01<T0, T1, T2, T3>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A03I02<T0, T1, T2, T3>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A03I03<T0, T1, T2, T3>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A03I04<T0, T1, T2, T3>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new();
	public delegate UnityEngine.Awaitable A04I00<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A04I01<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A04I02<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A04I03<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A04I04<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A04I05<T0, T1, T2, T3, T4>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new();
	public delegate UnityEngine.Awaitable A05I00<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A05I01<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A05I02<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A05I03<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A05I04<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A05I05<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A05I06<T0, T1, T2, T3, T4, T5>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new();
	public delegate UnityEngine.Awaitable A06I00<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A06I01<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A06I02<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A06I03<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A06I04<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A06I05<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A06I06<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A06I07<T0, T1, T2, T3, T4, T5, T6>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new();
	public delegate UnityEngine.Awaitable A07I00<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A07I01<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A07I02<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A07I03<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A07I04<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A07I05<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A07I06<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A07I07<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A07I08<T0, T1, T2, T3, T4, T5, T6, T7>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new();
	public delegate UnityEngine.Awaitable A08I00<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A08I01<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A08I02<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A08I03<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A08I04<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A08I05<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A08I06<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A08I07<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A08I08<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A08I09<T0, T1, T2, T3, T4, T5, T6, T7, T8>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new();
	public delegate UnityEngine.Awaitable A09I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A09I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A09I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A09I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A09I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A09I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A09I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A09I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A09I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A09I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A09I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new();
	public delegate UnityEngine.Awaitable A10I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A10I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new();
	public delegate UnityEngine.Awaitable A11I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A11I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new();
	public delegate UnityEngine.Awaitable A12I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A12I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new();
	public delegate UnityEngine.Awaitable A13I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, IOdccItem where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A13I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new();
	public delegate UnityEngine.Awaitable A14I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, IOdccItem where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A14I15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, ICollection<IOdccAttach>, new();
	public delegate UnityEngine.Awaitable A15I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, IOdccItem where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15I15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, ICollection<IOdccAttach>, new() where T15 : class, IOdccItem;
	public delegate UnityEngine.Awaitable A15I16<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(OdccQueryLooper.LoopInfo loopInfo, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, ICollection<IOdccAttach>, new() where T15 : class, ICollection<IOdccAttach>, new();
	#endregion

	#region QuerySystemBuilder
	/// 이 코드는 <see cref=\"BC.ODCC.QuerySystemBuilder\"/>를 확장합니다.
	public partial class QuerySystemBuilder
	{
		public QuerySystemBuilder WithAny<T0>() where T0 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0)));
		public QuerySystemBuilder WithAny<T0, T1>() where T0 : class, IOdccItem where T1 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1)));
		public QuerySystemBuilder WithAny<T0, T1, T2>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14)));
		public QuerySystemBuilder WithAny<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem => WithAny(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15)));
		public QuerySystemBuilder WithNone<T0>() where T0 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0)));
		public QuerySystemBuilder WithNone<T0, T1>() where T0 : class, IOdccItem where T1 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1)));
		public QuerySystemBuilder WithNone<T0, T1, T2>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14)));
		public QuerySystemBuilder WithNone<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem => WithNone(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15)));
		public QuerySystemBuilder WithAll<T0>() where T0 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0)));
		public QuerySystemBuilder WithAll<T0, T1>() where T0 : class, IOdccItem where T1 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1)));
		public QuerySystemBuilder WithAll<T0, T1, T2>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14)));
		public QuerySystemBuilder WithAll<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>() where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem => WithAll(OdccManager.GetTypeToIndex(typeof(T0), typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5), typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11), typeof(T12), typeof(T13), typeof(T14), typeof(T15)));
	}
	#endregion

	#region OdccQueryLooper
	/// 이 코드는 <see cref=\"BC.ODCC.OdccQueryLooper\"/>를 확장합니다.
	public partial class OdccQueryLooper
	{

		public class RunForeachAction_A00I00<T0> : RunForeachAction where T0 : class, IOdccItem
		{
			T0 t0;
			A00I00<T0> delegateA;
			public RunForeachAction_A00I00(A00I00<T0> delegateA, ObjectBehaviour key, T0 t0)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0);
		}
		public OdccQueryLooper CallForeach<T0>(D00I00<T0> t = null) where T0 : class, IOdccItem
		{
			return CallForeach<T0>(async (info, t0) => t(info, t0));
		}
		public OdccQueryLooper CallForeach<T0>(A00I00<T0> t = null) where T0 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A00I00<T0>(t, item, SetForeachItem<T0>(item));
		}

		public class RunForeachAction_A00I01<T0> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new()
		{
			T0 t0;
			A00I01<T0> delegateA;
			public RunForeachAction_A00I01(A00I01<T0> delegateA, ObjectBehaviour key, T0 t0)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0);
		}
		public OdccQueryLooper CallForeach<T0>(D00I01<T0> t = null) where T0 : class, ICollection<IOdccAttach>, new()
		{
			return CallForeach<T0>(async (info, t0) => t(info, t0));
		}
		public OdccQueryLooper CallForeach<T0>(A00I01<T0> t = null) where T0 : class, ICollection<IOdccAttach>, new()
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A00I01<T0>(t, item, SetForeachItems<T0>(item));
		}

		public class RunForeachAction_A01I00<T0, T1> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem
		{
			T0 t0; T1 t1;
			A01I00<T0, T1> delegateA;
			public RunForeachAction_A01I00(A01I00<T0, T1> delegateA, ObjectBehaviour key, T0 t0, T1 t1)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1);
		}
		public OdccQueryLooper CallForeach<T0, T1>(D01I00<T0, T1> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem
		{
			return CallForeach<T0, T1>(async (info, t0, t1) => t(info, t0, t1));
		}
		public OdccQueryLooper CallForeach<T0, T1>(A01I00<T0, T1> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A01I00<T0, T1>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item));
		}

		public class RunForeachAction_A01I01<T0, T1> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem
		{
			T0 t0; T1 t1;
			A01I01<T0, T1> delegateA;
			public RunForeachAction_A01I01(A01I01<T0, T1> delegateA, ObjectBehaviour key, T0 t0, T1 t1)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1);
		}
		public OdccQueryLooper CallForeach<T0, T1>(D01I01<T0, T1> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem
		{
			return CallForeach<T0, T1>(async (info, t0, t1) => t(info, t0, t1));
		}
		public OdccQueryLooper CallForeach<T0, T1>(A01I01<T0, T1> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A01I01<T0, T1>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item));
		}

		public class RunForeachAction_A01I02<T0, T1> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new()
		{
			T0 t0; T1 t1;
			A01I02<T0, T1> delegateA;
			public RunForeachAction_A01I02(A01I02<T0, T1> delegateA, ObjectBehaviour key, T0 t0, T1 t1)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1);
		}
		public OdccQueryLooper CallForeach<T0, T1>(D01I02<T0, T1> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new()
		{
			return CallForeach<T0, T1>(async (info, t0, t1) => t(info, t0, t1));
		}
		public OdccQueryLooper CallForeach<T0, T1>(A01I02<T0, T1> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new()
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A01I02<T0, T1>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item));
		}

		public class RunForeachAction_A02I00<T0, T1, T2> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2;
			A02I00<T0, T1, T2> delegateA;
			public RunForeachAction_A02I00(A02I00<T0, T1, T2> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2>(D02I00<T0, T1, T2> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2>(async (info, t0, t1, t2) => t(info, t0, t1, t2));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2>(A02I00<T0, T1, T2> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A02I00<T0, T1, T2>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item));
		}

		public class RunForeachAction_A02I01<T0, T1, T2> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2;
			A02I01<T0, T1, T2> delegateA;
			public RunForeachAction_A02I01(A02I01<T0, T1, T2> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2>(D02I01<T0, T1, T2> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2>(async (info, t0, t1, t2) => t(info, t0, t1, t2));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2>(A02I01<T0, T1, T2> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A02I01<T0, T1, T2>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item));
		}

		public class RunForeachAction_A02I02<T0, T1, T2> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2;
			A02I02<T0, T1, T2> delegateA;
			public RunForeachAction_A02I02(A02I02<T0, T1, T2> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2>(D02I02<T0, T1, T2> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2>(async (info, t0, t1, t2) => t(info, t0, t1, t2));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2>(A02I02<T0, T1, T2> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A02I02<T0, T1, T2>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item));
		}

		public class RunForeachAction_A02I03<T0, T1, T2> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new()
		{
			T0 t0; T1 t1; T2 t2;
			A02I03<T0, T1, T2> delegateA;
			public RunForeachAction_A02I03(A02I03<T0, T1, T2> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2>(D02I03<T0, T1, T2> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new()
		{
			return CallForeach<T0, T1, T2>(async (info, t0, t1, t2) => t(info, t0, t1, t2));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2>(A02I03<T0, T1, T2> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new()
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A02I03<T0, T1, T2>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item));
		}

		public class RunForeachAction_A03I00<T0, T1, T2, T3> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3;
			A03I00<T0, T1, T2, T3> delegateA;
			public RunForeachAction_A03I00(A03I00<T0, T1, T2, T3> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3>(D03I00<T0, T1, T2, T3> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3>(async (info, t0, t1, t2, t3) => t(info, t0, t1, t2, t3));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3>(A03I00<T0, T1, T2, T3> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A03I00<T0, T1, T2, T3>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item));
		}

		public class RunForeachAction_A03I01<T0, T1, T2, T3> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3;
			A03I01<T0, T1, T2, T3> delegateA;
			public RunForeachAction_A03I01(A03I01<T0, T1, T2, T3> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3>(D03I01<T0, T1, T2, T3> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3>(async (info, t0, t1, t2, t3) => t(info, t0, t1, t2, t3));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3>(A03I01<T0, T1, T2, T3> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A03I01<T0, T1, T2, T3>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item));
		}

		public class RunForeachAction_A03I02<T0, T1, T2, T3> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3;
			A03I02<T0, T1, T2, T3> delegateA;
			public RunForeachAction_A03I02(A03I02<T0, T1, T2, T3> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3>(D03I02<T0, T1, T2, T3> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3>(async (info, t0, t1, t2, t3) => t(info, t0, t1, t2, t3));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3>(A03I02<T0, T1, T2, T3> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A03I02<T0, T1, T2, T3>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item));
		}

		public class RunForeachAction_A03I03<T0, T1, T2, T3> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3;
			A03I03<T0, T1, T2, T3> delegateA;
			public RunForeachAction_A03I03(A03I03<T0, T1, T2, T3> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3>(D03I03<T0, T1, T2, T3> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3>(async (info, t0, t1, t2, t3) => t(info, t0, t1, t2, t3));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3>(A03I03<T0, T1, T2, T3> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A03I03<T0, T1, T2, T3>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item));
		}

		public class RunForeachAction_A03I04<T0, T1, T2, T3> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new()
		{
			T0 t0; T1 t1; T2 t2; T3 t3;
			A03I04<T0, T1, T2, T3> delegateA;
			public RunForeachAction_A03I04(A03I04<T0, T1, T2, T3> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3>(D03I04<T0, T1, T2, T3> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new()
		{
			return CallForeach<T0, T1, T2, T3>(async (info, t0, t1, t2, t3) => t(info, t0, t1, t2, t3));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3>(A03I04<T0, T1, T2, T3> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new()
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A03I04<T0, T1, T2, T3>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item));
		}

		public class RunForeachAction_A04I00<T0, T1, T2, T3, T4> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4;
			A04I00<T0, T1, T2, T3, T4> delegateA;
			public RunForeachAction_A04I00(A04I00<T0, T1, T2, T3, T4> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(D04I00<T0, T1, T2, T3, T4> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4>(async (info, t0, t1, t2, t3, t4) => t(info, t0, t1, t2, t3, t4));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(A04I00<T0, T1, T2, T3, T4> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A04I00<T0, T1, T2, T3, T4>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item));
		}

		public class RunForeachAction_A04I01<T0, T1, T2, T3, T4> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4;
			A04I01<T0, T1, T2, T3, T4> delegateA;
			public RunForeachAction_A04I01(A04I01<T0, T1, T2, T3, T4> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(D04I01<T0, T1, T2, T3, T4> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4>(async (info, t0, t1, t2, t3, t4) => t(info, t0, t1, t2, t3, t4));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(A04I01<T0, T1, T2, T3, T4> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A04I01<T0, T1, T2, T3, T4>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item));
		}

		public class RunForeachAction_A04I02<T0, T1, T2, T3, T4> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4;
			A04I02<T0, T1, T2, T3, T4> delegateA;
			public RunForeachAction_A04I02(A04I02<T0, T1, T2, T3, T4> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(D04I02<T0, T1, T2, T3, T4> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4>(async (info, t0, t1, t2, t3, t4) => t(info, t0, t1, t2, t3, t4));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(A04I02<T0, T1, T2, T3, T4> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A04I02<T0, T1, T2, T3, T4>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item));
		}

		public class RunForeachAction_A04I03<T0, T1, T2, T3, T4> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4;
			A04I03<T0, T1, T2, T3, T4> delegateA;
			public RunForeachAction_A04I03(A04I03<T0, T1, T2, T3, T4> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(D04I03<T0, T1, T2, T3, T4> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4>(async (info, t0, t1, t2, t3, t4) => t(info, t0, t1, t2, t3, t4));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(A04I03<T0, T1, T2, T3, T4> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A04I03<T0, T1, T2, T3, T4>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item));
		}

		public class RunForeachAction_A04I04<T0, T1, T2, T3, T4> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4;
			A04I04<T0, T1, T2, T3, T4> delegateA;
			public RunForeachAction_A04I04(A04I04<T0, T1, T2, T3, T4> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(D04I04<T0, T1, T2, T3, T4> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4>(async (info, t0, t1, t2, t3, t4) => t(info, t0, t1, t2, t3, t4));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(A04I04<T0, T1, T2, T3, T4> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A04I04<T0, T1, T2, T3, T4>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item));
		}

		public class RunForeachAction_A04I05<T0, T1, T2, T3, T4> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new()
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4;
			A04I05<T0, T1, T2, T3, T4> delegateA;
			public RunForeachAction_A04I05(A04I05<T0, T1, T2, T3, T4> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(D04I05<T0, T1, T2, T3, T4> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new()
		{
			return CallForeach<T0, T1, T2, T3, T4>(async (info, t0, t1, t2, t3, t4) => t(info, t0, t1, t2, t3, t4));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4>(A04I05<T0, T1, T2, T3, T4> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new()
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A04I05<T0, T1, T2, T3, T4>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item));
		}

		public class RunForeachAction_A05I00<T0, T1, T2, T3, T4, T5> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5;
			A05I00<T0, T1, T2, T3, T4, T5> delegateA;
			public RunForeachAction_A05I00(A05I00<T0, T1, T2, T3, T4, T5> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(D05I00<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5>(async (info, t0, t1, t2, t3, t4, t5) => t(info, t0, t1, t2, t3, t4, t5));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(A05I00<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A05I00<T0, T1, T2, T3, T4, T5>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item));
		}

		public class RunForeachAction_A05I01<T0, T1, T2, T3, T4, T5> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5;
			A05I01<T0, T1, T2, T3, T4, T5> delegateA;
			public RunForeachAction_A05I01(A05I01<T0, T1, T2, T3, T4, T5> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(D05I01<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5>(async (info, t0, t1, t2, t3, t4, t5) => t(info, t0, t1, t2, t3, t4, t5));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(A05I01<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A05I01<T0, T1, T2, T3, T4, T5>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item));
		}

		public class RunForeachAction_A05I02<T0, T1, T2, T3, T4, T5> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5;
			A05I02<T0, T1, T2, T3, T4, T5> delegateA;
			public RunForeachAction_A05I02(A05I02<T0, T1, T2, T3, T4, T5> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(D05I02<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5>(async (info, t0, t1, t2, t3, t4, t5) => t(info, t0, t1, t2, t3, t4, t5));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(A05I02<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A05I02<T0, T1, T2, T3, T4, T5>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item));
		}

		public class RunForeachAction_A05I03<T0, T1, T2, T3, T4, T5> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5;
			A05I03<T0, T1, T2, T3, T4, T5> delegateA;
			public RunForeachAction_A05I03(A05I03<T0, T1, T2, T3, T4, T5> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(D05I03<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5>(async (info, t0, t1, t2, t3, t4, t5) => t(info, t0, t1, t2, t3, t4, t5));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(A05I03<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A05I03<T0, T1, T2, T3, T4, T5>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item));
		}

		public class RunForeachAction_A05I04<T0, T1, T2, T3, T4, T5> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5;
			A05I04<T0, T1, T2, T3, T4, T5> delegateA;
			public RunForeachAction_A05I04(A05I04<T0, T1, T2, T3, T4, T5> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(D05I04<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5>(async (info, t0, t1, t2, t3, t4, t5) => t(info, t0, t1, t2, t3, t4, t5));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(A05I04<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A05I04<T0, T1, T2, T3, T4, T5>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item));
		}

		public class RunForeachAction_A05I05<T0, T1, T2, T3, T4, T5> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5;
			A05I05<T0, T1, T2, T3, T4, T5> delegateA;
			public RunForeachAction_A05I05(A05I05<T0, T1, T2, T3, T4, T5> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(D05I05<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5>(async (info, t0, t1, t2, t3, t4, t5) => t(info, t0, t1, t2, t3, t4, t5));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(A05I05<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A05I05<T0, T1, T2, T3, T4, T5>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item));
		}

		public class RunForeachAction_A05I06<T0, T1, T2, T3, T4, T5> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new()
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5;
			A05I06<T0, T1, T2, T3, T4, T5> delegateA;
			public RunForeachAction_A05I06(A05I06<T0, T1, T2, T3, T4, T5> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(D05I06<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new()
		{
			return CallForeach<T0, T1, T2, T3, T4, T5>(async (info, t0, t1, t2, t3, t4, t5) => t(info, t0, t1, t2, t3, t4, t5));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5>(A05I06<T0, T1, T2, T3, T4, T5> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new()
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A05I06<T0, T1, T2, T3, T4, T5>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item));
		}

		public class RunForeachAction_A06I00<T0, T1, T2, T3, T4, T5, T6> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6;
			A06I00<T0, T1, T2, T3, T4, T5, T6> delegateA;
			public RunForeachAction_A06I00(A06I00<T0, T1, T2, T3, T4, T5, T6> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(D06I00<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6>(async (info, t0, t1, t2, t3, t4, t5, t6) => t(info, t0, t1, t2, t3, t4, t5, t6));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(A06I00<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A06I00<T0, T1, T2, T3, T4, T5, T6>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item));
		}

		public class RunForeachAction_A06I01<T0, T1, T2, T3, T4, T5, T6> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6;
			A06I01<T0, T1, T2, T3, T4, T5, T6> delegateA;
			public RunForeachAction_A06I01(A06I01<T0, T1, T2, T3, T4, T5, T6> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(D06I01<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6>(async (info, t0, t1, t2, t3, t4, t5, t6) => t(info, t0, t1, t2, t3, t4, t5, t6));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(A06I01<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A06I01<T0, T1, T2, T3, T4, T5, T6>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item));
		}

		public class RunForeachAction_A06I02<T0, T1, T2, T3, T4, T5, T6> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6;
			A06I02<T0, T1, T2, T3, T4, T5, T6> delegateA;
			public RunForeachAction_A06I02(A06I02<T0, T1, T2, T3, T4, T5, T6> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(D06I02<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6>(async (info, t0, t1, t2, t3, t4, t5, t6) => t(info, t0, t1, t2, t3, t4, t5, t6));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(A06I02<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A06I02<T0, T1, T2, T3, T4, T5, T6>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item));
		}

		public class RunForeachAction_A06I03<T0, T1, T2, T3, T4, T5, T6> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6;
			A06I03<T0, T1, T2, T3, T4, T5, T6> delegateA;
			public RunForeachAction_A06I03(A06I03<T0, T1, T2, T3, T4, T5, T6> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(D06I03<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6>(async (info, t0, t1, t2, t3, t4, t5, t6) => t(info, t0, t1, t2, t3, t4, t5, t6));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(A06I03<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A06I03<T0, T1, T2, T3, T4, T5, T6>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item));
		}

		public class RunForeachAction_A06I04<T0, T1, T2, T3, T4, T5, T6> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6;
			A06I04<T0, T1, T2, T3, T4, T5, T6> delegateA;
			public RunForeachAction_A06I04(A06I04<T0, T1, T2, T3, T4, T5, T6> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(D06I04<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6>(async (info, t0, t1, t2, t3, t4, t5, t6) => t(info, t0, t1, t2, t3, t4, t5, t6));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(A06I04<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A06I04<T0, T1, T2, T3, T4, T5, T6>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item));
		}

		public class RunForeachAction_A06I05<T0, T1, T2, T3, T4, T5, T6> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6;
			A06I05<T0, T1, T2, T3, T4, T5, T6> delegateA;
			public RunForeachAction_A06I05(A06I05<T0, T1, T2, T3, T4, T5, T6> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(D06I05<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6>(async (info, t0, t1, t2, t3, t4, t5, t6) => t(info, t0, t1, t2, t3, t4, t5, t6));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(A06I05<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A06I05<T0, T1, T2, T3, T4, T5, T6>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item));
		}

		public class RunForeachAction_A06I06<T0, T1, T2, T3, T4, T5, T6> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6;
			A06I06<T0, T1, T2, T3, T4, T5, T6> delegateA;
			public RunForeachAction_A06I06(A06I06<T0, T1, T2, T3, T4, T5, T6> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(D06I06<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6>(async (info, t0, t1, t2, t3, t4, t5, t6) => t(info, t0, t1, t2, t3, t4, t5, t6));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(A06I06<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A06I06<T0, T1, T2, T3, T4, T5, T6>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItem<T6>(item));
		}

		public class RunForeachAction_A06I07<T0, T1, T2, T3, T4, T5, T6> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new()
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6;
			A06I07<T0, T1, T2, T3, T4, T5, T6> delegateA;
			public RunForeachAction_A06I07(A06I07<T0, T1, T2, T3, T4, T5, T6> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(D06I07<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new()
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6>(async (info, t0, t1, t2, t3, t4, t5, t6) => t(info, t0, t1, t2, t3, t4, t5, t6));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6>(A06I07<T0, T1, T2, T3, T4, T5, T6> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new()
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A06I07<T0, T1, T2, T3, T4, T5, T6>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item));
		}

		public class RunForeachAction_A07I00<T0, T1, T2, T3, T4, T5, T6, T7> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7;
			A07I00<T0, T1, T2, T3, T4, T5, T6, T7> delegateA;
			public RunForeachAction_A07I00(A07I00<T0, T1, T2, T3, T4, T5, T6, T7> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(D07I00<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(async (info, t0, t1, t2, t3, t4, t5, t6, t7) => t(info, t0, t1, t2, t3, t4, t5, t6, t7));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(A07I00<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A07I00<T0, T1, T2, T3, T4, T5, T6, T7>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item));
		}

		public class RunForeachAction_A07I01<T0, T1, T2, T3, T4, T5, T6, T7> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7;
			A07I01<T0, T1, T2, T3, T4, T5, T6, T7> delegateA;
			public RunForeachAction_A07I01(A07I01<T0, T1, T2, T3, T4, T5, T6, T7> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(D07I01<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(async (info, t0, t1, t2, t3, t4, t5, t6, t7) => t(info, t0, t1, t2, t3, t4, t5, t6, t7));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(A07I01<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A07I01<T0, T1, T2, T3, T4, T5, T6, T7>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item));
		}

		public class RunForeachAction_A07I02<T0, T1, T2, T3, T4, T5, T6, T7> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7;
			A07I02<T0, T1, T2, T3, T4, T5, T6, T7> delegateA;
			public RunForeachAction_A07I02(A07I02<T0, T1, T2, T3, T4, T5, T6, T7> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(D07I02<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(async (info, t0, t1, t2, t3, t4, t5, t6, t7) => t(info, t0, t1, t2, t3, t4, t5, t6, t7));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(A07I02<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A07I02<T0, T1, T2, T3, T4, T5, T6, T7>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item));
		}

		public class RunForeachAction_A07I03<T0, T1, T2, T3, T4, T5, T6, T7> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7;
			A07I03<T0, T1, T2, T3, T4, T5, T6, T7> delegateA;
			public RunForeachAction_A07I03(A07I03<T0, T1, T2, T3, T4, T5, T6, T7> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(D07I03<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(async (info, t0, t1, t2, t3, t4, t5, t6, t7) => t(info, t0, t1, t2, t3, t4, t5, t6, t7));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(A07I03<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A07I03<T0, T1, T2, T3, T4, T5, T6, T7>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item));
		}

		public class RunForeachAction_A07I04<T0, T1, T2, T3, T4, T5, T6, T7> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7;
			A07I04<T0, T1, T2, T3, T4, T5, T6, T7> delegateA;
			public RunForeachAction_A07I04(A07I04<T0, T1, T2, T3, T4, T5, T6, T7> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(D07I04<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(async (info, t0, t1, t2, t3, t4, t5, t6, t7) => t(info, t0, t1, t2, t3, t4, t5, t6, t7));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(A07I04<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A07I04<T0, T1, T2, T3, T4, T5, T6, T7>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item));
		}

		public class RunForeachAction_A07I05<T0, T1, T2, T3, T4, T5, T6, T7> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7;
			A07I05<T0, T1, T2, T3, T4, T5, T6, T7> delegateA;
			public RunForeachAction_A07I05(A07I05<T0, T1, T2, T3, T4, T5, T6, T7> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(D07I05<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(async (info, t0, t1, t2, t3, t4, t5, t6, t7) => t(info, t0, t1, t2, t3, t4, t5, t6, t7));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(A07I05<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A07I05<T0, T1, T2, T3, T4, T5, T6, T7>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item));
		}

		public class RunForeachAction_A07I06<T0, T1, T2, T3, T4, T5, T6, T7> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7;
			A07I06<T0, T1, T2, T3, T4, T5, T6, T7> delegateA;
			public RunForeachAction_A07I06(A07I06<T0, T1, T2, T3, T4, T5, T6, T7> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(D07I06<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(async (info, t0, t1, t2, t3, t4, t5, t6, t7) => t(info, t0, t1, t2, t3, t4, t5, t6, t7));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(A07I06<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A07I06<T0, T1, T2, T3, T4, T5, T6, T7>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item));
		}

		public class RunForeachAction_A07I07<T0, T1, T2, T3, T4, T5, T6, T7> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7;
			A07I07<T0, T1, T2, T3, T4, T5, T6, T7> delegateA;
			public RunForeachAction_A07I07(A07I07<T0, T1, T2, T3, T4, T5, T6, T7> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(D07I07<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(async (info, t0, t1, t2, t3, t4, t5, t6, t7) => t(info, t0, t1, t2, t3, t4, t5, t6, t7));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(A07I07<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A07I07<T0, T1, T2, T3, T4, T5, T6, T7>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItem<T7>(item));
		}

		public class RunForeachAction_A07I08<T0, T1, T2, T3, T4, T5, T6, T7> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new()
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7;
			A07I08<T0, T1, T2, T3, T4, T5, T6, T7> delegateA;
			public RunForeachAction_A07I08(A07I08<T0, T1, T2, T3, T4, T5, T6, T7> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(D07I08<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new()
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(async (info, t0, t1, t2, t3, t4, t5, t6, t7) => t(info, t0, t1, t2, t3, t4, t5, t6, t7));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7>(A07I08<T0, T1, T2, T3, T4, T5, T6, T7> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new()
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A07I08<T0, T1, T2, T3, T4, T5, T6, T7>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item));
		}

		public class RunForeachAction_A08I00<T0, T1, T2, T3, T4, T5, T6, T7, T8> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8;
			A08I00<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA;
			public RunForeachAction_A08I00(A08I00<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(D08I00<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(A08I00<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A08I00<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item));
		}

		public class RunForeachAction_A08I01<T0, T1, T2, T3, T4, T5, T6, T7, T8> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8;
			A08I01<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA;
			public RunForeachAction_A08I01(A08I01<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(D08I01<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(A08I01<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A08I01<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item));
		}

		public class RunForeachAction_A08I02<T0, T1, T2, T3, T4, T5, T6, T7, T8> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8;
			A08I02<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA;
			public RunForeachAction_A08I02(A08I02<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(D08I02<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(A08I02<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A08I02<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item));
		}

		public class RunForeachAction_A08I03<T0, T1, T2, T3, T4, T5, T6, T7, T8> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8;
			A08I03<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA;
			public RunForeachAction_A08I03(A08I03<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(D08I03<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(A08I03<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A08I03<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item));
		}

		public class RunForeachAction_A08I04<T0, T1, T2, T3, T4, T5, T6, T7, T8> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8;
			A08I04<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA;
			public RunForeachAction_A08I04(A08I04<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(D08I04<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(A08I04<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A08I04<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item));
		}

		public class RunForeachAction_A08I05<T0, T1, T2, T3, T4, T5, T6, T7, T8> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8;
			A08I05<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA;
			public RunForeachAction_A08I05(A08I05<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(D08I05<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(A08I05<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A08I05<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item));
		}

		public class RunForeachAction_A08I06<T0, T1, T2, T3, T4, T5, T6, T7, T8> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8;
			A08I06<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA;
			public RunForeachAction_A08I06(A08I06<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(D08I06<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(A08I06<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A08I06<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item));
		}

		public class RunForeachAction_A08I07<T0, T1, T2, T3, T4, T5, T6, T7, T8> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8;
			A08I07<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA;
			public RunForeachAction_A08I07(A08I07<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(D08I07<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(A08I07<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A08I07<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item));
		}

		public class RunForeachAction_A08I08<T0, T1, T2, T3, T4, T5, T6, T7, T8> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8;
			A08I08<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA;
			public RunForeachAction_A08I08(A08I08<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(D08I08<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(A08I08<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A08I08<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItem<T8>(item));
		}

		public class RunForeachAction_A08I09<T0, T1, T2, T3, T4, T5, T6, T7, T8> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new()
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8;
			A08I09<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA;
			public RunForeachAction_A08I09(A08I09<T0, T1, T2, T3, T4, T5, T6, T7, T8> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(D08I09<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new()
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8>(A08I09<T0, T1, T2, T3, T4, T5, T6, T7, T8> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new()
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A08I09<T0, T1, T2, T3, T4, T5, T6, T7, T8>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item));
		}

		public class RunForeachAction_A09I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9;
			A09I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09I00(A09I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item));
		}

		public class RunForeachAction_A09I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9;
			A09I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09I01(A09I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item));
		}

		public class RunForeachAction_A09I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9;
			A09I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09I02(A09I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item));
		}

		public class RunForeachAction_A09I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9;
			A09I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09I03(A09I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item));
		}

		public class RunForeachAction_A09I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9;
			A09I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09I04(A09I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item));
		}

		public class RunForeachAction_A09I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9;
			A09I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09I05(A09I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item));
		}

		public class RunForeachAction_A09I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9;
			A09I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09I06(A09I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item));
		}

		public class RunForeachAction_A09I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9;
			A09I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09I07(A09I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item));
		}

		public class RunForeachAction_A09I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9;
			A09I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09I08(A09I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item));
		}

		public class RunForeachAction_A09I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9;
			A09I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09I09(A09I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItem<T9>(item));
		}

		public class RunForeachAction_A09I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new()
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9;
			A09I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA;
			public RunForeachAction_A09I10(A09I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(D09I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new()
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(A09I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new()
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A09I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item));
		}

		public class RunForeachAction_A10I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10;
			A10I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10I00(A10I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10;
			A10I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10I01(A10I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10;
			A10I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10I02(A10I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10;
			A10I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10I03(A10I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10;
			A10I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10I04(A10I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10;
			A10I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10I05(A10I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10;
			A10I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10I06(A10I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10;
			A10I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10I07(A10I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10;
			A10I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10I08(A10I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10;
			A10I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10I09(A10I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10;
			A10I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10I10(A10I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItem<T10>(item));
		}

		public class RunForeachAction_A10I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new()
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10;
			A10I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA;
			public RunForeachAction_A10I11(A10I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(D10I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new()
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(A10I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new()
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A10I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item));
		}

		public class RunForeachAction_A11I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11I00(A11I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11I01(A11I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11I02(A11I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11I03(A11I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11I04(A11I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11I05(A11I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11I06(A11I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11I07(A11I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11I08(A11I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11I09(A11I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11I10(A11I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11I11(A11I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItem<T11>(item));
		}

		public class RunForeachAction_A11I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new()
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11;
			A11I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA;
			public RunForeachAction_A11I12(A11I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(D11I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new()
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(A11I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new()
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A11I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item));
		}

		public class RunForeachAction_A12I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12I00(A12I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12I01(A12I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12I02(A12I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12I03(A12I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12I04(A12I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12I05(A12I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12I06(A12I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12I07(A12I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12I08(A12I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12I09(A12I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12I10(A12I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12I11(A12I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12I12(A12I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItem<T12>(item));
		}

		public class RunForeachAction_A12I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new()
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12;
			A12I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA;
			public RunForeachAction_A12I13(A12I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(D12I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new()
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(A12I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new()
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A12I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItems<T12>(item));
		}

		public class RunForeachAction_A13I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13I00(A13I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13I01(A13I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13I02(A13I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13I03(A13I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13I04(A13I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13I05(A13I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13I06(A13I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13I07(A13I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13I08(A13I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13I09(A13I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13I10(A13I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13I11(A13I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13I12(A13I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, IOdccItem where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, IOdccItem where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13I13(A13I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItems<T12>(item), SetForeachItem<T13>(item));
		}

		public class RunForeachAction_A13I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new()
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13;
			A13I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA;
			public RunForeachAction_A13I14(A13I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(D13I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new()
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(A13I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new()
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A13I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItems<T12>(item), SetForeachItems<T13>(item));
		}

		public class RunForeachAction_A14I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14I00(A14I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14I01(A14I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14I02(A14I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14I03(A14I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14I04(A14I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14I05(A14I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14I06(A14I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14I07(A14I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14I08(A14I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14I09(A14I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14I10(A14I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14I11(A14I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14I12(A14I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14I13(A14I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, IOdccItem where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, IOdccItem where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItems<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14I14(A14I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItems<T12>(item), SetForeachItems<T13>(item), SetForeachItem<T14>(item));
		}

		public class RunForeachAction_A14I15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, ICollection<IOdccAttach>, new()
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14;
			A14I15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA;
			public RunForeachAction_A14I15(A14I15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(D14I15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, ICollection<IOdccAttach>, new()
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(A14I15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, ICollection<IOdccAttach>, new()
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A14I15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItems<T12>(item), SetForeachItems<T13>(item), SetForeachItems<T14>(item));
		}

		public class RunForeachAction_A15I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15I00(A15I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, IOdccItem where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15I00<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItem<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15I01(A15I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, IOdccItem where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15I01<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItem<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15I02(A15I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, IOdccItem where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15I02<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItem<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15I03(A15I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, IOdccItem where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15I03<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItem<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15I04(A15I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, IOdccItem where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15I04<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItem<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15I05(A15I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, IOdccItem where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15I05<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItem<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15I06(A15I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, IOdccItem where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15I06<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItem<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15I07(A15I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, IOdccItem where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15I07<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItem<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15I08(A15I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, IOdccItem where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15I08<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItem<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15I09(A15I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, IOdccItem where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15I09<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItem<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15I10(A15I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, IOdccItem where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15I10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItem<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15I11(A15I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, IOdccItem where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15I11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItem<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15I12(A15I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, IOdccItem where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15I12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItem<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15I13(A15I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, IOdccItem where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15I13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItems<T12>(item), SetForeachItem<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15I14(A15I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, IOdccItem where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, IOdccItem where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15I14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItems<T12>(item), SetForeachItems<T13>(item), SetForeachItem<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15I15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, ICollection<IOdccAttach>, new() where T15 : class, IOdccItem
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15I15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15I15(A15I15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15I15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, ICollection<IOdccAttach>, new() where T15 : class, IOdccItem
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15I15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, ICollection<IOdccAttach>, new() where T15 : class, IOdccItem
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15I15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItems<T12>(item), SetForeachItems<T13>(item), SetForeachItems<T14>(item), SetForeachItem<T15>(item));
		}

		public class RunForeachAction_A15I16<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : RunForeachAction where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, ICollection<IOdccAttach>, new() where T15 : class, ICollection<IOdccAttach>, new()
		{
			T0 t0; T1 t1; T2 t2; T3 t3; T4 t4; T5 t5; T6 t6; T7 t7; T8 t8; T9 t9; T10 t10; T11 t11; T12 t12; T13 t13; T14 t14; T15 t15;
			A15I16<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA;
			public RunForeachAction_A15I16(A15I16<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateA, ObjectBehaviour key, T0 t0, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
			{
				this.key = key;
				this.delegateA=delegateA; this.t0 = t0; this.t1 = t1; this.t2 = t2; this.t3 = t3; this.t4 = t4; this.t5 = t5; this.t6 = t6; this.t7 = t7; this.t8 = t8; this.t9 = t9; this.t10 = t10; this.t11 = t11; this.t12 = t12; this.t13 = t13; this.t14 = t14; this.t15 = t15;
			}
			internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(D15I16<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, ICollection<IOdccAttach>, new() where T15 : class, ICollection<IOdccAttach>, new()
		{
			return CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(async (info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) => t(info, t0, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
		}
		public OdccQueryLooper CallForeach<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(A15I16<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> t = null) where T0 : class, ICollection<IOdccAttach>, new() where T1 : class, ICollection<IOdccAttach>, new() where T2 : class, ICollection<IOdccAttach>, new() where T3 : class, ICollection<IOdccAttach>, new() where T4 : class, ICollection<IOdccAttach>, new() where T5 : class, ICollection<IOdccAttach>, new() where T6 : class, ICollection<IOdccAttach>, new() where T7 : class, ICollection<IOdccAttach>, new() where T8 : class, ICollection<IOdccAttach>, new() where T9 : class, ICollection<IOdccAttach>, new() where T10 : class, ICollection<IOdccAttach>, new() where T11 : class, ICollection<IOdccAttach>, new() where T12 : class, ICollection<IOdccAttach>, new() where T13 : class, ICollection<IOdccAttach>, new() where T14 : class, ICollection<IOdccAttach>, new() where T15 : class, ICollection<IOdccAttach>, new()
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
			RunForeachAction CreateRunLoopAction(ObjectBehaviour item) => new RunForeachAction_A15I16<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(t, item, SetForeachItems<T0>(item), SetForeachItems<T1>(item), SetForeachItems<T2>(item), SetForeachItems<T3>(item), SetForeachItems<T4>(item), SetForeachItems<T5>(item), SetForeachItems<T6>(item), SetForeachItems<T7>(item), SetForeachItems<T8>(item), SetForeachItems<T9>(item), SetForeachItems<T10>(item), SetForeachItems<T11>(item), SetForeachItems<T12>(item), SetForeachItems<T13>(item), SetForeachItems<T14>(item), SetForeachItems<T15>(item));
		}
	}
	#endregion
}