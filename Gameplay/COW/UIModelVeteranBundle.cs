using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20032AC")]
public class UIModelVeteranBundle : UIBaseModel
{
	[Token(Token = "0x20032AD")]
	public enum State
	{
		[Token(Token = "0x40134C2")]
		NotLoaded,
		[Token(Token = "0x40134C3")]
		Loading,
		[Token(Token = "0x40134C4")]
		Purchasable,
		[Token(Token = "0x40134C5")]
		NotPurchasable,
		[Token(Token = "0x40134C6")]
		Paying,
		[Token(Token = "0x40134C7")]
		Exchanging,
		[Token(Token = "0x40134C8")]
		Pending
	}

	[Token(Token = "0x20032AE")]
	private class VeteranBundlesDelegate : PayUtility.PaymentDelegate
	{
		[Token(Token = "0x40134C9")]
		[FieldOffset(Offset = "0x0")]
		private static VeteranBundlesDelegate _I;

		[Token(Token = "0x1700169A")]
		public static VeteranBundlesDelegate I
		{
			[Token(Token = "0x60155FB")]
			[Address(RVA = "0x1935B04", Offset = "0x1935B04", VA = "0x1935B04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700169B")]
		public override string Name
		{
			[Token(Token = "0x60155FC")]
			[Address(RVA = "0x1935BE8", Offset = "0x1935BE8", VA = "0x1935BE8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60155FA")]
		[Address(RVA = "0x1935AFC", Offset = "0x1935AFC", VA = "0x1935AFC")]
		public VeteranBundlesDelegate()
		{
		}

		[Token(Token = "0x60155FD")]
		[Address(RVA = "0x1935C8C", Offset = "0x1935C8C", VA = "0x1935C8C", Slot = "13")]
		public override void OnProductsUpdated(string task, bool result, string[] productIdentifiers)
		{
		}

		[Token(Token = "0x60155FE")]
		[Address(RVA = "0x1935E24", Offset = "0x1935E24", VA = "0x1935E24", Slot = "16")]
		public override ProductPurchasedReaction OnProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, long rebateId, int quantity)
		{
			return null;
		}

		[Token(Token = "0x60155FF")]
		[Address(RVA = "0x1935FB4", Offset = "0x1935FB4", VA = "0x1935FB4")]
		public void _003C_003EiFixBaseProxy_OnProductsUpdated(string P0, bool P1, string[] P2)
		{
		}

		[Token(Token = "0x6015600")]
		[Address(RVA = "0x1935FD4", Offset = "0x1935FD4", VA = "0x1935FD4")]
		public ProductPurchasedReaction _003C_003EiFixBaseProxy_OnProductPurchased(string P0, ProductPurchasedResult P1, string P2, long P3, int P4)
		{
			return null;
		}
	}

	[Token(Token = "0x20032AF")]
	private sealed class _003CPurchase_003Ec__AnonStorey0
	{
		[Token(Token = "0x40134CA")]
		[FieldOffset(Offset = "0x8")]
		internal string productIdentifier;

		[Token(Token = "0x40134CB")]
		[FieldOffset(Offset = "0xC")]
		internal int rebateID;

		[Token(Token = "0x40134CC")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelVeteranBundle _0024this;

		[Token(Token = "0x6015601")]
		[Address(RVA = "0x1935A78", Offset = "0x1935A78", VA = "0x1935A78")]
		public _003CPurchase_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6015602")]
		[Address(RVA = "0x1935A80", Offset = "0x1935A80", VA = "0x1935A80")]
		internal void _003C_003Em__0(bool purchasing, string product, long rebateId)
		{
		}
	}

	[Token(Token = "0x40134B7")]
	public const uint PropID_Available = 2u;

	[Token(Token = "0x40134B8")]
	public const uint PropID_Unavailable = 4u;

	[Token(Token = "0x40134B9")]
	public const uint PropID_IAPResult = 8u;

	[Token(Token = "0x40134BA")]
	public const uint PropID_GotBundle = 16u;

	[Token(Token = "0x40134BB")]
	public const uint PropID_Pending = 32u;

	[Token(Token = "0x40134BC")]
	public const uint PropID_ProductUpdate = 64u;

	[Token(Token = "0x40134BD")]
	[FieldOffset(Offset = "0xC")]
	private State _003CCurrentVeteranBundlePurchaseState_003Ek__BackingField;

	[Token(Token = "0x40134BE")]
	[FieldOffset(Offset = "0x10")]
	private IAPInfoItem m_VeteranIAPInfo;

	[Token(Token = "0x40134BF")]
	[FieldOffset(Offset = "0x14")]
	private IAPBundleStoreData _PendingIAPBundle;

