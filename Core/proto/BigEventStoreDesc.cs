using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B32")]
public class BigEventStoreDesc
{
	[Token(Token = "0x400AAF0")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x400AAF1")]
	[FieldOffset(Offset = "0xC")]
	public ELimitedEvent.EventID event_id;

	[Token(Token = "0x400AAF2")]
	[FieldOffset(Offset = "0x10")]
	public ELimitedEvent.StoreType store_type;

	[Token(Token = "0x400AAF3")]
	[FieldOffset(Offset = "0x14")]
	public string start_time;

	[Token(Token = "0x400AAF4")]
	[FieldOffset(Offset = "0x18")]
	public string end_time;

	[Token(Token = "0x400AAF5")]
	[FieldOffset(Offset = "0x1C")]
	public uint start_timestamp;

	[Token(Token = "0x400AAF6")]
	[FieldOffset(Offset = "0x20")]
	public uint end_timestamp;

	[Token(Token = "0x400AAF7")]
	[FieldOffset(Offset = "0x24")]
	public uint condition;

	[Token(Token = "0x400AAF8")]
	[FieldOffset(Offset = "0x28")]
	public string cdn_url;

	[Token(Token = "0x600818D")]
	[Address(RVA = "0x317C3EC", Offset = "0x317C3EC", VA = "0x317C3EC")]
	public BigEventStoreDesc()
	{
	}
}
