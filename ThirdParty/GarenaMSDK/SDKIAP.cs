using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x2000035")]
public static class SDKIAP
{
	[Serializable]
	[Token(Token = "0x2000036")]
	public class IAPItem
	{
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x8")]
		public string ItemIdentifier;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0xC")]
		public bool Promotion;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x10")]
		public int VirtualCurrencyAmount;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x14")]
		public int PromotionAmount;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x18")]
		public string ActualCurrencyName;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x1C")]
		public float ActualCurrencyAmount;

		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x20")]
		public string PriceString;

		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x24")]
		public int RebateId;

		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x28")]
		public Subscription Subscription;

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x3461448", Offset = "0x3461448", VA = "0x3461448")]
		public IAPItem()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x34614E8", Offset = "0x34614E8", VA = "0x34614E8")]
		public static IAPItem _(SDKIAP_Android.Denomination denomination)
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000037")]
	public class Subscription
	{
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x8")]
		public SubscriptionPeriod Period;

		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0xC")]
		public SubscriptionStatus Status;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x10")]
		public int LastPaymentTime;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x18")]
		public long GracePeriodExpiryTime;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x20")]
		public long OnHoldSince;

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x3461C2C", Offset = "0x3461C2C", VA = "0x3461C2C")]
		public Subscription()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x3461664", Offset = "0x3461664", VA = "0x3461664")]
		public static Subscription _(SDKIAP_Android.Subscription subscription)
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000038")]
	public enum SubscriptionStatus
	{
		[Token(Token = "0x4000167")]
		None = -1,
		[Token(Token = "0x4000168")]
		Active,
		[Token(Token = "0x4000169")]
		Expired,
		[Token(Token = "0x400016A")]
		Cancelled,
		[Token(Token = "0x400016B")]
		Revoked,
		[Token(Token = "0x400016C")]
		Transferred,
		[Token(Token = "0x400016D")]
		Scheduled
	}

	[Serializable]
	[Token(Token = "0x2000039")]
	public enum SubscriptionPeriod
	{
		[Token(Token = "0x400016F")]
		None,
		[Token(Token = "0x4000170")]
		Week_1,
		[Token(Token = "0x4000171")]
		Month_1,
		[Token(Token = "0x4000172")]
		Month_3,
		[Token(Token = "0x4000173")]
		Month_6,
		[Token(Token = "0x4000174")]
		Year_1
	}

	[Serializable]
	[Token(Token = "0x200003A")]
	public class RebateOption
	{
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x8")]
		public long RebateId;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x10")]
		public int RebateAmount;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x14")]
		public int RemainingDays;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x18")]
		public int TotalDays;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x1C")]
		public bool CanPurchase;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x1D")]
		public bool CanRedeem;

		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x1E")]
		public bool Owned;

		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x20")]
		public string Name;

		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x24")]
		public string Description;

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x3461B70", Offset = "0x3461B70", VA = "0x3461B70")]
		public RebateOption()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200003B")]
	public class RebateRedeemResult
	{
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x8")]
		public long RebateId;

		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x10")]
		public int RebateAmount;

		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x14")]
		public int RemainingDays;

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x3461C1C", Offset = "0x3461C1C", VA = "0x3461C1C")]
		public RebateRedeemResult()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200003C")]
	public class ScanIAPInventoryResult
	{
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x8")]
		public string ItemIdentifier;

		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0xC")]
		public int VirtualCurrencyAmount;

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x10")]
		public bool IsPromotion;

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x11")]
		public bool Success;

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x14")]
		public string Error;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x3461C24", Offset = "0x3461C24", VA = "0x3461C24")]
		public ScanIAPInventoryResult()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200003D")]
	public class EventConfig
	{
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x8")]
		public double Price;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x10")]
		public long ItemId;

		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x18")]
		public long RebateId;

		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x20")]
		public string ExtraInfo;

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x3461164", Offset = "0x3461164", VA = "0x3461164")]
		public EventConfig()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x346116C", Offset = "0x346116C", VA = "0x346116C")]
		public static EventConfig _(SDKIAP_Android.EventConfigLessIsMore eventConfig)
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x200003E")]
	public class Event
	{
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x8")]
		public long EventId;

		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x10")]
		public string Type;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x18")]
		public long StartTime;

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x20")]
		public long EndTime;

		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x28")]
		public string Region;

		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x2C")]
		public EventConfig[] Configs;

		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<SDKIAP_Android.EventConfigLessIsMore, EventConfig> _003C_003Ef__mg_0024cache0;

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x3460F6C", Offset = "0x3460F6C", VA = "0x3460F6C")]
		public Event()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x3460F74", Offset = "0x3460F74", VA = "0x3460F74")]
		public static Event _(SDKIAP_Android.EventLessIsMore e)
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x200003F")]
	public class LoadEventConfigsResult
	{
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x8")]
		public int Flag;

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0xC")]
		public string Exception;

		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x10")]
		public Event[] Events;

		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<SDKIAP_Android.EventLessIsMore, Event> _003C_003Ef__mg_0024cache0;

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x3461784", Offset = "0x3461784", VA = "0x3461784")]
		public LoadEventConfigsResult()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x346178C", Offset = "0x346178C", VA = "0x346178C")]
		public static LoadEventConfigsResult _(SDKIAP_Android.LoadEventConfigsResult result)
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000040")]
	public class EventDatum
	{
		[Token(Token = "0x4000195")]
		public const int STATUS_ELIGIBLE = 0;

