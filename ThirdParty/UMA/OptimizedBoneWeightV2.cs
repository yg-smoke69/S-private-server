using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CC6")]
public struct OptimizedBoneWeightV2
{
	[Token(Token = "0x4019D07")]
	[FieldOffset(Offset = "0x0")]
	public uint boneIndex;

	[Token(Token = "0x4019D08")]
	[FieldOffset(Offset = "0x4")]
	public uint weight;

	[Token(Token = "0x6018524")]
	[Address(RVA = "0x2D4F09C", Offset = "0x2D4F09C", VA = "0x2D4F09C")]
	private static int FloatToByte(float x)
	{
		return default(int);
	}

	[Token(Token = "0x6018525")]
	[Address(RVA = "0x2D4F1CC", Offset = "0x2D4F1CC", VA = "0x2D4F1CC")]
	private static float ByteToFloat(uint x)
	{
		return default(float);
	}

	[Token(Token = "0x6018526")]
	[Address(RVA = "0x2D4F1EC", Offset = "0x2D4F1EC", VA = "0x2D4F1EC")]
	public static uint ConvertToUInt(float x, float y, float z, float w)
	{
		return default(uint);
	}

	[Token(Token = "0x6018527")]
	[Address(RVA = "0x2D4F230", Offset = "0x2D4F230", VA = "0x2D4F230")]
	public static implicit operator OptimizedBoneWeightV2(BoneWeight sourceWeight)
	{
		return default(OptimizedBoneWeightV2);
	}

	[Token(Token = "0x6018528")]
	[Address(RVA = "0x2D4F324", Offset = "0x2D4F324", VA = "0x2D4F324")]
	public static implicit operator OptimizedBoneWeightV2(OptimizedBoneWeight sourceWeight)
	{
		return default(OptimizedBoneWeightV2);
	}

	[Token(Token = "0x6018529")]
	[Address(RVA = "0x2D4F36C", Offset = "0x2D4F36C", VA = "0x2D4F36C")]
	public static implicit operator BoneWeight(OptimizedBoneWeightV2 sourceWeight)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(BoneWeight);
	}

	[Token(Token = "0x601852A")]
	[Address(RVA = "0x2D4F490", Offset = "0x2D4F490", VA = "0x2D4F490")]
	public static BoneWeight[] Convert(OptimizedBoneWeightV2[] boneWeights)
	{
		return null;
	}

	[Token(Token = "0x601852B")]
	[Address(RVA = "0x2D4F5B4", Offset = "0x2D4F5B4", VA = "0x2D4F5B4")]
	public static OptimizedBoneWeightV2[] Convert(BoneWeight[] boneWeights)
	{
		return null;
	}

	[Token(Token = "0x601852C")]
	[Address(RVA = "0x93D82C", Offset = "0x93D82C", VA = "0x93D82C")]
	public void TranslateBoneWeight(ref BoneWeight dest, int[] boneMapping)
	{
	}

	[Token(Token = "0x601852D")]
	[Address(RVA = "0x2D4F830", Offset = "0x2D4F830", VA = "0x2D4F830")]
	public static OptimizedBoneWeightV2 UpdateBoneIndex(ref OptimizedBoneWeightV2 source, int[] indexMapping)
	{
		return default(OptimizedBoneWeightV2);
	}
}
