using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000210")]
public class RebateCardData : CSVBaseData
{
	[Token(Token = "0x4000C34")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x4000C35")]
	[FieldOffset(Offset = "0xC")]
	public int RebateID;

	[Token(Token = "0x4000C36")]
	[FieldOffset(Offset = "0x10")]
	public string Price;

	[Token(Token = "0x4000C37")]
	[FieldOffset(Offset = "0x14")]
	public int RebateDays;

	[Token(Token = "0x4000C38")]
	[FieldOffset(Offset = "0x18")]
	public RebateCardType RebateCardType;

	[Token(Token = "0x4000C39")]
	[FieldOffset(Offset = "0x1C")]
	public int RebateAmount;

	[Token(Token = "0x4000C3A")]
	[FieldOffset(Offset = "0x20")]
	public int FirstRebateAmount;

	[Token(Token = "0x4000C3B")]
	[FieldOffset(Offset = "0x24")]
	public string ProductIdentifier;

	[Token(Token = "0x4000C3C")]
	[FieldOffset(Offset = "0x28")]
	public int EarningRatePercentage;

	[Token(Token = "0x4000C3D")]
	[FieldOffset(Offset = "0x2C")]
	public string NameKey;

	[Token(Token = "0x4000C3E")]
	[FieldOffset(Offset = "0x30")]
	public int DaysAheadForRenewalReminding;

	[Token(Token = "0x4000C3F")]
	[FieldOffset(Offset = "0x34")]
	public string SubscriptionProductIdentifier_iOS;

	[Token(Token = "0x4000C40")]
	[FieldOffset(Offset = "0x38")]
	public string SubscriptionProductIdentifier_Android;

	[Token(Token = "0x4000C41")]
	[FieldOffset(Offset = "0x3C")]
	public string SubscribePrice;

	[Token(Token = "0x4000C42")]
	[FieldOffset(Offset = "0x40")]
	public int SubscribeBonus;

	[Token(Token = "0x4000C43")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, RebateCardData> _Data;

	[Token(Token = "0x1700015E")]
	public string SubscriptionProductIdentifier
	{
		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x196E88C", Offset = "0x196E88C", VA = "0x196E88C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700015F")]
	public static Dictionary<int, RebateCardData> Data
	{
		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x196E8E4", Offset = "0x196E8E4", VA = "0x196E8E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000A92")]
	[Address(RVA = "0x196E808", Offset = "0x196E808", VA = "0x196E808")]
	public RebateCardData()
	{
	}

	[Token(Token = "0x6000A95")]
	[Address(RVA = "0x196E9B4", Offset = "0x196E9B4", VA = "0x196E9B4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A96")]
	[Address(RVA = "0x196EA18", Offset = "0x196EA18", VA = "0x196EA18", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000A97")]
	[Address(RVA = "0x196EE38", Offset = "0x196EE38", VA = "0x196EE38")]
	public bool SupportSubscription()
	{
		return default(bool);
	}
}
