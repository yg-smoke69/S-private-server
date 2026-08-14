using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001642")]
public class ClanMemberWithAccountInfo
{
	[Token(Token = "0x40095AB")]
	[FieldOffset(Offset = "0x8")]
	public AccountInfoBasic basic_info;

	[Token(Token = "0x40095AC")]
	[FieldOffset(Offset = "0x10")]
	public ulong clan_id;

	[Token(Token = "0x40095AD")]
	[FieldOffset(Offset = "0x18")]
	public uint member_type;

	[Token(Token = "0x40095AE")]
	[FieldOffset(Offset = "0x20")]
	public ulong join_at;

	[Token(Token = "0x40095AF")]
	[FieldOffset(Offset = "0x28")]
	public string region;

	[Token(Token = "0x40095B0")]
	[FieldOffset(Offset = "0x2C")]
	public uint honor_point;

	[Token(Token = "0x40095B1")]
	[FieldOffset(Offset = "0x30")]
	public uint race_point;

	[Token(Token = "0x40095B2")]
	[FieldOffset(Offset = "0x38")]
	public ulong last_gain_rp_at;

	[Token(Token = "0x6007C8C")]
	[Address(RVA = "0x309BDCC", Offset = "0x309BDCC", VA = "0x309BDCC")]
	public ClanMemberWithAccountInfo()
	{
	}
}
