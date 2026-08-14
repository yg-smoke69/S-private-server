using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CC8")]
public struct UMABoneWeight
{
	[Token(Token = "0x4019D0C")]
	[FieldOffset(Offset = "0x0")]
	public int boneIndex0;

	[Token(Token = "0x4019D0D")]
	[FieldOffset(Offset = "0x4")]
	public int boneIndex1;

	[Token(Token = "0x4019D0E")]
	[FieldOffset(Offset = "0x8")]
	public int boneIndex2;

	[Token(Token = "0x4019D0F")]
	[FieldOffset(Offset = "0xC")]
	public int boneIndex3;

	[Token(Token = "0x4019D10")]
	[FieldOffset(Offset = "0x10")]
	public float weight0;

	[Token(Token = "0x4019D11")]
	[FieldOffset(Offset = "0x14")]
	public float weight1;

	[Token(Token = "0x4019D12")]
	[FieldOffset(Offset = "0x18")]
	public float weight2;

	[Token(Token = "0x4019D13")]
	[FieldOffset(Offset = "0x1C")]
	public float weight3;

	[Token(Token = "0x6018537")]
	[Address(RVA = "0x2DF8060", Offset = "0x2DF8060", VA = "0x2DF8060")]
	public static UMABoneWeight UpdateBoneIndex(ref UMABoneWeight source, int[] indexMapping)
	{
		return default(UMABoneWeight);
	}

	[Token(Token = "0x6018538")]
	[Address(RVA = "0x2DF80C4", Offset = "0x2DF80C4", VA = "0x2DF80C4")]
	public static implicit operator UMABoneWeight(BoneWeight sourceWeight)
	{
		return default(UMABoneWeight);
	}

	[Token(Token = "0x6018539")]
	[Address(RVA = "0x2DF81AC", Offset = "0x2DF81AC", VA = "0x2DF81AC")]
	public static implicit operator BoneWeight(UMABoneWeight sourceWeight)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(BoneWeight);
	}

	[Token(Token = "0x601853A")]
	[Address(RVA = "0x93DAA0", Offset = "0x93DAA0", VA = "0x93DAA0")]
	public void TranslateBoneWeight(ref BoneWeight dest, int[] boneMapping)
	{
	}

	[Token(Token = "0x601853B")]
	[Address(RVA = "0x2DF826C", Offset = "0x2DF826C", VA = "0x2DF826C")]
	public static UMABoneWeight[] Convert(BoneWeight[] boneWeights)
	{
		return null;
	}

	[Token(Token = "0x601853C")]
	[Address(RVA = "0x2DF83A8", Offset = "0x2DF83A8", VA = "0x2DF83A8")]
	public static BoneWeight[] Convert(UMABoneWeight[] boneWeights)
	{
		return null;
	}
}
