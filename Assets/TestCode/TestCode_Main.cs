#if UNITY_EDITOR && USING_AWAITABLE_LOOP
using System.Collections.Generic;

using BC.ODCC;

using UnityEngine;

using static BC.ODCC.OdccQueryLooper;

public class TestCode_Main : ObjectBehaviour
{
	QuerySystem querySystem;
	OdccQueryCollector queryCollector;

	protected override void BaseAwake()
	{
		base.BaseAwake();
		querySystem = QuerySystemBuilder.CreateQuery()
				.WithAll<TestCodeObject>()                                          // <T,> 의 모든 항목이 반드시 포함해야 함.
				.WithAny<TestCodeComponentA, TestCodeComponentB>()                  // <T,> 중에 하나라도 포함하면 됨.
				.WithNone<TestCodeData>()                                           // <T,> 중에 하나라도 포함하면 안됨
			.Build();                                                               // 위 조건으로 쿼리 생성.

		queryCollector = OdccQueryCollector.CreateQueryCollector(querySystem)       // 해당 쿼리를 사용하는 수집기 생성
			.CreateChangeListEvent(InitTestCode, UpdateTestCode)                    // 쿼리를 만족하는 객체의 변동 사항을 감시 하는 이벤트 생성

			.CreateActionEvent("TempCallEvent")                                     // 수동으로 호출 가능한 이벤트 생성
				.CallForeach<TestCodeObject>(CallEventTestSync)                         // 호출될 이벤트 등록방식 1-1 : 대기 없는 함수 등록
				.CallForeach<TestCodeObject>((_, _) => { })          // 호출될 이벤트 등록방식 1-2 : 대기 없는 함수 등록
				.CallForeach<TestCodeObject>(CallEventTestAsync)                        // 호출될 이벤트 등록방식 2-1 : 대기하는 함수 등록
				.CallForeach<TestCodeObject, TestCodeComponentA>(async (_, _, _) => {
					await Awaitable.NextFrameAsync();                               // 호출될 이벤트 등록방식 2-2 : 대기하는 함수 등록	
				})
				.CallAction(() => { })                                                // Foreach로 탐색 외 다른 이벤트를 수행해야 하는경우. 
				.ShowCallLog(true)                                                  // 호출 로그를 출력할지 여부
			.GetCollector()

			.CreateLooperEvent("TempLoopEvent")                                     // 자동으로 호출되는 Update Loop 생성
				.CallForeach<TestCodeObject>(CallEventTestSync)                         // 호출될 이벤트 등록방식 1-1 : 대기 없는 함수 등록
				.CallForeach<TestCodeObject>((_, _) => { })          // 호출될 이벤트 등록방식 1-2 : 대기 없는 함수 등록
				.CallForeach<TestCodeObject>(CallEventTestAsync)                        // 호출될 이벤트 등록방식 2-1 : 대기하는 함수 등록
				.CallForeach<TestCodeObject, TestCodeComponentA>(async (_, _, _) => {
					await Awaitable.NextFrameAsync();                               // 호출될 이벤트 등록방식 2-2 : 대기하는 함수 등록	
				})
				.CallAction(() => { })                                                // Foreach로 탐색 외 다른 이벤트를 수행해야 하는경우.
				.ShowCallLog(true)                                                  // 호출 로그를 출력할지 여부
			.GetCollector();
	}

	protected override void BaseStart()
	{
		queryCollector.CreateActionEvent("TempCallEvent").RunAction();
	}

	private void InitTestCode(IEnumerable<ObjectBehaviour> enumerable)
	{
	}

	private void UpdateTestCode(ObjectBehaviour behaviour, bool added)
	{
	}

	private void CallEventTestSync(LoopInfo loopInfo, TestCodeObject t0)
	{
	}
	private async Awaitable CallEventTestAsync(LoopInfo loopInfo, TestCodeObject t0)
	{
		await Awaitable.NextFrameAsync();
	}
}
#endif