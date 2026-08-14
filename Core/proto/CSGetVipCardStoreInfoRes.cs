using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001911")]
public class CSGetVipCardStoreInfoRes
{
	[Token(Token = "0x4009EB2")]
	[FieldOffset(Offset = "0x8")]
	public List<VipCardStoreInfo> infos;

	[Token(Token = "0x6007F6A")]
	[Address(RVA = "0x309649C", Offset = "0x309649C", VA = "0x309649C")]
	public CSGetVipCardStoreInfoRes()
	{
	}
}
