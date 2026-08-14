using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A76")]
public class UIWeaponSkinUpgraderGunPickItemView : UIBaseView
{
	[Token(Token = "0x4018D1D")]
	[FieldOffset(Offset = "0x14")]
	public UISprite spriteQualityBar;

	[Token(Token = "0x4018D1E")]
	[FieldOffset(Offset = "0x18")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x4018D1F")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite spriteQualityLight;

	[Token(Token = "0x4018D20")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Custom;

	[Token(Token = "0x4018D21")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SpriteWeapon;

	[Token(Token = "0x4018D22")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelTheme;

	[Token(Token = "0x4018D23")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite SpriteLogo;

	[Token(Token = "0x4018D24")]
	[FieldOffset(Offset = "0x30")]
	public GameObject WSUNewTag;

	[Token(Token = "0x4018D25")]
	[FieldOffset(Offset = "0x34")]
	public GameObject CanGet;

	[Token(Token = "0x4018D26")]
	[FieldOffset(Offset = "0x38")]
	public GameObject HaveHad;

	[Token(Token = "0x4018D27")]
	[FieldOffset(Offset = "0x3C")]
	public UIGrid GridLevelMark;

	[Token(Token = "0x4018D28")]
	[FieldOffset(Offset = "0x40")]
	public UILabel LabelLevel;

	[Token(Token = "0x4018D29")]
	[FieldOffset(Offset = "0x44")]
	public UIButton BtnGunPick;

	[Token(Token = "0x4018D2A")]
	[FieldOffset(Offset = "0x48")]
	public GameObject CantGet;

	[Token(Token = "0x4018D2B")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject CanPurchase;

	[Token(Token = "0x4018D2C")]
	[FieldOffset(Offset = "0x50")]
	public UIButton BtnGoToPurchase;

	[Token(Token = "0x4018D2D")]
	[FieldOffset(Offset = "0x54")]
	public GameObject SpriteQualityOrangePlus;

	[Token(Token = "0x6017308")]
	[Address(RVA = "0x1B72E90", Offset = "0x1B72E90", VA = "0x1B72E90")]
	public UIWeaponSkinUpgraderGunPickItemView()
	{
	}

	[Token(Token = "0x6017309")]
	[Address(RVA = "0x1B72E98", Offset = "0x1B72E98", VA = "0x1B72E98", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601730A")]
	[Address(RVA = "0x1B735EC", Offset = "0x1B735EC", VA = "0x1B735EC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
