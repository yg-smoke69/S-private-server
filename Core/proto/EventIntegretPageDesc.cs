using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019D9")]
public class EventIntegretPageDesc
{
	[Token(Token = "0x400A221")]
	[FieldOffset(Offset = "0x8")]
	public uint event_id;

	[Token(Token = "0x400A222")]
	[FieldOffset(Offset = "0xC")]
	public string event_name;

	[Token(Token = "0x400A223")]
	[FieldOffset(Offset = "0x10")]
	public string event_start_time;

	[Token(Token = "0x400A224")]
	[FieldOffset(Offset = "0x14")]
	public string event_end_time;

	[Token(Token = "0x400A225")]
	[FieldOffset(Offset = "0x18")]
	public uint event_start_timestamp;

	[Token(Token = "0x400A226")]
	[FieldOffset(Offset = "0x1C")]
	public uint event_end_timestamp;

	[Token(Token = "0x400A227")]
	[FieldOffset(Offset = "0x20")]
	public string language;

	[Token(Token = "0x400A228")]
	[FieldOffset(Offset = "0x24")]
	public string lobby_icon;

	[Token(Token = "0x400A229")]
	[FieldOffset(Offset = "0x28")]
	public string web_mission_url;

	[Token(Token = "0x400A22A")]
	[FieldOffset(Offset = "0x2C")]
	public List<EventMissionDesc> event_missions;

	[Token(Token = "0x400A22B")]
	[FieldOffset(Offset = "0x30")]
	public string go_pos;

	[Token(Token = "0x6008031")]
	[Address(RVA = "0x309F944", Offset = "0x309F944", VA = "0x309F944")]
	public EventIntegretPageDesc()
	{
	}
}
