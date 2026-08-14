using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CD5")]
public class UMADynamicBoneColliderProperties : ScriptableObject
{
	[Token(Token = "0x4019D85")]
	[FieldOffset(Offset = "0xC")]
	public string m_RootTransformName;

	[Token(Token = "0x4019D86")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Center;

	[Token(Token = "0x4019D87")]
	[FieldOffset(Offset = "0x1C")]
	public float m_Radius;

	[Token(Token = "0x4019D88")]
	[FieldOffset(Offset = "0x20")]
	public float m_Height;

	[Token(Token = "0x4019D89")]
	[FieldOffset(Offset = "0x24")]
	public DynamicBoneCollider.Direction m_Direction;

	[Token(Token = "0x6018599")]
	[Address(RVA = "0x2E01000", Offset = "0x2E01000", VA = "0x2E01000")]
	public UMADynamicBoneColliderProperties()
	{
	}

	[Token(Token = "0x601859A")]
	[Address(RVA = "0x2E010A8", Offset = "0x2E010A8", VA = "0x2E010A8")]
	public void ApplyValues(DynamicBoneCollider dynamicBoneCollider)
	{
	}

	[Token(Token = "0x601859B")]
	[Address(RVA = "0x2E01130", Offset = "0x2E01130", VA = "0x2E01130")]
	public void ReadValues(DynamicBoneCollider dynamicBoneCollider)
	{
	}
}
