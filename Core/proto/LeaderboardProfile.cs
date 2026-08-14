using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001562")]
public class LeaderboardProfile
{
	[Token(Token = "0x40092F9")]
	[FieldOffset(Offset = "0x8")]
	public bool has_data;

	[Token(Token = "0x40092FA")]
	[FieldOffset(Offset = "0xC")]
	public AccountLeaderboardProfile account_profile;

	[Token(Token = "0x40092FB")]
	[FieldOffset(Offset = "0x10")]
	public ClanLeaderboardProfile clan_profile;

	[Token(Token = "0x40092FC")]
	[FieldOffset(Offset = "0x14")]
	public TeamLeaderboardProfile team_profile;

	[Token(Token = "0x6007BAA")]
	[Address(RVA = "0x30A445C", Offset = "0x30A445C", VA = "0x30A445C")]
	public LeaderboardProfile()
	{
	}
}
