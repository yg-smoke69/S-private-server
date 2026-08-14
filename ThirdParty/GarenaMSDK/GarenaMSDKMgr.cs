using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GarenaMSDK;

[Token(Token = "0x200000E")]
public class GarenaMSDKMgr : MonoBehaviour
{
	[Token(Token = "0x200000F")]
	private sealed class _003CGetPlatformBindingInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x8")]
		internal Action<SDKBind.PlatformBindingInfo> callback;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0xC")]
		internal GarenaMSDKMgr _0024this;

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x344F770", Offset = "0x344F770", VA = "0x344F770")]
		public _003CGetPlatformBindingInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x3452540", Offset = "0x3452540", VA = "0x3452540")]
		internal void _003C_003Em__0(SDKBind.PlatformBindingInfo info)
		{
		}
	}

	[Token(Token = "0x2000010")]
	private sealed class _003COnGetPlatformBindingInfoComplete_003Ec__AnonStorey1
	{
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x8")]
		internal string platformBindingInfo;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0xC")]
		internal GarenaMSDKMgr _0024this;

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x344F9BC", Offset = "0x344F9BC", VA = "0x344F9BC")]
		public _003COnGetPlatformBindingInfoComplete_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x34525CC", Offset = "0x34525CC", VA = "0x34525CC")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2000011")]
	private sealed class _003COnGetPlatformBindingSession_003Ec__AnonStorey2
	{
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x8")]
		internal string loginRsp;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0xC")]
		internal GarenaMSDKMgr _0024this;

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x344FCCC", Offset = "0x344FCCC", VA = "0x344FCCC")]
		public _003COnGetPlatformBindingSession_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x3452798", Offset = "0x3452798", VA = "0x3452798")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2000012")]
	private sealed class _003COnPerformPlatformBindingComplete_003Ec__AnonStorey3
	{
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x8")]
		internal string result;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0xC")]
		internal GarenaMSDKMgr _0024this;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x344FF48", Offset = "0x344FF48", VA = "0x344FF48")]
		public _003COnPerformPlatformBindingComplete_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x3452940", Offset = "0x3452940", VA = "0x3452940")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0xC")]
	public bool EnableDebugLog;

	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x10")]
	private string _003CGuestOpenID_003Ek__BackingField;

	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x14")]
	private string _003CGuestAccessToken_003Ek__BackingField;

	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x18")]
	private string _003COpenID_003Ek__BackingField;

	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x1C")]
	private string _003CAccessToken_003Ek__BackingField;

	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x20")]
	private AccountPlatform _003CPlatform_003Ek__BackingField;

	[Token(Token = "0x40000B4")]
	private const string PLAYER_PREFS_KEY_LOGIN_PLATFORM = "GMSDK_LOGIN_PLATFORM";

	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x24")]
	private string appId;

	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x28")]
	private string appKey;

	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x2C")]
	private string appPushKey;

	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x30")]
	private SDKLogin sdkLogin;

	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x34")]
	private SDKBind sdkBind;

	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x0")]
	private static GarenaMSDKMgr instance;

	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x4")]
	private static bool InitFlag;

	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0x38")]
	private SDKBind.PlatformBindingInfo _003CPlatformBindingInfo_003Ek__BackingField;

	[Token(Token = "0x17000003")]
	public string GuestOpenID
	{
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x344CF48", Offset = "0x344CF48", VA = "0x344CF48")]
		get
		{
			return null;
		}
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x344CF50", Offset = "0x344CF50", VA = "0x344CF50")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public string GuestAccessToken
	{
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x344CF58", Offset = "0x344CF58", VA = "0x344CF58")]
		get
		{
			return null;
		}
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x344CF60", Offset = "0x344CF60", VA = "0x344CF60")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public string OpenID
	{
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x344CF68", Offset = "0x344CF68", VA = "0x344CF68")]
		get
		{
			return null;
		}
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x344CF70", Offset = "0x344CF70", VA = "0x344CF70")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public string AccessToken
	{
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x344CF78", Offset = "0x344CF78", VA = "0x344CF78")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x344CF80", Offset = "0x344CF80", VA = "0x344CF80")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public AccountPlatform Platform
	{
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x344CF88", Offset = "0x344CF88", VA = "0x344CF88")]
		get
		{
			return default(AccountPlatform);
		}
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x344CF90", Offset = "0x344CF90", VA = "0x344CF90")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public AccountPlatform LoginPlatform
	{
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x344CF98", Offset = "0x344CF98", VA = "0x344CF98")]
		get
		{
			return default(AccountPlatform);
		}
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x344D088", Offset = "0x344D088", VA = "0x344D088")]
		private set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public static GarenaMSDKMgr Instance
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x344D178", Offset = "0x344D178", VA = "0x344D178")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000A")]
	public SDKBind.PlatformBindingInfo PlatformBindingInfo
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x344F624", Offset = "0x344F624", VA = "0x344F624")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x344EA74", Offset = "0x344EA74", VA = "0x344EA74")]
		private set
		{
		}
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x344CE90", Offset = "0x344CE90", VA = "0x344CE90")]
	public GarenaMSDKMgr()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x344D204", Offset = "0x344D204", VA = "0x344D204")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x344D2F8", Offset = "0x344D2F8", VA = "0x344D2F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x344D2FC", Offset = "0x344D2FC", VA = "0x344D2FC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x344D300", Offset = "0x344D300", VA = "0x344D300")]
	public bool IsPlatformInstalled(AccountPlatform platform)
	{
		return default(bool);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x344D588", Offset = "0x344D588", VA = "0x344D588")]
	public void InitSDK(string appId, string appKey, string appPushKey, bool production, bool force = false)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x344DAEC", Offset = "0x344DAEC", VA = "0x344DAEC")]
	public static void SetOverrideRootUrl(string url)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x344DC88", Offset = "0x344DC88", VA = "0x344DC88")]
	public static void SetOverrideNewRootUrl(string url)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x344DE24", Offset = "0x344DE24", VA = "0x344DE24")]
	public static void SetGoogleClientID(string googleClientID)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x344DF4C", Offset = "0x344DF4C", VA = "0x344DF4C")]
	public AccountPlatform GetLoginRecord()
	{
		return default(AccountPlatform);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x344E048", Offset = "0x344E048", VA = "0x344E048")]
	public bool SupportGuestMigration()
	{
		return default(bool);
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x344E144", Offset = "0x344E144", VA = "0x344E144")]
	public bool NeedGuestMigration()
	{
		return default(bool);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x344E240", Offset = "0x344E240", VA = "0x344E240")]
	public void MigrateGuest(SDKLogin.SAFGuestCb onMigrate)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x344E340", Offset = "0x344E340", VA = "0x344E340")]
	public bool SupportGuestBackup()
	{
		return default(bool);
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x344E43C", Offset = "0x344E43C", VA = "0x344E43C")]
	public bool NeedsGuestBackup()
	{
		return default(bool);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x344E538", Offset = "0x344E538", VA = "0x344E538")]
	public void BackupGuest(SDKLogin.SAFGuestCb onBackup)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x344E638", Offset = "0x344E638", VA = "0x344E638")]
	public void AutosaveGuest(SDKLogin.SAFGuestCb onAutosave)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x344E738", Offset = "0x344E738", VA = "0x344E738")]
	public bool PlatformAvailable(AccountPlatform platform)
	{
		return default(bool);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x344E804", Offset = "0x344E804", VA = "0x344E804")]
	public void Login(AccountPlatform accountPlatform, bool autoLogin, SDKLogin.LoginSuccessCb loginSuccess, SDKLogin.LoginFailCb loginFail)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x344EA3C", Offset = "0x344EA3C", VA = "0x344EA3C")]
	public void Logout()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x344EB40", Offset = "0x344EB40", VA = "0x344EB40")]
	public void OnLogin(string msg)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x344ED50", Offset = "0x344ED50", VA = "0x344ED50")]
	public void GetBindSession(AccountPlatform platform, SDKBind.GetBindSessionSuccessCb getBindSessionSuccess, SDKBind.GetBindSessionFaildCb getBindSessionFaild)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x344EF40", Offset = "0x344EF40", VA = "0x344EF40")]
	public void OnGetBindSession(string msg)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x344F0CC", Offset = "0x344F0CC", VA = "0x344F0CC")]
	public void OnClearThirdPartySession()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x344F114", Offset = "0x344F114", VA = "0x344F114")]
	public void ResetGuest()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x344F270", Offset = "0x344F270", VA = "0x344F270")]
	public void OnMigrateGuestResult(string result)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x344F3AC", Offset = "0x344F3AC", VA = "0x344F3AC")]
	public void OnBackupGuestResult(string result)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x344F4E8", Offset = "0x344F4E8", VA = "0x344F4E8")]
	public void OnAutosaveGuestResult(string result)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x344F62C", Offset = "0x344F62C", VA = "0x344F62C")]
	public void GetPlatformBindingInfo(Action<SDKBind.PlatformBindingInfo> callback)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x344F848", Offset = "0x344F848", VA = "0x344F848")]
	public void OnGetPlatformBindingInfoComplete(string platformBindingInfo)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x344F9C4", Offset = "0x344F9C4", VA = "0x344F9C4")]
	public void GetPlatformBindingSession(AccountPlatform platform, Action<BindSessionRsp> callback)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x344FB58", Offset = "0x344FB58", VA = "0x344FB58")]
	public void OnGetPlatformBindingSession(string loginRsp)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x344FCD4", Offset = "0x344FCD4", VA = "0x344FCD4")]
	public void PerformPlatformBinding(Action<SDKBind.PerformPlatformBindingResult> callback)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x344FDD4", Offset = "0x344FDD4", VA = "0x344FDD4")]
	public void OnPerformPlatformBindingComplete(string result)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x344FF50", Offset = "0x344FF50", VA = "0x344FF50")]
	public void SendGameToSessionException(string message)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x344FF54", Offset = "0x344FF54", VA = "0x344FF54")]
	public void SendGameToSessionCallback(string pluginResult)
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x344FF58", Offset = "0x344FF58", VA = "0x344FF58")]
	public void SendMediaToSessionCallback(string pluginResult)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x344FF5C", Offset = "0x344FF5C", VA = "0x344FF5C")]
	public void SendLinkToSessionCallback(string pluginResult)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x344FF60", Offset = "0x344FF60", VA = "0x344FF60")]
	public void ShareToFacebookException(string message)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x344FF64", Offset = "0x344FF64", VA = "0x344FF64")]
	public void ShareToFacebookCallback(string pluginResult)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x344FF68", Offset = "0x344FF68", VA = "0x344FF68")]
	public void SendLinkToFacebookCallback(string pluginResult)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x344FF6C", Offset = "0x344FF6C", VA = "0x344FF6C")]
	public void SendRequestInvitationToFacebookCallback(string pluginResult)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x344FF70", Offset = "0x344FF70", VA = "0x344FF70")]
	public void SendGameRequestToFacebookUserCallback(string pluginResult)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x3450264", Offset = "0x3450264", VA = "0x3450264")]
	public void ShareToVkCallback(string pluginResult)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x3450268", Offset = "0x3450268", VA = "0x3450268")]
	public void onGetRebateOptions(string getRebateOptionsResult)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x34505BC", Offset = "0x34505BC", VA = "0x34505BC")]
	public void onRedeemResultObtained(string redeemResult)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x34509A0", Offset = "0x34509A0", VA = "0x34509A0")]
	public void onPaymentOptionsLoaded(string loadPaymentOptionsResult)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x3450EC0", Offset = "0x3450EC0", VA = "0x3450EC0")]
	public void onPaymentProcessed_Exception(string transactionInfo)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x3451118", Offset = "0x3451118", VA = "0x3451118")]
	public void onPaymentProcessed(string transactionInfo)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x3451370", Offset = "0x3451370", VA = "0x3451370")]
	public void onScanGoogleInAppPurchaseInventoryResult(string result)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x3451AC0", Offset = "0x3451AC0", VA = "0x3451AC0")]
	public void onLoadEventConfigsResult(string result)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x3451D34", Offset = "0x3451D34", VA = "0x3451D34")]
	public void onEventPaymentOptionsLoaded(string result)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x3451FA8", Offset = "0x3451FA8", VA = "0x3451FA8")]
	public void onEventPaymentProcessed_Exception(string result)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x3452200", Offset = "0x3452200", VA = "0x3452200")]
	public void onEventPaymentProcessed(string result)
	{
	}

	[Token(Token = "0x600007D")]
	private static void _DebugCallback<T>(string cb, string tString)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x3452458", Offset = "0x3452458", VA = "0x3452458")]
	public bool ShouldLogoutForErrorCode(ErrorCode errorCode)
	{
		return default(bool);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x3452484", Offset = "0x3452484", VA = "0x3452484")]
	public void DebugPlatformLogin(AccountPlatform platform, string openID, string token)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x3452494", Offset = "0x3452494", VA = "0x3452494")]
	public void DebugRestorePlatformInfo()
	{
	}
}
