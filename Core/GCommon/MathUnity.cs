using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003F0B")]
public class MathUnity
{
	[Token(Token = "0x401A9B0")]
	public const float EPSILON = 1E-05f;

	[Token(Token = "0x401A9B1")]
	public const float RAD0 = 0f;

	[Token(Token = "0x401A9B2")]
	public const float RADHALF = (float)Math.PI / 360f;

	[Token(Token = "0x401A9B3")]
	public const float RAD1 = (float)Math.PI / 180f;

	[Token(Token = "0x401A9B4")]
	public const float RAD5 = 0.08726646f;

	[Token(Token = "0x401A9B5")]
	public const float RAD10 = 0.17453292f;

	[Token(Token = "0x401A9B6")]
	public const float RAD15 = (float)Math.PI / 12f;

	[Token(Token = "0x401A9B7")]
	public const float RAD22HALF = (float)Math.PI / 8f;

	[Token(Token = "0x401A9B8")]
	public const float RAD30 = (float)Math.PI / 6f;

	[Token(Token = "0x401A9B9")]
	public const float RAD45 = (float)Math.PI / 4f;

	[Token(Token = "0x401A9BA")]
	public const float RAD60 = (float)Math.PI / 3f;

	[Token(Token = "0x401A9BB")]
	public const float RAD90 = (float)Math.PI / 2f;

	[Token(Token = "0x401A9BC")]
	public const float RAD120 = (float)Math.PI * 2f / 3f;

	[Token(Token = "0x401A9BD")]
	public const float RAD135 = (float)Math.PI * 3f / 4f;

	[Token(Token = "0x401A9BE")]
	public const float RAD180 = (float)Math.PI;

	[Token(Token = "0x401A9BF")]
	[FieldOffset(Offset = "0x0")]
	public static Matrix4x4 matrixCaculation;

	[Token(Token = "0x401A9C0")]
	[FieldOffset(Offset = "0x40")]
	public static Vector3 Vector3_0;

	[Token(Token = "0x401A9C1")]
	[FieldOffset(Offset = "0x4C")]
	public static Vector3 Vector3_X;

	[Token(Token = "0x401A9C2")]
	[FieldOffset(Offset = "0x58")]
	public static Vector3 Vector3_Y;

	[Token(Token = "0x401A9C3")]
	[FieldOffset(Offset = "0x64")]
	public static Vector3 Vector3_Z;

	[Token(Token = "0x401A9C4")]
	[FieldOffset(Offset = "0x70")]
	public static Vector3 Vector3_NX;

	[Token(Token = "0x401A9C5")]
	[FieldOffset(Offset = "0x7C")]
	public static Vector3 Vector3_NY;

	[Token(Token = "0x401A9C6")]
	[FieldOffset(Offset = "0x88")]
	public static Vector3 Vector3_NZ;

	[Token(Token = "0x6019AC4")]
	[Address(RVA = "0x296A884", Offset = "0x296A884", VA = "0x296A884")]
	public MathUnity()
	{
	}

	[Token(Token = "0x6019AC5")]
	[Address(RVA = "0x296A88C", Offset = "0x296A88C", VA = "0x296A88C")]
	public static Vector3 Vector3ZeroY(Vector3 v)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019AC6")]
	[Address(RVA = "0x296A898", Offset = "0x296A898", VA = "0x296A898")]
	public static Vector3 VectorWithY(Vector3 v, float y)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019AC7")]
	[Address(RVA = "0x296A8C8", Offset = "0x296A8C8", VA = "0x296A8C8")]
	public static Vector3 GetDirection2D(Vector3 to, Vector3 from)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019AC8")]
	[Address(RVA = "0x296A9A8", Offset = "0x296A9A8", VA = "0x296A9A8")]
	public static Vector3 GetDirection(Vector3 to, Vector3 from)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019AC9")]
	[Address(RVA = "0x296AA98", Offset = "0x296AA98", VA = "0x296AA98")]
	public static float GetDistance2D(Vector3 to, Vector3 from)
	{
		return default(float);
	}

	[Token(Token = "0x6019ACA")]
	[Address(RVA = "0x296AB6C", Offset = "0x296AB6C", VA = "0x296AB6C")]
	public static float GetDistance(Vector3 to, Vector3 from)
	{
		return default(float);
	}

	[Token(Token = "0x6019ACB")]
	[Address(RVA = "0x296AC4C", Offset = "0x296AC4C", VA = "0x296AC4C")]
	public static float AngleBetween2DWithSign(Vector3 from, Vector3 to)
	{
		return default(float);
	}

