using System;
using System.Collections.Generic;

namespace BC.Base
{
	public class TupleItem<T1> : Tuple<T1>
	{
		public TupleItem(T1 item1) : base(item1)
		{
		}

		public T Get<T>()
		{
			return Item1 is T t ? t : default;
		}
	}
	public class TupleItem<T1, T2> : Tuple<T1, T2>
	{
		public TupleItem(T1 item1, T2 item2) : base(item1, item2)
		{
		}
		public T Get<T>()
		{
			if(Item1 is T t1) return t1;
			else if(Item2 is T t2) return t2;
			else return default;
		}
	}
	public class TupleItem<T1, T2, T3> : Tuple<T1, T2, T3>
	{
		public TupleItem(T1 item1, T2 item2, T3 item3) : base(item1, item2, item3)
		{
		}
		public T Get<T>()
		{
			if(Item1 is T t1) return t1;
			else if(Item2 is T t2) return t2;
			else if(Item3 is T t3) return t3;
			else return default;
		}
	}
	public class TupleItem<T1, T2, T3, T4> : Tuple<T1, T2, T3, T4>
	{
		public TupleItem(T1 item1, T2 item2, T3 item3, T4 item4) : base(item1, item2, item3, item4)
		{
		}
		public T Get<T>()
		{
			if(Item1 is T t1) return t1;
			else if(Item2 is T t2) return t2;
			else if(Item3 is T t3) return t3;
			else if(Item4 is T t4) return t4;
			else return default;
		}
	}
	public class TupleItem<T1, T2, T3, T4, T5> : Tuple<T1, T2, T3, T4, T5>
	{
		public TupleItem(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) : base(item1, item2, item3, item4, item5)
		{
		}
		public T Get<T>()
		{
			if(Item1 is T t1) return t1;
			else if(Item2 is T t2) return t2;
			else if(Item3 is T t3) return t3;
			else if(Item4 is T t4) return t4;
			else if(Item5 is T t5) return t5;
			else return default;
		}
	}
	public class TupleItem<T1, T2, T3, T4, T5, T6> : Tuple<T1, T2, T3, T4, T5, T6>
	{
		public TupleItem(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) : base(item1, item2, item3, item4, item5, item6)
		{
		}
		public T Get<T>()
		{
			if(Item1 is T t1) return t1;
			else if(Item2 is T t2) return t2;
			else if(Item3 is T t3) return t3;
			else if(Item4 is T t4) return t4;
			else if(Item5 is T t5) return t5;
			else if(Item6 is T t6) return t6;
			else return default;
		}
	}
	public class TupleItem<T1, T2, T3, T4, T5, T6, T7> : Tuple<T1, T2, T3, T4, T5, T6, T7>
	{
		public TupleItem(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) : base(item1, item2, item3, item4, item5, item6, item7)
		{
		}
		public T Get<T>()
		{
			if(Item1 is T t1) return t1;
			else if(Item2 is T t2) return t2;
			else if(Item3 is T t3) return t3;
			else if(Item4 is T t4) return t4;
			else if(Item5 is T t5) return t5;
			else if(Item6 is T t6) return t6;
			else if(Item7 is T t7) return t7;
			else return default;
		}
	}

	public class TupleDictionary<TKey, T1> : Dictionary<TKey, Tuple<T1>>
	{

	}
	public class TupleDictionary<TKey, T1, T2> : Dictionary<TKey, TupleItem<T1, T2>> { }
	public class TupleDictionary<TKey, T1, T2, T3> : Dictionary<TKey, TupleItem<T1, T2, T3>> { }
	public class TupleDictionary<TKey, T1, T2, T3, T4> : Dictionary<TKey, TupleItem<T1, T2, T3, T4>> { }
	public class TupleDictionary<TKey, T1, T2, T3, T4, T5> : Dictionary<TKey, TupleItem<T1, T2, T3, T4, T5>> { }
	public class TupleDictionary<TKey, T1, T2, T3, T4, T5, T6> : Dictionary<TKey, TupleItem<T1, T2, T3, T4, T5, T6>> { }
	public class TupleDictionary<TKey, T1, T2, T3, T4, T5, T6, T7> : Dictionary<TKey, TupleItem<T1, T2, T3, T4, T5, T6, T7>> { }

}
