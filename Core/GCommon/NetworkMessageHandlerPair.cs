using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004077")]
public class NetworkMessageHandlerPair
{
	[Token(Token = "0x401B1CA")]
	[FieldOffset(Offset = "0x8")]
	public List<Delegate> CallBacks;

	[Token(Token = "0x401B1CB")]
	[FieldOffset(Offset = "0xC")]
	public Type MsgType;

	[Token(Token = "0x601A395")]
	[Address(RVA = "0x2979990", Offset = "0x2979990", VA = "0x2979990")]
	public NetworkMessageHandlerPair()
	{
	}
}
