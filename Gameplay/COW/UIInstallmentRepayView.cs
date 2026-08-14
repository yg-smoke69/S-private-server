using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037FB")]
public class UIInstallmentRepayView : UIBaseView
{
	[Token(Token = "0x4016BE1")]
	[FieldOffset(Offset = "0x14")]
	public BaseItemView BaseItemView;

	[Token(Token = "0x4016BE2")]
	[FieldOffset(Offset = "0x18")]
	public UISprite ItemIcon;

	[Token(Token = "0x4016BE3")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite WeaponIcon;

	[Token(Token = "0x4016BE4")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ItemNameLabel;

	[Token(Token = "0x4016BE5")]
	[FieldOffset(Offset = "0x24")]
	public UISprite VoucherIcon;

	[Token(Token = "0x4016BE6")]
	[FieldOffset(Offset = "0x28")]
	public UILabel RepayTips;

	[Token(Token = "0x4016BE7")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ButtonGroup;

	[Token(Token = "0x4016BE8")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BtnOKGO;

	[Token(Token = "0x4016BE9")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnOK;

	[Token(Token = "0x4016BEA")]
	[FieldOffset(Offset = "0x38")]
	public UISprite BtnOKSprite;

	[Token(Token = "0x4016BEB")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject BtnCancelGO;

	[Token(Token = "0x4016BEC")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BtnCancel;

	[Token(Token = "0x4016BED")]
	[FieldOffset(Offset = "0x44")]
	public UISprite BtnCancelSprite;

	[Token(Token = "0x6016B9C")]
	[Address(RVA = "0x1280DE0", Offset = "0x1280DE0", VA = "0x1280DE0")]
	public UIInstallmentRepayView()
	{
	}

	[Token(Token = "0x6016B9D")]
	[Address(RVA = "0x1280DE8", Offset = "0x1280DE8", VA = "0x1280DE8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B9E")]
	[Address(RVA = "0x12813EC", Offset = "0x12813EC", VA = "0x12813EC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
