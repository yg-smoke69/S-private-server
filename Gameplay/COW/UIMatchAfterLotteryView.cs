using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003892")]
public class UIMatchAfterLotteryView : UIBaseView
{
	[Token(Token = "0x40175EA")]
	[FieldOffset(Offset = "0x14")]
	public GameObject MaskBG;

	[Token(Token = "0x40175EB")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid ItemsGrid;

	[Token(Token = "0x40175EC")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LuckyTodayLabel;

	[Token(Token = "0x40175ED")]
	[FieldOffset(Offset = "0x20")]
	public GameObject OpenAllObj;

	[Token(Token = "0x40175EE")]
	[FieldOffset(Offset = "0x24")]
	public UIButton PurchaseBtn;

	[Token(Token = "0x40175EF")]
	[FieldOffset(Offset = "0x28")]
	public GameObject FreeBG;

	[Token(Token = "0x40175F0")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject CostBG;

	[Token(Token = "0x40175F1")]
	[FieldOffset(Offset = "0x30")]
	public UILabel DiamondCount;

	[Token(Token = "0x40175F2")]
	[FieldOffset(Offset = "0x34")]
	public UIButton CloseBtn;

	[Token(Token = "0x40175F3")]
	[FieldOffset(Offset = "0x38")]
	public UIButton PrizeHintBtn;

	[Token(Token = "0x6016D61")]
	[Address(RVA = "0x2815AE0", Offset = "0x2815AE0", VA = "0x2815AE0")]
	public UIMatchAfterLotteryView()
	{
	}

	[Token(Token = "0x6016D62")]
	[Address(RVA = "0x2815AE8", Offset = "0x2815AE8", VA = "0x2815AE8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D63")]
	[Address(RVA = "0x2815FC0", Offset = "0x2815FC0", VA = "0x2815FC0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
