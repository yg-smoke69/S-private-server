using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2003B6B")]
public class HangColliderCapsuleProperty
{
	[Token(Token = "0x4019509")]
	[FieldOffset(Offset = "0x8")]
	public string name;

	[Token(Token = "0x401950A")]
	[FieldOffset(Offset = "0xC")]
	public string rootName;

	[Token(Token = "0x401950B")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 localPosition;

	[Token(Token = "0x401950C")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 localEulerAngles;

	[Token(Token = "0x401950D")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 localScale;

	[Token(Token = "0x401950E")]
	[FieldOffset(Offset = "0x34")]
	public float ColliCapsuleRadius;

	[Token(Token = "0x401950F")]
	[FieldOffset(Offset = "0x38")]
	public float ColliCapsuleHeight;

	[Token(Token = "0x6017A88")]
	[Address(RVA = "0x350D4D8", Offset = "0x350D4D8", VA = "0x350D4D8")]
	public HangColliderCapsuleProperty()
	{
	}

	[Token(Token = "0x6017A89")]
	[Address(RVA = "0x350D5C4", Offset = "0x350D5C4", VA = "0x350D5C4")]
	public void ApplyValues(HangCollider_Capsule collider)
	{
	}
}
