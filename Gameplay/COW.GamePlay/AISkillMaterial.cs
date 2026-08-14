using System;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Serializable]
[Token(Token = "0x20008C1")]
public class AISkillMaterial
{
	[Token(Token = "0x4005427")]
	[FieldOffset(Offset = "0x8")]
	public OPKPPFDNCMC m_SkillType;

	[Token(Token = "0x4005428")]
	[FieldOffset(Offset = "0xC")]
	public Material m_Material;

	[Token(Token = "0x6003D39")]
	[Address(RVA = "0x1DEFA64", Offset = "0x1DEFA64", VA = "0x1DEFA64")]
	public AISkillMaterial()
	{
	}
}
