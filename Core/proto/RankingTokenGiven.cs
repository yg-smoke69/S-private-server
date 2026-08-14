using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A4D")]
public class RankingTokenGiven
{
	[Token(Token = "0x400A4CB")]
	[FieldOffset(Offset = "0x8")]
	public uint survival_time_lower;

	[Token(Token = "0x400A4CC")]
	[FieldOffset(Offset = "0xC")]
	public uint survival_time_upper;

	[Token(Token = "0x400A4CD")]
	[FieldOffset(Offset = "0x10")]
	public uint token_given;

	[Token(Token = "0x60080A5")]
	[Address(RVA = "0x33E0EA0", Offset = "0x33E0EA0", VA = "0x33E0EA0")]
	public RankingTokenGiven()
	{
	}
}
