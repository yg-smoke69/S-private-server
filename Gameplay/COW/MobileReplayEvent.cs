using System;
using Il2CppDummyDll;
using message;

namespace COW;

[Serializable]
[Token(Token = "0x2000816")]
public class MobileReplayEvent
{
	[Token(Token = "0x40050DD")]
	[FieldOffset(Offset = "0x8")]
	public float Time;

	[Token(Token = "0x40050DE")]
	[FieldOffset(Offset = "0xC")]
	public OLDFDLECCBG Event;

	[Token(Token = "0x6003361")]
	[Address(RVA = "0x227882C", Offset = "0x227882C", VA = "0x227882C")]
	public MobileReplayEvent()
	{
	}
}
