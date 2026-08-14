using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016C2")]
public class CSGetBroadcastListRes
{
	[Token(Token = "0x40096E5")]
	[FieldOffset(Offset = "0x8")]
	public List<BroadcastMessage> broadcast_messages;

	[Token(Token = "0x40096E6")]
	[FieldOffset(Offset = "0xC")]
	public bool silence_show_switch;

	[Token(Token = "0x6007D23")]
	[Address(RVA = "0x3182B1C", Offset = "0x3182B1C", VA = "0x3182B1C")]
	public CSGetBroadcastListRes()
	{
	}
}
