using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003604")]
public class UIHudCannonInfoView : UIBaseView
{
	[Token(Token = "0x40159E6")]
	[FieldOffset(Offset = "0x14")]
	public GameObject GoldEffect;

	[Token(Token = "0x40159E7")]
	[FieldOffset(Offset = "0x18")]
	public UISprite WeaponIcon;

	[Token(Token = "0x40159E8")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite HeatWeaponIcon;

	[Token(Token = "0x40159E9")]
	[FieldOffset(Offset = "0x20")]
	public GameObject AmmoInfoGO;

	[Token(Token = "0x40159EA")]
	[FieldOffset(Offset = "0x24")]
	public UILabel CurrentAmmoCount;

	[Token(Token = "0x40159EB")]
	[FieldOffset(Offset = "0x28")]
	public UILabel MaxAmmoCount;

	[Token(Token = "0x40159EC")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject VFX_CombineSprite;

	[Token(Token = "0x60165BA")]
	[Address(RVA = "0x2147208", Offset = "0x2147208", VA = "0x2147208")]
	public UIHudCannonInfoView()
	{
	}

	[Token(Token = "0x60165BB")]
	[Address(RVA = "0x2147210", Offset = "0x2147210", VA = "0x2147210", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165BC")]
	[Address(RVA = "0x21475D4", Offset = "0x21475D4", VA = "0x21475D4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
