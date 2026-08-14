using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20030AA")]
public class UIModelIAPBundle : UIBaseModel
{
	[Token(Token = "0x20030AB")]
	public enum State
	{
		[Token(Token = "0x4012840")]
		NotLoaded,
		[Token(Token = "0x4012841")]
		Loading,
		[Token(Token = "0x4012842")]
		Purchasable,
		[Token(Token = "0x4012843")]
		NotPurchasable,
		[Token(Token = "0x4012844")]
		Paying,
		[Token(Token = "0x4012845")]
		Exchanging,
		[Token(Token = "0x4012846")]
		Pending,
		[Token(Token = "0x4012847")]
		DiamondExchanging
	}

	[Token(Token = "0x20030AC")]
	private class IAPBundlesDelegate : PayUtility.PaymentDelegate
	{
		[Token(Token = "0x4012848")]
		[FieldOffset(Offset = "0x0")]
		private static IAPBundlesDelegate _I;

		[Token(Token = "0x1700152B")]
		public static IAPBundlesDelegate I
		{
			[Token(Token = "0x6014604")]
			[Address(RVA = "0x12BE398", Offset = "0x12BE398", VA = "0x12BE398")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700152C")]
		public override string Name
		{
			[Token(Token = "0x6014605")]
			[Address(RVA = "0x12C48B8", Offset = "0x12C48B8", VA = "0x12C48B8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6014603")]
		[Address(RVA = "0x12C48B0", Offset = "0x12C48B0", VA = "0x12C48B0")]
		public IAPBundlesDelegate()
		{
		}

		[Token(Token = "0x6014606")]
		[Address(RVA = "0x12C495C", Offset = "0x12C495C", VA = "0x12C495C", Slot = "13")]
		public override void OnProductsUpdated(string task, bool result, string[] productIdentifiers)
		{
		}

		[Token(Token = "0x6014607")]
		[Address(RVA = "0x12C4AF4", Offset = "0x12C4AF4", VA = "0x12C4AF4", Slot = "19")]
		public override bool PaymentAfterRecommitted(int pendingProduct, int[] recommittedProducts)
		{
			return default(bool);
		}

		[Token(Token = "0x6014608")]
		[Address(RVA = "0x12C4C38", Offset = "0x12C4C38", VA = "0x12C4C38", Slot = "16")]
		public override ProductPurchasedReaction OnProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, long rebateId, int quantity)
		{
			return null;
		}

		[Token(Token = "0x6014609")]
		[Address(RVA = "0x12C4DC0", Offset = "0x12C4DC0", VA = "0x12C4DC0")]
		public void _003C_003EiFixBaseProxy_OnProductsUpdated(string P0, bool P1, string[] P2)
		{
		}

		[Token(Token = "0x601460A")]
		[Address(RVA = "0x12C4DE0", Offset = "0x12C4DE0", VA = "0x12C4DE0")]
		public bool _003C_003EiFixBaseProxy_PaymentAfterRecommitted(int P0, int[] P1)
		{
			return default(bool);
		}

		[Token(Token = "0x601460B")]
		[Address(RVA = "0x12C4DE8", Offset = "0x12C4DE8", VA = "0x12C4DE8")]
		public ProductPurchasedReaction _003C_003EiFixBaseProxy_OnProductPurchased(string P0, ProductPurchasedResult P1, string P2, long P3, int P4)
		{
			return null;
		}
	}

	[Token(Token = "0x20030AD")]
	private sealed class _003CPurchase_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012849")]
		[FieldOffset(Offset = "0x8")]
		internal string productIdentifier;

		[Token(Token = "0x401284A")]
		[FieldOffset(Offset = "0xC")]
		internal int rebateID;

		[Token(Token = "0x401284B")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelIAPBundle _0024this;

		[Token(Token = "0x601460C")]
		[Address(RVA = "0x12C077C", Offset = "0x12C077C", VA = "0x12C077C")]
		public _003CPurchase_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601460D")]
		[Address(RVA = "0x12C4734", Offset = "0x12C4734", VA = "0x12C4734")]
		internal void _003C_003Em__0(bool purchasing, string product, long rebateId)
		{
		}
	}

	[Token(Token = "0x20030AE")]
	private sealed class _003CPurchase_003Ec__AnonStorey1
	{
		[Token(Token = "0x401284C")]
		[FieldOffset(Offset = "0x8")]
		internal string productIdentifier;

		[Token(Token = "0x401284D")]
		[FieldOffset(Offset = "0x10")]
		internal long rebateID;

		[Token(Token = "0x401284E")]
		[FieldOffset(Offset = "0x18")]
		internal UIModelIAPBundle _0024this;

		[Token(Token = "0x601460E")]
		[Address(RVA = "0x12C0CD8", Offset = "0x12C0CD8", VA = "0x12C0CD8")]
		public _003CPurchase_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x601460F")]
		[Address(RVA = "0x12C47A4", Offset = "0x12C47A4", VA = "0x12C47A4")]
		internal void _003C_003Em__0(bool purchasing, string product, long rebateId)
		{
		}
	}

	[Token(Token = "0x20030AF")]
	private sealed class _003CRequestPurchaseForRecommitted_003Ec__AnonStorey2
	{
		[Token(Token = "0x401284F")]
		[FieldOffset(Offset = "0x8")]
		internal int[] recommittedProductIDs;

		[Token(Token = "0x6014610")]
		[Address(RVA = "0x12C3278", Offset = "0x12C3278", VA = "0x12C3278")]
		public _003CRequestPurchaseForRecommitted_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6014611")]
		[Address(RVA = "0x12C4814", Offset = "0x12C4814", VA = "0x12C4814")]
		internal bool _003C_003Em__0(IAPBundleStoreData datum)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x401282A")]
	public const uint PropID_Available = 2u;

	[Token(Token = "0x401282B")]
	public const uint PropID_Unavailable = 4u;

	[Token(Token = "0x401282C")]
	public const uint PropID_IAPResult = 8u;

	[Token(Token = "0x401282D")]
	public const uint PropID_GotBundle = 16u;

	[Token(Token = "0x401282E")]
	public const uint PropID_Pending = 32u;

	[Token(Token = "0x401282F")]
	public const uint PropID_DiamondExchanging = 64u;

	[Token(Token = "0x4012830")]
	public const uint PropID_DiamondPurchaseFail = 128u;

	[Token(Token = "0x4012831")]
	public const uint PropID_ProductUpdate = 256u;

	[Token(Token = "0x4012832")]
	public const uint PropID_DiamondGotBundle = 512u;

	[Token(Token = "0x4012833")]
	[FieldOffset(Offset = "0xC")]
	private int m_CurrentStoreID;

	[Token(Token = "0x4012834")]
	[FieldOffset(Offset = "0x10")]
	private ulong m_EndTime_S;

	[Token(Token = "0x4012835")]
	[FieldOffset(Offset = "0x18")]
	private string m_Slogan;

	[Token(Token = "0x4012836")]
	[FieldOffset(Offset = "0x1C")]
	private State _003CCurrentState_003Ek__BackingField;

	[Token(Token = "0x4012837")]
	[FieldOffset(Offset = "0x20")]
	private bool m_DeepLink;

	[Token(Token = "0x4012838")]
	[FieldOffset(Offset = "0x24")]
	private IAPBundleStoreData _PendingIAPBundle;

	[Token(Token = "0x4012839")]
	private const string PLAYER_PREFS_KEY_IAP_BUNDLE = "IAPBundleEndTime";

	[Token(Token = "0x401283A")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<IAPInfoItem> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x401283B")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<CSVBaseData, IAPBundleStoreData> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x401283C")]
	[FieldOffset(Offset = "0x8")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x401283D")]
	[FieldOffset(Offset = "0xC")]
	private static Converter<AwardDesc, BaseItemInfo> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x401283E")]
	[FieldOffset(Offset = "0x10")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x17001529")]
	public State CurrentState
	{
		[Token(Token = "0x60145DB")]
		[Address(RVA = "0x12BDC80", Offset = "0x12BDC80", VA = "0x12BDC80")]
		get
		{
			return default(State);
		}
		[Token(Token = "0x60145DC")]
		[Address(RVA = "0x12BDC88", Offset = "0x12BDC88", VA = "0x12BDC88")]
		private set
		{
		}
	}

	[Token(Token = "0x1700152A")]
	public string Slogan
	{
		[Token(Token = "0x60145E8")]
		[Address(RVA = "0x12BED88", Offset = "0x12BED88", VA = "0x12BED88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60145DA")]
	[Address(RVA = "0x12BDBB4", Offset = "0x12BDBB4", VA = "0x12BDBB4")]
	public UIModelIAPBundle()
	{
	}

	[Token(Token = "0x60145DD")]
	[Address(RVA = "0x12BDC90", Offset = "0x12BDC90", VA = "0x12BDC90", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x60145DE")]
	[Address(RVA = "0x12BE5D0", Offset = "0x12BE5D0", VA = "0x12BE5D0", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60145DF")]
	[Address(RVA = "0x12BE6D8", Offset = "0x12BE6D8", VA = "0x12BE6D8", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60145E0")]
	[Address(RVA = "0x12BE47C", Offset = "0x12BE47C", VA = "0x12BE47C")]
	public bool AllPurchasable()
	{
		return default(bool);
	}

	[Token(Token = "0x60145E1")]
	[Address(RVA = "0x12BE730", Offset = "0x12BE730", VA = "0x12BE730")]
	public EStoreType GetCurBundleStoreType()
	{
		return default(EStoreType);
	}

	[Token(Token = "0x60145E2")]
	[Address(RVA = "0x12BE8D8", Offset = "0x12BE8D8", VA = "0x12BE8D8")]
	public bool IsVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x60145E3")]
	[Address(RVA = "0x12BEBA8", Offset = "0x12BEBA8", VA = "0x12BEBA8")]
	public bool IsPurchasable()
	{
		return default(bool);
	}

	[Token(Token = "0x60145E4")]
	[Address(RVA = "0x12BEB50", Offset = "0x12BEB50", VA = "0x12BEB50")]
	public int CurrentIAPBundleStoreID()
	{
		return default(int);
	}

	[Token(Token = "0x60145E5")]
	[Address(RVA = "0x12BE7A8", Offset = "0x12BE7A8", VA = "0x12BE7A8")]
	public IAPBundleStoreData CurrentIAPBundleStore()
	{
		return null;
	}

	[Token(Token = "0x60145E6")]
	[Address(RVA = "0x12BECB8", Offset = "0x12BECB8", VA = "0x12BECB8")]
	public ulong PurchaseEnd_S()
	{
		return default(ulong);
	}

	[Token(Token = "0x60145E7")]
	[Address(RVA = "0x12BED30", Offset = "0x12BED30", VA = "0x12BED30")]
	public ulong EndTime_S()
	{
		return default(ulong);
	}

	[Token(Token = "0x60145E9")]
	[Address(RVA = "0x12BEDE0", Offset = "0x12BEDE0", VA = "0x12BEDE0")]
	public int PurchaseCountdown_S()
	{
		return default(int);
	}

	[Token(Token = "0x60145EA")]
	[Address(RVA = "0x12BEEC8", Offset = "0x12BEEC8", VA = "0x12BEEC8")]
	public void OnDeepLinked()
	{
	}

	[Token(Token = "0x60145EB")]
	[Address(RVA = "0x12BEFCC", Offset = "0x12BEFCC", VA = "0x12BEFCC")]
	public void GotoState(State next)
	{
	}

	[Token(Token = "0x60145EC")]
	[Address(RVA = "0x12BF78C", Offset = "0x12BF78C", VA = "0x12BF78C")]
	public void FakeTrigger()
	{
	}

	[Token(Token = "0x60145ED")]
	[Address(RVA = "0x12BFD44", Offset = "0x12BFD44", VA = "0x12BFD44")]
	private bool CheckPurchaseValid()
	{
		return default(bool);
	}

	[Token(Token = "0x60145EE")]
	[Address(RVA = "0x12C0264", Offset = "0x12C0264", VA = "0x12C0264")]
	public void Purchase([Optional] IAPBundleStoreData data)
	{
	}

	[Token(Token = "0x60145EF")]
	[Address(RVA = "0x12C0784", Offset = "0x12C0784", VA = "0x12C0784")]
	public void Purchase(VipCardRebateDesc cardDesc, [Optional] IAPBundleStoreData data)
	{
	}

	[Token(Token = "0x60145F0")]
	[Address(RVA = "0x12C0CE0", Offset = "0x12C0CE0", VA = "0x12C0CE0")]
	private void OnPurchased(bool success, string productIdentifier, int rebateId)
	{
	}

	[Token(Token = "0x60145F1")]
	[Address(RVA = "0x12C1A04", Offset = "0x12C1A04", VA = "0x12C1A04")]
	public void RequestIAPBundle(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x60145F2")]
	[Address(RVA = "0x12C1D88", Offset = "0x12C1D88", VA = "0x12C1D88")]
	private void OnIAPBundleResponse(HttpErrorCode errorCode, object response)
	{
	}

	[Token(Token = "0x60145F3")]
	[Address(RVA = "0x12C15A4", Offset = "0x12C15A4", VA = "0x12C15A4")]
	private void RequestPurchase()
	{
	}

	[Token(Token = "0x60145F4")]
	[Address(RVA = "0x12C2AB8", Offset = "0x12C2AB8", VA = "0x12C2AB8")]
	private bool RequestPurchaseForRecommitted(int[] recommittedProductIDs, int pendingProductID)
	{
		return default(bool);
	}

	[Token(Token = "0x60145F5")]
	[Address(RVA = "0x12C3280", Offset = "0x12C3280", VA = "0x12C3280")]
	public void RequestDiamondPurchase(IAPBundleStoreData data)
	{
	}

	[Token(Token = "0x60145F6")]
	[Address(RVA = "0x12C36B8", Offset = "0x12C36B8", VA = "0x12C36B8")]
	public void OnReceivedPurchasedBundle(CSIAPPurchaseRes response)
	{
	}

	[Token(Token = "0x60145F7")]
	[Address(RVA = "0x12C3B00", Offset = "0x12C3B00", VA = "0x12C3B00")]
	public string GetNotifyText()
	{
		return null;
	}

	[Token(Token = "0x60145F8")]
	[Address(RVA = "0x12BF5E4", Offset = "0x12BF5E4", VA = "0x12BF5E4")]
	public bool GetIsFirstTime()
	{
		return default(bool);
	}

	[Token(Token = "0x60145F9")]
	[Address(RVA = "0x12C3F1C", Offset = "0x12C3F1C", VA = "0x12C3F1C")]
	public void SetIsFirstTime(bool isFirstTime)
	{
	}

	[Token(Token = "0x60145FA")]
	[Address(RVA = "0x12C4068", Offset = "0x12C4068", VA = "0x12C4068")]
	private static bool _003COnIAPBundleResponse_003Em__0(IAPInfoItem temp)
	{
		return default(bool);
	}

	[Token(Token = "0x60145FB")]
	[Address(RVA = "0x12C4098", Offset = "0x12C4098", VA = "0x12C4098")]
	private void _003CRequestPurchase_003Em__1(HttpErrorCode errorCode, object response)
	{
	}

	[Token(Token = "0x60145FC")]
	[Address(RVA = "0x12C4354", Offset = "0x12C4354", VA = "0x12C4354")]
	private static IAPBundleStoreData _003CRequestPurchaseForRecommitted_003Em__2(CSVBaseData datum)
	{
		return null;
	}

	[Token(Token = "0x60145FD")]
	[Address(RVA = "0x12C43E8", Offset = "0x12C43E8", VA = "0x12C43E8")]
	private static void _003CRequestPurchaseForRecommitted_003Em__3(HttpErrorCode errorCode, object response)
	{
	}

	[Token(Token = "0x60145FE")]
	[Address(RVA = "0x12C4688", Offset = "0x12C4688", VA = "0x12C4688")]
	private void _003CRequestDiamondPurchase_003Em__4(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60145FF")]
	[Address(RVA = "0x12C4698", Offset = "0x12C4698", VA = "0x12C4698")]
	private static BaseItemInfo _003COnReceivedPurchasedBundle_003Em__5(AwardDesc reward)
	{
		return null;
	}

	[Token(Token = "0x6014600")]
	[Address(RVA = "0x12C471C", Offset = "0x12C471C", VA = "0x12C471C")]
	private static CommonRewardItemInfo _003COnReceivedPurchasedBundle_003Em__6(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x6014601")]
	[Address(RVA = "0x12C4724", Offset = "0x12C4724", VA = "0x12C4724")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x6014602")]
	[Address(RVA = "0x12C472C", Offset = "0x12C472C", VA = "0x12C472C")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
