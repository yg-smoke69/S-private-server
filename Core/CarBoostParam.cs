using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000D13")]
public class CarBoostParam
{
	[Token(Token = "0x4006A15")]
	[FieldOffset(Offset = "0x8")]
	public float MaxSpeed;

	[Token(Token = "0x4006A16")]
	[FieldOffset(Offset = "0xC")]
	public float Torque;

	[Token(Token = "0x4006A17")]
	[FieldOffset(Offset = "0x10")]
	public float TimeLength;

	[Token(Token = "0x4006A18")]
	[FieldOffset(Offset = "0x14")]
	public float HighSpeedSteerAngle;

	[Token(Token = "0x600644A")]
	[Address(RVA = "0x230CF10", Offset = "0x230CF10", VA = "0x230CF10")]
	public CarBoostParam()
	{
	}
}
