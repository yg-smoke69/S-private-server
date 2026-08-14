using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AB1")]
public class IAPPoolDesc
{
	[Token(Token = "0x400A7DB")]
	[FieldOffset(Offset = "0x8")]
	public uint bundle_pool_id;

	[Token(Token = "0x400A7DC")]
	[FieldOffset(Offset = "0xC")]
	public string start_time;

	[Token(Token = "0x400A7DD")]
	[FieldOffset(Offset = "0x10")]
	public string end_time;

	[Token(Token = "0x400A7DE")]
	[FieldOffset(Offset = "0x14")]
	public uint exist_time;

	[Token(Token = "0x400A7DF")]
	[FieldOffset(Offset = "0x18")]
	public uint cd_time;

	[Token(Token = "0x400A7E0")]
	[FieldOffset(Offset = "0x1C")]
	public uint match_mode;

	[Token(Token = "0x400A7E1")]
	[FieldOffset(Offset = "0x20")]
	public uint game_mode;

	[Token(Token = "0x400A7E2")]
	[FieldOffset(Offset = "0x24")]
	public uint map_id;

	[Token(Token = "0x400A7E3")]
	[FieldOffset(Offset = "0x28")]
	public string group_mode;

	[Token(Token = "0x400A7E4")]
	[FieldOffset(Offset = "0x2C")]
	public uint rank;

	[Token(Token = "0x400A7E5")]
	[FieldOffset(Offset = "0x30")]
	public uint match_time;

	[Token(Token = "0x400A7E6")]
	[FieldOffset(Offset = "0x34")]
	public float drop_rate;

	[Token(Token = "0x400A7E7")]
	[FieldOffset(Offset = "0x38")]
	public uint is_ios_review;

	[Token(Token = "0x400A7E8")]
	[FieldOffset(Offset = "0x3C")]
	public uint min_player_level;

	[Token(Token = "0x400A7E9")]
	[FieldOffset(Offset = "0x40")]
	public uint max_player_level;

	[Token(Token = "0x400A7EA")]
	[FieldOffset(Offset = "0x44")]
	public uint min_ranking_level;

	[Token(Token = "0x400A7EB")]
	[FieldOffset(Offset = "0x48")]
	public string is_ep_unlock;

	[Token(Token = "0x400A7EC")]
	[FieldOffset(Offset = "0x4C")]
	public uint[] paid_levels;

	[Token(Token = "0x400A7ED")]
	[FieldOffset(Offset = "0x50")]
	public uint veteran_class;

	[Token(Token = "0x400A7EE")]
	[FieldOffset(Offset = "0x54")]
	public List<string> melon_pi_api_classes;

	[Token(Token = "0x400A7EF")]
	[FieldOffset(Offset = "0x58")]
	public EStore.IapSpecialDropType special_type;

	[Token(Token = "0x400A7F0")]
	[FieldOffset(Offset = "0x5C")]
	public uint special_type_num;

	[Token(Token = "0x400A7F1")]
	[FieldOffset(Offset = "0x60")]
	public EStore.IapDropSituation drop_situation;

	[Token(Token = "0x400A7F2")]
	[FieldOffset(Offset = "0x64")]
	public uint drop_situation_desc;

	[Token(Token = "0x400A7F3")]
	[FieldOffset(Offset = "0x68")]
	public List<string> choco_api;

	[Token(Token = "0x600810E")]
	[Address(RVA = "0x30A394C", Offset = "0x30A394C", VA = "0x30A394C")]
	public IAPPoolDesc()
	{
	}
}
