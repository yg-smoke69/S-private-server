using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E6B")]
internal class AutoTaskSeasonChange : AutoPopupTask
{
	[Token(Token = "0x400BF69")]
	[FieldOffset(Offset = "0x8")]
	private UILadderMatchSeasonChangeController m_SeasonChangeCtrl;

	[Token(Token = "0x6009225")]
	[Address(RVA = "0x10F950C", Offset = "0x10F950C", VA = "0x10F950C")]
	public AutoTaskSeasonChange()
	{
	}

	[Token(Token = "0x6009226")]
	[Address(RVA = "0x10F9514", Offset = "0x10F9514", VA = "0x10F9514", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x6009227")]
	[Address(RVA = "0x10F95E4", Offset = "0x10F95E4", VA = "0x10F95E4", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x6009228")]
	[Address(RVA = "0x10F980C", Offset = "0x10F980C", VA = "0x10F980C", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
