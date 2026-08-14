using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BA1")]
public class GoPosShow
{
	[Token(Token = "0x400ADCF")]
	[FieldOffset(Offset = "0x8")]
	public uint go_pos;

	[Token(Token = "0x400ADD0")]
	[FieldOffset(Offset = "0xC")]
	public string sub_go_pos;

	[Token(Token = "0x400ADD1")]
	[FieldOffset(Offset = "0x10")]
	public string desc;

	[Token(Token = "0x60081FC")]
	[Address(RVA = "0x30A28E0", Offset = "0x30A28E0", VA = "0x30A28E0")]
	public GoPosShow()
	{
	}
}
