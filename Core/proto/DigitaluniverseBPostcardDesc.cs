using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B6A")]
public class DigitaluniverseBPostcardDesc
{
	[Token(Token = "0x400AC7B")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AC7C")]
	[FieldOffset(Offset = "0xC")]
	public string name;

	[Token(Token = "0x400AC7D")]
	[FieldOffset(Offset = "0x10")]
	public string description;

	[Token(Token = "0x400AC7E")]
	[FieldOffset(Offset = "0x14")]
	public string postcard_resource;

	[Token(Token = "0x400AC7F")]
	[FieldOffset(Offset = "0x18")]
	public string start_time;

	[Token(Token = "0x400AC80")]
	[FieldOffset(Offset = "0x1C")]
	public string end_time;

	[Token(Token = "0x60081C5")]
	[Address(RVA = "0x309EB5C", Offset = "0x309EB5C", VA = "0x309EB5C")]
	public DigitaluniverseBPostcardDesc()
	{
	}
}
