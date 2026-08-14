using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034C3")]
public class UIDigitaluniverseB3DCameraView : UIBaseView
{
	[Token(Token = "0x4014A2F")]
	[FieldOffset(Offset = "0x14")]
	public Transform CoreAward;

	[Token(Token = "0x4014A30")]
	[FieldOffset(Offset = "0x18")]
	public Transform DoorContainer;

	[Token(Token = "0x4014A31")]
	[FieldOffset(Offset = "0x1C")]
	public Transform DoorGunContainer;

	[Token(Token = "0x4014A32")]
	[FieldOffset(Offset = "0x20")]
	public Transform DoorClothesContainer;

	[Token(Token = "0x4014A33")]
	[FieldOffset(Offset = "0x24")]
	public Transform DoorMapContainer;

	[Token(Token = "0x4014A34")]
	[FieldOffset(Offset = "0x28")]
	public Transform DoorModelContainer;

	[Token(Token = "0x4014A35")]
	[FieldOffset(Offset = "0x2C")]
	public Transform DoorActivityContainer;

	[Token(Token = "0x60161FD")]
	[Address(RVA = "0x2D88388", Offset = "0x2D88388", VA = "0x2D88388")]
	public UIDigitaluniverseB3DCameraView()
	{
	}

	[Token(Token = "0x60161FE")]
	[Address(RVA = "0x2D88390", Offset = "0x2D88390", VA = "0x2D88390", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161FF")]
	[Address(RVA = "0x2D88660", Offset = "0x2D88660", VA = "0x2D88660")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
