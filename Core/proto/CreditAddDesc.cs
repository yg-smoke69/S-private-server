using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C08")]
public class CreditAddDesc
{
	[Token(Token = "0x400B056")]
	[FieldOffset(Offset = "0x8")]
	public uint game_mode;

	[Token(Token = "0x400B057")]
	[FieldOffset(Offset = "0xC")]
	public uint match_mode;

	[Token(Token = "0x400B058")]
	[FieldOffset(Offset = "0x10")]
	public uint upper_ranking;

	[Token(Token = "0x400B059")]
	[FieldOffset(Offset = "0x14")]
	public uint lower_ranking;

	[Token(Token = "0x400B05A")]
	[FieldOffset(Offset = "0x18")]
	public uint credit_value;

	[Token(Token = "0x6008263")]
	[Address(RVA = "0x309D854", Offset = "0x309D854", VA = "0x309D854")]
	public CreditAddDesc()
	{
	}
}
