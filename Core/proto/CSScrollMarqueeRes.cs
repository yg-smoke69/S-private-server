using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016C1")]
public class CSScrollMarqueeRes
{
	[Token(Token = "0x40096E4")]
	[FieldOffset(Offset = "0x8")]
	public List<ScrollMarqueeDesc> scrollMarquees;

	[Token(Token = "0x6007D22")]
	[Address(RVA = "0x3099610", Offset = "0x3099610", VA = "0x3099610")]
	public CSScrollMarqueeRes()
	{
	}
}
