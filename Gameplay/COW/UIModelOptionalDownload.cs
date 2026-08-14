using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20031B0")]
public class UIModelOptionalDownload : UIBaseModel
{
	[Token(Token = "0x20031B1")]
	public enum EOptionalLobbyResType
	{
		[Token(Token = "0x4012EA7")]
		None,
		[Token(Token = "0x4012EA8")]
		BigEvent
	}

	[Token(Token = "0x20031B2")]
	private sealed class _003CCheckOptionalVersionWithCallback_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012EA9")]
		[FieldOffset(Offset = "0x8")]
		internal Action checked_callback;

		[Token(Token = "0x4012EAA")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelOptionalDownload _0024this;

		[Token(Token = "0x6014EF5")]
		[Address(RVA = "0x2B0F314", Offset = "0x2B0F314", VA = "0x2B0F314")]
		public _003CCheckOptionalVersionWithCallback_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6014EF6")]
		[Address(RVA = "0x2B2DE18", Offset = "0x2B2DE18", VA = "0x2B2DE18")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4012E6C")]
	[FieldOffset(Offset = "0xC")]
	private List<uint> m_DownloadTypeList;

	[Token(Token = "0x4012E6D")]
	[FieldOffset(Offset = "0x10")]
	private List<DownloadInfo> m_DownloadInfoList;

	[Token(Token = "0x4012E6E")]
	public const uint PropID_VersionChecked = 2u;

	[Token(Token = "0x4012E6F")]
	public const uint PropID_NotifyAssetRefresh = 4u;

	[Token(Token = "0x4012E70")]
	public const uint PropID_DownloadFinished = 8u;

	[Token(Token = "0x4012E71")]
	public const uint PropID_SingleFileDownloadFinished = 16u;

	[Token(Token = "0x4012E72")]
	public const uint PropID_InfoListRefreshed = 32u;

	[Token(Token = "0x4012E73")]
	public const uint PropID_ActivityStateRefreshed = 64u;

	[Token(Token = "0x4012E74")]
	public const uint PropID_TipsStateRefreshed = 128u;

	[Token(Token = "0x4012E75")]
	public const uint PropID_AllFileDownloaded = 256u;

	[Token(Token = "0x4012E76")]
	public const uint PropID_DownloadCentreVisibleRefresh = 512u;

	[Token(Token = "0x4012E77")]
	public const uint PropID_TagOptioanlPatchDownloadFinished = 1024u;

	[Token(Token = "0x4012E78")]
	public const uint PropID_TagOptionalPatchDownloadDelete = 2048u;

	[Token(Token = "0x4012E79")]
	public const uint PropID_TagOptionalPatchDownloadStart = 4096u;

	[Token(Token = "0x4012E7A")]
	public const uint PropID_CheckOptionalAutoDownload = 8192u;

	[Token(Token = "0x4012E7B")]
	private const string NOTIFY_FINISHIED_KEY = "OptionalDownload";

	[Token(Token = "0x4012E7C")]
	private const string DELTED_KEY = "_Deleted";

	[Token(Token = "0x4012E7D")]
	private const string DELTED_KEYTAG = "_DeletedTag";

	[Token(Token = "0x4012E7E")]
	[FieldOffset(Offset = "0x14")]
	private EModelDownloadState m_DownloadState;

	[Token(Token = "0x4012E7F")]
	public const float DownloadSizeUnit = 9.536743E-07f;

	[Token(Token = "0x4012E80")]
	[FieldOffset(Offset = "0x18")]
	private EOptionalLobbyResType m_CurOptionalLobbyResType;

	[Token(Token = "0x4012E81")]
	[FieldOffset(Offset = "0x1C")]
	private bool? m_LocalClothReady;

	[Token(Token = "0x4012E82")]
	[FieldOffset(Offset = "0x1E")]
	private bool? m_LocalPetSkinReady;

	[Token(Token = "0x4012E83")]
	[FieldOffset(Offset = "0x20")]
	private bool? m_HaveVersionUpdate;

	[Token(Token = "0x4012E84")]
	[FieldOffset(Offset = "0x22")]
	private bool _003CInSpeedUp_003Ek__BackingField;

	[Token(Token = "0x4012E85")]
	[FieldOffset(Offset = "0x24")]
	private uint m_SpeedUpDelayCall;

	[Token(Token = "0x4012E86")]
	private const float CHECK_NETWORK_TIME = 5f;

	[Token(Token = "0x4012E87")]
	[FieldOffset(Offset = "0x28")]
	private string m_LastCacheNetworkType;

	[Token(Token = "0x4012E88")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_CheckNetwork_DelayCallID;

	[Token(Token = "0x4012E89")]
	public const uint OptionalReDefOwnedClothesId = 2u;

	[Token(Token = "0x4012E8A")]
	public const uint OptionalReDefEquipedClothesId = 1u;

	[Token(Token = "0x4012E8B")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<ResVersionInfo.FileInfo, int> m_SingleFileLastErrorMap;

	[Token(Token = "0x4012E8C")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<uint, ActivityClientInfo> m_ActivityInfoMap;

	[Token(Token = "0x4012E8D")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<uint, ClientActivityDesc> m_TagActivityInfoIdMap;

	[Token(Token = "0x4012E8E")]
	[FieldOffset(Offset = "0x3C")]
	private List<uint> m_NeedDownloadCloths;

	[Token(Token = "0x4012E8F")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<uint, List<uint>> m_TagResDownloadTypesMap;

	[Token(Token = "0x4012E90")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<uint, DownloadInfoGroup> m_TabDownloadInfoMap;

	[Token(Token = "0x4012E91")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<uint, TagDownloadInfo> m_TagDownloadInfoItemMap;

	[Token(Token = "0x4012E92")]
	[FieldOffset(Offset = "0x4C")]
	private Dictionary<uint, List<ResVersionInfo.FileInfo>> m_TagFileInfosMap;

	[Token(Token = "0x4012E93")]
	[FieldOffset(Offset = "0x50")]
	private LinkedList<uint> m_PendingTag;

	[Token(Token = "0x4012E94")]
	[FieldOffset(Offset = "0x54")]
	private Dictionary<uint, int> OPTIONALRESDOWNLOADREDEFID_LEVEL_MAP;

	[Token(Token = "0x4012E95")]
	[FieldOffset(Offset = "0x58")]
	private uint m_UpdateProcessTagPengindCallId;

	[Token(Token = "0x4012E96")]
	[FieldOffset(Offset = "0x5C")]
	private BitArrayBoolean m_NeedShowCentre;

	[Token(Token = "0x4012E97")]
	private const uint ShowCentreFlag_Activity = 2u;

	[Token(Token = "0x4012E98")]
	private const uint ShowCentreFlag_NeedDownload = 4u;

	[Token(Token = "0x4012E99")]
	[FieldOffset(Offset = "0x60")]
	public bool m_HaveShowAutoDownloadTips;

	[Token(Token = "0x4012E9A")]
	public const string OptionalABDownLoadInfoKey = "OptionalABDownLoadInfoKey";

	[Token(Token = "0x4012E9B")]
	[FieldOffset(Offset = "0x0")]
	public static bool EnableAutoDownload;

	[Token(Token = "0x4012E9C")]
	[FieldOffset(Offset = "0x61")]
	public bool RegisterUpdateAction;

	[Token(Token = "0x4012E9D")]
	[FieldOffset(Offset = "0x62")]
	public bool m_IsProduceDynamicPack;

	[Token(Token = "0x4012E9E")]
	[FieldOffset(Offset = "0x64")]
	private float m_LastErrMsgShowTime;

	[Token(Token = "0x4012E9F")]
	[FieldOffset(Offset = "0x68")]
	public ResDownloadType CurNotifyResType;

	[Token(Token = "0x4012EA0")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_LastTag;

	[Token(Token = "0x4012EA1")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<uint, List<uint>> m_TypeCategoryOptionalIdsMap;

	[Token(Token = "0x4012EA2")]
	[FieldOffset(Offset = "0x4")]
	private static Action<ResDownloadType, ResErrorCode> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4012EA3")]
	[FieldOffset(Offset = "0x8")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4012EA4")]
	[FieldOffset(Offset = "0xC")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4012EA5")]
	[FieldOffset(Offset = "0x10")]
	private static Func<KeyValuePair<uint, int>, int> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x170015FB")]
	public EModelDownloadState DownloadState
	{
		[Token(Token = "0x6014E43")]
		[Address(RVA = "0x2B0D80C", Offset = "0x2B0D80C", VA = "0x2B0D80C")]
		get
		{
			return default(EModelDownloadState);
		}
		[Token(Token = "0x6014E44")]
		[Address(RVA = "0x2B0D864", Offset = "0x2B0D864", VA = "0x2B0D864")]
		private set
		{
		}
	}

	[Token(Token = "0x170015FC")]
	public bool InSpeedUp
	{
		[Token(Token = "0x6014E45")]
		[Address(RVA = "0x2B0DDE4", Offset = "0x2B0DDE4", VA = "0x2B0DDE4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014E46")]
		[Address(RVA = "0x2B0DDEC", Offset = "0x2B0DDEC", VA = "0x2B0DDEC")]
		private set
		{
		}
	}

	[Token(Token = "0x170015FD")]
	public bool NeedShowCentre
	{
		[Token(Token = "0x6014E47")]
		[Address(RVA = "0x2B0DDF4", Offset = "0x2B0DDF4", VA = "0x2B0DDF4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6014E40")]
	[Address(RVA = "0x2B0D294", Offset = "0x2B0D294", VA = "0x2B0D294")]
	public UIModelOptionalDownload()
	{
	}

	[Token(Token = "0x6014E41")]
	[Address(RVA = "0x2B0D5B4", Offset = "0x2B0D5B4", VA = "0x2B0D5B4", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014E42")]
	[Address(RVA = "0x2B0D60C", Offset = "0x2B0D60C", VA = "0x2B0D60C", Slot = "13")]
	public override void ClearCache()
	{
	}

	[Token(Token = "0x6014E48")]
	[Address(RVA = "0x2B0DEBC", Offset = "0x2B0DEBC", VA = "0x2B0DEBC", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6014E49")]
	[Address(RVA = "0x2B0E058", Offset = "0x2B0E058", VA = "0x2B0E058", Slot = "11")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6014E4A")]
	[Address(RVA = "0x2B0E220", Offset = "0x2B0E220", VA = "0x2B0E220")]
	public bool NetWordIsWiFi()
	{
		return default(bool);
	}

	[Token(Token = "0x6014E4B")]
	[Address(RVA = "0x2B0E2EC", Offset = "0x2B0E2EC", VA = "0x2B0E2EC", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014E4C")]
	[Address(RVA = "0x2B0E3F8", Offset = "0x2B0E3F8", VA = "0x2B0E3F8")]
	public void RestLastErrMsgShowTime()
	{
	}

	[Token(Token = "0x6014E4D")]
	[Address(RVA = "0x2B0E454", Offset = "0x2B0E454", VA = "0x2B0E454")]
	public static string GetRewardIconByActivityState(EActivity.State state)
	{
		return null;
	}

	[Token(Token = "0x6014E4E")]
	[Address(RVA = "0x2B0E558", Offset = "0x2B0E558", VA = "0x2B0E558")]
	public static string GetPackNameByDownloadType(ResDownloadType type)
	{
		return null;
	}

	[Token(Token = "0x6014E4F")]
	[Address(RVA = "0x2B0E630", Offset = "0x2B0E630", VA = "0x2B0E630")]
	public void HintWithErrorCode(ResErrorCode error)
	{
	}

	[Token(Token = "0x6014E50")]
	[Address(RVA = "0x2B0E988", Offset = "0x2B0E988", VA = "0x2B0E988")]
	public void CheckOptionalVersionInLauncher()
	{
	}

	[Token(Token = "0x6014E51")]
	[Address(RVA = "0x2B0ED84", Offset = "0x2B0ED84", VA = "0x2B0ED84")]
	public void StartDownloadProcess()
	{
	}

	[Token(Token = "0x6014E52")]
	[Address(RVA = "0x2B0EFB0", Offset = "0x2B0EFB0", VA = "0x2B0EFB0")]
	public void CheckOptionalVersion()
	{
	}

	[Token(Token = "0x6014E53")]
	[Address(RVA = "0x2B0F138", Offset = "0x2B0F138", VA = "0x2B0F138")]
	public void CheckOptionalVersionWithCallback(Action checked_callback)
	{
	}

	[Token(Token = "0x6014E54")]
	[Address(RVA = "0x2B0F31C", Offset = "0x2B0F31C", VA = "0x2B0F31C")]
	private void CheckDesignatedFile()
	{
	}

	[Token(Token = "0x6014E55")]
	[Address(RVA = "0x2B0EB10", Offset = "0x2B0EB10", VA = "0x2B0EB10")]
	private void onVersionChecked()
	{
	}

	[Token(Token = "0x6014E56")]
	[Address(RVA = "0x2B10278", Offset = "0x2B10278", VA = "0x2B10278")]
	private void CheckNeedDelete()
	{
	}

	[Token(Token = "0x6014E57")]
	[Address(RVA = "0x2B10B90", Offset = "0x2B10B90", VA = "0x2B10B90")]
	public void OnEnterLobby()
	{
	}

	[Token(Token = "0x6014E58")]
	[Address(RVA = "0x2B0FF8C", Offset = "0x2B0FF8C", VA = "0x2B0FF8C")]
	private bool CheckShowAutoDownloadTips()
	{
		return default(bool);
	}

	[Token(Token = "0x6014E59")]
	[Address(RVA = "0x2B10E04", Offset = "0x2B10E04", VA = "0x2B10E04")]
	public void CheckOwenOrEquipedClothesOnEnterLobby()
	{
	}

	[Token(Token = "0x6014E5A")]
	[Address(RVA = "0x2B0FAD8", Offset = "0x2B0FAD8", VA = "0x2B0FAD8")]
	public void CheckNeedDownload()
	{
	}

	[Token(Token = "0x6014E5B")]
	[Address(RVA = "0x2B1206C", Offset = "0x2B1206C", VA = "0x2B1206C")]
	public void PrepareForBackGroundDownload()
	{
	}

	[Token(Token = "0x6014E5C")]
	[Address(RVA = "0x2B123F0", Offset = "0x2B123F0", VA = "0x2B123F0")]
	public void UnPrepareForBackGroundDownload()
	{
	}

	[Token(Token = "0x6014E5D")]
	[Address(RVA = "0x2B12548", Offset = "0x2B12548", VA = "0x2B12548")]
	public bool GetAutoDownloadFlag()
	{
		return default(bool);
	}

	[Token(Token = "0x6014E5E")]
	[Address(RVA = "0x2B12814", Offset = "0x2B12814", VA = "0x2B12814")]
	private void CheckAutoResumeResDownloadType()
	{
	}

	[Token(Token = "0x6014E5F")]
	[Address(RVA = "0x2B0FDDC", Offset = "0x2B0FDDC", VA = "0x2B0FDDC")]
	public void CheckAutoDownload()
	{
	}

	[Token(Token = "0x6014E60")]
	[Address(RVA = "0x2B11780", Offset = "0x2B11780", VA = "0x2B11780")]
	public void CheckAndAutoDownload(List<uint> tags)
	{
	}

	[Token(Token = "0x6014E61")]
	[Address(RVA = "0x2B130F8", Offset = "0x2B130F8", VA = "0x2B130F8")]
	public void DownloadSingleFile(ResourceID id, bool manualDownload = false)
	{
	}

	[Token(Token = "0x6014E62")]
	[Address(RVA = "0x2B135D0", Offset = "0x2B135D0", VA = "0x2B135D0")]
	public void DownloadMutileRes(List<ResourceID> download_resList, bool manual = false)
	{
	}

	[Token(Token = "0x6014E63")]
	[Address(RVA = "0x2B13BF4", Offset = "0x2B13BF4", VA = "0x2B13BF4")]
	private void StartDownloadMutileFileByTag(List<string> ab_path)
	{
	}

	[Token(Token = "0x6014E64")]
	[Address(RVA = "0x2B14DA4", Offset = "0x2B14DA4", VA = "0x2B14DA4")]
	private void PriorityOfCurSingleFileDownload(TagDownloadInfo tagDownloadInfo)
	{
	}

	[Token(Token = "0x6014E65")]
	[Address(RVA = "0x2B14BA0", Offset = "0x2B14BA0", VA = "0x2B14BA0")]
	private TagDownloadInfo GetEffectiveTagId(List<uint> tag_list)
	{
		return null;
	}

	[Token(Token = "0x6014E66")]
	[Address(RVA = "0x2B15A08", Offset = "0x2B15A08", VA = "0x2B15A08")]
	public bool IsOptionalPackedRes(ResourceID id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014E67")]
	[Address(RVA = "0x2B15B14", Offset = "0x2B15B14", VA = "0x2B15B14")]
	public bool IsOptionalPackedRes(string ab_path)
	{
		return default(bool);
	}

	[Token(Token = "0x6014E68")]
	[Address(RVA = "0x2B133D4", Offset = "0x2B133D4", VA = "0x2B133D4")]
	public void DownloadSingleFileForNewTagDownloadInfo(string ab_path, bool manualDownload = false)
	{
	}

	[Token(Token = "0x6014E69")]
	[Address(RVA = "0x2B15C7C", Offset = "0x2B15C7C", VA = "0x2B15C7C")]
	public void DownloadAllFileByResType(ResDownloadType type, bool manaualDownload = false)
	{
	}

	[Token(Token = "0x6014E6A")]
	[Address(RVA = "0x2B0F924", Offset = "0x2B0F924", VA = "0x2B0F924")]
	private void StartDownloadSingle(string ab_path, ResUpdateDownloadContext context, bool manualDownload = false)
	{
	}

	[Token(Token = "0x6014E6B")]
	[Address(RVA = "0x2B16540", Offset = "0x2B16540", VA = "0x2B16540")]
	private void StartDownloadAll(ResUpdateDownloadContext context, bool manualDownload = false)
	{
	}

	[Token(Token = "0x6014E6C")]
	[Address(RVA = "0x2B1694C", Offset = "0x2B1694C", VA = "0x2B1694C")]
	public void PauseDownload(bool need_auto_resume = false)
	{
	}

	[Token(Token = "0x6014E6D")]
	[Address(RVA = "0x2B16FE8", Offset = "0x2B16FE8", VA = "0x2B16FE8")]
	public void CheckAllFileStatesByFileName(string file_name)
	{
	}

	[Token(Token = "0x6014E6E")]
	[Address(RVA = "0x2B170FC", Offset = "0x2B170FC", VA = "0x2B170FC")]
	public void CheckAllFileStatesByContextType(ResDownloadType context_type)
	{
	}

	[Token(Token = "0x6014E6F")]
	[Address(RVA = "0x2B172A4", Offset = "0x2B172A4", VA = "0x2B172A4")]
	private EActivity.Event GetActivityEventTypeByDownloadType(ResDownloadType type)
	{
		return default(EActivity.Event);
	}

	[Token(Token = "0x6014E70")]
	[Address(RVA = "0x2B17308", Offset = "0x2B17308", VA = "0x2B17308")]
	public void NotifyServieTag(uint[] tagIds)
	{
	}

	[Token(Token = "0x6014E71")]
	[Address(RVA = "0x2B176A8", Offset = "0x2B176A8", VA = "0x2B176A8")]
	private void OnFileDownloadedNotify(ResErrorCode error, ResDownloadType type, ResVersionInfo.FileInfo file_info)
	{
	}

	[Token(Token = "0x6014E72")]
	[Address(RVA = "0x2B17894", Offset = "0x2B17894", VA = "0x2B17894")]
	private void OnSingleFileDownloadedFinished(ResErrorCode error, ResDownloadType type, ResVersionInfo.FileInfo file_info)
	{
	}

	[Token(Token = "0x6014E73")]
	[Address(RVA = "0x2B17CCC", Offset = "0x2B17CCC", VA = "0x2B17CCC")]
	private void OnDownloadedFinished(ResErrorCode error, ResDownloadType type)
	{
	}

	[Token(Token = "0x6014E74")]
	[Address(RVA = "0x2B0D678", Offset = "0x2B0D678", VA = "0x2B0D678")]
	private void ClearNetWorkTypeCache()
	{
	}

	[Token(Token = "0x6014E75")]
	[Address(RVA = "0x2B0DB90", Offset = "0x2B0DB90", VA = "0x2B0DB90")]
	private void CacheNetWorkType()
	{
	}

	[Token(Token = "0x6014E76")]
	[Address(RVA = "0x2B18074", Offset = "0x2B18074", VA = "0x2B18074")]
	private void OnNetWorkCheck()
	{
	}

	[Token(Token = "0x6014E77")]
	[Address(RVA = "0x2B18300", Offset = "0x2B18300", VA = "0x2B18300")]
	public bool CheckErrorWithDownloadInfo()
	{
		return default(bool);
	}

	[Token(Token = "0x6014E78")]
	[Address(RVA = "0x2B10000", Offset = "0x2B10000", VA = "0x2B10000")]
	public void RefreshDownloadInfoList(bool need_add_fileinfo = false)
	{
	}

	[Token(Token = "0x6014E79")]
	[Address(RVA = "0x2B18500", Offset = "0x2B18500", VA = "0x2B18500")]
	public long GetZipSizeWithResID(List<ResourceID> res_id_list, [Optional] HashSet<ResVersionInfo.FileInfo> added_file_list)
	{
		return default(long);
	}

	[Token(Token = "0x6014E7A")]
	[Address(RVA = "0x2B18DD4", Offset = "0x2B18DD4", VA = "0x2B18DD4")]
	public void GetZipInfoWithResID(ResourceID res_id, ref HashSet<ResVersionInfo.FileInfo> added_file_list, ref HashSet<ResVersionInfo.FileInfo> except_flie_list)
	{
	}

	[Token(Token = "0x6014E7B")]
	[Address(RVA = "0x2B194B8", Offset = "0x2B194B8", VA = "0x2B194B8")]
	public void GetZipInfoWithResID(ResourceID res_id, ref HashSet<ResVersionInfo.FileInfo> added_file_list)
	{
	}

	[Token(Token = "0x6014E7C")]
	[Address(RVA = "0x2B1872C", Offset = "0x2B1872C", VA = "0x2B1872C")]
	public long GetZipSizeWithResID(ResourceID res_id, [Optional] HashSet<ResVersionInfo.FileInfo> added_file_list)
	{
		return default(long);
	}

	[Token(Token = "0x6014E7D")]
	[Address(RVA = "0x2B19B24", Offset = "0x2B19B24", VA = "0x2B19B24")]
	public List<ResVersionInfo.FileInfo> SimpleFileInfosByResourceIds(List<ResourceID> resIds)
	{
		return null;
	}

	[Token(Token = "0x6014E7E")]
	[Address(RVA = "0x2B1A05C", Offset = "0x2B1A05C", VA = "0x2B1A05C")]
	public List<ResVersionInfo.FileInfo> FileInfosByResourceIds(List<ResourceID> resIds)
	{
		return null;
	}

	[Token(Token = "0x6014E7F")]
	[Address(RVA = "0x2B1A8D0", Offset = "0x2B1A8D0", VA = "0x2B1A8D0")]
	public float EstimateRemainDownloadedSize(List<ResourceID> resIds)
	{
		return default(float);
	}

	[Token(Token = "0x6014E80")]
	[Address(RVA = "0x2B1AA10", Offset = "0x2B1AA10", VA = "0x2B1AA10")]
	public bool NeedSecondConfirmForDownloadSingleFile(List<ResourceID> res_id_list)
	{
		return default(bool);
	}

	[Token(Token = "0x6014E81")]
	[Address(RVA = "0x2B1ABD8", Offset = "0x2B1ABD8", VA = "0x2B1ABD8")]
	public bool NeedSecondConfirmForDownloadSingleFile(ResourceID res_id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014E82")]
	[Address(RVA = "0x2B167A0", Offset = "0x2B167A0", VA = "0x2B167A0")]
	public void ClearDeletedType(ResDownloadType type)
	{
	}

	[Token(Token = "0x6014E83")]
	[Address(RVA = "0x2B12B9C", Offset = "0x2B12B9C", VA = "0x2B12B9C")]
	public bool HasBeingDeletedTag(uint tag)
	{
		return default(bool);
	}

	[Token(Token = "0x6014E84")]
	[Address(RVA = "0x2B1AE4C", Offset = "0x2B1AE4C", VA = "0x2B1AE4C")]
	public void DeletedTag(uint tag)
	{
	}

	[Token(Token = "0x6014E85")]
	[Address(RVA = "0x2B1AFA0", Offset = "0x2B1AFA0", VA = "0x2B1AFA0")]
	public void ClearDeletedTag(uint tag)
	{
	}

	[Token(Token = "0x6014E86")]
	[Address(RVA = "0x2B1B0F4", Offset = "0x2B1B0F4", VA = "0x2B1B0F4")]
	public bool HaveFinishedOptionalDownloadActivity()
	{
		return default(bool);
	}

	[Token(Token = "0x6014E87")]
	[Address(RVA = "0x2B1B3B0", Offset = "0x2B1B3B0", VA = "0x2B1B3B0")]
	public void UpdateActivityStateWithTagId(uint tagId, ClientActivityDesc activit_desc)
	{
	}

	[Token(Token = "0x6014E88")]
	[Address(RVA = "0x2B1B550", Offset = "0x2B1B550", VA = "0x2B1B550")]
	public void RecheckActivityState()
	{
	}

	[Token(Token = "0x6014E89")]
	[Address(RVA = "0x2B1BA04", Offset = "0x2B1BA04", VA = "0x2B1BA04")]
	public ResourceID GetTagActivityResouceIcon(uint tagId, out uint rewardNum)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6014E8A")]
	[Address(RVA = "0x2B1BCC8", Offset = "0x2B1BCC8", VA = "0x2B1BCC8")]
	public EActivity.State GetActivityStateByTagId(uint tagId, out bool have_activity_info)
	{
		return default(EActivity.State);
	}

	[Token(Token = "0x6014E8B")]
	[Address(RVA = "0x2B1BE88", Offset = "0x2B1BE88", VA = "0x2B1BE88")]
	public void AwardByTagId(uint tagId)
	{
	}

	[Token(Token = "0x6014E8C")]
	[Address(RVA = "0x2B1C034", Offset = "0x2B1C034", VA = "0x2B1C034")]
	private float GetTargetUnzipSpeed(bool is_speed_up)
	{
		return default(float);
	}

	[Token(Token = "0x6014E8D")]
	[Address(RVA = "0x2B1C2BC", Offset = "0x2B1C2BC", VA = "0x2B1C2BC")]
	public void StartSpeedUp()
	{
	}

	[Token(Token = "0x6014E8E")]
	[Address(RVA = "0x2B1C550", Offset = "0x2B1C550", VA = "0x2B1C550")]
	public void BackToNormalSpeed()
	{
	}

	[Token(Token = "0x6014E8F")]
	[Address(RVA = "0x2B1C6DC", Offset = "0x2B1C6DC", VA = "0x2B1C6DC")]
	public bool IsTipsStateReady()
	{
		return default(bool);
	}

	[Token(Token = "0x6014E90")]
	[Address(RVA = "0x2B1C7D0", Offset = "0x2B1C7D0", VA = "0x2B1C7D0")]
	public void SetLocalClothReadyState(bool is_ready, List<uint> need_download_list)
	{
	}

	[Token(Token = "0x6014E91")]
	[Address(RVA = "0x2B1C954", Offset = "0x2B1C954", VA = "0x2B1C954")]
	public void SetLocalPetSkinReadyState(bool is_ready)
	{
	}

	[Token(Token = "0x6014E92")]
	[Address(RVA = "0x2B1CA90", Offset = "0x2B1CA90", VA = "0x2B1CA90")]
	public void DownloadFilesQuickly(List<ResourceID> reslist)
	{
	}

	[Token(Token = "0x6014E93")]
	[Address(RVA = "0x2B1CB68", Offset = "0x2B1CB68", VA = "0x2B1CB68")]
	public EDownloadContextState GetDownloadContextStateByType(ResDownloadType type)
	{
		return default(EDownloadContextState);
	}

	[Token(Token = "0x6014E94")]
	[Address(RVA = "0x2B1CC80", Offset = "0x2B1CC80", VA = "0x2B1CC80")]
	public bool IsMapDownloading(List<ResourceID> mapRes)
	{
		return default(bool);
	}

	[Token(Token = "0x6014E95")]
	[Address(RVA = "0x2B1D03C", Offset = "0x2B1D03C", VA = "0x2B1D03C")]
	public List<ResourceID> GetUGCResDownLoadList()
	{
		return null;
	}

	[Token(Token = "0x6014E96")]
	[Address(RVA = "0x2B104A8", Offset = "0x2B104A8", VA = "0x2B104A8")]
	public TagDownloadInfo GetDownloadInfoByTag(uint tagId)
	{
		return null;
	}

	[Token(Token = "0x6014E97")]
	[Address(RVA = "0x2B1D148", Offset = "0x2B1D148", VA = "0x2B1D148")]
	public uint GetOptionalLobbyResTag(EOptionalLobbyResType abType, uint abId)
	{
		return default(uint);
	}

	[Token(Token = "0x6014E98")]
	[Address(RVA = "0x2B1D1C4", Offset = "0x2B1D1C4", VA = "0x2B1D1C4")]
	public List<ResVersionInfo.FileInfo> GetOptionalLobbyResFileInfo(EOptionalLobbyResType abType, uint abId)
	{
		return null;
	}

	[Token(Token = "0x6014E99")]
	[Address(RVA = "0x2B1D2D8", Offset = "0x2B1D2D8", VA = "0x2B1D2D8")]
	public bool IsOptionalLobbyResDownloaded(EOptionalLobbyResType abType, uint abId, bool isShowPop = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6014E9A")]
	[Address(RVA = "0x2B1D394", Offset = "0x2B1D394", VA = "0x2B1D394")]
	public bool IsForceAllFileDownloadRes(List<ResourceID> needDownloadRes, ref ResDownloadType resType)
	{
		return default(bool);
	}

	[Token(Token = "0x6014E9B")]
	[Address(RVA = "0x2B1DC0C", Offset = "0x2B1DC0C", VA = "0x2B1DC0C")]
	public List<ResVersionInfo.FileInfo> GetAllFileDownloadResFileInfo(ResDownloadType resType)
	{
		return null;
	}

	[Token(Token = "0x6014E9C")]
	[Address(RVA = "0x2B1DD5C", Offset = "0x2B1DD5C", VA = "0x2B1DD5C")]
	public uint GetAllFileDownloadResMainTag(ResDownloadType resType)
	{
		return default(uint);
	}

	[Token(Token = "0x6014E9D")]
	[Address(RVA = "0x2B1DED4", Offset = "0x2B1DED4", VA = "0x2B1DED4")]
	public bool IsUGCResDownloaded(bool isShowPop = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6014E9E")]
	[Address(RVA = "0x2B1DF38", Offset = "0x2B1DF38", VA = "0x2B1DF38")]
	public float GetAllFileDownloadResSize(ResDownloadType resType)
	{
		return default(float);
	}

	[Token(Token = "0x6014E9F")]
	[Address(RVA = "0x2B1E0B0", Offset = "0x2B1E0B0", VA = "0x2B1E0B0")]
	public bool IsAllFileDownloaded(ResDownloadType resType, bool isShowPop = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6014EA0")]
	[Address(RVA = "0x2B1E5C8", Offset = "0x2B1E5C8", VA = "0x2B1E5C8")]
	public static string GetOptionalABDownLoadInfoCrc(string key)
	{
		return null;
	}

	[Token(Token = "0x6014EA1")]
	[Address(RVA = "0x2B1E6E0", Offset = "0x2B1E6E0", VA = "0x2B1E6E0")]
	public static void SetOptionalABDownLoadInfoCrc(string key, string value)
	{
	}

	[Token(Token = "0x6014EA2")]
	[Address(RVA = "0x2B1E7BC", Offset = "0x2B1E7BC", VA = "0x2B1E7BC")]
	public static bool IsOptionalBundleDownLoadInfoChanged()
	{
		return default(bool);
	}

	[Token(Token = "0x6014EA3")]
	[Address(RVA = "0x2B1ECC8", Offset = "0x2B1ECC8", VA = "0x2B1ECC8")]
	public static void LogOptionalDownloadInfo()
	{
	}

	[Token(Token = "0x6014EA4")]
	[Address(RVA = "0x2B153EC", Offset = "0x2B153EC", VA = "0x2B153EC")]
	private bool AddToPendingDownloadByTag(uint tag, bool isAddFirst = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6014EA5")]
	[Address(RVA = "0x2B1F144", Offset = "0x2B1F144", VA = "0x2B1F144")]
	private void AddNeedDownloadOptionalReDefIdLevel(uint tag, int sortId)
	{
	}

	[Token(Token = "0x6014EA6")]
	[Address(RVA = "0x2B1F390", Offset = "0x2B1F390", VA = "0x2B1F390")]
	private void RemoveFromPendingTag(uint tag)
	{
	}

	[Token(Token = "0x6014EA7")]
	[Address(RVA = "0x2B1F494", Offset = "0x2B1F494", VA = "0x2B1F494")]
	public EDownloadContextState IsPendingOrDownloadingByTag(uint tag)
	{
		return default(EDownloadContextState);
	}

	[Token(Token = "0x6014EA8")]
	[Address(RVA = "0x2B1F5D8", Offset = "0x2B1F5D8", VA = "0x2B1F5D8")]
	public uint GetDownloadingTagId()
	{
		return default(uint);
	}

	[Token(Token = "0x6014EA9")]
	[Address(RVA = "0x2B1F6F4", Offset = "0x2B1F6F4", VA = "0x2B1F6F4")]
	public void PendingDownloadClick(uint tag)
	{
	}

	[Token(Token = "0x6014EAA")]
	[Address(RVA = "0x2B1F764", Offset = "0x2B1F764", VA = "0x2B1F764")]
	private void UpdateProcessTagPendingList()
	{
	}

	[Token(Token = "0x6014EAB")]
	[Address(RVA = "0x2B21874", Offset = "0x2B21874", VA = "0x2B21874")]
	private void SendEventLog_OptionalBundleDownload(uint bundleId, string packageName, List<uint> resDownloadTypeList, ResErrorCode lastErrorCode)
	{
	}

	[Token(Token = "0x6014EAC")]
	[Address(RVA = "0x2B21594", Offset = "0x2B21594", VA = "0x2B21594")]
	public ResErrorCode OnTagDownloadFinished(uint tag)
	{
		return default(ResErrorCode);
	}

	[Token(Token = "0x6014EAD")]
	[Address(RVA = "0x2B21DA4", Offset = "0x2B21DA4", VA = "0x2B21DA4")]
	public ResErrorCode OnTagSingleFileDownloadFinished(TagDownloadInfo tagDownloadInfo)
	{
		return default(ResErrorCode);
	}

	[Token(Token = "0x6014EAE")]
	[Address(RVA = "0x2B22238", Offset = "0x2B22238", VA = "0x2B22238")]
	private ResErrorCode GetResErrorCodeByTag(uint tag)
	{
		return default(ResErrorCode);
	}

	[Token(Token = "0x6014EAF")]
	[Address(RVA = "0x2B22500", Offset = "0x2B22500", VA = "0x2B22500")]
	private void ProduceDynamicDownloadInfo()
	{
	}

	[Token(Token = "0x6014EB0")]
	[Address(RVA = "0x2B23674", Offset = "0x2B23674", VA = "0x2B23674")]
	public void InitTagDownloadInfoShowState()
	{
	}

	[Token(Token = "0x6014EB1")]
	[Address(RVA = "0x2B23B80", Offset = "0x2B23B80", VA = "0x2B23B80")]
	private void PrintDynamicPackFileInfoAbName()
	{
	}

	[Token(Token = "0x6014EB2")]
	[Address(RVA = "0x2B24324", Offset = "0x2B24324", VA = "0x2B24324")]
	private void AddTypeTagPair(uint TypeId, uint TagId)
	{
	}

	[Token(Token = "0x6014EB3")]
	[Address(RVA = "0x2B244E8", Offset = "0x2B244E8", VA = "0x2B244E8")]
	public void InitTabDownloadInfo(bool login = false)
	{
	}

	[Token(Token = "0x6014EB4")]
	[Address(RVA = "0x2B10FB0", Offset = "0x2B10FB0", VA = "0x2B10FB0")]
	public void ProduceOwnedDynamicDownloadInfo()
	{
	}

	[Token(Token = "0x6014EB5")]
	[Address(RVA = "0x2B27030", Offset = "0x2B27030", VA = "0x2B27030")]
	private void ProduceTagDownloadInfo(uint tag, List<ResVersionInfo.FileInfo> fileInfo_List, List<uint> resDownloadTypeList)
	{
	}

	[Token(Token = "0x6014EB6")]
	[Address(RVA = "0x2B1D660", Offset = "0x2B1D660", VA = "0x2B1D660")]
	public bool GetResourceAbNames(List<ResourceID> resources, ref HashSet<string> abNameList)
	{
		return default(bool);
	}

	[Token(Token = "0x6014EB7")]
	[Address(RVA = "0x2B22FB4", Offset = "0x2B22FB4", VA = "0x2B22FB4")]
	private List<ResVersionInfo.FileInfo> InitFileInfoInContext(List<string> abPath_List, ResDownloadType type, uint tag, bool isRecommend = false)
	{
		return null;
	}

	[Token(Token = "0x6014EB8")]
	[Address(RVA = "0x2B26444", Offset = "0x2B26444", VA = "0x2B26444")]
	private void ClearTagTableByTag(uint tag)
	{
	}

	[Token(Token = "0x6014EB9")]
	[Address(RVA = "0x2B266A0", Offset = "0x2B266A0", VA = "0x2B266A0")]
	private List<ResVersionInfo.FileInfo> InitMutilFileInfoList(List<string> ab_patchList, uint tag, ref List<uint> resDownloadTypeList)
	{
		return null;
	}

	[Token(Token = "0x6014EBA")]
	[Address(RVA = "0x2B12D14", Offset = "0x2B12D14", VA = "0x2B12D14")]
	public void StartDownloadByTag(uint tag, bool manualDownload = false, bool ChangeDownloadStateMode = false)
	{
	}

	[Token(Token = "0x6014EBB")]
	[Address(RVA = "0x2B276B0", Offset = "0x2B276B0", VA = "0x2B276B0")]
	private void NotifyStartDownload(uint tag)
	{
	}

	[Token(Token = "0x6014EBC")]
	[Address(RVA = "0x2B207E4", Offset = "0x2B207E4", VA = "0x2B207E4")]
	private void StartDownloadByTagForPendingProcess(uint tag)
	{
	}

	[Token(Token = "0x6014EBD")]
	[Address(RVA = "0x2B27A44", Offset = "0x2B27A44", VA = "0x2B27A44")]
	public void StartDownloadByType(uint type)
	{
	}

	[Token(Token = "0x6014EBE")]
	[Address(RVA = "0x2B27BF4", Offset = "0x2B27BF4", VA = "0x2B27BF4")]
	private void StartDownloadBatch(List<uint> tagList, bool addFirst = false)
	{
	}

	[Token(Token = "0x6014EBF")]
	[Address(RVA = "0x2B2058C", Offset = "0x2B2058C", VA = "0x2B2058C")]
	public void PauseDownloadByTagForTagPendingUpdateProcess(uint tag)
	{
	}

	[Token(Token = "0x6014EC0")]
	[Address(RVA = "0x2B16E30", Offset = "0x2B16E30", VA = "0x2B16E30")]
	private void PauseDownloadByTag(uint tag)
	{
	}

	[Token(Token = "0x6014EC1")]
	[Address(RVA = "0x2B27E90", Offset = "0x2B27E90", VA = "0x2B27E90")]
	public void ManaualPauseDownloadByTag(uint tag)
	{
	}

	[Token(Token = "0x6014EC2")]
	[Address(RVA = "0x2B27F08", Offset = "0x2B27F08", VA = "0x2B27F08")]
	public void PauseDownloadByType(uint type)
	{
	}

	[Token(Token = "0x6014EC3")]
	[Address(RVA = "0x2B281B8", Offset = "0x2B281B8", VA = "0x2B281B8")]
	public void PendingClickByTag(uint tag)
	{
	}

	[Token(Token = "0x6014EC4")]
	[Address(RVA = "0x2B28228", Offset = "0x2B28228", VA = "0x2B28228")]
	public void PendingDownloadByType(uint type)
	{
	}

	[Token(Token = "0x6014EC5")]
	[Address(RVA = "0x2B1058C", Offset = "0x2B1058C", VA = "0x2B1058C")]
	public void DeleteFileByTag(uint tag, bool deleteRecommend = false)
	{
	}

	[Token(Token = "0x6014EC6")]
	[Address(RVA = "0x2B12A60", Offset = "0x2B12A60", VA = "0x2B12A60")]
	private List<uint> GetDownloadSortedTagList(List<uint> need_sort_list)
	{
		return null;
	}

	[Token(Token = "0x6014EC7")]
	[Address(RVA = "0x2B284EC", Offset = "0x2B284EC", VA = "0x2B284EC")]
	private int CompareDownloadSort(uint tag1, uint tag2)
	{
		return default(int);
	}

	[Token(Token = "0x6014EC8")]
	[Address(RVA = "0x2B2861C", Offset = "0x2B2861C", VA = "0x2B2861C")]
	public DownloadInfoGroup GetTabDownloadInfoByTypeId(uint type)
	{
		return null;
	}

	[Token(Token = "0x6014EC9")]
	[Address(RVA = "0x2B2870C", Offset = "0x2B2870C", VA = "0x2B2870C")]
	public void DownloadAllTagDownloadInfo()
	{
	}

	[Token(Token = "0x6014ECA")]
	[Address(RVA = "0x2B28788", Offset = "0x2B28788", VA = "0x2B28788")]
	public List<uint> GetAllNeedDownloadOptionalRedefId()
	{
		return null;
	}

	[Token(Token = "0x6014ECB")]
	[Address(RVA = "0x2B28C84", Offset = "0x2B28C84", VA = "0x2B28C84")]
	public bool isAllShowTagInTagPendOrFinished()
	{
		return default(bool);
	}

	[Token(Token = "0x6014ECC")]
	[Address(RVA = "0x2B29178", Offset = "0x2B29178", VA = "0x2B29178")]
	public List<uint> GetDownloadOptionalRedefIdListByType(uint type)
	{
		return null;
	}

	[Token(Token = "0x6014ECD")]
	[Address(RVA = "0x2B29260", Offset = "0x2B29260", VA = "0x2B29260")]
	public List<uint> GetTabDownloadInfoIds()
	{
		return null;
	}

	[Token(Token = "0x6014ECE")]
	[Address(RVA = "0x2B29538", Offset = "0x2B29538", VA = "0x2B29538")]
	public bool GetTotalDownloadBtnShowState()
	{
		return default(bool);
	}

	[Token(Token = "0x6014ECF")]
	[Address(RVA = "0x2B22DE8", Offset = "0x2B22DE8", VA = "0x2B22DE8")]
	private void AddTagResDownloadType(uint tag, ResDownloadType type)
	{
	}

	[Token(Token = "0x6014ED0")]
	[Address(RVA = "0x2B29B74", Offset = "0x2B29B74", VA = "0x2B29B74")]
	public EDownloadContextState GetAbStateByFileName(string file_fullName)
	{
		return default(EDownloadContextState);
	}

	[Token(Token = "0x6014ED1")]
	[Address(RVA = "0x2B29EF0", Offset = "0x2B29EF0", VA = "0x2B29EF0")]
	private EDownloadContextState GetProvityDownloadstate(EDownloadContextState old_state, EDownloadContextState new_state)
	{
		return default(EDownloadContextState);
	}

	[Token(Token = "0x6014ED2")]
	[Address(RVA = "0x2B29A50", Offset = "0x2B29A50", VA = "0x2B29A50")]
	private bool HaveEnoughStorage(long require_size)
	{
		return default(bool);
	}

	[Token(Token = "0x6014ED3")]
	[Address(RVA = "0x2B27338", Offset = "0x2B27338", VA = "0x2B27338")]
	public void OwnedNewValutOptionalRes(List<ResourceID> optionalRes)
	{
	}

	[Token(Token = "0x6014ED4")]
	[Address(RVA = "0x2B2C608", Offset = "0x2B2C608", VA = "0x2B2C608")]
	public void OwnedNewValutWeaponOptionalRes(List<ResourceID> optional_weapon_res)
	{
	}

	[Token(Token = "0x6014ED5")]
	[Address(RVA = "0x2B2C97C", Offset = "0x2B2C97C", VA = "0x2B2C97C")]
	public bool IsValidBundleItem(CSSharedItemData itemData)
	{
		return default(bool);
	}

	[Token(Token = "0x6014ED6")]
	[Address(RVA = "0x2B2CA0C", Offset = "0x2B2CA0C", VA = "0x2B2CA0C")]
	public List<ResourceID> ItemOptionalResReallyNeedDownload(CSSharedItemData itemData)
	{
		return null;
	}

	[Token(Token = "0x6014ED7")]
	[Address(RVA = "0x2B29F98", Offset = "0x2B29F98", VA = "0x2B29F98")]
	public void ItemOptionalRes(CSSharedItemData itemData, List<ResourceID> optionalRes)
	{
	}

	[Token(Token = "0x6014ED8")]
	[Address(RVA = "0x2B2CD5C", Offset = "0x2B2CD5C", VA = "0x2B2CD5C")]
	private static void AddRecipeAbResIds(List<ResourceID> dst, string[] recipes)
	{
	}

	[Token(Token = "0x6014ED9")]
	[Address(RVA = "0x2B2CE78", Offset = "0x2B2CE78", VA = "0x2B2CE78")]
	private static void AddRecipeAbResIds(List<ResourceID> dst, string recipe)
	{
	}

	[Token(Token = "0x6014EDA")]
	[Address(RVA = "0x2B2CC40", Offset = "0x2B2CC40", VA = "0x2B2CC40")]
	public bool NeedDownloadRes(ResourceID resId)
	{
		return default(bool);
	}

	[Token(Token = "0x6014EDB")]
	[Address(RVA = "0x2B19DA4", Offset = "0x2B19DA4", VA = "0x2B19DA4")]
	public HashSet<string> SimpleAbNamesOfResourceIds(List<ResourceID> resIds)
	{
		return null;
	}

	[Token(Token = "0x6014EDC")]
	[Address(RVA = "0x2B1A2DC", Offset = "0x2B1A2DC", VA = "0x2B1A2DC")]
	public HashSet<string> AbNamesOfResourceIds(List<ResourceID> resIds)
	{
		return null;
	}

	[Token(Token = "0x6014EDD")]
	[Address(RVA = "0x2B24DBC", Offset = "0x2B24DBC", VA = "0x2B24DBC")]
	public List<ResourceID> GetCurrentAvatarResourceId()
	{
		return null;
	}

	[Token(Token = "0x6014EDE")]
	[Address(RVA = "0x2B24F94", Offset = "0x2B24F94", VA = "0x2B24F94")]
	public List<ResourceID> GetEquipedClothesResourceID()
	{
		return null;
	}

	[Token(Token = "0x6014EDF")]
	[Address(RVA = "0x2B25A28", Offset = "0x2B25A28", VA = "0x2B25A28")]
	public List<ResourceID> GetEquipedWeaponSkinResource()
	{
		return null;
	}

	[Token(Token = "0x6014EE0")]
	[Address(RVA = "0x2B257C0", Offset = "0x2B257C0", VA = "0x2B257C0")]
	public List<ResourceID> GetShowInLobbyWeaponSkin()
	{
		return null;
	}

	[Token(Token = "0x6014EE1")]
	[Address(RVA = "0x2B2526C", Offset = "0x2B2526C", VA = "0x2B2526C")]
	public List<ResourceID> GetAvatarEquipedCollection()
	{
		return null;
	}

	[Token(Token = "0x6014EE2")]
	[Address(RVA = "0x2B25D10", Offset = "0x2B25D10", VA = "0x2B25D10")]
	public List<ResourceID> GetHDLobbyWeaponRackResource()
	{
		return null;
	}

	[Token(Token = "0x6014EE3")]
	[Address(RVA = "0x2B26004", Offset = "0x2B26004", VA = "0x2B26004")]
	public List<ResourceID> GetHDLobbyOtherShowResouce()
	{
		return null;
	}

	[Token(Token = "0x6014EE5")]
	[Address(RVA = "0x2B2D00C", Offset = "0x2B2D00C", VA = "0x2B2D00C")]
	private void _003CCheckOptionalVersionInLauncher_003Em__0()
	{
	}

	[Token(Token = "0x6014EE6")]
	[Address(RVA = "0x2B2D1A4", Offset = "0x2B2D1A4", VA = "0x2B2D1A4")]
	private void _003CCheckOptionalVersion_003Em__1()
	{
	}

	[Token(Token = "0x6014EE7")]
	[Address(RVA = "0x2B2D33C", Offset = "0x2B2D33C", VA = "0x2B2D33C")]
	private void _003ConVersionChecked_003Em__2()
	{
	}

	[Token(Token = "0x6014EE8")]
	[Address(RVA = "0x2B2D44C", Offset = "0x2B2D44C", VA = "0x2B2D44C")]
	private void _003COnEnterLobby_003Em__3()
	{
	}

	[Token(Token = "0x6014EE9")]
	[Address(RVA = "0x2B2D55C", Offset = "0x2B2D55C", VA = "0x2B2D55C")]
	private static void _003CPrepareForBackGroundDownload_003Em__4(ResDownloadType type, ResErrorCode errorCode)
	{
	}

	[Token(Token = "0x6014EEA")]
	[Address(RVA = "0x2B2D94C", Offset = "0x2B2D94C", VA = "0x2B2D94C")]
	private static void _003CPrepareForBackGroundDownload_003Em__5()
	{
	}

	[Token(Token = "0x6014EEB")]
	[Address(RVA = "0x2B2DA48", Offset = "0x2B2DA48", VA = "0x2B2DA48")]
	private void _003CCheckAndAutoDownload_003Em__6()
	{
	}

	[Token(Token = "0x6014EEC")]
	[Address(RVA = "0x2B2DB58", Offset = "0x2B2DB58", VA = "0x2B2DB58")]
	private void _003CCheckAndAutoDownload_003Em__7()
	{
	}

	[Token(Token = "0x6014EED")]
	[Address(RVA = "0x2B2DC68", Offset = "0x2B2DC68", VA = "0x2B2DC68")]
	private void _003CCheckAndAutoDownload_003Em__8()
	{
	}

	[Token(Token = "0x6014EEE")]
	[Address(RVA = "0x2B2DD78", Offset = "0x2B2DD78", VA = "0x2B2DD78")]
	private static void _003CNotifyServieTag_003Em__9(HttpErrorCode error, object res)
	{
	}

	[Token(Token = "0x6014EEF")]
	[Address(RVA = "0x2B2DD7C", Offset = "0x2B2DD7C", VA = "0x2B2DD7C")]
	private void _003CStartSpeedUp_003Em__A()
	{
	}

	[Token(Token = "0x6014EF0")]
	[Address(RVA = "0x2B2DD88", Offset = "0x2B2DD88", VA = "0x2B2DD88")]
	private static int _003CAddNeedDownloadOptionalReDefIdLevel_003Em__B(KeyValuePair<uint, int> i)
	{
		return default(int);
	}

	[Token(Token = "0x6014EF1")]
	[Address(RVA = "0x2B2DDF8", Offset = "0x2B2DDF8", VA = "0x2B2DDF8")]
	public void _003C_003EiFixBaseProxy_ClearCache()
	{
	}

	[Token(Token = "0x6014EF2")]
	[Address(RVA = "0x2B2DE00", Offset = "0x2B2DE00", VA = "0x2B2DE00")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x6014EF3")]
	[Address(RVA = "0x2B2DE08", Offset = "0x2B2DE08", VA = "0x2B2DE08")]
	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	[Token(Token = "0x6014EF4")]
	[Address(RVA = "0x2B2DE10", Offset = "0x2B2DE10", VA = "0x2B2DE10")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
