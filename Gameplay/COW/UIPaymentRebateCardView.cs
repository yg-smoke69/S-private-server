using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038EF")]
public class UIPaymentRebateCardView : UIBaseView
{
	[Token(Token = "0x4017A66")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIPaymentRebateCard;

	[Token(Token = "0x4017A67")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TotalRebateDescLabel;

	[Token(Token = "0x4017A68")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TotalRebateAmountLabel;

	[Token(Token = "0x4017A69")]
	[FieldOffset(Offset = "0x20")]
	public UILabel NotifyLabel;

	[Token(Token = "0x4017A6A")]
	[FieldOffset(Offset = "0x24")]
	public UIToggle CheckboxForNotify;

	[Token(Token = "0x4017A6B")]
	[FieldOffset(Offset = "0x28")]
	public UISprite RebateCardsContainer_MonthCard;

	[Token(Token = "0x4017A6C")]
	[FieldOffset(Offset = "0x2C")]
	public UINetworkTextureExt NetworkTexture_MonthCard;

	[Token(Token = "0x4017A6D")]
	[FieldOffset(Offset = "0x30")]
	public UISprite RebateCardsContainer_WeekCard;

	[Token(Token = "0x4017A6E")]
	[FieldOffset(Offset = "0x34")]
	public UINetworkTextureExt NetworkTexture_WeekCard;

	[Token(Token = "0x4017A6F")]
	[FieldOffset(Offset = "0x38")]
	public GameObject LoadingContainer;

	[Token(Token = "0x6016E76")]
	[Address(RVA = "0x29DC344", Offset = "0x29DC344", VA = "0x29DC344")]
	public UIPaymentRebateCardView()
	{
	}

	[Token(Token = "0x6016E77")]
	[Address(RVA = "0x29DC34C", Offset = "0x29DC34C", VA = "0x29DC34C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E78")]
	[Address(RVA = "0x29DC83C", Offset = "0x29DC83C", VA = "0x29DC83C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
