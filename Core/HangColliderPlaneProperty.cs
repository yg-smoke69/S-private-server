using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2003B6C")]
public class HangColliderPlaneProperty
{
	[Token(Token = "0x4019510")]
	[FieldOffset(Offset = "0x8")]
	public string name;

	[Token(Token = "0x4019511")]
	[FieldOffset(Offset = "0xC")]
	public string rootName;

	[Token(Token = "0x4019512")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 localPosition;

	[Token(Token = "0x4019513")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 localEulerAngles;

	[Token(Token = "0x4019514")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 localScale;

	[Token(Token = "0x6017A8A")]
	[Address(RVA = "0x350D724", Offset = "0x350D724", VA = "0x350D724")]
	public HangColliderPlaneProperty()
	{
	}

	[Token(Token = "0x6017A8B")]
	[Address(RVA = "0x350D800", Offset = "0x350D800", VA = "0x350D800")]
	public void ApplyValues(HangCollider_Plane collider)
	{
	}
}
