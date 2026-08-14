using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A9E")]
public class ChestTypeDesc
{
	[Token(Token = "0x400A6E4")]
	[FieldOffset(Offset = "0x8")]
	public uint chest_id;

	[Token(Token = "0x400A6E5")]
	[FieldOffset(Offset = "0xC")]
	public uint chest_sub_id;

	[Token(Token = "0x400A6E6")]
	[FieldOffset(Offset = "0x10")]
	public uint chest_type;

	[Token(Token = "0x400A6E7")]
	[FieldOffset(Offset = "0x14")]
	public uint priority;

	[Token(Token = "0x400A6E8")]
	[FieldOffset(Offset = "0x18")]
	public string start_time;

	[Token(Token = "0x400A6E9")]
	[FieldOffset(Offset = "0x1C")]
	public string end_time;

	[Token(Token = "0x400A6EA")]
	[FieldOffset(Offset = "0x20")]
	public string chest_name;

	[Token(Token = "0x400A6EB")]
	[FieldOffset(Offset = "0x24")]
	public uint[] jackpot;

	[Token(Token = "0x400A6EC")]
	[FieldOffset(Offset = "0x28")]
	public bool first_reward_switch;

	[Token(Token = "0x400A6ED")]
	[FieldOffset(Offset = "0x2C")]
	public uint first_reward_min;

	[Token(Token = "0x400A6EE")]
	[FieldOffset(Offset = "0x30")]
	public uint first_reward_max;

	[Token(Token = "0x400A6EF")]
	[FieldOffset(Offset = "0x34")]
	public uint second_level_count;

	[Token(Token = "0x400A6F0")]
	[FieldOffset(Offset = "0x38")]
	public uint third_level_count;

	[Token(Token = "0x400A6F1")]
	[FieldOffset(Offset = "0x3C")]
	public bool extra_reward_switch;

	[Token(Token = "0x400A6F2")]
	[FieldOffset(Offset = "0x40")]
	public uint[] extra_reward_reset_day;

	[Token(Token = "0x400A6F3")]
	[FieldOffset(Offset = "0x44")]
	public uint rare_item_min;

	[Token(Token = "0x400A6F4")]
	[FieldOffset(Offset = "0x48")]
	public uint rare_item_max;

	[Token(Token = "0x400A6F5")]
	[FieldOffset(Offset = "0x4C")]
	public uint chest_activity;

	[Token(Token = "0x400A6F6")]
	[FieldOffset(Offset = "0x50")]
	public long start_time_stamp;

	[Token(Token = "0x400A6F7")]
	[FieldOffset(Offset = "0x58")]
	public long end_time_stamp;

	[Token(Token = "0x400A6F8")]
	[FieldOffset(Offset = "0x60")]
	public bool drop_probability_switch;

	[Token(Token = "0x400A6F9")]
	[FieldOffset(Offset = "0x61")]
	public bool lucky_inherit_switch;

	[Token(Token = "0x400A6FA")]
	[FieldOffset(Offset = "0x64")]
	public uint open_priority_switch;

	[Token(Token = "0x400A6FB")]
	[FieldOffset(Offset = "0x68")]
	public ELottery.Type type;

	[Token(Token = "0x400A6FC")]
	[FieldOffset(Offset = "0x6C")]
	public uint forge_tab_id;

	[Token(Token = "0x400A6FD")]
	[FieldOffset(Offset = "0x70")]
	public uint rare_item2_min;

	[Token(Token = "0x400A6FE")]
	[FieldOffset(Offset = "0x74")]
	public uint rare_item2_max;

	[Token(Token = "0x400A6FF")]
	[FieldOffset(Offset = "0x78")]
	public long drop_up_start_time;

	[Token(Token = "0x400A700")]
	[FieldOffset(Offset = "0x80")]
	public long drop_up_end_time;

	[Token(Token = "0x400A701")]
	[FieldOffset(Offset = "0x88")]
	public uint veteran_buff_num;

	[Token(Token = "0x400A702")]
	[FieldOffset(Offset = "0x8C")]
	public uint veteran_buff_time;

	[Token(Token = "0x400A703")]
	[FieldOffset(Offset = "0x90")]
	public bool melonpi_switch;

	[Token(Token = "0x400A704")]
	[FieldOffset(Offset = "0x98")]
	public long show_time_stamp;

	[Token(Token = "0x400A705")]
	[FieldOffset(Offset = "0xA0")]
	public uint[] buff_up_random;

	[Token(Token = "0x400A706")]
	[FieldOffset(Offset = "0xA4")]
	public uint[] buff_up_probability;

	[Token(Token = "0x400A707")]
	[FieldOffset(Offset = "0xA8")]
	public uint[] buff_up_display;

	[Token(Token = "0x400A708")]
	[FieldOffset(Offset = "0xAC")]
	public uint Luck_point_once;

	[Token(Token = "0x400A709")]
	[FieldOffset(Offset = "0xB0")]
	public uint Luck_point_multi;

	[Token(Token = "0x400A70A")]
	[FieldOffset(Offset = "0xB4")]
	public uint Luck_point_buff;

	[Token(Token = "0x400A70B")]
	[FieldOffset(Offset = "0xB8")]
	public uint Luck_point_reset;

	[Token(Token = "0x400A70C")]
	[FieldOffset(Offset = "0xBC")]
	public uint[] token_max;

	[Token(Token = "0x400A70D")]
	[FieldOffset(Offset = "0xC0")]
	public uint[] token_min;

	[Token(Token = "0x400A70E")]
	[FieldOffset(Offset = "0xC4")]
	public uint legend_cloth_id;

	[Token(Token = "0x400A70F")]
	[FieldOffset(Offset = "0xC8")]
	public bool mab_switch;

	[Token(Token = "0x400A710")]
	[FieldOffset(Offset = "0xCC")]
	public uint independent_entrance_type;

	[Token(Token = "0x60080FB")]
	[Address(RVA = "0x309B6BC", Offset = "0x309B6BC", VA = "0x309B6BC")]
	public ChestTypeDesc()
	{
	}
}
