using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BB5")]
public class FourSymbolsSettingDesc
{
	[Token(Token = "0x400AE53")]
	[FieldOffset(Offset = "0x8")]
	public bool assemble_switch;

	[Token(Token = "0x400AE54")]
	[FieldOffset(Offset = "0x9")]
	public bool store_switch;

	[Token(Token = "0x400AE55")]
	[FieldOffset(Offset = "0xA")]
	public bool sign_in_switch;

	[Token(Token = "0x400AE56")]
	[FieldOffset(Offset = "0xB")]
	public bool mission_switch;

	[Token(Token = "0x400AE57")]
	[FieldOffset(Offset = "0xC")]
	public bool mode_switch;

	[Token(Token = "0x400AE58")]
	[FieldOffset(Offset = "0x10")]
	public uint mode_show_time_start;

	[Token(Token = "0x400AE59")]
	[FieldOffset(Offset = "0x14")]
	public uint mode_time_start;

	[Token(Token = "0x400AE5A")]
	[FieldOffset(Offset = "0x18")]
	public uint mode_time_end;

	[Token(Token = "0x400AE5B")]
	[FieldOffset(Offset = "0x1C")]
	public uint mode_go_pos;

	[Token(Token = "0x400AE5C")]
	[FieldOffset(Offset = "0x20")]
	public uint mode_sub_go_pos;

	[Token(Token = "0x400AE5D")]
	[FieldOffset(Offset = "0x24")]
	public string web_url;

	[Token(Token = "0x400AE5E")]
	[FieldOffset(Offset = "0x28")]
	public uint web_event_start;

	[Token(Token = "0x400AE5F")]
	[FieldOffset(Offset = "0x2C")]
	public uint web_event_end;

	[Token(Token = "0x400AE60")]
	[FieldOffset(Offset = "0x30")]
	public uint token_id;

	[Token(Token = "0x400AE61")]
	[FieldOffset(Offset = "0x34")]
	public uint rev1_start;

	[Token(Token = "0x400AE62")]
	[FieldOffset(Offset = "0x38")]
	public uint rev1_end;

	[Token(Token = "0x400AE63")]
	[FieldOffset(Offset = "0x3C")]
	public uint rev1_go_pos;

	[Token(Token = "0x400AE64")]
	[FieldOffset(Offset = "0x40")]
	public uint rev1_sub_go_pos;

	[Token(Token = "0x400AE65")]
	[FieldOffset(Offset = "0x44")]
	public string rev1_cdn;

	[Token(Token = "0x400AE66")]
	[FieldOffset(Offset = "0x48")]
	public string rev1_key;

	[Token(Token = "0x400AE67")]
	[FieldOffset(Offset = "0x4C")]
	public uint rev2_start;

	[Token(Token = "0x400AE68")]
	[FieldOffset(Offset = "0x50")]
	public uint rev2_end;

	[Token(Token = "0x400AE69")]
	[FieldOffset(Offset = "0x54")]
	public uint rev2_go_pos;

	[Token(Token = "0x400AE6A")]
	[FieldOffset(Offset = "0x58")]
	public uint rev2_sub_go_pos;

	[Token(Token = "0x400AE6B")]
	[FieldOffset(Offset = "0x5C")]
	public string rev2_cdn;

	[Token(Token = "0x400AE6C")]
	[FieldOffset(Offset = "0x60")]
	public string rev2_key;

	[Token(Token = "0x400AE6D")]
	[FieldOffset(Offset = "0x64")]
	public uint four_symbols_chat_duration;

	[Token(Token = "0x400AE6E")]
	[FieldOffset(Offset = "0x68")]
	public List<AwardDesc> chess_final_awards;

	[Token(Token = "0x400AE6F")]
	[FieldOffset(Offset = "0x6C")]
	public List<AwardDesc> sign_in_accumulate_awards;

	[Token(Token = "0x400AE70")]
	[FieldOffset(Offset = "0x70")]
	public uint cumulative_times;

	[Token(Token = "0x400AE71")]
	[FieldOffset(Offset = "0x74")]
	public string final_node_title_key;

	[Token(Token = "0x400AE72")]
	[FieldOffset(Offset = "0x78")]
	public string final_node_text_key;

	[Token(Token = "0x400AE73")]
	[FieldOffset(Offset = "0x7C")]
	public string web_cdn;

	[Token(Token = "0x6008210")]
	[Address(RVA = "0x30A0FFC", Offset = "0x30A0FFC", VA = "0x30A0FFC")]
	public FourSymbolsSettingDesc()
	{
	}
}
