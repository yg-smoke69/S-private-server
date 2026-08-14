using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000AA5")]
public class EnvGlobalSetting
{
	[Token(Token = "0x4005D2A")]
	[FieldOffset(Offset = "0x8")]
	public Color lightColor;

	[Token(Token = "0x4005D2B")]
	[FieldOffset(Offset = "0x18")]
	public float lightIntensity;

	[Token(Token = "0x4005D2C")]
	[FieldOffset(Offset = "0x1C")]
	public float darkness;

	[Token(Token = "0x4005D2D")]
	[FieldOffset(Offset = "0x20")]
	public float shadowStrength;

	[Token(Token = "0x4005D2E")]
	[FieldOffset(Offset = "0x24")]
	public float terrainWetness;

	[Token(Token = "0x4005D2F")]
	[FieldOffset(Offset = "0x28")]
	public float lensFlare;

	[Token(Token = "0x4005D30")]
	[FieldOffset(Offset = "0x2C")]
	public Color fogColor;

	[Token(Token = "0x4005D31")]
	[FieldOffset(Offset = "0x3C")]
	public Color ambientColor;

	[Token(Token = "0x4005D32")]
	[FieldOffset(Offset = "0x4C")]
	public bool nightMode;

	[Token(Token = "0x6005199")]
	[Address(RVA = "0x32081C4", Offset = "0x32081C4", VA = "0x32081C4")]
	public EnvGlobalSetting()
	{
	}
}
