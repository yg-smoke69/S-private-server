using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using message;

namespace COW.GamePlay;

[Serializable]
[Token(Token = "0x20003DD")]
public class SkillAnim
{
	[Token(Token = "0x400394E")]
	[FieldOffset(Offset = "0x8")]
	public OPKPPFDNCMC m_SkillType;

	[Token(Token = "0x400394F")]
	[FieldOffset(Offset = "0xC")]
	public List<PhaseAnim> m_PhaseAnims;

	[Token(Token = "0x6001149")]
	[Address(RVA = "0x1D79E5C", Offset = "0x1D79E5C", VA = "0x1D79E5C")]
	public SkillAnim()
	{
	}
}
