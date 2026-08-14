using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2001DF8")]
public class CameraShakeParam
{
	[Token(Token = "0x400BDFB")]
	[FieldOffset(Offset = "0x8")]
	public bool Enable;

	[Token(Token = "0x400BDFC")]
	[FieldOffset(Offset = "0xC")]
	public float Duration;

	[Token(Token = "0x400BDFD")]
	[FieldOffset(Offset = "0x10")]
	public float Factor;

	[Token(Token = "0x6008F87")]
	[Address(RVA = "0x230CD28", Offset = "0x230CD28", VA = "0x230CD28")]
	public CameraShakeParam()
	{
	}
}
