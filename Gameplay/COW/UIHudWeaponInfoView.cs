using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037CA")]
public class UIHudWeaponInfoView : UIBaseView
{
	[Token(Token = "0x4016999")]
	[FieldOffset(Offset = "0x14")]
	public UIButton HeavyWidget;

	[Token(Token = "0x401699A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel HeavyAmmoCount;

	[Token(Token = "0x401699B")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite HeavyWeaponIcon;

	[Token(Token = "0x401699C")]
	[FieldOffset(Offset = "0x20")]
	public UIButton GrenadeWidget;

	[Token(Token = "0x401699D")]
	[FieldOffset(Offset = "0x24")]
	public GameObject GrenadeLabel;

	[Token(Token = "0x401699E")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget NormalWidget;

	[Token(Token = "0x401699F")]
	[FieldOffset(Offset = "0x2C")]
	public Transform EffectRoot;

	[Token(Token = "0x40169A0")]
	[FieldOffset(Offset = "0x30")]
	public GameObject LevelUp;

	[Token(Token = "0x40169A1")]
	[FieldOffset(Offset = "0x34")]
	public GameObject LevelDown;

	[Token(Token = "0x40169A2")]
	[FieldOffset(Offset = "0x38")]
	public UILabel WeaponName;

	[Token(Token = "0x40169A3")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject GoldEffect;

	[Token(Token = "0x40169A4")]
	[FieldOffset(Offset = "0x40")]
	public UISprite SpriteLevelEffect;

	[Token(Token = "0x40169A5")]
	[FieldOffset(Offset = "0x44")]
	public GameObject GoGradeLv1;

	[Token(Token = "0x40169A6")]
	[FieldOffset(Offset = "0x48")]
	public GameObject GoGradeLv2;

	[Token(Token = "0x40169A7")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject GoGradeLv3;

	[Token(Token = "0x40169A8")]
	[FieldOffset(Offset = "0x50")]
	public UISprite WeaponIcon;

	[Token(Token = "0x40169A9")]
	[FieldOffset(Offset = "0x54")]
	public UISprite HeatWeaponIcon;

	[Token(Token = "0x40169AA")]
	[FieldOffset(Offset = "0x58")]
	public GameObject AmmoInfoGO;

	[Token(Token = "0x40169AB")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel CurrentAmmoCount;

	[Token(Token = "0x40169AC")]
	[FieldOffset(Offset = "0x60")]
	public UILabel MaxAmmoCount;

	[Token(Token = "0x40169AD")]
	[FieldOffset(Offset = "0x64")]
	public UIProgressBar AmmoStatusBar;

	[Token(Token = "0x40169AE")]
	[FieldOffset(Offset = "0x68")]
	public Transform Reload;

	[Token(Token = "0x40169AF")]
	[FieldOffset(Offset = "0x6C")]
	public UIGrid SwitchWeaponGrid;

	[Token(Token = "0x40169B0")]
	[FieldOffset(Offset = "0x70")]
	public UISprite InfiniteSprite;

	[Token(Token = "0x40169B1")]
	[FieldOffset(Offset = "0x74")]
	public UISprite BuffIcon;

	[Token(Token = "0x40169B2")]
	[FieldOffset(Offset = "0x78")]
	public UIHudWeaponShield Shield;

	[Token(Token = "0x40169B3")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject CombineSprite;

	[Token(Token = "0x40169B4")]
	[FieldOffset(Offset = "0x80")]
	public GameObject CombineSpriteDissolve;

	[Token(Token = "0x40169B5")]
	[FieldOffset(Offset = "0x84")]
	public ParticleSystem Effect_Kord;

	[Token(Token = "0x40169B6")]
	[FieldOffset(Offset = "0x88")]
	public GameObject VFX_CombineSprite;

	[Token(Token = "0x40169B7")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject BuildingWidget;

	[Token(Token = "0x40169B8")]
	[FieldOffset(Offset = "0x90")]
	public UIButton BuildingBtn;

	[Token(Token = "0x40169B9")]
	[FieldOffset(Offset = "0x94")]
	public GameObject BuildingLabel;

	[Token(Token = "0x40169BA")]
	[FieldOffset(Offset = "0x98")]
	public UIGrid BuildingGrid;

	[Token(Token = "0x40169BB")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject VehicleWidget;

	[Token(Token = "0x40169BC")]
	[FieldOffset(Offset = "0xA0")]
	public UIGrid VehicleGrid;

	[Token(Token = "0x40169BD")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject HeatWeaponWidget;

	[Token(Token = "0x40169BE")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel HeatWeaponEnergy;

	[Token(Token = "0x40169BF")]
	[FieldOffset(Offset = "0xAC")]
	public UIWidget TutorialWidget;

	[Token(Token = "0x40169C0")]
	[FieldOffset(Offset = "0xB0")]
	public Animation AnimationReplacerVFX;

	[Token(Token = "0x40169C1")]
	[FieldOffset(Offset = "0xB4")]
	public UIButton GoldWeaponUpgradeBtn;

	[Token(Token = "0x40169C2")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject SpriteGoldPlus;

	[Token(Token = "0x40169C3")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject SpriteRedPlus;

	[Token(Token = "0x40169C4")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject QualityMark1;

	[Token(Token = "0x40169C5")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject QualityMark2;

	[Token(Token = "0x40169C6")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject QualityMark3;

	[Token(Token = "0x40169C7")]
	[FieldOffset(Offset = "0xCC")]
	public GameObject BuffEffect;

	[Token(Token = "0x6016B09")]
	[Address(RVA = "0x255DE78", Offset = "0x255DE78", VA = "0x255DE78")]
	public UIHudWeaponInfoView()
	{
	}

	[Token(Token = "0x6016B0A")]
	[Address(RVA = "0x255DE80", Offset = "0x255DE80", VA = "0x255DE80", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B0B")]
	[Address(RVA = "0x255F01C", Offset = "0x255F01C", VA = "0x255F01C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
