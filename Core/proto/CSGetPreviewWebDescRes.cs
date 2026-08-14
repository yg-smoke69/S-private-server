using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015C1")]
public class CSGetPreviewWebDescRes
{
	[Token(Token = "0x4009432")]
	[FieldOffset(Offset = "0x8")]
	public List<PreviewWebDesc> preview_web_descs;

	[Token(Token = "0x6007C0B")]
	[Address(RVA = "0x3094AD8", Offset = "0x3094AD8", VA = "0x3094AD8")]
	public CSGetPreviewWebDescRes()
	{
	}
}
