using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TsiU;
using UnityEngine;
using UnityEngine.Networking;

namespace GCommon;

[Token(Token = "0x20040CA")]
public class ResHotUpdater : TSingleton<ResHotUpdater>
{
	[Token(Token = "0x20040CB")]
	private sealed class _003CDownloadDesignatedFile_003Ec__AnonStorey0
	{
		[Token(Token = "0x401B3A3")]
		[FieldOffset(Offset = "0x8")]
		internal DownloadContext context;

		[Token(Token = "0x401B3A4")]
		[FieldOffset(Offset = "0xC")]
		internal ResHotUpdater _0024this;

		[Token(Token = "0x601A638")]
		[Address(RVA = "0x32E7814", Offset = "0x32E7814", VA = "0x32E7814")]
		public _003CDownloadDesignatedFile_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601A639")]
		[Address(RVA = "0x32E781C", Offset = "0x32E781C", VA = "0x32E781C")]
		internal void _003C_003Em__0(UnityWebRequest www, ResWithTempFileLoader loader)
		{
		}
	}

	[Token(Token = "0x20040CC")]
	private sealed class _003CCheckNeedDownloadByType_003Ec__AnonStorey1
	{
		[Token(Token = "0x401B3A5")]
		[FieldOffset(Offset = "0x8")]
		internal DownloadContext context;

		[Token(Token = "0x401B3A6")]
		[FieldOffset(Offset = "0xC")]
		internal ResHotUpdater _0024this;

		[Token(Token = "0x601A63A")]
		[Address(RVA = "0x32E6E4C", Offset = "0x32E6E4C", VA = "0x32E6E4C")]
		public _003CCheckNeedDownloadByType_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x601A63B")]
		[Address(RVA = "0x32E6E54", Offset = "0x32E6E54", VA = "0x32E6E54")]
		internal void _003C_003Em__0(UnityWebRequest www, ResWithTempFileLoader loader)
		{
		}
	}

	[Token(Token = "0x20040CD")]
	private sealed class _003CNotifyFileDownloaded_003Ec__AnonStorey2
	{
		[Token(Token = "0x401B3A7")]
		[FieldOffset(Offset = "0x8")]
		internal DownloadContext context;

		[Token(Token = "0x401B3A8")]
		[FieldOffset(Offset = "0xC")]
		internal ResHotUpdater _0024this;

		[Token(Token = "0x601A63C")]
		[Address(RVA = "0x32E8194", Offset = "0x32E8194", VA = "0x32E8194")]
		public _003CNotifyFileDownloaded_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x601A63D")]
		[Address(RVA = "0x32E819C", Offset = "0x32E819C", VA = "0x32E819C")]
		internal void _003C_003Em__0(string hashCode, ResUnzipFileLoader unzip_loader)
		{
		}
	}

	[Token(Token = "0x20040CE")]
	private sealed class _003CCheckCopyAndUnzipDesignatedFile_003Ec__AnonStorey3
	{
		[Token(Token = "0x401B3A9")]
		[FieldOffset(Offset = "0x8")]
		internal DownloadContext context;

		[Token(Token = "0x401B3AA")]
		[FieldOffset(Offset = "0xC")]
		internal ResVersionInfo.FileInfo fi;

		[Token(Token = "0x401B3AB")]
		[FieldOffset(Offset = "0x10")]
		internal Action<string, ResUnzipFileLoader> onUnzipped;

		[Token(Token = "0x401B3AC")]
		[FieldOffset(Offset = "0x14")]
		internal ResHotUpdater _0024this;

		[Token(Token = "0x601A63E")]
		[Address(RVA = "0x32E4FC0", Offset = "0x32E4FC0", VA = "0x32E4FC0")]
		public _003CCheckCopyAndUnzipDesignatedFile_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x601A63F")]
		[Address(RVA = "0x32E4FC8", Offset = "0x32E4FC8", VA = "0x32E4FC8")]
		internal void _003C_003Em__0(string hashCode, ResUnzipFileLoader unzip_loader)
		{
		}

		[Token(Token = "0x601A640")]
		[Address(RVA = "0x32E5018", Offset = "0x32E5018", VA = "0x32E5018")]
		internal void _003C_003Em__1(WWW www, ResWWWFileLoader loader)
		{
		}
	}

