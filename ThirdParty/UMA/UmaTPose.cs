using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CF8")]
public class UmaTPose : ScriptableObject
{
	[NonSerialized]
	[Token(Token = "0x4019E39")]
	[FieldOffset(Offset = "0xC")]
	public SkeletonBone[] boneInfo;

	[NonSerialized]
	[Token(Token = "0x4019E3A")]
	[FieldOffset(Offset = "0x10")]
	public HumanBone[] humanInfo;

	[NonSerialized]
	[Token(Token = "0x4019E3B")]
	[FieldOffset(Offset = "0x14")]
	public float armStretch;

	[NonSerialized]
	[Token(Token = "0x4019E3C")]
	[FieldOffset(Offset = "0x18")]
	public float feetSpacing;

	[NonSerialized]
	[Token(Token = "0x4019E3D")]
	[FieldOffset(Offset = "0x1C")]
	public float legStretch;

	[NonSerialized]
	[Token(Token = "0x4019E3E")]
	[FieldOffset(Offset = "0x20")]
	public float lowerArmTwist;

	[NonSerialized]
	[Token(Token = "0x4019E3F")]
	[FieldOffset(Offset = "0x24")]
	public float lowerLegTwist;

	[NonSerialized]
	[Token(Token = "0x4019E40")]
	[FieldOffset(Offset = "0x28")]
	public float upperArmTwist;

	[NonSerialized]
	[Token(Token = "0x4019E41")]
	[FieldOffset(Offset = "0x2C")]
	public float upperLegTwist;

	[NonSerialized]
	[Token(Token = "0x4019E42")]
	[FieldOffset(Offset = "0x30")]
	public bool extendedInfo;

	[Token(Token = "0x4019E43")]
	[FieldOffset(Offset = "0x34")]
	public byte[] serializedChunk;

	[Token(Token = "0x601869E")]
	[Address(RVA = "0x35EDFE0", Offset = "0x35EDFE0", VA = "0x35EDFE0")]
	public UmaTPose()
	{
	}

	[Token(Token = "0x601869F")]
	[Address(RVA = "0x35EDFE8", Offset = "0x35EDFE8", VA = "0x35EDFE8")]
	public void Serialize()
	{
	}

	[Token(Token = "0x60186A0")]
	[Address(RVA = "0x35EE604", Offset = "0x35EE604", VA = "0x35EE604")]
	public void DeSerialize()
	{
	}

	[Token(Token = "0x60186A1")]
	[Address(RVA = "0x35EE950", Offset = "0x35EE950", VA = "0x35EE950")]
	private SkeletonBone DeSerializeSkeletonBone(BinaryReader br)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(SkeletonBone);
	}

	[Token(Token = "0x60186A2")]
	[Address(RVA = "0x35EEBDC", Offset = "0x35EEBDC", VA = "0x35EEBDC")]
	private Quaternion DeSerializeQuaternion(BinaryReader br)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}

	[Token(Token = "0x60186A3")]
	[Address(RVA = "0x35EEA44", Offset = "0x35EEA44", VA = "0x35EEA44")]
	private HumanBone DeSerializeHumanBone(BinaryReader br)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(HumanBone);
	}

	[Token(Token = "0x60186A4")]
	[Address(RVA = "0x35EECAC", Offset = "0x35EECAC", VA = "0x35EECAC")]
	private HumanLimit DeSerializeHumanLimit(BinaryReader br)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(HumanLimit);
	}

	[Token(Token = "0x60186A5")]
	[Address(RVA = "0x35EEB3C", Offset = "0x35EEB3C", VA = "0x35EEB3C")]
	private Vector3 DeserializeVector3(BinaryReader br)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60186A6")]
	[Address(RVA = "0x35EE4D8", Offset = "0x35EE4D8", VA = "0x35EE4D8")]
	private void Serialize(BinaryWriter bn, HumanBone value)
	{
	}

	[Token(Token = "0x60186A7")]
	[Address(RVA = "0x35EEDBC", Offset = "0x35EEDBC", VA = "0x35EEDBC")]
	private void Serialize(BinaryWriter bn, HumanLimit value)
	{
	}

	[Token(Token = "0x60186A8")]
	[Address(RVA = "0x35EE3E8", Offset = "0x35EE3E8", VA = "0x35EE3E8")]
	private void Serialize(BinaryWriter bn, SkeletonBone bone)
	{
	}

	[Token(Token = "0x60186A9")]
	[Address(RVA = "0x35EEFA4", Offset = "0x35EEFA4", VA = "0x35EEFA4")]
	private void Serialize(BinaryWriter bn, Quaternion value)
	{
	}

	[Token(Token = "0x60186AA")]
	[Address(RVA = "0x35EEF10", Offset = "0x35EEF10", VA = "0x35EEF10")]
	private void Serialize(BinaryWriter bn, Vector3 value)
	{
	}

	[Token(Token = "0x60186AB")]
	[Address(RVA = "0x35EF064", Offset = "0x35EF064", VA = "0x35EF064")]
	public void ReadFromHumanDescription(HumanDescription description)
	{
	}

	[Token(Token = "0x60186AC")]
	[Address(RVA = "0x35EF144", Offset = "0x35EF144", VA = "0x35EF144")]
	public void ReadFromTransform(Animator rootAnimator)
	{
	}

	[Token(Token = "0x60186AD")]
	[Address(RVA = "0x35EF484", Offset = "0x35EF484", VA = "0x35EF484")]
	private void ExtractHumanInfo(Animator animator, List<HumanBone> humanInfoList)
	{
	}

	[Token(Token = "0x60186AE")]
	[Address(RVA = "0x35EF28C", Offset = "0x35EF28C", VA = "0x35EF28C")]
	private void AddRecursively(List<SkeletonBone> boneInfoList, Transform root)
	{
	}
}
