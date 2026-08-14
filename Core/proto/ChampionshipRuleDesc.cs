using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AFA")]
public class ChampionshipRuleDesc
{
	[Token(Token = "0x400A9B3")]
	[FieldOffset(Offset = "0x8")]
	public uint limited_level;

	[Token(Token = "0x400A9B4")]
	[FieldOffset(Offset = "0xC")]
	public uint limited_rank;

	[Token(Token = "0x400A9B5")]
	[FieldOffset(Offset = "0x10")]
	public uint upper_limited_level;

	[Token(Token = "0x400A9B6")]
	[FieldOffset(Offset = "0x14")]
	public uint upper_limited_rank;

	[Token(Token = "0x6008155")]
	[Address(RVA = "0x309AFD4", Offset = "0x309AFD4", VA = "0x309AFD4")]
	public ChampionshipRuleDesc()
	{
	}
}
