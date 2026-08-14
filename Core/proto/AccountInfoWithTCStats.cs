using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001479")]
public class AccountInfoWithTCStats
{
	[Token(Token = "0x4008E1C")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4008E1D")]
	[FieldOffset(Offset = "0x10")]
	public uint games_played;

	[Token(Token = "0x4008E1E")]
	[FieldOffset(Offset = "0x14")]
	public uint wins;

	[Token(Token = "0x4008E1F")]
	[FieldOffset(Offset = "0x18")]
	public uint kills;

	[Token(Token = "0x4008E20")]
	[FieldOffset(Offset = "0x1C")]
	public DetailedTCStats detailed_stats;

	[Token(Token = "0x6007B06")]
	[Address(RVA = "0x317994C", Offset = "0x317994C", VA = "0x317994C")]
	public AccountInfoWithTCStats()
	{
	}
}
