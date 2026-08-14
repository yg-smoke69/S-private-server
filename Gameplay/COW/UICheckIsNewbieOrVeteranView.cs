using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200343A")]
public class UICheckIsNewbieOrVeteranView : UIBaseView
{
	[Token(Token = "0x4014396")]
	[FieldOffset(Offset = "0x14")]
	public Animation AnimSwitch;

	[Token(Token = "0x4014397")]
	[FieldOffset(Offset = "0x18")]
	public GameObject WindowContainer;

	[Token(Token = "0x4014398")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnNewbie;

	[Token(Token = "0x4014399")]
	[FieldOffset(Offset = "0x20")]
	public UISprite BtnNewbieSpriteBg;

	[Token(Token = "0x401439A")]
	[FieldOffset(Offset = "0x24")]
	public GameObject BtnNewbieChoosenSprite;

	[Token(Token = "0x401439B")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnVeteran;

	[Token(Token = "0x401439C")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite BtnVeteranSpriteBg;

	[Token(Token = "0x401439D")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BtnVeteranChoosenSprite;

	[Token(Token = "0x401439E")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnMaster;

	[Token(Token = "0x401439F")]
	[FieldOffset(Offset = "0x38")]
	public UISprite BtnMasterSpriteBg;

	[Token(Token = "0x40143A0")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject BtnMasterChoosenSprite;

	[Token(Token = "0x40143A1")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BtnConfirm;

	[Token(Token = "0x40143A2")]
	[FieldOffset(Offset = "0x44")]
	public GameObject GoActiveBtnConfirm;

	[Token(Token = "0x40143A3")]
	[FieldOffset(Offset = "0x48")]
	public UISprite IconNewbie;

	[Token(Token = "0x40143A4")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite StripeNewbie;

	[Token(Token = "0x40143A5")]
	[FieldOffset(Offset = "0x50")]
	public UILabel LabelNewbie;

	[Token(Token = "0x40143A6")]
	[FieldOffset(Offset = "0x54")]
	public UISprite IconVeteran;

	[Token(Token = "0x40143A7")]
	[FieldOffset(Offset = "0x58")]
	public UISprite StripeVeteran;

	[Token(Token = "0x40143A8")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel LabelVeteran;

	[Token(Token = "0x40143A9")]
	[FieldOffset(Offset = "0x60")]
	public UISprite IconMaster;

	[Token(Token = "0x40143AA")]
	[FieldOffset(Offset = "0x64")]
	public UISprite StripeMaster;

	[Token(Token = "0x40143AB")]
	[FieldOffset(Offset = "0x68")]
	public UILabel LabelMaster;

	[Token(Token = "0x6016062")]
	[Address(RVA = "0x208A254", Offset = "0x208A254", VA = "0x208A254")]
	public UICheckIsNewbieOrVeteranView()
	{
	}

	[Token(Token = "0x6016063")]
	[Address(RVA = "0x208A25C", Offset = "0x208A25C", VA = "0x208A25C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016064")]
	[Address(RVA = "0x208ABA8", Offset = "0x208ABA8", VA = "0x208ABA8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
