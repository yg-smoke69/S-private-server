using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using GarenaMSDK;
using Il2CppDummyDll;
using UnityEngine;
using tcp;

namespace COW;

[Token(Token = "0x2002D69")]
public static class PayUtility
{
	[Token(Token = "0x2002D6A")]
	public abstract class PaymentDelegate
	{
		[Token(Token = "0x2002D6B")]
		public class ProductPurchasedReaction
		{
			[Token(Token = "0x40116EA")]
			[FieldOffset(Offset = "0x8")]
			public bool UpdateRebateOption;

			[Token(Token = "0x40116EB")]
			[FieldOffset(Offset = "0x9")]
			public bool UpdateProduct;

			[Token(Token = "0x601307E")]
			[Address(RVA = "0x2DC0AC4", Offset = "0x2DC0AC4", VA = "0x2DC0AC4")]
			public ProductPurchasedReaction()
			{
			}
		}

		[Token(Token = "0x2002D6C")]
		public class ProductPurchasedResult
		{
			[Token(Token = "0x40116EC")]
			[FieldOffset(Offset = "0x8")]
			public bool IsOK;

			[Token(Token = "0x40116ED")]
			[FieldOffset(Offset = "0xC")]
			public ErrorCode Code;

			[Token(Token = "0x40116EE")]
			[FieldOffset(Offset = "0x10")]
			public string Msg;

			[Token(Token = "0x601307F")]
			[Address(RVA = "0x2DBFB70", Offset = "0x2DBFB70", VA = "0x2DBFB70")]
			public ProductPurchasedResult()
			{
			}
		}

		[Token(Token = "0x40116E5")]
		[FieldOffset(Offset = "0x8")]
		private string[] _003CProductsInDemand_003Ek__BackingField;

		[Token(Token = "0x40116E6")]
		[FieldOffset(Offset = "0xC")]
		private long[] _003CRebateOptionsInDemand_003Ek__BackingField;

		[Token(Token = "0x40116E7")]
		[FieldOffset(Offset = "0x10")]
		private bool _003CEventProductsInDemand_003Ek__BackingField;

		[Token(Token = "0x40116E8")]
		[FieldOffset(Offset = "0x14")]
		protected Action<bool, string, bool, long> _OnPurchasingProduct;

		[Token(Token = "0x40116E9")]
		[FieldOffset(Offset = "0x18")]
		protected Action<bool, string, long> _OnPurchasingRebateOption;

		[Token(Token = "0x17001377")]
		public abstract string Name
		{
			[Token(Token = "0x6013061")]
			get;
		}

