using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001477")]
public class AccountInfoWithStatsToClient
{
	[Token(Token = "0x4008E0D")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4008E0E")]
	[FieldOffset(Offset = "0x10")]
	public uint games_played;

	[Token(Token = "0x4008E0F")]
	[FieldOffset(Offset = "0x14")]
	public uint wins;

	[Token(Token = "0x4008E10")]
	[FieldOffset(Offset = "0x18")]
	public uint kills;

	[Token(Token = "0x4008E11")]
	[FieldOffset(Offset = "0x1C")]
	public PlayerDetailedStats detailed_stats;

	[Token(Token = "0x6007B04")]
	[Address(RVA = "0x3179944", Offset = "0x3179944", VA = "0x3179944")]
	public AccountInfoWithStatsToClient()
	{
	}
}
