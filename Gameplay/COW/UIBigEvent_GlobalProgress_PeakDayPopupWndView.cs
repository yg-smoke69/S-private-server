using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033F2")]
public class UIBigEvent_GlobalProgress_PeakDayPopupWndView : UIBaseView
{
	[Token(Token = "0x4013FCA")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelTitle;

	[Token(Token = "0x4013FCB")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnClose;

	[Token(Token = "0x4013FCC")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite SpriteBtnClose;

	[Token(Token = "0x4013FCD")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelDesc;

	[Token(Token = "0x4013FCE")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid GridAwardContainer;

	[Token(Token = "0x4013FCF")]
	[FieldOffset(Offset = "0x28")]
	public GameObject GoClaim;

	[Token(Token = "0x4013FD0")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject LabelCantClaim;

	[Token(Token = "0x4013FD1")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnClaim;

	[Token(Token = "0x4013FD2")]
	[FieldOffset(Offset = "0x34")]
	public GameObject GoClaimed;

	[Token(Token = "0x4013FD3")]
	[FieldOffset(Offset = "0x38")]
	public GameObject GoExpired;

	[Token(Token = "0x4013FD4")]
	[FieldOffset(Offset = "0x3C")]
	public UINetworkTexture TextureBg;

	[Token(Token = "0x4013FD5")]
	[FieldOffset(Offset = "0x40")]
	public UINetworkTexture TextureTitle;

	[Token(Token = "0x6015F8A")]
	[Address(RVA = "0x10C0AA8", Offset = "0x10C0AA8", VA = "0x10C0AA8")]
	public UIBigEvent_GlobalProgress_PeakDayPopupWndView()
	{
	}

	[Token(Token = "0x6015F8B")]
	[Address(RVA = "0x10C0AB0", Offset = "0x10C0AB0", VA = "0x10C0AB0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F8C")]
	[Address(RVA = "0x10C1048", Offset = "0x10C1048", VA = "0x10C1048")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
