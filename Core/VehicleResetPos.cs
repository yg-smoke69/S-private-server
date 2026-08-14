using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AA0")]
public class VehicleResetPos : MonoBehaviour
{
	[Token(Token = "0x4005CFF")]
	[FieldOffset(Offset = "0xC")]
	public Transform m_Transform;

	[Token(Token = "0x4005D00")]
	[FieldOffset(Offset = "0x10")]
	public float m_Radius;

	[Token(Token = "0x4005D01")]
	[FieldOffset(Offset = "0x14")]
	public int Index;

	[Token(Token = "0x4005D02")]
	[FieldOffset(Offset = "0x18")]
	public float m_Theta;

	[Token(Token = "0x4005D03")]
	[FieldOffset(Offset = "0x1C")]
	public Color m_Color;

	[Token(Token = "0x6005167")]
	[Address(RVA = "0x2A69444", Offset = "0x2A69444", VA = "0x2A69444")]
	public VehicleResetPos()
	{
	}
}
