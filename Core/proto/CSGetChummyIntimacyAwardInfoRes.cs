using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001932")]
public class CSGetChummyIntimacyAwardInfoRes
{
	[Token(Token = "0x4009F12")]
	[FieldOffset(Offset = "0x8")]
	public List<ChummyIntimacyAwardInfo> award_info;

	[Token(Token = "0x6007F8B")]
	[Address(RVA = "0x3182E88", Offset = "0x3182E88", VA = "0x3182E88")]
	public CSGetChummyIntimacyAwardInfoRes()
	{
	}
}
