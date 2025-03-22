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
					if(condition())
					{
						return;
					}
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
			await WaitAll(default, awaitables);
		}
		public static async Awaitable WaitAll(CancellationToken cancellationToken, params Awaitable[] awaitables)
		{
			foreach(var awaitable in awaitables)
			{

				try
				{
					if(awaitable == null || !cancellationToken.CanBeCanceled) continue;
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
			return await WaitAll(default, awaitables);
		}
		public static async Awaitable<T[]> WaitAll<T>(CancellationToken cancellationToken, params Awaitable<T>[] awaitables)
		{
			int length = awaitables.Length;
			T[] result = new T[length];
			for(int i = 0 ; i<length ; i++)
			{
				try
				{
					var awaitable = awaitables[i];
					if(awaitable == null || !cancellationToken.CanBeCanceled) continue;
					result[i] = await awaitable;
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
			await ParallelWaitAll(default, awaitables);
		}
		public static async Awaitable ParallelWaitAll(CancellationToken cancellationToken, params Awaitable[] awaitables)
		{
			int waitParallel = awaitables.Length;
			foreach(var awaitable in awaitables)
			{
				if(awaitable == null) continue;
				ParallelUpdate(awaitable);
			}

			while(waitParallel > 0 && cancellationToken.CanBeCanceled)
			{
				await Awaitable.NextFrameAsync(cancellationToken);
			}
			async void ParallelUpdate(Awaitable awaitable)
			{
				await awaitable;
				waitParallel--;
			}
		}
		public static async Awaitable<T[]> ParallelWaitAll<T>(params Awaitable<T>[] awaitables)
		{
			return await ParallelWaitAll(default, awaitables);
		}
		public static async Awaitable<T[]> ParallelWaitAll<T>(CancellationToken cancellationToken, params Awaitable<T>[] awaitables)
		{
			int length = awaitables.Length;
			T[] result = new T[length];
			int waitParallel = length;
			for(int i = 0 ; i<length ; i++)
			{
				Awaitable<T> awaitable = awaitables[i];
				if(awaitable == null)
				{
					waitParallel--;
					continue;
				}
				ParallelUpdate(i, awaitable);
			}

			while(waitParallel > 0 && cancellationToken.CanBeCanceled)
			{
				await Awaitable.NextFrameAsync(cancellationToken);
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
			return await ParallelWaitAll(default, resultAwaitables, awaitables);
		}
		public static async Awaitable<T> ParallelWaitAll<T>(CancellationToken cancellationToken, Awaitable<T> resultAwaitables, params Awaitable[] awaitables)
		{
			int length = awaitables.Length;
			T result = default;
			int waitParallel = length + 1;
			ResultParallelUpdate(resultAwaitables);
			for(int i = 0 ; i<length ; i++)
			{
				Awaitable awaitable = awaitables[i];
				if(awaitable == null)
				{
					waitParallel--;
					continue;
				}
				ParallelUpdate(awaitable);
			}

			while(waitParallel > 0 && cancellationToken.CanBeCanceled)
			{
				await Awaitable.NextFrameAsync(cancellationToken);
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
			await ParallelWaitAny(default, awaitables);
		}
		public static async Awaitable ParallelWaitAny(CancellationToken cancellationToken, params Awaitable[] awaitables)
		{
			bool waitParallel = true;
			foreach(Awaitable awaitable in awaitables)
			{
				if(awaitable == null || !cancellationToken.CanBeCanceled) continue;
				ParallelUpdate(awaitable);
			}

			while(waitParallel || cancellationToken.CanBeCanceled)
			{
				await Awaitable.NextFrameAsync(cancellationToken);
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
			return await ParallelWaitAny(default, awaitables);
		}
		public static async Awaitable<T> ParallelWaitAny<T>(CancellationToken cancellationToken, params Awaitable<T>[] awaitables)
		{
			T result = default;
			bool waitParallel = true;
			foreach(var awaitable in awaitables)
			{
				if(awaitable == null || !cancellationToken.CanBeCanceled) continue;
				ParallelUpdate(awaitable);
			}

			while(waitParallel && cancellationToken.CanBeCanceled)
			{
				await Awaitable.NextFrameAsync(cancellationToken);
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
			return await ParallelWaitAny(default, resultAwaitables, awaitables);
		}
		public static async Awaitable<T> ParallelWaitAny<T>(CancellationToken cancellationToken, Awaitable<T> resultAwaitables, params Awaitable[] awaitables)
		{
			T result = default;
			bool waitResult = true;
			bool waitParallel = true;
			foreach(var awaitable in awaitables)
			{
				if(awaitable == null || !cancellationToken.CanBeCanceled) continue;
				ParallelUpdate(awaitable);
			}

			while((waitParallel || waitResult) && cancellationToken.CanBeCanceled)
			{
				await Awaitable.NextFrameAsync(cancellationToken);
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