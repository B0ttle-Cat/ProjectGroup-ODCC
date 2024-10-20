#if UNITY_EDITOR && USING_AWAITABLE_LOOP
using System.Collections.Generic;

using BC.ODCC;

using UnityEngine;

using static BC.ODCC.OdccQueryLooper;

public class TestCode_Main : ObjectBehaviour
{
	QuerySystem querySystem;
	OdccQueryCollector queryCollector;

	public override void BaseAwake()
	{
		base.BaseAwake();
		querySystem = QuerySystemBuilder.CreateQuery()
				.WithAll<TestCodeObject>()                                          // <T,> �� ��� �׸��� �ݵ�� �����ؾ� ��.
				.WithAny<TestCodeComponentA, TestCodeComponentB>()                  // <T,> �߿� �ϳ��� �����ϸ� ��.
				.WithNone<TestCodeData>()                                           // <T,> �߿� �ϳ��� �����ϸ� �ȵ�
			.Build();                                                               // �� �������� ���� ����.

		queryCollector = OdccQueryCollector.CreateQueryCollector(querySystem)       // �ش� ������ ����ϴ� ������ ����
			.CreateChangeListEvent(InitTestCode, UpdateTestCode)                    // ������ �����ϴ� ��ü�� ���� ������ ���� �ϴ� �̺�Ʈ ����

			.CreateActionEvent("TempCallEvent")                                     // �������� ȣ�� ������ �̺�Ʈ ����
				.Foreach<TestCodeObject>(CallEventTestSync)                         // ȣ��� �̺�Ʈ ��Ϲ�� 1-1 : ��� ���� �Լ� ���
				.Foreach<TestCodeObject>((_, _) => { })          // ȣ��� �̺�Ʈ ��Ϲ�� 1-2 : ��� ���� �Լ� ���
				.Foreach<TestCodeObject>(CallEventTestAsync)                        // ȣ��� �̺�Ʈ ��Ϲ�� 2-1 : ����ϴ� �Լ� ���
				.Foreach<TestCodeObject, TestCodeComponentA>(async (_, _, _) => {
					await Awaitable.NextFrameAsync();                               // ȣ��� �̺�Ʈ ��Ϲ�� 2-2 : ����ϴ� �Լ� ���	
				})
				.CallNext(() => { })                                                // Foreach�� Ž�� �� �ٸ� �̺�Ʈ�� �����ؾ� �ϴ°��. 
				.ShowCallLog(true)                                                  // ȣ�� �α׸� ������� ����
			.GetCollector()

			.CreateLooperEvent("TempLoopEvent")                                     // �ڵ����� ȣ��Ǵ� Update Loop ����
				.Foreach<TestCodeObject>(CallEventTestSync)                         // ȣ��� �̺�Ʈ ��Ϲ�� 1-1 : ��� ���� �Լ� ���
				.Foreach<TestCodeObject>((_, _) => { })          // ȣ��� �̺�Ʈ ��Ϲ�� 1-2 : ��� ���� �Լ� ���
				.Foreach<TestCodeObject>(CallEventTestAsync)                        // ȣ��� �̺�Ʈ ��Ϲ�� 2-1 : ����ϴ� �Լ� ���
				.Foreach<TestCodeObject, TestCodeComponentA>(async (_, _, _) => {
					await Awaitable.NextFrameAsync();                               // ȣ��� �̺�Ʈ ��Ϲ�� 2-2 : ����ϴ� �Լ� ���	
				})
				.CallNext(() => { })                                                // Foreach�� Ž�� �� �ٸ� �̺�Ʈ�� �����ؾ� �ϴ°��.
				.ShowCallLog(true)                                                  // ȣ�� �α׸� ������� ����
			.GetCollector();
	}

	public override void BaseStart()
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