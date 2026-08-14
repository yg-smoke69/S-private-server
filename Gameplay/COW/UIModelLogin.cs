using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using GarenaMSDK;
using Il2CppDummyDll;
using LitJson;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2003100")]
internal class UIModelLogin : UIBaseModel
{
	[Serializable]
	[Token(Token = "0x2003101")]
	public class CachedPlayerInfo
	{
		[Token(Token = "0x4012A54")]
		[FieldOffset(Offset = "0x8")]
		public string Nickname;

		[Token(Token = "0x4012A55")]
		[FieldOffset(Offset = "0xC")]
		public int GarenaConnectFacebook;

		[Token(Token = "0x60148E1")]
		[Address(RVA = "0x1B010C4", Offset = "0x1B010C4", VA = "0x1B010C4")]
		public CachedPlayerInfo()
		{
		}
	}

	[Token(Token = "0x2003102")]
	private class ServerStatusInfo
	{
		[Token(Token = "0x4012A56")]
		[FieldOffset(Offset = "0x8")]
		public uint code;

		[Token(Token = "0x4012A57")]
		[FieldOffset(Offset = "0xC")]
		public string billboard_msg;

		[Token(Token = "0x60148E2")]
		[Address(RVA = "0x1B190F8", Offset = "0x1B190F8", VA = "0x1B190F8")]
		public ServerStatusInfo()
		{
		}
	}

	[Token(Token = "0x2003103")]
	public enum ELogoutType
	{
		[Token(Token = "0x4012A59")]
		Manually,
		[Token(Token = "0x4012A5A")]
		Exception
	}

	[Token(Token = "0x2003104")]
	private sealed class _003CPrepareLoadingVideo_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4012A5B")]
		[FieldOffset(Offset = "0x8")]
		internal UILoadingVideoPlayer _003CloadingVideo_003E__0;

