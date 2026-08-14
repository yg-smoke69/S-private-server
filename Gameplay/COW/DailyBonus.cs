using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20031E8")]
public class DailyBonus
{
	[Token(Token = "0x4013008")]
	[FieldOffset(Offset = "0x8")]
	public bool m_ExpAchieved;

	[Token(Token = "0x4013009")]
	[FieldOffset(Offset = "0xC")]
	public int m_ExpBonus;

	[Token(Token = "0x401300A")]
	[FieldOffset(Offset = "0x10")]
	public bool m_GoldAchieved;

	[Token(Token = "0x401300B")]
	[FieldOffset(Offset = "0x14")]
	public int m_GoldBonus;

	[Token(Token = "0x60150DF")]
	[Address(RVA = "0x1C88DDC", Offset = "0x1C88DDC", VA = "0x1C88DDC")]
	public DailyBonus()
	{
	}
}
