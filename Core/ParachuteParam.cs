using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2001DF9")]
public class ParachuteParam
{
	[Token(Token = "0x400BDFE")]
	[FieldOffset(Offset = "0x8")]
	public float UpOffset;

	[Token(Token = "0x400BDFF")]
	[FieldOffset(Offset = "0xC")]
	public float BackOffset;

	[Token(Token = "0x400BE00")]
	[FieldOffset(Offset = "0x10")]
	public float FOV;

	[Token(Token = "0x400BE01")]
	[FieldOffset(Offset = "0x14")]
	public bool ImmediateChange;

	[Token(Token = "0x400BE02")]
	[FieldOffset(Offset = "0x18")]
	public AnimationCurve AnimCur;

	[Token(Token = "0x400BE03")]
	[FieldOffset(Offset = "0x1C")]
	public CameraShakeParam ShakeParam;

	[Token(Token = "0x400BE04")]
	[FieldOffset(Offset = "0x20")]
	public float TransSpeed;

	[Token(Token = "0x6008F88")]
	[Address(RVA = "0x1C79C8C", Offset = "0x1C79C8C", VA = "0x1C79C8C")]
	public ParachuteParam()
	{
	}
}
