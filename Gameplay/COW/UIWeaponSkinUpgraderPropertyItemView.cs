using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A79")]
public class UIWeaponSkinUpgraderPropertyItemView : UIBaseView
{
	[Token(Token = "0x4018D37")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnWeaponSkinProperty;

	[Token(Token = "0x4018D38")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ObjCanMove;

	[Token(Token = "0x4018D39")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ObjChosen;

	[Token(Token = "0x4018D3A")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelDesc;

	[Token(Token = "0x4018D3B")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ObjUnChosen;

	[Token(Token = "0x4018D3C")]
	[FieldOffset(Offset = "0x28")]
	public UISprite SpriteIcon;

	[Token(Token = "0x4018D3D")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnPropertyOnlySprite;

	[Token(Token = "0x4018D3E")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ObjOnlyChosen;

	[Token(Token = "0x4018D3F")]
	[FieldOffset(Offset = "0x34")]
	public GameObject ObjOnlyUnChosen;

	[Token(Token = "0x4018D40")]
	[FieldOffset(Offset = "0x38")]
	public UISprite SpriteIcon2;

	[Token(Token = "0x4018D41")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ObjTinyProperty;

	[Token(Token = "0x4018D42")]
	[FieldOffset(Offset = "0x40")]
	public UISprite SpriteTinyProperty;

	[Token(Token = "0x6017311")]
	[Address(RVA = "0x1B7653C", Offset = "0x1B7653C", VA = "0x1B7653C")]
	public UIWeaponSkinUpgraderPropertyItemView()
	{
	}

	[Token(Token = "0x6017312")]
	[Address(RVA = "0x1B76544", Offset = "0x1B76544", VA = "0x1B76544", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017313")]
	[Address(RVA = "0x1B76AC4", Offset = "0x1B76AC4", VA = "0x1B76AC4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
