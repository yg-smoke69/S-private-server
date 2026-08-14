using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E5C")]
public class AutoTaskDebt : AutoPopupTask
{
	[Token(Token = "0x400BF4A")]
	[FieldOffset(Offset = "0x8")]
	private UIDebtWindowController m_DebtUI;

	[Token(Token = "0x60091DF")]
	[Address(RVA = "0x10F2F8C", Offset = "0x10F2F8C", VA = "0x10F2F8C")]
	public AutoTaskDebt()
	{
	}

	[Token(Token = "0x60091E0")]
	[Address(RVA = "0x10F2F94", Offset = "0x10F2F94", VA = "0x10F2F94", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x60091E1")]
	[Address(RVA = "0x10F2FEC", Offset = "0x10F2FEC", VA = "0x10F2FEC", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x60091E2")]
	[Address(RVA = "0x10F3238", Offset = "0x10F3238", VA = "0x10F3238", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
