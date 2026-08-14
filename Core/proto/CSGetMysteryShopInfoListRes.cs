using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200175A")]
public class CSGetMysteryShopInfoListRes
{
	[Token(Token = "0x4009A0B")]
	[FieldOffset(Offset = "0x8")]
	public List<CSGetMysteryShopInfoRes> mystery_shop_info_list;

	[Token(Token = "0x6007DB4")]
	[Address(RVA = "0x3187F7C", Offset = "0x3187F7C", VA = "0x3187F7C")]
	public CSGetMysteryShopInfoListRes()
	{
	}
}
