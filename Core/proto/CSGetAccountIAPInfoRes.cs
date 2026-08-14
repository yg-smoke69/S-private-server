using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001738")]
public class CSGetAccountIAPInfoRes
{
	[Token(Token = "0x4009999")]
	[FieldOffset(Offset = "0x8")]
	public List<IAPInfoItem> iap_info_res;

	[Token(Token = "0x6007D92")]
	[Address(RVA = "0x3180C1C", Offset = "0x3180C1C", VA = "0x3180C1C")]
	public CSGetAccountIAPInfoRes()
	{
	}
}