		[Token(Token = "0x17001378")]
		public virtual string[] ProductsInDemand
		{
			[Token(Token = "0x6013062")]
			[Address(RVA = "0x2DDBB14", Offset = "0x2DDBB14", VA = "0x2DDBB14", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6013063")]
			[Address(RVA = "0x2DDBB1C", Offset = "0x2DDBB1C", VA = "0x2DDBB1C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17001379")]
		public virtual long[] RebateOptionsInDemand
		{
			[Token(Token = "0x6013064")]
			[Address(RVA = "0x2DDBB24", Offset = "0x2DDBB24", VA = "0x2DDBB24", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6013065")]
			[Address(RVA = "0x2DDBB2C", Offset = "0x2DDBB2C", VA = "0x2DDBB2C", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700137A")]
		public virtual string EventTypeInDemand
		{
			[Token(Token = "0x6013066")]
			[Address(RVA = "0x2DDBB34", Offset = "0x2DDBB34", VA = "0x2DDBB34", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700137B")]
		public virtual bool EventProductsInDemand
		{
			[Token(Token = "0x6013067")]
			[Address(RVA = "0x2DDBC0C", Offset = "0x2DDBC0C", VA = "0x2DDBC0C", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6013068")]
			[Address(RVA = "0x2DDBC14", Offset = "0x2DDBC14", VA = "0x2DDBC14", Slot = "11")]
			protected set
			{
			}
		}

		[Token(Token = "0x6013060")]
		[Address(RVA = "0x2DDBB0C", Offset = "0x2DDBB0C", VA = "0x2DDBB0C")]
		protected PaymentDelegate()
		{
		}

		[Token(Token = "0x6013069")]
		[Address(RVA = "0x2DDBC1C", Offset = "0x2DDBC1C", VA = "0x2DDBC1C", Slot = "12")]
		public virtual void OnEventConfigsUpdated(string reason, bool result)
		{
		}

		[Token(Token = "0x601306A")]
		[Address(RVA = "0x2DDBC8C", Offset = "0x2DDBC8C", VA = "0x2DDBC8C", Slot = "13")]
		public virtual void OnProductsUpdated(string reason, bool result, string[] productIdentifiers)
		{
		}

		[Token(Token = "0x601306B")]
		[Address(RVA = "0x2DDBFC4", Offset = "0x2DDBFC4", VA = "0x2DDBFC4", Slot = "14")]
		public virtual void OnEventProductsAndDataUpdate(string reason, bool result)
		{
		}

		[Token(Token = "0x601306C")]
		[Address(RVA = "0x2DDC034", Offset = "0x2DDC034", VA = "0x2DDC034")]
		protected Dictionary<long, SDKIAP.Event> GetEventConfigs()
		{
			return null;
		}

		[Token(Token = "0x601306D")]
		[Address(RVA = "0x2DDC16C", Offset = "0x2DDC16C", VA = "0x2DDC16C")]
		protected Dictionary<long, SDKIAP.EventDatum> GetEventData()
		{
			return null;
		}

		[Token(Token = "0x601306E")]
		[Address(RVA = "0x2DDC2A4", Offset = "0x2DDC2A4", VA = "0x2DDC2A4", Slot = "15")]
		public virtual void OnRebateOptionsUpdated(string reason, bool result, long[] rebateIds)
		{
		}

		[Token(Token = "0x601306F")]
		[Address(RVA = "0x2DDC318", Offset = "0x2DDC318", VA = "0x2DDC318", Slot = "16")]
		public virtual ProductPurchasedReaction OnProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, long rebateId, int quantity)
		{
			return null;
		}

		[Token(Token = "0x6013070")]
		[Address(RVA = "0x2DDC3B4", Offset = "0x2DDC3B4", VA = "0x2DDC3B4", Slot = "17")]
		public virtual bool OnEventProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, int quantity)
		{
			return default(bool);
		}

		[Token(Token = "0x6013071")]
		[Address(RVA = "0x2DDC438", Offset = "0x2DDC438", VA = "0x2DDC438", Slot = "18")]
		public virtual void OnPurchasing(string reason, bool willPurchase, string productIdentifier, long rebateId, bool isEvent, long eventId)
		{
		}

		[Token(Token = "0x6013072")]
		[Address(RVA = "0x2DDC594", Offset = "0x2DDC594", VA = "0x2DDC594", Slot = "19")]
		public virtual bool PaymentAfterRecommitted(int pendingProduct, int[] recommittedProducts)
		{
			return default(bool);
		}

		[Token(Token = "0x6013073")]
		[Address(RVA = "0x2DDC610", Offset = "0x2DDC610", VA = "0x2DDC610", Slot = "20")]
		public virtual bool OnRebateOptionRedeemed(string reason, bool result, RebateOptionRedeemResult redeemResult)
		{
			return default(bool);
		}

		[Token(Token = "0x6013074")]
		[Address(RVA = "0x2DDBD88", Offset = "0x2DDBD88", VA = "0x2DDBD88")]
		public bool LackProducts(bool logVerbose = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6013075")]
		[Address(RVA = "0x2DDC690", Offset = "0x2DDC690", VA = "0x2DDC690")]
		public bool LackRebateOptions()
		{
			return default(bool);
		}

		[Token(Token = "0x6013076")]
		[Address(RVA = "0x2DDC838", Offset = "0x2DDC838", VA = "0x2DDC838", Slot = "21")]
		public virtual bool UpdateProducts(string reason)
		{
			return default(bool);
		}

		[Token(Token = "0x6013077")]
		[Address(RVA = "0x2DDCA10", Offset = "0x2DDCA10", VA = "0x2DDCA10", Slot = "22")]
		public virtual bool UpdateRebateOptions(string reason)
		{
			return default(bool);
		}

		[Token(Token = "0x6013078")]
		[Address(RVA = "0x2DDCBCC", Offset = "0x2DDCBCC", VA = "0x2DDCBCC")]
		public void PurchaseProduct(string reason, string productIdentifier, bool isEvent = false, long eventId = 0L, [Optional] Action<bool, string, bool, long> onPurchasing)
		{
		}

		[Token(Token = "0x6013079")]
		[Address(RVA = "0x2DDCD58", Offset = "0x2DDCD58", VA = "0x2DDCD58")]
		public void PurchaseRebateOption(string reason, string productIdentifier, long rebateId, [Optional] Action<bool, string, long> onPurchasing)
		{
		}

		[Token(Token = "0x601307A")]
		[Address(RVA = "0x2DDCEC8", Offset = "0x2DDCEC8", VA = "0x2DDCEC8")]
		protected bool _DemandUpdateEventConfigs(string reason)
		{
			return default(bool);
		}

		[Token(Token = "0x601307B")]
		[Address(RVA = "0x2DDC8A4", Offset = "0x2DDC8A4", VA = "0x2DDC8A4")]
		protected bool _DemandUpdateProducts(string reason)
		{
			return default(bool);
		}

		[Token(Token = "0x601307C")]
		[Address(RVA = "0x2DDD038", Offset = "0x2DDD038", VA = "0x2DDD038")]
		protected bool _DemandUpdateEventProducts(string reason)
		{
			return default(bool);
		}

		[Token(Token = "0x601307D")]
		[Address(RVA = "0x2DDCA7C", Offset = "0x2DDCA7C", VA = "0x2DDCA7C")]
		protected bool _DemandUpdateRebateOptions(string reason)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002D6D")]
	private enum E_MShopFallbackStrategy
	{
		[Token(Token = "0x40116F0")]
		None,
		[Token(Token = "0x40116F1")]
		WebView,
		[Token(Token = "0x40116F2")]
		Browser,
		[Token(Token = "0x40116F3")]
		Double
	}

	[Token(Token = "0x2002D6E")]
	public class SubscriptionSwitch
	{
		[Token(Token = "0x40116F4")]
		public const int Off = 0;

		[Token(Token = "0x40116F5")]
		public const int On = 1;

		[Token(Token = "0x40116F6")]
		public const int Subscribed = 2;

		[Token(Token = "0x6013080")]
		[Address(RVA = "0x2DDD174", Offset = "0x2DDD174", VA = "0x2DDD174")]
		public SubscriptionSwitch()
		{
		}

		[Token(Token = "0x6013081")]
		[Address(RVA = "0x2DDD17C", Offset = "0x2DDD17C", VA = "0x2DDD17C")]
		public static int GetSubscriptionSwitch(string gameVarDefRegions)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2002D6F")]
	public class SubscriptionGracePeriodReminderInfo
	{
		[Token(Token = "0x40116F7")]
		[FieldOffset(Offset = "0x8")]
		public Action<SubscriptionGracePeriodReminderInfo> OnConfirm;

		[Token(Token = "0x40116F8")]
		[FieldOffset(Offset = "0xC")]
		public Action<SubscriptionGracePeriodReminderInfo> OnCancel;

		[Token(Token = "0x6013082")]
		[Address(RVA = "0x2DDD16C", Offset = "0x2DDD16C", VA = "0x2DDD16C")]
		public SubscriptionGracePeriodReminderInfo()
		{
		}
	}

	[Token(Token = "0x2002D70")]
	public struct SubscriptionHintOption
	{
		[Token(Token = "0x40116F9")]
		[FieldOffset(Offset = "0x0")]
		public Subscription Subscription;

		[Token(Token = "0x40116FA")]
		[FieldOffset(Offset = "0x4")]
		public Vector3 Position;

		[Token(Token = "0x40116FB")]
		[FieldOffset(Offset = "0x10")]
		public string LocKey_Title;

		[Token(Token = "0x40116FC")]
		[FieldOffset(Offset = "0x14")]
		public string LocKey_LastPaymentTime;

		[Token(Token = "0x40116FD")]
		[FieldOffset(Offset = "0x18")]
		public string LocKey_NextPaymentTime;

		[Token(Token = "0x40116FE")]
		[FieldOffset(Offset = "0x1C")]
		public string LocKey_Cancel;
	}

	[Token(Token = "0x2002D71")]
	public class RebateOptionRedeemResult
	{
		[Token(Token = "0x40116FF")]
		[FieldOffset(Offset = "0x8")]
		public long RebateID;

		[Token(Token = "0x4011700")]
		[FieldOffset(Offset = "0x10")]
		public int RemainingDays;

		[Token(Token = "0x4011701")]
		[FieldOffset(Offset = "0x14")]
		public int RedeemAmount;

		[Token(Token = "0x6013083")]
		[Address(RVA = "0x2DD8284", Offset = "0x2DD8284", VA = "0x2DD8284")]
		public RebateOptionRedeemResult()
		{
		}
	}

	[Token(Token = "0x2002D72")]
	private sealed class _003CShowPaymentFailureMessageBox_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011702")]
		[FieldOffset(Offset = "0x8")]
		internal Action onCancel;

		[Token(Token = "0x6013084")]
		[Address(RVA = "0x2DD0044", Offset = "0x2DD0044", VA = "0x2DD0044")]
		public _003CShowPaymentFailureMessageBox_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6013085")]
		[Address(RVA = "0x2DDBA7C", Offset = "0x2DDBA7C", VA = "0x2DDBA7C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002D73")]
	private sealed class _003COnPurchasedProduct_003Ec__AnonStorey1
	{
		[Token(Token = "0x4011703")]
		[FieldOffset(Offset = "0x8")]
		internal SDKIAPTaskInfo info;

		[Token(Token = "0x4011704")]
		[FieldOffset(Offset = "0xC")]
		internal SDKIAPTaskResult result;

		[Token(Token = "0x4011705")]
		[FieldOffset(Offset = "0x10")]
		internal bool isEvent;

		[Token(Token = "0x4011706")]
		[FieldOffset(Offset = "0x14")]
		internal string item_identifier;

		[Token(Token = "0x4011707")]
		[FieldOffset(Offset = "0x18")]
		internal int quantity;

		[Token(Token = "0x6013086")]
		[Address(RVA = "0x2DD4428", Offset = "0x2DD4428", VA = "0x2DD4428")]
		public _003COnPurchasedProduct_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6013087")]
		[Address(RVA = "0x2DDB83C", Offset = "0x2DDB83C", VA = "0x2DDB83C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002D74")]
	private sealed class _003CPromptOnInsufficientDiamonds_003Ec__AnonStorey2
	{
		[Token(Token = "0x4011708")]
		[FieldOffset(Offset = "0x8")]
		internal UINavigationUtil.UINavigationFrom from;

		[Token(Token = "0x6013088")]
		[Address(RVA = "0x2DD58F4", Offset = "0x2DD58F4", VA = "0x2DD58F4")]
		public _003CPromptOnInsufficientDiamonds_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6013089")]
		[Address(RVA = "0x2DDB8F8", Offset = "0x2DDB8F8", VA = "0x2DDB8F8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002D75")]
	private sealed class _003COnPurchaseRebateItemFailure_003Ec__AnonStorey3
	{
		[Token(Token = "0x4011709")]
		[FieldOffset(Offset = "0x8")]
		internal SDKIAPTaskInfo info;

		[Token(Token = "0x401170A")]
		[FieldOffset(Offset = "0xC")]
		internal SDKIAPTaskResult result;

		[Token(Token = "0x401170B")]
		[FieldOffset(Offset = "0x10")]
		internal string display_item_identifier;

		[Token(Token = "0x401170C")]
		[FieldOffset(Offset = "0x18")]
		internal long display_rebate_id;

		[Token(Token = "0x401170D")]
		[FieldOffset(Offset = "0x20")]
		internal SDKIAPManager.RebateOptionPurchaseResult purchaseResult;

		[Token(Token = "0x601308A")]
		[Address(RVA = "0x2DD6BFC", Offset = "0x2DD6BFC", VA = "0x2DD6BFC")]
		public _003COnPurchaseRebateItemFailure_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x601308B")]
		[Address(RVA = "0x2DDB77C", Offset = "0x2DDB77C", VA = "0x2DDB77C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x40116A4")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly DateTime APOCH_UTC;

	[Token(Token = "0x40116A5")]
	[FieldOffset(Offset = "0x10")]
	private static bool _Inited;

	[Token(Token = "0x40116A6")]
	private const string IAP_ITEM_IDENTIFIER_TEMPLATE_GOOGLE_PLAY = "freefiremax.diamond.{0}";

	[Token(Token = "0x40116A7")]
	[FieldOffset(Offset = "0x14")]
	private static Dictionary<string, PaymentDelegate> _PaymentDelegates;

	[Token(Token = "0x40116A8")]
	[FieldOffset(Offset = "0x18")]
	private static bool _003CScanningIAPInventory_003Ek__BackingField;

	[Token(Token = "0x40116A9")]
	[FieldOffset(Offset = "0x1C")]
	public static readonly AES.AESOption MshopAesOption;

	[Token(Token = "0x40116AA")]
	[FieldOffset(Offset = "0x20")]
	private static Dictionary<string, PayItemData> _FetchedProductsByIdentifier;

	[Token(Token = "0x40116AB")]
	[FieldOffset(Offset = "0x24")]
	private static Dictionary<string, PayItemData> _FetchedEventProductsByIdentifier;

	[Token(Token = "0x40116AC")]
	[FieldOffset(Offset = "0x28")]
	private static Dictionary<string, Dictionary<long, SDKIAP.Event>> _FetchedEventConfigs;

	[Token(Token = "0x40116AD")]
	[FieldOffset(Offset = "0x2C")]
	private static Dictionary<string, Dictionary<long, SDKIAP.EventDatum>> _FetchedEventData;

	[Token(Token = "0x40116AE")]
	[FieldOffset(Offset = "0x30")]
	private static Dictionary<long, RebateItemData> _RebateItems;

	[Token(Token = "0x40116AF")]
	[FieldOffset(Offset = "0x34")]
	private static PaymentAction _003C_LastPaymentAction_003Ek__BackingField;

	[Token(Token = "0x40116B0")]
	[FieldOffset(Offset = "0x38")]
	private static PaymentAction _003C_PendingPaymentAction_003Ek__BackingField;

	[Token(Token = "0x40116B1")]
	[FieldOffset(Offset = "0x3C")]
	private static string _003CLastPaymentProductIdentifier_003Ek__BackingField;

	[Token(Token = "0x40116B2")]
	[FieldOffset(Offset = "0x40")]
	private static bool _003CIsLoggedIn_003Ek__BackingField;

	[Token(Token = "0x40116B3")]
	[FieldOffset(Offset = "0x44")]
	private static SDKType LastSDKType;

	[Token(Token = "0x40116B4")]
	[FieldOffset(Offset = "0x48")]
	private static string LastSDKID;

	[Token(Token = "0x40116B5")]
	[FieldOffset(Offset = "0x4C")]
	private static bool SDKAccountChanged;

	[Token(Token = "0x40116B6")]
	private const string PLAYER_PREFS_KEY_OFFLINE_TRANSACTIONS = "OfflineTransactions";

	[Token(Token = "0x40116B7")]
	[FieldOffset(Offset = "0x50")]
	private static Dictionary<int, string> _PaymentErrorCodeToLocKey;

	[Token(Token = "0x40116B8")]
	private const int SecondsInDay = 86400;

	[Token(Token = "0x40116B9")]
	private const int RebateRedeemResetSecondsInDay_UTC = 68400;

	[Token(Token = "0x40116BA")]
	[FieldOffset(Offset = "0x54")]
	private static SDKIAP.LogCallback _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x40116BB")]
	[FieldOffset(Offset = "0x58")]
	private static SDKIAP.LogCallback _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x40116BC")]
	[FieldOffset(Offset = "0x5C")]
	private static SDKIAP.LogCallback _003C_003Ef__mg_0024cache2;

	[Token(Token = "0x40116BD")]
	[FieldOffset(Offset = "0x60")]
	private static Converter<CSVBaseData, PlatformPromotionProductsData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40116BE")]
	[FieldOffset(Offset = "0x64")]
	private static Action<SDKIAPTaskInfo, SDKIAP.ScanIAPInventoryResult[]> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x40116BF")]
	[FieldOffset(Offset = "0x68")]
	private static Action _003C_003Ef__mg_0024cache3;

	[Token(Token = "0x40116C0")]
	[FieldOffset(Offset = "0x6C")]
	private static Action _003C_003Ef__am_0024cache2;

	[Token(Token = "0x40116C1")]
	[FieldOffset(Offset = "0x70")]
	private static Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.IAPItem[]> _003C_003Ef__mg_0024cache4;

	[Token(Token = "0x40116C2")]
	[FieldOffset(Offset = "0x74")]
	private static Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.IAPItem[]> _003C_003Ef__mg_0024cache5;

	[Token(Token = "0x40116C3")]
	[FieldOffset(Offset = "0x78")]
	private static Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.IAPItem[]> _003C_003Ef__mg_0024cache6;

	[Token(Token = "0x40116C4")]
	[FieldOffset(Offset = "0x7C")]
	private static Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.IAPItem[]> _003C_003Ef__mg_0024cache7;

	[Token(Token = "0x40116C5")]
	[FieldOffset(Offset = "0x80")]
	private static Converter<string, int> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x40116C6")]
	[FieldOffset(Offset = "0x84")]
	private static Converter<int, string> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x40116C7")]
	[FieldOffset(Offset = "0x88")]
	private static Converter<long, string> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x40116C8")]
	[FieldOffset(Offset = "0x8C")]
	private static Converter<SDKIAP.IAPItem, string> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x40116C9")]
	[FieldOffset(Offset = "0x90")]
	private static Converter<SDKIAP.IAPItem, string> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x40116CA")]
	[FieldOffset(Offset = "0x94")]
	private static Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.LoadEventConfigsResult> _003C_003Ef__mg_0024cache8;

	[Token(Token = "0x40116CB")]
	[FieldOffset(Offset = "0x98")]
	private static Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.LoadEventIAPResult> _003C_003Ef__mg_0024cache9;

	[Token(Token = "0x40116CC")]
	[FieldOffset(Offset = "0x9C")]
	private static Converter<SDKIAP.IAPItem, string> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x40116CD")]
	[FieldOffset(Offset = "0xA0")]
	private static Converter<SDKIAP.EventDatum, string> _003C_003Ef__am_0024cache9;

	[Token(Token = "0x40116CE")]
	[FieldOffset(Offset = "0xA4")]
	private static Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.RebateOption[]> _003C_003Ef__mg_0024cacheA;

	[Token(Token = "0x40116CF")]
	[FieldOffset(Offset = "0xA8")]
	private static Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.RebateOption[]> _003C_003Ef__mg_0024cacheB;

	[Token(Token = "0x40116D0")]
	[FieldOffset(Offset = "0xAC")]
	private static Converter<SDKIAP.RebateOption, string> _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x40116D1")]
	[FieldOffset(Offset = "0xB0")]
	private static Converter<SDKIAP.RebateOption, long> _003C_003Ef__am_0024cacheB;

	[Token(Token = "0x40116D2")]
	[FieldOffset(Offset = "0xB4")]
	private static Action _003C_003Ef__am_0024cacheC;

	[Token(Token = "0x40116D3")]
	[FieldOffset(Offset = "0xB8")]
	private static Action _003C_003Ef__am_0024cacheD;

	[Token(Token = "0x40116D4")]
	[FieldOffset(Offset = "0xBC")]
	private static Action<SDKIAPTaskInfo, SDKIAP.ScanIAPInventoryResult[]> _003C_003Ef__am_0024cacheE;

	[Token(Token = "0x40116D5")]
	[FieldOffset(Offset = "0xC0")]
	private static Action _003C_003Ef__am_0024cacheF;

	[Token(Token = "0x40116D6")]
	[FieldOffset(Offset = "0xC4")]
	private static Converter<string, int> _003C_003Ef__am_0024cache10;

	[Token(Token = "0x40116D7")]
	[FieldOffset(Offset = "0xC8")]
	private static Action _003C_003Ef__am_0024cache11;

	[Token(Token = "0x40116D8")]
	[FieldOffset(Offset = "0xCC")]
	private static Action<SDKIAPTaskInfo, SDKIAPTaskResult, string, int> _003C_003Ef__mg_0024cacheC;

	[Token(Token = "0x40116D9")]
	[FieldOffset(Offset = "0xD0")]
	private static Action<SDKIAPTaskInfo, SDKIAPTaskResult, string> _003C_003Ef__mg_0024cacheD;

	[Token(Token = "0x40116DA")]
	[FieldOffset(Offset = "0xD4")]
	private static Action<SDKIAPTaskInfo, SDKIAPTaskResult, string, int> _003C_003Ef__mg_0024cacheE;

	[Token(Token = "0x40116DB")]
	[FieldOffset(Offset = "0xD8")]
	private static Action<SDKIAPTaskInfo, SDKIAPTaskResult, string> _003C_003Ef__mg_0024cacheF;

	[Token(Token = "0x40116DC")]
	[FieldOffset(Offset = "0xDC")]
	private static Action _003C_003Ef__am_0024cache12;

	[Token(Token = "0x40116DD")]
	[FieldOffset(Offset = "0xE0")]
	private static Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAPManager.RebateOptionPurchaseResult> _003C_003Ef__mg_0024cache10;

	[Token(Token = "0x40116DE")]
	[FieldOffset(Offset = "0xE4")]
	private static Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAPManager.RebateOptionPurchaseResult> _003C_003Ef__mg_0024cache11;

	[Token(Token = "0x40116DF")]
	[FieldOffset(Offset = "0xE8")]
	private static Action<SDKIAPTaskInfo, SDKIAPTaskResult, SDKIAP.RebateRedeemResult[]> _003C_003Ef__mg_0024cache12;

	[Token(Token = "0x40116E0")]
	[FieldOffset(Offset = "0xEC")]
	private static Converter<int, string> _003C_003Ef__am_0024cache13;

	[Token(Token = "0x40116E1")]
	[FieldOffset(Offset = "0xF0")]
	private static Action _003C_003Ef__am_0024cache14;

	[Token(Token = "0x40116E2")]
	[FieldOffset(Offset = "0xF4")]
	private static Func<SDKIAP.ScanIAPInventoryResult, bool> _003C_003Ef__am_0024cache15;

	[Token(Token = "0x40116E3")]
	[FieldOffset(Offset = "0xF8")]
	private static Func<SDKIAP.ScanIAPInventoryResult, bool> _003C_003Ef__am_0024cache16;

	[Token(Token = "0x40116E4")]
	[FieldOffset(Offset = "0xFC")]
	private static Converter<SDKIAP.ScanIAPInventoryResult, string> _003C_003Ef__am_0024cache17;

	[Token(Token = "0x1700136B")]
	private static string IAPItemIdentifierTemplate
	{
		[Token(Token = "0x6012FDD")]
		[Address(RVA = "0x2DBE4B8", Offset = "0x2DBE4B8", VA = "0x2DBE4B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700136C")]
	public static bool ShouldRecommitBeforePayment
	{
		[Token(Token = "0x6012FDE")]
		[Address(RVA = "0x2DBE554", Offset = "0x2DBE554", VA = "0x2DBE554")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700136D")]
	public static bool ScanningIAPInventory
	{
		[Token(Token = "0x6012FE8")]
		[Address(RVA = "0x2DC22B0", Offset = "0x2DC22B0", VA = "0x2DC22B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6012FE9")]
		[Address(RVA = "0x2DC233C", Offset = "0x2DC233C", VA = "0x2DC233C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700136E")]
	private static E_MShopFallbackStrategy MShopFallbackStrategy
	{
		[Token(Token = "0x6012FEE")]
		[Address(RVA = "0x2DC44C0", Offset = "0x2DC44C0", VA = "0x2DC44C0")]
		get
		{
			return default(E_MShopFallbackStrategy);
		}
	}

	[Token(Token = "0x1700136F")]
	private static bool PreferExternalUnityPaymentShop
	{
		[Token(Token = "0x6012FF0")]
		[Address(RVA = "0x2DC50F0", Offset = "0x2DC50F0", VA = "0x2DC50F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001370")]
	public static Dictionary<long, RebateItemData> RebateItems
	{
		[Token(Token = "0x6012FF9")]
		[Address(RVA = "0x2DC5818", Offset = "0x2DC5818", VA = "0x2DC5818")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001371")]
	private static PaymentAction _LastPaymentAction
	{
		[Token(Token = "0x6012FFA")]
		[Address(RVA = "0x2DC58E8", Offset = "0x2DC58E8", VA = "0x2DC58E8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6012FFB")]
		[Address(RVA = "0x2DC5974", Offset = "0x2DC5974", VA = "0x2DC5974")]
		set
		{
		}
	}

	[Token(Token = "0x17001372")]
	private static PaymentAction _PendingPaymentAction
	{
		[Token(Token = "0x6012FFC")]
		[Address(RVA = "0x2DC5A04", Offset = "0x2DC5A04", VA = "0x2DC5A04")]
		get
		{
			return null;
		}
		[Token(Token = "0x6012FFD")]
		[Address(RVA = "0x2DC5A90", Offset = "0x2DC5A90", VA = "0x2DC5A90")]
		set
		{
		}
	}

	[Token(Token = "0x17001373")]
	public static string LastPaymentProductIdentifier
	{
		[Token(Token = "0x6012FFE")]
		[Address(RVA = "0x2DC0ACC", Offset = "0x2DC0ACC", VA = "0x2DC0ACC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6012FFF")]
		[Address(RVA = "0x2DC5B20", Offset = "0x2DC5B20", VA = "0x2DC5B20")]
		private set
		{
		}
	}

	[Token(Token = "0x17001374")]
	public static bool IsLoggedIn
	{
		[Token(Token = "0x6013000")]
		[Address(RVA = "0x2DC2164", Offset = "0x2DC2164", VA = "0x2DC2164")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6013001")]
		[Address(RVA = "0x2DC5BB0", Offset = "0x2DC5BB0", VA = "0x2DC5BB0")]
		private set
		{
		}
	}

	[Token(Token = "0x17001375")]
	public static bool Pending
	{
		[Token(Token = "0x601300D")]
		[Address(RVA = "0x2DC6BD0", Offset = "0x2DC6BD0", VA = "0x2DC6BD0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001376")]
	private static bool ShowIAPFailureSignature
	{
		[Token(Token = "0x6013038")]
		[Address(RVA = "0x2DCEDC8", Offset = "0x2DCEDC8", VA = "0x2DCEDC8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6012FD9")]
	[Address(RVA = "0x2DBE0C4", Offset = "0x2DBE0C4", VA = "0x2DBE0C4")]
	internal static DateTime SecondsAfterApoch(long seconds)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6012FDA")]
	[Address(RVA = "0x2DBE1F0", Offset = "0x2DBE1F0", VA = "0x2DBE1F0")]
	public static string USD(float price)
	{
		return null;
	}

	[Token(Token = "0x6012FDB")]
	[Address(RVA = "0x2DBE308", Offset = "0x2DBE308", VA = "0x2DBE308")]
	public static string USD(string price)
	{
		return null;
	}

	[Token(Token = "0x6012FDC")]
	[Address(RVA = "0x2DBE3E4", Offset = "0x2DBE3E4", VA = "0x2DBE3E4")]
	private static void Uninit()
	{
	}

	[Token(Token = "0x6012FDF")]
	[Address(RVA = "0x2DBE888", Offset = "0x2DBE888", VA = "0x2DBE888")]
	private static void Init(int serverID = 0)
	{
	}

	[Token(Token = "0x6012FE0")]
	[Address(RVA = "0x2DBF47C", Offset = "0x2DBF47C", VA = "0x2DBF47C")]
	public static void LogVerbose(string log)
	{
	}

	[Token(Token = "0x6012FE1")]
	[Address(RVA = "0x2DBF580", Offset = "0x2DBF580", VA = "0x2DBF580")]
	private static void Log(string log)
	{
	}

	[Token(Token = "0x6012FE2")]
	[Address(RVA = "0x2DBF658", Offset = "0x2DBF658", VA = "0x2DBF658")]
	private static void LogError(string log)
	{
	}

	[Token(Token = "0x6012FE3")]
	[Address(RVA = "0x2DBF730", Offset = "0x2DBF730", VA = "0x2DBF730")]
	public static void Register(PaymentDelegate del)
	{
	}

	[Token(Token = "0x6012FE4")]
	[Address(RVA = "0x2DBF860", Offset = "0x2DBF860", VA = "0x2DBF860")]
	public static void Unregister(PaymentDelegate del)
	{
	}

	[Token(Token = "0x6012FE5")]
	[Address(RVA = "0x2DBFA1C", Offset = "0x2DBFA1C", VA = "0x2DBFA1C")]
	private static PaymentDelegate.ProductPurchasedResult Convert(SDKIAPTaskResult result)
	{
		return null;
	}

	[Token(Token = "0x6012FE6")]
	[Address(RVA = "0x2DBFB78", Offset = "0x2DBFB78", VA = "0x2DBFB78")]
	private static void NotifyDelegates_ProductPurchased(SDKIAPTaskInfo info, SDKIAPTaskResult result, bool isEvent, string productIdentifier, long rebateId, int quantity)
	{
	}

	[Token(Token = "0x6012FE7")]
	[Address(RVA = "0x2DC2070", Offset = "0x2DC2070", VA = "0x2DC2070")]
	private static void ClearTransactions()
	{
	}

	[Token(Token = "0x6012FEA")]
	[Address(RVA = "0x2DC23CC", Offset = "0x2DC23CC", VA = "0x2DC23CC")]
	private static void ScanIAPInventory()
	{
	}

	[Token(Token = "0x6012FEB")]
	[Address(RVA = "0x2DC2CB8", Offset = "0x2DC2CB8", VA = "0x2DC2CB8")]
	private static void SetMshopUrl()
	{
	}

	[Token(Token = "0x6012FEC")]
	[Address(RVA = "0x2DC304C", Offset = "0x2DC304C", VA = "0x2DC304C")]
	private static void ProcessScanInventoryResults(SDKIAP.ScanIAPInventoryResult[] results)
	{
	}

	[Token(Token = "0x6012FED")]
	[Address(RVA = "0x2DC4304", Offset = "0x2DC4304", VA = "0x2DC4304")]
	private static void ShowPlatformPromotionProductMessageBox()
	{
	}

	[Token(Token = "0x6012FEF")]
	[Address(RVA = "0x2DC473C", Offset = "0x2DC473C", VA = "0x2DC473C")]
	public static void DisplayMShop()
	{
	}

	[Token(Token = "0x6012FF1")]
	[Address(RVA = "0x2DC47F8", Offset = "0x2DC47F8", VA = "0x2DC47F8")]
	public static void DisplayUnityMShop()
	{
	}

	[Token(Token = "0x6012FF2")]
	[Address(RVA = "0x2DC51F0", Offset = "0x2DC51F0", VA = "0x2DC51F0")]
	public static void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x6012FF3")]
	[Address(RVA = "0x2DBF124", Offset = "0x2DBF124", VA = "0x2DBF124")]
	public static uint ExtractProductId(string productIdentifier)
	{
		return default(uint);
	}

	[Token(Token = "0x6012FF4")]
	[Address(RVA = "0x2DBF390", Offset = "0x2DBF390", VA = "0x2DBF390")]
	public static string FormatProductIdentifier(int productId)
	{
		return null;
	}

	[Token(Token = "0x6012FF5")]
	[Address(RVA = "0x2DC5500", Offset = "0x2DC5500", VA = "0x2DC5500")]
	public static PayItemData GetFetchedProduct(int productId)
	{
		return null;
	}

	[Token(Token = "0x6012FF6")]
	[Address(RVA = "0x2DC0B58", Offset = "0x2DC0B58", VA = "0x2DC0B58")]
	public static PayItemData GetFetchedProduct(string productIdentifier)
	{
		return null;
	}

	[Token(Token = "0x6012FF7")]
	[Address(RVA = "0x2DC55CC", Offset = "0x2DC55CC", VA = "0x2DC55CC")]
	public static PayItemData GetFetchedEventProduct(int productId)
	{
		return null;
	}

	[Token(Token = "0x6012FF8")]
	[Address(RVA = "0x2DC5698", Offset = "0x2DC5698", VA = "0x2DC5698")]
	public static PayItemData GetFetchedEventProduct(string productIdentifier)
	{
		return null;
	}

	[Token(Token = "0x6013002")]
	[Address(RVA = "0x2DC5C40", Offset = "0x2DC5C40", VA = "0x2DC5C40")]
	public static void AfterLogoutSDK()
	{
	}

	[Token(Token = "0x6013003")]
	[Address(RVA = "0x2DC5D04", Offset = "0x2DC5D04", VA = "0x2DC5D04")]
	public static void AfterLoginSDK()
	{
	}

	[Token(Token = "0x6013004")]
	[Address(RVA = "0x2DC60C8", Offset = "0x2DC60C8", VA = "0x2DC60C8")]
	public static void AfterLoginServer(int serverID = 0)
	{
	}

	[Token(Token = "0x6013005")]
	[Address(RVA = "0x2DC6190", Offset = "0x2DC6190", VA = "0x2DC6190")]
	public static void Preload()
	{
	}

	[Token(Token = "0x6013006")]
	[Address(RVA = "0x2DC61DC", Offset = "0x2DC61DC", VA = "0x2DC61DC")]
	public static void AfterLogoutServer()
	{
	}

	[Token(Token = "0x6013007")]
	[Address(RVA = "0x2DC64B8", Offset = "0x2DC64B8", VA = "0x2DC64B8")]
	private static void UpdateTips()
	{
	}

	[Token(Token = "0x6013008")]
	[Address(RVA = "0x2DC21F0", Offset = "0x2DC21F0", VA = "0x2DC21F0")]
	public static bool IsSupportIAP()
	{
		return default(bool);
	}

	[Token(Token = "0x6013009")]
	[Address(RVA = "0x2DC6700", Offset = "0x2DC6700", VA = "0x2DC6700")]
	public static bool IsSupportEventIAP()
	{
		return default(bool);
	}

	[Token(Token = "0x601300A")]
	[Address(RVA = "0x2DC67C0", Offset = "0x2DC67C0", VA = "0x2DC67C0")]
	private static string GetMessageForNotSupportingIAP()
	{
		return null;
	}

	[Token(Token = "0x601300B")]
	[Address(RVA = "0x2DC68DC", Offset = "0x2DC68DC", VA = "0x2DC68DC")]
	public static void ShowNotSupportingIAPMessageBox(uint gopos, bool standard = false)
	{
	}

	[Token(Token = "0x601300C")]
	[Address(RVA = "0x2DC6B14", Offset = "0x2DC6B14", VA = "0x2DC6B14")]
	public static bool SupportSubscription()
	{
		return default(bool);
	}

	[Token(Token = "0x601300E")]
	[Address(RVA = "0x2DC0CD8", Offset = "0x2DC0CD8", VA = "0x2DC0CD8")]
	private static bool UpdateIAPItems(SDKIAPTaskInfo info, string[] itemIdentifiers, long[] rebateIds)
	{
		return default(bool);
	}

	[Token(Token = "0x601300F")]
	[Address(RVA = "0x2DC6C90", Offset = "0x2DC6C90", VA = "0x2DC6C90")]
	private static void OnAllIAPItemsUpdated(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.IAPItem[] items)
	{
	}

	[Token(Token = "0x6013010")]
	[Address(RVA = "0x2DC8218", Offset = "0x2DC8218", VA = "0x2DC8218")]
	private static void OnSomeIAPItemsUpdated(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.IAPItem[] items)
	{
	}

	[Token(Token = "0x6013011")]
	[Address(RVA = "0x2DC6D84", Offset = "0x2DC6D84", VA = "0x2DC6D84")]
	private static void ApplyUpdatedIAPItems(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.IAPItem[] items, bool replace)
	{
	}

	[Token(Token = "0x6013012")]
	[Address(RVA = "0x2DC830C", Offset = "0x2DC830C", VA = "0x2DC830C")]
	private static PayItemData ParsePayItemData(SDKIAP.IAPItem iapItem)
	{
		return null;
	}

	[Token(Token = "0x6013013")]
	[Address(RVA = "0x2DC6574", Offset = "0x2DC6574", VA = "0x2DC6574")]
	private static void UpdateIAPProductTips()
	{
	}

	[Token(Token = "0x6013014")]
	[Address(RVA = "0x2DC8664", Offset = "0x2DC8664", VA = "0x2DC8664")]
	private static bool LoadEventConfigs(SDKIAPTaskInfo info, bool activeOnly)
	{
		return default(bool);
	}

	[Token(Token = "0x6013015")]
	[Address(RVA = "0x2DC88F4", Offset = "0x2DC88F4", VA = "0x2DC88F4")]
	private static void OnEventConfigsLoaded(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.LoadEventConfigsResult ret)
	{
	}

	[Token(Token = "0x6013016")]
	[Address(RVA = "0x2DC1E20", Offset = "0x2DC1E20", VA = "0x2DC1E20")]
	private static bool LoadEventIAPItems(SDKIAPTaskInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x6013017")]
	[Address(RVA = "0x2DC9D48", Offset = "0x2DC9D48", VA = "0x2DC9D48")]
	private static void OnEventIAPItemsLoaded(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.LoadEventIAPResult ret)
	{
	}

	[Token(Token = "0x6013018")]
	[Address(RVA = "0x2DC1A48", Offset = "0x2DC1A48", VA = "0x2DC1A48")]
	private static bool UpdateRebateItems(SDKIAPTaskInfo info, long[] rebateIds)
	{
		return default(bool);
	}

	[Token(Token = "0x6013019")]
	[Address(RVA = "0x2DCAE74", Offset = "0x2DCAE74", VA = "0x2DCAE74")]
	private static void OnAllRebateOptionsUpdated(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.RebateOption[] rebateOptions)
	{
	}

	[Token(Token = "0x601301A")]
	[Address(RVA = "0x2DCBBEC", Offset = "0x2DCBBEC", VA = "0x2DCBBEC")]
	private static void OnSomeRebateOptionsUpdated(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.RebateOption[] rebateOptions)
	{
	}

	[Token(Token = "0x601301B")]
	[Address(RVA = "0x2DCAF68", Offset = "0x2DCAF68", VA = "0x2DCAF68")]
	private static void ApplyUpdatedRebateItems(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.RebateOption[] rebateOptions, bool replace)
	{
	}

	[Token(Token = "0x601301C")]
	[Address(RVA = "0x2DCBCE0", Offset = "0x2DCBCE0", VA = "0x2DCBCE0")]
	private static RebateItemData ParseRebateItemData(SDKIAP.RebateOption rebateOption)
	{
		return null;
	}

	[Token(Token = "0x601301D")]
	[Address(RVA = "0x2DCBEA8", Offset = "0x2DCBEA8", VA = "0x2DCBEA8")]
	private static bool ClearLastIAPAction()
	{
		return default(bool);
	}

	[Token(Token = "0x601301E")]
	[Address(RVA = "0x2DCBFAC", Offset = "0x2DCBFAC", VA = "0x2DCBFAC")]
	private static void RetryLastIAPAction()
	{
	}

	[Token(Token = "0x601301F")]
	[Address(RVA = "0x2DCE0C0", Offset = "0x2DCE0C0", VA = "0x2DCE0C0")]
	public static void RemindSubscriptionGracePeriod(SubscriptionGracePeriodReminderInfo info)
	{
	}

	[Token(Token = "0x6013020")]
	[Address(RVA = "0x2DCE1F4", Offset = "0x2DCE1F4", VA = "0x2DCE1F4")]
	public static bool CanTryFixingGracePeriod()
	{
		return default(bool);
	}

	[Token(Token = "0x6013021")]
	[Address(RVA = "0x2DCE300", Offset = "0x2DCE300", VA = "0x2DCE300")]
	public static void TryFixingGracePeriod()
	{
	}

	[Token(Token = "0x6013022")]
	[Address(RVA = "0x2DCE408", Offset = "0x2DCE408", VA = "0x2DCE408")]
	public static bool CanTryFixingOnHold()
	{
		return default(bool);
	}

	[Token(Token = "0x6013023")]
	[Address(RVA = "0x2DCE514", Offset = "0x2DCE514", VA = "0x2DCE514")]
	public static void TryFixingOnHold()
	{
	}

	[Token(Token = "0x6013024")]
	[Address(RVA = "0x2DCE61C", Offset = "0x2DCE61C", VA = "0x2DCE61C")]
	private static string IAPFailureSignature(string item_identifier, int rebate_id, ErrorCode errorCode)
	{
		return null;
	}

	[Token(Token = "0x6013025")]
	[Address(RVA = "0x2DCEF0C", Offset = "0x2DCEF0C", VA = "0x2DCEF0C")]
	private static void ShowPaymentFailureMessageBox(SDKIAPTaskResult result, string item_identifier, int rebate_id, [Optional] Action onCancel)
	{
	}

	[Token(Token = "0x6013026")]
	[Address(RVA = "0x2DD0784", Offset = "0x2DD0784", VA = "0x2DD0784")]
	private static void RecommitBeforePayment()
	{
	}

	[Token(Token = "0x6013027")]
	[Address(RVA = "0x2DD0DF4", Offset = "0x2DD0DF4", VA = "0x2DD0DF4")]
	private static void _RecommitBeforePaymentFailure()
	{
	}

	[Token(Token = "0x6013028")]
	[Address(RVA = "0x2DD1390", Offset = "0x2DD1390", VA = "0x2DD1390")]
	private static void _RecommitBeforePaymentSuccess(string[] recommittedProducts)
	{
	}

	[Token(Token = "0x6013029")]
	[Address(RVA = "0x2DD0BF0", Offset = "0x2DD0BF0", VA = "0x2DD0BF0")]
	private static void TryPendingPaymentAction()
	{
	}

	[Token(Token = "0x601302A")]
	[Address(RVA = "0x2DD0F4C", Offset = "0x2DD0F4C", VA = "0x2DD0F4C")]
	private static void NotifyDelegate_OnPurchasingPending(bool willPurchase)
	{
	}

	[Token(Token = "0x601302B")]
	[Address(RVA = "0x2DD1558", Offset = "0x2DD1558", VA = "0x2DD1558")]
	private static bool NotifyDelegates_PaymentAfterRecommitted(string[] recommittedProducts)
	{
		return default(bool);
	}

	[Token(Token = "0x601302C")]
	[Address(RVA = "0x2DCD2E0", Offset = "0x2DCD2E0", VA = "0x2DCD2E0")]
	private static void PurchaseProduct(SDKIAPTaskInfo info, [Optional] string productIdentifier, int quantity = 1, bool isEvent = false, long eventId = 0L)
	{
	}

	[Token(Token = "0x601302D")]
	[Address(RVA = "0x2DD19A0", Offset = "0x2DD19A0", VA = "0x2DD19A0")]
	private static void _PurchaseProduct(SDKIAPTaskInfo info, [Optional] string productIdentifier, int quantity = 1, bool isEvent = false, long eventId = 0L)
	{
	}

	[Token(Token = "0x601302E")]
	[Address(RVA = "0x2DD2274", Offset = "0x2DD2274", VA = "0x2DD2274")]
	private static void OnPurchaseProductSuccess(SDKIAPTaskInfo info, SDKIAPTaskResult result, string productIdentifier, int quantity)
	{
	}

	[Token(Token = "0x601302F")]
	[Address(RVA = "0x2DD33F4", Offset = "0x2DD33F4", VA = "0x2DD33F4")]
	private static void OnPurchaseProductFailure(SDKIAPTaskInfo info, SDKIAPTaskResult result, string productIdentifier)
	{
	}

	[Token(Token = "0x6013030")]
	[Address(RVA = "0x2DD34E8", Offset = "0x2DD34E8", VA = "0x2DD34E8")]
	private static void OnPurchaseEventProductSuccess(SDKIAPTaskInfo info, SDKIAPTaskResult result, string productIdentifier, int quantity)
	{
	}

	[Token(Token = "0x6013031")]
	[Address(RVA = "0x2DD3D8C", Offset = "0x2DD3D8C", VA = "0x2DD3D8C")]
	private static void OnPurchaseEventProductFailure(SDKIAPTaskInfo info, SDKIAPTaskResult result, string productIdentifier)
	{
	}

	[Token(Token = "0x6013032")]
	[Address(RVA = "0x2DD3E80", Offset = "0x2DD3E80", VA = "0x2DD3E80")]
	private static void CacheOfflineTransaction(string productIdentifier)
	{
	}

	[Token(Token = "0x6013033")]
	[Address(RVA = "0x2DD41B0", Offset = "0x2DD41B0", VA = "0x2DD41B0")]
	private static void ClearCachedOfflineTransaction(string productIdentifier)
	{
	}

	[Token(Token = "0x6013034")]
	[Address(RVA = "0x2DD02F4", Offset = "0x2DD02F4", VA = "0x2DD02F4")]
	private static bool CheckHasCachedOfflineTransaction(string productIdentifier)
	{
		return default(bool);
	}

	[Token(Token = "0x6013035")]
	[Address(RVA = "0x2DD2540", Offset = "0x2DD2540", VA = "0x2DD2540")]
	private static void OnPurchasedProduct(SDKIAPTaskInfo info, SDKIAPTaskResult result, bool isEvent, bool success)
	{
	}

	[Token(Token = "0x6013036")]
	[Address(RVA = "0x2DD4430", Offset = "0x2DD4430", VA = "0x2DD4430")]
	public static bool ShouldOverrideLocalPaymentItem(ErrorCode errorCode)
	{
		return default(bool);
	}

	[Token(Token = "0x6013037")]
	[Address(RVA = "0x2DD06F4", Offset = "0x2DD06F4", VA = "0x2DD06F4")]
	public static bool ShouldPromptRetry(ErrorCode errorCode)
	{
		return default(bool);
	}

	[Token(Token = "0x6013039")]
	[Address(RVA = "0x2DD004C", Offset = "0x2DD004C", VA = "0x2DD004C")]
	public static string ErrorCodeToString_IAP(int errorCode, string errorMessage = "")
	{
		return null;
	}

	[Token(Token = "0x601303A")]
	[Address(RVA = "0x2DD44A8", Offset = "0x2DD44A8", VA = "0x2DD44A8")]
	public static string GetPaymentNotificationString(InventoryTopupNtf topupNotification)
	{
		return null;
	}

	[Token(Token = "0x601303B")]
	[Address(RVA = "0x2DD496C", Offset = "0x2DD496C", VA = "0x2DD496C")]
	public static string SubscriptionPeriodLocalizationKey(SubscriptionPeriod sp)
	{
		return null;
	}

	[Token(Token = "0x601303C")]
	[Address(RVA = "0x2DD4A74", Offset = "0x2DD4A74", VA = "0x2DD4A74")]
	public static void ShowSubscriptionHint(SubscriptionHintOption option)
	{
	}

	[Token(Token = "0x601303D")]
	[Address(RVA = "0x2DD54BC", Offset = "0x2DD54BC", VA = "0x2DD54BC")]
	public static void PromptOnInsufficientDiamonds(UINavigationUtil.UINavigationFrom from, string msg = "", string title = "", string okText = "")
	{
	}

	[Token(Token = "0x601303E")]
	[Address(RVA = "0x2DC3EA8", Offset = "0x2DC3EA8", VA = "0x2DC3EA8")]
	public static void ShowPaymentMessageBox(string message, string title = "", string okText = "", [Optional] Action onOK, [Optional] Action onCancel, string note = "", UIPopupMessageBoxController.EButtonStyle buttonStyle = UIPopupMessageBoxController.EButtonStyle.None, [Optional] Action onClose)
	{
	}

	[Token(Token = "0x601303F")]
	[Address(RVA = "0x2DD58FC", Offset = "0x2DD58FC", VA = "0x2DD58FC")]
	public static void ShowPaymentMessageBoxNotUseSpecialDepth(string message, string title = "", string okText = "", [Optional] Action onOK, [Optional] Action onCancel, string note = "", UIPopupMessageBox2Controller.EButtonStyle buttonStyle = UIPopupMessageBox2Controller.EButtonStyle.None)
	{
	}

	[Token(Token = "0x6013040")]
	[Address(RVA = "0x2DD5D40", Offset = "0x2DD5D40", VA = "0x2DD5D40")]
	private static void OnPurchaseRebateItemSuccess(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAPManager.RebateOptionPurchaseResult purchaseResult)
	{
	}

	[Token(Token = "0x6013041")]
	[Address(RVA = "0x2DD6620", Offset = "0x2DD6620", VA = "0x2DD6620")]
	private static void OnPurchaseRebateItemFailure(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAPManager.RebateOptionPurchaseResult purchaseResult)
	{
	}

	[Token(Token = "0x6013042")]
	[Address(RVA = "0x2DCC228", Offset = "0x2DCC228", VA = "0x2DCC228")]
	private static void PurchaseRebateOption(SDKIAPTaskInfo info, string productIdentifier, long rebateId)
	{
	}

	[Token(Token = "0x6013043")]
	[Address(RVA = "0x2DD6C04", Offset = "0x2DD6C04", VA = "0x2DD6C04")]
	private static void _PurchaseRebateOption(SDKIAPTaskInfo info, string productIdentifier, long rebateId)
	{
	}

	[Token(Token = "0x6013044")]
	[Address(RVA = "0x2DD719C", Offset = "0x2DD719C", VA = "0x2DD719C")]
	public static void RedeemRebateOption(int rebateId)
	{
	}

	[Token(Token = "0x6013045")]
	[Address(RVA = "0x2DD78D4", Offset = "0x2DD78D4", VA = "0x2DD78D4")]
	private static void OnRebateOptionRedeemed(SDKIAPTaskInfo info, SDKIAPTaskResult result, SDKIAP.RebateRedeemResult[] results)
	{
	}

	[Token(Token = "0x6013046")]
	[Address(RVA = "0x2DD828C", Offset = "0x2DD828C", VA = "0x2DD828C")]
	public static int GetRebateNextResetTime()
	{
		return default(int);
	}

	[Token(Token = "0x6013048")]
	[Address(RVA = "0x2DD916C", Offset = "0x2DD916C", VA = "0x2DD916C")]
	private static PlatformPromotionProductsData _003CScanIAPInventory_003Em__0(CSVBaseData temp)
	{
		return null;
	}

	[Token(Token = "0x6013049")]
	[Address(RVA = "0x2DD9200", Offset = "0x2DD9200", VA = "0x2DD9200")]
	private static void _003CScanIAPInventory_003Em__1(SDKIAPTaskInfo info, SDKIAP.ScanIAPInventoryResult[] results)
	{
	}

	[Token(Token = "0x601304A")]
	[Address(RVA = "0x2DD9324", Offset = "0x2DD9324", VA = "0x2DD9324")]
	private static void _003CDisplayUnityMShop_003Em__2()
	{
	}

	[Token(Token = "0x601304B")]
	[Address(RVA = "0x2DD93FC", Offset = "0x2DD93FC", VA = "0x2DD93FC")]
	private static int _003CUpdateIAPItems_003Em__3(string idStr)
	{
		return default(int);
	}

	[Token(Token = "0x601304C")]
	[Address(RVA = "0x2DD947C", Offset = "0x2DD947C", VA = "0x2DD947C")]
	private static string _003CUpdateIAPItems_003Em__4(int itemId)
	{
		return null;
	}

	[Token(Token = "0x601304D")]
	[Address(RVA = "0x2DD94A0", Offset = "0x2DD94A0", VA = "0x2DD94A0")]
	private static string _003CUpdateIAPItems_003Em__5(long rebateId)
	{
		return null;
	}

	[Token(Token = "0x601304E")]
	[Address(RVA = "0x2DD94C0", Offset = "0x2DD94C0", VA = "0x2DD94C0")]
	private static string _003CApplyUpdatedIAPItems_003Em__6(SDKIAP.IAPItem item)
	{
		return null;
	}

	[Token(Token = "0x601304F")]
	[Address(RVA = "0x2DD9968", Offset = "0x2DD9968", VA = "0x2DD9968")]
	private static string _003CApplyUpdatedIAPItems_003Em__7(SDKIAP.IAPItem item)
	{
		return null;
	}

	[Token(Token = "0x6013050")]
	[Address(RVA = "0x2DD998C", Offset = "0x2DD998C", VA = "0x2DD998C")]
	private static string _003COnEventIAPItemsLoaded_003Em__8(SDKIAP.IAPItem item)
	{
		return null;
	}

	[Token(Token = "0x6013051")]
	[Address(RVA = "0x2DD9E34", Offset = "0x2DD9E34", VA = "0x2DD9E34")]
	private static string _003COnEventIAPItemsLoaded_003Em__9(SDKIAP.EventDatum datum)
	{
		return null;
	}

	[Token(Token = "0x6013052")]
	[Address(RVA = "0x2DDA3C8", Offset = "0x2DDA3C8", VA = "0x2DDA3C8")]
	private static string _003CApplyUpdatedRebateItems_003Em__A(SDKIAP.RebateOption rebateOption)
	{
		return null;
	}

	[Token(Token = "0x6013053")]
	[Address(RVA = "0x2DDA878", Offset = "0x2DDA878", VA = "0x2DDA878")]
	private static long _003CApplyUpdatedRebateItems_003Em__B(SDKIAP.RebateOption rebateOption)
	{
		return default(long);
	}

	[Token(Token = "0x6013054")]
	[Address(RVA = "0x2DDA89C", Offset = "0x2DDA89C", VA = "0x2DDA89C")]
	private static void _003CShowPaymentFailureMessageBox_003Em__C()
	{
	}

	[Token(Token = "0x6013055")]
	[Address(RVA = "0x2DDAC00", Offset = "0x2DDAC00", VA = "0x2DDAC00")]
	private static void _003CShowPaymentFailureMessageBox_003Em__D()
	{
	}

	[Token(Token = "0x6013056")]
	[Address(RVA = "0x2DDAC78", Offset = "0x2DDAC78", VA = "0x2DDAC78")]
	private static void _003CRecommitBeforePayment_003Em__E(SDKIAPTaskInfo info, SDKIAP.ScanIAPInventoryResult[] results)
	{
	}

	[Token(Token = "0x6013057")]
	[Address(RVA = "0x2DDB1BC", Offset = "0x2DDB1BC", VA = "0x2DDB1BC")]
	private static void _003CTryPendingPaymentAction_003Em__F()
	{
	}

	[Token(Token = "0x6013058")]
	[Address(RVA = "0x2DDB3F0", Offset = "0x2DDB3F0", VA = "0x2DDB3F0")]
	private static int _003CNotifyDelegates_PaymentAfterRecommitted_003Em__10(string str)
	{
		return default(int);
	}

	[Token(Token = "0x6013059")]
	[Address(RVA = "0x2DDB470", Offset = "0x2DDB470", VA = "0x2DDB470")]
	private static void _003CPurchaseProduct_003Em__11()
	{
	}

	[Token(Token = "0x601305A")]
	[Address(RVA = "0x2DDB548", Offset = "0x2DDB548", VA = "0x2DDB548")]
	private static void _003CPurchaseRebateOption_003Em__12()
	{
	}

	[Token(Token = "0x601305B")]
	[Address(RVA = "0x2DDB620", Offset = "0x2DDB620", VA = "0x2DDB620")]
	private static string _003COnEventIAPItemsLoaded_003Em__13(int id)
	{
		return null;
	}

	[Token(Token = "0x601305C")]
	[Address(RVA = "0x2DDB644", Offset = "0x2DDB644", VA = "0x2DDB644")]
	private static void _003CShowPaymentFailureMessageBox_003Em__14()
	{
	}

	[Token(Token = "0x601305D")]
	[Address(RVA = "0x2DDB71C", Offset = "0x2DDB71C", VA = "0x2DDB71C")]
	private static bool _003CRecommitBeforePayment_003Em__15(SDKIAP.ScanIAPInventoryResult r)
	{
		return default(bool);
	}

	[Token(Token = "0x601305E")]
	[Address(RVA = "0x2DDB73C", Offset = "0x2DDB73C", VA = "0x2DDB73C")]
	private static bool _003CRecommitBeforePayment_003Em__16(SDKIAP.ScanIAPInventoryResult r)
	{
		return default(bool);
	}

	[Token(Token = "0x601305F")]
	[Address(RVA = "0x2DDB758", Offset = "0x2DDB758", VA = "0x2DDB758")]
	private static string _003CRecommitBeforePayment_003Em__17(SDKIAP.ScanIAPInventoryResult r)
	{
		return null;
	}
}