		[Token(Token = "0x4000196")]
		public const int STATUS_PENDING = 1;

		[Token(Token = "0x4000197")]
		public const int STATUS_ILLEGIBLE = 2;

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x8")]
		public long EventId;

		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x10")]
		public string Type;

		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x18")]
		public long StartTime;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x20")]
		public long EndTime;

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x28")]
		public long AvailableTimes;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x30")]
		public long TotalTimes;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x38")]
		public int Status;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x3C")]
		public int[] ItemIds;

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x3461284", Offset = "0x3461284", VA = "0x3461284")]
		public EventDatum()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x346128C", Offset = "0x346128C", VA = "0x346128C")]
		public static EventDatum _(SDKIAP_Android.PricingEvent e)
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000041")]
	public class LoadEventIAPResult
	{
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x8")]
		public int Flag;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0xC")]
		public string Exception;

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x10")]
		public IAPItem[] Items;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x14")]
		public EventDatum[] Data;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<SDKIAP_Android.Denomination, IAPItem> _003C_003Ef__mg_0024cache0;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x4")]
		private static Converter<SDKIAP_Android.PricingEvent, EventDatum> _003C_003Ef__mg_0024cache1;

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x34618FC", Offset = "0x34618FC", VA = "0x34618FC")]
		public LoadEventIAPResult()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x3461904", Offset = "0x3461904", VA = "0x3461904")]
		public static LoadEventIAPResult _(SDKIAP_Android.GetEventsPricingResult result)
		{
			return null;
		}
	}

	[Token(Token = "0x2000042")]
	public delegate void LogCallback(string log);

	[Token(Token = "0x4000147")]
	[FieldOffset(Offset = "0x0")]
	public static string IAPItemIdentifierTemplate;

	[Token(Token = "0x4000148")]
	[FieldOffset(Offset = "0x4")]
	public static string VirtualCurrencyName;

	[Token(Token = "0x4000149")]
	[FieldOffset(Offset = "0x8")]
	internal static Action<IAPItem[], ErrorCode, string> OnLoadedIAPItems;

	[Token(Token = "0x400014A")]
	[FieldOffset(Offset = "0xC")]
	internal static Action<LoadEventConfigsResult> OnLoadEventConfigs;

	[Token(Token = "0x400014B")]
	[FieldOffset(Offset = "0x10")]
	internal static Action<LoadEventIAPResult> OnLoadedEventIAPItems;

	[Token(Token = "0x400014C")]
	[FieldOffset(Offset = "0x14")]
	internal static Action<SDKIAP_Android.TransactionInfo> OnPaymentProcessedOrException;

	[Token(Token = "0x400014D")]
	[FieldOffset(Offset = "0x18")]
	internal static Action<SDKIAP_Android.TransactionInfo> OnEventPaymentProcessedOrException;

	[Token(Token = "0x400014E")]
	[FieldOffset(Offset = "0x1C")]
	internal static Action<ScanIAPInventoryResult[]> OnScanIAPInventoryResult;

	[Token(Token = "0x400014F")]
	[FieldOffset(Offset = "0x20")]
	internal static Action<RebateOption[], ErrorCode, string> OnLoadedRebateOptions;

	[Token(Token = "0x4000150")]
	[FieldOffset(Offset = "0x24")]
	internal static Action<RebateRedeemResult[], ErrorCode, string> OnRedeemedRebateOptions;

	[Token(Token = "0x4000151")]
	[FieldOffset(Offset = "0x28")]
	public static LogCallback OnLogVerbose;

	[Token(Token = "0x4000152")]
	[FieldOffset(Offset = "0x2C")]
	public static LogCallback OnLog;

	[Token(Token = "0x4000153")]
	[FieldOffset(Offset = "0x30")]
	public static LogCallback OnLogError;

	[Token(Token = "0x4000154")]
	[FieldOffset(Offset = "0x34")]
	private static readonly Dictionary<string, Dictionary<bool, string>> MShopUrls;

	[Token(Token = "0x4000155")]
	[FieldOffset(Offset = "0x38")]
	public static string ConfigMShopUrl;

	[Token(Token = "0x4000156")]
	[FieldOffset(Offset = "0x3C")]
	public static string OverrideMShopUrl;

