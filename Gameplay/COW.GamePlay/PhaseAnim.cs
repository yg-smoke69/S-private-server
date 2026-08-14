using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Serializable]
[Token(Token = "0x20003DC")]
public class PhaseAnim
{
	[Token(Token = "0x400394C")]
	[FieldOffset(Offset = "0x8")]
	public GDEHAFJBPGE m_PhaseType;

	[Token(Token = "0x400394D")]
	[FieldOffset(Offset = "0xC")]
	public List<AnimationClip> m_AnimClips;

	[Token(Token = "0x6001148")]
	[Address(RVA = "0xBD0C88", Offset = "0xBD0C88", VA = "0xBD0C88")]
	public PhaseAnim()
	{
	}
}
