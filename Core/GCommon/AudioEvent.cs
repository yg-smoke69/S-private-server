using System;
using AK.Wwise;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Serializable]
[Token(Token = "0x2003E5D")]
public class AudioEvent : ScriptableObject
{
	[Token(Token = "0x401A5ED")]
	[FieldOffset(Offset = "0xC")]
	public Event PlayEvent;

	[Token(Token = "0x401A5EE")]
	[FieldOffset(Offset = "0x10")]
	public Bank OwnedBank;

	[Token(Token = "0x60195CB")]
	[Address(RVA = "0x306DEEC", Offset = "0x306DEEC", VA = "0x306DEEC")]
	public AudioEvent()
	{
	}
}
