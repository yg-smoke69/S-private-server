using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2003B67")]
public class ANGLE_LIMIT
{
	[Token(Token = "0x40194D0")]
	[FieldOffset(Offset = "0x8")]
	public Transform BaseAxis_1;

	[Token(Token = "0x40194D1")]
	[FieldOffset(Offset = "0xC")]
	public Transform BaseAxis_2;

	[Token(Token = "0x40194D2")]
	[FieldOffset(Offset = "0x10")]
	public float BaseAxisTwoSettingsRate;

	[Token(Token = "0x40194D3")]
	[FieldOffset(Offset = "0x14")]
	public float BoneBlendRate;

	[Token(Token = "0x40194D4")]
	[FieldOffset(Offset = "0x18")]
	public bool PivotLimitUseFlag;

	[Token(Token = "0x40194D5")]
	[FieldOffset(Offset = "0x1C")]
	public float PivotLimitRotOffset;

	[Token(Token = "0x40194D6")]
	[FieldOffset(Offset = "0x20")]
	public bool DBG_PivotLimitDispFlag;

	[Token(Token = "0x40194D7")]
	[FieldOffset(Offset = "0x24")]
	public float Y_AngleMin;

	[Token(Token = "0x40194D8")]
	[FieldOffset(Offset = "0x28")]
	public float Y_AngleMax;

	[Token(Token = "0x40194D9")]
	[FieldOffset(Offset = "0x2C")]
	public float Z_AngleMin;

	[Token(Token = "0x40194DA")]
	[FieldOffset(Offset = "0x30")]
	public float Z_AngleMax;

	[Token(Token = "0x40194DB")]
	[FieldOffset(Offset = "0x34")]
	public HangManager.LANGUAGE_TYPE LanguageType;

	[Token(Token = "0x6017A6C")]
	[Address(RVA = "0x35BDE28", Offset = "0x35BDE28", VA = "0x35BDE28")]
	public ANGLE_LIMIT()
	{
	}
}
