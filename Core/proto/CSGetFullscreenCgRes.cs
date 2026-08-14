using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016D1")]
public class CSGetFullscreenCgRes
{
	[Token(Token = "0x400975E")]
	[FieldOffset(Offset = "0x8")]
	public List<FullscreenCgDesc> fullscreen_cgs;

	[Token(Token = "0x6007D2B")]
	[Address(RVA = "0x31855B8", Offset = "0x31855B8", VA = "0x31855B8")]
	public CSGetFullscreenCgRes()
	{
	}
}
