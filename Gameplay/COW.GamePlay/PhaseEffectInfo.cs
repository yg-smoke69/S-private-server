using System;
using Il2CppDummyDll;

namespace COW.GamePlay;

[Serializable]
[Token(Token = "0x200092C")]
public class PhaseEffectInfo
{
	[Token(Token = "0x400553B")]
	[FieldOffset(Offset = "0x8")]
	public int Phase;

	[Token(Token = "0x400553C")]
	[FieldOffset(Offset = "0xC")]
	public AIAttachEffects attachEffects;

	[Token(Token = "0x6004071")]
	[Address(RVA = "0xBD0D14", Offset = "0xBD0D14", VA = "0xBD0D14")]
	public PhaseEffectInfo()
	{
	}
}
