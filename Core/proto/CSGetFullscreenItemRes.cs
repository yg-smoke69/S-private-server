using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016D2")]
public class CSGetFullscreenItemRes
{
	[Token(Token = "0x400975F")]
	[FieldOffset(Offset = "0x8")]
	public List<FullscreenItemDesc> fullscreen_items;

	[Token(Token = "0x6007D2C")]
	[Address(RVA = "0x3185644", Offset = "0x3185644", VA = "0x3185644")]
	public CSGetFullscreenItemRes()
	{
	}
}
