using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BFC")]
public class HurricaneBRandomEle
{
	[Token(Token = "0x400B027")]
	[FieldOffset(Offset = "0x8")]
	public uint element_id;

	[Token(Token = "0x400B028")]
	[FieldOffset(Offset = "0xC")]
	public uint probability;

	[Token(Token = "0x6008257")]
	[Address(RVA = "0x30A354C", Offset = "0x30A354C", VA = "0x30A354C")]
	public HurricaneBRandomEle()
	{
	}
}
