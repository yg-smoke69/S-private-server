using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GarenaMSDK;

[Token(Token = "0x2000043")]
public static class SDKIAP_Android
{
	[Serializable]
	[Token(Token = "0x2000044")]
	public enum TransactionStatus
	{
		[Token(Token = "0x40001AE")]
		Created = 6001,
		[Token(Token = "0x40001AF")]
		Opening,
		[Token(Token = "0x40001B0")]
		Opened,
		[Token(Token = "0x40001B1")]
		Processed,
		[Token(Token = "0x40001B2")]
		Closed,
		[Token(Token = "0x40001B3")]
		ClosedWithError
	}

	[Serializable]
	[Token(Token = "0x2000045")]
	public enum ResultCode
	{
		[Token(Token = "0x40001B5")]
		Success,
		[Token(Token = "0x40001B6")]
		Cancel,
		[Token(Token = "0x40001B7")]
		Error
	}

	[Serializable]
	[Token(Token = "0x2000046")]
	public class TransactionInfo
	{
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x8")]
		public int status;

		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0xC")]
		public int transactionStatus;

		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x10")]
		public int resultCode;

		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x14")]
		public int errorCode;

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x18")]
		public string transactionId;

		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x1C")]
		public string name;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x20")]
		public string icon;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x24")]
		public int appPoints;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x28")]
		public long rebateId;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x30")]
		public int remainingDays;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x34")]
		public string transactionError;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x38")]
		public string errorMessage;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x3C")]
		public int quantity;

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x34654F0", Offset = "0x34654F0", VA = "0x34654F0")]
		public TransactionInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000047")]
	public class RebateOptionItem
	{
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x8")]
		public long rebateId;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x10")]
		public int rebateAmount;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x14")]
		public int remainingDays;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x18")]
		public int rebateDays;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x1C")]
		public bool validToPurchase;

		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x1D")]
		public bool validToRedeem;

		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x1E")]
		public bool owned;

		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x24")]
		public string description;

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x346540C", Offset = "0x346540C", VA = "0x346540C")]
		public RebateOptionItem()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000048")]
	public class GetRebateOptionsResult
	{
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x8")]
		public int result;

		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0xC")]
		public RebateOptionItem[] options;

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x34653EC", Offset = "0x34653EC", VA = "0x34653EC")]
		public GetRebateOptionsResult()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000049")]
	public class RedeemResultItem
	{
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x8")]
		public long rebateId;

		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x10")]
		public int appPoint;

		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x14")]
		public int remainingDays;

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x34654C8", Offset = "0x34654C8", VA = "0x34654C8")]
		public RedeemResultItem()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200004A")]
	public class RedeemResponse
	{
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x8")]
		public int result;

		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0xC")]
		public int totalRedeemed;

		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x10")]
		public RedeemResultItem[] redeemList;

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x34654B8", Offset = "0x34654B8", VA = "0x34654B8")]
		public RedeemResponse()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200004B")]
	public class RedeemResult
	{
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x8")]
		public int result;

		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0xC")]
		public RedeemResponse response;

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x34654C0", Offset = "0x34654C0", VA = "0x34654C0")]
		public RedeemResult()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200004C")]
	public class Denomination
	{
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x8")]
		public int appPoints;

		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0xC")]
		public string iconUrl;

		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x10")]
		public bool isPromo;

		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x14")]
		public string itemId;

		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x1C")]
		public string price;

		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x20")]
		public int promoPoints;

		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x24")]
		public int rebateId;

		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x28")]
		public Subscription subscription;

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x34653CC", Offset = "0x34653CC", VA = "0x34653CC")]
		public Denomination()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200004D")]
	public class Subscription
	{
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x8")]
		public int period;

		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0xC")]
		public int status;

		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x10")]
		public int lastPaymentTime;

		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x18")]
		public long gracePeriodExpiryTime;

		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x20")]
		public long onHoldSince;

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x34654E8", Offset = "0x34654E8", VA = "0x34654E8")]
		public Subscription()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200004E")]
	public class Channel
	{
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x8")]
		public int category;

		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0xC")]
		public string name;

		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x10")]
		public string channelId;

		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x14")]
		public float discount;

		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x18")]
		public string description;

		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x1C")]
		public int flag;

		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x20")]
		public string iconUrl;

		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x24")]
		public Denomination[] items;

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x34653C4", Offset = "0x34653C4", VA = "0x34653C4")]
		public Channel()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200004F")]
	public class LoadPaymentOptionsResult
	{
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x8")]
		public Channel[] paymentChannels;

		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0xC")]
		public string exception;

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x34653FC", Offset = "0x34653FC", VA = "0x34653FC")]
		public LoadPaymentOptionsResult()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000050")]
	public class ScanGoogleIAPInventoryResult
	{
		[Serializable]
		[Token(Token = "0x2000051")]
		public class Result
		{
			[Serializable]
			[Token(Token = "0x2000052")]
			public class ItemInfo
			{
				[Token(Token = "0x40001F4")]
				[FieldOffset(Offset = "0x8")]
				public bool isPromotion;

