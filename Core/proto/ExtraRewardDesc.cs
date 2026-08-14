using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AA2")]
public class ExtraRewardDesc
{
	[Token(Token = "0x400A73D")]
	[FieldOffset(Offset = "0x8")]
	public uint chest_id;

	[Token(Token = "0x400A73E")]
	[FieldOffset(Offset = "0xC")]
	public string icon;

	[Token(Token = "0x400A73F")]
	[FieldOffset(Offset = "0x10")]
	public uint cdt_type;

	[Token(Token = "0x400A740")]
	[FieldOffset(Offset = "0x14")]
	public uint cdt_value;

	[Token(Token = "0x400A741")]
	[FieldOffset(Offset = "0x18")]
	public List<ExchangedAward> reward_list;

	[Token(Token = "0x400A742")]
	[FieldOffset(Offset = "0x1C")]
	public uint chest_sub_id;

	[Token(Token = "0x400A743")]
	[FieldOffset(Offset = "0x20")]
	public string special_reward;

	[Token(Token = "0x400A744")]
	[FieldOffset(Offset = "0x24")]
	public uint token_id;

	[Token(Token = "0x400A745")]
	[FieldOffset(Offset = "0x28")]
	public uint token_num;

	[Token(Token = "0x400A746")]
	[FieldOffset(Offset = "0x2C")]
	public string reward_icon;

	[Token(Token = "0x400A747")]
	[FieldOffset(Offset = "0x30")]
	public uint rare_reward;

	[Token(Token = "0x400A748")]
	[FieldOffset(Offset = "0x34")]
	public bool is_show_box;

	[Token(Token = "0x60080FF")]
	[Address(RVA = "0x30A016C", Offset = "0x30A016C", VA = "0x30A016C")]
	public ExtraRewardDesc()
	{
	}
}
