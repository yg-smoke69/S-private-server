using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E56")]
public class AutoTaskCupMatchChampion : AutoPopupTask
{
	[Token(Token = "0x400BF3C")]
	[FieldOffset(Offset = "0x8")]
	private UICupMatchChampionController m_Ctrl;

	[Token(Token = "0x400BF3D")]
	[FieldOffset(Offset = "0xC")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x60091C7")]
	[Address(RVA = "0x10F0D20", Offset = "0x10F0D20", VA = "0x10F0D20")]
	public AutoTaskCupMatchChampion()
	{
	}

	[Token(Token = "0x60091C8")]
	[Address(RVA = "0x10F0D28", Offset = "0x10F0D28", VA = "0x10F0D28", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x60091C9")]
	[Address(RVA = "0x10F0E10", Offset = "0x10F0E10", VA = "0x10F0E10", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x60091CA")]
	[Address(RVA = "0x10F1070", Offset = "0x10F1070", VA = "0x10F1070", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
