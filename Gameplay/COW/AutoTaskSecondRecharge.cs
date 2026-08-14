using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E6D")]
internal class AutoTaskSecondRecharge : AutoPopupTask
{
	[Token(Token = "0x400BF6B")]
	[FieldOffset(Offset = "0x8")]
	private UISecondRechargeController m_PopupWnd;

	[Token(Token = "0x600922D")]
	[Address(RVA = "0x10F990C", Offset = "0x10F990C", VA = "0x10F990C")]
	public AutoTaskSecondRecharge()
	{
	}

	[Token(Token = "0x600922E")]
	[Address(RVA = "0x10F9914", Offset = "0x10F9914", VA = "0x10F9914", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x600922F")]
	[Address(RVA = "0x10F996C", Offset = "0x10F996C", VA = "0x10F996C", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x6009230")]
	[Address(RVA = "0x10F9BEC", Offset = "0x10F9BEC", VA = "0x10F9BEC", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
