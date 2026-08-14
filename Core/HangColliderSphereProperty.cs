using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2003B6D")]
public class HangColliderSphereProperty
{
	[Token(Token = "0x4019515")]
	[FieldOffset(Offset = "0x8")]
	public string name;

	[Token(Token = "0x4019516")]
	[FieldOffset(Offset = "0xC")]
	public string rootName;

	[Token(Token = "0x4019517")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 localPosition;

	[Token(Token = "0x4019518")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 localEulerAngles;

	[Token(Token = "0x4019519")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 localScale;

	[Token(Token = "0x401951A")]
	[FieldOffset(Offset = "0x34")]
	public float ColliSphereRadius;

	[Token(Token = "0x6017A8C")]
	[Address(RVA = "0x350D91C", Offset = "0x350D91C", VA = "0x350D91C")]
	public HangColliderSphereProperty()
	{
	}

	[Token(Token = "0x6017A8D")]
	[Address(RVA = "0x350D9FC", Offset = "0x350D9FC", VA = "0x350D9FC")]
	public void ApplyValues(HangCollider_Sphere collider)
	{
	}
}
