using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E5F")]
public class AutoTaskEPTaskGuild : AutoPopupTask
{
	[Token(Token = "0x400BF4C")]
	[FieldOffset(Offset = "0x8")]
	private UIEPTaskGuideController m_EPTaskGuideUI;

	[Token(Token = "0x60091EB")]
	[Address(RVA = "0x10F3A0C", Offset = "0x10F3A0C", VA = "0x10F3A0C")]
	public AutoTaskEPTaskGuild()
	{
	}

	[Token(Token = "0x60091EC")]
	[Address(RVA = "0x10F3A14", Offset = "0x10F3A14", VA = "0x10F3A14", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x60091ED")]
	[Address(RVA = "0x10F3A6C", Offset = "0x10F3A6C", VA = "0x10F3A6C", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x60091EE")]
	[Address(RVA = "0x10F3BF4", Offset = "0x10F3BF4", VA = "0x10F3BF4", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
