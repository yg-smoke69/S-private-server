using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B12")]
public class WorldChannelCtrlDesc
{
	[Token(Token = "0x400AA26")]
	[FieldOffset(Offset = "0x8")]
	public bool enable;

	[Token(Token = "0x400AA27")]
	[FieldOffset(Offset = "0xC")]
	public uint channel_capacity;

	[Token(Token = "0x400AA28")]
	[FieldOffset(Offset = "0x10")]
	public uint clear_channel_cdt_size;

	[Token(Token = "0x400AA29")]
	[FieldOffset(Offset = "0x14")]
	public uint clear_channel_cdt_time;

	[Token(Token = "0x400AA2A")]
	[FieldOffset(Offset = "0x18")]
	public uint merge_scan_interval;

	[Token(Token = "0x400AA2B")]
	[FieldOffset(Offset = "0x1C")]
	public uint daily_msg_limit_default;

	[Token(Token = "0x400AA2C")]
	[FieldOffset(Offset = "0x20")]
	public uint daily_msg_limit_fast;

	[Token(Token = "0x400AA2D")]
	[FieldOffset(Offset = "0x24")]
	public uint sticky_speaker_item_id;

	[Token(Token = "0x400AA2E")]
	[FieldOffset(Offset = "0x28")]
	public bool enable_custom_msg;

	[Token(Token = "0x400AA2F")]
	[FieldOffset(Offset = "0x2C")]
	public List<string> main_lang_array;

	[Token(Token = "0x400AA30")]
	[FieldOffset(Offset = "0x30")]
	public bool enable_hacker_pool_chat;

	[Token(Token = "0x600816D")]
	[Address(RVA = "0x33E6C34", Offset = "0x33E6C34", VA = "0x33E6C34")]
	public WorldChannelCtrlDesc()
	{
	}
}
