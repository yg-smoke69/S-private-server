using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001876")]
public class CSGetLiveDescRes
{
	[Token(Token = "0x4009D03")]
	[FieldOffset(Offset = "0x8")]
	public List<LiveDesc> descs;

	[Token(Token = "0x6007ECF")]
	[Address(RVA = "0x3186FB0", Offset = "0x3186FB0", VA = "0x3186FB0")]
	public CSGetLiveDescRes()
	{
	}
}
