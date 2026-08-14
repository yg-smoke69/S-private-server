using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E42")]
public class AutoPopup
{
	[Token(Token = "0x2001E43")]
	public enum State
	{
		[Token(Token = "0x400BF15")]
		None,
		[Token(Token = "0x400BF16")]
		Start,
		[Token(Token = "0x400BF17")]
		End
	}

	[Token(Token = "0x2001E44")]
	public enum TaskState
	{
		[Token(Token = "0x400BF19")]
		None,
		[Token(Token = "0x400BF1A")]
		WatingData,
		[Token(Token = "0x400BF1B")]
		Do,
		[Token(Token = "0x400BF1C")]
		WaitingDone,
		[Token(Token = "0x400BF1D")]
		Finished
	}

	[Token(Token = "0x2001E45")]
	public class ScheduleTask
	{
		[Token(Token = "0x400BF1E")]
		[FieldOffset(Offset = "0x8")]
		public TaskState state;

		[Token(Token = "0x400BF1F")]
		[FieldOffset(Offset = "0xC")]
		public List<int> waitHttpMessages;

		[Token(Token = "0x400BF20")]
		[FieldOffset(Offset = "0x10")]
		public HttpRequest currentWaitHttpRequest;

		[Token(Token = "0x400BF21")]
		[FieldOffset(Offset = "0x14")]
		public AutoPopupTask task;

		[Token(Token = "0x600917B")]
		[Address(RVA = "0x10E7234", Offset = "0x10E7234", VA = "0x10E7234")]
		public ScheduleTask()
		{
		}
	}

	[Token(Token = "0x400BF11")]
	[FieldOffset(Offset = "0x8")]
	private State m_State;

	[Token(Token = "0x400BF12")]
	[FieldOffset(Offset = "0xC")]
	private List<ScheduleTask> m_ScheduleTasks;

	[Token(Token = "0x400BF13")]
	[FieldOffset(Offset = "0x10")]
	private UIModelUser m_ModelUser;

	[Token(Token = "0x6009174")]
	[Address(RVA = "0x10E6F2C", Offset = "0x10E6F2C", VA = "0x10E6F2C")]
	public AutoPopup()
	{
	}

	[Token(Token = "0x6009175")]
	[Address(RVA = "0x10E7028", Offset = "0x10E7028", VA = "0x10E7028")]
	public void StartTask()
	{
	}

	[Token(Token = "0x6009176")]
	[Address(RVA = "0x10E7084", Offset = "0x10E7084", VA = "0x10E7084")]
	public void StopTask()
	{
	}

	[Token(Token = "0x6009177")]
	[Address(RVA = "0x10E70E0", Offset = "0x10E70E0", VA = "0x10E70E0")]
	public State NowState()
	{
		return default(State);
	}

	[Token(Token = "0x6009178")]
	[Address(RVA = "0x10E7138", Offset = "0x10E7138", VA = "0x10E7138")]
	public void AddTask(AutoPopupTask task)
	{
	}

	[Token(Token = "0x6009179")]
	[Address(RVA = "0x10E72C0", Offset = "0x10E72C0", VA = "0x10E72C0")]
	public void Update()
	{
	}

	[Token(Token = "0x600917A")]
	[Address(RVA = "0x10E7680", Offset = "0x10E7680", VA = "0x10E7680")]
	public void Reset()
	{
	}
}
