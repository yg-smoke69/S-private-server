using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019E2")]
public class GameOpeningInfoDesc
{
	[Token(Token = "0x400A292")]
	[FieldOffset(Offset = "0x8")]
	public uint map_id;

	[Token(Token = "0x400A293")]
	[FieldOffset(Offset = "0xC")]
	public string name;

	[Token(Token = "0x400A294")]
	[FieldOffset(Offset = "0x10")]
	public string start_time;

	[Token(Token = "0x400A295")]
	[FieldOffset(Offset = "0x14")]
	public string end_time;

	[Token(Token = "0x400A296")]
	[FieldOffset(Offset = "0x18")]
	public string tips;

	[Token(Token = "0x400A297")]
	[FieldOffset(Offset = "0x1C")]
	public uint game_mode;

	[Token(Token = "0x400A298")]
	[FieldOffset(Offset = "0x20")]
	public uint match_mode;

	[Token(Token = "0x400A299")]
	[FieldOffset(Offset = "0x24")]
	public bool is_new;

	[Token(Token = "0x400A29A")]
	[FieldOffset(Offset = "0x28")]
	public string config_start_time;

	[Token(Token = "0x400A29B")]
	[FieldOffset(Offset = "0x2C")]
	public string config_end_time;

	[Token(Token = "0x400A29C")]
	[FieldOffset(Offset = "0x30")]
	public string player_count_limit;

	[Token(Token = "0x400A29D")]
	[FieldOffset(Offset = "0x34")]
	public uint level_visual_style;

	[Token(Token = "0x400A29E")]
	[FieldOffset(Offset = "0x38")]
	public string difficulty;

	[Token(Token = "0x400A29F")]
	[FieldOffset(Offset = "0x3C")]
	public string weekday;

	[Token(Token = "0x400A2A0")]
	[FieldOffset(Offset = "0x40")]
	public uint sort_id;

	[Token(Token = "0x400A2A1")]
	[FieldOffset(Offset = "0x44")]
	public string visual_map;

	[Token(Token = "0x400A2A2")]
	[FieldOffset(Offset = "0x48")]
	public uint tag;

	[Token(Token = "0x400A2A3")]
	[FieldOffset(Offset = "0x4C")]
	public string version;

	[Token(Token = "0x400A2A4")]
	[FieldOffset(Offset = "0x50")]
	public bool is_random;

	[Token(Token = "0x400A2A5")]
	[FieldOffset(Offset = "0x54")]
	public string match_mode_image;

	[Token(Token = "0x400A2A6")]
	[FieldOffset(Offset = "0x58")]
	public bool is_force_random;

	[Token(Token = "0x400A2A7")]
	[FieldOffset(Offset = "0x5C")]
	public string tips_parameter;

	[Token(Token = "0x400A2A8")]
	[FieldOffset(Offset = "0x60")]
	public bool is_live_open;

	[Token(Token = "0x400A2A9")]
	[FieldOffset(Offset = "0x64")]
	public uint live_effects_id;

	[Token(Token = "0x400A2AA")]
	[FieldOffset(Offset = "0x68")]
	public bool max_only;

	[Token(Token = "0x600803A")]
	[Address(RVA = "0x30A1ACC", Offset = "0x30A1ACC", VA = "0x30A1ACC")]
	public GameOpeningInfoDesc()
	{
	}
}
