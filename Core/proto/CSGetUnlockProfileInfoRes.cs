using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001676")]
public class CSGetUnlockProfileInfoRes
{
	[Token(Token = "0x400963E")]
	[FieldOffset(Offset = "0x8")]
	public List<UnlockProfileConfig> infos;

	[Token(Token = "0x6007CC0")]
	[Address(RVA = "0x3095DB0", Offset = "0x3095DB0", VA = "0x3095DB0")]
	public CSGetUnlockProfileInfoRes()
	{
	}
}
