using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001784")]
public class TeamInfo
{
	[Token(Token = "0x4009A6A")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x4009A6B")]
	[FieldOffset(Offset = "0x10")]
	public string team_name;

	[Token(Token = "0x4009A6C")]
	[FieldOffset(Offset = "0x18")]
	public ulong create_at;

	[Token(Token = "0x4009A6D")]
	[FieldOffset(Offset = "0x20")]
	public ulong captain_id;

	[Token(Token = "0x4009A6E")]
	[FieldOffset(Offset = "0x28")]
	public uint member_num;

	[Token(Token = "0x4009A6F")]
	[FieldOffset(Offset = "0x2C")]
	public string region;

	[Token(Token = "0x4009A70")]
	[FieldOffset(Offset = "0x30")]
	public uint banner_id;

	[Token(Token = "0x4009A71")]
	[FieldOffset(Offset = "0x34")]
	public string contact_info;

	[Token(Token = "0x4009A72")]
	[FieldOffset(Offset = "0x38")]
	public string country_or_area;

	[Token(Token = "0x4009A73")]
	[FieldOffset(Offset = "0x3C")]
	public uint head_pic;

	[Token(Token = "0x4009A74")]
	[FieldOffset(Offset = "0x40")]
	public ulong[] member_ids;

	[Token(Token = "0x4009A75")]
	[FieldOffset(Offset = "0x44")]
	public uint limited_level;

	[Token(Token = "0x4009A76")]
	[FieldOffset(Offset = "0x48")]
	public uint limited_ranking_point;

	[Token(Token = "0x4009A77")]
	[FieldOffset(Offset = "0x4C")]
	public bool is_qualified;

	[Token(Token = "0x4009A78")]
	[FieldOffset(Offset = "0x50")]
	public uint upper_limited_level;

	[Token(Token = "0x4009A79")]
	[FieldOffset(Offset = "0x54")]
	public uint upper_limited_ranking_point;

	[Token(Token = "0x4009A7A")]
	[FieldOffset(Offset = "0x58")]
	public uint player_num_min;

	[Token(Token = "0x6007DDE")]
	[Address(RVA = "0x33E336C", Offset = "0x33E336C", VA = "0x33E336C")]
	public TeamInfo()
	{
	}
}
