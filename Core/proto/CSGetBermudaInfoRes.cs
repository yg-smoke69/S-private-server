using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001810")]
public class CSGetBermudaInfoRes
{
	[Token(Token = "0x4009BFB")]
	[FieldOffset(Offset = "0x8")]
	public List<BermudaRewardInfo> bermudaRewardInfo;

	[Token(Token = "0x6007E6A")]
	[Address(RVA = "0x3182108", Offset = "0x3182108", VA = "0x3182108")]
	public CSGetBermudaInfoRes()
	{
	}
}
