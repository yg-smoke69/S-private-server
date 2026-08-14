using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B7A")]
public class BigEventCDNDesc
{
	[Token(Token = "0x400ACE0")]
	[FieldOffset(Offset = "0x8")]
	public ELimitedEvent.EventID event_id;

	[Token(Token = "0x400ACE1")]
	[FieldOffset(Offset = "0xC")]
	public string lanuage;

	[Token(Token = "0x400ACE2")]
	[FieldOffset(Offset = "0x10")]
	public uint cdn_type;

	[Token(Token = "0x400ACE3")]
	[FieldOffset(Offset = "0x14")]
	public string url;

	[Token(Token = "0x60081D5")]
	[Address(RVA = "0x317BCDC", Offset = "0x317BCDC", VA = "0x317BCDC")]
	public BigEventCDNDesc()
	{
	}
}