	[Token(Token = "0x4000157")]
	[FieldOffset(Offset = "0x40")]
	public static uint OverrideProduction;

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x3453394", Offset = "0x3453394", VA = "0x3453394")]
	public static bool IsOK(ErrorCode errorCode)
	{
		return default(bool);
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x3459CBC", Offset = "0x3459CBC", VA = "0x3459CBC")]
	public static string FormatIAPItemIdentifier(string itemID)
	{
		return null;
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x3459D88", Offset = "0x3459D88", VA = "0x3459D88")]
	internal static void RestoreIAP(int serverId = 0, int roleId = 0)
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x34573E8", Offset = "0x34573E8", VA = "0x34573E8")]
	internal static void LogVerbose(string log)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x34570EC", Offset = "0x34570EC", VA = "0x34570EC")]
	internal static void Log(string log)
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x345A148", Offset = "0x345A148", VA = "0x345A148")]
	internal static void LogError(string log)
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x345A238", Offset = "0x345A238", VA = "0x345A238")]
	public static bool CanLoadIAPItemsOnDemand()
	{
		return default(bool);
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x345A240", Offset = "0x345A240", VA = "0x345A240")]
	public static bool CanGetRebateOptionsOnDemand()
	{
		return default(bool);
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x3455010", Offset = "0x3455010", VA = "0x3455010")]
	internal static void GetRebateOptions()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x345655C", Offset = "0x345655C", VA = "0x345655C")]
	internal static void GetRebateOptionsByRebateIds(long[] rebateIds)
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x345A8B0", Offset = "0x345A8B0", VA = "0x345A8B0")]
	public static bool ShouldLoadRebateIAPItems()
	{
		return default(bool);
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x345A8B8", Offset = "0x345A8B8", VA = "0x345A8B8")]
	internal static void ClearIAPItems()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x3454748", Offset = "0x3454748", VA = "0x3454748")]
	internal static bool LoadIAPItems(int serverId, int roleId, bool localized, bool allItems = true, long rebateId = 0L)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x3455BB0", Offset = "0x3455BB0", VA = "0x3455BB0")]
	internal static bool LoadIAPItems(int serverId, int roleId, bool localized, int[] itemIds, long[] rebateIds)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x345BBB0", Offset = "0x345BBB0", VA = "0x345BBB0")]
	public static void SetLocale(string language, string region)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x345BD08", Offset = "0x345BD08", VA = "0x345BD08")]
	public static bool IsSupportIAP()
	{
		return default(bool);
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x3457C10", Offset = "0x3457C10", VA = "0x3457C10")]
	internal static bool IAP([Optional] string productIdentifier, long rebateId = 0L, int quantity = 1, int serverId = 0, int roleId = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x3458BDC", Offset = "0x3458BDC", VA = "0x3458BDC")]
	internal static bool RedeemRebate(int rebateId = 0, int serverId = 0, int roleId = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x345CC5C", Offset = "0x345CC5C", VA = "0x345CC5C")]
	public static bool ShouldScanIAPInventory()
	{
		return default(bool);
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x345CC64", Offset = "0x345CC64", VA = "0x345CC64")]
	internal static string ScanIAPInventory(int serverId = 0, int roleId = 0)
	{
		return null;
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x345CEC8", Offset = "0x345CEC8", VA = "0x345CEC8")]
	public static bool IsSupportEventIAP()
	{
		return default(bool);
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x3453240", Offset = "0x3453240", VA = "0x3453240")]
	internal static bool LoadEventConfigs(string region, bool activeOnly)
	{
		return default(bool);
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x3453B8C", Offset = "0x3453B8C", VA = "0x3453B8C")]
	internal static bool LoadEventIAPItems(string region, int serverId, int roleId, bool localized)
	{
		return default(bool);
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x3456F60", Offset = "0x3456F60", VA = "0x3456F60")]
	internal static bool EventIAP(string region, long eventId, [Optional] string productIdentifier, int quantity = 1, int serverId = 0, int roleId = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x345DE68", Offset = "0x345DE68", VA = "0x345DE68")]
	private static string UrlGet(string url, string key, string value)
	{
		return null;
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x345E0A0", Offset = "0x345E0A0", VA = "0x345E0A0")]
	private static string MShopClientType()
	{
		return null;
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x345E0FC", Offset = "0x345E0FC", VA = "0x345E0FC")]
	internal static string GetOriginalMShopUrl(bool production, string region)
	{
		return null;
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x345E8DC", Offset = "0x345E8DC", VA = "0x345E8DC")]
	internal static string GetMShopUrl(bool production, string region, string app_id, string access_token, int serverID, int roleID, bool embedded)
	{
		return null;
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x345F318", Offset = "0x345F318", VA = "0x345F318")]
	internal static string GetMShopUrl(bool production, string region, string language, string app_id, string access_token, int serverID, int roleID, bool embedded)
	{
		return null;
	}
}
