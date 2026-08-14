using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TsiU;

namespace GCommon;

[Token(Token = "0x20040D9")]
public class ResUpdateDownloadEngine : TSingleton<ResUpdateDownloadEngine>
{
	[Token(Token = "0x20040DA")]
	private sealed class _003CStartGetLocalVersionInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x401B3FD")]
		[FieldOffset(Offset = "0x8")]
		internal List<uint> type_list;

		[Token(Token = "0x401B3FE")]
		[FieldOffset(Offset = "0xC")]
		internal Action finished_callback;

		[Token(Token = "0x401B3FF")]
		[FieldOffset(Offset = "0x10")]
		internal ResUpdateDownloadEngine _0024this;

		[Token(Token = "0x601A6EE")]
		[Address(RVA = "0x32FBD68", Offset = "0x32FBD68", VA = "0x32FBD68")]
		public _003CStartGetLocalVersionInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601A6EF")]
		[Address(RVA = "0x32FC8DC", Offset = "0x32FC8DC", VA = "0x32FC8DC")]
		internal void _003C_003Em__0(ResDownloadType _context_type)
		{
		}
	}

	[Token(Token = "0x20040DB")]
	private sealed class _003CStartGetLocalVersionInfo_003Ec__AnonStorey1
	{
		[Token(Token = "0x401B400")]
		[FieldOffset(Offset = "0x8")]
		internal Action finished_callback;

		[Token(Token = "0x601A6F0")]
		[Address(RVA = "0x32FBE90", Offset = "0x32FBE90", VA = "0x32FBE90")]
		public _003CStartGetLocalVersionInfo_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x601A6F1")]
		[Address(RVA = "0x32FC910", Offset = "0x32FC910", VA = "0x32FC910")]
		internal void _003C_003Em__0(ResDownloadType _context_type)
		{
		}
	}

	[Token(Token = "0x401B3EB")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, int> RESDOWNLOADTYPE_LEVEL_MAP;

	[Token(Token = "0x401B3EC")]
	[FieldOffset(Offset = "0x8")]
	public Dictionary<uint, string> VersionMap;

	[Token(Token = "0x401B3ED")]
	[FieldOffset(Offset = "0xC")]
	public Dictionary<uint, string[]> LoginDownloadMap;

	[Token(Token = "0x401B3EE")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, uint> m_FileNameMap;

	[Token(Token = "0x401B3EF")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<uint, ResUpdateDownloadContext> m_DownloadContextMap;

	[Token(Token = "0x401B3F0")]
	[FieldOffset(Offset = "0x18")]
	private LinkedList<ResUpdateDownloadContext> m_PendingDownloadContext;

	[Token(Token = "0x401B3F1")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<ResVersionInfo.FileInfo, ResFileLoader> m_LoaderInfoMap;

	[Token(Token = "0x401B3F2")]
	[FieldOffset(Offset = "0x20")]
	private ResHotUpdaterContext _003CHotUpdaterContext_003Ek__BackingField;

	[Token(Token = "0x401B3F3")]
	[FieldOffset(Offset = "0x24")]
	private string _003CCDNAddr_003Ek__BackingField;

	[Token(Token = "0x401B3F4")]
	[FieldOffset(Offset = "0x28")]
	private bool _003CEnableBackgroundDownload_003Ek__BackingField;

	[Token(Token = "0x401B3F5")]
	[FieldOffset(Offset = "0x29")]
	private bool _003CEnableBackgroundDownloadInLobby_003Ek__BackingField;

	[Token(Token = "0x401B3F6")]
	[FieldOffset(Offset = "0x2C")]
	public Action BackgroundDownloadStart;

	[Token(Token = "0x401B3F7")]
	[FieldOffset(Offset = "0x30")]
	public Action<ResDownloadType, ResErrorCode> BackgroundDownloadFinishedCallback;

	[Token(Token = "0x401B3F8")]
	[FieldOffset(Offset = "0x34")]
	public int UnZipBuffSize;

	[Token(Token = "0x401B3F9")]
	[FieldOffset(Offset = "0x38")]
	public bool NeedInitFileLength;

	[Token(Token = "0x401B3FA")]
	[FieldOffset(Offset = "0x3C")]
	public int MultiDownloadGCIndex;

	[Token(Token = "0x401B3FB")]
	[FieldOffset(Offset = "0x40")]
	public bool EnableClearMemWhenAutoPause;

	[Token(Token = "0x401B3FC")]
	private const int BASE_UNZIP_SIZE = 102400;

	[Token(Token = "0x17001CF6")]
	public ResHotUpdaterContext HotUpdaterContext
	{
		[Token(Token = "0x601A6C7")]
		[Address(RVA = "0x32ED8B4", Offset = "0x32ED8B4", VA = "0x32ED8B4")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A6C8")]
		[Address(RVA = "0x32FB43C", Offset = "0x32FB43C", VA = "0x32FB43C")]
		private set
		{
		}
	}

	[Token(Token = "0x17001CF7")]
	public string CDNAddr
	{
		[Token(Token = "0x601A6C9")]
		[Address(RVA = "0x32F5B58", Offset = "0x32F5B58", VA = "0x32F5B58")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A6CA")]
		[Address(RVA = "0x32FB444", Offset = "0x32FB444", VA = "0x32FB444")]
		set
		{
		}
	}

	[Token(Token = "0x17001CF8")]
	public bool EnableBackgroundDownload
	{
		[Token(Token = "0x601A6CB")]
		[Address(RVA = "0x32FB44C", Offset = "0x32FB44C", VA = "0x32FB44C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A6CC")]
		[Address(RVA = "0x32FB454", Offset = "0x32FB454", VA = "0x32FB454")]
		set
		{
		}
	}

	[Token(Token = "0x17001CF9")]
	public bool EnableBackgroundDownloadInLobby
	{
		[Token(Token = "0x601A6CD")]
		[Address(RVA = "0x32FB45C", Offset = "0x32FB45C", VA = "0x32FB45C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A6CE")]
		[Address(RVA = "0x32FB464", Offset = "0x32FB464", VA = "0x32FB464")]
		set
		{
		}
	}

	[Token(Token = "0x17001CFA")]
	public string PlatformIdentifierForOptionals
	{
		[Token(Token = "0x601A6CF")]
		[Address(RVA = "0x32F5C04", Offset = "0x32F5C04", VA = "0x32F5C04")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A6C6")]
	[Address(RVA = "0x32FB368", Offset = "0x32FB368", VA = "0x32FB368")]
	public ResUpdateDownloadEngine()
	{
	}

	[Token(Token = "0x601A6D0")]
	[Address(RVA = "0x32FB46C", Offset = "0x32FB46C", VA = "0x32FB46C")]
	public void Init(ResHotUpdaterContext updater_context, int multi_download_gc_index, bool need_init_file_length)
	{
	}

	[Token(Token = "0x601A6D1")]
	[Address(RVA = "0x32FB574", Offset = "0x32FB574", VA = "0x32FB574")]
	public void SetVersionMap(Dictionary<uint, string> version_map)
	{
	}

	[Token(Token = "0x601A6D2")]
	[Address(RVA = "0x32FB57C", Offset = "0x32FB57C", VA = "0x32FB57C")]
	public void SetLoginDownloadPackMap(Dictionary<uint, string[]> login_download_map)
	{
	}

	[Token(Token = "0x601A6D3")]
	[Address(RVA = "0x32FB584", Offset = "0x32FB584", VA = "0x32FB584")]
	public void SetSpeedScale(float speed_scale)
	{
	}

	[Token(Token = "0x601A6D4")]
	[Address(RVA = "0x32F2F8C", Offset = "0x32F2F8C", VA = "0x32F2F8C")]
	public bool AddToPendingDownload(ResUpdateDownloadContext context, bool isAddFirst = false)
	{
		return default(bool);
	}

	[Token(Token = "0x601A6D5")]
	[Address(RVA = "0x32F2F4C", Offset = "0x32F2F4C", VA = "0x32F2F4C")]
	public void PauseDownloadByType(ResDownloadType type, bool isPause, bool need_auto_resume = false)
	{
	}

	[Token(Token = "0x601A6D6")]
	[Address(RVA = "0x32FB874", Offset = "0x32FB874", VA = "0x32FB874")]
	public void PauseDownloadByType(ResUpdateDownloadContext context, bool isPause, bool need_auto_resume = false, bool manualPause = false)
	{
	}

	[Token(Token = "0x601A6D7")]
	[Address(RVA = "0x32ED954", Offset = "0x32ED954", VA = "0x32ED954")]
	public ResUpdateDownloadContext GetRunningDownloadContext()
	{
		return null;
	}

	[Token(Token = "0x601A6D8")]
	[Address(RVA = "0x32FB670", Offset = "0x32FB670", VA = "0x32FB670")]
	public ResUpdateDownloadContext GetDownloadContextByType(ResDownloadType type)
	{
		return null;
	}

	[Token(Token = "0x601A6D9")]
	[Address(RVA = "0x32FB9A4", Offset = "0x32FB9A4", VA = "0x32FB9A4")]
	public ResUpdateDownloadContext GetDownloadContextByFileName(string fileName)
	{
		return null;
	}

	[Token(Token = "0x601A6DA")]
	[Address(RVA = "0x32FBA9C", Offset = "0x32FBA9C", VA = "0x32FBA9C")]
	public void StartGetLocalVersionInfo(List<uint> type_list, Action finished_callback)
	{
	}

	[Token(Token = "0x601A6DB")]
	[Address(RVA = "0x32FBD70", Offset = "0x32FBD70", VA = "0x32FBD70")]
	public void StartGetLocalVersionInfo(ResDownloadType type, Action finished_callback)
	{
	}

	[Token(Token = "0x601A6DC")]
	[Address(RVA = "0x32FBE98", Offset = "0x32FBE98", VA = "0x32FBE98")]
	public void UpdateImiatelyContext(DownloadContext context, List<ResVersionInfo.FileInfo> infolist)
	{
	}

	[Token(Token = "0x601A6DD")]
	[Address(RVA = "0x32FBE9C", Offset = "0x32FBE9C", VA = "0x32FBE9C")]
	public void Update(float time)
	{
	}

	[Token(Token = "0x601A6DE")]
	[Address(RVA = "0x32F7164", Offset = "0x32F7164", VA = "0x32F7164")]
	public void RegistFileNameToEngine(string full_name, ResDownloadType type)
	{
	}

	[Token(Token = "0x601A6DF")]
	[Address(RVA = "0x32FB9C4", Offset = "0x32FB9C4", VA = "0x32FB9C4")]
	public ResDownloadType GetDownloadTypeByFileName(string full_name)
	{
		return default(ResDownloadType);
	}

	[Token(Token = "0x601A6E0")]
	[Address(RVA = "0x32FC00C", Offset = "0x32FC00C", VA = "0x32FC00C")]
	public string GetLocalPathByPlatfrom(string full_name)
	{
		return null;
	}

	[Token(Token = "0x601A6E1")]
	[Address(RVA = "0x32FC0D4", Offset = "0x32FC0D4", VA = "0x32FC0D4")]
	public ResVersionInfo.FileInfo GetLocalFileInfo(string full_name)
	{
		return null;
	}

	[Token(Token = "0x601A6E2")]
	[Address(RVA = "0x32FC148", Offset = "0x32FC148", VA = "0x32FC148")]
	public void DeleteFilesByDownloadType(ResDownloadType type)
	{
	}

	[Token(Token = "0x601A6E3")]
	[Address(RVA = "0x32FC238", Offset = "0x32FC238", VA = "0x32FC238")]
	public void RemoveFromPending(ResUpdateDownloadContext context)
	{
	}

	[Token(Token = "0x601A6E4")]
	[Address(RVA = "0x32FC2F8", Offset = "0x32FC2F8", VA = "0x32FC2F8")]
	private void OnContextBackgroundFinished(ResDownloadType type, ResErrorCode errorCode)
	{
	}

	[Token(Token = "0x601A6E5")]
	[Address(RVA = "0x32FC430", Offset = "0x32FC430", VA = "0x32FC430")]
	public void OnApplicationPaused(bool is_paused)
	{
	}

	[Token(Token = "0x601A6E6")]
	[Address(RVA = "0x32EEC88", Offset = "0x32EEC88", VA = "0x32EEC88")]
	public bool RegisterLoader(ResVersionInfo.FileInfo fileInfo, ResFileLoader loader)
	{
		return default(bool);
	}

	[Token(Token = "0x601A6E7")]
	[Address(RVA = "0x32EEBE8", Offset = "0x32EEBE8", VA = "0x32EEBE8")]
	public ResFileLoader GetLoaderByFileInfo(ResVersionInfo.FileInfo info)
	{
		return null;
	}

	[Token(Token = "0x601A6E8")]
	[Address(RVA = "0x32F2118", Offset = "0x32F2118", VA = "0x32F2118")]
	public void UnRegisterLoader(ResVersionInfo.FileInfo fileInfo)
	{
	}

	[Token(Token = "0x601A6E9")]
	[Address(RVA = "0x32FC6F0", Offset = "0x32FC6F0", VA = "0x32FC6F0")]
	public long FileDownloadedAndZipSize(ResVersionInfo.FileInfo fileInfo)
	{
		return default(long);
	}

	[Token(Token = "0x601A6EA")]
	[Address(RVA = "0x32FC7BC", Offset = "0x32FC7BC", VA = "0x32FC7BC")]
	public long FileNeedDownloadAndZipSize(ResVersionInfo.FileInfo fileInfo)
	{
		return default(long);
	}

	[Token(Token = "0x601A6EB")]
	[Address(RVA = "0x32FC7F4", Offset = "0x32FC7F4", VA = "0x32FC7F4")]
	public long FileNeedDownloadSize(ResVersionInfo.FileInfo fileInfo)
	{
		return default(long);
	}

	[Token(Token = "0x601A6EC")]
	[Address(RVA = "0x32F9750", Offset = "0x32F9750", VA = "0x32F9750")]
	public float DownloadedSizeInfo(List<ResVersionInfo.FileInfo> fileInfos, out float estimateRemainDownloadSize, out long totalNeedDownloadSize)
	{
		return default(float);
	}
}
