using System;
using Il2CppDummyDll;
using message;

[Serializable]
[Token(Token = "0x200070F")]
public class AISpawnInfo
{
	[Token(Token = "0x4004BFD")]
	[FieldOffset(Offset = "0x8")]
	public LAKANBFBEOK AIType;

	[Token(Token = "0x4004BFE")]
	[FieldOffset(Offset = "0xC")]
	public int AISkinID;

	[Token(Token = "0x4004BFF")]
	[FieldOffset(Offset = "0x10")]
	public int SpawnNum;

	[Token(Token = "0x4004C00")]
	[FieldOffset(Offset = "0x14")]
	public float HealthScaleOnBase;

	[Token(Token = "0x4004C01")]
	[FieldOffset(Offset = "0x18")]
	public float SpeedScale;

	[Token(Token = "0x4004C02")]
	[FieldOffset(Offset = "0x1C")]
	public bool isBoss;

	[Token(Token = "0x6002CD5")]
	[Address(RVA = "0x35BBD64", Offset = "0x35BBD64", VA = "0x35BBD64")]
	public AISpawnInfo()
	{
	}
}
