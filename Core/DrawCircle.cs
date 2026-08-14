using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A68")]
public class DrawCircle : MonoBehaviour
{
	[Token(Token = "0x4005C25")]
	[FieldOffset(Offset = "0xC")]
	public Transform m_Transform;

	[Token(Token = "0x4005C26")]
	[FieldOffset(Offset = "0x10")]
	public float m_Radius;

	[Token(Token = "0x4005C27")]
	[FieldOffset(Offset = "0x14")]
	public int m_Index;

	[Token(Token = "0x4005C28")]
	[FieldOffset(Offset = "0x18")]
	public bool m_MiniZone;

	[Token(Token = "0x4005C29")]
	[FieldOffset(Offset = "0x1C")]
	public float m_InnerRadius;

	[Token(Token = "0x4005C2A")]
	[FieldOffset(Offset = "0x20")]
	public float m_Theta;

	[Token(Token = "0x4005C2B")]
	[FieldOffset(Offset = "0x24")]
	public Color m_Color;

	[Token(Token = "0x4005C2C")]
	[FieldOffset(Offset = "0x34")]
	public Color m_InnerColor;

	[Token(Token = "0x600508B")]
	[Address(RVA = "0x2324480", Offset = "0x2324480", VA = "0x2324480")]
	public DrawCircle()
	{
	}
}
