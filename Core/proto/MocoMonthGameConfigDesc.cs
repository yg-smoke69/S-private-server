using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BC6")]
public class MocoMonthGameConfigDesc
{
	[Token(Token = "0x400AEC9")]
	[FieldOffset(Offset = "0x8")]
	public uint tickets_token_num;

	[Token(Token = "0x400AECA")]
	[FieldOffset(Offset = "0xC")]
	public float conversionFactor;

	[Token(Token = "0x400AECB")]
	[FieldOffset(Offset = "0x10")]
	public uint remaining_time_score;

	[Token(Token = "0x400AECC")]
	[FieldOffset(Offset = "0x14")]
	public uint skip_score;

	[Token(Token = "0x400AECD")]
	[FieldOffset(Offset = "0x18")]
	public uint protection_score;

	[Token(Token = "0x6008221")]
	[Address(RVA = "0x30A8AD8", Offset = "0x30A8AD8", VA = "0x30A8AD8")]
	public MocoMonthGameConfigDesc()
	{
	}
}
