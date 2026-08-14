using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B3E")]
public class RampageRankDesc
{
	[Token(Token = "0x400AB75")]
	[FieldOffset(Offset = "0x8")]
	public uint rank;

	[Token(Token = "0x400AB76")]
	[FieldOffset(Offset = "0x10")]
	public ulong points;

	[Token(Token = "0x400AB77")]
	[FieldOffset(Offset = "0x18")]
	public string rank_desc;

	[Token(Token = "0x6008199")]
	[Address(RVA = "0x33E0560", Offset = "0x33E0560", VA = "0x33E0560")]
	public RampageRankDesc()
	{
	}
}
