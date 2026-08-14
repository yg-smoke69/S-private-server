using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B74")]
public class MonopolyEventDesc
{
	[Token(Token = "0x400ACB1")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400ACB2")]
	[FieldOffset(Offset = "0xC")]
	public uint phase;

	[Token(Token = "0x400ACB3")]
	[FieldOffset(Offset = "0x10")]
	public string event_title;

	[Token(Token = "0x400ACB4")]
	[FieldOffset(Offset = "0x14")]
	public string event_desc;

	[Token(Token = "0x400ACB5")]
	[FieldOffset(Offset = "0x18")]
	public MonopolyEventOption event_option1;

	[Token(Token = "0x400ACB6")]
	[FieldOffset(Offset = "0x1C")]
	public MonopolyEventOption event_option2;

	[Token(Token = "0x400ACB7")]
	[FieldOffset(Offset = "0x20")]
	public bool is_mission;

	[Token(Token = "0x400ACB8")]
	[FieldOffset(Offset = "0x24")]
	public uint weight;

	[Token(Token = "0x60081CF")]
	[Address(RVA = "0x30A8ED8", Offset = "0x30A8ED8", VA = "0x30A8ED8")]
	public MonopolyEventDesc()
	{
	}
}
