using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A7D")]
public class EventSettingDesc
{
	[Token(Token = "0x400A5C7")]
	[FieldOffset(Offset = "0x8")]
	public uint ep_event_id;

	[Token(Token = "0x400A5C8")]
	[FieldOffset(Offset = "0xC")]
	public string start_time;

	[Token(Token = "0x400A5C9")]
	[FieldOffset(Offset = "0x10")]
	public string end_time;

	[Token(Token = "0x400A5CA")]
	[FieldOffset(Offset = "0x14")]
	public string ep_event_name;

	[Token(Token = "0x400A5CB")]
	[FieldOffset(Offset = "0x18")]
	public uint ep_badge;

	[Token(Token = "0x400A5CC")]
	[FieldOffset(Offset = "0x1C")]
	public uint gold_limit_improved;

	[Token(Token = "0x400A5CD")]
	[FieldOffset(Offset = "0x20")]
	public uint fp_challenge;

	[Token(Token = "0x400A5CE")]
	[FieldOffset(Offset = "0x28")]
	public long start_timestamp;

	[Token(Token = "0x400A5CF")]
	[FieldOffset(Offset = "0x30")]
	public long end_timestamp;

	[Token(Token = "0x400A5D0")]
	[FieldOffset(Offset = "0x38")]
	public uint completion_per_round;

	[Token(Token = "0x400A5D1")]
	[FieldOffset(Offset = "0x3C")]
	public uint completion_per_day;

	[Token(Token = "0x60080DA")]
	[Address(RVA = "0x309FB10", Offset = "0x309FB10", VA = "0x309FB10")]
	public EventSettingDesc()
	{
	}
}
