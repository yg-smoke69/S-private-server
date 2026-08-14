using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200380B")]
public class UILadderMatchExchangeMallView : UIBaseView
{
	[Token(Token = "0x4016C79")]
	[FieldOffset(Offset = "0x14")]
	public GameObject AnimationMain;

	[Token(Token = "0x4016C7A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4016C7B")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject SliderNode;

	[Token(Token = "0x4016C7C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ExchangeMallTypeContainer;

	[Token(Token = "0x4016C7D")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButton NormalMallToggle;

	[Token(Token = "0x4016C7E")]
	[FieldOffset(Offset = "0x28")]
	public UIToggleButton PreviousRankMallToggle;

	[Token(Token = "0x4016C7F")]
	[FieldOffset(Offset = "0x2C")]
	public UIEasyList ExchangeMallEasyList;

	[Token(Token = "0x4016C80")]
	[FieldOffset(Offset = "0x30")]
	public UINetworkTexture BigPrizeCDN;

	[Token(Token = "0x4016C81")]
	[FieldOffset(Offset = "0x34")]
	public UIWidget PreviewContainer;

	[Token(Token = "0x4016C82")]
	[FieldOffset(Offset = "0x38")]
	public UIScrollView ExchangeMallScrollView;

	[Token(Token = "0x4016C83")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel LabelLimitedCount;

	[Token(Token = "0x4016C84")]
	[FieldOffset(Offset = "0x40")]
	public UILabel BuyBtnLabel;

	[Token(Token = "0x4016C85")]
	[FieldOffset(Offset = "0x44")]
	public UISprite BuyIcon;

	[Token(Token = "0x4016C86")]
	[FieldOffset(Offset = "0x48")]
	public UIButton BuyBtn;

	[Token(Token = "0x4016C87")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel BigPrizePeriodLabel;

	[Token(Token = "0x4016C88")]
	[FieldOffset(Offset = "0x50")]
	public GameObject UILadderMatchExchangeMall;

	[Token(Token = "0x4016C89")]
	[FieldOffset(Offset = "0x54")]
	public UILabel ExchangeCurrencyNum;

	[Token(Token = "0x4016C8A")]
	[FieldOffset(Offset = "0x58")]
	public GameObject ExchangeCurrencyBtn;

	[Token(Token = "0x4016C8B")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject BuyBtnGrayBG;

	[Token(Token = "0x4016C8C")]
	[FieldOffset(Offset = "0x60")]
	public GameObject BuyBtnBG;

	[Token(Token = "0x4016C8D")]
	[FieldOffset(Offset = "0x64")]
	public UILabel BuyBtnGrayLabel;

	[Token(Token = "0x6016BCC")]
	[Address(RVA = "0x1AE71C0", Offset = "0x1AE71C0", VA = "0x1AE71C0")]
	public UILadderMatchExchangeMallView()
	{
	}

	[Token(Token = "0x6016BCD")]
	[Address(RVA = "0x1AE71C8", Offset = "0x1AE71C8", VA = "0x1AE71C8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BCE")]
	[Address(RVA = "0x1AE7A9C", Offset = "0x1AE7A9C", VA = "0x1AE7A9C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
