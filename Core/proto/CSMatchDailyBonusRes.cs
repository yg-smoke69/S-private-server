using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200151B")]
public class CSMatchDailyBonusRes
{
	[Token(Token = "0x40090B9")]
	[FieldOffset(Offset = "0x8")]
	public bool has_exp_achieved;

	[Token(Token = "0x40090BA")]
	[FieldOffset(Offset = "0xC")]
	public uint exp_bonus;

	[Token(Token = "0x40090BB")]
	[FieldOffset(Offset = "0x10")]
	public bool has_gold_achieved;

	[Token(Token = "0x40090BC")]
	[FieldOffset(Offset = "0x14")]
	public uint gold_bonus;

	[Token(Token = "0x6007B64")]
	[Address(RVA = "0x3097A60", Offset = "0x3097A60", VA = "0x3097A60")]
	public CSMatchDailyBonusRes()
	{
	}
}
