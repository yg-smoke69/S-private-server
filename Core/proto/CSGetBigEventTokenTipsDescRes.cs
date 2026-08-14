using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001875")]
public class CSGetBigEventTokenTipsDescRes
{
	[Token(Token = "0x4009D02")]
	[FieldOffset(Offset = "0x8")]
	public List<BigEventTokenTipsDesc> descs;

	[Token(Token = "0x6007ECE")]
	[Address(RVA = "0x3182300", Offset = "0x3182300", VA = "0x3182300")]
	public CSGetBigEventTokenTipsDescRes()
	{
	}
}
