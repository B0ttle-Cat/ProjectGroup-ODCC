#if UNITY_EDITOR && USING_AWAITABLE_LOOP
using System;
using System.Collections.Generic;

using UnityEngine;

using static UnityEngine.Awaitable;

public class Test : MonoBehaviour
{
	Func<Awaitable> GetLoop;
	Awaitable awaitable;
	Awaiter? loop;

	public void Start()
	{
		GetLoop = TestAwaitable;
		awaitable = null;
	}

	// Update is called once per frame
	List<Awaitable> list = new List<Awaitable>();
	void Update()
	{
		if(awaitable is null || awaitable.IsCompleted)
		{
			awaitable = GetLoop();
		}
	}
	void LateUpdate()
	{
		if(awaitable is null || awaitable.IsCompleted)
		{
			awaitable = GetLoop();
		}
	}

	private async Awaitable TestAwaitable()
	{
		try
		{
			TestFunc2();
			//await TestFunc();
		}
		catch(Exception ex)
		{
			Debug.LogException(ex);
		}
	}


	public void TestFunc2()
	{
		Debug.Log($"ENDED {Time.frameCount} ===============");
	}
	public async Awaitable TestFunc()
	{
		Debug.Log($"START {Time.frameCount} ===============");
		await Awaitable.EndOfFrameAsync();
		Debug.Log($"ENDED {Time.frameCount} ===============");
	}
}
#endif