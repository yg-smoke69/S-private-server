using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW.GamePlay;

[Serializable]
[Token(Token = "0x200092B")]
public class AIAttachEffects
{
	[Token(Token = "0x4005539")]
	[FieldOffset(Offset = "0x8")]
	public List<AIAttachEffect> ActiveEffects;

	[Token(Token = "0x400553A")]
	[FieldOffset(Offset = "0xC")]
	public List<AIAttachEffect> DisActiveEffects;

	[Token(Token = "0x6004070")]
	[Address(RVA = "0x1DEEC8C", Offset = "0x1DEEC8C", VA = "0x1DEEC8C")]
	public AIAttachEffects()
	{
	}
}
