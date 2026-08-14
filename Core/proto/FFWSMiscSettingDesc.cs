using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B92")]
public class FFWSMiscSettingDesc
{
	[Token(Token = "0x400AD62")]
	[FieldOffset(Offset = "0x8")]
	public uint sugar_token_id;

	[Token(Token = "0x400AD63")]
	[FieldOffset(Offset = "0xC")]
	public uint exchange_token_id;

	[Token(Token = "0x400AD64")]
	[FieldOffset(Offset = "0x10")]
	public long guessing_deadline;

	[Token(Token = "0x400AD65")]
	[FieldOffset(Offset = "0x18")]
	public long award_announced_time;

	[Token(Token = "0x400AD66")]
	[FieldOffset(Offset = "0x20")]
	public long live_start_time;

	[Token(Token = "0x400AD67")]
	[FieldOffset(Offset = "0x28")]
	public long live_end_time;

	[Token(Token = "0x400AD68")]
	[FieldOffset(Offset = "0x30")]
	public List<string> live_cdn_urls;

	[Token(Token = "0x400AD69")]
	[FieldOffset(Offset = "0x34")]
	public string live_url;

	[Token(Token = "0x400AD6A")]
	[FieldOffset(Offset = "0x38")]
	public long final_team_url_show_start_time;

	[Token(Token = "0x400AD6B")]
	[FieldOffset(Offset = "0x40")]
	public long final_team_url_show_end_time;

	[Token(Token = "0x400AD6C")]
	[FieldOffset(Offset = "0x48")]
	public string final_team_url;

	[Token(Token = "0x400AD6D")]
	[FieldOffset(Offset = "0x50")]
	public long champion_url_show_switch_time;

	[Token(Token = "0x400AD6E")]
	[FieldOffset(Offset = "0x58")]
	public string champion_url;

	[Token(Token = "0x400AD6F")]
	[FieldOffset(Offset = "0x60")]
	public long store_unlock_time;

	[Token(Token = "0x400AD70")]
	[FieldOffset(Offset = "0x68")]
	public List<string> live_cdn_gopos;

	[Token(Token = "0x60081ED")]
	[Address(RVA = "0x30A051C", Offset = "0x30A051C", VA = "0x30A051C")]
	public FFWSMiscSettingDesc()
	{
	}
}