	[Token(Token = "0x6019ACC")]
	[Address(RVA = "0x296ADE0", Offset = "0x296ADE0", VA = "0x296ADE0")]
	public static bool IsZero(float v, float e = 1E-05f)
	{
		return default(bool);
	}

	[Token(Token = "0x6019ACD")]
	[Address(RVA = "0x296AE80", Offset = "0x296AE80", VA = "0x296AE80")]
	public static bool IsZero(Vector3 v, float e = 1E-05f)
	{
		return default(bool);
	}

	[Token(Token = "0x6019ACE")]
	[Address(RVA = "0x296AFB0", Offset = "0x296AFB0", VA = "0x296AFB0")]
	public static bool IsEqual(float v1, float v2, float e = 1E-05f)
	{
		return default(bool);
	}

	[Token(Token = "0x6019ACF")]
	[Address(RVA = "0x296B05C", Offset = "0x296B05C", VA = "0x296B05C")]
	public static Vector3 GetReflectedVector(Vector3 v, Vector3 n)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019AD0")]
	[Address(RVA = "0x296B184", Offset = "0x296B184", VA = "0x296B184")]
	public static float GetFraction(float v)
	{
		return default(float);
	}

	[Token(Token = "0x6019AD1")]
	[Address(RVA = "0x296B19C", Offset = "0x296B19C", VA = "0x296B19C")]
	public static Vector3 RotateVectorAroundY(Vector3 v, float angle)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019AD2")]
	[Address(RVA = "0x296B2B4", Offset = "0x296B2B4", VA = "0x296B2B4")]
	public static Vector3 AngleToVector2D(float angle)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019AD3")]
	[Address(RVA = "0x296B374", Offset = "0x296B374", VA = "0x296B374")]
	public static float Vector2DToAngle(Vector3 v)
	{
		return default(float);
	}

	[Token(Token = "0x6019AD4")]
	[Address(RVA = "0x296B4CC", Offset = "0x296B4CC", VA = "0x296B4CC")]
	public static float NormalizeAngleZeroToTowPI(float angle)
	{
		return default(float);
	}

	[Token(Token = "0x6019AD5")]
	[Address(RVA = "0x296B524", Offset = "0x296B524", VA = "0x296B524")]
	public static float NormalizeAngleNegPIToPI(float angle)
	{
		return default(float);
	}

	[Token(Token = "0x6019AD6")]
	[Address(RVA = "0x296B588", Offset = "0x296B588", VA = "0x296B588")]
	public static Vector3 TransformDirection(Vector3 f, Vector3 d)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019AD7")]
	[Address(RVA = "0x296B810", Offset = "0x296B810", VA = "0x296B810")]
	public static Vector3 TransformPoint(Vector3 f, Vector3 basep, Vector3 p)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019AD8")]
	[Address(RVA = "0x296BAA4", Offset = "0x296BAA4", VA = "0x296BAA4")]
	public static float GetSign(float v)
	{
		return default(float);
	}

	[Token(Token = "0x6019AD9")]
	[Address(RVA = "0x296BAC4", Offset = "0x296BAC4", VA = "0x296BAC4")]
	public static bool CheckVector3Equals(Vector3 vec1, Vector3 vec2)
	{
		return default(bool);
	}

	[Token(Token = "0x6019ADA")]
	[Address(RVA = "0x296BC20", Offset = "0x296BC20", VA = "0x296BC20")]
	public static bool CheckVector3Equals(Vector3 vec1, Vector3 vec2, float e)
	{
		return default(bool);
	}

	[Token(Token = "0x6019ADB")]
	[Address(RVA = "0x296BD78", Offset = "0x296BD78", VA = "0x296BD78")]
	public static bool CheckQuaternionEquals(Quaternion q1, Quaternion q2, float e = 1E-05f)
	{
		return default(bool);
	}

	[Token(Token = "0x6019ADC")]
	[Address(RVA = "0x296BF40", Offset = "0x296BF40", VA = "0x296BF40")]
	public static Vector3 Get2BezeirPoint(Vector3 P0, Vector3 P1, Vector3 P2, float t)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019ADD")]
	[Address(RVA = "0x296C0A8", Offset = "0x296C0A8", VA = "0x296C0A8")]
	public static Quaternion LookRotation(Vector3 forward)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}

	[Token(Token = "0x6019ADE")]
	[Address(RVA = "0x296C278", Offset = "0x296C278", VA = "0x296C278")]
	public static Quaternion LookRotation(Vector3 forward, Vector3 up)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}
}
