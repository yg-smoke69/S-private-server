using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200156E")]
public class CSAccountCupInfoBundleRes
{
	[Token(Token = "0x400931E")]
	[FieldOffset(Offset = "0x8")]
	public List<CSAccountCupInfoRes> account_infos;

	[Token(Token = "0x6007BB6")]
	[Address(RVA = "0x317D740", Offset = "0x317D740", VA = "0x317D740")]
	public CSAccountCupInfoBundleRes()
	{
	}
}
