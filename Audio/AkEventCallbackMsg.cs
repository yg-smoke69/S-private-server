using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E1A")]
public class AkEventCallbackMsg
{
	[Token(Token = "0x401A4CF")]
	[FieldOffset(Offset = "0x8")]
	public AkCallbackInfo info;

	[Token(Token = "0x401A4D0")]
	[FieldOffset(Offset = "0xC")]
	public GameObject sender;

	[Token(Token = "0x401A4D1")]
	[FieldOffset(Offset = "0x10")]
	public AkCallbackType type;

	[Token(Token = "0x6019400")]
	[Address(RVA = "0x35D5FD0", Offset = "0x35D5FD0", VA = "0x35D5FD0")]
	public AkEventCallbackMsg()
	{
	}
}
