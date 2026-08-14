using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200361C")]
public class UIHudCrosshairsView : UIBaseView
{
	[Token(Token = "0x4015A83")]
	[FieldOffset(Offset = "0x14")]
	public UISprite AimSprite;

	[Token(Token = "0x4015A84")]
	[FieldOffset(Offset = "0x18")]
	public UISprite NoSightingChargeProgressSprite;

	[Token(Token = "0x4015A85")]
	[FieldOffset(Offset = "0x1C")]
	public TweenAlpha NoSightingChargeProgressTween;

	[Token(Token = "0x4015A86")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ChargingVfx;

	[Token(Token = "0x4015A87")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ChargeMaxVfx;

	[Token(Token = "0x4015A88")]
	[FieldOffset(Offset = "0x28")]
	public UISprite MedicalAimSprite;

	[Token(Token = "0x4015A89")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite AimClosePosSprite;

	[Token(Token = "0x4015A8A")]
	[FieldOffset(Offset = "0x30")]
	public GameObject HitEnhanced;

	[Token(Token = "0x4015A8B")]
	[FieldOffset(Offset = "0x34")]
	public GameObject IngameHudEnhancedHit;

	[Token(Token = "0x4015A8C")]
	[FieldOffset(Offset = "0x38")]
	public GameObject IngameHudEnhancedKill;

	[Token(Token = "0x4015A8D")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Hit;

	[Token(Token = "0x4015A8E")]
	[FieldOffset(Offset = "0x40")]
	public GameObject SpriteGunSight;

	[Token(Token = "0x4015A8F")]
	[FieldOffset(Offset = "0x44")]
	public UILabel ChargeRateTxt;

	[Token(Token = "0x4015A90")]
	[FieldOffset(Offset = "0x48")]
	public UISprite ChargeRate1;

	[Token(Token = "0x4015A91")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite ChargeRate2;

	[Token(Token = "0x4015A92")]
	[FieldOffset(Offset = "0x50")]
	public UISprite ChargeRate3;

	[Token(Token = "0x4015A93")]
	[FieldOffset(Offset = "0x54")]
	public GameObject ChargeVFX;

	[Token(Token = "0x4015A94")]
	[FieldOffset(Offset = "0x58")]
	public ParticleSystemRenderer ChargePS;

	[Token(Token = "0x4015A95")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject ChargeBurst;

	[Token(Token = "0x4015A96")]
	[FieldOffset(Offset = "0x60")]
	public ParticleSystem ChargeFire;

	[Token(Token = "0x4015A97")]
	[FieldOffset(Offset = "0x64")]
	public UISprite SpriteGunSightCenter;

	[Token(Token = "0x4015A98")]
	[FieldOffset(Offset = "0x68")]
	public UISprite SightCenterLight;

	[Token(Token = "0x4015A99")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite SpriteHealingGunSightCenter;

	[Token(Token = "0x4015A9A")]
	[FieldOffset(Offset = "0x70")]
	public UISprite HealingGunSightCenterLight;

	[Token(Token = "0x4015A9B")]
	[FieldOffset(Offset = "0x74")]
	public UITexture ThermalView;

	[Token(Token = "0x4015A9C")]
	[FieldOffset(Offset = "0x78")]
	public UITexture PenetrableView;

	[Token(Token = "0x4015A9D")]
	[FieldOffset(Offset = "0x7C")]
	public UISprite Sight;

	[Token(Token = "0x4015A9E")]
	[FieldOffset(Offset = "0x80")]
	public GameObject GunShield;

	[Token(Token = "0x4015A9F")]
	[FieldOffset(Offset = "0x84")]
	public UISprite GunShieldLeft;

	[Token(Token = "0x4015AA0")]
	[FieldOffset(Offset = "0x88")]
	public UISprite GunShieldRight;

	[Token(Token = "0x4015AA1")]
	[FieldOffset(Offset = "0x8C")]
	public ParticleSystem SightFireEffect01;

	[Token(Token = "0x4015AA2")]
	[FieldOffset(Offset = "0x90")]
	public ParticleSystem SightFireEffect02;

	[Token(Token = "0x4015AA3")]
	[FieldOffset(Offset = "0x94")]
	public TweenAlpha AimBanSprite;

	[Token(Token = "0x4015AA4")]
	[FieldOffset(Offset = "0x98")]
	public GameObject FlashHit;

	[Token(Token = "0x4015AA5")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject GrenadeHitProtection;

	[Token(Token = "0x6016603")]
	[Address(RVA = "0x1376088", Offset = "0x1376088", VA = "0x1376088")]
	public UIHudCrosshairsView()
	{
	}

	[Token(Token = "0x6016604")]
	[Address(RVA = "0x1376090", Offset = "0x1376090", VA = "0x1376090", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016605")]
	[Address(RVA = "0x1376E68", Offset = "0x1376E68", VA = "0x1376E68")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
