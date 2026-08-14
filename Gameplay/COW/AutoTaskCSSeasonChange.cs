using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E6C")]
internal class AutoTaskCSSeasonChange : AutoPopupTask
{
	[Token(Token = "0x400BF6A")]
	[FieldOffset(Offset = "0x8")]
	private UICSLadderMatchSeasonChangeController m_CsSeasonChangeCtrl;

	[Token(Token = "0x6009229")]
	[Address(RVA = "0x10EBB60", Offset = "0x10EBB60", VA = "0x10EBB60")]
	public AutoTaskCSSeasonChange()
	{
	}

	[Token(Token = "0x600922A")]
	[Address(RVA = "0x10EBB68", Offset = "0x10EBB68", VA = "0x10EBB68", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x600922B")]
	[Address(RVA = "0x10EBC38", Offset = "0x10EBC38", VA = "0x10EBC38", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x600922C")]
	[Address(RVA = "0x10EBE5C", Offset = "0x10EBE5C", VA = "0x10EBE5C", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
