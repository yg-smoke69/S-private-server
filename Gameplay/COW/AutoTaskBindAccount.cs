using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E4C")]
public class AutoTaskBindAccount : AutoPopupTask
{
	[Token(Token = "0x400BF28")]
	[FieldOffset(Offset = "0x8")]
	private UIBindAccountController m_UIBindAccountController;

	[Token(Token = "0x6009197")]
	[Address(RVA = "0x10EAA08", Offset = "0x10EAA08", VA = "0x10EAA08")]
	public AutoTaskBindAccount()
	{
	}

	[Token(Token = "0x6009198")]
	[Address(RVA = "0x10EAA10", Offset = "0x10EAA10", VA = "0x10EAA10", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x6009199")]
	[Address(RVA = "0x10EADC8", Offset = "0x10EADC8", VA = "0x10EADC8", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x600919A")]
	[Address(RVA = "0x10EAC10", Offset = "0x10EAC10", VA = "0x10EAC10")]
	public bool IsNeedBindAccountWndShow()
	{
		return default(bool);
	}

	[Token(Token = "0x600919B")]
	[Address(RVA = "0x10EAEC8", Offset = "0x10EAEC8", VA = "0x10EAEC8", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}
}
