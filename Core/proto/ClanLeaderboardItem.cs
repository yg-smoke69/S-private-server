using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001560")]
public class ClanLeaderboardItem
{
	[Token(Token = "0x40092F1")]
	[FieldOffset(Offset = "0x8")]
	public ulong clan_id;

	[Token(Token = "0x40092F2")]
	[FieldOffset(Offset = "0x10")]
	public double score;

	[Token(Token = "0x40092F3")]
	[FieldOffset(Offset = "0x18")]
	public ClanLeaderboardProfile clan_profile;

	[Token(Token = "0x40092F4")]
	[FieldOffset(Offset = "0x1C")]
	public int pos;

	[Token(Token = "0x6007BA8")]
	[Address(RVA = "0x309BB64", Offset = "0x309BB64", VA = "0x309BB64")]
	public ClanLeaderboardItem()
	{
	}
}
