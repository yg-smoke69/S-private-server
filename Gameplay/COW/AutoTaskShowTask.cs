using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E6E")]
internal class AutoTaskShowTask : AutoPopupTask
{
	[Token(Token = "0x400BF6C")]
	[FieldOffset(Offset = "0x8")]
	private UITaskController m_TaskUI;

	[Token(Token = "0x6009231")]
	[Address(RVA = "0x10F9CEC", Offset = "0x10F9CEC", VA = "0x10F9CEC")]
	public AutoTaskShowTask()
	{
	}

	[Token(Token = "0x6009232")]
	[Address(RVA = "0x10F9CF4", Offset = "0x10F9CF4", VA = "0x10F9CF4", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x6009233")]
	[Address(RVA = "0x10F9E00", Offset = "0x10F9E00", VA = "0x10F9E00", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x6009234")]
	[Address(RVA = "0x10FA34C", Offset = "0x10FA34C", VA = "0x10FA34C", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
