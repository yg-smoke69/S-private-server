using System;
using Il2CppDummyDll;
using message;

namespace COW.GamePlay;

[Serializable]
[Token(Token = "0x200092D")]
public class SkillEffectInfo
{
	[Token(Token = "0x400553D")]
	[FieldOffset(Offset = "0x8")]
	public OPKPPFDNCMC SkillType;

	[Token(Token = "0x400553E")]
	[FieldOffset(Offset = "0xC")]
	public GDEHAFJBPGE SkillPhase;

	[Token(Token = "0x400553F")]
	[FieldOffset(Offset = "0x10")]
	public AIAttachEffects attachEffects;

	[Token(Token = "0x6004072")]
	[Address(RVA = "0x1D79EE8", Offset = "0x1D79EE8", VA = "0x1D79EE8")]
	public SkillEffectInfo()
	{
	}
}
