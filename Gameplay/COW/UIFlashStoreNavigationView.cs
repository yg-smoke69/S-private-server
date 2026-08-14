using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200353B")]
public class UIFlashStoreNavigationView : UIBaseView
{
	[Token(Token = "0x40150D2")]
	[FieldOffset(Offset = "0x14")]
	public Transform CountDownContainer;

	[Token(Token = "0x40150D3")]
	[FieldOffset(Offset = "0x18")]
	public UIButton FreeAcessBtn;

	[Token(Token = "0x40150D4")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget FreeAcessWidget;

	[Token(Token = "0x40150D5")]
	[FieldOffset(Offset = "0x20")]
	public GameObject MallContentContainer;

	[Token(Token = "0x40150D6")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BuyBtn;

	[Token(Token = "0x40150D7")]
	[FieldOffset(Offset = "0x28")]
	public GameObject TogglesContentContainer;

	[Token(Token = "0x40150D8")]
	[FieldOffset(Offset = "0x2C")]
	public UIScrollView NormalMallTabScrollView;

	[Token(Token = "0x40150D9")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid TabGrid;

	[Token(Token = "0x40150DA")]
	[FieldOffset(Offset = "0x34")]
	public UIToggleButtonGroup TabToggleButtonGroup;

	[Token(Token = "0x40150DB")]
	[FieldOffset(Offset = "0x38")]
	public UIWidget PreviewContainer;

	[Token(Token = "0x40150DC")]
	[FieldOffset(Offset = "0x3C")]
	public UINetworkTexture DiamondStoreLabelCDN;

	[Token(Token = "0x40150DD")]
	[FieldOffset(Offset = "0x40")]
	public UILabel PeriodIllustrationLabel;

	[Token(Token = "0x40150DE")]
	[FieldOffset(Offset = "0x44")]
	public UILabel PeriodTimeLabel;

	[Token(Token = "0x40150DF")]
	[FieldOffset(Offset = "0x48")]
	public GameObject main;

	[Token(Token = "0x40150E0")]
	[FieldOffset(Offset = "0x4C")]
	public UIScrollView ExchangeMallScrollView;

	[Token(Token = "0x40150E1")]
	[FieldOffset(Offset = "0x50")]
	public UIEasyList ExchangeMallEasyList;

	[Token(Token = "0x40150E2")]
	[FieldOffset(Offset = "0x54")]
	public UILabel BuyBtnLabel;

	[Token(Token = "0x40150E3")]
	[FieldOffset(Offset = "0x58")]
	public UILabel LabelLimitedCount;

	[Token(Token = "0x40150E4")]
	[FieldOffset(Offset = "0x5C")]
	public UIToggleButton mallToggle;

	[Token(Token = "0x40150E5")]
	[FieldOffset(Offset = "0x60")]
	public UIButton RuleButton;

	[Token(Token = "0x40150E6")]
	[FieldOffset(Offset = "0x64")]
	public GameObject DiamondStoreLabelDefaultSprite;

	[Token(Token = "0x40150E7")]
	[FieldOffset(Offset = "0x68")]
	public UIPanel GuideMaskPanel;

	[Token(Token = "0x40150E8")]
	[FieldOffset(Offset = "0x6C")]
	public UIButton GuideMaskBtn;

	[Token(Token = "0x40150E9")]
	[FieldOffset(Offset = "0x70")]
	public UILabel FreeAcessLabel;

	[Token(Token = "0x40150EA")]
	[FieldOffset(Offset = "0x74")]
	public GameObject FreeAcessCountDownContainer;

	[Token(Token = "0x40150EB")]
	[FieldOffset(Offset = "0x78")]
	public UIWidget ItemListGuideWidget;

	[Token(Token = "0x6016361")]
	[Address(RVA = "0x1B59680", Offset = "0x1B59680", VA = "0x1B59680")]
	public UIFlashStoreNavigationView()
	{
	}

	[Token(Token = "0x6016362")]
	[Address(RVA = "0x1B59688", Offset = "0x1B59688", VA = "0x1B59688", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016363")]
	[Address(RVA = "0x1B5A12C", Offset = "0x1B5A12C", VA = "0x1B5A12C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
