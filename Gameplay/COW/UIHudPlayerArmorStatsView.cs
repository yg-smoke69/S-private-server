using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036E1")]
public class UIHudPlayerArmorStatsView : UIBaseView
{
	[Token(Token = "0x4016299")]
	[FieldOffset(Offset = "0x14")]
	public GameObject HelmetBG;

	[Token(Token = "0x401629A")]
	[FieldOffset(Offset = "0x18")]
	public UISprite FilledHelmet;

	[Token(Token = "0x401629B")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite FilledHelmetEnhanced;

	[Token(Token = "0x401629C")]
	[FieldOffset(Offset = "0x20")]
	public UISprite HelmetLevel;

	[Token(Token = "0x401629D")]
	[FieldOffset(Offset = "0x24")]
	public TweenAlpha HelmetDurabilityRecoverEffect;

	[Token(Token = "0x401629E")]
	[FieldOffset(Offset = "0x28")]
	public UILabel HelmetBuffCountLabel;

	[Token(Token = "0x401629F")]
	[FieldOffset(Offset = "0x2C")]
	public Animation HelmetVFX;

	[Token(Token = "0x40162A0")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ArmorBG;

	[Token(Token = "0x40162A1")]
	[FieldOffset(Offset = "0x34")]
	public UISprite FilledArmor;

	[Token(Token = "0x40162A2")]
	[FieldOffset(Offset = "0x38")]
	public UISprite FilledArmorEnhanced;

	[Token(Token = "0x40162A3")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite ArmorLevel;

	[Token(Token = "0x40162A4")]
	[FieldOffset(Offset = "0x40")]
	public TweenAlpha ArmorDurabilityRecoverEffect;

	[Token(Token = "0x40162A5")]
	[FieldOffset(Offset = "0x44")]
	public UILabel VestBuffCountLabel;

	[Token(Token = "0x40162A6")]
	[FieldOffset(Offset = "0x48")]
	public Animation VestVFX;

	[Token(Token = "0x40162A7")]
	[FieldOffset(Offset = "0x4C")]
	public UIWidget UseWidget;

	[Token(Token = "0x40162A8")]
	[FieldOffset(Offset = "0x50")]
	public UIButton BtnQuickUse;

	[Token(Token = "0x40162A9")]
	[FieldOffset(Offset = "0x54")]
	public ParticleSystem FlashEffect;

	[Token(Token = "0x601684E")]
	[Address(RVA = "0x186602C", Offset = "0x186602C", VA = "0x186602C")]
	public UIHudPlayerArmorStatsView()
	{
	}

	[Token(Token = "0x601684F")]
	[Address(RVA = "0x1866034", Offset = "0x1866034", VA = "0x1866034", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016850")]
	[Address(RVA = "0x18667C4", Offset = "0x18667C4", VA = "0x18667C4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
