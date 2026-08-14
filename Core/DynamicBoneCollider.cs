using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003B2F")]
public class DynamicBoneCollider : MonoBehaviour
{
	[Token(Token = "0x2003B30")]
	public enum Direction
	{
		[Token(Token = "0x4019310")]
		X,
		[Token(Token = "0x4019311")]
		Y,
		[Token(Token = "0x4019312")]
		Z
	}

	[Token(Token = "0x2003B31")]
	public enum Bound
	{
		[Token(Token = "0x4019314")]
		Outside,
		[Token(Token = "0x4019315")]
		Inside
	}

	[Token(Token = "0x401930A")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 m_Center;

	[Token(Token = "0x401930B")]
	[FieldOffset(Offset = "0x18")]
	public float m_Radius;

	[Token(Token = "0x401930C")]
	[FieldOffset(Offset = "0x1C")]
	public float m_Height;

	[Token(Token = "0x401930D")]
	[FieldOffset(Offset = "0x20")]
	public Direction m_Direction;

	[Token(Token = "0x401930E")]
	[FieldOffset(Offset = "0x24")]
	public Bound m_Bound;

	[Token(Token = "0x60177F5")]
	[Address(RVA = "0x31F8208", Offset = "0x31F8208", VA = "0x31F8208")]
	public DynamicBoneCollider()
	{
	}

	[Token(Token = "0x60177F6")]
	[Address(RVA = "0x31F82B0", Offset = "0x31F82B0", VA = "0x31F82B0")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60177F7")]
	[Address(RVA = "0x31F8360", Offset = "0x31F8360", VA = "0x31F8360")]
	public void Collide(ref Vector3 particlePosition, float particleRadius)
	{
	}

	[Token(Token = "0x60177F8")]
	[Address(RVA = "0x31F95A0", Offset = "0x31F95A0", VA = "0x31F95A0")]
	public void PostCollide(ref Vector3 particlePosition, ref Vector3 parentParticlePosition, float particleRadius)
	{
	}

	[Token(Token = "0x60177F9")]
	[Address(RVA = "0x31F86FC", Offset = "0x31F86FC", VA = "0x31F86FC")]
	private static void OutsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
	}

	[Token(Token = "0x60177FA")]
	[Address(RVA = "0x31F9A7C", Offset = "0x31F9A7C", VA = "0x31F9A7C")]
	private static Vector3 OutsideSphereDelta(Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60177FB")]
	[Address(RVA = "0x31F9C90", Offset = "0x31F9C90", VA = "0x31F9C90")]
	private static Vector3 OutsideCapsuleDelta(Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60177FC")]
	[Address(RVA = "0x31FA17C", Offset = "0x31FA17C", VA = "0x31FA17C")]
	private static Vector3 LinePointProjection(Vector3 P, Vector3 A, Vector3 B)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60177FD")]
	[Address(RVA = "0x31F88F0", Offset = "0x31F88F0", VA = "0x31F88F0")]
	private static void InsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
	}

	[Token(Token = "0x60177FE")]
	[Address(RVA = "0x31F8ADC", Offset = "0x31F8ADC", VA = "0x31F8ADC")]
	private static void OutsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
	}

	[Token(Token = "0x60177FF")]
	[Address(RVA = "0x31F9050", Offset = "0x31F9050", VA = "0x31F9050")]
	private static void InsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
	}
}