				[Token(Token = "0x40001F5")]
				[FieldOffset(Offset = "0xC")]
				public string itemName;

				[Token(Token = "0x40001F6")]
				[FieldOffset(Offset = "0x10")]
				public int amount;

				[Token(Token = "0x40001F7")]
				[FieldOffset(Offset = "0x14")]
				public string itemSku;

				[Token(Token = "0x60001F2")]
				[Address(RVA = "0x34654E0", Offset = "0x34654E0", VA = "0x34654E0")]
				public ItemInfo()
				{
				}
			}

			[Token(Token = "0x40001F1")]
			[FieldOffset(Offset = "0x8")]
			public string error;

			[Token(Token = "0x40001F2")]
			[FieldOffset(Offset = "0xC")]
			public bool success;

			[Token(Token = "0x40001F3")]
			[FieldOffset(Offset = "0x10")]
			public ItemInfo item;

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x34654D8", Offset = "0x34654D8", VA = "0x34654D8")]
			public Result()
			{
			}
		}

		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x8")]
		public Result[] results;

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x34654D0", Offset = "0x34654D0", VA = "0x34654D0")]
		public ScanGoogleIAPInventoryResult()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000053")]
	public class EventConfigLessIsMore
	{
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x8")]
		public long rebate_id;

		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x10")]
		public long item_id;

		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x18")]
		public double price;

		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x20")]
		public string extra_info;

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x34653D4", Offset = "0x34653D4", VA = "0x34653D4")]
		public EventConfigLessIsMore()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000054")]
	public class EventLessIsMore
	{
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x8")]
		public long id;

		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x10")]
		public long start_time;

		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x18")]
		public long end_time;

		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x20")]
		public string region;

		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x24")]
		public string type;

		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x28")]
		public EventConfigLessIsMore[] configs;

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x34653DC", Offset = "0x34653DC", VA = "0x34653DC")]
		public EventLessIsMore()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000055")]
	public class LoadEventConfigsResult
	{
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x8")]
		public int result;

		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0xC")]
		public string exception;

		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x10")]
		public EventLessIsMore[] eventsLessIsMore;

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x34653F4", Offset = "0x34653F4", VA = "0x34653F4")]
		public LoadEventConfigsResult()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000056")]
	public class PricingEvent
	{
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x8")]
		public int id;

		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0xC")]
		public string type;

		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x10")]
		public long start_time;

		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x18")]
		public long end_time;

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x20")]
		public int available_times;

		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x24")]
		public int total_times;

		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x28")]
		public int status;

		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x2C")]
		public int[] items;

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x3465404", Offset = "0x3465404", VA = "0x3465404")]
		public PricingEvent()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000057")]
	public class GetEventsPricingResult
	{
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x8")]
		public int result;

		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0xC")]
		public string exception;

		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x10")]
		public Denomination[] paymentOptions;

		[Token(Token = "0x4000210")]
		[FieldOffset(Offset = "0x14")]
		public PricingEvent[] pricingEvents;

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x34653E4", Offset = "0x34653E4", VA = "0x34653E4")]
		public GetEventsPricingResult()
		{
		}
	}

	[Token(Token = "0x40001A6")]
	[FieldOffset(Offset = "0x0")]
	private static AndroidJavaClass _IAP;

	[Token(Token = "0x40001A7")]
	private const string PAYMENT_CHANNEL_ID_GOOGLE_PLAY = "201069";

