using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003F09")]
public class Circle2D : _Attribute
{
	[Token(Token = "0x401A9AE")]
	[FieldOffset(Offset = "0x8")]
	private Vector3 m_Position;

	[Token(Token = "0x401A9AF")]
	[FieldOffset(Offset = "0x14")]
	private float m_Radius;

	[Token(Token = "0x6019AB4")]
	[Address(RVA = "0x3085D98", Offset = "0x3085D98", VA = "0x3085D98")]
	public Circle2D(Vector3 pos, float radius)
	{
	}

	[Token(Token = "0x6019AB5")]
	[Address(RVA = "0x3085DD0", Offset = "0x3085DD0", VA = "0x3085DD0", Slot = "4")]
	public Vector3 GetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019AB6")]
	[Address(RVA = "0x3085DE4", Offset = "0x3085DE4", VA = "0x3085DE4", Slot = "6")]
	public Vector3 GetSize()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019AB7")]
	[Address(RVA = "0x3085E24", Offset = "0x3085E24", VA = "0x3085E24", Slot = "5")]
	public Vector3 GetCenter()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019AB8")]
	[Address(RVA = "0x3085E38", Offset = "0x3085E38", VA = "0x3085E38")]
	public void SetPosition(Vector3 pos)
	{
	}

	[Token(Token = "0x6019AB9")]
	[Address(RVA = "0x3085E44", Offset = "0x3085E44", VA = "0x3085E44")]
	public float GetRadius()
	{
		return default(float);
	}

	[Token(Token = "0x6019ABA")]
	[Address(RVA = "0x3085E4C", Offset = "0x3085E4C", VA = "0x3085E4C")]
	public void SetRadius(float radius)
	{
	}

	[Token(Token = "0x6019ABB")]
	[Address(RVA = "0x3085E54", Offset = "0x3085E54", VA = "0x3085E54", Slot = "7")]
	public bool IsPointInside(Vector3 v, float margin = 0f)
	{
		return default(bool);
	}

	[Token(Token = "0x6019ABC")]
	[Address(RVA = "0x3085F38", Offset = "0x3085F38", VA = "0x3085F38", Slot = "8")]
	public Vector3 GetRandomPoint(float margin = 0f)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019ABD")]
	[Address(RVA = "0x3086084", Offset = "0x3086084", VA = "0x3086084", Slot = "9")]
	public Vector3 ClampPoint(Vector3 v, float margin = 0f)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}
}
