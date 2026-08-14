using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014EE")]
public class CreditPunishInfo
{
	[Token(Token = "0x400904A")]
	[FieldOffset(Offset = "0x8")]
	public ECreditScore.CreditCdtType cdt_type;

	[Token(Token = "0x400904B")]
	[FieldOffset(Offset = "0xC")]
	public uint match_mode;

	[Token(Token = "0x400904C")]
	[FieldOffset(Offset = "0x10")]
	public uint game_mode;

	[Token(Token = "0x400904D")]
	[FieldOffset(Offset = "0x14")]
	public uint group_mode;

	[Token(Token = "0x400904E")]
	[FieldOffset(Offset = "0x18")]
	public uint cdt_credit_score;

	[Token(Token = "0x6007B3E")]
	[Address(RVA = "0x309D8F0", Offset = "0x309D8F0", VA = "0x309D8F0")]
	public CreditPunishInfo()
	{
	}
}