		[Token(Token = "0x4012A5C")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLogin _0024this;

		[Token(Token = "0x4012A5D")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4012A5E")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x4012A5F")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x1700156A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60148E5")]
			[Address(RVA = "0x1B1695C", Offset = "0x1B1695C", VA = "0x1B1695C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700156B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60148E6")]
			[Address(RVA = "0x1B16964", Offset = "0x1B16964", VA = "0x1B16964", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60148E3")]
		[Address(RVA = "0x1B00064", Offset = "0x1B00064", VA = "0x1B00064")]
		public _003CPrepareLoadingVideo_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60148E4")]
		[Address(RVA = "0x1B165CC", Offset = "0x1B165CC", VA = "0x1B165CC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60148E7")]
		[Address(RVA = "0x1B1696C", Offset = "0x1B1696C", VA = "0x1B1696C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60148E8")]
		[Address(RVA = "0x1B16980", Offset = "0x1B16980", VA = "0x1B16980", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2003105")]
	private sealed class _003COnLoginSDK_Garena_Failure_003Ec__AnonStorey1
	{
		[Token(Token = "0x4012A60")]
		[FieldOffset(Offset = "0x8")]
		internal ErrorCode errCode;

		[Token(Token = "0x4012A61")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLogin _0024this;

		[Token(Token = "0x60148E9")]
		[Address(RVA = "0x1B04240", Offset = "0x1B04240", VA = "0x1B04240")]
		public _003COnLoginSDK_Garena_Failure_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60148EA")]
		[Address(RVA = "0x1B1659C", Offset = "0x1B1659C", VA = "0x1B1659C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2003106")]
	private sealed class _003CDebugRequestLogin_003Ec__AnonStorey2
	{
		[Token(Token = "0x4012A62")]
		[FieldOffset(Offset = "0x8")]
		internal LoginReq req;

		[Token(Token = "0x4012A63")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLogin _0024this;

		[Token(Token = "0x60148EB")]
		[Address(RVA = "0x1B06E84", Offset = "0x1B06E84", VA = "0x1B06E84")]
		public _003CDebugRequestLogin_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60148EC")]
		[Address(RVA = "0x1B160A4", Offset = "0x1B160A4", VA = "0x1B160A4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003107")]
	private sealed class _003CRequestRegionChoose_003Ec__AnonStorey3
	{
		[Token(Token = "0x4012A64")]
		[FieldOffset(Offset = "0x8")]
		internal string region;

		[Token(Token = "0x4012A65")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLogin _0024this;

		[Token(Token = "0x60148ED")]
		[Address(RVA = "0x1B071A8", Offset = "0x1B071A8", VA = "0x1B071A8")]
		public _003CRequestRegionChoose_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x60148EE")]
		[Address(RVA = "0x1B18A10", Offset = "0x1B18A10", VA = "0x1B18A10")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003108")]
	private sealed class _003CRequestPlatformRegister_003Ec__AnonStorey4
	{
		[Token(Token = "0x4012A66")]
		[FieldOffset(Offset = "0x8")]
		internal uint avatar_id;

		[Token(Token = "0x4012A67")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLogin _0024this;

		[Token(Token = "0x60148EF")]
		[Address(RVA = "0x1B086B4", Offset = "0x1B086B4", VA = "0x1B086B4")]
		public _003CRequestPlatformRegister_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x60148F0")]
		[Address(RVA = "0x1B17658", Offset = "0x1B17658", VA = "0x1B17658")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003109")]
	private sealed class _003CRequestBind_003Ec__AnonStorey5
	{
		[Token(Token = "0x4012A68")]
		[FieldOffset(Offset = "0x8")]
		internal PlatformType newPlatform;

		[Token(Token = "0x4012A69")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLogin _0024this;

		[Token(Token = "0x60148F1")]
		[Address(RVA = "0x1B08C18", Offset = "0x1B08C18", VA = "0x1B08C18")]
		public _003CRequestBind_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x60148F2")]
		[Address(RVA = "0x1B16A50", Offset = "0x1B16A50", VA = "0x1B16A50")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x200310A")]
	private sealed class _003CRequestLogout_003Ec__AnonStorey6
	{
		[Token(Token = "0x4012A6A")]
		[FieldOffset(Offset = "0x8")]
		internal bool logoutSdk;

		[Token(Token = "0x4012A6B")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLogin _0024this;

		[Token(Token = "0x60148F3")]
		[Address(RVA = "0x1B0900C", Offset = "0x1B0900C", VA = "0x1B0900C")]
		public _003CRequestLogout_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x60148F4")]
		[Address(RVA = "0x1B17160", Offset = "0x1B17160", VA = "0x1B17160")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x200310B")]
	private sealed class _003CProcessMiddleLoginRes_003Ec__AnonStorey7
	{
		[Token(Token = "0x4012A6C")]
		[FieldOffset(Offset = "0x8")]
		internal object res;

		[Token(Token = "0x4012A6D")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelLogin _0024this;

		[Token(Token = "0x60148F5")]
		[Address(RVA = "0x1B0C4F0", Offset = "0x1B0C4F0", VA = "0x1B0C4F0")]
		public _003CProcessMiddleLoginRes_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x60148F6")]
		[Address(RVA = "0x1B16A08", Offset = "0x1B16A08", VA = "0x1B16A08")]
		internal void _003C_003Em__0(HttpErrorCode errorCode1, object res1)
		{
		}
	}

	[Token(Token = "0x200310C")]
	private sealed class _003CContainWhiteList_003Ec__AnonStorey8
	{
		[Token(Token = "0x4012A6E")]
		[FieldOffset(Offset = "0x8")]
		internal string msg;

		[Token(Token = "0x60148F7")]
		[Address(RVA = "0x1B147F8", Offset = "0x1B147F8", VA = "0x1B147F8")]
		public _003CContainWhiteList_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x60148F8")]
		[Address(RVA = "0x1B16070", Offset = "0x1B16070", VA = "0x1B16070")]
		internal bool _003C_003Em__0(string x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4012A17")]
	[FieldOffset(Offset = "0xC")]
	public bool m_Registered;

	[Token(Token = "0x4012A18")]
	public const uint PropID_LoginRetOK = 2u;

	[Token(Token = "0x4012A19")]
	public const uint PropID_LoginRetNewUser = 4u;

	[Token(Token = "0x4012A1A")]
	public const uint PropID_GuestBindSuccess = 8u;

	[Token(Token = "0x4012A1B")]
	public const uint PropID_SDKLogin = 16u;

	[Token(Token = "0x4012A1C")]
	public const uint PropID_LoginRegionChoose = 32u;

	[Token(Token = "0x4012A1D")]
	public const uint PropID_LoginRegionReChoose = 64u;

	[Token(Token = "0x4012A1E")]
	public const uint PropID_LoginServerFailure_Logout = 128u;

	[Token(Token = "0x4012A1F")]
	public const uint PropID_RegisterSuccess = 256u;

	[Token(Token = "0x4012A20")]
	public const uint PropID_LoginGetDescFinish = 512u;

	[Token(Token = "0x4012A21")]
	public const uint PropID_ShowMaintenanceMessage = 1024u;

	[Token(Token = "0x4012A22")]
	public const uint PropID_LoginLoadOver = 2048u;

	[Token(Token = "0x4012A23")]
	public const uint PropID_MajorLoginSuccess = 4096u;

	[Token(Token = "0x4012A24")]
	public const uint PropID_PlatformBindSuccess = 8192u;

	[Token(Token = "0x4012A25")]
	public const uint PropID_GetPlatformBindInfoSuccess = 16384u;

	[Token(Token = "0x4012A26")]
	public const uint PropID_MajorRegisterResponed = 32768u;

	[Token(Token = "0x4012A27")]
	private const float TIMEOUT_LOGIN = 10f;

	[Token(Token = "0x4012A28")]
	private const float TIMEOUT_LOGOUT = 10f;

	[Token(Token = "0x4012A29")]
	private const float TIMEOUT_REGISTER = 20f;

	[Token(Token = "0x4012A2A")]
	private const float TIMEOUT_BINDING = 20f;

	[Token(Token = "0x4012A2B")]
	private const string KEY_InstantApp = "instantapp";

	[Token(Token = "0x4012A2C")]
	public const string KEY_GUIDE_BINDACCOUNT = "KEY_GUIDE_BINDACCOUNT";

	[Token(Token = "0x4012A2D")]
	public const string KEY_NEW_WEEK_BINDACCOUNT = "KEY_NEW_WEEK_BINDACCOUNT";

	[Token(Token = "0x4012A2E")]
	private const int ReRequestLogInterval = 5;

	[Token(Token = "0x4012A2F")]
	[FieldOffset(Offset = "0x10")]
	private uint m_CurRequestLoginDelayCallID;

	[Token(Token = "0x4012A30")]
	[FieldOffset(Offset = "0x14")]
	public bool IsFirstTimeOpenLobby;

	[Token(Token = "0x4012A31")]
	[FieldOffset(Offset = "0x18")]
	private EAccount.DownloadType m_DownLoadType;

	[Token(Token = "0x4012A32")]
	[FieldOffset(Offset = "0x1C")]
	public bool FirstTimeInLobby;

	[Token(Token = "0x4012A33")]
	[FieldOffset(Offset = "0x20")]
	public string loginRegion;

	[Token(Token = "0x4012A34")]
	[FieldOffset(Offset = "0x24")]
	public string IpCity;

	[Token(Token = "0x4012A35")]
	[FieldOffset(Offset = "0x28")]
	public string IpSubdivision;

	[Token(Token = "0x4012A36")]
	[FieldOffset(Offset = "0x2C")]
	private uint _003Cm_LoginTryTimes_003Ek__BackingField;

	[Token(Token = "0x4012A37")]
	[FieldOffset(Offset = "0x30")]
	public GameObject loadingVideoGo;

	[Token(Token = "0x4012A38")]
	private const string PLAYER_INFO_CACHE_KEY_TEMPLATE = "PlayerInfoCache_{0}";

	[Token(Token = "0x4012A39")]
	private const string m_KeyCreateNameDuration = "CreateNameDuration";

	[Token(Token = "0x4012A3A")]
	[FieldOffset(Offset = "0x34")]
	private UIPopupMessageBoxController m_LoginQueuePopupController;

	[Token(Token = "0x4012A3B")]
	[FieldOffset(Offset = "0x38")]
	private UILoginQueueInfoPopupWndController m_LoginQueueInfoCtrl;

	[Token(Token = "0x4012A3C")]
	[FieldOffset(Offset = "0x3C")]
	private LoginQueueInfo m_CacheQueueInfo;

	[Token(Token = "0x4012A3D")]
	[FieldOffset(Offset = "0x40")]
	private ulong m_LastFetchQueueInfoTime;

	[Token(Token = "0x4012A3E")]
	[FieldOffset(Offset = "0x48")]
	private string m_CachedRegion;

	[Token(Token = "0x4012A3F")]
	[FieldOffset(Offset = "0x4C")]
	private int m_RegionID;

	[Token(Token = "0x4012A40")]
	[FieldOffset(Offset = "0x50")]
	private bool _PendingLoginSDK_Garena;

	[Token(Token = "0x4012A41")]
	[FieldOffset(Offset = "0x54")]
	private AccountPlatform _PendingLoginSDK_Garena_AccountPlatform;

	[Token(Token = "0x4012A42")]
	private const int GMSDK_LOGIN_RETRY_INTERVAL_MAX = 20;

	[Token(Token = "0x4012A43")]
	private const int GMSDK_LOGIN_RETRY_INTERVAL_STEP = 5;

	[Token(Token = "0x4012A44")]
	[FieldOffset(Offset = "0x58")]
	private int _GMSDKLoginRetryTimes;

	[Token(Token = "0x4012A45")]
	private const int AUTO_LOGIN_TIMEOUT_S = 60;

	[Token(Token = "0x4012A46")]
	[FieldOffset(Offset = "0x5C")]
	private uint _DelayCallId_AbortLoginSDK_Garena;

	[Token(Token = "0x4012A47")]
	[FieldOffset(Offset = "0x60")]
	private bool _LogGuestMigrationResult;

	[Token(Token = "0x4012A48")]
	[FieldOffset(Offset = "0x64")]
	private int _GuestMigrationResult;

	[Token(Token = "0x4012A49")]
	[FieldOffset(Offset = "0x68")]
	private List<string> m_ChatWebWhiteList;

	[Token(Token = "0x4012A4A")]
	[FieldOffset(Offset = "0x0")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4012A4B")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4012A4C")]
	[FieldOffset(Offset = "0x8")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4012A4D")]
	[FieldOffset(Offset = "0xC")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x4012A4E")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map14;

	[Token(Token = "0x4012A4F")]
	[FieldOffset(Offset = "0x14")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map15;

	[Token(Token = "0x4012A50")]
	[FieldOffset(Offset = "0x18")]
	private static Action _003C_003Ef__am_0024cache4;

	[Token(Token = "0x4012A51")]
	[FieldOffset(Offset = "0x1C")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map16;

	[Token(Token = "0x4012A52")]
	[FieldOffset(Offset = "0x20")]
	private static Predicate<AbTestChoice> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x4012A53")]
	[FieldOffset(Offset = "0x24")]
	private static Action _003C_003Ef__am_0024cache6;

	[Token(Token = "0x17001566")]
	public uint m_LoginTryTimes
	{
		[Token(Token = "0x6014881")]
		[Address(RVA = "0x1AFFCF8", Offset = "0x1AFFCF8", VA = "0x1AFFCF8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6014882")]
		[Address(RVA = "0x1AFFCF0", Offset = "0x1AFFCF0", VA = "0x1AFFCF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001567")]
	public string CachedRegion
	{
		[Token(Token = "0x6014892")]
		[Address(RVA = "0x1B018E4", Offset = "0x1B018E4", VA = "0x1B018E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001568")]
	public int RegionID
	{
		[Token(Token = "0x6014893")]
		[Address(RVA = "0x1B0193C", Offset = "0x1B0193C", VA = "0x1B0193C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6014894")]
		[Address(RVA = "0x1B01994", Offset = "0x1B01994", VA = "0x1B01994")]
		set
		{
		}
	}

	[Token(Token = "0x17001569")]
	public string DeviceUniqueIdentifier
	{
		[Token(Token = "0x6014896")]
		[Address(RVA = "0x1B01A4C", Offset = "0x1B01A4C", VA = "0x1B01A4C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6014880")]
	[Address(RVA = "0x1AFFC58", Offset = "0x1AFFC58", VA = "0x1AFFC58")]
	public UIModelLogin()
	{
	}

	[Token(Token = "0x6014883")]
	[Address(RVA = "0x1AFFD00", Offset = "0x1AFFD00", VA = "0x1AFFD00")]
	public void LogVerbose(string log)
	{
	}

	[Token(Token = "0x6014884")]
	[Address(RVA = "0x1AFFDD4", Offset = "0x1AFFDD4", VA = "0x1AFFDD4")]
	private void StartLoginLoading()
	{
	}

	[Token(Token = "0x6014885")]
	[Address(RVA = "0x1AFFF98", Offset = "0x1AFFF98", VA = "0x1AFFF98")]
	public IEnumerator PrepareLoadingVideo()
	{
		return null;
	}

	[Token(Token = "0x6014886")]
	[Address(RVA = "0x1B0006C", Offset = "0x1B0006C", VA = "0x1B0006C")]
	public void ReleaseVideo()
	{
	}

	[Token(Token = "0x6014887")]
	[Address(RVA = "0x1B001B0", Offset = "0x1B001B0", VA = "0x1B001B0")]
	public void OnPauseVideo(bool paused)
	{
	}

	[Token(Token = "0x6014888")]
	[Address(RVA = "0x1B0032C", Offset = "0x1B0032C", VA = "0x1B0032C")]
	public bool SupportSignIn(PlatformType platformType)
	{
		return default(bool);
	}

	[Token(Token = "0x6014889")]
	[Address(RVA = "0x1B00430", Offset = "0x1B00430", VA = "0x1B00430")]
	public bool IsNewWeekLoginInWhenLevelMeet()
	{
		return default(bool);
	}

	[Token(Token = "0x601488A")]
	[Address(RVA = "0x1B00870", Offset = "0x1B00870", VA = "0x1B00870")]
	public bool IsFirstTimeLoginToday()
	{
		return default(bool);
	}

	[Token(Token = "0x601488B")]
	[Address(RVA = "0x1B00BB4", Offset = "0x1B00BB4", VA = "0x1B00BB4")]
	public void UpdatePlayerInfoCache()
	{
	}

	[Token(Token = "0x601488C")]
	[Address(RVA = "0x1B010CC", Offset = "0x1B010CC", VA = "0x1B010CC")]
	private void WritePlayerInfoCache(string open_id, CachedPlayerInfo info)
	{
	}

	[Token(Token = "0x601488D")]
	[Address(RVA = "0x1B00E34", Offset = "0x1B00E34", VA = "0x1B00E34")]
	public CachedPlayerInfo ReadPlayerInfoCache(string open_id)
	{
		return null;
	}

	[Token(Token = "0x601488E")]
	[Address(RVA = "0x1B01334", Offset = "0x1B01334", VA = "0x1B01334")]
	public void SaveRegisterCreateNameDuration(ulong accountId, uint duration)
	{
	}

	[Token(Token = "0x601488F")]
	[Address(RVA = "0x1B014A4", Offset = "0x1B014A4", VA = "0x1B014A4")]
	private int GetRegisterCreateNameDuration(ulong accountId)
	{
		return default(int);
	}

	[Token(Token = "0x6014890")]
	[Address(RVA = "0x1B01614", Offset = "0x1B01614", VA = "0x1B01614")]
	public void TryGetRegisterCreateNameDurationAndSendLog(ulong accountId)
	{
	}

	[Token(Token = "0x6014891")]
	[Address(RVA = "0x1B017D4", Offset = "0x1B017D4", VA = "0x1B017D4")]
	private void StopReRequestLoginProcess()
	{
	}

	[Token(Token = "0x6014895")]
	[Address(RVA = "0x1B019F4", Offset = "0x1B019F4", VA = "0x1B019F4", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014897")]
	[Address(RVA = "0x1B01B6C", Offset = "0x1B01B6C", VA = "0x1B01B6C")]
	public void RequestServerStatus(string region)
	{
	}

	[Token(Token = "0x6014898")]
	[Address(RVA = "0x1B02224", Offset = "0x1B02224", VA = "0x1B02224")]
	public void ShowFailedPanel()
	{
	}

	[Token(Token = "0x6014899")]
	[Address(RVA = "0x1B0263C", Offset = "0x1B0263C", VA = "0x1B0263C")]
	public void ShowRegionNotOpenPanel(uint time)
	{
	}

	[Token(Token = "0x601489A")]
	[Address(RVA = "0x1B02958", Offset = "0x1B02958", VA = "0x1B02958")]
	public void LoginSDK(PlatformType platformType, bool autoLogin)
	{
	}

	[Token(Token = "0x601489B")]
	[Address(RVA = "0x1B02E58", Offset = "0x1B02E58", VA = "0x1B02E58")]
	private void LoginSDK_Garena_Abort_Cancel()
	{
	}

	[Token(Token = "0x601489C")]
	[Address(RVA = "0x1B02F68", Offset = "0x1B02F68", VA = "0x1B02F68")]
	private void LoginSDK_Garena_Abort()
	{
	}

	[Token(Token = "0x601489D")]
	[Address(RVA = "0x1B031B0", Offset = "0x1B031B0", VA = "0x1B031B0")]
	private void OnLoginSDK_Garena_Success(LoginRsp rsp)
	{
	}

	[Token(Token = "0x601489E")]
	[Address(RVA = "0x1B038D4", Offset = "0x1B038D4", VA = "0x1B038D4")]
	private void _OnLoginSDK_Garena_Failure(ErrorCode errCode)
	{
	}

	[Token(Token = "0x601489F")]
	[Address(RVA = "0x1B02FE0", Offset = "0x1B02FE0", VA = "0x1B02FE0")]
	private void OnLoginSDK_Garena_Failure(ErrorCode errCode)
	{
	}

	[Token(Token = "0x60148A0")]
	[Address(RVA = "0x1B02A98", Offset = "0x1B02A98", VA = "0x1B02A98")]
	private void LoginSDK_Garena(AccountPlatform accountPlatform, bool autoLogin)
	{
	}

	[Token(Token = "0x60148A1")]
	[Address(RVA = "0x1B04248", Offset = "0x1B04248", VA = "0x1B04248")]
	public void RequestLogin()
	{
	}

	[Token(Token = "0x60148A2")]
	[Address(RVA = "0x1B06058", Offset = "0x1B06058", VA = "0x1B06058")]
	public void DebugPlatformRequestLogin(JsonData platformInfo)
	{
	}

	[Token(Token = "0x60148A3")]
	[Address(RVA = "0x1B06838", Offset = "0x1B06838", VA = "0x1B06838")]
	public void DebugRequestLogin(string loginInfo)
	{
	}

	[Token(Token = "0x60148A4")]
	[Address(RVA = "0x1B06E8C", Offset = "0x1B06E8C", VA = "0x1B06E8C")]
	public void RequestRegionChoose(string region)
	{
	}

	[Token(Token = "0x60148A5")]
	[Address(RVA = "0x1B071B0", Offset = "0x1B071B0", VA = "0x1B071B0")]
	public void RequestGetPlatformProfile()
	{
	}

	[Token(Token = "0x60148A6")]
	[Address(RVA = "0x1B0756C", Offset = "0x1B0756C", VA = "0x1B0756C")]
	public EAccount.DownloadType PublicGetDownloadType()
	{
		return default(EAccount.DownloadType);
	}

	[Token(Token = "0x60148A7")]
	[Address(RVA = "0x1B075CC", Offset = "0x1B075CC", VA = "0x1B075CC")]
	private EAccount.DownloadType GetDownloadType()
	{
		return default(EAccount.DownloadType);
	}

	[Token(Token = "0x60148A8")]
	[Address(RVA = "0x1B07624", Offset = "0x1B07624", VA = "0x1B07624")]
	private void ClearCookie()
	{
	}

	[Token(Token = "0x60148A9")]
	[Address(RVA = "0x1B0783C", Offset = "0x1B0783C", VA = "0x1B0783C")]
	public void RequestGenerateNickname()
	{
	}

	[Token(Token = "0x60148AA")]
	[Address(RVA = "0x1B07BF8", Offset = "0x1B07BF8", VA = "0x1B07BF8")]
	public void RequestPlatformRegister(string nickname, uint avatar_id)
	{
	}

	[Token(Token = "0x60148AB")]
	[Address(RVA = "0x1B086BC", Offset = "0x1B086BC", VA = "0x1B086BC")]
	public void RequestBind(PlatformType oldPlatform, PlatformType newPlatform, string newOpenId, string newToken)
	{
	}

	[Token(Token = "0x60148AC")]
	[Address(RVA = "0x1B08C20", Offset = "0x1B08C20", VA = "0x1B08C20")]
	public void RequestLogout(ELogoutType type, bool logoutSdk = true)
	{
	}

	[Token(Token = "0x60148AD")]
	[Address(RVA = "0x1B093A4", Offset = "0x1B093A4", VA = "0x1B093A4")]
	public void RequestDelAccount()
	{
	}

	[Token(Token = "0x60148AE")]
	[Address(RVA = "0x1B09014", Offset = "0x1B09014", VA = "0x1B09014")]
	private void ClearAfterLogout()
	{
	}

	[Token(Token = "0x60148AF")]
	[Address(RVA = "0x1B0963C", Offset = "0x1B0963C", VA = "0x1B0963C", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60148B0")]
	[Address(RVA = "0x1B096AC", Offset = "0x1B096AC", VA = "0x1B096AC")]
	private void PopupWrongVersionMessage()
	{
	}

	[Token(Token = "0x60148B1")]
	[Address(RVA = "0x1B04B54", Offset = "0x1B04B54", VA = "0x1B04B54")]
	private void PopupLoginQueueIsFull()
	{
	}

	[Token(Token = "0x60148B2")]
	[Address(RVA = "0x1B04E90", Offset = "0x1B04E90", VA = "0x1B04E90")]
	private void UpdateLoginQueueInfo(LoginQueueInfo info, bool isNew = false)
	{
	}

	[Token(Token = "0x60148B3")]
	[Address(RVA = "0x1B099FC", Offset = "0x1B099FC", VA = "0x1B099FC")]
	private void ClearQueueInfo()
	{
	}

	[Token(Token = "0x60148B4")]
	[Address(RVA = "0x1B03550", Offset = "0x1B03550", VA = "0x1B03550")]
	private void InitCachedLockRegion()
	{
	}

	[Token(Token = "0x60148B5")]
	[Address(RVA = "0x1B09B08", Offset = "0x1B09B08", VA = "0x1B09B08")]
	private void UpdateCachedLockRegion(string region)
	{
	}

	[Token(Token = "0x60148B6")]
	[Address(RVA = "0x1B09D6C", Offset = "0x1B09D6C", VA = "0x1B09D6C")]
	private void ProcessLoginError(HttpErrorCode errorCode)
	{
	}

	[Token(Token = "0x60148B7")]
	[Address(RVA = "0x1B0B990", Offset = "0x1B0B990", VA = "0x1B0B990")]
	private void ProcessAccountForbidden(BlacklistInfoRes blackList)
	{
	}

	[Token(Token = "0x60148B8")]
	[Address(RVA = "0x1B0BB10", Offset = "0x1B0BB10", VA = "0x1B0BB10")]
	private void OnMiddleLoginRes(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60148B9")]
	[Address(RVA = "0x1B0BB9C", Offset = "0x1B0BB9C", VA = "0x1B0BB9C")]
	private void ProcessMiddleLoginRes(HttpErrorCode errorCode, object res, uint login_by = 0u)
	{
	}

	[Token(Token = "0x60148BA")]
	[Address(RVA = "0x1B0C4F8", Offset = "0x1B0C4F8", VA = "0x1B0C4F8")]
	private void ProcessLastLoginRes(HttpErrorCode errorCode, object res, object res1)
	{
	}

	[Token(Token = "0x60148BB")]
	[Address(RVA = "0x1B0F900", Offset = "0x1B0F900", VA = "0x1B0F900")]
	private void OnGetLoginDesc(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x60148BC")]
	[Address(RVA = "0x1B0F528", Offset = "0x1B0F528", VA = "0x1B0F528")]
	private void RequestStaticDescOnLogin()
	{
	}

	[Token(Token = "0x60148BD")]
	[Address(RVA = "0x1B11AB0", Offset = "0x1B11AB0", VA = "0x1B11AB0")]
	private void RequestLobbyMessage()
	{
	}

	[Token(Token = "0x60148BE")]
	[Address(RVA = "0x1B0D48C", Offset = "0x1B0D48C", VA = "0x1B0D48C")]
	private void ProcessSuccessfulLogin(LoginRes loginRes, MajorLoginRes majorRes)
	{
	}

	[Token(Token = "0x60148BF")]
	[Address(RVA = "0x1B12CC8", Offset = "0x1B12CC8", VA = "0x1B12CC8")]
	private void LoadCSVWithRegion()
	{
	}

	[Token(Token = "0x60148C0")]
	[Address(RVA = "0x1B112C8", Offset = "0x1B112C8", VA = "0x1B112C8")]
	private void DetectAndroidApplications(CSGetAndroidApplicationToDetectRes androidApplicationToDetectRes)
	{
	}

	[Token(Token = "0x60148C1")]
	[Address(RVA = "0x1B05064", Offset = "0x1B05064", VA = "0x1B05064")]
	private void CreateLoginReqInfoData(ref LoginReq req)
	{
	}

	[Token(Token = "0x60148C2")]
	[Address(RVA = "0x1B13454", Offset = "0x1B13454", VA = "0x1B13454")]
	public bool ShouldShowBindAccount()
	{
		return default(bool);
	}

	[Token(Token = "0x60148C3")]
	[Address(RVA = "0x1B1355C", Offset = "0x1B1355C", VA = "0x1B1355C")]
	public bool PlatformBtnNeedShowOutOfMoreButton(PlatformType platformType)
	{
		return default(bool);
	}

	[Token(Token = "0x60148C4")]
	[Address(RVA = "0x1B135F0", Offset = "0x1B135F0", VA = "0x1B135F0")]
	public void Bind(PlatformType platform)
	{
	}

	[Token(Token = "0x60148C5")]
	[Address(RVA = "0x1B13770", Offset = "0x1B13770", VA = "0x1B13770")]
	private void BindGarena(PlatformType platform)
	{
	}

	[Token(Token = "0x60148C6")]
	[Address(RVA = "0x1B138EC", Offset = "0x1B138EC", VA = "0x1B138EC")]
	private void BindSecondaryPlatform(PlatformType platform)
	{
	}

	[Token(Token = "0x60148C7")]
	[Address(RVA = "0x1B13A30", Offset = "0x1B13A30", VA = "0x1B13A30")]
	private string ProcessBindErrcode(ErrorCode errCode)
	{
		return null;
	}

	[Token(Token = "0x60148C8")]
	[Address(RVA = "0x1B13D70", Offset = "0x1B13D70", VA = "0x1B13D70")]
	private void PlatformLoginDone(PlatformType platformType, string userId, string accessToken)
	{
	}

	[Token(Token = "0x60148C9")]
	[Address(RVA = "0x1B13F74", Offset = "0x1B13F74", VA = "0x1B13F74")]
	public void RequestSecondaryBind(PlatformType newPlatform, string newOpenId, string newToken)
	{
	}

	[Token(Token = "0x60148CA")]
	[Address(RVA = "0x1B14348", Offset = "0x1B14348", VA = "0x1B14348")]
	private void ShowAccountBindResult()
	{
	}

	[Token(Token = "0x60148CB")]
	[Address(RVA = "0x1B14638", Offset = "0x1B14638", VA = "0x1B14638")]
	public void OnGuestMigrationResult(int result)
	{
	}

	[Token(Token = "0x60148CC")]
	[Address(RVA = "0x1B1235C", Offset = "0x1B1235C", VA = "0x1B1235C")]
	private void LogGuestMigration()
	{
	}

	[Token(Token = "0x60148CD")]
	[Address(RVA = "0x1B0B644", Offset = "0x1B0B644", VA = "0x1B0B644")]
	private void ProcesssLoginErrorBRCodeVersion()
	{
	}

	[Token(Token = "0x60148CE")]
	[Address(RVA = "0x1B12440", Offset = "0x1B12440", VA = "0x1B12440")]
	private void ProcessChatWebWhitelist(CSGetChatWebWhiteListRes desc)
	{
	}

	[Token(Token = "0x60148CF")]
	[Address(RVA = "0x1B146A4", Offset = "0x1B146A4", VA = "0x1B146A4")]
	public bool ContainWhiteList(string msg)
	{
		return default(bool);
	}

	[Token(Token = "0x60148D0")]
	[Address(RVA = "0x1B14800", Offset = "0x1B14800", VA = "0x1B14800")]
	private static void _003CRequestServerStatus_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60148D1")]
	[Address(RVA = "0x1B14C50", Offset = "0x1B14C50", VA = "0x1B14C50")]
	private static void _003CShowRegionNotOpenPanel_003Em__1()
	{
	}

	[Token(Token = "0x60148D2")]
	[Address(RVA = "0x1B14D1C", Offset = "0x1B14D1C", VA = "0x1B14D1C")]
	private static void _003CRequestGetPlatformProfile_003Em__2(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60148D3")]
	[Address(RVA = "0x1B14D20", Offset = "0x1B14D20", VA = "0x1B14D20")]
	private static void _003CRequestGenerateNickname_003Em__3(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60148D4")]
	[Address(RVA = "0x1B14EAC", Offset = "0x1B14EAC", VA = "0x1B14EAC")]
	private void _003CRequestDelAccount_003Em__4(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60148D5")]
	[Address(RVA = "0x1B15218", Offset = "0x1B15218", VA = "0x1B15218")]
	private static void _003CPopupWrongVersionMessage_003Em__5()
	{
	}

	[Token(Token = "0x60148D6")]
	[Address(RVA = "0x1B15294", Offset = "0x1B15294", VA = "0x1B15294")]
	private void _003CProcessLastLoginRes_003Em__6()
	{
	}

	[Token(Token = "0x60148D7")]
	[Address(RVA = "0x1B15298", Offset = "0x1B15298", VA = "0x1B15298")]
	private static bool _003CProcessLastLoginRes_003Em__7(AbTestChoice newChoice)
	{
		return default(bool);
	}

	[Token(Token = "0x60148D8")]
	[Address(RVA = "0x1B152C4", Offset = "0x1B152C4", VA = "0x1B152C4")]
	private void _003COnGetLoginDesc_003Em__8()
	{
	}

	[Token(Token = "0x60148D9")]
	[Address(RVA = "0x1B152C8", Offset = "0x1B152C8", VA = "0x1B152C8")]
	private void _003CProcessSuccessfulLogin_003Em__9(SDKBind.PlatformBindingInfo info)
	{
	}

	[Token(Token = "0x60148DA")]
	[Address(RVA = "0x1B15348", Offset = "0x1B15348", VA = "0x1B15348")]
	private void _003CBindGarena_003Em__A(BindSessionRsp rsp)
	{
	}

	[Token(Token = "0x60148DB")]
	[Address(RVA = "0x1B153B4", Offset = "0x1B153B4", VA = "0x1B153B4")]
	private void _003CBindGarena_003Em__B(ErrorCode errCode)
	{
	}

	[Token(Token = "0x60148DC")]
	[Address(RVA = "0x1B155C8", Offset = "0x1B155C8", VA = "0x1B155C8")]
	private void _003CBindSecondaryPlatform_003Em__C(BindSessionRsp rsp)
	{
	}

	[Token(Token = "0x60148DD")]
	[Address(RVA = "0x1B15A6C", Offset = "0x1B15A6C", VA = "0x1B15A6C")]
	private void _003CRequestSecondaryBind_003Em__D(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60148DE")]
	[Address(RVA = "0x1B15F20", Offset = "0x1B15F20", VA = "0x1B15F20")]
	private static void _003CProcesssLoginErrorBRCodeVersion_003Em__E()
	{
	}

	[Token(Token = "0x60148DF")]
	[Address(RVA = "0x1B15FE8", Offset = "0x1B15FE8", VA = "0x1B15FE8")]
	private void _003CRequestSecondaryBind_003Em__F(SDKBind.PlatformBindingInfo rsp)
	{
	}

	[Token(Token = "0x60148E0")]
	[Address(RVA = "0x1B16068", Offset = "0x1B16068", VA = "0x1B16068")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
