using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200192F")]
public class CSGetChummyRequestsRes
{
	[Token(Token = "0x4009F0C")]
	[FieldOffset(Offset = "0x8")]
	public List<ChummyRequest> chummy_requests;

	[Token(Token = "0x6007F88")]
	[Address(RVA = "0x3182F14", Offset = "0x3182F14", VA = "0x3182F14")]
	public CSGetChummyRequestsRes()
	{
	}
}
