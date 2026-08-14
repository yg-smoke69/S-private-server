using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200139F")]
public class PlatformProfileRes
{
	[Token(Token = "0x4008A40")]
	[FieldOffset(Offset = "0x8")]
	public string external_id;

	[Token(Token = "0x4008A41")]
	[FieldOffset(Offset = "0xC")]
	public uint external_type;

	[Token(Token = "0x4008A42")]
	[FieldOffset(Offset = "0x10")]
	public string external_name;

	[Token(Token = "0x4008A43")]
	[FieldOffset(Offset = "0x14")]
	public string external_icon;

	[Token(Token = "0x6007A9A")]
	[Address(RVA = "0x33DFC54", Offset = "0x33DFC54", VA = "0x33DFC54")]
	public PlatformProfileRes()
	{
	}
}
