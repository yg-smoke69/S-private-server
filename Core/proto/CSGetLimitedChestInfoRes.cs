using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001915")]
public class CSGetLimitedChestInfoRes
{
	[Token(Token = "0x4009EB7")]
	[FieldOffset(Offset = "0x8")]
	public List<LimitedChestInfo> limited_chest_info_list;

	[Token(Token = "0x6007F6E")]
	[Address(RVA = "0x3186818", Offset = "0x3186818", VA = "0x3186818")]
	public CSGetLimitedChestInfoRes()
	{
	}
}
