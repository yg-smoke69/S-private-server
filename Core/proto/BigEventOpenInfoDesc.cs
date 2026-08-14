using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B34")]
public class BigEventOpenInfoDesc
{
	[Token(Token = "0x400AB03")]
	[FieldOffset(Offset = "0x8")]
	public ELimitedEvent.EventID event_id;

	[Token(Token = "0x400AB04")]
	[FieldOffset(Offset = "0xC")]
	public ELimitedEvent.EventState event_state;

	[Token(Token = "0x400AB05")]
	[FieldOffset(Offset = "0x10")]
	public string start_time;

	[Token(Token = "0x400AB06")]
	[FieldOffset(Offset = "0x14")]
	public string end_time;

	[Token(Token = "0x400AB07")]
	[FieldOffset(Offset = "0x18")]
	public uint start_timestamp;

	[Token(Token = "0x400AB08")]
	[FieldOffset(Offset = "0x1C")]
	public uint end_timestamp;

	[Token(Token = "0x600818F")]
	[Address(RVA = "0x317C1A4", Offset = "0x317C1A4", VA = "0x317C1A4")]
	public BigEventOpenInfoDesc()
	{
	}
}
