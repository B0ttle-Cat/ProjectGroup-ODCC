using System;
using System.Threading;

using UnityEngine;

namespace BC.Base
{
	public static class AwaitableUtility
	{
		public static async Awaitable WaitTrue(Func<bool> condition, CancellationToken cancellationToken = default(CancellationToken))
		{
			if(condition == null) return;
			while(true)
			{
				try
				{
					cancellationToken.ThrowIfCancellationRequested();
					if(condition()) return;
					await Awaitable.NextFrameAsync(cancellationToken);
				}
				catch(Exception ex)
				{
					Debug.LogException(ex);
					return;
				}
			}
		}
		public static async Awaitable WaitFalse(Func<bool> condition, CancellationToken cancellationToken = default(CancellationToken))
		{
			if(condition == null) return;
			while(true)
			{
				try
				{
					cancellationToken.ThrowIfCancellationRequested();
					if(!condition()) return;
					await Awaitable.NextFrameAsync(cancellationToken);
				}
				catch(Exception ex)
				{
					Debug.LogException(ex);
					return;
				}
			}
		}
		public static async Awaitable<T> WaitNotNull<T>(Func<T> checkT, CancellationToken cancellationToken = default(CancellationToken)) where T : class
		{
			if(checkT == null) return null;
			while(true)
			{
				try
				{
					cancellationToken.ThrowIfCancellationRequested();
					var t = checkT();
					if(t != null) return t;
					await Awaitable.NextFrameAsync(cancellationToken);
				}
				catch(Exception ex)
				{
					Debug.LogException(ex);
					return null;
				}
			}
		}
		public static async Awaitable<T> WaitIsNull<T>(Func<T> checkT, CancellationToken cancellationToken = default(CancellationToken)) where T : class
		{
			if(checkT == null) return null;
			while(true)
			{
				try
				{
					cancellationToken.ThrowIfCancellationRequested();
					var t = checkT();
					if(t == null) return t;
					await Awaitable.NextFrameAsync(cancellationToken);
				}
				catch(Exception ex)
				{
					Debug.LogException(ex);
					return null;
				}
			}
		}
		public static async Awaitable WaitAll(params Awaitable[] awaitables)
		{
			foreach(var awaitable in awaitables)
			{

				try
				{
					await awaitable;
				}
				catch(Exception ex)
				{
					Debug.LogException(ex);
					continue;
				}
			}
		}

		public static async Awaitable<T[]> WaitAll<T>(params Awaitable<T>[] awaitables)
		{
			int length = awaitables.Length;
			T[] result = new T[length];
			for(int i = 0 ; i<length ; i++)
			{
				try
				{
					result[i] = await awaitables[i];
				}
				catch(Exception ex)
				{
					Debug.LogException(ex);
					continue;
				}
			}
			return result;
		}

		public static async Awaitable ParallelWaitAll(params Awaitable[] awaitables)
		{
			int waitParallel = awaitables.Length;
			foreach(var awaitable in awaitables)
			{
				ParallelUpdate(awaitable);
			}

			while(waitParallel > 0)
			{
				await Awaitable.NextFrameAsync();
			}
			async void ParallelUpdate(Awaitable awaitable)
			{
				await awaitable;
				waitParallel--;
			}
		}

		public static async Awaitable<T[]> ParallelWaitAll<T>(params Awaitable<T>[] awaitables)
		{
			int length = awaitables.Length;
			T[] result = new T[length];
			int waitParallel = length;
			for(int i = 0 ; i<length ; i++)
			{
				Awaitable<T> awaitable = awaitables[i];
				ParallelUpdate(i, awaitable);
			}

			while(waitParallel > 0)
			{
				await Awaitable.NextFrameAsync();
			}

			return result;
			async void ParallelUpdate(int index, Awaitable<T> awaitable)
			{
				result[index] = await awaitable;
				waitParallel--;
			}
		}
		public static async Awaitable<T> ParallelWaitAll<T>(Awaitable<T> resultAwaitables, params Awaitable[] awaitables)
		{
			int length = awaitables.Length + 1;
			T result = default;
			int waitParallel = length;
			ResultParallelUpdate(resultAwaitables);
			for(int i = 0 ; i<length ; i++)
			{
				Awaitable awaitable = awaitables[i];
				ParallelUpdate(awaitable);
			}

			while(waitParallel > 0)
			{
				await Awaitable.NextFrameAsync();
			}

			return result;
			async void ParallelUpdate(Awaitable awaitable)
			{
				await awaitable;
				waitParallel--;
			}
			async void ResultParallelUpdate(Awaitable<T> awaitable)
			{
				result = await awaitable;
				waitParallel--;
			}
		}


		public static async Awaitable ParallelWaitAny(params Awaitable[] awaitables)
		{
			bool waitParallel = true;
			foreach(Awaitable awaitable in awaitables)
			{
				ParallelUpdate(awaitable);
			}

			while(waitParallel)
			{
				await Awaitable.NextFrameAsync();
			}
			foreach(var awaitable in awaitables)
			{
				try
				{
					awaitable.Cancel();
				}
				catch(System.OperationCanceledException cancel) { }
			}
			async void ParallelUpdate(Awaitable awaitable)
			{
				await awaitable;
				waitParallel = false;
			}
		}

		public static async Awaitable<T> ParallelWaitAny<T>(params Awaitable<T>[] awaitables)
		{
			T result = default;
			bool waitParallel = true;
			foreach(var awaitable in awaitables)
			{
				ParallelUpdate(awaitable);
			}

			while(waitParallel)
			{
				await Awaitable.NextFrameAsync();
			}
			foreach(var awaitable in awaitables)
			{
				try
				{
					awaitable.Cancel();
				}
				catch(System.OperationCanceledException cancel) { }
			}
			return result;
			async void ParallelUpdate(Awaitable<T> awaitable)
			{
				var _result = await awaitable;
				if(waitParallel)
				{
					result = _result;
				}
				waitParallel = false;
			}
		}

		public static async Awaitable<T> ParallelWaitAny<T>(Awaitable<T> resultAwaitables, params Awaitable[] awaitables)
		{
			T result = default;
			bool waitResult = true;
			bool waitParallel = true;
			foreach(var awaitable in awaitables)
			{
				ParallelUpdate(awaitable);
			}

			while(waitParallel || waitResult)
			{
				await Awaitable.NextFrameAsync();
			}
			foreach(var awaitable in awaitables)
			{
				try
				{
					awaitable.Cancel();
				}
				catch(System.OperationCanceledException cancel) { }
			}
			return result;
			async void ParallelUpdate(Awaitable awaitable)
			{
				await awaitable;
				waitParallel = false;
			}
			async void ResultParallelUpdate(Awaitable<T> awaitable)
			{
				result = await awaitable;
				waitResult = false;
			}
		}
	}
}