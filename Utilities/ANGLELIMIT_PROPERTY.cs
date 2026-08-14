using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2003B6E")]
public class ANGLELIMIT_PROPERTY
{
	[Token(Token = "0x401951B")]
	[FieldOffset(Offset = "0x8")]
	public string BaseAxis_1;

	[Token(Token = "0x401951C")]
	[FieldOffset(Offset = "0xC")]
	public string BaseAxis_1_Parent;

	[Token(Token = "0x401951D")]
	[FieldOffset(Offset = "0x10")]
	public Quaternion BaseAxis_1_quaternion;

	[Token(Token = "0x401951E")]
	[FieldOffset(Offset = "0x20")]
	public string BaseAxis_2;

	[Token(Token = "0x401951F")]
	[FieldOffset(Offset = "0x24")]
	public string BaseAxis_2_Parent;

	[Token(Token = "0x4019520")]
	[FieldOffset(Offset = "0x28")]
	public Quaternion BaseAxis_2_quaternion;

	[Token(Token = "0x4019521")]
	[FieldOffset(Offset = "0x38")]
	public float BaseAxisTwoSettingsRate;

	[Token(Token = "0x4019522")]
	[FieldOffset(Offset = "0x3C")]
	public float BoneBlendRate;

	[Token(Token = "0x4019523")]
	[FieldOffset(Offset = "0x40")]
	public bool PivotLimitUseFlag;

	[Token(Token = "0x4019524")]
	[FieldOffset(Offset = "0x44")]
	public float PivotLimitRotOffset;

	[Token(Token = "0x4019525")]
	[FieldOffset(Offset = "0x48")]
	public bool DBG_PivotLimitDispFlag;

	[Token(Token = "0x4019526")]
	[FieldOffset(Offset = "0x4C")]
	public float Y_AngleMin;

	[Token(Token = "0x4019527")]
	[FieldOffset(Offset = "0x50")]
	public float Y_AngleMax;

	[Token(Token = "0x4019528")]
	[FieldOffset(Offset = "0x54")]
	public float Z_AngleMin;

	[Token(Token = "0x4019529")]
	[FieldOffset(Offset = "0x58")]
	public float Z_AngleMax;

	[Token(Token = "0x6017A8E")]
	[Address(RVA = "0x35BDE20", Offset = "0x35BDE20", VA = "0x35BDE20")]
	public ANGLELIMIT_PROPERTY()
	{
	}
}
