using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200021A")]
public class RetentionPushNotificationData : CSVBaseData
{
	[Token(Token = "0x4000C71")]
	public const int SECONDS_PER_DAY = 86400;

	[Token(Token = "0x4000C72")]
	public const string REGION_DEFAULT = "default";

	[Token(Token = "0x4000C73")]
	[FieldOffset(Offset = "0x8")]
	public string Region;

	[Token(Token = "0x4000C74")]
	[FieldOffset(Offset = "0xC")]
	public string NotifyTitleKey;

	[Token(Token = "0x4000C75")]
	[FieldOffset(Offset = "0x10")]
	public string NotifyContentKey;

	[Token(Token = "0x4000C76")]
	[FieldOffset(Offset = "0x14")]
	public uint NewbieDays;

	[Token(Token = "0x4000C77")]
	[FieldOffset(Offset = "0x18")]
	public uint NotifyDays;

	[Token(Token = "0x4000C78")]
	[FieldOffset(Offset = "0x1C")]
	public uint RewardID;

	[Token(Token = "0x4000C79")]
	[FieldOffset(Offset = "0x20")]
	public uint RewardNum;

	[Token(Token = "0x4000C7A")]
	[FieldOffset(Offset = "0x24")]
	public uint RewardTime;

	[Token(Token = "0x6000ABA")]
	[Address(RVA = "0x2408CB0", Offset = "0x2408CB0", VA = "0x2408CB0")]
	public RetentionPushNotificationData()
	{
	}

	[Token(Token = "0x6000ABB")]
	[Address(RVA = "0x2408D34", Offset = "0x2408D34", VA = "0x2408D34", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000ABC")]
	[Address(RVA = "0x2408ED8", Offset = "0x2408ED8", VA = "0x2408ED8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000ABD")]
	[Address(RVA = "0x2408D9C", Offset = "0x2408D9C", VA = "0x2408D9C")]
	public static string FormatPrimaryKey(string region, uint newbie_days, uint notify_days)
	{
		return null;
	}
}
