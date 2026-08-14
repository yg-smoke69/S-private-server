using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000AA8")]
public class EnvWeatherSound
{
	[Token(Token = "0x4005D3F")]
	[FieldOffset(Offset = "0x8")]
	public bool hasSound;

	[Token(Token = "0x4005D40")]
	[FieldOffset(Offset = "0xC")]
	public float volume;

	[Token(Token = "0x4005D41")]
	[FieldOffset(Offset = "0x10")]
	public string loopOutside;

	[Token(Token = "0x4005D42")]
	[FieldOffset(Offset = "0x14")]
	public string loopInRoom;

	[Token(Token = "0x4005D43")]
	[FieldOffset(Offset = "0x18")]
	public string[] footsteps;

	[Token(Token = "0x600519C")]
	[Address(RVA = "0x320DA20", Offset = "0x320DA20", VA = "0x320DA20")]
	public EnvWeatherSound()
	{
	}
}
