using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003F0C")]
public class Rectangle2D : _Attribute
{
	[Token(Token = "0x401A9C7")]
	[FieldOffset(Offset = "0x8")]
	private Vector3 m_Position;

	[Token(Token = "0x401A9C8")]
	[FieldOffset(Offset = "0x14")]
	private float m_HalfLength;

	[Token(Token = "0x401A9C9")]
	[FieldOffset(Offset = "0x18")]
	private float m_HalfWidth;

	[Token(Token = "0x6019AE0")]
	[Address(RVA = "0x3325E3C", Offset = "0x3325E3C", VA = "0x3325E3C")]
	public Rectangle2D(Vector3 pos, float length, float width)
	{
	}

	[Token(Token = "0x6019AE1")]
	[Address(RVA = "0x3325E88", Offset = "0x3325E88", VA = "0x3325E88")]
	public Rectangle2D(Vector3 leftBottom, Vector3 rightTop)
	{
	}

	[Token(Token = "0x6019AE2")]
	[Address(RVA = "0x3326010", Offset = "0x3326010", VA = "0x3326010", Slot = "4")]
	public Vector3 GetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019AE3")]
	[Address(RVA = "0x3326024", Offset = "0x3326024", VA = "0x3326024")]
	public void SetPosition(Vector3 v)
	{
	}

	[Token(Token = "0x6019AE4")]
	[Address(RVA = "0x3326030", Offset = "0x3326030", VA = "0x3326030")]
	public void UpdateSize(float length, float width)
	{
	}

	[Token(Token = "0x6019AE5")]
	[Address(RVA = "0x3326050", Offset = "0x3326050", VA = "0x3326050", Slot = "6")]
	public Vector3 GetSize()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019AE6")]
	[Address(RVA = "0x3326098", Offset = "0x3326098", VA = "0x3326098", Slot = "5")]
	public Vector3 GetCenter()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019AE7")]
	[Address(RVA = "0x33260AC", Offset = "0x33260AC", VA = "0x33260AC", Slot = "7")]
	public bool IsPointInside(Vector3 v, float margin = 0f)
	{
		return default(bool);
	}

	[Token(Token = "0x6019AE8")]
	[Address(RVA = "0x3326128", Offset = "0x3326128", VA = "0x3326128", Slot = "8")]
	public Vector3 GetRandomPoint(float margin = 0f)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019AE9")]
	[Address(RVA = "0x33261CC", Offset = "0x33261CC", VA = "0x33261CC", Slot = "9")]
	public Vector3 ClampPoint(Vector3 v, float margin = 0f)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}
}
