using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001508")]
public class AccountInfoBasicBundleRes
{
	[Token(Token = "0x4009091")]
	[FieldOffset(Offset = "0x8")]
	public List<AccountInfoBasic> infos;

	[Token(Token = "0x6007B51")]
	[Address(RVA = "0x3179718", Offset = "0x3179718", VA = "0x3179718")]
	public AccountInfoBasicBundleRes()
	{
	}
}
