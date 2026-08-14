using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B2F")]
public class CustomEventLocDesc
{
	[Token(Token = "0x400AAE3")]
	[FieldOffset(Offset = "0x8")]
	public uint loc_id;

	[Token(Token = "0x400AAE4")]
	[FieldOffset(Offset = "0xC")]
	public string language;

	[Token(Token = "0x400AAE5")]
	[FieldOffset(Offset = "0x10")]
	public string content;

	[Token(Token = "0x400AAE6")]
	[FieldOffset(Offset = "0x14")]
	public string color;

	[Token(Token = "0x600818A")]
	[Address(RVA = "0x309E0F4", Offset = "0x309E0F4", VA = "0x309E0F4")]
	public CustomEventLocDesc()
	{
	}
}
