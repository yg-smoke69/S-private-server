using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BAA")]
public class CupRuleDesc
{
	[Token(Token = "0x400AE18")]
	[FieldOffset(Offset = "0x8")]
	public uint limited_level;

	[Token(Token = "0x400AE19")]
	[FieldOffset(Offset = "0xC")]
	public uint limited_rank;

	[Token(Token = "0x400AE1A")]
	[FieldOffset(Offset = "0x10")]
	public uint upper_limited_level;

	[Token(Token = "0x400AE1B")]
	[FieldOffset(Offset = "0x14")]
	public uint upper_limited_rank;

	[Token(Token = "0x400AE1C")]
	[FieldOffset(Offset = "0x18")]
	public uint player_count_limit;

	[Token(Token = "0x6008205")]
	[Address(RVA = "0x309DDEC", Offset = "0x309DDEC", VA = "0x309DDEC")]
	public CupRuleDesc()
	{
	}
}
