using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AA3")]
public class ChestSpecialExchangeDesc
{
	[Token(Token = "0x400A749")]
	[FieldOffset(Offset = "0x8")]
	public uint forge_tab_id;

	[Token(Token = "0x400A74A")]
	[FieldOffset(Offset = "0xC")]
	public string tab_name;

	[Token(Token = "0x400A74B")]
	[FieldOffset(Offset = "0x10")]
	public uint item_id;

	[Token(Token = "0x400A74C")]
	[FieldOffset(Offset = "0x14")]
	public uint item_num;

	[Token(Token = "0x400A74D")]
	[FieldOffset(Offset = "0x18")]
	public uint sort_id;

	[Token(Token = "0x400A74E")]
	[FieldOffset(Offset = "0x1C")]
	public string added_time;

	[Token(Token = "0x400A74F")]
	[FieldOffset(Offset = "0x20")]
	public string expire_time;

	[Token(Token = "0x400A750")]
	[FieldOffset(Offset = "0x24")]
	public uint limited_purchase_times;

	[Token(Token = "0x400A751")]
	[FieldOffset(Offset = "0x28")]
	public string language;

	[Token(Token = "0x400A752")]
	[FieldOffset(Offset = "0x2C")]
	public string image_url;

	[Token(Token = "0x400A753")]
	[FieldOffset(Offset = "0x30")]
	public bool is_show;

	[Token(Token = "0x400A754")]
	[FieldOffset(Offset = "0x34")]
	public List<AwardDesc> exchange_items;

	[Token(Token = "0x400A755")]
	[FieldOffset(Offset = "0x38")]
	public uint reward_level;

	[Token(Token = "0x400A756")]
	[FieldOffset(Offset = "0x3C")]
	public string real_image_url;

	[Token(Token = "0x400A757")]
	[FieldOffset(Offset = "0x40")]
	public uint purchase_times;

	[Token(Token = "0x400A758")]
	[FieldOffset(Offset = "0x44")]
	public uint item_duration;

	[Token(Token = "0x400A759")]
	[FieldOffset(Offset = "0x48")]
	public string effect_icon;

	[Token(Token = "0x400A75A")]
	[FieldOffset(Offset = "0x4C")]
	public uint id;

	[Token(Token = "0x6008100")]
	[Address(RVA = "0x309B590", Offset = "0x309B590", VA = "0x309B590")]
	public ChestSpecialExchangeDesc()
	{
	}
}
