using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001977")]
public class CSGetCustomEventStoreAccountInfoRes
{
	[Token(Token = "0x4009FDC")]
	[FieldOffset(Offset = "0x8")]
	public List<CustomLimitedStoreAccountInfo> infos;

	[Token(Token = "0x6007FD0")]
	[Address(RVA = "0x3183BA8", Offset = "0x3183BA8", VA = "0x3183BA8")]
	public CSGetCustomEventStoreAccountInfoRes()
	{
	}
}
