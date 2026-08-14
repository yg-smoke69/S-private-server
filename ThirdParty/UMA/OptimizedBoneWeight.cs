using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CC7")]
public struct OptimizedBoneWeight
{
	[Token(Token = "0x4019D09")]
	[FieldOffset(Offset = "0x0")]
	public uint boneIndex;

	[Token(Token = "0x4019D0A")]
	[FieldOffset(Offset = "0x4")]
	public uint weight01;

	[Token(Token = "0x4019D0B")]
	[FieldOffset(Offset = "0x8")]
	public uint weight23;

	[Token(Token = "0x601852E")]
	[Address(RVA = "0x2D4E9A4", Offset = "0x2D4E9A4", VA = "0x2D4E9A4")]
	private static ushort FloatToUShort(float weight)
	{
		return default(ushort);
	}

	[Token(Token = "0x601852F")]
	[Address(RVA = "0x2D4E9C4", Offset = "0x2D4E9C4", VA = "0x2D4E9C4")]
	private static float ShortToFloat(ushort weight)
	{
		return default(float);
	}

	[Token(Token = "0x6018530")]
	[Address(RVA = "0x2D4E9E0", Offset = "0x2D4E9E0", VA = "0x2D4E9E0")]
	public static implicit operator OptimizedBoneWeight(BoneWeight sourceWeight)
	{
		return default(OptimizedBoneWeight);
	}

	[Token(Token = "0x6018531")]
	[Address(RVA = "0x2D4EB08", Offset = "0x2D4EB08", VA = "0x2D4EB08")]
	public static implicit operator OptimizedBoneWeight(UMABoneWeight sourceWeight)
	{
		return default(OptimizedBoneWeight);
	}

	[Token(Token = "0x6018532")]
	[Address(RVA = "0x2D4EB78", Offset = "0x2D4EB78", VA = "0x2D4EB78")]
	public static implicit operator BoneWeight(OptimizedBoneWeight sourceWeight)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(BoneWeight);
	}

	[Token(Token = "0x6018533")]
	[Address(RVA = "0x93D824", Offset = "0x93D824", VA = "0x93D824")]
	public void TranslateBoneWeight(ref BoneWeight dest, int[] boneMapping)
	{
	}

	[Token(Token = "0x6018534")]
	[Address(RVA = "0x2D4EDE0", Offset = "0x2D4EDE0", VA = "0x2D4EDE0")]
	public static OptimizedBoneWeight[] Convert(BoneWeight[] boneWeights)
	{
		return null;
	}

	[Token(Token = "0x6018535")]
	[Address(RVA = "0x2D4EF14", Offset = "0x2D4EF14", VA = "0x2D4EF14")]
	public static BoneWeight[] Convert(OptimizedBoneWeight[] boneWeights)
	{
		return null;
	}

	[Token(Token = "0x6018536")]
	[Address(RVA = "0x2D4F038", Offset = "0x2D4F038", VA = "0x2D4F038")]
	public static OptimizedBoneWeight UpdateBoneIndex(ref OptimizedBoneWeight source, int[] indexMapping)
	{
		return default(OptimizedBoneWeight);
	}
}
