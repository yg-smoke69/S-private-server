using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A34")]
public class ClanWarInfoDesc
{
	[Token(Token = "0x400A40A")]
	[FieldOffset(Offset = "0x8")]
	public uint season_id;

	[Token(Token = "0x400A40B")]
	[FieldOffset(Offset = "0xC")]
	public bool is_open;

	[Token(Token = "0x400A40C")]
	[FieldOffset(Offset = "0x10")]
	public long start_time;

	[Token(Token = "0x400A40D")]
	[FieldOffset(Offset = "0x18")]
	public long end_time;

	[Token(Token = "0x400A40E")]
	[FieldOffset(Offset = "0x20")]
	public uint available_map;

	[Token(Token = "0x400A40F")]
	[FieldOffset(Offset = "0x24")]
	public uint max_player;

	[Token(Token = "0x400A410")]
	[FieldOffset(Offset = "0x28")]
	public uint min_player;

	[Token(Token = "0x400A411")]
	[FieldOffset(Offset = "0x2C")]
	public uint limited_level;

	[Token(Token = "0x400A412")]
	[FieldOffset(Offset = "0x30")]
	public string cdn_url1;

	[Token(Token = "0x400A413")]
	[FieldOffset(Offset = "0x34")]
	public string cdn_url2;

	[Token(Token = "0x400A414")]
	[FieldOffset(Offset = "0x38")]
	public string cdn_url3;

	[Token(Token = "0x400A415")]
	[FieldOffset(Offset = "0x3C")]
	public string web_link;

	[Token(Token = "0x400A416")]
	[FieldOffset(Offset = "0x40")]
	public string rules_desc1;

	[Token(Token = "0x400A417")]
	[FieldOffset(Offset = "0x44")]
	public string rules_desc2;

	[Token(Token = "0x400A418")]
	[FieldOffset(Offset = "0x48")]
	public string map_name;

	[Token(Token = "0x400A419")]
	[FieldOffset(Offset = "0x4C")]
	public uint clan_war_cache_timeout;

	[Token(Token = "0x400A41A")]
	[FieldOffset(Offset = "0x50")]
	public string noti_push_time;

	[Token(Token = "0x400A41B")]
	[FieldOffset(Offset = "0x54")]
	public string noti_push_title;

	[Token(Token = "0x400A41C")]
	[FieldOffset(Offset = "0x58")]
	public string noti_push_content;

	[Token(Token = "0x600808C")]
	[Address(RVA = "0x309C1EC", Offset = "0x309C1EC", VA = "0x309C1EC")]
	public ClanWarInfoDesc()
	{
	}
}
