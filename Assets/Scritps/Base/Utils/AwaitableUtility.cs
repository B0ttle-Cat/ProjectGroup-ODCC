﻿using System;
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

		public static async Awaitable<T> WaitAll<T>(params Awaitable<T>[] awaitables)
		{
			T result = default;
			foreach(var awaitable in awaitables)
			{
				try
				{
					result = await awaitable;
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

		public static async Awaitable<T> ParallelWaitAll<T>(params Awaitable<T>[] awaitables)
		{
			T result = default;
			int waitParallel = awaitables.Length;
			foreach(var awaitable in awaitables)
			{
				ParallelUpdate(awaitable);
			}

			while(waitParallel > 0)
			{
				await Awaitable.NextFrameAsync();
			}

			return result;
			async void ParallelUpdate(Awaitable<T> awaitable)
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
	}
}