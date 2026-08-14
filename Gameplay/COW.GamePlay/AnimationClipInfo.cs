using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Serializable]
[Token(Token = "0x20003DB")]
public class AnimationClipInfo
{
	[Token(Token = "0x4003949")]
	[FieldOffset(Offset = "0x8")]
	public BJDDKOAMBAP mAnimType;

	[Token(Token = "0x400394A")]
	[FieldOffset(Offset = "0xC")]
	public AnimationClip mAnimClip;

	[NonSerialized]
	[Token(Token = "0x400394B")]
	[FieldOffset(Offset = "0x10")]
	public string mAnimName;

	[Token(Token = "0x6001147")]
	[Address(RVA = "0x1141FAC", Offset = "0x1141FAC", VA = "0x1141FAC")]
	public AnimationClipInfo()
	{
	}
}
