using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000D14")]
public class CarJumpParam
{
	[Token(Token = "0x4006A19")]
	[FieldOffset(Offset = "0x8")]
	public float Height;

	[Token(Token = "0x4006A1A")]
	[FieldOffset(Offset = "0xC")]
	public float Acceleration;

	[Token(Token = "0x4006A1B")]
	[FieldOffset(Offset = "0x10")]
	public float MaxSpeed;

	[Token(Token = "0x600644B")]
	[Address(RVA = "0x230CF60", Offset = "0x230CF60", VA = "0x230CF60")]
	public CarJumpParam()
	{
	}
}
