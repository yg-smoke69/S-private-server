using System;
using System.Collections.Generic;
using GCommon;
using GarenaMSDK;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20031B3")]
public class UIModelPayment : UIBaseModel
{
	[Token(Token = "0x20031B4")]
	public enum PaymentBundleState
	{
		[Token(Token = "0x4012EEE")]
		NotLoaded,
		[Token(Token = "0x4012EEF")]
		Loading,
		[Token(Token = "0x4012EF0")]
		Loaded,
		[Token(Token = "0x4012EF1")]
		Paying,
		[Token(Token = "0x4012EF2")]
		Exchanging
	}

	[Token(Token = "0x20031B5")]
	public enum TopupEventType
	{
		[Token(Token = "0x4012EF4")]
		MysteryBonus,
		[Token(Token = "0x4012EF5")]
		DiamondEvent
	}

	[Token(Token = "0x20031B6")]
	public enum BundlePurchaseError
	{
		[Token(Token = "0x4012EF7")]
		None,
		[Token(Token = "0x4012EF8")]
		NotLoaded,
		[Token(Token = "0x4012EF9")]
		Missing,
		[Token(Token = "0x4012EFA")]
		SoldOut,
		[Token(Token = "0x4012EFB")]
		Pending
	}

	[Token(Token = "0x20031B7")]
	private class PaymentBundlesDelegate : PayUtility.PaymentDelegate
	{
		[Token(Token = "0x4012EFC")]
		[FieldOffset(Offset = "0x0")]
		private static PaymentBundlesDelegate _I;

		[Token(Token = "0x17001618")]
		public static PaymentBundlesDelegate I
		{
			[Token(Token = "0x6014F91")]
			[Address(RVA = "0x31ADCA8", Offset = "0x31ADCA8", VA = "0x31ADCA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001619")]
		public override string Name
		{
			[Token(Token = "0x6014F92")]
			[Address(RVA = "0x31C3E20", Offset = "0x31C3E20", VA = "0x31C3E20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6014F90")]
		[Address(RVA = "0x31C3E18", Offset = "0x31C3E18", VA = "0x31C3E18")]
		public PaymentBundlesDelegate()
		{
		}

		[Token(Token = "0x6014F93")]
		[Address(RVA = "0x31C3EC4", Offset = "0x31C3EC4", VA = "0x31C3EC4", Slot = "16")]
		public override ProductPurchasedReaction OnProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, long rebateId, int quantity)
		{
			return null;
		}

		[Token(Token = "0x6014F94")]
		[Address(RVA = "0x31C4058", Offset = "0x31C4058", VA = "0x31C4058")]
		public ProductPurchasedReaction _003C_003EiFixBaseProxy_OnProductPurchased(string P0, ProductPurchasedResult P1, string P2, long P3, int P4)
		{
			return null;
		}
	}

	[Token(Token = "0x20031B8")]
	public enum VersionType
	{
		[Token(Token = "0x4012EFE")]
		IAPProducts,
		[Token(Token = "0x4012EFF")]
		PaymentBundles,
		[Token(Token = "0x4012F00")]
		RebateCard
	}

	[Token(Token = "0x20031B9")]
	private class VersionInfo
	{
		[Token(Token = "0x4012F01")]
		[FieldOffset(Offset = "0x8")]
		public string PlayerPrefsKey;

		[Token(Token = "0x4012F02")]
		[FieldOffset(Offset = "0xC")]
		public Func<string> LocalOverride;

		[Token(Token = "0x4012F03")]
		[FieldOffset(Offset = "0x10")]
		public Func<string> Remote;

		[Token(Token = "0x6014F95")]
		[Address(RVA = "0x31BE2A8", Offset = "0x31BE2A8", VA = "0x31BE2A8")]
		public VersionInfo()
		{
		}
	}

	[Token(Token = "0x20031BA")]
	public enum PaymentButtonStyle
	{
		[Token(Token = "0x4012F05")]
		FirstTime = 1,
		[Token(Token = "0x4012F06")]
		SecondTime,
		[Token(Token = "0x4012F07")]
		LessIsMore,
		[Token(Token = "0x4012F08")]
		MysteryTopupBonus,
		[Token(Token = "0x4012F09")]
		Normal,
		[Token(Token = "0x4012F0A")]
		Finished
	}

	[Token(Token = "0x20031BB")]
	public class PaymentButtonDisplayInfo
	{
		[Token(Token = "0x4012F0B")]
		[FieldOffset(Offset = "0x8")]
		public string CdnUrl;

		[Token(Token = "0x4012F0C")]
		[FieldOffset(Offset = "0xC")]
		public uint StartTime;

		[Token(Token = "0x4012F0D")]
		[FieldOffset(Offset = "0x10")]
		public uint EndTime;

		[Token(Token = "0x4012F0E")]
		[FieldOffset(Offset = "0x14")]
		public uint subtype;

		[Token(Token = "0x4012F0F")]
		[FieldOffset(Offset = "0x18")]
		public uint gopos;

		[Token(Token = "0x4012F10")]
		[FieldOffset(Offset = "0x1C")]
		public string subgopos;

		[Token(Token = "0x6014F96")]
		[Address(RVA = "0x31B453C", Offset = "0x31B453C", VA = "0x31B453C")]
		public PaymentButtonDisplayInfo()
		{
		}
	}

	[Token(Token = "0x20031BC")]
	private class DiamondProductsDelegate : PayUtility.PaymentDelegate
	{
		[Token(Token = "0x4012F11")]
		[FieldOffset(Offset = "0x0")]
		private static DiamondProductsDelegate _I;

		[Token(Token = "0x4012F12")]
		[FieldOffset(Offset = "0x1C")]
		private string[] _003CProductsInDemand_003Ek__BackingField;

