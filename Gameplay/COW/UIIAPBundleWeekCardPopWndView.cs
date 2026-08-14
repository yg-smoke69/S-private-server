using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037F5")]
public class UIIAPBundleWeekCardPopWndView : UIBaseView
{
	[Token(Token = "0x4016B63")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Close;

	[Token(Token = "0x4016B64")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TotalPercentLabel;

	[Token(Token = "0x4016B65")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TotalWorthLabel;

	[Token(Token = "0x4016B66")]
	[FieldOffset(Offset = "0x20")]
	public GameObject WeekDecoration;

	[Token(Token = "0x4016B67")]
	[FieldOffset(Offset = "0x24")]
	public GameObject TotalValue;

	[Token(Token = "0x4016B68")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TotalValueLabel;

	[Token(Token = "0x4016B69")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton TotalValueTipBtn;

	[Token(Token = "0x4016B6A")]
	[FieldOffset(Offset = "0x30")]
	public GameObject MorePirze;

	[Token(Token = "0x4016B6B")]
	[FieldOffset(Offset = "0x34")]
	public UILabel MorePirzeLabel;

	[Token(Token = "0x4016B6C")]
	[FieldOffset(Offset = "0x38")]
	public UIEasyList EasyList;

	[Token(Token = "0x4016B6D")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ContentBG;

	[Token(Token = "0x4016B6E")]
	[FieldOffset(Offset = "0x40")]
	public UICountDownLabel CountdownLabel;

	[Token(Token = "0x4016B6F")]
	[FieldOffset(Offset = "0x44")]
	public UILabel DesciptionLabel;

	[Token(Token = "0x4016B70")]
	[FieldOffset(Offset = "0x48")]
	public GameObject DiscountWidget;

	[Token(Token = "0x4016B71")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel DiscountEffectLabel;

	[Token(Token = "0x4016B72")]
	[FieldOffset(Offset = "0x50")]
	public UILabel DiscountLabel;

	[Token(Token = "0x4016B73")]
	[FieldOffset(Offset = "0x54")]
	public UIButton PurchaseedButton;

	[Token(Token = "0x4016B74")]
	[FieldOffset(Offset = "0x58")]
	public UIButton CheckInBtn;

	[Token(Token = "0x4016B75")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton PurchaseButton;

	[Token(Token = "0x4016B76")]
	[FieldOffset(Offset = "0x60")]
	public UILabel OriginalPriceLabel;

	[Token(Token = "0x4016B77")]
	[FieldOffset(Offset = "0x64")]
	public UILabel ActualPriceLabel;

	[Token(Token = "0x6016B8A")]
	[Address(RVA = "0xD45B54", Offset = "0xD45B54", VA = "0xD45B54")]
	public UIIAPBundleWeekCardPopWndView()
	{
	}

	[Token(Token = "0x6016B8B")]
	[Address(RVA = "0xD45B5C", Offset = "0xD45B5C", VA = "0xD45B5C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B8C")]
	[Address(RVA = "0xD46448", Offset = "0xD46448", VA = "0xD46448")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
