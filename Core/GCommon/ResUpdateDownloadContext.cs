using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

namespace GCommon;

[Token(Token = "0x20040D4")]
public class ResUpdateDownloadContext : DownloadContext
{
	[Token(Token = "0x20040D5")]
	private sealed class _003CClearTempFileByTag_003Ec__AnonStorey0
	{
		[Token(Token = "0x401B3E9")]
		[FieldOffset(Offset = "0x8")]
		internal string fileName;

		[Token(Token = "0x601A6B5")]
		[Address(RVA = "0x32F0D5C", Offset = "0x32F0D5C", VA = "0x32F0D5C")]
		public _003CClearTempFileByTag_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601A6B6")]
		[Address(RVA = "0x32FB2C4", Offset = "0x32FB2C4", VA = "0x32FB2C4")]
		internal bool _003C_003Em__0(ResVersionInfo.FileInfo a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20040D6")]
	private sealed class _003CCleanCacheByTag_003Ec__AnonStorey1
	{
		[Token(Token = "0x401B3EA")]
		[FieldOffset(Offset = "0x8")]
		internal string fileName;

		[Token(Token = "0x601A6B7")]
		[Address(RVA = "0x32F1478", Offset = "0x32F1478", VA = "0x32F1478")]
		public _003CCleanCacheByTag_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x601A6B8")]
		[Address(RVA = "0x32FB220", Offset = "0x32FB220", VA = "0x32FB220")]
		internal bool _003C_003Em__0(ResVersionInfo.FileInfo a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x401B3BA")]
	[FieldOffset(Offset = "0x30")]
	public int MaxOptionalDownloadThreadCount;

	[Token(Token = "0x401B3BB")]
	[FieldOffset(Offset = "0x34")]
	public int MultiDownloadGCIndex;

	[Token(Token = "0x401B3BC")]
	[FieldOffset(Offset = "0x38")]
	public int MaxRetryCount;

	[Token(Token = "0x401B3BD")]
	[FieldOffset(Offset = "0x3C")]
	public string RemoteAddr;

	[Token(Token = "0x401B3BE")]
	[FieldOffset(Offset = "0x40")]
	public string LocalAddr;

	[Token(Token = "0x401B3BF")]
	[FieldOffset(Offset = "0x44")]
	public string TempCacheAddr;

	[Token(Token = "0x401B3C0")]
	[FieldOffset(Offset = "0x48")]
	public string VersionInfoPath;

	[Token(Token = "0x401B3C1")]
	[FieldOffset(Offset = "0x4C")]
	public string FileInfoPath;

	[Token(Token = "0x401B3C2")]
	[FieldOffset(Offset = "0x50")]
	public string AssetBundlePrefix;

	[Token(Token = "0x401B3C3")]
	[FieldOffset(Offset = "0x54")]
	public bool SingleFileDownloadFinished;

	[Token(Token = "0x401B3C4")]
	[FieldOffset(Offset = "0x58")]
	protected Action<ResDownloadType> m_OnVersionCheckFinished;

	[Token(Token = "0x401B3C5")]
	[FieldOffset(Offset = "0x5C")]
	private Action<ResErrorCode, ResDownloadType, ResVersionInfo.FileInfo> m_SingleFileFinishedCallBack;

	[Token(Token = "0x401B3C6")]
	[FieldOffset(Offset = "0x60")]
	private Action<ResErrorCode, ResDownloadType, ResVersionInfo.FileInfo> m_FileFinishedNotify;

	[Token(Token = "0x401B3C7")]
	[FieldOffset(Offset = "0x64")]
	public List<ResVersionInfo.FileInfo> m_NeedRetryFileInfo;

	[Token(Token = "0x401B3C8")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<uint, List<ResVersionInfo.FileInfo>> m_TagFilesMap;

	[Token(Token = "0x401B3C9")]
	[FieldOffset(Offset = "0x6C")]
	private Dictionary<uint, EDownloadContextMode> m_TagDownloadStateMap;

	[Token(Token = "0x401B3CA")]
	[FieldOffset(Offset = "0x70")]
	private string _003CCacheAddr_003Ek__BackingField;

	[Token(Token = "0x401B3CB")]
	[FieldOffset(Offset = "0x74")]
	private string _003COldVersionCacheAddr_003Ek__BackingField;

	[Token(Token = "0x401B3CC")]
	[FieldOffset(Offset = "0x78")]
	private bool _003CNeedDownload_003Ek__BackingField;

	[Token(Token = "0x401B3CD")]
	[FieldOffset(Offset = "0x79")]
	private bool _003CNeedCheckVersion_003Ek__BackingField;

	[Token(Token = "0x401B3CE")]
	[FieldOffset(Offset = "0x7A")]
	private bool _003CRunningCheckVersion_003Ek__BackingField;

	[Token(Token = "0x401B3CF")]
	[FieldOffset(Offset = "0x80")]
	private long _003CDownloadedSize_003Ek__BackingField;

	[Token(Token = "0x401B3D0")]
	[FieldOffset(Offset = "0x88")]
	private long _003CTotalZipSize_003Ek__BackingField;

	[Token(Token = "0x401B3D1")]
	[FieldOffset(Offset = "0x90")]
	private long _003CTotalSize_003Ek__BackingField;

	[Token(Token = "0x401B3D2")]
	[FieldOffset(Offset = "0x98")]
	private bool _003CNeedContinueWithDownloadAll_003Ek__BackingField;

	[Token(Token = "0x401B3D3")]
	[FieldOffset(Offset = "0xA0")]
	public long m_StartDownloadSize;

	[Token(Token = "0x401B3D4")]
	[FieldOffset(Offset = "0xA8")]
	private EDownloadContextMode _003CDownloadMode_003Ek__BackingField;

	[Token(Token = "0x401B3D5")]
	[FieldOffset(Offset = "0xAC")]
	public List<ResVersionInfo.FileInfo> LastInDownloadFileList;

	[Token(Token = "0x401B3D6")]
	[FieldOffset(Offset = "0xB0")]
	public bool HaveVersionUpdate;

	[Token(Token = "0x401B3D7")]
	[FieldOffset(Offset = "0xB1")]
	public bool NeedSkipVersion;

	[Token(Token = "0x401B3D8")]
	[FieldOffset(Offset = "0xB2")]
	public bool NeedAutoResume;

	[Token(Token = "0x401B3D9")]
	[FieldOffset(Offset = "0xB4")]
	public Action<ResDownloadType, ResErrorCode> BackGroundDownloadFinished;

	[Token(Token = "0x401B3DA")]
	[FieldOffset(Offset = "0xB8")]
	private HashSet<ResVersionInfo.FileInfo> m_DownloadingFileList;

	[Token(Token = "0x401B3DB")]
	[FieldOffset(Offset = "0xBC")]
	private Dictionary<ResVersionInfo.FileInfo, ResLoaderInfo> m_LoaderInfoMap;

	[Token(Token = "0x401B3DC")]
	[FieldOffset(Offset = "0xC0")]
	protected DownloadVersionInfo m_LocalVersionInfo;

	[Token(Token = "0x401B3DD")]
	[FieldOffset(Offset = "0xC4")]
	protected DownloadVersionInfo m_RemoteVersionInfo;

	[Token(Token = "0x401B3DE")]
	[FieldOffset(Offset = "0xC8")]
	protected ResUpdateDownloadEngine m_OwnedEngine;

	[Token(Token = "0x401B3DF")]
	[FieldOffset(Offset = "0xCC")]
	protected bool m_NeedCheckFileState;

	[Token(Token = "0x401B3E0")]
	[FieldOffset(Offset = "0xD0")]
	protected List<string> m_NeedRemoveFilePathes;

	[Token(Token = "0x401B3E1")]
	[FieldOffset(Offset = "0xD4")]
	protected int m_MaxLoaderCount;

	[Token(Token = "0x401B3E2")]
	[FieldOffset(Offset = "0xD8")]
	protected bool m_ShouldOverrideWithFull;

	[Token(Token = "0x401B3E3")]
	[FieldOffset(Offset = "0xD9")]
	protected bool m_ShoulClearMemWhenAutoPause;

	[Token(Token = "0x401B3E4")]
	[FieldOffset(Offset = "0xDC")]
	private List<string> m_LoginDownloadFileName;

	[Token(Token = "0x401B3E5")]
	[FieldOffset(Offset = "0xE0")]
	private uint Have_finshed_file;

	[Token(Token = "0x401B3E6")]
	[FieldOffset(Offset = "0xE4")]
	private Action<ResErrorCode, ResDownloadType> UpdateDownloadFinishedCallBack;

	[Token(Token = "0x401B3E7")]
	[FieldOffset(Offset = "0xE8")]
	private uint Error_occur_File;

	[Token(Token = "0x401B3E8")]
	[FieldOffset(Offset = "0xEC")]
	private List<ResVersionInfo.FileInfo> m_LoginDownloadFileInfo;

	[Token(Token = "0x17001CE7")]
	public List<ResVersionInfo.FileInfo> NeedRetryFileInfo
	{
		[Token(Token = "0x601A64B")]
		[Address(RVA = "0x32ED8DC", Offset = "0x32ED8DC", VA = "0x32ED8DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CE8")]
	public bool IsPendding
	{
		[Token(Token = "0x601A64C")]
		[Address(RVA = "0x32ED8E4", Offset = "0x32ED8E4", VA = "0x32ED8E4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001CE9")]
	public string CacheAddr
	{
		[Token(Token = "0x601A64D")]
		[Address(RVA = "0x32EDA2C", Offset = "0x32EDA2C", VA = "0x32EDA2C")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A64E")]
		[Address(RVA = "0x32ED8A4", Offset = "0x32ED8A4", VA = "0x32ED8A4")]
		protected set
		{
		}
	}

	[Token(Token = "0x17001CEA")]
	public string OldVersionCacheAddr
	{
		[Token(Token = "0x601A64F")]
		[Address(RVA = "0x32EDA34", Offset = "0x32EDA34", VA = "0x32EDA34")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A650")]
		[Address(RVA = "0x32ED8AC", Offset = "0x32ED8AC", VA = "0x32ED8AC")]
		protected set
		{
		}
	}

	[Token(Token = "0x17001CEB")]
	public bool NeedDownload
	{
		[Token(Token = "0x601A651")]
		[Address(RVA = "0x32EDA3C", Offset = "0x32EDA3C", VA = "0x32EDA3C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A652")]
		[Address(RVA = "0x32ED8BC", Offset = "0x32ED8BC", VA = "0x32ED8BC")]
		protected set
		{
		}
	}

	[Token(Token = "0x17001CEC")]
	public bool NeedCheckVersion
	{
		[Token(Token = "0x601A653")]
		[Address(RVA = "0x32EDA44", Offset = "0x32EDA44", VA = "0x32EDA44")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A654")]
		[Address(RVA = "0x32ED8C4", Offset = "0x32ED8C4", VA = "0x32ED8C4")]
		protected set
		{
		}
	}

	[Token(Token = "0x17001CED")]
	public bool RunningCheckVersion
	{
		[Token(Token = "0x601A655")]
		[Address(RVA = "0x32EDA4C", Offset = "0x32EDA4C", VA = "0x32EDA4C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A656")]
		[Address(RVA = "0x32ED8CC", Offset = "0x32ED8CC", VA = "0x32ED8CC")]
		protected set
		{
		}
	}

	[Token(Token = "0x17001CEE")]
	public long DownloadedSize
	{
		[Token(Token = "0x601A657")]
		[Address(RVA = "0x32EDA54", Offset = "0x32EDA54", VA = "0x32EDA54")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x601A658")]
		[Address(RVA = "0x32EDA5C", Offset = "0x32EDA5C", VA = "0x32EDA5C")]
		protected set
		{
		}
	}

	[Token(Token = "0x17001CEF")]
	public long TotalZipSize
	{
		[Token(Token = "0x601A659")]
		[Address(RVA = "0x32EDA6C", Offset = "0x32EDA6C", VA = "0x32EDA6C")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x601A65A")]
		[Address(RVA = "0x32EDA74", Offset = "0x32EDA74", VA = "0x32EDA74")]
		protected set
		{
		}
	}

	[Token(Token = "0x17001CF0")]
	public long TotalSize
	{
		[Token(Token = "0x601A65B")]
		[Address(RVA = "0x32EDA84", Offset = "0x32EDA84", VA = "0x32EDA84")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x601A65C")]
		[Address(RVA = "0x32EDA8C", Offset = "0x32EDA8C", VA = "0x32EDA8C")]
		protected set
		{
		}
	}

	[Token(Token = "0x17001CF1")]
	public bool NeedContinueWithDownloadAll
	{
		[Token(Token = "0x601A65D")]
		[Address(RVA = "0x32EDA9C", Offset = "0x32EDA9C", VA = "0x32EDA9C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A65E")]
		[Address(RVA = "0x32EDAA4", Offset = "0x32EDAA4", VA = "0x32EDAA4")]
		private set
		{
		}
	}

	[Token(Token = "0x17001CF2")]
	public EDownloadContextMode DownloadMode
	{
		[Token(Token = "0x601A65F")]
		[Address(RVA = "0x32EDAAC", Offset = "0x32EDAAC", VA = "0x32EDAAC")]
		get
		{
			return default(EDownloadContextMode);
		}
		[Token(Token = "0x601A660")]
		[Address(RVA = "0x32ED8D4", Offset = "0x32ED8D4", VA = "0x32ED8D4")]
		protected set
		{
		}
	}

	[Token(Token = "0x17001CF3")]
	public virtual bool SupportBackgroundDownload
	{
		[Token(Token = "0x601A661")]
		[Address(RVA = "0x32EDAB4", Offset = "0x32EDAB4", VA = "0x32EDAB4", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001CF4")]
	public string Version
	{
		[Token(Token = "0x601A662")]
		[Address(RVA = "0x32EDABC", Offset = "0x32EDABC", VA = "0x32EDABC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A64A")]
	[Address(RVA = "0x32ED1CC", Offset = "0x32ED1CC", VA = "0x32ED1CC")]
	public ResUpdateDownloadContext(ResUpdateDownloadEngine owned_engine, ResDownloadType type, int maxLoaderCountSimultaneously)
	{
	}

	[Token(Token = "0x601A663")]
	[Address(RVA = "0x32EDB30", Offset = "0x32EDB30", VA = "0x32EDB30", Slot = "4")]
	public override void Clear()
	{
	}

	[Token(Token = "0x601A664")]
	[Address(RVA = "0x32EDC24", Offset = "0x32EDC24", VA = "0x32EDC24")]
	public void ChangeStateToDownload()
	{
	}

	[Token(Token = "0x601A665")]
	[Address(RVA = "0x32EDC30", Offset = "0x32EDC30", VA = "0x32EDC30")]
	public void SetBackgroundFinishedCallBack(Action<ResDownloadType, ResErrorCode> call_back)
	{
	}

	[Token(Token = "0x601A666")]
	[Address(RVA = "0x32EDCF8", Offset = "0x32EDCF8", VA = "0x32EDCF8")]
	private void OnBackGroundFinished()
	{
	}

	[Token(Token = "0x601A667")]
	[Address(RVA = "0x32EDDE4", Offset = "0x32EDDE4", VA = "0x32EDDE4")]
	public void StartBackgroundThread()
	{
	}

	[Token(Token = "0x601A668")]
	[Address(RVA = "0x32EDE28", Offset = "0x32EDE28", VA = "0x32EDE28")]
	public void OnApplicationPaused(bool is_paused)
	{
	}

	[Token(Token = "0x601A669")]
	[Address(RVA = "0x32EDF4C", Offset = "0x32EDF4C", VA = "0x32EDF4C")]
	public void WWWLoad(string path, Action<WWW, ResWWWFileLoader> onLoaded, bool isFromRemote, long totalSize = 0L, bool includeVersionDir = true, [Optional] ResVersionInfo.FileInfo file_info)
	{
	}

	[Token(Token = "0x601A66A")]
	[Address(RVA = "0x32EE448", Offset = "0x32EE448", VA = "0x32EE448")]
	public void BigFileDownload(ResVersionInfo.FileInfo file_info, string path, Action<UnityWebRequest, ResWithTempFileLoader> onLoaded, bool addLoaderFirst = false)
	{
	}

	[Token(Token = "0x601A66B")]
	[Address(RVA = "0x32EED78", Offset = "0x32EED78", VA = "0x32EED78")]
	public void Unzip(ResVersionInfo.FileInfo file_info, Action<string, ResUnzipFileLoader> onLoaded, bool addProgressSize = false, bool addFirst = false, bool isBackGroundLoaderDownloadFinished = false)
	{
	}

	[Token(Token = "0x601A66C")]
	[Address(RVA = "0x32EF308", Offset = "0x32EF308", VA = "0x32EF308")]
	public string GetLocalPathByPlatfromByFileInfo(ResVersionInfo.FileInfo fileInfo, ResVersionInfo.FileInfo.OpState targetState, bool need_cache = true)
	{
		return null;
	}

	[Token(Token = "0x601A66D")]
	[Address(RVA = "0x32EFAC4", Offset = "0x32EFAC4", VA = "0x32EFAC4")]
	protected bool SaveFile(string path, byte[] content)
	{
		return default(bool);
	}

	[Token(Token = "0x601A66E")]
	[Address(RVA = "0x32EFEE8", Offset = "0x32EFEE8", VA = "0x32EFEE8")]
	protected bool MoveTempFile(string relativePath, string tempPath)
	{
		return default(bool);
	}

	[Token(Token = "0x601A66F")]
	[Address(RVA = "0x32F0284", Offset = "0x32F0284", VA = "0x32F0284")]
	protected void ClearTempFile(string tempPath, [Optional] string flagPath)
	{
	}

	[Token(Token = "0x601A670")]
	[Address(RVA = "0x32F04D8", Offset = "0x32F04D8", VA = "0x32F04D8")]
	public void ClearAllTempFile()
	{
	}

	[Token(Token = "0x601A671")]
	[Address(RVA = "0x32F0840", Offset = "0x32F0840", VA = "0x32F0840")]
	public void ClearTempFileByTag(uint tag, bool deleteRecommend = false, bool deleteDownloadIngTagFile = true, uint downloading_tag = 0u)
	{
	}

	[Token(Token = "0x601A672")]
	[Address(RVA = "0x32F0D64", Offset = "0x32F0D64", VA = "0x32F0D64")]
	public void CleanCache()
	{
	}

	[Token(Token = "0x601A673")]
	[Address(RVA = "0x32F1020", Offset = "0x32F1020", VA = "0x32F1020")]
	public void CleanCacheByTag(uint tag, bool DeleteRecommend = false, bool deleteDownloadIngTagFile = true, uint downloading_tag = 0u)
	{
	}

	[Token(Token = "0x601A674")]
	[Address(RVA = "0x32F1480", Offset = "0x32F1480", VA = "0x32F1480")]
	public void CleanFiltCache()
	{
	}

	[Token(Token = "0x601A675")]
	[Address(RVA = "0x32F17B4", Offset = "0x32F17B4", VA = "0x32F17B4")]
	public void CleanCache(string file_name)
	{
	}

	[Token(Token = "0x601A676")]
	[Address(RVA = "0x32F1B40", Offset = "0x32F1B40", VA = "0x32F1B40")]
	public void RemoveLoaderByTag(uint tag)
	{
	}

	[Token(Token = "0x601A677")]
	[Address(RVA = "0x32F1DD4", Offset = "0x32F1DD4", VA = "0x32F1DD4")]
	public void DeleteLoaderByTag(uint tag, bool deleteRecommend, bool deleteDownloadIngTagFile, uint downloading_tag)
	{
	}

	[Token(Token = "0x601A678")]
	[Address(RVA = "0x32F21D8", Offset = "0x32F21D8", VA = "0x32F21D8", Slot = "9")]
	public virtual void DeleteAllFile()
	{
	}

	[Token(Token = "0x601A679")]
	[Address(RVA = "0x32F2978", Offset = "0x32F2978", VA = "0x32F2978")]
	public void DeleteFileByTag(uint tag, bool deleteRecommend = false, bool deleteDownloadIngTagFile = true, uint downloading_tag = 0u)
	{
	}

	[Token(Token = "0x601A67A")]
	[Address(RVA = "0x32F2A50", Offset = "0x32F2A50", VA = "0x32F2A50")]
	private void ClearByTag(uint tag)
	{
	}

	[Token(Token = "0x601A67B")]
	[Address(RVA = "0x32F2B04", Offset = "0x32F2B04", VA = "0x32F2B04")]
	public void DeleleAllReplacedFiles()
	{
	}

	[Token(Token = "0x601A67C")]
	[Address(RVA = "0x32F2E40", Offset = "0x32F2E40", VA = "0x32F2E40", Slot = "6")]
	public override void StartDownload([Optional] Action<ResErrorCode, ResDownloadType> callback)
	{
	}

	[Token(Token = "0x601A67D")]
	[Address(RVA = "0x32F2E4C", Offset = "0x32F2E4C", VA = "0x32F2E4C")]
	public void StartDownload(bool need_add_first, [Optional] Action<ResErrorCode, ResDownloadType> callback)
	{
	}

	[Token(Token = "0x601A67E")]
	[Address(RVA = "0x32F34E8", Offset = "0x32F34E8", VA = "0x32F34E8")]
	public void StartDownloadAllFile(Action<ResErrorCode, ResDownloadType> callback, [Optional] Action<ResErrorCode, ResDownloadType, ResVersionInfo.FileInfo> file_downloaded_notify, bool manualDownload = false, uint tag = 0u)
	{
	}

	[Token(Token = "0x601A67F")]
	[Address(RVA = "0x32F37DC", Offset = "0x32F37DC", VA = "0x32F37DC")]
	private void StartDownloadFile(List<string> download_file_names, Action<ResErrorCode, ResDownloadType> callback, [Optional] Action<ResErrorCode, ResDownloadType, ResVersionInfo.FileInfo> file_downloaded_notify, bool manualDownload = false, uint tag = 0u)
	{
	}

	[Token(Token = "0x601A680")]
	[Address(RVA = "0x32F40FC", Offset = "0x32F40FC", VA = "0x32F40FC")]
	public void StartDownloadFileByTag(uint Tag, [Optional] Action<ResErrorCode, ResDownloadType> callback, [Optional] Action<ResErrorCode, ResDownloadType, ResVersionInfo.FileInfo> single_file_call_back, bool manualDownload = false)
	{
	}

	[Token(Token = "0x601A681")]
	[Address(RVA = "0x32F4390", Offset = "0x32F4390", VA = "0x32F4390")]
	public void StartDownloadDesignatedFile(string ab_path, [Optional] Action<ResErrorCode, ResDownloadType> callback, [Optional] Action<ResErrorCode, ResDownloadType, ResVersionInfo.FileInfo> single_file_call_back, bool manualDownload = false)
	{
	}

	[Token(Token = "0x601A682")]
	[Address(RVA = "0x32F4468", Offset = "0x32F4468", VA = "0x32F4468", Slot = "5")]
	public override void PauseDownload(bool isPause, bool is_auto_pause = false)
	{
	}

	[Token(Token = "0x601A683")]
	[Address(RVA = "0x32F48D4", Offset = "0x32F48D4", VA = "0x32F48D4")]
	public List<ResVersionInfo.FileInfo> GetAllFileInfos()
	{
		return null;
	}

	[Token(Token = "0x601A684")]
	[Address(RVA = "0x32F4B04", Offset = "0x32F4B04", VA = "0x32F4B04")]
	public void SortTagFileList()
	{
	}

	[Token(Token = "0x601A685")]
	[Address(RVA = "0x32F5258", Offset = "0x32F5258", VA = "0x32F5258", Slot = "10")]
	public virtual void StartGetLocalVersion([Optional] Action<ResDownloadType> on_version_check_finished)
	{
	}

	[Token(Token = "0x601A686")]
	[Address(RVA = "0x32F554C", Offset = "0x32F554C", VA = "0x32F554C")]
	protected void onLocalVersionInfoLoaded(bool result)
	{
	}

	[Token(Token = "0x601A687")]
	[Address(RVA = "0x32F56EC", Offset = "0x32F56EC", VA = "0x32F56EC", Slot = "11")]
	public virtual void StartVersionCheck()
	{
	}

	[Token(Token = "0x601A688")]
	[Address(RVA = "0x32F5C60", Offset = "0x32F5C60", VA = "0x32F5C60", Slot = "12")]
	protected virtual void onRemoteVersionInfoLoaded(bool result)
	{
	}

	[Token(Token = "0x601A689")]
	[Address(RVA = "0x32F5EE8", Offset = "0x32F5EE8", VA = "0x32F5EE8")]
	private void onLocalFileInfoLoaded_Pass(bool result)
	{
	}

	[Token(Token = "0x601A68A")]
	[Address(RVA = "0x32F5FEC", Offset = "0x32F5FEC", VA = "0x32F5FEC")]
	protected void onLocalFileInfoLoaded_Update(bool result)
	{
	}

	[Token(Token = "0x601A68B")]
	[Address(RVA = "0x32F6168", Offset = "0x32F6168", VA = "0x32F6168", Slot = "13")]
	protected virtual void onRemoteFileInfoLoaded(bool result)
	{
	}

	[Token(Token = "0x601A68C")]
	[Address(RVA = "0x32F5B60", Offset = "0x32F5B60", VA = "0x32F5B60")]
	protected void onVersionChecked()
	{
	}

	[Token(Token = "0x601A68D")]
	[Address(RVA = "0x32F44CC", Offset = "0x32F44CC", VA = "0x32F44CC")]
	public void CheckFileStates()
	{
	}

	[Token(Token = "0x601A68E")]
	[Address(RVA = "0x32F2298", Offset = "0x32F2298", VA = "0x32F2298")]
	protected void CheckNeedDownload(bool refresh_last_download = false)
	{
	}

	[Token(Token = "0x601A68F")]
	[Address(RVA = "0x32F71EC", Offset = "0x32F71EC", VA = "0x32F71EC")]
	private void UpdateNeedDownloadSize([Optional] ResVersionInfo.FileInfo fileInfo, bool is_unzip = false)
	{
	}

	[Token(Token = "0x601A690")]
	[Address(RVA = "0x32F7500", Offset = "0x32F7500", VA = "0x32F7500")]
	protected void NotifyFileDownloaded(ResErrorCode result, ResFileLoader loader)
	{
	}

	[Token(Token = "0x601A691")]
	[Address(RVA = "0x32F77B8", Offset = "0x32F77B8", VA = "0x32F77B8")]
	protected void NotifyFileUnZipped(string hash_code, ResUnzipFileLoader unzip_loader)
	{
	}

	[Token(Token = "0x601A692")]
	[Address(RVA = "0x32F8254", Offset = "0x32F8254", VA = "0x32F8254")]
	public ResVersionInfo.FileInfo GetCurrentDownloadFileInfo()
	{
		return null;
	}

	[Token(Token = "0x601A693")]
	[Address(RVA = "0x32F40EC", Offset = "0x32F40EC", VA = "0x32F40EC")]
	public void UpdateLastError(ResErrorCode error)
	{
	}

	[Token(Token = "0x601A694")]
	[Address(RVA = "0x32F826C", Offset = "0x32F826C", VA = "0x32F826C")]
	public ResErrorCode GetDetailedDownloadError(string error)
	{
		return default(ResErrorCode);
	}

	[Token(Token = "0x601A695")]
	[Address(RVA = "0x32F82F0", Offset = "0x32F82F0", VA = "0x32F82F0")]
	public ResVersionInfo.FileInfo GetLocalFileInfo(string path)
	{
		return null;
	}

	[Token(Token = "0x601A696")]
	[Address(RVA = "0x32F833C", Offset = "0x32F833C", VA = "0x32F833C")]
	public bool FileExist(ResVersionInfo.FileInfo fileInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x601A697")]
	[Address(RVA = "0x32F83C4", Offset = "0x32F83C4", VA = "0x32F83C4")]
	public string GetLocalPathByPlatfrom(string path)
	{
		return null;
	}

	[Token(Token = "0x601A698")]
	[Address(RVA = "0x32F84FC", Offset = "0x32F84FC", VA = "0x32F84FC", Slot = "7")]
	public override void InvokeFinishCallBack()
	{
	}

	[Token(Token = "0x601A699")]
	[Address(RVA = "0x32F4028", Offset = "0x32F4028", VA = "0x32F4028")]
	protected bool HaveEnoughStorage(long require_size)
	{
		return default(bool);
	}

	[Token(Token = "0x601A69A")]
	[Address(RVA = "0x32F85E8", Offset = "0x32F85E8", VA = "0x32F85E8")]
	public ResLoaderInfo GetLoaderByFileInfo(ResVersionInfo.FileInfo info)
	{
		return null;
	}

	[Token(Token = "0x601A69B")]
	[Address(RVA = "0x32F8688", Offset = "0x32F8688", VA = "0x32F8688")]
	public bool IsInPending()
	{
		return default(bool);
	}

	[Token(Token = "0x601A69C")]
	[Address(RVA = "0x32F86C4", Offset = "0x32F86C4", VA = "0x32F86C4")]
	public bool IsRuning()
	{
		return default(bool);
	}

	[Token(Token = "0x601A69D")]
	[Address(RVA = "0x32F8700", Offset = "0x32F8700", VA = "0x32F8700")]
	public long GetTotalSizeInByte()
	{
		return default(long);
	}

	[Token(Token = "0x601A69E")]
	[Address(RVA = "0x32F8720", Offset = "0x32F8720", VA = "0x32F8720")]
	public long GetTotalLoadedSizeInByte()
	{
		return default(long);
	}

	[Token(Token = "0x601A69F")]
	[Address(RVA = "0x32F876C", Offset = "0x32F876C", VA = "0x32F876C", Slot = "14")]
	public virtual float GetFileDownloadProcess()
	{
		return default(float);
	}

	[Token(Token = "0x601A6A0")]
	[Address(RVA = "0x32F8860", Offset = "0x32F8860", VA = "0x32F8860")]
	public float GetFileDownloadSize()
	{
		return default(float);
	}

	[Token(Token = "0x601A6A1")]
	[Address(RVA = "0x32F88AC", Offset = "0x32F88AC", VA = "0x32F88AC")]
	public long GetTagFileRequireDownloadSize(uint tag)
	{
		return default(long);
	}

	[Token(Token = "0x601A6A2")]
	[Address(RVA = "0x32F8AC0", Offset = "0x32F8AC0", VA = "0x32F8AC0")]
	public void AddTagFilesPair(uint tag, List<ResVersionInfo.FileInfo> fileInfoList, bool isRecommend = false)
	{
	}

	[Token(Token = "0x601A6A3")]
	[Address(RVA = "0x32F8F80", Offset = "0x32F8F80", VA = "0x32F8F80")]
	public void AddTagFilesPair(uint tag, ResVersionInfo.FileInfo fileInfo, bool isRecommend = false)
	{
	}

	[Token(Token = "0x601A6A4")]
	[Address(RVA = "0x32F9200", Offset = "0x32F9200", VA = "0x32F9200")]
	public List<uint> GetTagListByModeAllFile()
	{
		return null;
	}

	[Token(Token = "0x601A6A5")]
	[Address(RVA = "0x32F9458", Offset = "0x32F9458", VA = "0x32F9458")]
	public void AddTagDownloadStatePair(uint tag, EDownloadContextMode eDownloadContextState = EDownloadContextMode.DesignatedFile)
	{
	}

	[Token(Token = "0x601A6A6")]
	[Address(RVA = "0x32F9518", Offset = "0x32F9518", VA = "0x32F9518")]
	public EDownloadContextMode GetTagDownloadState(uint tag)
	{
		return default(EDownloadContextMode);
	}

	[Token(Token = "0x601A6A7")]
	[Address(RVA = "0x32F95B0", Offset = "0x32F95B0", VA = "0x32F95B0")]
	public List<ResVersionInfo.FileInfo> FileInfosByTag(uint tag)
	{
		return null;
	}

	[Token(Token = "0x601A6A8")]
	[Address(RVA = "0x32F9648", Offset = "0x32F9648", VA = "0x32F9648")]
	public float GetTagFileDownloadedSize(uint tag)
	{
		return default(float);
	}

	[Token(Token = "0x601A6A9")]
	[Address(RVA = "0x32F99DC", Offset = "0x32F99DC", VA = "0x32F99DC")]
	public bool IsTagContainRecommendFile(uint tag)
	{
		return default(bool);
	}

	[Token(Token = "0x601A6AA")]
	[Address(RVA = "0x32F9B70", Offset = "0x32F9B70", VA = "0x32F9B70")]
	public long GetTotalTagZipSize(uint tag, ref bool isRecommend, ref long TotalOutSize)
	{
		return default(long);
	}

	[Token(Token = "0x601A6AB")]
	[Address(RVA = "0x32F9E6C", Offset = "0x32F9E6C", VA = "0x32F9E6C")]
	public bool GetTagFileDownloadState(uint tag)
	{
		return default(bool);
	}

	[Token(Token = "0x601A6AC")]
	[Address(RVA = "0x32FA020", Offset = "0x32FA020", VA = "0x32FA020")]
	public void ClearFileTagTable(uint tag)
	{
	}

	[Token(Token = "0x601A6AD")]
	[Address(RVA = "0x32FA2FC", Offset = "0x32FA2FC", VA = "0x32FA2FC")]
	public void StartDownloadLoginFile(Action<ResErrorCode, ResDownloadType> call_back)
	{
	}

	[Token(Token = "0x601A6AE")]
	[Address(RVA = "0x32FA424", Offset = "0x32FA424", VA = "0x32FA424")]
	private void LoginUpdateDownloadCallBack(ResErrorCode error_code, ResDownloadType resDownloadType, ResVersionInfo.FileInfo fileInfo)
	{
	}

	[Token(Token = "0x601A6AF")]
	[Address(RVA = "0x32FA900", Offset = "0x32FA900", VA = "0x32FA900")]
	public void ClearUpdateLoginFinishedCallBack()
	{
	}

	[Token(Token = "0x601A6B0")]
	[Address(RVA = "0x32FA954", Offset = "0x32FA954", VA = "0x32FA954")]
	public float GetLoginUpdateDownloadProcess()
	{
		return default(float);
	}

	[Token(Token = "0x601A6B1")]
	[Address(RVA = "0x32FA9E0", Offset = "0x32FA9E0", VA = "0x32FA9E0")]
	private void _003COnBackGroundFinished_003Em__0()
	{
	}

	[Token(Token = "0x601A6B2")]
	[Address(RVA = "0x32FAA18", Offset = "0x32FAA18", VA = "0x32FAA18")]
	private void _003CStartDownloadFile_003Em__1(UnityWebRequest www, ResWithTempFileLoader loader)
	{
	}

	[Token(Token = "0x601A6B3")]
	[Address(RVA = "0x32FB218", Offset = "0x32FB218", VA = "0x32FB218")]
	private void _003CStartDownloadFile_003Em__2(string hashCode, ResUnzipFileLoader unzip_loader)
	{
	}

	[Token(Token = "0x601A6B4")]
	[Address(RVA = "0x32FB21C", Offset = "0x32FB21C", VA = "0x32FB21C")]
	private void _003CNotifyFileDownloaded_003Em__3(string hashCode, ResUnzipFileLoader unzip_loader)
	{
	}
}
