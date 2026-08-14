using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000446")]
public class BlackMaskConfig
{
	[Token(Token = "0x4003C3E")]
	[FieldOffset(Offset = "0x8")]
	public float BeginPlayTime;

	[Token(Token = "0x4003C3F")]
	[FieldOffset(Offset = "0xC")]
	public EMaskAnimType maskType;

	[Token(Token = "0x4003C40")]
	[FieldOffset(Offset = "0x10")]
	public float changeDuration;

	[Token(Token = "0x4003C41")]
	[FieldOffset(Offset = "0x14")]
	public float stableDuration;

	[Token(Token = "0x600155E")]
	[Address(RVA = "0x2ED0D6C", Offset = "0x2ED0D6C", VA = "0x2ED0D6C")]
	public BlackMaskConfig()
	{
	}
}
