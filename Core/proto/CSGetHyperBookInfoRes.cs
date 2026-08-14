using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200198B")]
public class CSGetHyperBookInfoRes
{
	[Token(Token = "0x400A00E")]
	[FieldOffset(Offset = "0x8")]
	public List<HyperBookInfo> book_infos;

	[Token(Token = "0x6007FE6")]
	[Address(RVA = "0x3185FF8", Offset = "0x3185FF8", VA = "0x3185FF8")]
	public CSGetHyperBookInfoRes()
	{
	}
}
