using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200317F")]
public class ClientMemberShipCardData
{
	[Token(Token = "0x4012D10")]
	[FieldOffset(Offset = "0x8")]
	public bool HasProcessed;

	[Token(Token = "0x4012D11")]
	[FieldOffset(Offset = "0xC")]
	public uint ID;

	[Token(Token = "0x4012D12")]
	[FieldOffset(Offset = "0x10")]
	public EVipCard.VipCardType Type;

	[Token(Token = "0x4012D13")]
	[FieldOffset(Offset = "0x14")]
	public RebateCardData RebateCardData;

	[Token(Token = "0x4012D14")]
	[FieldOffset(Offset = "0x18")]
	private PayItemData _003CSubscriptionProductFromCSV_003Ek__BackingField;

	[Token(Token = "0x4012D15")]
	[FieldOffset(Offset = "0x1C")]
	public uint Percent;

	[Token(Token = "0x4012D16")]
	[FieldOffset(Offset = "0x20")]
	public uint CardWorth;

	[Token(Token = "0x4012D17")]
	[FieldOffset(Offset = "0x24")]
	public uint SignDiamondGet;

	[Token(Token = "0x4012D18")]
	[FieldOffset(Offset = "0x28")]
	public uint InstantDiamondGet;

	[Token(Token = "0x4012D19")]
	[FieldOffset(Offset = "0x2C")]
	public uint TotalDiamondReward;

	[Token(Token = "0x4012D1A")]
	[FieldOffset(Offset = "0x30")]
	public uint OtherWorth;

	[Token(Token = "0x4012D1B")]
	[FieldOffset(Offset = "0x34")]
	public uint RemainingDays;

	[Token(Token = "0x4012D1C")]
	[FieldOffset(Offset = "0x38")]
	public uint CurrentDay;

	[Token(Token = "0x4012D1D")]
	[FieldOffset(Offset = "0x3C")]
	public uint DiscountStartTime;

	[Token(Token = "0x4012D1E")]
	[FieldOffset(Offset = "0x40")]
	public uint DiscountEndTime;

	[Token(Token = "0x4012D1F")]
	[FieldOffset(Offset = "0x44")]
	public float DiscountPrice;

	[Token(Token = "0x4012D20")]
	[FieldOffset(Offset = "0x48")]
	public uint DiscountPurchaseLimitTime;

	[Token(Token = "0x4012D21")]
	[FieldOffset(Offset = "0x4C")]
	public int DiscountRebateID;

	[Token(Token = "0x4012D22")]
	[FieldOffset(Offset = "0x50")]
	public string DiscountProductIdentifier;

	[Token(Token = "0x4012D23")]
	[FieldOffset(Offset = "0x54")]
	public List<AwardDesc> ShowRewardList;

	[Token(Token = "0x4012D24")]
	[FieldOffset(Offset = "0x58")]
	public List<AwardDesc> TodayRewardList;

	[Token(Token = "0x4012D25")]
	[FieldOffset(Offset = "0x5C")]
	public uint TodayGemReward;

	[Token(Token = "0x4012D26")]
	[FieldOffset(Offset = "0x60")]
	public VipCardRebateDesc AirDropRebateDesc;

	[Token(Token = "0x4012D27")]
	[FieldOffset(Offset = "0x64")]
	public uint WarnTime;

	[Token(Token = "0x170015DE")]
	public PayItemData SubscriptionProductFromCSV
	{
		[Token(Token = "0x6014CB3")]
		[Address(RVA = "0x172C8D0", Offset = "0x172C8D0", VA = "0x172C8D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014CB4")]
		[Address(RVA = "0x172C8D8", Offset = "0x172C8D8", VA = "0x172C8D8")]
		private set
		{
		}
	}

	[Token(Token = "0x6014CB2")]
	[Address(RVA = "0x172C420", Offset = "0x172C420", VA = "0x172C420")]
	public ClientMemberShipCardData(EVipCard.VipCardType type)
	{
	}
}