	[Token(Token = "0x20040CF")]
	private sealed class _003CCheckHashFile_003Ec__AnonStorey4
	{
		[Token(Token = "0x401B3AD")]
		[FieldOffset(Offset = "0x8")]
		internal DownloadContext context;

		[Token(Token = "0x401B3AE")]
		[FieldOffset(Offset = "0xC")]
		internal Action<ResErrorCode, ResDownloadType> finished_callback;

		[Token(Token = "0x401B3AF")]
		[FieldOffset(Offset = "0x10")]
		internal ResHotUpdater _0024this;

		[Token(Token = "0x601A641")]
		[Address(RVA = "0x32E6D58", Offset = "0x32E6D58", VA = "0x32E6D58")]
		public _003CCheckHashFile_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x601A642")]
		[Address(RVA = "0x32E6D60", Offset = "0x32E6D60", VA = "0x32E6D60")]
		internal void _003C_003Em__0(string hashCode, ResHashFileLoader hash_loader)
		{
		}

		[Token(Token = "0x601A643")]
		[Address(RVA = "0x32E6DB0", Offset = "0x32E6DB0", VA = "0x32E6DB0")]
		internal void _003C_003Em__1(ResErrorCode error_code, ResDownloadType download_type)
		{
		}
	}

	[Token(Token = "0x20040D0")]
	private sealed class _003CCheckCopyAndUnzipFile_003Ec__AnonStorey5
	{
		[Token(Token = "0x401B3B0")]
		[FieldOffset(Offset = "0x8")]
		internal DownloadContext context;

		[Token(Token = "0x401B3B1")]
		[FieldOffset(Offset = "0xC")]
		internal Action<string, ResUnzipFileLoader> onUnzipped;

		[Token(Token = "0x401B3B2")]
		[FieldOffset(Offset = "0x10")]
		internal ResHotUpdater _0024this;

		[Token(Token = "0x601A644")]
		[Address(RVA = "0x32E5574", Offset = "0x32E5574", VA = "0x32E5574")]
		public _003CCheckCopyAndUnzipFile_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x601A645")]
		[Address(RVA = "0x32E557C", Offset = "0x32E557C", VA = "0x32E557C")]
		internal void _003C_003Em__0(string hashCode, ResUnzipFileLoader unzip_loader)
		{
		}

		[Token(Token = "0x601A646")]
		[Address(RVA = "0x32E55CC", Offset = "0x32E55CC", VA = "0x32E55CC")]
		internal void _003C_003Em__1(string hashCode, ResHashFileLoader hash_loader)
		{
		}
	}

	[Token(Token = "0x20040D1")]
	private sealed class _003CCheckCopyAndUnzipFile_003Ec__AnonStorey6
	{
		[Token(Token = "0x401B3B3")]
		[FieldOffset(Offset = "0x8")]
		internal ResVersionInfo.FileInfo fi;

		[Token(Token = "0x401B3B4")]
		[FieldOffset(Offset = "0xC")]
		internal _003CCheckCopyAndUnzipFile_003Ec__AnonStorey5 _003C_003Ef__ref_00245;

		[Token(Token = "0x601A647")]
		[Address(RVA = "0x32E561C", Offset = "0x32E561C", VA = "0x32E561C")]
		public _003CCheckCopyAndUnzipFile_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x601A648")]
		[Address(RVA = "0x32E5624", Offset = "0x32E5624", VA = "0x32E5624")]
		internal void _003C_003Em__0(WWW www, ResWWWFileLoader loader)
		{
		}
	}

	[Token(Token = "0x401B391")]
	[FieldOffset(Offset = "0x0")]
	public static bool VersionToolsCompressCompulsoryAb;

	[Token(Token = "0x401B392")]
	[FieldOffset(Offset = "0x1")]
	public static bool SaveUnCompressedCompulsoryAbToPersistDir;

	[Token(Token = "0x401B393")]
	[FieldOffset(Offset = "0x2")]
	public static bool LoadLocalCompulsoryAbFromStreamDir;

	[Token(Token = "0x401B394")]
	[FieldOffset(Offset = "0x8")]
	private ResHotUpdaterContext m_Context;

