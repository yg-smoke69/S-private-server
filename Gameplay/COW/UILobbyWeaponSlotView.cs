using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003855")]
public class UILobbyWeaponSlotView : UIBaseView
{
	[Token(Token = "0x401715A")]
	[FieldOffset(Offset = "0x14")]
	public UIButton SlotButton;

	[Token(Token = "0x401715B")]
	[FieldOffset(Offset = "0x18")]
	public WeaponRackDragDropItem DragDropItem;

	[Token(Token = "0x401715C")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton DeleteButton;

	[Token(Token = "0x401715D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject GunRoot;

	[Token(Token = "0x401715E")]
	[FieldOffset(Offset = "0x24")]
	public UISprite GunIcon;

	[Token(Token = "0x401715F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject GrenadeRoot;

	[Token(Token = "0x4017160")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite GrenadeIcon;

	[Token(Token = "0x4017161")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Mask;

	[Token(Token = "0x6016CAA")]
	[Address(RVA = "0x21E6DD4", Offset = "0x21E6DD4", VA = "0x21E6DD4")]
	public UILobbyWeaponSlotView()
	{
	}

	[Token(Token = "0x6016CAB")]
	[Address(RVA = "0x21E6DDC", Offset = "0x21E6DDC", VA = "0x21E6DDC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CAC")]
	[Address(RVA = "0x21E7200", Offset = "0x21E7200", VA = "0x21E7200")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
