using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Serializable]
[Token(Token = "0x2000282")]
public class AnimRef : ScriptableObject
{
	[Token(Token = "0x4000F37")]
	[FieldOffset(Offset = "0xC")]
	public AnimationClip[] Clips;

	[Token(Token = "0x6000C4D")]
	[Address(RVA = "0x14C6CF8", Offset = "0x14C6CF8", VA = "0x14C6CF8")]
	public AnimRef()
	{
	}

	[Token(Token = "0x6000C4E")]
	[Address(RVA = "0x14C6D00", Offset = "0x14C6D00", VA = "0x14C6D00")]
	public AnimationClip GetClip0()
	{
		return null;
	}
}
