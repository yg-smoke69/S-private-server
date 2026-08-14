using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A04")]
public class BillboardDesc
{
	[Token(Token = "0x400A326")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A327")]
	[FieldOffset(Offset = "0xC")]
	public string desc;

	[Token(Token = "0x400A328")]
	[FieldOffset(Offset = "0x10")]
	public uint enabled;

	[Token(Token = "0x600805C")]
	[Address(RVA = "0x317C550", Offset = "0x317C550", VA = "0x317C550")]
	public BillboardDesc()
	{
	}
}
