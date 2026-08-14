using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001561")]
public class TeamLeaderboardItem
{
	[Token(Token = "0x40092F5")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x40092F6")]
	[FieldOffset(Offset = "0x10")]
	public double score;

	[Token(Token = "0x40092F7")]
	[FieldOffset(Offset = "0x18")]
	public TeamLeaderboardProfile team_profile;

	[Token(Token = "0x40092F8")]
	[FieldOffset(Offset = "0x1C")]
	public int pos;

	[Token(Token = "0x6007BA9")]
	[Address(RVA = "0x33E3438", Offset = "0x33E3438", VA = "0x33E3438")]
	public TeamLeaderboardItem()
	{
	}
}
