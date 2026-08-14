using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001DF5")]
public class GameMiscConfig : ScriptableObject
{
	[Token(Token = "0x400BDEB")]
	[FieldOffset(Offset = "0xC")]
	public DeathEffectConfig DeathEffectConfig;

	[Token(Token = "0x400BDEC")]
	[FieldOffset(Offset = "0x10")]
	public OutSafeZoneEffectConfig OutSafeZoneConfig;

	[Token(Token = "0x6008F84")]
	[Address(RVA = "0x3448844", Offset = "0x3448844", VA = "0x3448844")]
	public GameMiscConfig()
	{
	}
}
