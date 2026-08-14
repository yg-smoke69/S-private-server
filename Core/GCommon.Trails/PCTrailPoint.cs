using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.Trails;

[Token(Token = "0x2003EBA")]
public class PCTrailPoint
{
	[Token(Token = "0x401A7C4")]
	[FieldOffset(Offset = "0x8")]
	public Vector3 Forward;

	[Token(Token = "0x401A7C5")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 Position;

	[Token(Token = "0x401A7C6")]
	[FieldOffset(Offset = "0x20")]
	public int PointNumber;

	[Token(Token = "0x401A7C7")]
	[FieldOffset(Offset = "0x24")]
	private float m_TimeActive;

	[Token(Token = "0x401A7C8")]
	[FieldOffset(Offset = "0x28")]
	private float m_Distance;

	[Token(Token = "0x601983D")]
	[Address(RVA = "0x323F4AC", Offset = "0x323F4AC", VA = "0x323F4AC")]
	public PCTrailPoint()
	{
	}

	[Token(Token = "0x601983E")]
	[Address(RVA = "0x323F4B4", Offset = "0x323F4B4", VA = "0x323F4B4", Slot = "4")]
	public virtual void Update(float deltaTime)
	{
	}

	[Token(Token = "0x601983F")]
	[Address(RVA = "0x323F4C8", Offset = "0x323F4C8", VA = "0x323F4C8")]
	public float TimeActive()
	{
		return default(float);
	}

	[Token(Token = "0x6019840")]
	[Address(RVA = "0x323F4D0", Offset = "0x323F4D0", VA = "0x323F4D0")]
	public void SetTimeActive(float time)
	{
	}

	[Token(Token = "0x6019841")]
	[Address(RVA = "0x323F4D8", Offset = "0x323F4D8", VA = "0x323F4D8")]
	public void SetDistanceFromStart(float distance)
	{
	}

	[Token(Token = "0x6019842")]
	[Address(RVA = "0x323F4E0", Offset = "0x323F4E0", VA = "0x323F4E0")]
	public float GetDistanceFromStart()
	{
		return default(float);
	}
}
