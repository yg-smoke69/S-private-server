using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001566")]
public class AccountLeaderboardItem
{
	[Token(Token = "0x4009306")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009307")]
	[FieldOffset(Offset = "0x10")]
	public double score;

	[Token(Token = "0x4009308")]
	[FieldOffset(Offset = "0x18")]
	public AccountLeaderboardProfile account_profile;

	[Token(Token = "0x4009309")]
	[FieldOffset(Offset = "0x1C")]
	public int pos;

	[Token(Token = "0x6007BAE")]
	[Address(RVA = "0x3179954", Offset = "0x3179954", VA = "0x3179954")]
	public AccountLeaderboardItem()
	{
	}
}
