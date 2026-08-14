using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CD6")]
public class UMADynamicBoneProperties : ScriptableObject
{
	[Token(Token = "0x4019D8A")]
	[FieldOffset(Offset = "0xC")]
	public float m_UpdateRate;

	[Token(Token = "0x4019D8B")]
	[FieldOffset(Offset = "0x10")]
	public float m_Damping;

	[Token(Token = "0x4019D8C")]
	[FieldOffset(Offset = "0x14")]
	public float m_Elasticity;

	[Token(Token = "0x4019D8D")]
	[FieldOffset(Offset = "0x18")]
	public float m_Stiffness;

	[Token(Token = "0x4019D8E")]
	[FieldOffset(Offset = "0x1C")]
	public float m_Inert;

	[Token(Token = "0x4019D8F")]
	[FieldOffset(Offset = "0x20")]
	public float m_Radius;

	[Token(Token = "0x4019D90")]
	[FieldOffset(Offset = "0x24")]
	public float m_EndLength;

	[Token(Token = "0x4019D91")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 m_EndOffset;

	[Token(Token = "0x4019D92")]
	[FieldOffset(Offset = "0x34")]
	public Vector3 m_Gravity;

	[Token(Token = "0x4019D93")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 m_Force;

	[Token(Token = "0x4019D94")]
	[FieldOffset(Offset = "0x4C")]
	public bool m_AnimationControlled;

	[Token(Token = "0x4019D95")]
	[FieldOffset(Offset = "0x4D")]
	public bool m_useNet;

	[Token(Token = "0x4019D96")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 m_RandomAcceleration;

	[Token(Token = "0x4019D97")]
	[FieldOffset(Offset = "0x5C")]
	public int m_RandomAccelerationInterval;

	[Token(Token = "0x601859C")]
	[Address(RVA = "0x2E011B8", Offset = "0x2E011B8", VA = "0x2E011B8")]
	public UMADynamicBoneProperties()
	{
	}

	[Token(Token = "0x601859D")]
	[Address(RVA = "0x2E012D8", Offset = "0x2E012D8", VA = "0x2E012D8")]
	public void ApplyValues(DynamicBone dynamicBone, Transform root)
	{
	}

	[Token(Token = "0x601859E")]
	[Address(RVA = "0x2E0148C", Offset = "0x2E0148C", VA = "0x2E0148C")]
	public void ApplyValues(DynamicBoneNet dynamicBoneNet, Transform root)
	{
	}

	[Token(Token = "0x601859F")]
	[Address(RVA = "0x2E01640", Offset = "0x2E01640", VA = "0x2E01640")]
	public void ReadValues(DynamicBone dynamicBone)
	{
	}
}
