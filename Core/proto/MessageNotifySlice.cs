using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001376")]
public class MessageNotifySlice
{
	[Token(Token = "0x4008998")]
	[FieldOffset(Offset = "0x8")]
	public List<MessageNotify> msgs;

	[Token(Token = "0x6007A77")]
	[Address(RVA = "0x30A88D8", Offset = "0x30A88D8", VA = "0x30A88D8")]
	public MessageNotifySlice()
	{
	}
}