	[Token(Token = "0x40134C0")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<IAPInfoItem> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17001698")]
	public State CurrentVeteranBundlePurchaseState
	{
		[Token(Token = "0x60155E5")]
		[Address(RVA = "0x16AA7FC", Offset = "0x16AA7FC", VA = "0x16AA7FC")]
		get
		{
			return default(State);
		}
		[Token(Token = "0x60155E6")]
		[Address(RVA = "0x16AA804", Offset = "0x16AA804", VA = "0x16AA804")]
		private set
		{
		}
	}

	[Token(Token = "0x17001699")]
	public IAPInfoItem VeteranIAPInfo
	{
		[Token(Token = "0x60155E7")]
		[Address(RVA = "0x16AA80C", Offset = "0x16AA80C", VA = "0x16AA80C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60155E4")]
	[Address(RVA = "0x16AA73C", Offset = "0x16AA73C", VA = "0x16AA73C")]
	public UIModelVeteranBundle()
	{
	}

	[Token(Token = "0x60155E8")]
	[Address(RVA = "0x16AA864", Offset = "0x16AA864", VA = "0x16AA864", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x60155E9")]
	[Address(RVA = "0x16AA95C", Offset = "0x16AA95C", VA = "0x16AA95C", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60155EA")]
	[Address(RVA = "0x16AAA3C", Offset = "0x16AAA3C", VA = "0x16AAA3C")]
	public ulong GetEndTime()
	{
		return default(ulong);
	}

	[Token(Token = "0x60155EB")]
	[Address(RVA = "0x16AAAAC", Offset = "0x16AAAAC", VA = "0x16AAAAC", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60155EC")]
	[Address(RVA = "0x16AAB04", Offset = "0x16AAB04", VA = "0x16AAB04")]
	public bool IsVeteranBundleVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x60155ED")]
	[Address(RVA = "0x16AACC8", Offset = "0x16AACC8", VA = "0x16AACC8")]
	public bool IsVeteranBundlePurchasable()
	{
		return default(bool);
	}

	[Token(Token = "0x60155EE")]
	[Address(RVA = "0x16AAE1C", Offset = "0x16AAE1C", VA = "0x16AAE1C")]
	public bool CanPurchaseVeteranBundle()
	{
		return default(bool);
	}

	[Token(Token = "0x60155EF")]
	[Address(RVA = "0x16AAC58", Offset = "0x16AAC58", VA = "0x16AAC58")]
	public int CurVeteranBundleStoreID()
	{
		return default(int);
	}

	[Token(Token = "0x60155F0")]
	[Address(RVA = "0x16AAF34", Offset = "0x16AAF34", VA = "0x16AAF34")]
	public IAPBundleStoreData CurVeteranBundleStore()
	{
		return null;
	}

	[Token(Token = "0x60155F1")]
	[Address(RVA = "0x16AB064", Offset = "0x16AB064", VA = "0x16AB064")]
	public void ChangeVeteranBundlePurchaseState(State next)
	{
	}

	[Token(Token = "0x60155F2")]
	[Address(RVA = "0x16AB364", Offset = "0x16AB364", VA = "0x16AB364")]
	public void Purchase([Optional] IAPBundleStoreData data)
	{
	}

	[Token(Token = "0x60155F3")]
	[Address(RVA = "0x16ABC2C", Offset = "0x16ABC2C", VA = "0x16ABC2C")]
	public void OnPurchased(bool success, string productIdentifier, int rebateId)
	{
	}

	[Token(Token = "0x60155F4")]
	[Address(RVA = "0x16AC7A8", Offset = "0x16AC7A8", VA = "0x16AC7A8")]
	public void OnIAPBundleResponse(HttpErrorCode errorCode, CSGetAccountIAPInfoRes response)
	{
	}

	[Token(Token = "0x60155F5")]
	[Address(RVA = "0x16AC348", Offset = "0x16AC348", VA = "0x16AC348")]
	public void RequestPurchase()
	{
	}

	[Token(Token = "0x60155F6")]
	[Address(RVA = "0x16AD060", Offset = "0x16AD060", VA = "0x16AD060")]
	private void OnPurchaseResponse(HttpErrorCode errorCode, object response)
	{
	}

	[Token(Token = "0x60155F7")]
	[Address(RVA = "0x16AD37C", Offset = "0x16AD37C", VA = "0x16AD37C")]
	private static bool _003COnIAPBundleResponse_003Em__0(IAPInfoItem temp)
	{
		return default(bool);
	}

	[Token(Token = "0x60155F8")]
	[Address(RVA = "0x16AD3A8", Offset = "0x16AD3A8", VA = "0x16AD3A8")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x60155F9")]
	[Address(RVA = "0x16AD3B0", Offset = "0x16AD3B0", VA = "0x16AD3B0")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
