using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001717")]
public class CSGetGoogleRewardsDescRes
{
	[Token(Token = "0x4009870")]
	[FieldOffset(Offset = "0x8")]
	public List<GoogleRewardsDesc> reward_desc;

	[Token(Token = "0x6007D71")]
	[Address(RVA = "0x3185C3C", Offset = "0x3185C3C", VA = "0x3185C3C")]
	public CSGetGoogleRewardsDescRes()
	{
	}
}