	[Token(Token = "0x40001A8")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<long, string> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40001A9")]
	[FieldOffset(Offset = "0x8")]
	private static Converter<RebateOptionItem, SDKIAP.RebateOption> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x40001AA")]
	[FieldOffset(Offset = "0xC")]
	private static Converter<int, string> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x40001AB")]
	[FieldOffset(Offset = "0x10")]
	private static Converter<long, string> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x40001AC")]
	[FieldOffset(Offset = "0x14")]
	private static Converter<RedeemResultItem, SDKIAP.RebateRedeemResult> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x17000057")]
	public static AndroidJavaClass IAP
	{
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x3464FEC", Offset = "0x3464FEC", VA = "0x3464FEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000058")]
	private static string PaymentChannelID
	{
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x34650AC", Offset = "0x34650AC", VA = "0x34650AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x345BD0C", Offset = "0x345BD0C", VA = "0x345BD0C")]
	public static bool IsGooglePlayServicesAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x345BBB4", Offset = "0x345BBB4", VA = "0x345BBB4")]
	public static void SetLocale(string language, string region)
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x345A248", Offset = "0x345A248", VA = "0x345A248")]
	public static void GetRebateOptions(int serverId, int roleId)
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x345A49C", Offset = "0x345A49C", VA = "0x345A49C")]
	public static void GetRebateOptions(int serverId, int roleId, long[] rebateIds)
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x3450310", Offset = "0x3450310", VA = "0x3450310")]
	public static void OnGetRebateOptions(string getRebateOptionsResult)
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x345A8BC", Offset = "0x345A8BC", VA = "0x345A8BC")]
	public static void ClearIAPItems()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x345A958", Offset = "0x345A958", VA = "0x345A958")]
	public static bool LoadPaymentOptions(int serverId, int roleId, string virtualCurrencyName, bool allItems, long rebateId, bool localizedPrice)
	{
		return default(bool);
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x345B250", Offset = "0x345B250", VA = "0x345B250")]
	public static bool LoadPaymentOptions(int serverId, int roleId, string virtualCurrencyName, bool localizedPrice, int[] itemIds, long[] rebateIds)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x3450A48", Offset = "0x3450A48", VA = "0x3450A48")]
	public static void OnPaymentOptionsLoaded(string result)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x345BDB4", Offset = "0x345BDB4", VA = "0x345BDB4")]
	public static bool ProcessPaymentWithChannelItem(int serverId, int roleId, string virtualCurrencyName, string itemIdentifier)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x345C3CC", Offset = "0x345C3CC", VA = "0x345C3CC")]
	public static bool ProcessPayment(int serverId, int roleId, string virtualCurrencyName, long rebateId)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x3450F68", Offset = "0x3450F68", VA = "0x3450F68")]
	public static void OnPaymentProcessed_Exception(string transactionInfo)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x34511C0", Offset = "0x34511C0", VA = "0x34511C0")]
	public static void OnPaymentProcessed(string transactionInfo)
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x345C960", Offset = "0x345C960", VA = "0x345C960")]
	public static void Redeem(long rebateId = 0L, int serverId = 0, int roleId = 0)
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x3450664", Offset = "0x3450664", VA = "0x3450664")]
	public static void OnRedeemed(string redeemResult)
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x345CC68", Offset = "0x345CC68", VA = "0x345CC68")]
	public static string ScanGoogleIAPInventory(int serverId, int roleId)
	{
		return null;
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x3451418", Offset = "0x3451418", VA = "0x3451418")]
	public static void OnScanGoogleIAPInventoryResult(string result)
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x345CED0", Offset = "0x345CED0", VA = "0x345CED0")]
	public static bool LoadEventConfigs(string region, bool activeOnly)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x3451B68", Offset = "0x3451B68", VA = "0x3451B68")]
	internal static void OnLoadEventConfigsResult(string str)
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x345D19C", Offset = "0x345D19C", VA = "0x345D19C")]
	public static bool LoadEventPaymentOptions(string region, int serverId, int roleId, string virtualCurrencyName, bool localizedPrice)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x3451DDC", Offset = "0x3451DDC", VA = "0x3451DDC")]
	internal static void OnEventPaymentOptionsLoaded(string str)
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x345D79C", Offset = "0x345D79C", VA = "0x345D79C")]
	public static bool ProcessEventPayment(string region, string itemId, string eventId, int serverId, int roleId, string virtualCurrencyName)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x3452050", Offset = "0x3452050", VA = "0x3452050")]
	internal static void OnEventPaymentProcessed_Exception(string str)
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x34522A8", Offset = "0x34522A8", VA = "0x34522A8")]
	internal static void OnEventPaymentProcessed(string str)
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x3465108", Offset = "0x3465108", VA = "0x3465108")]
	private static string _003CGetRebateOptions_003Em__0(long id)
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x3465128", Offset = "0x3465128", VA = "0x3465128")]
	private static SDKIAP.RebateOption _003COnGetRebateOptions_003Em__1(RebateOptionItem input)
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x34652A4", Offset = "0x34652A4", VA = "0x34652A4")]
	private static string _003CLoadPaymentOptions_003Em__2(int id)
	{
		return null;
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x34652C8", Offset = "0x34652C8", VA = "0x34652C8")]
	private static string _003CLoadPaymentOptions_003Em__3(long id)
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x34652E8", Offset = "0x34652E8", VA = "0x34652E8")]
	private static SDKIAP.RebateRedeemResult _003COnRedeemed_003Em__4(RedeemResultItem input)
	{
		return null;
	}
}
