using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200368D")]
public class UIHudKillDetailView : UIBaseView
{
	[Token(Token = "0x4015EF8")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LablePlayerName;

	[Token(Token = "0x4015EF9")]
	[FieldOffset(Offset = "0x18")]
	public Transform ProfileContainer;

	[Token(Token = "0x4015EFA")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelClickTip;

	[Token(Token = "0x4015EFB")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SpriteItemIcon;

	[Token(Token = "0x4015EFC")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelItemName;

	[Token(Token = "0x4015EFD")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelDamage;

	[Token(Token = "0x4015EFE")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LabelPageTitle;

	[Token(Token = "0x4015EFF")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnChangePage;

	[Token(Token = "0x4015F00")]
	[FieldOffset(Offset = "0x34")]
	public GameObject SpriteHeadShot;

	[Token(Token = "0x4015F01")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LabelDamageTip;

	[Token(Token = "0x4015F02")]
	[FieldOffset(Offset = "0x3C")]
	public Transform DamageGroup;

	[Token(Token = "0x4015F03")]
	[FieldOffset(Offset = "0x40")]
	public GameObject SpriteNormalShot;

	[Token(Token = "0x4015F04")]
	[FieldOffset(Offset = "0x44")]
	public Transform NormalShotPos;

	[Token(Token = "0x4015F05")]
	[FieldOffset(Offset = "0x48")]
	public Transform HeadShotPos;

	[Token(Token = "0x4015F06")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton CloseBtn;

	[Token(Token = "0x4015F07")]
	[FieldOffset(Offset = "0x50")]
	public Transform DMGPos;

	[Token(Token = "0x4015F08")]
	[FieldOffset(Offset = "0x54")]
	public GameObject OtherSituations;

	[Token(Token = "0x4015F09")]
	[FieldOffset(Offset = "0x58")]
	public GameObject LowConfiguration;

	[Token(Token = "0x6016754")]
	[Address(RVA = "0x1BB2810", Offset = "0x1BB2810", VA = "0x1BB2810")]
	public UIHudKillDetailView()
	{
	}

	[Token(Token = "0x6016755")]
	[Address(RVA = "0x1BB2818", Offset = "0x1BB2818", VA = "0x1BB2818", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016756")]
	[Address(RVA = "0x1BB2F28", Offset = "0x1BB2F28", VA = "0x1BB2F28")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
