using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C21")]
public class ThumbUpTutorialDesc
{
	[Token(Token = "0x400B112")]
	[FieldOffset(Offset = "0x8")]
	public string rank;

	[Token(Token = "0x400B113")]
	[FieldOffset(Offset = "0xC")]
	public string thumb_up_num;

	[Token(Token = "0x6008285")]
	[Address(RVA = "0x33E3810", Offset = "0x33E3810", VA = "0x33E3810")]
	public ThumbUpTutorialDesc()
	{
	}
}
