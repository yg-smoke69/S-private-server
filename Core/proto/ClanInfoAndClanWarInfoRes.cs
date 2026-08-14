using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001641")]
public class ClanInfoAndClanWarInfoRes
{
	[Token(Token = "0x40095A9")]
	[FieldOffset(Offset = "0x8")]
	public ClanInfo clan_info;

	[Token(Token = "0x40095AA")]
	[FieldOffset(Offset = "0xC")]
	public AccountClanWarMatchInfo clan_war_match_info;

	[Token(Token = "0x6007C8B")]
	[Address(RVA = "0x309BABC", Offset = "0x309BABC", VA = "0x309BABC")]
	public ClanInfoAndClanWarInfoRes()
	{
	}
}
