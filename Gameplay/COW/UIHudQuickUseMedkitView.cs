using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036F5")]
public class UIHudQuickUseMedkitView : UIBaseView
{
	[Token(Token = "0x4016337")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnQuickUse;

	[Token(Token = "0x4016338")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget BtnWidget;

	[Token(Token = "0x4016339")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject UrgencyTipObj;

	[Token(Token = "0x401633A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject PrepTimer;

	[Token(Token = "0x401633B")]
	[FieldOffset(Offset = "0x24")]
	public UILabel TimeLabel;

	[Token(Token = "0x401633C")]
	[FieldOffset(Offset = "0x28")]
	public UISprite Progress;

	[Token(Token = "0x401633D")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel MedkitCount;

	[Token(Token = "0x401633E")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget Icon;

	[Token(Token = "0x401633F")]
	[FieldOffset(Offset = "0x34")]
	public UISprite MedkitIcon;

	[Token(Token = "0x4016340")]
	[FieldOffset(Offset = "0x38")]
	public ParticleSystem FlashEffect;

	[Token(Token = "0x4016341")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite SpriteBg;

	[Token(Token = "0x4016342")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Effect_VFX;

	[Token(Token = "0x4016343")]
	[FieldOffset(Offset = "0x44")]
	public UIWidget MedkitDir;

	[Token(Token = "0x4016344")]
	[FieldOffset(Offset = "0x48")]
	public GameObject CircleCon;

	[Token(Token = "0x4016345")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject HaveCircle3;

	[Token(Token = "0x4016346")]
	[FieldOffset(Offset = "0x50")]
	public GameObject HaveCircle1;

	[Token(Token = "0x4016347")]
	[FieldOffset(Offset = "0x54")]
	public GameObject HaveCircle2;

	[Token(Token = "0x4016348")]
	[FieldOffset(Offset = "0x58")]
	public UIWidget MedkitDirCon;

	[Token(Token = "0x601688A")]
	[Address(RVA = "0x1FD1CC4", Offset = "0x1FD1CC4", VA = "0x1FD1CC4")]
	public UIHudQuickUseMedkitView()
	{
	}

	[Token(Token = "0x601688B")]
	[Address(RVA = "0x1FD1CCC", Offset = "0x1FD1CCC", VA = "0x1FD1CCC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601688C")]
	[Address(RVA = "0x1FD2480", Offset = "0x1FD2480", VA = "0x1FD2480")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
