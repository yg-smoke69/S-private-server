using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200356D")]
public class UIGachaEnergyContentView : UIBaseView
{
	[Token(Token = "0x40152C1")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget PreviewLeftSide;

	[Token(Token = "0x40152C2")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget PreviewRightSide;

	[Token(Token = "0x40152C3")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Anim;

	[Token(Token = "0x40152C4")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CDNMask01;

	[Token(Token = "0x40152C5")]
	[FieldOffset(Offset = "0x24")]
	public GameObject CDNMask02;

	[Token(Token = "0x40152C6")]
	[FieldOffset(Offset = "0x28")]
	public GameObject EnergyDefaultTitle;

	[Token(Token = "0x40152C7")]
	[FieldOffset(Offset = "0x2C")]
	public UINetworkTexture LimitTitleCDN;

	[Token(Token = "0x40152C8")]
	[FieldOffset(Offset = "0x30")]
	public UICountDownIcon CountDownIcon;

	[Token(Token = "0x40152C9")]
	[FieldOffset(Offset = "0x34")]
	public UICountDownLabel GachaCountDownLabel;

	[Token(Token = "0x40152CA")]
	[FieldOffset(Offset = "0x38")]
	public UIButton RefreshBuffBtn;

	[Token(Token = "0x40152CB")]
	[FieldOffset(Offset = "0x3C")]
	public UICheckboxButton ChooseCheckBtn;

	[Token(Token = "0x40152CC")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ChooseState;

	[Token(Token = "0x40152CD")]
	[FieldOffset(Offset = "0x44")]
	public GameObject BuyBtnGroup;

	[Token(Token = "0x40152CE")]
	[FieldOffset(Offset = "0x48")]
	public UIButton ShowRewardsBtn;

	[Token(Token = "0x40152CF")]
	[FieldOffset(Offset = "0x4C")]
	public UIWidget GachaPreviewPosition;

	[Token(Token = "0x60163F7")]
	[Address(RVA = "0x247490C", Offset = "0x247490C", VA = "0x247490C")]
	public UIGachaEnergyContentView()
	{
	}

	[Token(Token = "0x60163F8")]
	[Address(RVA = "0x2474914", Offset = "0x2474914", VA = "0x2474914", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60163F9")]
	[Address(RVA = "0x2474FB4", Offset = "0x2474FB4", VA = "0x2474FB4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
