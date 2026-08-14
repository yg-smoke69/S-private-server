using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019CD")]
public class TreasureShootDesc
{
	[Token(Token = "0x400A192")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A193")]
	[FieldOffset(Offset = "0xC")]
	public uint weight;

	[Token(Token = "0x400A194")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> awards;

	[Token(Token = "0x400A195")]
	[FieldOffset(Offset = "0x14")]
	public bool is_preview;

	[Token(Token = "0x400A196")]
	[FieldOffset(Offset = "0x18")]
	public uint preview_avatar;

	[Token(Token = "0x400A197")]
	[FieldOffset(Offset = "0x1C")]
	public bool is_big_reward;

	[Token(Token = "0x400A198")]
	[FieldOffset(Offset = "0x20")]
	public EInventory.AwardType return_type;

	[Token(Token = "0x400A199")]
	[FieldOffset(Offset = "0x24")]
	public uint return_id;

	[Token(Token = "0x400A19A")]
	[FieldOffset(Offset = "0x28")]
	public uint return_num;

	[Token(Token = "0x400A19B")]
	[FieldOffset(Offset = "0x2C")]
	public uint reward_level;

	[Token(Token = "0x400A19C")]
	[FieldOffset(Offset = "0x30")]
	public string icon;

	[Token(Token = "0x400A19D")]
	[FieldOffset(Offset = "0x34")]
	public bool is_auto_open;

	[Token(Token = "0x400A19E")]
	[FieldOffset(Offset = "0x35")]
	public bool compose_icon;

	[Token(Token = "0x400A19F")]
	[FieldOffset(Offset = "0x36")]
	public bool is_preview_probability;

	[Token(Token = "0x6008025")]
	[Address(RVA = "0x33E3C30", Offset = "0x33E3C30", VA = "0x33E3C30")]
	public TreasureShootDesc()
	{
	}
}
