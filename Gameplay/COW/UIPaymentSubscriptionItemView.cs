using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038F5")]
public class UIPaymentSubscriptionItemView : UIBaseView
{
	[Token(Token = "0x4017AA6")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Button;

	[Token(Token = "0x4017AA7")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Selected;

	[Token(Token = "0x4017AA8")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite RedDot;

	[Token(Token = "0x4017AA9")]
	[FieldOffset(Offset = "0x20")]
	public UILabel PriceLabel;

	[Token(Token = "0x4017AAA")]
	[FieldOffset(Offset = "0x24")]
	public UILabel PeriodLabel;

	[Token(Token = "0x4017AAB")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget Subscribing;

	[Token(Token = "0x4017AAC")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel SubscribingLabel;

	[Token(Token = "0x4017AAD")]
	[FieldOffset(Offset = "0x30")]
	public UINetworkTextureExt MainAdNetworkTexture;

	[Token(Token = "0x4017AAE")]
	[FieldOffset(Offset = "0x34")]
	public UIWidget NewIcon;

	[Token(Token = "0x4017AAF")]
	[FieldOffset(Offset = "0x38")]
	public UIWidget LimitedIcon;

	[Token(Token = "0x6016E88")]
	[Address(RVA = "0x29EAE60", Offset = "0x29EAE60", VA = "0x29EAE60")]
	public UIPaymentSubscriptionItemView()
	{
	}

	[Token(Token = "0x6016E89")]
	[Address(RVA = "0x29EAE68", Offset = "0x29EAE68", VA = "0x29EAE68", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E8A")]
	[Address(RVA = "0x29EB370", Offset = "0x29EB370", VA = "0x29EB370")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
