using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C04")]
public class CreditPunishDesc
{
	[Token(Token = "0x400B046")]
	[FieldOffset(Offset = "0x8")]
	public uint credit_score;

	[Token(Token = "0x400B047")]
	[FieldOffset(Offset = "0xC")]
	public ECreditScore.CreditCdtType credit_cdt_type;

	[Token(Token = "0x400B048")]
	[FieldOffset(Offset = "0x10")]
	public uint credit_cdt_value1;

	[Token(Token = "0x400B049")]
	[FieldOffset(Offset = "0x14")]
	public uint credit_cdt_value2;

	[Token(Token = "0x400B04A")]
	[FieldOffset(Offset = "0x18")]
	public uint credit_cdt_value3;

	[Token(Token = "0x600825F")]
	[Address(RVA = "0x309D8E8", Offset = "0x309D8E8", VA = "0x309D8E8")]
	public CreditPunishDesc()
	{
	}
}
