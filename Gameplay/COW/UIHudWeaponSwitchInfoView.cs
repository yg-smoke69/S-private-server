using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037CB")]
public class UIHudWeaponSwitchInfoView : UIBaseView
{
	[Token(Token = "0x40169C8")]
	[FieldOffset(Offset = "0x14")]
	public UIButton WeaponSwitchButton;

	[Token(Token = "0x40169C9")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget WeaponSwitchWidget;

	[Token(Token = "0x40169CA")]
	[FieldOffset(Offset = "0x1C")]
	public Transform EffectRoot;

	[Token(Token = "0x40169CB")]
	[FieldOffset(Offset = "0x20")]
	public UISprite PrimaryIcon;

	[Token(Token = "0x40169CC")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SecondaryIcon;

	[Token(Token = "0x40169CD")]
	[FieldOffset(Offset = "0x28")]
	public UISprite NoWeapon01;

	[Token(Token = "0x40169CE")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite NoWeapon02;

	[Token(Token = "0x40169CF")]
	[FieldOffset(Offset = "0x30")]
	public UISprite MeleeIcon;

	[Token(Token = "0x40169D0")]
	[FieldOffset(Offset = "0x34")]
	public GameObject PVEAmmoInfo;

	[Token(Token = "0x40169D1")]
	[FieldOffset(Offset = "0x38")]
	public UILabel PVECurAmmo;

	[Token(Token = "0x40169D2")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite PVEInfiniteSprite;

	[Token(Token = "0x40169D3")]
	[FieldOffset(Offset = "0x40")]
	public UILabel PVEMaxAmmo;

	[Token(Token = "0x40169D4")]
	[FieldOffset(Offset = "0x44")]
	public GameObject PVESep;

	[Token(Token = "0x40169D5")]
	[FieldOffset(Offset = "0x48")]
	public UIProgressBar PVEAmmoStatusBar;

	[Token(Token = "0x40169D6")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject AmmoInfoGO;

	[Token(Token = "0x40169D7")]
	[FieldOffset(Offset = "0x50")]
	public UILabel MaxAmmoCount;

	[Token(Token = "0x40169D8")]
	[FieldOffset(Offset = "0x54")]
	public UISprite InfiniteSprite;

	[Token(Token = "0x40169D9")]
	[FieldOffset(Offset = "0x58")]
	public UIProgressBar AmmoStatusBar;

	[Token(Token = "0x40169DA")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite SpriteBg;

	[Token(Token = "0x40169DB")]
	[FieldOffset(Offset = "0x60")]
	public UISprite GoldenBg;

	[Token(Token = "0x40169DC")]
	[FieldOffset(Offset = "0x64")]
	public GameObject GoGradeLv1;

	[Token(Token = "0x40169DD")]
	[FieldOffset(Offset = "0x68")]
	public GameObject GoGradeLv2;

	[Token(Token = "0x40169DE")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject GoGradeLv3;

	[Token(Token = "0x40169DF")]
	[FieldOffset(Offset = "0x70")]
	public UIHudWeaponShield Shield;

	[Token(Token = "0x40169E0")]
	[FieldOffset(Offset = "0x74")]
	public GameObject CombineSprite;

	[Token(Token = "0x40169E1")]
	[FieldOffset(Offset = "0x78")]
	public GameObject CombineSpriteDissolve;

	[Token(Token = "0x40169E2")]
	[FieldOffset(Offset = "0x7C")]
	public Animation AnimationReplacerVFX;

	[Token(Token = "0x40169E3")]
	[FieldOffset(Offset = "0x80")]
	public GameObject VFX_CombineSprite;

	[Token(Token = "0x40169E4")]
	[FieldOffset(Offset = "0x84")]
	public GameObject SpriteGoldPlus;

	[Token(Token = "0x40169E5")]
	[FieldOffset(Offset = "0x88")]
	public GameObject SpriteRedPlus;

	[Token(Token = "0x40169E6")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject QualityMark1;

	[Token(Token = "0x40169E7")]
	[FieldOffset(Offset = "0x90")]
	public GameObject QualityMark2;

	[Token(Token = "0x40169E8")]
	[FieldOffset(Offset = "0x94")]
	public GameObject QualityMark3;

	[Token(Token = "0x6016B0C")]
	[Address(RVA = "0x25641D8", Offset = "0x25641D8", VA = "0x25641D8")]
	public UIHudWeaponSwitchInfoView()
	{
	}

	[Token(Token = "0x6016B0D")]
	[Address(RVA = "0x25641E0", Offset = "0x25641E0", VA = "0x25641E0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B0E")]
	[Address(RVA = "0x2564EB8", Offset = "0x2564EB8", VA = "0x2564EB8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
