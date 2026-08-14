using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200356A")]
public class UIGachaDrawResultItemView : UIBaseView
{
	[Token(Token = "0x401528D")]
	[FieldOffset(Offset = "0x14")]
	public TweenPosition FlowAnim;

	[Token(Token = "0x401528E")]
	[FieldOffset(Offset = "0x18")]
	public BaseItemView RewardItem;

	[Token(Token = "0x401528F")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel NameLabel;

	[Token(Token = "0x4015290")]
	[FieldOffset(Offset = "0x20")]
	public GameObject IconGroup;

	[Token(Token = "0x4015291")]
	[FieldOffset(Offset = "0x24")]
	public UISprite VoucherIcon;

	[Token(Token = "0x4015292")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LimitLabel;

	[Token(Token = "0x4015293")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggle RewardToggle;

	[Token(Token = "0x4015294")]
	[FieldOffset(Offset = "0x30")]
	public UISprite SelectedSprite;

	[Token(Token = "0x4015295")]
	[FieldOffset(Offset = "0x34")]
	public UISprite UnSelectedSprite;

	[Token(Token = "0x4015296")]
	[FieldOffset(Offset = "0x38")]
	public UILabel QuantityLabel;

	[Token(Token = "0x4015297")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ExchangeVoucher;

	[Token(Token = "0x4015298")]
	[FieldOffset(Offset = "0x40")]
	public TweenAlpha VoucherTweenAnim;

	[Token(Token = "0x4015299")]
	[FieldOffset(Offset = "0x44")]
	public UISprite VoucherSprite;

	[Token(Token = "0x401529A")]
	[FieldOffset(Offset = "0x48")]
	public UILabel VoucherCntLabel;

	[Token(Token = "0x401529B")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite GemSprite;

	[Token(Token = "0x60163EE")]
	[Address(RVA = "0x2471FD4", Offset = "0x2471FD4", VA = "0x2471FD4")]
	public UIGachaDrawResultItemView()
	{
	}

	[Token(Token = "0x60163EF")]
	[Address(RVA = "0x2471FDC", Offset = "0x2471FDC", VA = "0x2471FDC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60163F0")]
	[Address(RVA = "0x24726AC", Offset = "0x24726AC", VA = "0x24726AC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
