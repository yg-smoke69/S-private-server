using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001625")]
public class CSClanInfoBundleRes
{
	[Token(Token = "0x400953F")]
	[FieldOffset(Offset = "0x8")]
	public List<ClanInfo> infos;

	[Token(Token = "0x6007C6F")]
	[Address(RVA = "0x317EB68", Offset = "0x317EB68", VA = "0x317EB68")]
	public CSClanInfoBundleRes()
	{
	}
}
