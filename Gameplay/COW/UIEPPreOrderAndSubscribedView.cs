using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003520")]
public class UIEPPreOrderAndSubscribedView : UIBaseView
{
	[Token(Token = "0x4014F80")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BtnPanel;

	[Token(Token = "0x4014F81")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture CDNTexture;

	[Token(Token = "0x4014F82")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Title;

	[Token(Token = "0x4014F83")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid BtnGrid;

	[Token(Token = "0x4014F84")]
	[FieldOffset(Offset = "0x24")]
	public UIButton PreOrderEPBtn;

	[Token(Token = "0x4014F85")]
	[FieldOffset(Offset = "0x28")]
	public UISprite PreorderIcon;

	[Token(Token = "0x4014F86")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel PreorderLabel;

	[Token(Token = "0x4014F87")]
	[FieldOffset(Offset = "0x30")]
	public UIButton SubscribeEPBtn;

	[Token(Token = "0x4014F88")]
	[FieldOffset(Offset = "0x34")]
	public UISprite SubscribeIcon;

	[Token(Token = "0x4014F89")]
	[FieldOffset(Offset = "0x38")]
	public UILabel SubscribeLabel;

	[Token(Token = "0x4014F8A")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel SubscriptionBonusAmountLabel;

	[Token(Token = "0x4014F8B")]
	[FieldOffset(Offset = "0x40")]
	public UISprite SubscriptionBonus;

	[Token(Token = "0x4014F8C")]
	[FieldOffset(Offset = "0x44")]
	public UISprite SubscriptionTips;

	[Token(Token = "0x4014F8D")]
	[FieldOffset(Offset = "0x48")]
	public UIButton BtnClose;

	[Token(Token = "0x6016310")]
	[Address(RVA = "0x2BAE988", Offset = "0x2BAE988", VA = "0x2BAE988")]
	public UIEPPreOrderAndSubscribedView()
	{
	}

	[Token(Token = "0x6016311")]
	[Address(RVA = "0x2BAE990", Offset = "0x2BAE990", VA = "0x2BAE990", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016312")]
	[Address(RVA = "0x2BAF00C", Offset = "0x2BAF00C", VA = "0x2BAF00C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
