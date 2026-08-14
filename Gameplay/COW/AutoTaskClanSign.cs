using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002534")]
public class AutoTaskClanSign : AutoPopupTask
{
	[Token(Token = "0x400E694")]
	[FieldOffset(Offset = "0x8")]
	private UIGuildSignInController m_SignUI;

	[Token(Token = "0x600D86F")]
	[Address(RVA = "0x10EF474", Offset = "0x10EF474", VA = "0x10EF474")]
	public AutoTaskClanSign()
	{
	}

	[Token(Token = "0x600D870")]
	[Address(RVA = "0x10EF47C", Offset = "0x10EF47C", VA = "0x10EF47C", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x600D871")]
	[Address(RVA = "0x10EF6C8", Offset = "0x10EF6C8", VA = "0x10EF6C8", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x600D872")]
	[Address(RVA = "0x10EF7C8", Offset = "0x10EF7C8", VA = "0x10EF7C8", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}
}
