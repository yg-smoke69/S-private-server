using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E1D")]
public class AkEventCallbackData : ScriptableObject
{
	[Token(Token = "0x401A4E2")]
	[FieldOffset(Offset = "0xC")]
	public List<int> callbackFlags;

	[Token(Token = "0x401A4E3")]
	[FieldOffset(Offset = "0x10")]
	public List<string> callbackFunc;

	[Token(Token = "0x401A4E4")]
	[FieldOffset(Offset = "0x14")]
	public List<GameObject> callbackGameObj;

	[Token(Token = "0x401A4E5")]
	[FieldOffset(Offset = "0x18")]
	public int uFlags;

	[Token(Token = "0x601940D")]
	[Address(RVA = "0x35D62FC", Offset = "0x35D62FC", VA = "0x35D62FC")]
	public AkEventCallbackData()
	{
	}
}
