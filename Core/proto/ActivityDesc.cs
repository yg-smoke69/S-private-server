using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019D1")]
public class ActivityDesc
{
	[Token(Token = "0x400A1BC")]
	[FieldOffset(Offset = "0x8")]
	public uint group_id;

	[Token(Token = "0x400A1BD")]
	[FieldOffset(Offset = "0xC")]
	public uint activity_id;

	[Token(Token = "0x400A1BE")]
	[FieldOffset(Offset = "0x10")]
	public uint activity_type;

	[Token(Token = "0x400A1BF")]
	[FieldOffset(Offset = "0x14")]
	public uint sort_id;

	[Token(Token = "0x400A1C0")]
	[FieldOffset(Offset = "0x18")]
	public uint is_process_show;

	[Token(Token = "0x400A1C1")]
	[FieldOffset(Offset = "0x1C")]
	public uint act_tag;

	[Token(Token = "0x400A1C2")]
	[FieldOffset(Offset = "0x20")]
	public uint gos_pos;

	[Token(Token = "0x400A1C3")]
	[FieldOffset(Offset = "0x24")]
	public string start_time;

	[Token(Token = "0x400A1C4")]
	[FieldOffset(Offset = "0x28")]
	public string end_time;

	[Token(Token = "0x400A1C5")]
	[FieldOffset(Offset = "0x2C")]
	public EActivity.CircleType circle_type;

	[Token(Token = "0x400A1C6")]
	[FieldOffset(Offset = "0x30")]
	public EActivity.PreConditionType pre_cdt_type1;

	[Token(Token = "0x400A1C7")]
	[FieldOffset(Offset = "0x34")]
	public uint pre_cdt_value1;

	[Token(Token = "0x400A1C8")]
	[FieldOffset(Offset = "0x38")]
	public EActivity.PreConditionType pre_cdt_type2;

	[Token(Token = "0x400A1C9")]
	[FieldOffset(Offset = "0x3C")]
	public uint pre_cdt_value2;

	[Token(Token = "0x400A1CA")]
	[FieldOffset(Offset = "0x40")]
	public EActivity.PreConditionType pre_cdt_type3;

	[Token(Token = "0x400A1CB")]
	[FieldOffset(Offset = "0x44")]
	public uint pre_cdt_value3;

	[Token(Token = "0x400A1CC")]
	[FieldOffset(Offset = "0x48")]
	public EActivity.ConditionType cdt_type;

	[Token(Token = "0x400A1CD")]
	[FieldOffset(Offset = "0x4C")]
	public uint cdt_value;

	[Token(Token = "0x400A1CE")]
	[FieldOffset(Offset = "0x50")]
	public List<AwardDesc> awards;

	[Token(Token = "0x400A1CF")]
	[FieldOffset(Offset = "0x54")]
	public List<Item> exchange_items;

	[Token(Token = "0x400A1D0")]
	[FieldOffset(Offset = "0x58")]
	public EActivity.PreConditionType pre_cdt_type4;

	[Token(Token = "0x400A1D1")]
	[FieldOffset(Offset = "0x5C")]
	public uint pre_cdt_value4;

	[Token(Token = "0x400A1D2")]
	[FieldOffset(Offset = "0x60")]
	public EActivity.PreConditionType pre_cdt_type5;

	[Token(Token = "0x400A1D3")]
	[FieldOffset(Offset = "0x64")]
	public uint pre_cdt_value5;

	[Token(Token = "0x400A1D4")]
	[FieldOffset(Offset = "0x68")]
	public string show_time;

	[Token(Token = "0x400A1D5")]
	[FieldOffset(Offset = "0x6C")]
	public uint table_type;

	[Token(Token = "0x400A1D6")]
	[FieldOffset(Offset = "0x70")]
	public uint pre_activity_id;

	[Token(Token = "0x400A1D7")]
	[FieldOffset(Offset = "0x74")]
	public uint settle_limit;

	[Token(Token = "0x400A1D8")]
	[FieldOffset(Offset = "0x78")]
	public uint affiliate_table;

	[Token(Token = "0x400A1D9")]
	[FieldOffset(Offset = "0x7C")]
	public uint activity_class;

	[Token(Token = "0x400A1DA")]
	[FieldOffset(Offset = "0x80")]
	public long[] hint_reset_time;

	[Token(Token = "0x400A1DB")]
	[FieldOffset(Offset = "0x84")]
	public uint pre_cdt_gos_pos;

	[Token(Token = "0x400A1DC")]
	[FieldOffset(Offset = "0x88")]
	public uint[] pre_cdt_item_ids;

	[Token(Token = "0x400A1DD")]
	[FieldOffset(Offset = "0x8C")]
	public uint min_level;

	[Token(Token = "0x400A1DE")]
	[FieldOffset(Offset = "0x90")]
	public uint max_level;

	[Token(Token = "0x400A1DF")]
	[FieldOffset(Offset = "0x94")]
	public EActivity.Platform platform;

	[Token(Token = "0x400A1E0")]
	[FieldOffset(Offset = "0x98")]
	public uint pre_cdt_switch;

	[Token(Token = "0x400A1E1")]
	[FieldOffset(Offset = "0x9C")]
	public bool big_prize;

	[Token(Token = "0x400A1E2")]
	[FieldOffset(Offset = "0xA0")]
	public EActivity.SubType sub_type;

	[Token(Token = "0x400A1E3")]
	[FieldOffset(Offset = "0xA4")]
	public string stop_show_time;

	[Token(Token = "0x400A1E4")]
	[FieldOffset(Offset = "0xA8")]
	public uint award_expression;

	[Token(Token = "0x400A1E5")]
	[FieldOffset(Offset = "0xAC")]
	public uint client_type;

	[Token(Token = "0x6008029")]
	[Address(RVA = "0x317A194", Offset = "0x317A194", VA = "0x317A194")]
	public ActivityDesc()
	{
	}
}
