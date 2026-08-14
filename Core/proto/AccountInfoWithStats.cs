using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001369")]
public class AccountInfoWithStats
{
	[Token(Token = "0x4008912")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4008913")]
	[FieldOffset(Offset = "0x10")]
	public uint games_played;

	[Token(Token = "0x4008914")]
	[FieldOffset(Offset = "0x14")]
	public uint wins;

	[Token(Token = "0x4008915")]
	[FieldOffset(Offset = "0x18")]
	public uint kills;

	[Token(Token = "0x4008916")]
	[FieldOffset(Offset = "0x1C")]
	public string detailed_stats;

	[Token(Token = "0x4008917")]
	[FieldOffset(Offset = "0x20")]
	public bool is_cs_ranking;

	[Token(Token = "0x6007A6A")]
	[Address(RVA = "0x31798A4", Offset = "0x31798A4", VA = "0x31798A4")]
	public AccountInfoWithStats()
	{
	}
}
