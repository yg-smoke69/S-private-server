using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B15")]
public class LinkActivityMapDesc
{
	[Token(Token = "0x400AA40")]
	[FieldOffset(Offset = "0x8")]
	public string activity_date;

	[Token(Token = "0x400AA41")]
	[FieldOffset(Offset = "0xC")]
	public uint token_id;

	[Token(Token = "0x400AA42")]
	[FieldOffset(Offset = "0x10")]
	public uint award_id;

	[Token(Token = "0x400AA43")]
	[FieldOffset(Offset = "0x14")]
	public uint locate_id;

	[Token(Token = "0x6008170")]
	[Address(RVA = "0x30A4B24", Offset = "0x30A4B24", VA = "0x30A4B24")]
	public LinkActivityMapDesc()
	{
	}
}
