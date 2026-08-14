using System;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2000D12")]
public class CarInWaterParam
{
	[Token(Token = "0x4006A0F")]
	[FieldOffset(Offset = "0x8")]
	public bool Amphibious;

	[Token(Token = "0x4006A10")]
	[FieldOffset(Offset = "0xC")]
	public float UpdateBodyYSpeed;

	[Token(Token = "0x4006A11")]
	[FieldOffset(Offset = "0x10")]
	public float EnterWaterBodyY;

	[Token(Token = "0x4006A12")]
	[FieldOffset(Offset = "0x14")]
	public float InWaterBodyY;

	[Token(Token = "0x4006A13")]
	[FieldOffset(Offset = "0x18")]
	public float ExitWaterBodyY;

	[Token(Token = "0x4006A14")]
	[FieldOffset(Offset = "0x1C")]
	public float ExitedWaterBodyLocalY;

	[Token(Token = "0x6006449")]
	[Address(RVA = "0x230CF28", Offset = "0x230CF28", VA = "0x230CF28")]
	public CarInWaterParam()
	{
	}
}
