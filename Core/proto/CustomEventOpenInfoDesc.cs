using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B2C")]
public class CustomEventOpenInfoDesc
{
	[Token(Token = "0x400AACA")]
	[FieldOffset(Offset = "0x8")]
	public uint custom_event_id;

	[Token(Token = "0x400AACB")]
	[FieldOffset(Offset = "0xC")]
	public uint template_id;

	[Token(Token = "0x400AACC")]
	[FieldOffset(Offset = "0x10")]
	public ECustomEvent.EventState event_state;

	[Token(Token = "0x400AACD")]
	[FieldOffset(Offset = "0x14")]
	public string start_time;

	[Token(Token = "0x400AACE")]
	[FieldOffset(Offset = "0x18")]
	public string end_time;

	[Token(Token = "0x400AACF")]
	[FieldOffset(Offset = "0x1C")]
	public uint start_timestamp;

	[Token(Token = "0x400AAD0")]
	[FieldOffset(Offset = "0x20")]
	public uint end_timestamp;

	[Token(Token = "0x400AAD1")]
	[FieldOffset(Offset = "0x24")]
	public string cdn_url;

	[Token(Token = "0x6008187")]
	[Address(RVA = "0x309E1AC", Offset = "0x309E1AC", VA = "0x309E1AC")]
	public CustomEventOpenInfoDesc()
	{
	}
}
