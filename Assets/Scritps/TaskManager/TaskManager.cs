using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace BC.Base
{
	public static class TaskManager
	{
		private static ConcurrentDictionary<object, CancellationTokenSource> keyToken = new ConcurrentDictionary<object, CancellationTokenSource>();
		public static CancellationTokenSource Run(object key, Func<Task> function)
		{
			Stop(key);

			CancellationTokenSource cancellationToken = new CancellationTokenSource();
			CancellationToken token = cancellationToken.Token;
			keyToken.AddOrUpdate(key, cancellationToken, (_, _) => cancellationToken);
			Task.Run(async () =>
			{
				try
				{
					await function.Invoke();
				}
				catch(TaskCanceledException ex)
				{
					Debug.LogException(ex);
				}
				catch(Exception ex)
				{
					Debug.LogException(ex);
				}
				finally
				{
					cancellationToken.Dispose();
					keyToken.TryRemove(key, out var _);
				}
			}, token);
			return cancellationToken;
		}
		public static CancellationTokenSource Run(object key, Func<CancellationToken, Task> function, Action cancelCallback)
		{
			Stop(key);

			CancellationTokenSource cancellationToken = new CancellationTokenSource();
			CancellationToken token = cancellationToken.Token;
			keyToken.AddOrUpdate(key, cancellationToken, (_, _) => cancellationToken);
			Task.Run(async () =>
			{
				try
				{
					await function.Invoke(token);
				}
				catch(TaskCanceledException ex)
				{
					Debug.Log(ex.Message);
					cancelCallback?.Invoke();
				}
				catch(Exception ex)
				{
					Debug.LogException(ex);
				}
				finally
				{
					Dispose(key);
				}
			}, token);
			return cancellationToken;
		}
		public static void Stop(object key)
		{
			if(keyToken.TryRemove(key, out var token))
			{
				token.Cancel();
			}
		}
		public static void Dispose(object key)
		{
			if(keyToken.TryRemove(key, out var token))
			{
				token.Dispose();
			}
		}
	}
}
