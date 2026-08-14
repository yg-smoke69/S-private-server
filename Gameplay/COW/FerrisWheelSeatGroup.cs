using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20005C1")]
public class FerrisWheelSeatGroup : Entity
{
	[Token(Token = "0x40043BB")]
	[FieldOffset(Offset = "0x34")]
	private bool m_EnableSeatRota;

	[Token(Token = "0x40043BC")]
	[FieldOffset(Offset = "0x38")]
	public Transform RotationCenter;

	[Token(Token = "0x40043BD")]
	[FieldOffset(Offset = "0x3C")]
	public FerrisWheelSeat[] Seat;

	[Token(Token = "0x40043BE")]
	[FieldOffset(Offset = "0x40")]
	public byte GroupID;

	[Token(Token = "0x40043BF")]
	[FieldOffset(Offset = "0x44")]
	public uint FerrisWheelID;

	[Token(Token = "0x40043C0")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 oriWorldRota;

	[Token(Token = "0x60022E3")]
	[Address(RVA = "0xDE5628", Offset = "0xDE5628", VA = "0xDE5628")]
	public FerrisWheelSeatGroup()
	{
	}

	[Token(Token = "0x60022E4")]
	[Address(RVA = "0xDE5700", Offset = "0xDE5700", VA = "0xDE5700", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60022E5")]
	[Address(RVA = "0xDE5854", Offset = "0xDE5854", VA = "0xDE5854")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60022E6")]
	[Address(RVA = "0xDE5900", Offset = "0xDE5900", VA = "0xDE5900")]
	public bool CanGetOn()
	{
		return default(bool);
	}

	[Token(Token = "0x60022E7")]
	[Address(RVA = "0xDE59D8", Offset = "0xDE59D8", VA = "0xDE59D8")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}
}
