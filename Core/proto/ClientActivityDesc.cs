using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001616")]
public class ClientActivityDesc
{
	[Token(Token = "0x4009506")]
	[FieldOffset(Offset = "0x8")]
	public uint group_id;

	[Token(Token = "0x4009507")]
	[FieldOffset(Offset = "0xC")]
	public uint activity_id;

	[Token(Token = "0x4009508")]
	[FieldOffset(Offset = "0x10")]
	public string act_title;

	[Token(Token = "0x4009509")]
	[FieldOffset(Offset = "0x14")]
	public string act_text;

	[Token(Token = "0x400950A")]
	[FieldOffset(Offset = "0x18")]
	public string award_context;

	[Token(Token = "0x400950B")]
	[FieldOffset(Offset = "0x1C")]
	public string image_url;

	[Token(Token = "0x400950C")]
	[FieldOffset(Offset = "0x20")]
	public string image_url_for_lobby;

	[Token(Token = "0x400950D")]
	[FieldOffset(Offset = "0x24")]
	public uint activity_type;

	[Token(Token = "0x400950E")]
	[FieldOffset(Offset = "0x28")]
	public uint sort_id;

	[Token(Token = "0x400950F")]
	[FieldOffset(Offset = "0x2C")]
	public uint is_process_show;

	[Token(Token = "0x4009510")]
	[FieldOffset(Offset = "0x30")]
	public uint act_tag;

	[Token(Token = "0x4009511")]
	[FieldOffset(Offset = "0x34")]
	public uint gos_pos;

	[Token(Token = "0x4009512")]
	[FieldOffset(Offset = "0x38")]
	public long start_time;

	[Token(Token = "0x4009513")]
	[FieldOffset(Offset = "0x40")]
	public long end_time;

	[Token(Token = "0x4009514")]
	[FieldOffset(Offset = "0x48")]
	public uint cdt_value;

	[Token(Token = "0x4009515")]
	[FieldOffset(Offset = "0x4C")]
	public List<AwardDesc> awards;

	[Token(Token = "0x4009516")]
	[FieldOffset(Offset = "0x50")]
	public List<Item> exchange_items;

	[Token(Token = "0x4009517")]
	[FieldOffset(Offset = "0x58")]
	public long show_time;

	[Token(Token = "0x4009518")]
	[FieldOffset(Offset = "0x60")]
	public uint table_type;

	[Token(Token = "0x4009519")]
	[FieldOffset(Offset = "0x64")]
	public string original_start_time;

	[Token(Token = "0x400951A")]
	[FieldOffset(Offset = "0x68")]
	public string original_end_time;

	[Token(Token = "0x400951B")]
	[FieldOffset(Offset = "0x6C")]
	public string image_url_for_top_up;

	[Token(Token = "0x400951C")]
	[FieldOffset(Offset = "0x70")]
	public uint affiliate_table;

	[Token(Token = "0x400951D")]
	[FieldOffset(Offset = "0x74")]
	public uint activity_class;

	[Token(Token = "0x400951E")]
	[FieldOffset(Offset = "0x78")]
	public long[] hint_reset_time;

	[Token(Token = "0x400951F")]
	[FieldOffset(Offset = "0x7C")]
	public uint pre_cdt_gos_pos;

	[Token(Token = "0x4009520")]
	[FieldOffset(Offset = "0x80")]
	public uint[] pre_cdt_item_ids;

	[Token(Token = "0x4009521")]
	[FieldOffset(Offset = "0x84")]
	public uint min_level;

	[Token(Token = "0x4009522")]
	[FieldOffset(Offset = "0x88")]
	public uint max_level;

	[Token(Token = "0x4009523")]
	[FieldOffset(Offset = "0x8C")]
	public bool big_prize;

	[Token(Token = "0x4009524")]
	[FieldOffset(Offset = "0x90")]
	public EActivity.SubType sub_type;

	[Token(Token = "0x4009525")]
	[FieldOffset(Offset = "0x98")]
	public long stop_show_time;

	[Token(Token = "0x4009526")]
	[FieldOffset(Offset = "0xA0")]
	public EActivity.CircleType circle_type;

	[Token(Token = "0x4009527")]
	[FieldOffset(Offset = "0xA4")]
	public uint award_expression;

	[Token(Token = "0x4009528")]
	[FieldOffset(Offset = "0xA8")]
	public EActivity.ConditionType cdt;

	[Token(Token = "0x4009529")]
	[FieldOffset(Offset = "0xAC")]
	public EActivity.PreConditionType pre_cdt1;

	[Token(Token = "0x400952A")]
	[FieldOffset(Offset = "0xB0")]
	public uint pre_cdv1;

	[Token(Token = "0x6007C60")]
	[Address(RVA = "0x309C474", Offset = "0x309C474", VA = "0x309C474")]
	public ClientActivityDesc()
	{
	}
}
