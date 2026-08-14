using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000AA7")]
public class EnvWeatherEffect
{
	[Token(Token = "0x4005D3B")]
	[FieldOffset(Offset = "0x8")]
	public string effectResourceID;

	[Token(Token = "0x4005D3C")]
	[FieldOffset(Offset = "0xC")]
	public float effectUp;

	[Token(Token = "0x4005D3D")]
	[FieldOffset(Offset = "0x10")]
	public float effectDistance;

	[Token(Token = "0x4005D3E")]
	[FieldOffset(Offset = "0x14")]
	public bool stopWhenUnderShelter;

	[Token(Token = "0x600519B")]
	[Address(RVA = "0x320DA10", Offset = "0x320DA10", VA = "0x320DA10")]
	public EnvWeatherEffect()
	{
	}
}