	[Token(Token = "0x401B395")]
	[FieldOffset(Offset = "0xC")]
	private ResVersionInfo m_LocalVersionInfo;

	[Token(Token = "0x401B396")]
	[FieldOffset(Offset = "0x10")]
	private ResVersionInfo m_RemoteVersionInfo;

	[Token(Token = "0x401B397")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<uint, DownloadContext> m_DownloadContextMap;

	[Token(Token = "0x401B398")]
	[FieldOffset(Offset = "0x18")]
	private LinkedList<DownloadContext> m_PendingDownloadContext;

	[Token(Token = "0x401B399")]
	[FieldOffset(Offset = "0x1C")]
	private ResErrorCode m_LastError;

	[Token(Token = "0x401B39A")]
	[FieldOffset(Offset = "0x20")]
	private string _003CFakeVersion_003Ek__BackingField;

	[Token(Token = "0x401B39B")]
	[FieldOffset(Offset = "0x24")]
	public string VersionCode;

	[Token(Token = "0x401B39C")]
	[FieldOffset(Offset = "0x28")]
	private string _003COriginalVersion_003Ek__BackingField;

	[Token(Token = "0x401B39D")]
	[FieldOffset(Offset = "0x2C")]
	public int FileCount;

	[Token(Token = "0x401B39E")]
	[FieldOffset(Offset = "0x30")]
	public List<string> FileException;

	[Token(Token = "0x401B39F")]
	[FieldOffset(Offset = "0x34")]
	public string FileSimple;

	[Token(Token = "0x401B3A0")]
	[FieldOffset(Offset = "0x38")]
	public string FileHash;

	[Token(Token = "0x401B3A1")]
	[FieldOffset(Offset = "0x3C")]
	private HashSet<string> m_FileHashCodeSet;

	[Token(Token = "0x401B3A2")]
	[FieldOffset(Offset = "0x40")]
	private float NextCheckTime;

	[Token(Token = "0x17001CDB")]
	public ResHotUpdaterContext Context
	{
		[Token(Token = "0x601A5EC")]
		[Address(RVA = "0x333BE88", Offset = "0x333BE88", VA = "0x333BE88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CDC")]
	public ResErrorCode LastError
	{
		[Token(Token = "0x601A5ED")]
		[Address(RVA = "0x333BE90", Offset = "0x333BE90", VA = "0x333BE90")]
		get
		{
			return default(ResErrorCode);
		}
	}

	[Token(Token = "0x17001CDD")]
	public string FakeVersion
	{
		[Token(Token = "0x601A5EF")]
		[Address(RVA = "0x333BFB8", Offset = "0x333BFB8", VA = "0x333BFB8")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A5F0")]
		[Address(RVA = "0x333BFC0", Offset = "0x333BFC0", VA = "0x333BFC0")]
		set
		{
		}
	}

	[Token(Token = "0x17001CDE")]
	public string Version
	{
		[Token(Token = "0x601A5F1")]
		[Address(RVA = "0x333BFC8", Offset = "0x333BFC8", VA = "0x333BFC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CDF")]
	public uint MajorVersion
	{
		[Token(Token = "0x601A5F2")]
		[Address(RVA = "0x333C084", Offset = "0x333C084", VA = "0x333C084")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001CE0")]
	public string OptionalVersion
	{
		[Token(Token = "0x601A5F3")]
		[Address(RVA = "0x333C098", Offset = "0x333C098", VA = "0x333C098")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CE1")]
	public string PlatformIdentifier
	{
		[Token(Token = "0x601A5F4")]
		[Address(RVA = "0x333C10C", Offset = "0x333C10C", VA = "0x333C10C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CE2")]
	public string RemotePlatform
	{
		[Token(Token = "0x601A5F5")]
		[Address(RVA = "0x333C168", Offset = "0x333C168", VA = "0x333C168")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CE3")]
	public string ReleaseChannel
	{
		[Token(Token = "0x601A5F6")]
		[Address(RVA = "0x333C1C4", Offset = "0x333C1C4", VA = "0x333C1C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CE4")]
	public string AssetBundleManifestPath
	{
		[Token(Token = "0x601A5F7")]
		[Address(RVA = "0x333C220", Offset = "0x333C220", VA = "0x333C220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CE5")]
	public string OriginalVersion
	{
		[Token(Token = "0x601A5F8")]
		[Address(RVA = "0x333C244", Offset = "0x333C244", VA = "0x333C244")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A5F9")]
		[Address(RVA = "0x333C24C", Offset = "0x333C24C", VA = "0x333C24C")]
		private set
		{
		}
	}

	[Token(Token = "0x17001CE6")]
	public HashSet<string> FileHashCodeSet
	{
		[Token(Token = "0x601A5FA")]
		[Address(RVA = "0x333C254", Offset = "0x333C254", VA = "0x333C254")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A5EB")]
	[Address(RVA = "0x333BD88", Offset = "0x333BD88", VA = "0x333BD88")]
	public ResHotUpdater()
	{
	}

	[Token(Token = "0x601A5EE")]
	[Address(RVA = "0x333BE98", Offset = "0x333BE98", VA = "0x333BE98")]
	public void SetLastError(DownloadContext context, ResErrorCode error)
	{
	}

	[Token(Token = "0x601A5FB")]
	[Address(RVA = "0x333C2E4", Offset = "0x333C2E4", VA = "0x333C2E4")]
	public void Init(ResHotUpdaterContext context)
	{
	}

	[Token(Token = "0x601A5FC")]
	[Address(RVA = "0x333C6F8", Offset = "0x333C6F8", VA = "0x333C6F8")]
	public DownloadContext GetDownloadContextByType(ResDownloadType type)
	{
		return null;
	}

	[Token(Token = "0x601A5FD")]
	[Address(RVA = "0x333C828", Offset = "0x333C828", VA = "0x333C828")]
	public bool AddToPendingDownload(DownloadContext context, bool isAddFirst = false)
	{
		return default(bool);
	}

	[Token(Token = "0x601A5FE")]
	[Address(RVA = "0x333C90C", Offset = "0x333C90C", VA = "0x333C90C")]
	public void PauseDownloadByType(ResDownloadType type, bool isPause)
	{
	}

	[Token(Token = "0x601A5FF")]
	[Address(RVA = "0x333C940", Offset = "0x333C940", VA = "0x333C940")]
	public void PauseRunningDownloadWithAllType(bool isPause)
	{
	}

	[Token(Token = "0x601A600")]
	[Address(RVA = "0x333CA34", Offset = "0x333CA34", VA = "0x333CA34")]
	public void CleanTempCache(ResDownloadType type)
	{
	}

	[Token(Token = "0x601A601")]
	[Address(RVA = "0x333CCA8", Offset = "0x333CCA8", VA = "0x333CCA8")]
	public void CleanCache()
	{
	}

	[Token(Token = "0x601A602")]
	[Address(RVA = "0x333CED8", Offset = "0x333CED8", VA = "0x333CED8")]
	public void StartGetLocalVersion()
	{
	}

	[Token(Token = "0x601A603")]
	[Address(RVA = "0x333CFDC", Offset = "0x333CFDC", VA = "0x333CFDC")]
	public void StartGetLocalFileInfo()
	{
	}

	[Token(Token = "0x601A604")]
	[Address(RVA = "0x333D0BC", Offset = "0x333D0BC", VA = "0x333D0BC")]
	public void StartVersionCheck(string remoteAddr, [Optional] string remoteVersion)
	{
	}

	[Token(Token = "0x601A605")]
	[Address(RVA = "0x333D7E4", Offset = "0x333D7E4", VA = "0x333D7E4")]
	public ResErrorCode GetDetailedDownloadError(string error)
	{
		return default(ResErrorCode);
	}

	[Token(Token = "0x601A606")]
	[Address(RVA = "0x333D864", Offset = "0x333D864", VA = "0x333D864")]
	public void StartHotUpdateDownload(Action<ResErrorCode> onHotUpdateFinished)
	{
	}

	[Token(Token = "0x601A607")]
	[Address(RVA = "0x333DBB0", Offset = "0x333DBB0", VA = "0x333DBB0")]
	public void Update(float time)
	{
	}

	[Token(Token = "0x601A608")]
	[Address(RVA = "0x333DD18", Offset = "0x333DD18", VA = "0x333DD18")]
	public void ClearContextActionReference()
	{
	}

	[Token(Token = "0x601A609")]
	[Address(RVA = "0x333DD2C", Offset = "0x333DD2C", VA = "0x333DD2C")]
	public void Clear()
	{
	}

	[Token(Token = "0x601A60A")]
	[Address(RVA = "0x333DEE8", Offset = "0x333DEE8", VA = "0x333DEE8")]
	public void ClearPendingDownloadContext()
	{
	}

	[Token(Token = "0x601A60B")]
	[Address(RVA = "0x333E0A0", Offset = "0x333E0A0", VA = "0x333E0A0")]
	public void WWWLoad(DownloadContext context, string path, Action<WWW, ResWWWFileLoader> onLoaded, bool isFromRemote, long totalSize = 0L, bool includeVersionDir = true, [Optional] ResVersionInfo.FileInfo file_info)
	{
	}

	[Token(Token = "0x601A60C")]
	[Address(RVA = "0x333E5F4", Offset = "0x333E5F4", VA = "0x333E5F4")]
	public void Download(DownloadContext context, ResVersionInfo.FileInfo file_info, string path, Action<UnityWebRequest, ResWithTempFileLoader> onLoaded, bool isFromRemote)
	{
	}

	[Token(Token = "0x601A60D")]
	[Address(RVA = "0x333EE04", Offset = "0x333EE04", VA = "0x333EE04")]
	public void BigFileDownload(DownloadContext context, ResVersionInfo.FileInfo file_info, string path, Action<UnityWebRequest, ResWithTempFileLoader> onLoaded)
	{
	}

	[Token(Token = "0x601A60E")]
	[Address(RVA = "0x333F508", Offset = "0x333F508", VA = "0x333F508")]
	public void Unzip(DownloadContext context, ResVersionInfo.FileInfo file_info, Action<string, ResUnzipFileLoader> onLoaded, bool addProgressSize = false, bool addFirst = false)
	{
	}

	[Token(Token = "0x601A60F")]
	[Address(RVA = "0x33400EC", Offset = "0x33400EC", VA = "0x33400EC")]
	public void HashFile(DownloadContext context, ResVersionInfo.FileInfo file_info, Action<string, ResHashFileLoader> onLoaded, bool addProgressSize = false, bool addFirst = false)
	{
	}

	[Token(Token = "0x601A610")]
	[Address(RVA = "0x334030C", Offset = "0x334030C", VA = "0x334030C")]
	public AssetBundle LoadAssetBundle(string path, bool logError = true)
	{
		return null;
	}

	[Token(Token = "0x601A611")]
	[Address(RVA = "0x3340800", Offset = "0x3340800", VA = "0x3340800")]
	public string GetHotUpdateMovieUrl(ResourceID id)
	{
		return null;
	}

	[Token(Token = "0x601A612")]
	[Address(RVA = "0x3340AE8", Offset = "0x3340AE8", VA = "0x3340AE8")]
	public long GetTotalSizeInByte(ResDownloadType type = ResDownloadType.CompulsoryRes)
	{
		return default(long);
	}

	[Token(Token = "0x601A613")]
	[Address(RVA = "0x3340B1C", Offset = "0x3340B1C", VA = "0x3340B1C")]
	public long GetTotalLoadedSizeInByte(ResDownloadType type = ResDownloadType.CompulsoryRes)
	{
		return default(long);
	}

	[Token(Token = "0x601A614")]
	[Address(RVA = "0x3340B50", Offset = "0x3340B50", VA = "0x3340B50")]
	public long GetTotalDownloadSizeInByte(ResDownloadType type = ResDownloadType.CompulsoryRes)
	{
		return default(long);
	}

	[Token(Token = "0x601A615")]
	[Address(RVA = "0x3340B70", Offset = "0x3340B70", VA = "0x3340B70")]
	public ResVersionInfo.FileInfo GetLocalFileInfo(string path)
	{
		return null;
	}

	[Token(Token = "0x601A616")]
	[Address(RVA = "0x3340BE0", Offset = "0x3340BE0", VA = "0x3340BE0")]
	public ResVersionInfo.FileInfo GetRemoteFileInfo(string path)
	{
		return null;
	}

	[Token(Token = "0x601A617")]
	[Address(RVA = "0x3340C2C", Offset = "0x3340C2C", VA = "0x3340C2C")]
	public bool ABFileExist(string ab_path)
	{
		return default(bool);
	}

	[Token(Token = "0x601A618")]
	[Address(RVA = "0x3340D18", Offset = "0x3340D18", VA = "0x3340D18")]
	public bool ABFileExist(ResVersionInfo.FileInfo fileInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x601A619")]
	[Address(RVA = "0x3340584", Offset = "0x3340584", VA = "0x3340584")]
	private string GetLocalPathByPlatfrom(string path)
	{
		return null;
	}

	[Token(Token = "0x601A61A")]
	[Address(RVA = "0x333F7A8", Offset = "0x333F7A8", VA = "0x333F7A8")]
	public string GetLocalPathByPlatfromByFileInfo(ResVersionInfo.FileInfo fileInfo, ResVersionInfo.FileInfo.OpState targetState)
	{
		return null;
	}

	[Token(Token = "0x601A61B")]
	[Address(RVA = "0x3340DA0", Offset = "0x3340DA0", VA = "0x3340DA0")]
	private void ClearTempFile(string tempPath, [Optional] string flagPath)
	{
	}

	[Token(Token = "0x601A61C")]
	[Address(RVA = "0x3340FF4", Offset = "0x3340FF4", VA = "0x3340FF4")]
	private bool MoveTempFile(string relativePath, ResFileType type, string tempPath)
	{
		return default(bool);
	}

	[Token(Token = "0x601A61D")]
	[Address(RVA = "0x33413F8", Offset = "0x33413F8", VA = "0x33413F8")]
	private bool SaveFile(string path, ResFileType type, byte[] content)
	{
		return default(bool);
	}

	[Token(Token = "0x601A61E")]
	[Address(RVA = "0x334188C", Offset = "0x334188C", VA = "0x334188C")]
	private void onLocalVersionInfoLoaded(bool result)
	{
	}

	[Token(Token = "0x601A61F")]
	[Address(RVA = "0x333D424", Offset = "0x333D424", VA = "0x333D424")]
	private void onRemoveVersionInfoLoaded(bool result)
	{
	}

	[Token(Token = "0x601A620")]
	[Address(RVA = "0x33419D4", Offset = "0x33419D4", VA = "0x33419D4")]
	private void onLocalFileInfoLoaded_Pass(bool result)
	{
	}

	[Token(Token = "0x601A621")]
	[Address(RVA = "0x3341B1C", Offset = "0x3341B1C", VA = "0x3341B1C")]
	private void onLocalFileInfoLoaded_Hotupdate(bool result)
	{
	}

	[Token(Token = "0x601A622")]
	[Address(RVA = "0x3341CF4", Offset = "0x3341CF4", VA = "0x3341CF4")]
	private void onRemoteFileInfoLoaded(bool result)
	{
	}

	[Token(Token = "0x601A623")]
	[Address(RVA = "0x3342D98", Offset = "0x3342D98", VA = "0x3342D98")]
	public static bool IsOptionalMap(ResDownloadType type)
	{
		return default(bool);
	}

	[Token(Token = "0x601A624")]
	[Address(RVA = "0x3342DA0", Offset = "0x3342DA0", VA = "0x3342DA0")]
	public static bool IsOptionalPet(ResDownloadType type)
	{
		return default(bool);
	}

	[Token(Token = "0x601A625")]
	[Address(RVA = "0x3342DA8", Offset = "0x3342DA8", VA = "0x3342DA8")]
	public static int[] GetResFileTypeList(ResDownloadType type)
	{
		return null;
	}

	[Token(Token = "0x601A626")]
	[Address(RVA = "0x3342E7C", Offset = "0x3342E7C", VA = "0x3342E7C")]
	public bool CheckHasNeedDownloadFileByType(ResDownloadType type)
	{
		return default(bool);
	}

	[Token(Token = "0x601A627")]
	[Address(RVA = "0x33435CC", Offset = "0x33435CC", VA = "0x33435CC")]
	public bool DownloadDesignatedFile(ResDownloadType type, string ab_path, bool useMultiThreadDownload = false)
	{
		return default(bool);
	}

	[Token(Token = "0x601A628")]
	[Address(RVA = "0x3341FF4", Offset = "0x3341FF4", VA = "0x3341FF4")]
	public bool CheckNeedDownloadByType(ResDownloadType type, bool useMultiThreadDownload = false)
	{
		return default(bool);
	}

	[Token(Token = "0x601A629")]
	[Address(RVA = "0x3344098", Offset = "0x3344098", VA = "0x3344098")]
	private string ConvertSimpleName(string full_name)
	{
		return null;
	}

	[Token(Token = "0x601A62A")]
	[Address(RVA = "0x3344240", Offset = "0x3344240", VA = "0x3344240")]
	private void NotifyFileHashed(DownloadContext context, string hash_code, ResHashFileLoader hashFileLoader)
	{
	}

	[Token(Token = "0x601A62B")]
	[Address(RVA = "0x33444A4", Offset = "0x33444A4", VA = "0x33444A4")]
	public void FinalHash()
	{
	}

	[Token(Token = "0x601A62C")]
	[Address(RVA = "0x3344738", Offset = "0x3344738", VA = "0x3344738")]
	private void NotifyFileUnZiped(DownloadContext context, string hash_code, ResUnzipFileLoader unzip_loader)
	{
	}

	[Token(Token = "0x601A62D")]
	[Address(RVA = "0x3345030", Offset = "0x3345030", VA = "0x3345030")]
	private void NotifyFileDownloaded(ResErrorCode result, DownloadContext context, ResFileLoader loader)
	{
	}

	[Token(Token = "0x601A62E")]
	[Address(RVA = "0x3345204", Offset = "0x3345204", VA = "0x3345204")]
	public ResErrorCode SaveVersionInfo(ResDownloadType type)
	{
		return default(ResErrorCode);
	}

	[Token(Token = "0x601A62F")]
	[Address(RVA = "0x333DAD4", Offset = "0x333DAD4", VA = "0x333DAD4")]
	public void StartDownloadContextByType(uint[] type_list, Action<ResErrorCode, ResDownloadType> onDownloadFinished)
	{
	}

	[Token(Token = "0x601A630")]
	[Address(RVA = "0x334537C", Offset = "0x334537C", VA = "0x334537C")]
	public void StartDownloadContextByType(ResDownloadType type, Action<ResErrorCode, ResDownloadType> onDownloadFinished)
	{
	}

	[Token(Token = "0x601A631")]
	[Address(RVA = "0x3343B14", Offset = "0x3343B14", VA = "0x3343B14")]
	public bool CheckCopyAndUnzipDesignatedFile(string ab_path, ResDownloadType type = ResDownloadType.CompulsoryRes)
	{
		return default(bool);
	}

	[Token(Token = "0x601A632")]
	[Address(RVA = "0x33454A4", Offset = "0x33454A4", VA = "0x33454A4")]
	public void CheckHashFile(float cool_down_time = 0f, ResDownloadType type = ResDownloadType.CompulsoryRes, [Optional] Action<ResErrorCode, ResDownloadType> finished_callback)
	{
	}

	[Token(Token = "0x601A633")]
	[Address(RVA = "0x3345D78", Offset = "0x3345D78", VA = "0x3345D78")]
	public bool CheckCopyAndUnzipFile(ResDownloadType type = ResDownloadType.CompulsoryRes)
	{
		return default(bool);
	}

	[Token(Token = "0x601A634")]
	[Address(RVA = "0x3346830", Offset = "0x3346830", VA = "0x3346830")]
	public long GetLocalStoredFileSizeWithType(ResFileType type)
	{
		return default(long);
	}

	[Token(Token = "0x601A635")]
	[Address(RVA = "0x334684C", Offset = "0x334684C", VA = "0x334684C")]
	public long GetNeedDownloadFileSize(ResDownloadType type)
	{
		return default(long);
	}

	[Token(Token = "0x601A637")]
	[Address(RVA = "0x3347098", Offset = "0x3347098", VA = "0x3347098")]
	private void _003CStartHotUpdateDownload_003Em__0(ResErrorCode result, ResDownloadType type)
	{
	}
}