		[Token(Token = "0x1700161A")]
		public static DiamondProductsDelegate I
		{
			[Token(Token = "0x6014F98")]
			[Address(RVA = "0x31ADBC4", Offset = "0x31ADBC4", VA = "0x31ADBC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700161B")]
		public override string Name
		{
			[Token(Token = "0x6014F99")]
			[Address(RVA = "0x31C0984", Offset = "0x31C0984", VA = "0x31C0984", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700161C")]
		public override string[] ProductsInDemand
		{
			[Token(Token = "0x6014F9A")]
			[Address(RVA = "0x31C0A28", Offset = "0x31C0A28", VA = "0x31C0A28", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6014F9B")]
			[Address(RVA = "0x31C0A30", Offset = "0x31C0A30", VA = "0x31C0A30", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x6014F97")]
		[Address(RVA = "0x31C097C", Offset = "0x31C097C", VA = "0x31C097C")]
		public DiamondProductsDelegate()
		{
		}

		[Token(Token = "0x6014F9C")]
		[Address(RVA = "0x31C0A38", Offset = "0x31C0A38", VA = "0x31C0A38", Slot = "13")]
		public override void OnProductsUpdated(string reason, bool result, string[] productIdentifiers)
		{
		}

		[Token(Token = "0x6014F9D")]
		[Address(RVA = "0x31C0BD0", Offset = "0x31C0BD0", VA = "0x31C0BD0", Slot = "16")]
		public override ProductPurchasedReaction OnProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, long rebateId, int quantity)
		{
			return null;
		}

		[Token(Token = "0x6014F9E")]
		[Address(RVA = "0x31C0E84", Offset = "0x31C0E84", VA = "0x31C0E84")]
		public void _003C_003EiFixBaseProxy_OnProductsUpdated(string P0, bool P1, string[] P2)
		{
		}

		[Token(Token = "0x6014F9F")]
		[Address(RVA = "0x31C0EA4", Offset = "0x31C0EA4", VA = "0x31C0EA4")]
		public ProductPurchasedReaction _003C_003EiFixBaseProxy_OnProductPurchased(string P0, ProductPurchasedResult P1, string P2, long P3, int P4)
		{
			return null;
		}
	}

	[Token(Token = "0x20031BD")]
	public class LessIsMoreEvent
	{
		[Token(Token = "0x20031BE")]
		public class Tier
		{
			[Token(Token = "0x4012F19")]
			[FieldOffset(Offset = "0x8")]
			public uint TierId;

			[Token(Token = "0x4012F1A")]
			[FieldOffset(Offset = "0xC")]
			public uint MinDiamonds;

			[Token(Token = "0x4012F1B")]
			[FieldOffset(Offset = "0x10")]
			public float Price;

			[Token(Token = "0x4012F1C")]
			[FieldOffset(Offset = "0x18")]
			public long ItemId;

			[Token(Token = "0x4012F1D")]
			[FieldOffset(Offset = "0x20")]
			public long RebateId;

			[Token(Token = "0x4012F1E")]
			[FieldOffset(Offset = "0x28")]
			public uint GainDiamonds;

			[Token(Token = "0x6014FA1")]
			[Address(RVA = "0x31C1284", Offset = "0x31C1284", VA = "0x31C1284")]
			public Tier()
			{
			}
		}

		[Token(Token = "0x4012F13")]
		[FieldOffset(Offset = "0x8")]
		public Tier[] Tiers;

		[Token(Token = "0x4012F14")]
		[FieldOffset(Offset = "0xC")]
		public bool Eligible;

		[Token(Token = "0x4012F15")]
		[FieldOffset(Offset = "0xD")]
		public bool Pending;

		[Token(Token = "0x4012F16")]
		[FieldOffset(Offset = "0x10")]
		public ulong StartTime;

		[Token(Token = "0x4012F17")]
		[FieldOffset(Offset = "0x18")]
		public ulong EndTime;

		[Token(Token = "0x4012F18")]
		[FieldOffset(Offset = "0x20")]
		public long SDKEventId;

		[Token(Token = "0x6014FA0")]
		[Address(RVA = "0x31C127C", Offset = "0x31C127C", VA = "0x31C127C")]
		public LessIsMoreEvent()
		{
		}
	}

	[Token(Token = "0x20031BF")]
	private class LessIsMoreDelegate : PayUtility.PaymentDelegate
	{
		[Serializable]
		[Token(Token = "0x20031C0")]
		public class LessIsMoreExtraInfo
		{
			[Token(Token = "0x4012F29")]
			[FieldOffset(Offset = "0x8")]
			public int price_tier;

			[Token(Token = "0x4012F2A")]
			[FieldOffset(Offset = "0xC")]
			public int tier_diamond_min;

			[Token(Token = "0x4012F2B")]
			[FieldOffset(Offset = "0x10")]
			public int diamond_num;

			[Token(Token = "0x6014FBF")]
			[Address(RVA = "0x31C3E10", Offset = "0x31C3E10", VA = "0x31C3E10")]
			public LessIsMoreExtraInfo()
			{
			}
		}

		[Token(Token = "0x4012F1F")]
		[FieldOffset(Offset = "0x0")]
		private static LessIsMoreDelegate _I;

		[Token(Token = "0x4012F20")]
		[FieldOffset(Offset = "0x1C")]
		private LessIsMoreEvent _003CEvent_003Ek__BackingField;

		[Token(Token = "0x4012F21")]
		[FieldOffset(Offset = "0x20")]
		private int _ReloadFailures;

		[Token(Token = "0x4012F22")]
		[FieldOffset(Offset = "0x28")]
		private ulong _LastLoadEventConfigsTimestamp;

		[Token(Token = "0x4012F23")]
		[FieldOffset(Offset = "0x30")]
		private bool _LastLoadEventConfigsResult;

		[Token(Token = "0x4012F24")]
		[FieldOffset(Offset = "0x38")]
		private ulong _LastLoadEventProductsTimestamp;

		[Token(Token = "0x4012F25")]
		[FieldOffset(Offset = "0x40")]
		private bool _LastLoadEventProductsResult;

		[Token(Token = "0x4012F26")]
		[FieldOffset(Offset = "0x4")]
		private static Predicate<DiamondSpendEventDesc> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x4012F27")]
		[FieldOffset(Offset = "0x8")]
		private static Comparison<LessIsMoreEvent.Tier> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x4012F28")]
		[FieldOffset(Offset = "0xC")]
		private static Comparison<LessIsMoreEvent.Tier> _003C_003Ef__am_0024cache2;

		[Token(Token = "0x1700161D")]
		public static LessIsMoreDelegate I
		{
			[Token(Token = "0x6014FA3")]
			[Address(RVA = "0x31ADE70", Offset = "0x31ADE70", VA = "0x31ADE70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700161E")]
		public override string Name
		{
			[Token(Token = "0x6014FA4")]
			[Address(RVA = "0x31C0EE0", Offset = "0x31C0EE0", VA = "0x31C0EE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700161F")]
		public override string EventTypeInDemand
		{
			[Token(Token = "0x6014FA5")]
			[Address(RVA = "0x31C0F84", Offset = "0x31C0F84", VA = "0x31C0F84", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001620")]
		public LessIsMoreEvent Event
		{
			[Token(Token = "0x6014FA7")]
			[Address(RVA = "0x31B4EFC", Offset = "0x31B4EFC", VA = "0x31B4EFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6014FA8")]
			[Address(RVA = "0x31C1274", Offset = "0x31C1274", VA = "0x31C1274")]
			private set
			{
			}
		}

		[Token(Token = "0x17001621")]
		private int MaxReloadFailures
		{
			[Token(Token = "0x6014FAE")]
			[Address(RVA = "0x31C2870", Offset = "0x31C2870", VA = "0x31C2870")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17001622")]
		private ulong MinReloadInterval
		{
			[Token(Token = "0x6014FAF")]
			[Address(RVA = "0x31C29C4", Offset = "0x31C29C4", VA = "0x31C29C4")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x17001623")]
		private ulong PendingReloadInterval
		{
			[Token(Token = "0x6014FB0")]
			[Address(RVA = "0x31C2B14", Offset = "0x31C2B14", VA = "0x31C2B14")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x6014FA2")]
		[Address(RVA = "0x31C0ED8", Offset = "0x31C0ED8", VA = "0x31C0ED8")]
		public LessIsMoreDelegate()
		{
		}

		[Token(Token = "0x6014FA6")]
		[Address(RVA = "0x31C10A4", Offset = "0x31C10A4", VA = "0x31C10A4", Slot = "13")]
		public override void OnProductsUpdated(string task, bool result, string[] productIdentifiers)
		{
		}

		[Token(Token = "0x6014FA9")]
		[Address(RVA = "0x31AEA80", Offset = "0x31AEA80", VA = "0x31AEA80")]
		public void ClearEvent()
		{
		}

		[Token(Token = "0x6014FAA")]
		[Address(RVA = "0x31B5774", Offset = "0x31B5774", VA = "0x31B5774")]
		public void SetEventFromGame(DiamondSpendEventInfo info)
		{
		}

		[Token(Token = "0x6014FAB")]
		[Address(RVA = "0x31C128C", Offset = "0x31C128C", VA = "0x31C128C")]
		private void SetEventFromSDK()
		{
		}

		[Token(Token = "0x6014FAC")]
		[Address(RVA = "0x31C1FF8", Offset = "0x31C1FF8", VA = "0x31C1FF8")]
		private bool ShouldDisplayEvent(SDKIAP.Event e)
		{
			return default(bool);
		}

		[Token(Token = "0x6014FAD")]
		[Address(RVA = "0x31C2484", Offset = "0x31C2484", VA = "0x31C2484")]
		private bool ShouldDisplayEvent(SDKIAP.EventDatum d)
		{
			return default(bool);
		}

		[Token(Token = "0x6014FB1")]
		[Address(RVA = "0x31B6328", Offset = "0x31B6328", VA = "0x31B6328")]
		public void ReloadEvent()
		{
		}

		[Token(Token = "0x6014FB2")]
		[Address(RVA = "0x31C2C64", Offset = "0x31C2C64", VA = "0x31C2C64", Slot = "12")]
		public override void OnEventConfigsUpdated(string reason, bool result)
		{
		}

		[Token(Token = "0x6014FB3")]
		[Address(RVA = "0x31C3334", Offset = "0x31C3334", VA = "0x31C3334", Slot = "14")]
		public override void OnEventProductsAndDataUpdate(string reason, bool result)
		{
		}

		[Token(Token = "0x6014FB4")]
		[Address(RVA = "0x31C36B8", Offset = "0x31C36B8", VA = "0x31C36B8", Slot = "16")]
		public override ProductPurchasedReaction OnProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, long rebateId, int quantity)
		{
			return null;
		}

		[Token(Token = "0x6014FB5")]
		[Address(RVA = "0x31C3968", Offset = "0x31C3968", VA = "0x31C3968", Slot = "17")]
		public override bool OnEventProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, int quantity)
		{
			return default(bool);
		}

		[Token(Token = "0x6014FB6")]
		[Address(RVA = "0x31C3C1C", Offset = "0x31C3C1C", VA = "0x31C3C1C")]
		private static bool _003CSetEventFromGame_003Em__0(DiamondSpendEventDesc desc)
		{
			return default(bool);
		}

		[Token(Token = "0x6014FB7")]
		[Address(RVA = "0x31C3CF0", Offset = "0x31C3CF0", VA = "0x31C3CF0")]
		private static int _003CSetEventFromGame_003Em__1(LessIsMoreEvent.Tier a, LessIsMoreEvent.Tier b)
		{
			return default(int);
		}

		[Token(Token = "0x6014FB8")]
		[Address(RVA = "0x31C3D38", Offset = "0x31C3D38", VA = "0x31C3D38")]
		private static int _003CSetEventFromSDK_003Em__2(LessIsMoreEvent.Tier a, LessIsMoreEvent.Tier b)
		{
			return default(int);
		}

		[Token(Token = "0x6014FB9")]
		[Address(RVA = "0x31C3D80", Offset = "0x31C3D80", VA = "0x31C3D80")]
		public string _003C_003EiFixBaseProxy_get_EventTypeInDemand()
		{
			return null;
		}

		[Token(Token = "0x6014FBA")]
		[Address(RVA = "0x31C3D88", Offset = "0x31C3D88", VA = "0x31C3D88")]
		public void _003C_003EiFixBaseProxy_OnProductsUpdated(string P0, bool P1, string[] P2)
		{
		}

		[Token(Token = "0x6014FBB")]
		[Address(RVA = "0x31C3DA8", Offset = "0x31C3DA8", VA = "0x31C3DA8")]
		public void _003C_003EiFixBaseProxy_OnEventConfigsUpdated(string P0, bool P1)
		{
		}

		[Token(Token = "0x6014FBC")]
		[Address(RVA = "0x31C3DB0", Offset = "0x31C3DB0", VA = "0x31C3DB0")]
		public void _003C_003EiFixBaseProxy_OnEventProductsAndDataUpdate(string P0, bool P1)
		{
		}

		[Token(Token = "0x6014FBD")]
		[Address(RVA = "0x31C3DB8", Offset = "0x31C3DB8", VA = "0x31C3DB8")]
		public ProductPurchasedReaction _003C_003EiFixBaseProxy_OnProductPurchased(string P0, ProductPurchasedResult P1, string P2, long P3, int P4)
		{
			return null;
		}

		[Token(Token = "0x6014FBE")]
		[Address(RVA = "0x31C3DEC", Offset = "0x31C3DEC", VA = "0x31C3DEC")]
		public bool _003C_003EiFixBaseProxy_OnEventProductPurchased(string P0, ProductPurchasedResult P1, string P2, int P3)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20031C1")]
	private class SubscriptionHubDelegate : PayUtility.PaymentDelegate
	{
		[Token(Token = "0x4012F2C")]
		[FieldOffset(Offset = "0x0")]
		private static SubscriptionHubDelegate _I;

		[Token(Token = "0x4012F2D")]
		[FieldOffset(Offset = "0x1C")]
		private string LastSubscribedProductIdentifier;

		[Token(Token = "0x17001624")]
		public static SubscriptionHubDelegate I
		{
			[Token(Token = "0x6014FC1")]
			[Address(RVA = "0x31ADD8C", Offset = "0x31ADD8C", VA = "0x31ADD8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001625")]
		public override string Name
		{
			[Token(Token = "0x6014FC2")]
			[Address(RVA = "0x31C4094", Offset = "0x31C4094", VA = "0x31C4094", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6014FC0")]
		[Address(RVA = "0x31C408C", Offset = "0x31C408C", VA = "0x31C408C")]
		public SubscriptionHubDelegate()
		{
		}

		[Token(Token = "0x6014FC3")]
		[Address(RVA = "0x31C4138", Offset = "0x31C4138", VA = "0x31C4138", Slot = "16")]
		public override ProductPurchasedReaction OnProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, long rebateId, int quantity)
		{
			return null;
		}

		[Token(Token = "0x6014FC4")]
		[Address(RVA = "0x31C42BC", Offset = "0x31C42BC", VA = "0x31C42BC", Slot = "13")]
		public override void OnProductsUpdated(string reason, bool result, string[] productIdentifiers)
		{
		}

		[Token(Token = "0x6014FC5")]
		[Address(RVA = "0x31C4508", Offset = "0x31C4508", VA = "0x31C4508")]
		public ProductPurchasedReaction _003C_003EiFixBaseProxy_OnProductPurchased(string P0, ProductPurchasedResult P1, string P2, long P3, int P4)
		{
			return null;
		}

		[Token(Token = "0x6014FC6")]
		[Address(RVA = "0x31C453C", Offset = "0x31C453C", VA = "0x31C453C")]
		public void _003C_003EiFixBaseProxy_OnProductsUpdated(string P0, bool P1, string[] P2)
		{
		}
	}

	[Token(Token = "0x20031C2")]
	private sealed class _003CHasPaymentSpecialStore_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012F2E")]
		[FieldOffset(Offset = "0x8")]
		internal EStore.PbwActivityType type;

		[Token(Token = "0x6014FC7")]
		[Address(RVA = "0x31B1C78", Offset = "0x31B1C78", VA = "0x31B1C78")]
		public _003CHasPaymentSpecialStore_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6014FC8")]
		[Address(RVA = "0x31C010C", Offset = "0x31C010C", VA = "0x31C010C")]
		internal bool _003C_003Em__0(PayBundleWindowDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20031C3")]
	private sealed class _003CCheckFreeBundles_003Ec__AnonStorey1
	{
		[Token(Token = "0x4012F2F")]
		[FieldOffset(Offset = "0x8")]
		internal SpecialStoreDesc store;

		[Token(Token = "0x6014FC9")]
		[Address(RVA = "0x31B2C2C", Offset = "0x31B2C2C", VA = "0x31B2C2C")]
		public _003CCheckFreeBundles_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6014FCA")]
		[Address(RVA = "0x31BF344", Offset = "0x31BF344", VA = "0x31BF344")]
		internal bool _003C_003Em__0(PayBundleWindowDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20031C4")]
	private sealed class _003CRequestTopupEvent_003Ec__AnonStorey2
	{
		[Token(Token = "0x4012F30")]
		[FieldOffset(Offset = "0x8")]
		internal CSTopupEventInfoReq req;

		[Token(Token = "0x4012F31")]
		[FieldOffset(Offset = "0xC")]
		internal uint propID;

		[Token(Token = "0x4012F32")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelPayment _0024this;

		[Token(Token = "0x6014FCB")]
		[Address(RVA = "0x31B56BC", Offset = "0x31B56BC", VA = "0x31B56BC")]
		public _003CRequestTopupEvent_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6014FCC")]
		[Address(RVA = "0x31C022C", Offset = "0x31C022C", VA = "0x31C022C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20031C5")]
	private sealed class _003CFetchSubscriptionBundles_003Ec__AnonStorey3
	{
		[Token(Token = "0x4012F33")]
		[FieldOffset(Offset = "0x8")]
		internal uint http;

		[Token(Token = "0x4012F34")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelPayment _0024this;

		[Token(Token = "0x4012F35")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<SubscribeStoreDesc, string> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6014FCD")]
		[Address(RVA = "0x31B8C90", Offset = "0x31B8C90", VA = "0x31B8C90")]
		public _003CFetchSubscriptionBundles_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6014FCE")]
		[Address(RVA = "0x31BF828", Offset = "0x31BF828", VA = "0x31BF828")]
		internal void _003C_003Em__0(HttpErrorCode error, object resObj)
		{
		}

		[Token(Token = "0x6014FCF")]
		[Address(RVA = "0x31C0074", Offset = "0x31C0074", VA = "0x31C0074")]
		private static string _003C_003Em__1(SubscribeStoreDesc desc)
		{
			return null;
		}
	}

	[Token(Token = "0x20031C6")]
	private sealed class _003CClaimSubscriptionBundle_003Ec__AnonStorey4
	{
		[Token(Token = "0x4012F36")]
		[FieldOffset(Offset = "0x8")]
		internal uint store_id;

		[Token(Token = "0x4012F37")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelPayment _0024this;

		[Token(Token = "0x6014FD0")]
		[Address(RVA = "0x31BAAB4", Offset = "0x31BAAB4", VA = "0x31BAAB4")]
		public _003CClaimSubscriptionBundle_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6014FD1")]
		[Address(RVA = "0x31BF784", Offset = "0x31BF784", VA = "0x31BF784")]
		internal void _003C_003Em__0(PayUtility.SubscriptionGracePeriodReminderInfo info)
		{
		}
	}

	[Token(Token = "0x20031C7")]
	private sealed class _003C_ClaimSubscriptionBundle_003Ec__AnonStorey5
	{
		[Token(Token = "0x4012F38")]
		[FieldOffset(Offset = "0x8")]
		internal uint store_id;

		[Token(Token = "0x4012F39")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelPayment _0024this;

		[Token(Token = "0x6014FD2")]
		[Address(RVA = "0x31BAD88", Offset = "0x31BAD88", VA = "0x31BAD88")]
		public _003C_ClaimSubscriptionBundle_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6014FD3")]
		[Address(RVA = "0x31C0704", Offset = "0x31C0704", VA = "0x31C0704")]
		internal void _003C_003Em__0(HttpErrorCode error, object resObj)
		{
		}
	}

	[Token(Token = "0x20031C8")]
	private sealed class _003CClaimPayLevelReward_003Ec__AnonStorey6
	{
		[Token(Token = "0x4012F3A")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x4012F3B")]
		[FieldOffset(Offset = "0xC")]
		internal uint level;

		[Token(Token = "0x4012F3C")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelPayment _0024this;

		[Token(Token = "0x6014FD4")]
		[Address(RVA = "0x31BCA28", Offset = "0x31BCA28", VA = "0x31BCA28")]
		public _003CClaimPayLevelReward_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x6014FD5")]
		[Address(RVA = "0x31BF450", Offset = "0x31BF450", VA = "0x31BF450")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20031C9")]
	private sealed class _003CExistUnawardedPayLevelReward_003Ec__AnonStorey7
	{
		[Token(Token = "0x4012F3D")]
		[FieldOffset(Offset = "0x8")]
		internal PayLevelRewardDesc item;

		[Token(Token = "0x6014FD6")]
		[Address(RVA = "0x31BDBD8", Offset = "0x31BDBD8", VA = "0x31BDBD8")]
		public _003CExistUnawardedPayLevelReward_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x6014FD7")]
		[Address(RVA = "0x31BF7B4", Offset = "0x31BF7B4", VA = "0x31BF7B4")]
		internal bool _003C_003Em__0(PlayLevelInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4012EAB")]
	[FieldOffset(Offset = "0xC")]
	private WaitingResponseHandler m_WaitingHandler;

	[Token(Token = "0x4012EAC")]
	[FieldOffset(Offset = "0x10")]
	private PaymentBundleState _003CBundleState_003Ek__BackingField;

	[Token(Token = "0x4012EAD")]
	[FieldOffset(Offset = "0x14")]
	private List<PlayLevelInfo> m_PayLevelInfos;

	[Token(Token = "0x4012EAE")]
	[FieldOffset(Offset = "0x18")]
	private List<PayLevelRewardDesc> m_PayLevelRewardDescs;

	[Token(Token = "0x4012EAF")]
	[FieldOffset(Offset = "0x1C")]
	private PayLevelPoolDesc _003CPayLevelPoolDesc_003Ek__BackingField;

	[Token(Token = "0x4012EB0")]
	[FieldOffset(Offset = "0x20")]
	private PayBundleWindowDesc m_GrowthFundBundleDesc;

	[Token(Token = "0x4012EB1")]
	[FieldOffset(Offset = "0x24")]
	public List<PlatformPromotionProductsData> PlatformPromotionProductDatas;

	[Token(Token = "0x4012EB2")]
	[FieldOffset(Offset = "0x28")]
	public ulong LastScanIAPInventoryTimeOnApplicationPause;

	[Token(Token = "0x4012EB3")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<uint, ResourceID> m_GrowthFundPics;

	[Token(Token = "0x4012EB4")]
	public const uint PropID_PaymentBundlesUpdated = 2u;

	[Token(Token = "0x4012EB5")]
	public const uint PropID_DiamondProductPurchased = 4u;

	[Token(Token = "0x4012EB6")]
	public const uint PropID_PaymentBundleExchanged = 8u;

	[Token(Token = "0x4012EB7")]
	public const uint PropID_MysteryBonusUpdated = 16u;

	[Token(Token = "0x4012EB8")]
	public const uint PropID_MysteryBonusSpinUpdated = 32u;

	[Token(Token = "0x4012EB9")]
	public const uint PropID_DiamondEvent = 64u;

	[Token(Token = "0x4012EBA")]
	public const uint PropID_SubscriptionBundlesUpdated = 128u;

	[Token(Token = "0x4012EBB")]
	public const uint PropID_SubscriptionBundleStatusUpdated = 256u;

	[Token(Token = "0x4012EBC")]
	public const uint PropID_SubscriptionBundleClaimed = 512u;

	[Token(Token = "0x4012EBD")]
	public const uint PropID_Subscribed = 1024u;

	[Token(Token = "0x4012EBE")]
	public const uint PropID_DiamondProductsUpdated = 2048u;

	[Token(Token = "0x4012EBF")]
	public const uint PropID_SubscriptionProductsUpdated = 4096u;

	[Token(Token = "0x4012EC0")]
	public const uint PropID_DiamondEventProductsUpdated = 8192u;

	[Token(Token = "0x4012EC1")]
	public const uint PropID_DiamondEventProductPurchased = 16384u;

	[Token(Token = "0x4012EC2")]
	public const uint PropID_GetGrowthFundDescs = 32768u;

	[Token(Token = "0x4012EC3")]
	public const uint PropID_PaymentBundlePurchased = 65536u;

	[Token(Token = "0x4012EC4")]
	public const uint PropID_GetPayLevelInfo = 131072u;

	[Token(Token = "0x4012EC5")]
	public const uint PropID_ClaimPayLevelReward = 262144u;

	[Token(Token = "0x4012EC6")]
	public const uint PropID_GetMysteryBonusProbability = 524288u;

	[Token(Token = "0x4012EC7")]
	public const string PAYMENTBUNDLENEWBIE = "PaymentBundleNewbie_";

	[Token(Token = "0x4012EC8")]
	public const string PAYMENTBUNDLEDISCOUNT = "PaymentBundleDiscount_";

	[Token(Token = "0x4012EC9")]
	[FieldOffset(Offset = "0x34")]
	private bool _003CHasOpenedLessIsMore_003Ek__BackingField;

	[Token(Token = "0x4012ECA")]
	[FieldOffset(Offset = "0x35")]
	private bool _003CHasClosedUI_003Ek__BackingField;

	[Token(Token = "0x4012ECB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly char[] SWITCH_CONTENT_SEPARATOR;

	[Token(Token = "0x4012ECC")]
	private const uint RELOAD_BUNDLES_INTERVAL_S = 1800u;

	[Token(Token = "0x4012ECD")]
	[FieldOffset(Offset = "0x38")]
	private ulong m_LastReloadBundles;

	[Token(Token = "0x4012ECE")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<uint, PayBundleWindowDesc> m_PaymentBundles;

	[Token(Token = "0x4012ECF")]
	[FieldOffset(Offset = "0x44")]
	private List<PayBundleWindowDesc> m_PaymentBundleList;

	[Token(Token = "0x4012ED0")]
	[FieldOffset(Offset = "0x48")]
	private ulong m_BundlesNextResetTime;

	[Token(Token = "0x4012ED1")]
	[FieldOffset(Offset = "0x50")]
	private List<SpecialStoreDesc> m_PaymentSpecialStores;

	[Token(Token = "0x4012ED2")]
	[FieldOffset(Offset = "0x54")]
	private uint m_PaymentBundleId_Paying;

	[Token(Token = "0x4012ED3")]
	[FieldOffset(Offset = "0x58")]
	private uint m_PaymentBundleId_Exchanging;

	[Token(Token = "0x4012ED4")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_currentBuyingBundleID;

	[Token(Token = "0x4012ED5")]
	[FieldOffset(Offset = "0x4")]
	private static readonly Dictionary<int, VersionInfo> _Versions;

	[Token(Token = "0x4012ED6")]
	[FieldOffset(Offset = "0x60")]
	private List<PayItemData> _DiamondProducts;

	[Token(Token = "0x4012ED7")]
	private const int REQUEST_MYSTERYBONUS_INTERVAL_S = 1200;

	[Token(Token = "0x4012ED8")]
	[FieldOffset(Offset = "0x64")]
	private float m_LastRequestMysteryBonusTime;

	[Token(Token = "0x4012ED9")]
	[FieldOffset(Offset = "0x68")]
	public MysteryBonusInfo m_MysteryBonusData;

	[Token(Token = "0x4012EDA")]
	[FieldOffset(Offset = "0x6C")]
	public CSMysteryBonusSpinRes m_MysteryBonusSpinData;

	[Token(Token = "0x4012EDB")]
	[FieldOffset(Offset = "0x70")]
	private bool hasRequestSpin;

	[Token(Token = "0x4012EDC")]
	[FieldOffset(Offset = "0x74")]
	private Dictionary<uint, SubscribeStoreDesc> m_DescriptionOfSubscriptions;

	[Token(Token = "0x4012EDD")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<uint, AccountSubscription> m_StatusOfSubscriptions;

	[Token(Token = "0x4012EDE")]
	[FieldOffset(Offset = "0x7C")]
	private Dictionary<uint, PayItemData> m_SubscriptionBundleProductsFromCSV;

	[Token(Token = "0x4012EDF")]
	private const string PLAYER_PREFS_KEY_HAS_SEEN_SUBSCRIPTION_HUB = "HasSeenPaymentSubscriptionHub";

	[Token(Token = "0x4012EE0")]
	private const string HAS_SEEN_GROWTH_FUND = "HasSeenPaymentGrowthFund";

	[Token(Token = "0x4012EE1")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<PayBundleWindowDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4012EE2")]
	[FieldOffset(Offset = "0xC")]
	private static Converter<PayBundleWindowDesc, string> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4012EE3")]
	[FieldOffset(Offset = "0x10")]
	private static Predicate<PayBundleWindowDesc> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4012EE4")]
	[FieldOffset(Offset = "0x14")]
	private static Converter<PayBundleWindowDesc, string> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x4012EE5")]
	[FieldOffset(Offset = "0x18")]
	private static Comparison<SpecialStoreDesc> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x4012EE6")]
	[FieldOffset(Offset = "0x1C")]
	private static Converter<AwardDesc, BaseItemInfo> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x4012EE7")]
	[FieldOffset(Offset = "0x20")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x4012EE8")]
	[FieldOffset(Offset = "0x24")]
	private static Converter<CSVBaseData, PayItemData> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x4012EE9")]
	[FieldOffset(Offset = "0x28")]
	private static Func<PayItemData, bool> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x4012EEA")]
	[FieldOffset(Offset = "0x2C")]
	private static Converter<PayItemData, string> _003C_003Ef__am_0024cache9;

	[Token(Token = "0x4012EEB")]
	[FieldOffset(Offset = "0x30")]
	private static Comparison<SubscribeStoreDesc> _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x4012EEC")]
	[FieldOffset(Offset = "0x34")]
	private static Action<PayUtility.SubscriptionGracePeriodReminderInfo> _003C_003Ef__am_0024cacheB;

	[Token(Token = "0x170015FE")]
	public PaymentBundleState BundleState
	{
		[Token(Token = "0x6014EF8")]
		[Address(RVA = "0x31ACF08", Offset = "0x31ACF08", VA = "0x31ACF08")]
		get
		{
			return default(PaymentBundleState);
		}
		[Token(Token = "0x6014EF9")]
		[Address(RVA = "0x31ACF10", Offset = "0x31ACF10", VA = "0x31ACF10")]
		private set
		{
		}
	}

	[Token(Token = "0x170015FF")]
	public List<PlayLevelInfo> PayLevelInfos
	{
		[Token(Token = "0x6014EFA")]
		[Address(RVA = "0x31ACF18", Offset = "0x31ACF18", VA = "0x31ACF18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001600")]
	public List<PayLevelRewardDesc> PayLevelRewardDescs
	{
		[Token(Token = "0x6014EFB")]
		[Address(RVA = "0x31ACF70", Offset = "0x31ACF70", VA = "0x31ACF70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001601")]
	public PayLevelPoolDesc PayLevelPoolDesc
	{
		[Token(Token = "0x6014EFD")]
		[Address(RVA = "0x31ACFD0", Offset = "0x31ACFD0", VA = "0x31ACFD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014EFC")]
		[Address(RVA = "0x31ACFC8", Offset = "0x31ACFC8", VA = "0x31ACFC8")]
		private set
		{
		}
	}

	[Token(Token = "0x17001602")]
	public PayBundleWindowDesc GrowthFundBundleDesc
	{
		[Token(Token = "0x6014EFE")]
		[Address(RVA = "0x31ACFD8", Offset = "0x31ACFD8", VA = "0x31ACFD8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001603")]
	public bool HasOpenedLessIsMore
	{
		[Token(Token = "0x6014EFF")]
		[Address(RVA = "0x31AD104", Offset = "0x31AD104", VA = "0x31AD104")]
		private get
		{
			return default(bool);
		}
		[Token(Token = "0x6014F00")]
		[Address(RVA = "0x31AD10C", Offset = "0x31AD10C", VA = "0x31AD10C")]
		set
		{
		}
	}

	[Token(Token = "0x17001604")]
	public bool HasClosedUI
	{
		[Token(Token = "0x6014F01")]
		[Address(RVA = "0x31AD114", Offset = "0x31AD114", VA = "0x31AD114")]
		private get
		{
			return default(bool);
		}
		[Token(Token = "0x6014F02")]
		[Address(RVA = "0x31AD11C", Offset = "0x31AD11C", VA = "0x31AD11C")]
		set
		{
		}
	}

	[Token(Token = "0x17001605")]
	public static bool LessIsMoreUseGMSDK
	{
		[Token(Token = "0x6014F03")]
		[Address(RVA = "0x31AD124", Offset = "0x31AD124", VA = "0x31AD124")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001606")]
	public static bool LessIsMoreGMSDKTest
	{
		[Token(Token = "0x6014F04")]
		[Address(RVA = "0x31AD28C", Offset = "0x31AD28C", VA = "0x31AD28C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001607")]
	public bool PaymentEnabled
	{
		[Token(Token = "0x6014F0B")]
		[Address(RVA = "0x31AEDE0", Offset = "0x31AEDE0", VA = "0x31AEDE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001608")]
	public string PaymentDisabledMessage
	{
		[Token(Token = "0x6014F0C")]
		[Address(RVA = "0x31AEE38", Offset = "0x31AEE38", VA = "0x31AEE38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001609")]
	public bool PaymentIAPEnabled
	{
		[Token(Token = "0x6014F0D")]
		[Address(RVA = "0x31AEF10", Offset = "0x31AEF10", VA = "0x31AEF10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700160A")]
	public bool GrowthFundEnabled
	{
		[Token(Token = "0x6014F0E")]
		[Address(RVA = "0x31AEF68", Offset = "0x31AEF68", VA = "0x31AEF68")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700160B")]
	public bool PaymentBundlesEnabled
	{
		[Token(Token = "0x6014F0F")]
		[Address(RVA = "0x31AEFC0", Offset = "0x31AEFC0", VA = "0x31AEFC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700160C")]
	public bool DiamondEventEnabled
	{
		[Token(Token = "0x6014F10")]
		[Address(RVA = "0x31AF10C", Offset = "0x31AF10C", VA = "0x31AF10C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700160D")]
	public bool ShopEnabled
	{
		[Token(Token = "0x6014F11")]
		[Address(RVA = "0x31AF164", Offset = "0x31AF164", VA = "0x31AF164")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700160E")]
	public bool ShopFirst
	{
		[Token(Token = "0x6014F13")]
		[Address(RVA = "0x31AF3C8", Offset = "0x31AF3C8", VA = "0x31AF3C8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700160F")]
	public bool IsEmbeddedMshop
	{
		[Token(Token = "0x6014F14")]
		[Address(RVA = "0x31AF4DC", Offset = "0x31AF4DC", VA = "0x31AF4DC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001610")]
	public Dictionary<uint, PayBundleWindowDesc> PaymentBundles
	{
		[Token(Token = "0x6014F16")]
		[Address(RVA = "0x31AF934", Offset = "0x31AF934", VA = "0x31AF934")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001611")]
	public List<PayBundleWindowDesc> PaymentBundleList
	{
		[Token(Token = "0x6014F17")]
		[Address(RVA = "0x31AF98C", Offset = "0x31AF98C", VA = "0x31AF98C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001612")]
	public ulong PaymentBundlesNextResetTime
	{
		[Token(Token = "0x6014F18")]
		[Address(RVA = "0x31AF9E4", Offset = "0x31AF9E4", VA = "0x31AF9E4")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6014F19")]
		[Address(RVA = "0x31AFAF0", Offset = "0x31AFAF0", VA = "0x31AFAF0")]
		private set
		{
		}
	}

	[Token(Token = "0x17001613")]
	public List<SpecialStoreDesc> PaymentSpecialStores
	{
		[Token(Token = "0x6014F1C")]
		[Address(RVA = "0x31B1628", Offset = "0x31B1628", VA = "0x31B1628")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001614")]
	public List<PayItemData> DiamondProducts
	{
		[Token(Token = "0x6014F2D")]
		[Address(RVA = "0x31B4544", Offset = "0x31B4544", VA = "0x31B4544")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001615")]
	public int SubscriptionBundleSwitch
	{
		[Token(Token = "0x6014F4D")]
		[Address(RVA = "0x31B87A8", Offset = "0x31B87A8", VA = "0x31B87A8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001616")]
	public bool HasSeenSubscriptionHub
	{
		[Token(Token = "0x6014F50")]
		[Address(RVA = "0x31B93D8", Offset = "0x31B93D8", VA = "0x31B93D8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001617")]
	public bool HasSeenGrowthFund
	{
		[Token(Token = "0x6014F51")]
		[Address(RVA = "0x31B94C0", Offset = "0x31B94C0", VA = "0x31B94C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6014EF7")]
	[Address(RVA = "0x31ACC58", Offset = "0x31ACC58", VA = "0x31ACC58")]
	public UIModelPayment()
	{
	}

	[Token(Token = "0x6014F05")]
	[Address(RVA = "0x31AD77C", Offset = "0x31AD77C", VA = "0x31AD77C")]
	private static bool LessIsMoreRightOnTime(ulong start, ulong end)
	{
		return default(bool);
	}

	[Token(Token = "0x6014F06")]
	[Address(RVA = "0x31ADA2C", Offset = "0x31ADA2C", VA = "0x31ADA2C", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014F07")]
	[Address(RVA = "0x31ADA84", Offset = "0x31ADA84", VA = "0x31ADA84", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6014F08")]
	[Address(RVA = "0x31AE41C", Offset = "0x31AE41C", VA = "0x31AE41C")]
	public void RequestSubscriptionBundles()
	{
	}

	[Token(Token = "0x6014F09")]
	[Address(RVA = "0x31AE838", Offset = "0x31AE838", VA = "0x31AE838", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014F0A")]
	[Address(RVA = "0x31AEAFC", Offset = "0x31AEAFC", VA = "0x31AEAFC")]
	private void GotoState(PaymentBundleState next)
	{
	}

	[Token(Token = "0x6014F12")]
	[Address(RVA = "0x31AF2AC", Offset = "0x31AF2AC", VA = "0x31AF2AC")]
	private bool IsSwitchOpen(ESwitch.SwitchFunc switchType)
	{
		return default(bool);
	}

	[Token(Token = "0x6014F15")]
	[Address(RVA = "0x31AF534", Offset = "0x31AF534", VA = "0x31AF534")]
	public void UpdatePaymentBundles(bool force = false, bool silence = false, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014F1A")]
	[Address(RVA = "0x31AFB6C", Offset = "0x31AFB6C", VA = "0x31AFB6C")]
	private void OnUpdatedPaymentBundles(HttpErrorCode error, object resObj)
	{
	}

	[Token(Token = "0x6014F1B")]
	[Address(RVA = "0x31B1528", Offset = "0x31B1528", VA = "0x31B1528")]
	public void OnDisplayPaymentBundles()
	{
	}

	[Token(Token = "0x6014F1D")]
	[Address(RVA = "0x31B1680", Offset = "0x31B1680", VA = "0x31B1680")]
	public void ProcessSpecialStoreDesc(CSGetPBWSpecialStoreRes res)
	{
	}

	[Token(Token = "0x6014F1E")]
	[Address(RVA = "0x31B19AC", Offset = "0x31B19AC", VA = "0x31B19AC")]
	public bool HasPaymentSpecialStore(EStore.PbwActivityType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6014F1F")]
	[Address(RVA = "0x31B1C80", Offset = "0x31B1C80", VA = "0x31B1C80")]
	public void PurchasePaymentBundle(uint id)
	{
	}

	[Token(Token = "0x6014F20")]
	[Address(RVA = "0x31B1E60", Offset = "0x31B1E60", VA = "0x31B1E60")]
	public BundlePurchaseError CheckPaymentBundlePurchasable(uint id)
	{
		return default(BundlePurchaseError);
	}

	[Token(Token = "0x6014F21")]
	[Address(RVA = "0x31B0D3C", Offset = "0x31B0D3C", VA = "0x31B0D3C")]
	private void PayForPendingPaymentBundle()
	{
	}

	[Token(Token = "0x6014F22")]
	[Address(RVA = "0x31B22E4", Offset = "0x31B22E4", VA = "0x31B22E4")]
	public void OnPaymentBundlePaid(bool success, string productIdentifier, long rebateId)
	{
	}

	[Token(Token = "0x6014F23")]
	[Address(RVA = "0x31B248C", Offset = "0x31B248C", VA = "0x31B248C")]
	private void ExchangePendingPaymentBundle()
	{
	}

	[Token(Token = "0x6014F24")]
	[Address(RVA = "0x31B2890", Offset = "0x31B2890", VA = "0x31B2890")]
	public bool BuyPaymentBundle(uint bundleID, EStore.PbwConsumeType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6014F25")]
	[Address(RVA = "0x31B055C", Offset = "0x31B055C", VA = "0x31B055C")]
	public void CheckFreeBundles()
	{
	}

	[Token(Token = "0x6014F26")]
	[Address(RVA = "0x31B2C34", Offset = "0x31B2C34", VA = "0x31B2C34")]
	private void OnPaymentBundlePaid(HttpErrorCode error, object resObj)
	{
	}

	[Token(Token = "0x6014F27")]
	[Address(RVA = "0x31B3024", Offset = "0x31B3024", VA = "0x31B3024")]
	private void OnPaymentBundleExchanged(HttpErrorCode error, object resObj)
	{
	}

	[Token(Token = "0x6014F28")]
	[Address(RVA = "0x31B342C", Offset = "0x31B342C", VA = "0x31B342C")]
	public void OnPaymentBundleReceived(CSPayBundleWindowPurchaseRes resObj)
	{
	}

	[Token(Token = "0x6014F29")]
	[Address(RVA = "0x31B3ACC", Offset = "0x31B3ACC", VA = "0x31B3ACC")]
	public void CacheVersion(VersionType versionType)
	{
	}

	[Token(Token = "0x6014F2A")]
	[Address(RVA = "0x31B3CB8", Offset = "0x31B3CB8", VA = "0x31B3CB8")]
	public bool SameVersion(VersionType versionType)
	{
		return default(bool);
	}

	[Token(Token = "0x6014F2B")]
	[Address(RVA = "0x31B3E54", Offset = "0x31B3E54", VA = "0x31B3E54")]
	private string GetLocalVersion(VersionType versionType)
	{
		return null;
	}

	[Token(Token = "0x6014F2C")]
	[Address(RVA = "0x31B40F8", Offset = "0x31B40F8", VA = "0x31B40F8")]
	public Dictionary<uint, PaymentButtonDisplayInfo> GetPaymentButton()
	{
		return null;
	}

	[Token(Token = "0x6014F2E")]
	[Address(RVA = "0x31ADF54", Offset = "0x31ADF54", VA = "0x31ADF54")]
	private void LoadDiamondProductsFromCSV()
	{
	}

	[Token(Token = "0x6014F2F")]
	[Address(RVA = "0x31B459C", Offset = "0x31B459C", VA = "0x31B459C")]
	public void ReloadDiamondProducts()
	{
	}

	[Token(Token = "0x6014F30")]
	[Address(RVA = "0x31B469C", Offset = "0x31B469C", VA = "0x31B469C")]
	public void PurchaseDiamondProduct(string productIdentifier)
	{
	}

	[Token(Token = "0x6014F31")]
	[Address(RVA = "0x31B4790", Offset = "0x31B4790", VA = "0x31B4790")]
	private void OnDiamondProductPurchased(string productIdentifier, int quantity)
	{
	}

	[Token(Token = "0x6014F32")]
	[Address(RVA = "0x31B4E88", Offset = "0x31B4E88", VA = "0x31B4E88")]
	public LessIsMoreEvent GetLessIsMoreEvent()
	{
		return null;
	}

	[Token(Token = "0x6014F33")]
	[Address(RVA = "0x31B4F04", Offset = "0x31B4F04", VA = "0x31B4F04")]
	public int GetLessIsMoreTier()
	{
		return default(int);
	}

	[Token(Token = "0x6014F34")]
	[Address(RVA = "0x31B515C", Offset = "0x31B515C", VA = "0x31B515C")]
	public void RequestTopupEvent(uint eventType, bool force = false, uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014F35")]
	[Address(RVA = "0x31B623C", Offset = "0x31B623C", VA = "0x31B623C")]
	public void UpdateEventData()
	{
	}

	[Token(Token = "0x6014F36")]
	[Address(RVA = "0x31B6F4C", Offset = "0x31B6F4C", VA = "0x31B6F4C")]
	public void ReloadDiamondEventProducts()
	{
	}

	[Token(Token = "0x6014F37")]
	[Address(RVA = "0x31B7084", Offset = "0x31B7084", VA = "0x31B7084")]
	public void RequestMysteryBonusSpin()
	{
	}

	[Token(Token = "0x6014F38")]
	[Address(RVA = "0x31B72C4", Offset = "0x31B72C4", VA = "0x31B72C4")]
	public void RequestGetMysteryBonusProbability()
	{
	}

	[Token(Token = "0x6014F39")]
	[Address(RVA = "0x31B56C4", Offset = "0x31B56C4", VA = "0x31B56C4")]
	private bool CanRequestMysteryBonus()
	{
		return default(bool);
	}

	[Token(Token = "0x6014F3A")]
	[Address(RVA = "0x31B756C", Offset = "0x31B756C", VA = "0x31B756C")]
	private bool IsBonusRequestInCoolDown()
	{
		return default(bool);
	}

	[Token(Token = "0x6014F3B")]
	[Address(RVA = "0x31B4B90", Offset = "0x31B4B90", VA = "0x31B4B90")]
	public bool HasBonusTopUpTimes()
	{
		return default(bool);
	}

	[Token(Token = "0x6014F3C")]
	[Address(RVA = "0x31B77EC", Offset = "0x31B77EC", VA = "0x31B77EC")]
	public uint GetRemainBonusTimes()
	{
		return default(uint);
	}

	[Token(Token = "0x6014F3D")]
	[Address(RVA = "0x31B4BF8", Offset = "0x31B4BF8", VA = "0x31B4BF8")]
	public uint GetBonusPercent()
	{
		return default(uint);
	}

	[Token(Token = "0x6014F3E")]
	[Address(RVA = "0x31B4C80", Offset = "0x31B4C80", VA = "0x31B4C80")]
	public void BonusTopupTimesAdd(uint time)
	{
	}

	[Token(Token = "0x6014F3F")]
	[Address(RVA = "0x31B76A8", Offset = "0x31B76A8", VA = "0x31B76A8")]
	public bool HasOpeningBonusEvent()
	{
		return default(bool);
	}

	[Token(Token = "0x6014F40")]
	[Address(RVA = "0x31B74E8", Offset = "0x31B74E8", VA = "0x31B74E8")]
	public bool IsValidMysteryBonusData()
	{
		return default(bool);
	}

	[Token(Token = "0x6014F41")]
	[Address(RVA = "0x31B78CC", Offset = "0x31B78CC", VA = "0x31B78CC")]
	public bool IsValidDiamondEvent()
	{
		return default(bool);
	}

	[Token(Token = "0x6014F42")]
	[Address(RVA = "0x31B79F8", Offset = "0x31B79F8", VA = "0x31B79F8")]
	public bool IsDiamondEventVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6014F43")]
	[Address(RVA = "0x31B7B70", Offset = "0x31B7B70", VA = "0x31B7B70")]
	public void SetDiamondEventTipsNum()
	{
	}

	[Token(Token = "0x6014F44")]
	[Address(RVA = "0x31B7C84", Offset = "0x31B7C84", VA = "0x31B7C84")]
	public void PurchaseDiamondEventProduct(string productIdentifier)
	{
	}

	[Token(Token = "0x6014F45")]
	[Address(RVA = "0x31B7E18", Offset = "0x31B7E18", VA = "0x31B7E18")]
	public static RebateCardType? ConvertToRebateCardType(ESubscription.PriceType price_type)
	{
		return null;
	}

	[Token(Token = "0x6014F46")]
	[Address(RVA = "0x31B7F24", Offset = "0x31B7F24", VA = "0x31B7F24")]
	public static SubscriptionPeriod ConvertToSubscriptionPeriod(ESubscription.PriceType price_type)
	{
		return default(SubscriptionPeriod);
	}

	[Token(Token = "0x6014F47")]
	[Address(RVA = "0x31B7F94", Offset = "0x31B7F94", VA = "0x31B7F94")]
	public PayItemData SubscriptionBundleProductFromCSV(uint store_id)
	{
		return null;
	}

	[Token(Token = "0x6014F48")]
	[Address(RVA = "0x31B8330", Offset = "0x31B8330", VA = "0x31B8330")]
	public List<SubscribeStoreDesc> Subscriptions()
	{
		return null;
	}

	[Token(Token = "0x6014F49")]
	[Address(RVA = "0x31B8248", Offset = "0x31B8248", VA = "0x31B8248")]
	public SubscribeStoreDesc DescriptionOfSubscription(uint store_id)
	{
		return null;
	}

	[Token(Token = "0x6014F4A")]
	[Address(RVA = "0x31B8B0C", Offset = "0x31B8B0C", VA = "0x31B8B0C")]
	public bool SubscriptionBundleBonusAvailable(uint store_id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014F4B")]
	[Address(RVA = "0x31B8BA8", Offset = "0x31B8BA8", VA = "0x31B8BA8")]
	public AccountSubscription StatusOfSubscription(uint store_id)
	{
		return null;
	}

	[Token(Token = "0x6014F4C")]
	[Address(RVA = "0x31B88FC", Offset = "0x31B88FC", VA = "0x31B88FC")]
	public bool CanDisplaySubscription(uint store_id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014F4E")]
	[Address(RVA = "0x31AE4FC", Offset = "0x31AE4FC", VA = "0x31AE4FC")]
	private void FetchSubscriptionBundles(uint http = 0u)
	{
	}

	[Token(Token = "0x6014F4F")]
	[Address(RVA = "0x31B8C98", Offset = "0x31B8C98", VA = "0x31B8C98")]
	public void ShowSubscriptionBundleHint(uint store_id, Vector3 position)
	{
	}

	[Token(Token = "0x6014F52")]
	[Address(RVA = "0x31B95A8", Offset = "0x31B95A8", VA = "0x31B95A8")]
	public bool EnableSubscriptionHub()
	{
		return default(bool);
	}

	[Token(Token = "0x6014F53")]
	[Address(RVA = "0x31B9600", Offset = "0x31B9600", VA = "0x31B9600")]
	public void SeenGrowthFund()
	{
	}

	[Token(Token = "0x6014F54")]
	[Address(RVA = "0x31B9804", Offset = "0x31B9804", VA = "0x31B9804")]
	public void SeenSubscriptionHub()
	{
	}

	[Token(Token = "0x6014F55")]
	[Address(RVA = "0x31B9B38", Offset = "0x31B9B38", VA = "0x31B9B38")]
	public void UpdateSubscriptionHubProducts()
	{
	}

	[Token(Token = "0x6014F56")]
	[Address(RVA = "0x31B9C38", Offset = "0x31B9C38", VA = "0x31B9C38")]
	public void UpdateSubscriptionBundleStatus(uint httpOption = 0u)
	{
	}

	[Token(Token = "0x6014F57")]
	[Address(RVA = "0x31B91B4", Offset = "0x31B91B4", VA = "0x31B91B4")]
	public PayItemData SubscriptionProduct_CSV(uint store_id)
	{
		return null;
	}

	[Token(Token = "0x6014F58")]
	[Address(RVA = "0x31B8F5C", Offset = "0x31B8F5C", VA = "0x31B8F5C")]
	public PayItemData SubscriptionProduct_SDK(uint store_id)
	{
		return null;
	}

	[Token(Token = "0x6014F59")]
	[Address(RVA = "0x31B9E98", Offset = "0x31B9E98", VA = "0x31B9E98")]
	public bool HasRedDotForSubscription(uint store_id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014F5A")]
	[Address(RVA = "0x31B98EC", Offset = "0x31B98EC", VA = "0x31B98EC")]
	private void UpdateSubscriptionHubTips()
	{
	}

	[Token(Token = "0x6014F5B")]
	[Address(RVA = "0x31B96E8", Offset = "0x31B96E8", VA = "0x31B96E8")]
	private void UpdateGrowthFundTips()
	{
	}

	[Token(Token = "0x6014F5C")]
	[Address(RVA = "0x31BA1E8", Offset = "0x31BA1E8", VA = "0x31BA1E8")]
	public bool WithinSubscriptionPeriod(uint store_id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014F5D")]
	[Address(RVA = "0x31BA274", Offset = "0x31BA274", VA = "0x31BA274")]
	public bool WithinSubscriptionPeriod(PayItemData csv, PayItemData sdk)
	{
		return default(bool);
	}

	[Token(Token = "0x6014F5E")]
	[Address(RVA = "0x31BA320", Offset = "0x31BA320", VA = "0x31BA320")]
	public bool Subscribing(uint store_id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014F5F")]
	[Address(RVA = "0x31B9F88", Offset = "0x31B9F88", VA = "0x31B9F88")]
	public bool Subscribing(PayItemData csv, PayItemData sdk)
	{
		return default(bool);
	}

	[Token(Token = "0x6014F60")]
	[Address(RVA = "0x31BA3AC", Offset = "0x31BA3AC", VA = "0x31BA3AC")]
	public bool InGracePeriod(PayItemData csv, PayItemData sdk)
	{
		return default(bool);
	}

	[Token(Token = "0x6014F61")]
	[Address(RVA = "0x31BA470", Offset = "0x31BA470", VA = "0x31BA470")]
	public bool IsOnHold(PayItemData csv, PayItemData sdk)
	{
		return default(bool);
	}

	[Token(Token = "0x6014F62")]
	[Address(RVA = "0x31BA51C", Offset = "0x31BA51C", VA = "0x31BA51C")]
	public void OnServerNoticedPayment(uint rebate_card_id)
	{
	}

	[Token(Token = "0x6014F63")]
	[Address(RVA = "0x31BA71C", Offset = "0x31BA71C", VA = "0x31BA71C")]
	public void ClaimSubscriptionBundle(uint store_id)
	{
	}

	[Token(Token = "0x6014F64")]
	[Address(RVA = "0x31BAABC", Offset = "0x31BAABC", VA = "0x31BAABC")]
	private void _ClaimSubscriptionBundle(uint store_id)
	{
	}

	[Token(Token = "0x6014F65")]
	[Address(RVA = "0x31BAD90", Offset = "0x31BAD90", VA = "0x31BAD90")]
	public void Subscribe(uint store_id)
	{
	}

	[Token(Token = "0x6014F66")]
	[Address(RVA = "0x31BB5FC", Offset = "0x31BB5FC", VA = "0x31BB5FC")]
	private void OnSubscribed(string subscriptionProductIdentifier)
	{
	}

	[Token(Token = "0x6014F67")]
	[Address(RVA = "0x31BBE78", Offset = "0x31BBE78", VA = "0x31BBE78")]
	public void GetGrowthFundDescs()
	{
	}

	[Token(Token = "0x6014F68")]
	[Address(RVA = "0x31BBF40", Offset = "0x31BBF40", VA = "0x31BBF40")]
	public void OnGetPayLevelConfig(CSGetPayLevelConfigRes res, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014F69")]
	[Address(RVA = "0x31BC450", Offset = "0x31BC450", VA = "0x31BC450")]
	public PlayLevelInfo GetPayLevelItemInfo(uint id, uint level)
	{
		return null;
	}

	[Token(Token = "0x6014F6A")]
	[Address(RVA = "0x31BC1B0", Offset = "0x31BC1B0", VA = "0x31BC1B0")]
	public void GetPayLevelInfo(uint id, bool silence = false, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014F6B")]
	[Address(RVA = "0x31BC624", Offset = "0x31BC624", VA = "0x31BC624")]
	public void ClaimPayLevelReward(uint id, uint level)
	{
	}

	[Token(Token = "0x6014F6C")]
	[Address(RVA = "0x31BCA30", Offset = "0x31BCA30", VA = "0x31BCA30")]
	public ResourceID GetPayLevelRewardIcon(uint level)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6014F6D")]
	[Address(RVA = "0x31BCE3C", Offset = "0x31BCE3C", VA = "0x31BCE3C")]
	public uint GetTotalPayLevelRewardDiamondCount()
	{
		return default(uint);
	}

	[Token(Token = "0x6014F6E")]
	[Address(RVA = "0x31BD074", Offset = "0x31BD074", VA = "0x31BD074")]
	public uint GetPayLevelMaxLevel()
	{
		return default(uint);
	}

	[Token(Token = "0x6014F6F")]
	[Address(RVA = "0x31BD228", Offset = "0x31BD228", VA = "0x31BD228")]
	public uint GetCurPayLevelInfoFinishedLevel()
	{
		return default(uint);
	}

	[Token(Token = "0x6014F70")]
	[Address(RVA = "0x31BD5D4", Offset = "0x31BD5D4", VA = "0x31BD5D4")]
	public EStore.PayLevelRewardHintType GetCurPayLevelDescHint()
	{
		return default(EStore.PayLevelRewardHintType);
	}

	[Token(Token = "0x6014F71")]
	[Address(RVA = "0x31BD798", Offset = "0x31BD798", VA = "0x31BD798")]
	public bool HasBoughtGrowthFund()
	{
		return default(bool);
	}

	[Token(Token = "0x6014F72")]
	[Address(RVA = "0x31BD820", Offset = "0x31BD820", VA = "0x31BD820")]
	private uint GetBundlePurchaseTimes(uint bundleId)
	{
		return default(uint);
	}

	[Token(Token = "0x6014F73")]
	[Address(RVA = "0x31BA030", Offset = "0x31BA030", VA = "0x31BA030")]
	public bool ExistFinishedPayLevelReward()
	{
		return default(bool);
	}

	[Token(Token = "0x6014F74")]
	[Address(RVA = "0x31BD944", Offset = "0x31BD944", VA = "0x31BD944")]
	public bool ExistUnawardedPayLevelReward()
	{
		return default(bool);
	}

	[Token(Token = "0x6014F75")]
	[Address(RVA = "0x31BDBE0", Offset = "0x31BDBE0", VA = "0x31BDBE0")]
	public EStore.PayLevelInfoState CalcPayLevelInfoState(uint level)
	{
		return default(EStore.PayLevelInfoState);
	}

	[Token(Token = "0x6014F77")]
	[Address(RVA = "0x31BE2B0", Offset = "0x31BE2B0", VA = "0x31BE2B0")]
	private static bool _003COnUpdatedPaymentBundles_003Em__0(PayBundleWindowDesc bundle)
	{
		return default(bool);
	}

	[Token(Token = "0x6014F78")]
	[Address(RVA = "0x31BE2DC", Offset = "0x31BE2DC", VA = "0x31BE2DC")]
	private static string _003COnUpdatedPaymentBundles_003Em__1(PayBundleWindowDesc bundle)
	{
		return null;
	}

	[Token(Token = "0x6014F79")]
	[Address(RVA = "0x31BE374", Offset = "0x31BE374", VA = "0x31BE374")]
	private static bool _003COnUpdatedPaymentBundles_003Em__2(PayBundleWindowDesc bundle)
	{
		return default(bool);
	}

	[Token(Token = "0x6014F7A")]
	[Address(RVA = "0x31BE3A0", Offset = "0x31BE3A0", VA = "0x31BE3A0")]
	private static string _003COnUpdatedPaymentBundles_003Em__3(PayBundleWindowDesc bundle)
	{
		return null;
	}

	[Token(Token = "0x6014F7B")]
	[Address(RVA = "0x31BE438", Offset = "0x31BE438", VA = "0x31BE438")]
	private static int _003CProcessSpecialStoreDesc_003Em__4(SpecialStoreDesc a, SpecialStoreDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x6014F7C")]
	[Address(RVA = "0x31BE480", Offset = "0x31BE480", VA = "0x31BE480")]
	private void _003CPayForPendingPaymentBundle_003Em__5(bool purchasing, string product, long rebateId)
	{
	}

	[Token(Token = "0x6014F7D")]
	[Address(RVA = "0x31BE490", Offset = "0x31BE490", VA = "0x31BE490")]
	private static BaseItemInfo _003COnPaymentBundleReceived_003Em__6(AwardDesc reward)
	{
		return null;
	}

	[Token(Token = "0x6014F7E")]
	[Address(RVA = "0x31BE514", Offset = "0x31BE514", VA = "0x31BE514")]
	private static CommonRewardItemInfo _003COnPaymentBundleReceived_003Em__7(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x6014F7F")]
	[Address(RVA = "0x31BE51C", Offset = "0x31BE51C", VA = "0x31BE51C")]
	private static PayItemData _003CLoadDiamondProductsFromCSV_003Em__8(CSVBaseData csvData)
	{
		return null;
	}

	[Token(Token = "0x6014F80")]
	[Address(RVA = "0x31BE838", Offset = "0x31BE838", VA = "0x31BE838")]
	private static bool _003CLoadDiamondProductsFromCSV_003Em__9(PayItemData p)
	{
		return default(bool);
	}

	[Token(Token = "0x6014F81")]
	[Address(RVA = "0x31BE844", Offset = "0x31BE844", VA = "0x31BE844")]
	private static string _003CLoadDiamondProductsFromCSV_003Em__A(PayItemData product)
	{
		return null;
	}

	[Token(Token = "0x6014F82")]
	[Address(RVA = "0x31BE868", Offset = "0x31BE868", VA = "0x31BE868")]
	private void _003CRequestMysteryBonusSpin_003Em__B(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014F83")]
	[Address(RVA = "0x31BE9C4", Offset = "0x31BE9C4", VA = "0x31BE9C4")]
	private void _003CRequestGetMysteryBonusProbability_003Em__C(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x6014F84")]
	[Address(RVA = "0x31BEB4C", Offset = "0x31BEB4C", VA = "0x31BEB4C")]
	private static int _003CSubscriptions_003Em__D(SubscribeStoreDesc a, SubscribeStoreDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x6014F85")]
	[Address(RVA = "0x31BEB8C", Offset = "0x31BEB8C", VA = "0x31BEB8C")]
	private void _003CUpdateSubscriptionBundleStatus_003Em__E(HttpErrorCode error, object resObj)
	{
	}

	[Token(Token = "0x6014F86")]
	[Address(RVA = "0x31BEDF4", Offset = "0x31BEDF4", VA = "0x31BEDF4")]
	private static void _003CClaimSubscriptionBundle_003Em__F(PayUtility.SubscriptionGracePeriodReminderInfo info)
	{
	}

	[Token(Token = "0x6014F87")]
	[Address(RVA = "0x31BEEAC", Offset = "0x31BEEAC", VA = "0x31BEEAC")]
	private void _003CGetPayLevelInfo_003Em__10(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014F88")]
	[Address(RVA = "0x31BF01C", Offset = "0x31BF01C", VA = "0x31BF01C")]
	private static string _003C_Versions_003Em__11()
	{
		return null;
	}

	[Token(Token = "0x6014F89")]
	[Address(RVA = "0x31BF098", Offset = "0x31BF098", VA = "0x31BF098")]
	private static string _003C_Versions_003Em__12()
	{
		return null;
	}

	[Token(Token = "0x6014F8A")]
	[Address(RVA = "0x31BF124", Offset = "0x31BF124", VA = "0x31BF124")]
	private static string _003C_Versions_003Em__13()
	{
		return null;
	}

	[Token(Token = "0x6014F8B")]
	[Address(RVA = "0x31BF1A0", Offset = "0x31BF1A0", VA = "0x31BF1A0")]
	private static string _003C_Versions_003Em__14()
	{
		return null;
	}

	[Token(Token = "0x6014F8C")]
	[Address(RVA = "0x31BF22C", Offset = "0x31BF22C", VA = "0x31BF22C")]
	private static string _003C_Versions_003Em__15()
	{
		return null;
	}

	[Token(Token = "0x6014F8D")]
	[Address(RVA = "0x31BF2A8", Offset = "0x31BF2A8", VA = "0x31BF2A8")]
	private static string _003C_Versions_003Em__16()
	{
		return null;
	}

	[Token(Token = "0x6014F8E")]
	[Address(RVA = "0x31BF334", Offset = "0x31BF334", VA = "0x31BF334")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x6014F8F")]
	[Address(RVA = "0x31BF33C", Offset = "0x31BF33C", VA = "0x31BF33C")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
