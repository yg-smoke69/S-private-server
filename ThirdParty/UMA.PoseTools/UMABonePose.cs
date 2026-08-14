using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA.PoseTools;

[Serializable]
[Token(Token = "0x2003CC4")]
public class UMABonePose : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2003CC5")]
	public class PoseBone
	{
		[Token(Token = "0x4019D02")]
		[FieldOffset(Offset = "0x8")]
		public string bone;

		[Token(Token = "0x4019D03")]
		[FieldOffset(Offset = "0xC")]
		public int hash;

		[Token(Token = "0x4019D04")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x4019D05")]
		[FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x4019D06")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 scale;

		[Token(Token = "0x6018523")]
		[Address(RVA = "0x2D52F58", Offset = "0x2D52F58", VA = "0x2D52F58")]
		public PoseBone()
		{
		}
	}

	[Token(Token = "0x4019CFF")]
	[FieldOffset(Offset = "0xC")]
	public PoseBone[] poses;

	[Token(Token = "0x4019D00")]
	[FieldOffset(Offset = "0x10")]
	public UMABonePose[] tweenPoses;

	[Token(Token = "0x4019D01")]
	[FieldOffset(Offset = "0x14")]
	public float[] tweenWeights;

	[Token(Token = "0x601851B")]
	[Address(RVA = "0x2D525E0", Offset = "0x2D525E0", VA = "0x2D525E0")]
	public UMABonePose()
	{
	}

	[Token(Token = "0x601851C")]
	[Address(RVA = "0x2D525E8", Offset = "0x2D525E8", VA = "0x2D525E8")]
	private void Reset()
	{
	}

	[Token(Token = "0x601851D")]
	[Address(RVA = "0x2D52650", Offset = "0x2D52650", VA = "0x2D52650")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x601851E")]
	[Address(RVA = "0x2D5273C", Offset = "0x2D5273C", VA = "0x2D5273C")]
	public int PoseCount()
	{
		return default(int);
	}

	[Token(Token = "0x601851F")]
	[Address(RVA = "0x2D52750", Offset = "0x2D52750", VA = "0x2D52750")]
	protected float ApplyPoseTweens(UMASkeleton umaSkeleton, float weight)
	{
		return default(float);
	}

	[Token(Token = "0x6018520")]
	[Address(RVA = "0x2D52B5C", Offset = "0x2D52B5C", VA = "0x2D52B5C")]
	public void ApplyPose(UMASkeleton umaSkeleton, float weight)
	{
	}

	[Token(Token = "0x6018521")]
	[Address(RVA = "0x2D52DCC", Offset = "0x2D52DCC", VA = "0x2D52DCC")]
	private static void RecurseTransformsInPrefab(Transform root, List<Transform> transforms)
	{
	}

	[Token(Token = "0x6018522")]
	[Address(RVA = "0x2D52EA8", Offset = "0x2D52EA8", VA = "0x2D52EA8")]
	public static Transform[] GetTransformsInPrefab(Transform prefab)
	{
		return null;
	}
}
