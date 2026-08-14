using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003530")]
public class UIFastSendGiftView : UIBaseView
{
	[Token(Token = "0x4015025")]
	[FieldOffset(Offset = "0x14")]
	public UIButton CloseBtn;

	[Token(Token = "0x4015026")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView GiftItemScrollView;

	[Token(Token = "0x4015027")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList GiftItemGrid;

	[Token(Token = "0x4015028")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Mask;

	[Token(Token = "0x4015029")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid TeamMateGrid;

	[Token(Token = "0x401502A")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BtnGroupContainer;

	[Token(Token = "0x401502B")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton SendBtn;

	[Token(Token = "0x401502C")]
	[FieldOffset(Offset = "0x30")]
	public UITable Table;

	[Token(Token = "0x401502D")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Diamond;

	[Token(Token = "0x401502E")]
	[FieldOffset(Offset = "0x38")]
	public UILabel GemsPriceLabel;

	[Token(Token = "0x401502F")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject OR;

	[Token(Token = "0x4015030")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Gold;

	[Token(Token = "0x4015031")]
	[FieldOffset(Offset = "0x44")]
	public UILabel CoinsPriceLabel;

	[Token(Token = "0x4015032")]
	[FieldOffset(Offset = "0x48")]
	public UIScrollView HotItemScrollView;

	[Token(Token = "0x4015033")]
	[FieldOffset(Offset = "0x4C")]
	public UIEasyList HotItemGrid;

	[Token(Token = "0x6016340")]
	[Address(RVA = "0x1DBBDC0", Offset = "0x1DBBDC0", VA = "0x1DBBDC0")]
	public UIFastSendGiftView()
	{
	}

	[Token(Token = "0x6016341")]
	[Address(RVA = "0x1DBBDC8", Offset = "0x1DBBDC8", VA = "0x1DBBDC8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016342")]
	[Address(RVA = "0x1DBC480", Offset = "0x1DBC480", VA = "0x1DBC480")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
