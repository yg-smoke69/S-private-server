using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E59")]
public class AutoTaskCupMatchFaction : AutoPopupTask
{
	[Token(Token = "0x400BF44")]
	[FieldOffset(Offset = "0x8")]
	private UICupMatchFactionController m_Ctrl;

	[Token(Token = "0x400BF45")]
	[FieldOffset(Offset = "0xC")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x60091D3")]
	[Address(RVA = "0x10F2048", Offset = "0x10F2048", VA = "0x10F2048")]
	public AutoTaskCupMatchFaction()
	{
	}

	[Token(Token = "0x60091D4")]
	[Address(RVA = "0x10F2050", Offset = "0x10F2050", VA = "0x10F2050", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x60091D5")]
	[Address(RVA = "0x10F2138", Offset = "0x10F2138", VA = "0x10F2138", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x60091D6")]
	[Address(RVA = "0x10F2338", Offset = "0x10F2338", VA = "0x10F2338", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
