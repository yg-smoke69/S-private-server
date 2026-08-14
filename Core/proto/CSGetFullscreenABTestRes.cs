using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001994")]
public class CSGetFullscreenABTestRes
{
	[Token(Token = "0x400A020")]
	[FieldOffset(Offset = "0x8")]
	public List<FullscreenABTestDesc> fullscreen_desc;

	[Token(Token = "0x6007FEF")]
	[Address(RVA = "0x318552C", Offset = "0x318552C", VA = "0x318552C")]
	public CSGetFullscreenABTestRes()
	{
	}
}
