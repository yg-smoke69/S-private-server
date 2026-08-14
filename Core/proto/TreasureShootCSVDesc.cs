using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019CE")]
public class TreasureShootCSVDesc
{
	[Token(Token = "0x400A1A0")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A1A1")]
	[FieldOffset(Offset = "0xC")]
	public uint weight;

	[Token(Token = "0x400A1A2")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> awards;

	[Token(Token = "0x400A1A3")]
	[FieldOffset(Offset = "0x14")]
	public bool is_preview;

	[Token(Token = "0x400A1A4")]
	[FieldOffset(Offset = "0x18")]
	public uint preview_avatar;

	[Token(Token = "0x400A1A5")]
	[FieldOffset(Offset = "0x1C")]
	public bool is_big_reward;

	[Token(Token = "0x400A1A6")]
	[FieldOffset(Offset = "0x20")]
	public EInventory.AwardType return_type;

	[Token(Token = "0x400A1A7")]
	[FieldOffset(Offset = "0x24")]
	public uint return_id;

	[Token(Token = "0x400A1A8")]
	[FieldOffset(Offset = "0x28")]
	public uint return_num;

	[Token(Token = "0x400A1A9")]
	[FieldOffset(Offset = "0x2C")]
	public uint reward_level;

	[Token(Token = "0x400A1AA")]
	[FieldOffset(Offset = "0x30")]
	public string icon;

	[Token(Token = "0x400A1AB")]
	[FieldOffset(Offset = "0x34")]
	public bool is_auto_open;

	[Token(Token = "0x400A1AC")]
	[FieldOffset(Offset = "0x35")]
	public bool compose_icon;

	[Token(Token = "0x400A1AD")]
	[FieldOffset(Offset = "0x38")]
	public uint base_weight_a;

	[Token(Token = "0x400A1AE")]
	[FieldOffset(Offset = "0x3C")]
	public uint base_weight_b;

	[Token(Token = "0x400A1AF")]
	[FieldOffset(Offset = "0x40")]
	public uint base_weight_c;

	[Token(Token = "0x400A1B0")]
	[FieldOffset(Offset = "0x44")]
	public uint base_weight_d;

	[Token(Token = "0x400A1B1")]
	[FieldOffset(Offset = "0x48")]
	public uint base_weight_e;

	[Token(Token = "0x400A1B2")]
	[FieldOffset(Offset = "0x4C")]
	public uint base_weight_f;

	[Token(Token = "0x400A1B3")]
	[FieldOffset(Offset = "0x50")]
	public uint base_weight_g;

	[Token(Token = "0x400A1B4")]
	[FieldOffset(Offset = "0x54")]
	public uint base_weight_h;

	[Token(Token = "0x400A1B5")]
	[FieldOffset(Offset = "0x58")]
	public bool is_preview_probability;

	[Token(Token = "0x6008026")]
	[Address(RVA = "0x33E3B5C", Offset = "0x33E3B5C", VA = "0x33E3B5C")]
	public TreasureShootCSVDesc()
	{
	}
}
