using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003BC6")]
public class MotorcycleWheelController : MonoBehaviour, _Attribute
{
	[Token(Token = "0x40197BE")]
	[FieldOffset(Offset = "0xC")]
	public RMCRealisticMotorcycleController m_Controller;

	[Token(Token = "0x40197BF")]
	[FieldOffset(Offset = "0x10")]
	public WheelCollider m_WheelCollider;

	[Token(Token = "0x40197C0")]
	[FieldOffset(Offset = "0x14")]
	public Transform m_WheelTransform;

	[Token(Token = "0x40197C1")]
	[FieldOffset(Offset = "0x18")]
	private float rot;

	[Token(Token = "0x6017DA1")]
	[Address(RVA = "0x1C70724", Offset = "0x1C70724", VA = "0x1C70724")]
	public MotorcycleWheelController()
	{
	}

	[Token(Token = "0x6017DA2")]
	[Address(RVA = "0x1C7072C", Offset = "0x1C7072C", VA = "0x1C7072C", Slot = "4")]
	public void AttachWheelModel(Transform model)
	{
	}

	[Token(Token = "0x6017DA3")]
	[Address(RVA = "0x1C708E4", Offset = "0x1C708E4", VA = "0x1C708E4")]
	public void EnableWheelCollider(bool e)
	{
	}

	[Token(Token = "0x6017DA4")]
	[Address(RVA = "0x1C709A0", Offset = "0x1C709A0", VA = "0x1C709A0")]
	private void Update()
	{
	}
}
