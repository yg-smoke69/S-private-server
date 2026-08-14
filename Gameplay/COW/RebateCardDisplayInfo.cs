using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20031F7")]
public class RebateCardDisplayInfo
{
	[Token(Token = "0x401303C")]
	[FieldOffset(Offset = "0x8")]
	public Color BgColor;

	[Token(Token = "0x401303D")]
	[FieldOffset(Offset = "0x18")]
	public string SubscriptionPeriodTextKey;

	[Token(Token = "0x401303E")]
	[FieldOffset(Offset = "0x1C")]
	public string Subscription_TitleKey;

	[Token(Token = "0x401303F")]
	[FieldOffset(Offset = "0x20")]
	public string Subscription_BenefitKey;

	[Token(Token = "0x4013040")]
	[FieldOffset(Offset = "0x24")]
	public string ConfirmBeforeSubscribe_TitleKey;

	[Token(Token = "0x4013041")]
	[FieldOffset(Offset = "0x28")]
	public string ConfirmBeforeSubscribe_TextKey;

	[Token(Token = "0x4013042")]
	[FieldOffset(Offset = "0x2C")]
	public string ConfirmBeforeSubscribe_LegalKey;

	[Token(Token = "0x4013043")]
	[FieldOffset(Offset = "0x30")]
	public string NotifyAfterSubscribe_SuccessKey;

	[Token(Token = "0x4013044")]
	[FieldOffset(Offset = "0x34")]
	public string PurchaseWhileSubscribed_TipsKey;

	[Token(Token = "0x4013045")]
	[FieldOffset(Offset = "0x38")]
	public string NotSubscribed_CheckBoxTextKey;

	[Token(Token = "0x4013046")]
	[FieldOffset(Offset = "0x3C")]
	public string Subscribed_CheckBoxTextKey;

	[Token(Token = "0x4013047")]
	[FieldOffset(Offset = "0x40")]
	public string Subscription_LastPaymentTimeKey;

	[Token(Token = "0x4013048")]
	[FieldOffset(Offset = "0x44")]
	public string Subscription_NextPaymentTimeKey;

	[Token(Token = "0x4013049")]
	[FieldOffset(Offset = "0x48")]
	public string HasReadSubscriptionHintPrefKey;

	[Token(Token = "0x401304A")]
	[FieldOffset(Offset = "0x4C")]
	public string ExtraItemKey;

	[Token(Token = "0x401304B")]
	[FieldOffset(Offset = "0x50")]
	public string InstantDiamondsKey;

	[Token(Token = "0x401304C")]
	[FieldOffset(Offset = "0x54")]
	public string DailyAndTotalDiamondsKey;

	[Token(Token = "0x401304D")]
	[FieldOffset(Offset = "0x58")]
	public string RebateRateKey;

	[Token(Token = "0x401304E")]
	[FieldOffset(Offset = "0x5C")]
	public string ResetTimeKey;

	[Token(Token = "0x401304F")]
	[FieldOffset(Offset = "0x60")]
	public string VipCardKey;

	[Token(Token = "0x4013050")]
	[FieldOffset(Offset = "0x0")]
	public static readonly Dictionary<int, RebateCardDisplayInfo> Infos;

	[Token(Token = "0x6015138")]
	[Address(RVA = "0x196EFF0", Offset = "0x196EFF0", VA = "0x196EFF0")]
	public RebateCardDisplayInfo()
	{
	}
}
