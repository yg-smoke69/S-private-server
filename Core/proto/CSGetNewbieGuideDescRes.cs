using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017C0")]
public class CSGetNewbieGuideDescRes
{
	[Token(Token = "0x4009B51")]
	[FieldOffset(Offset = "0x8")]
	public List<ExpGuideDesc> guide_desc;

	[Token(Token = "0x4009B52")]
	[FieldOffset(Offset = "0xC")]
	public List<ThumbUpTutorialDesc> thumb_up_desc;

	[Token(Token = "0x6007E1A")]
	[Address(RVA = "0x3188268", Offset = "0x3188268", VA = "0x3188268")]
	public CSGetNewbieGuideDescRes()
	{
	}
}
