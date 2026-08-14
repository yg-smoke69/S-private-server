using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B37")]
public class BigEventEntranceSettingDesc
{
	[Token(Token = "0x400AB23")]
	[FieldOffset(Offset = "0x8")]
	public ELimitedEvent.EventID event_id;

	[Token(Token = "0x400AB24")]
	[FieldOffset(Offset = "0xC")]
	public uint entrance_id;

	[Token(Token = "0x400AB25")]
	[FieldOffset(Offset = "0x10")]
	public uint start_timestamp;

	[Token(Token = "0x400AB26")]
	[FieldOffset(Offset = "0x14")]
	public uint end_timestamp;

	[Token(Token = "0x400AB27")]
	[FieldOffset(Offset = "0x18")]
	public bool display;

	[Token(Token = "0x400AB28")]
	[FieldOffset(Offset = "0x19")]
	public bool is_open;

	[Token(Token = "0x400AB29")]
	[FieldOffset(Offset = "0x1C")]
	public string cdn;

	[Token(Token = "0x400AB2A")]
	[FieldOffset(Offset = "0x20")]
	public uint go_pos;

	[Token(Token = "0x400AB2B")]
	[FieldOffset(Offset = "0x24")]
	public string sub_go_pos;

	[Token(Token = "0x400AB2C")]
	[FieldOffset(Offset = "0x28")]
	public string entrance_name;

	[Token(Token = "0x6008192")]
	[Address(RVA = "0x317BE64", Offset = "0x317BE64", VA = "0x317BE64")]
	public BigEventEntranceSettingDesc()
	{
	}
}
