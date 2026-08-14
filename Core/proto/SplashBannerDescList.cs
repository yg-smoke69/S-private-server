using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001762")]
public class SplashBannerDescList
{
	[Token(Token = "0x4009A21")]
	[FieldOffset(Offset = "0x8")]
	public List<SplashBannerDesc> splashBanners;

	[Token(Token = "0x6007DBC")]
	[Address(RVA = "0x33E27B0", Offset = "0x33E27B0", VA = "0x33E27B0")]
	public SplashBannerDescList()
	{
	}
}
