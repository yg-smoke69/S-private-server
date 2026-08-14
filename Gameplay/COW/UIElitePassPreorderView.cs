using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003508")]
public class UIElitePassPreorderView : UIBaseView
{
	[Token(Token = "0x4014E7F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton PreorderBtn;

	[Token(Token = "0x4014E80")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Price;

	[Token(Token = "0x4014E81")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel OriginalPrice;

	[Token(Token = "0x4014E82")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Discount;

	[Token(Token = "0x4014E83")]
	[FieldOffset(Offset = "0x24")]
	public UICountDownLabel PreorderCountDown;

	[Token(Token = "0x4014E84")]
	[FieldOffset(Offset = "0x28")]
	public UINetworkTexture PreorderCDN;

	[Token(Token = "0x4014E85")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton SubscribeBtn;

	[Token(Token = "0x4014E86")]
	[FieldOffset(Offset = "0x30")]
	public UISprite SubscriptionBonus;

	[Token(Token = "0x4014E87")]
	[FieldOffset(Offset = "0x34")]
	public UILabel SubscriptionBonusAmountLabel;

	[Token(Token = "0x4014E88")]
	[FieldOffset(Offset = "0x38")]
	public UIGrid PreviewGrid;

	[Token(Token = "0x4014E89")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject CGAnim;

	[Token(Token = "0x4014E8A")]
	[FieldOffset(Offset = "0x40")]
	public UIButton UIButtonAnimPlayBtn;

	[Token(Token = "0x4014E8B")]
	[FieldOffset(Offset = "0x44")]
	public UISprite UISpriteAnimPlayBtn;

	[Token(Token = "0x4014E8C")]
	[FieldOffset(Offset = "0x48")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x4014E8D")]
	[FieldOffset(Offset = "0x4C")]
	public Transform DownloadCtrlPos;

	[Token(Token = "0x60162C8")]
	[Address(RVA = "0x305ED9C", Offset = "0x305ED9C", VA = "0x305ED9C")]
	public UIElitePassPreorderView()
	{
	}

	[Token(Token = "0x60162C9")]
	[Address(RVA = "0x305EDA4", Offset = "0x305EDA4", VA = "0x305EDA4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162CA")]
	[Address(RVA = "0x305F458", Offset = "0x305F458", VA = "0x305F458")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
