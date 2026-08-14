using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002585")]
public class CommonRewardItemInfo
{
	[Token(Token = "0x2002586")]
	public enum RewardLevel
	{
		[Token(Token = "0x400E826")]
		NONE,
		[Token(Token = "0x400E827")]
		FIRST,
		[Token(Token = "0x400E828")]
		SECOND,
		[Token(Token = "0x400E829")]
		THIRD,
		[Token(Token = "0x400E82A")]
		FOURTH,
		[Token(Token = "0x400E82B")]
		FIFTH
	}

	[Token(Token = "0x400E81E")]
	[FieldOffset(Offset = "0x8")]
	public BaseItemInfo m_OriInfo;

	[Token(Token = "0x400E81F")]
	[FieldOffset(Offset = "0xC")]
	public BaseItemInfo m_EchInfo;

	[Token(Token = "0x400E820")]
	[FieldOffset(Offset = "0x10")]
	public uint m_Order;

	[Token(Token = "0x400E821")]
	[FieldOffset(Offset = "0x14")]
	public bool IsDropUpBuffed;

	[Token(Token = "0x400E822")]
	[FieldOffset(Offset = "0x15")]
	public bool IsSpecialLegendToken;

	[Token(Token = "0x400E823")]
	[FieldOffset(Offset = "0x16")]
	public bool IsGacha;

	[Token(Token = "0x400E824")]
	[FieldOffset(Offset = "0x18")]
	public RewardLevel rewardLevel;

	[Token(Token = "0x600DB5E")]
	[Address(RVA = "0x17391E4", Offset = "0x17391E4", VA = "0x17391E4")]
	public CommonRewardItemInfo()
	{
	}

	[Token(Token = "0x600DB5F")]
	[Address(RVA = "0x17391EC", Offset = "0x17391EC", VA = "0x17391EC")]
	public static RewardLevel CalRewardLevelRange(uint level)
	{
		return default(RewardLevel);
	}

	[Token(Token = "0x600DB60")]
	[Address(RVA = "0x173926C", Offset = "0x173926C", VA = "0x173926C")]
	public static implicit operator CommonRewardItemInfo(ExchangedAward awardItem)
	{
		return null;
	}

	[Token(Token = "0x600DB61")]
	[Address(RVA = "0x1739420", Offset = "0x1739420", VA = "0x1739420")]
	public static implicit operator CommonRewardItemInfo(Item item)
	{
		return null;
	}

	[Token(Token = "0x600DB62")]
	[Address(RVA = "0x1739544", Offset = "0x1739544", VA = "0x1739544")]
	public static implicit operator CommonRewardItemInfo(BaseItemInfo itemInfo)
	{
		return null;
	}

	[Token(Token = "0x600DB63")]
	[Address(RVA = "0x173962C", Offset = "0x173962C", VA = "0x173962C")]
	public static implicit operator CommonRewardItemInfo(AwardItemInfo itemInfo)
	{
		return null;
	}

	[Token(Token = "0x600DB64")]
	[Address(RVA = "0x1739714", Offset = "0x1739714", VA = "0x1739714")]
	public static implicit operator CommonRewardItemInfo(OptionalBundleShowData itemInfo)
	{
		return null;
	}

	[Token(Token = "0x600DB65")]
	[Address(RVA = "0x1739850", Offset = "0x1739850", VA = "0x1739850")]
	public bool CanExchang()
	{
		return default(bool);
	}

	[Token(Token = "0x600DB66")]
	[Address(RVA = "0x17398D4", Offset = "0x17398D4", VA = "0x17398D4")]
	public static Color GetColorByQuality(uint rare)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}
}
