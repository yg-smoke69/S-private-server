using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003682")]
public class UIHudInventoryWeaponSlotItemView : UIBaseView
{
	[Token(Token = "0x4015EA3")]
	[FieldOffset(Offset = "0x14")]
	public UIInventoryItemDragDropContainer DragDropContainer;

	[Token(Token = "0x4015EA4")]
	[FieldOffset(Offset = "0x18")]
	public UIInventoryItemDrapDrop DragDropItem;

	[Token(Token = "0x4015EA5")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggle ItemToggle;

	[Token(Token = "0x4015EA6")]
	[FieldOffset(Offset = "0x20")]
	public GameObject DragGO;

	[Token(Token = "0x4015EA7")]
	[FieldOffset(Offset = "0x24")]
	public UISprite ItemDragIcon;

	[Token(Token = "0x4015EA8")]
	[FieldOffset(Offset = "0x28")]
	public GameObject DeleteMask;

	[Token(Token = "0x4015EA9")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject NonDragGO;

	[Token(Token = "0x4015EAA")]
	[FieldOffset(Offset = "0x30")]
	public UISprite WeaponIcon;

	[Token(Token = "0x4015EAB")]
	[FieldOffset(Offset = "0x34")]
	public GameObject MuzzleSlotEmptyBG;

	[Token(Token = "0x4015EAC")]
	[FieldOffset(Offset = "0x38")]
	public Transform MuzzleSlot;

	[Token(Token = "0x4015EAD")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ForegripSlotEmptyBG;

	[Token(Token = "0x4015EAE")]
	[FieldOffset(Offset = "0x40")]
	public Transform ForegripSlot;

	[Token(Token = "0x4015EAF")]
	[FieldOffset(Offset = "0x44")]
	public GameObject MagazineSlotEmptyBG;

	[Token(Token = "0x4015EB0")]
	[FieldOffset(Offset = "0x48")]
	public Transform MagazineSlot;

	[Token(Token = "0x4015EB1")]
	[FieldOffset(Offset = "0x4C")]
	public Transform SightSlot;

	[Token(Token = "0x4015EB2")]
	[FieldOffset(Offset = "0x50")]
	public GameObject SightSlotEmptyBG;

	[Token(Token = "0x4015EB3")]
	[FieldOffset(Offset = "0x54")]
	public GameObject HighlightGO;

	[Token(Token = "0x4015EB4")]
	[FieldOffset(Offset = "0x58")]
	public Transform GunstockSlot;

	[Token(Token = "0x4015EB5")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject GunstockSlotEmptyBG;

	[Token(Token = "0x4015EB6")]
	[FieldOffset(Offset = "0x60")]
	public GameObject GoldSlotEmptyBG;

	[Token(Token = "0x4015EB7")]
	[FieldOffset(Offset = "0x64")]
	public Transform GoldSlot;

	[Token(Token = "0x4015EB8")]
	[FieldOffset(Offset = "0x68")]
	public GameObject CombineSprite;

	[Token(Token = "0x4015EB9")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject GoGradeLv1;

	[Token(Token = "0x4015EBA")]
	[FieldOffset(Offset = "0x70")]
	public GameObject GoGradeLv2;

	[Token(Token = "0x4015EBB")]
	[FieldOffset(Offset = "0x74")]
	public GameObject GoGradeLv3;

	[Token(Token = "0x4015EBC")]
	[FieldOffset(Offset = "0x78")]
	public UILabel AmmoCount;

	[Token(Token = "0x4015EBD")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel AmmoName;

	[Token(Token = "0x4015EBE")]
	[FieldOffset(Offset = "0x80")]
	public UILabel WeaponName;

	[Token(Token = "0x4015EBF")]
	[FieldOffset(Offset = "0x84")]
	public GameObject GoldWeaponUpgradeEffect;

	[Token(Token = "0x4015EC0")]
	[FieldOffset(Offset = "0x88")]
	public UIButton UpgradeButton;

	[Token(Token = "0x4015EC1")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject RealUpgradeVFX;

	[Token(Token = "0x4015EC2")]
	[FieldOffset(Offset = "0x90")]
	public GameObject GlodSlotCannotUpgradeBg;

	[Token(Token = "0x6016733")]
	[Address(RVA = "0x20A628C", Offset = "0x20A628C", VA = "0x20A628C")]
	public UIHudInventoryWeaponSlotItemView()
	{
	}

	[Token(Token = "0x6016734")]
	[Address(RVA = "0x20A6294", Offset = "0x20A6294", VA = "0x20A6294", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016735")]
	[Address(RVA = "0x20A6E20", Offset = "0x20A6E20", VA = "0x20A6E20")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
