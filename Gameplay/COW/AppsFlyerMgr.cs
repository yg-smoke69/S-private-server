using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000084")]
public class AppsFlyerMgr
{
	[Token(Token = "0x2000085")]
	public class GDPR_Identity
	{
		[Token(Token = "0x40002C4")]
		[FieldOffset(Offset = "0x8")]
		public string identity_type;

		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0xC")]
		public string identity_value;

		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x10")]
		public string identity_format;

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x14CB21C", Offset = "0x14CB21C", VA = "0x14CB21C")]
		public GDPR_Identity()
		{
		}
	}

	[Token(Token = "0x2000086")]
	public class GDPR_Req
	{
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x8")]
		public string subject_request_id;

		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0xC")]
		public string subject_request_type;

		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x10")]
		public GDPR_Identity[] subject_identities;

		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x14")]
		public string submitted_time;

		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x18")]
		public string property_id;

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x14CB214", Offset = "0x14CB214", VA = "0x14CB214")]
		public GDPR_Req()
		{
		}
	}

	[Token(Token = "0x40002BF")]
	public const string PRODUCT_TYPE_REBATE_CARD = "RebateCard";

	[Token(Token = "0x40002C0")]
	public const string PRODUCT_TYPE_IAP = "IAP";

	[Token(Token = "0x40002C1")]
	[FieldOffset(Offset = "0x0")]
	public static string FirstAppOpenKey;

	[Token(Token = "0x40002C2")]
	[FieldOffset(Offset = "0x4")]
	public static string FirstLoginKey;

	[Token(Token = "0x40002C3")]
	[FieldOffset(Offset = "0x8")]
	private static AdvertisingIdentifierCallback _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x1700006D")]
	public static string OpenId
	{
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x14C810C", Offset = "0x14C810C", VA = "0x14C810C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700006E")]
	public static string AccountId
	{
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x14C81EC", Offset = "0x14C81EC", VA = "0x14C81EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700006F")]
	public static string Region
	{
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x14C82C4", Offset = "0x14C82C4", VA = "0x14C82C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000070")]
	public static string LoginType
	{
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x14C83C8", Offset = "0x14C83C8", VA = "0x14C83C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000071")]
	public static string Version
	{
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x14C84E4", Offset = "0x14C84E4", VA = "0x14C84E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000072")]
	public static string Language
	{
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x14C85D0", Offset = "0x14C85D0", VA = "0x14C85D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000073")]
	public static string Channel
	{
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x14C86F8", Offset = "0x14C86F8", VA = "0x14C86F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x14C8104", Offset = "0x14C8104", VA = "0x14C8104")]
	public AppsFlyerMgr()
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x14C8794", Offset = "0x14C8794", VA = "0x14C8794")]
	public static void OnLogout()
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x14C890C", Offset = "0x14C890C", VA = "0x14C890C")]
	public static void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x14C8B48", Offset = "0x14C8B48", VA = "0x14C8B48")]
	public static void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x14C8850", Offset = "0x14C8850", VA = "0x14C8850")]
	public static void SendCacheEvent()
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x14C8CE0", Offset = "0x14C8CE0", VA = "0x14C8CE0")]
	public static void trackEventFirstAppOpen()
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x14C8E64", Offset = "0x14C8E64", VA = "0x14C8E64")]
	public static void trackEventAppOpen()
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x14C8FE8", Offset = "0x14C8FE8", VA = "0x14C8FE8")]
	public static void trackEventHfBegin(string localVersion, string pkgSize)
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x14C919C", Offset = "0x14C919C", VA = "0x14C919C")]
	public static void trackEventHfComplete(ResErrorCode error_code)
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x14C9318", Offset = "0x14C9318", VA = "0x14C9318")]
	public static void trackEventRegistration()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x14C9558", Offset = "0x14C9558", VA = "0x14C9558")]
	public static void trackEventLogin()
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x14C9754", Offset = "0x14C9754", VA = "0x14C9754")]
	public static void trackEventEnterLobby()
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x14C990C", Offset = "0x14C990C", VA = "0x14C990C")]
	public static void trackEventTutorial()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x14C9AC4", Offset = "0x14C9AC4", VA = "0x14C9AC4")]
	public static void trackEventPurchase()
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x14C9DA4", Offset = "0x14C9DA4", VA = "0x14C9DA4")]
	public static void trackEventEnterShop()
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x14C9F5C", Offset = "0x14C9F5C", VA = "0x14C9F5C")]
	public static void trackEventBuyCard()
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x14CA194", Offset = "0x14CA194", VA = "0x14CA194")]
	public static void trackEventAppStart(string local_version, string region)
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x14CA1F0", Offset = "0x14CA1F0", VA = "0x14CA1F0")]
	public static void trackEventLoginMethod()
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x14CA23C", Offset = "0x14CA23C", VA = "0x14CA23C")]
	public static void trackEventObbDownload(string lang)
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x14CA384", Offset = "0x14CA384", VA = "0x14CA384")]
	public static void trackEventInviteFriend(ulong accountID)
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x14CA590", Offset = "0x14CA590", VA = "0x14CA590")]
	public static void trackEventPurchase(ulong accountID, string productType, string productID, string currency, double revenue)
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x14CA624", Offset = "0x14CA624", VA = "0x14CA624")]
	public static void trackEventGooglePlayGiftCard(ulong accountID, string productID, int amount)
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x14CA698", Offset = "0x14CA698", VA = "0x14CA698")]
	public static void trackEventActivityAwarded()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x14CA6E4", Offset = "0x14CA6E4", VA = "0x14CA6E4")]
	public static void trackEventStoreClicks()
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x14C8C94", Offset = "0x14C8C94", VA = "0x14C8C94")]
	public static void SendEventStoreClicks()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x14CA730", Offset = "0x14CA730", VA = "0x14CA730")]
	public static void SetTrackEnable(bool enable)
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x14CA7FC", Offset = "0x14CA7FC", VA = "0x14CA7FC")]
	public static void RequestDelPersonalData()
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x14CAA84", Offset = "0x14CAA84", VA = "0x14CAA84")]
	private static void GetAdvertisingIdentifierCallBack(string advertisingId, bool trackingEnabled, string errorMsg)
	{
	}
}
