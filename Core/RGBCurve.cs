using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000790")]
public class RGBCurve : ScriptableObject
{
	[Token(Token = "0x4004E99")]
	[FieldOffset(Offset = "0xC")]
	public AnimationCurve R;

	[Token(Token = "0x4004E9A")]
	[FieldOffset(Offset = "0x10")]
	public AnimationCurve G;

	[Token(Token = "0x4004E9B")]
	[FieldOffset(Offset = "0x14")]
	public AnimationCurve B;

	[Token(Token = "0x1700039D")]
	public float length
	{
		[Token(Token = "0x6003088")]
		[Address(RVA = "0x31501B0", Offset = "0x31501B0", VA = "0x31501B0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6003086")]
	[Address(RVA = "0x3150060", Offset = "0x3150060", VA = "0x3150060")]
	public RGBCurve()
	{
	}

	[Token(Token = "0x6003087")]
	[Address(RVA = "0x315010C", Offset = "0x315010C", VA = "0x315010C")]
	public static float MaxTime(AnimationCurve curve)
	{
		return default(float);
	}

	[Token(Token = "0x6003089")]
	[Address(RVA = "0x3150268", Offset = "0x3150268", VA = "0x3150268")]
	public Vector3 Eval(float t)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}
}
