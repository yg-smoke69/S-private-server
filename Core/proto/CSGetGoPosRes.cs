using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001678")]
public class CSGetGoPosRes
{
	[Token(Token = "0x4009641")]
	[FieldOffset(Offset = "0x8")]
	public List<GoPos> go_pos;

	[Token(Token = "0x6007CC2")]
	[Address(RVA = "0x3185B14", Offset = "0x3185B14", VA = "0x3185B14")]
	public CSGetGoPosRes()
	{
	}
}
