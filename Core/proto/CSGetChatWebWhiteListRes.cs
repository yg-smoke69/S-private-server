using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001992")]
public class CSGetChatWebWhiteListRes
{
	[Token(Token = "0x400A01D")]
	[FieldOffset(Offset = "0x8")]
	public List<ChatWebWhiteListDesc> descs;

	[Token(Token = "0x6007FED")]
	[Address(RVA = "0x3182DFC", Offset = "0x3182DFC", VA = "0x3182DFC")]
	public CSGetChatWebWhiteListRes()
	{
	}
}
