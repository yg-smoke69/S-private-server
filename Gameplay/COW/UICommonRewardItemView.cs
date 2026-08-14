using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200347B")]
public class UICommonRewardItemView : UIBaseView
{
	[Token(Token = "0x40146BE")]
	[FieldOffset(Offset = "0x14")]
	public TweenScale UICommonRewardItem;

	[Token(Token = "0x40146BF")]
	[FieldOffset(Offset = "0x18")]
	public Animation UICommonRewardItemAnimation;

	[Token(Token = "0x40146C0")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject RewardItem;

	[Token(Token = "0x40146C1")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LimitLabel;

	[Token(Token = "0x40146C2")]
	[FieldOffset(Offset = "0x24")]
	public UIToggle RewardToggle;

	[Token(Token = "0x40146C3")]
	[FieldOffset(Offset = "0x28")]
	public UISprite SelectedSprite;

	[Token(Token = "0x40146C4")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite UnSelectedSprite;

	[Token(Token = "0x40146C5")]
	[FieldOffset(Offset = "0x30")]
	public UILabel QuantityLabel;

	[Token(Token = "0x40146C6")]
	[FieldOffset(Offset = "0x34")]
	public UIToggle OptionalToggle;

	[Token(Token = "0x40146C7")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ExchangeVoucher;

	[Token(Token = "0x40146C8")]
	[FieldOffset(Offset = "0x3C")]
	public TweenAlpha VoucherTweenAnim;

	[Token(Token = "0x40146C9")]
	[FieldOffset(Offset = "0x40")]
	public UISprite VoucherSprite;

	[Token(Token = "0x40146CA")]
	[FieldOffset(Offset = "0x44")]
	public UILabel VoucherCntLabel;

	[Token(Token = "0x6016125")]
	[Address(RVA = "0x2CE8DD8", Offset = "0x2CE8DD8", VA = "0x2CE8DD8")]
	public UICommonRewardItemView()
	{
	}

	[Token(Token = "0x6016126")]
	[Address(RVA = "0x2CE8DE0", Offset = "0x2CE8DE0", VA = "0x2CE8DE0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016127")]
	[Address(RVA = "0x2CE93F0", Offset = "0x2CE93F0", VA = "0x2CE93F0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
