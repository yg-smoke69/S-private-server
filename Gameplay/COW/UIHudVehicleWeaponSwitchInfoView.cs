using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037C9")]
public class UIHudVehicleWeaponSwitchInfoView : UIBaseView
{
	[Token(Token = "0x4016991")]
	[FieldOffset(Offset = "0x14")]
	public UIButton WeaponSwitchButton;

	[Token(Token = "0x4016992")]
	[FieldOffset(Offset = "0x18")]
	public TweenAlpha EquipHint;

	[Token(Token = "0x4016993")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite PrimaryIcon;

	[Token(Token = "0x4016994")]
	[FieldOffset(Offset = "0x20")]
	public GameObject AmmoInfoGO;

	[Token(Token = "0x4016995")]
	[FieldOffset(Offset = "0x24")]
	public UILabel MaxAmmoCount;

	[Token(Token = "0x4016996")]
	[FieldOffset(Offset = "0x28")]
	public UISprite InfiniteSprite;

	[Token(Token = "0x4016997")]
	[FieldOffset(Offset = "0x2C")]
	public UIProgressBar AmmoStatusBar;

	[Token(Token = "0x4016998")]
	[FieldOffset(Offset = "0x30")]
	public GameObject AutoShooting;

	[Token(Token = "0x6016B06")]
	[Address(RVA = "0x1A74ED4", Offset = "0x1A74ED4", VA = "0x1A74ED4")]
	public UIHudVehicleWeaponSwitchInfoView()
	{
	}

	[Token(Token = "0x6016B07")]
	[Address(RVA = "0x1A74EDC", Offset = "0x1A74EDC", VA = "0x1A74EDC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B08")]
	[Address(RVA = "0x1A7530C", Offset = "0x1A7530C", VA = "0x1A7530C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
