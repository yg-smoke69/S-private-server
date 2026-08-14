using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2001DF6")]
public class DeathEffectConfig
{
	[Token(Token = "0x400BDED")]
	[FieldOffset(Offset = "0x8")]
	public float DeathEffectDuration;

	[Token(Token = "0x400BDEE")]
	[FieldOffset(Offset = "0xC")]
	public float[] StartDeathVfxFrame;

	[Token(Token = "0x6008F85")]
	[Address(RVA = "0x23113E0", Offset = "0x23113E0", VA = "0x23113E0")]
	public DeathEffectConfig()
	{
	}
}
