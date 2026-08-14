using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2001DCB")]
public class ColliderInfo
{
	[Token(Token = "0x400BC97")]
	[FieldOffset(Offset = "0x8")]
	public Collider m_collider;

	[Token(Token = "0x400BC98")]
	[FieldOffset(Offset = "0xC")]
	public PlayerColliderChecker.HitPart m_hitBoxType;

	[Token(Token = "0x6008E2F")]
	[Address(RVA = "0x230F118", Offset = "0x230F118", VA = "0x230F118")]
	public ColliderInfo()
	{
	}
}
