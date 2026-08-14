using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038BD")]
public class UIMysteryMallView : UIBaseView
{
	[Token(Token = "0x40177BD")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Title;

	[Token(Token = "0x40177BE")]
	[FieldOffset(Offset = "0x18")]
	public UIButton LeaveBtn;

	[Token(Token = "0x40177BF")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel GemLabel;

	[Token(Token = "0x40177C0")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnGem;

	[Token(Token = "0x40177C1")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Container;

	[Token(Token = "0x40177C2")]
	[FieldOffset(Offset = "0x28")]
	public UIScrollView ItemScrollView;

	[Token(Token = "0x40177C3")]
	[FieldOffset(Offset = "0x2C")]
	public UITable ItemTable;

	[Token(Token = "0x40177C4")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnRule;

	[Token(Token = "0x40177C5")]
	[FieldOffset(Offset = "0x34")]
	public Transform CountDownContainer;

	[Token(Token = "0x40177C6")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LabelCostNum;

	[Token(Token = "0x40177C7")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel LabelSuperOriginalPrice;

	[Token(Token = "0x40177C8")]
	[FieldOffset(Offset = "0x40")]
	public UILabel LabelSuperDiscountPrice;

	[Token(Token = "0x40177C9")]
	[FieldOffset(Offset = "0x44")]
	public UIButton BtnPurchaseSuper;

	[Token(Token = "0x40177CA")]
	[FieldOffset(Offset = "0x48")]
	public GameObject Locked;

	[Token(Token = "0x40177CB")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject Purchasable;

	[Token(Token = "0x40177CC")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Shareable;

	[Token(Token = "0x40177CD")]
	[FieldOffset(Offset = "0x54")]
	public GameObject TipsIcon;

	[Token(Token = "0x40177CE")]
	[FieldOffset(Offset = "0x58")]
	public UILabel LabelPriceTip;

	[Token(Token = "0x40177CF")]
	[FieldOffset(Offset = "0x5C")]
	public Transform ItemSuperContainer;

	[Token(Token = "0x40177D0")]
	[FieldOffset(Offset = "0x60")]
	public Transform ItemSecondContainer;

	[Token(Token = "0x40177D1")]
	[FieldOffset(Offset = "0x64")]
	public UINetworkTextureExt CdnSuperBg;

	[Token(Token = "0x40177D2")]
	[FieldOffset(Offset = "0x68")]
	public UIGrid ItemNormalGrid;

	[Token(Token = "0x40177D3")]
	[FieldOffset(Offset = "0x6C")]
	public UIGrid BtnGrid;

	[Token(Token = "0x40177D4")]
	[FieldOffset(Offset = "0x70")]
	public UIButton BtnGoWeb;

	[Token(Token = "0x40177D5")]
	[FieldOffset(Offset = "0x74")]
	public UINetworkTextureExt CdnGoWeb;

	[Token(Token = "0x40177D6")]
	[FieldOffset(Offset = "0x78")]
	public UIButton BtnSwitchPool;

	[Token(Token = "0x40177D7")]
	[FieldOffset(Offset = "0x7C")]
	public UINetworkTextureExt CdnSwitchPool;

	[Token(Token = "0x40177D8")]
	[FieldOffset(Offset = "0x80")]
	public UILabel LabelPoolPrice;

	[Token(Token = "0x40177D9")]
	[FieldOffset(Offset = "0x84")]
	public UILabel LabelProgress;

	[Token(Token = "0x40177DA")]
	[FieldOffset(Offset = "0x88")]
	public UIProgressBar BarSwitchProgress;

	[Token(Token = "0x40177DB")]
	[FieldOffset(Offset = "0x8C")]
	public Transform TabContainer;

	[Token(Token = "0x6016DE2")]
	[Address(RVA = "0x1B2ED80", Offset = "0x1B2ED80", VA = "0x1B2ED80")]
	public UIMysteryMallView()
	{
	}

	[Token(Token = "0x6016DE3")]
	[Address(RVA = "0x1B2ED88", Offset = "0x1B2ED88", VA = "0x1B2ED88", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DE4")]
	[Address(RVA = "0x1B2F994", Offset = "0x1B2F994", VA = "0x1B2F994")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
