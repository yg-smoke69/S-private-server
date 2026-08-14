using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2001DF7")]
public class OutSafeZoneEffectConfig
{
	[Token(Token = "0x400BDEF")]
	[FieldOffset(Offset = "0x8")]
	public float[] Duration;

	[Token(Token = "0x400BDF0")]
	[FieldOffset(Offset = "0xC")]
	public AnimationCurve Curve;

	[Token(Token = "0x400BDF1")]
	[FieldOffset(Offset = "0x10")]
	public AnimationCurve CurvePost;

	[Token(Token = "0x400BDF2")]
	[FieldOffset(Offset = "0x14")]
	public AnimationCurve CurveScreen;

	[Token(Token = "0x400BDF3")]
	[FieldOffset(Offset = "0x18")]
	public float ShowPostDelay;

	[Token(Token = "0x400BDF4")]
	[FieldOffset(Offset = "0x1C")]
	public float StopPostDelay;

	[Token(Token = "0x400BDF5")]
	[FieldOffset(Offset = "0x20")]
	public string BR_Texture_Lut;

	[Token(Token = "0x400BDF6")]
	[FieldOffset(Offset = "0x24")]
	public Color BR_Color_Glich;

	[Token(Token = "0x400BDF7")]
	[FieldOffset(Offset = "0x34")]
	public Color BR_Color_Screen;

	[Token(Token = "0x400BDF8")]
	[FieldOffset(Offset = "0x44")]
	public string CS_Texture_Lut;

	[Token(Token = "0x400BDF9")]
	[FieldOffset(Offset = "0x48")]
	public Color CS_Color_Glich;

	[Token(Token = "0x400BDFA")]
	[FieldOffset(Offset = "0x58")]
	public Color CS_Color_Screen;

	[Token(Token = "0x6008F86")]
	[Address(RVA = "0x1C75D54", Offset = "0x1C75D54", VA = "0x1C75D54")]
	public OutSafeZoneEffectConfig()
	{
	}
}
