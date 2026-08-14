using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018A5")]
public class PoolLeaderboardPlayerInfo
{
	[Token(Token = "0x4009D75")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009D76")]
	[FieldOffset(Offset = "0x10")]
	public double score;

	[Token(Token = "0x4009D77")]
	[FieldOffset(Offset = "0x18")]
	public AccountInfoBasic account_info;

	[Token(Token = "0x6007EFE")]
	[Address(RVA = "0x33E0000", Offset = "0x33E0000", VA = "0x33E0000")]
	public PoolLeaderboardPlayerInfo()
	{
	}
}
