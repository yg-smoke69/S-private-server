using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x20040AD")]
public class DownloadVersionInfo
{
	[Token(Token = "0x20040AE")]
	private sealed class _003CLoadVersionInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x401B2CC")]
		[FieldOffset(Offset = "0x8")]
		internal ResUpdateDownloadContext update_context;

		[Token(Token = "0x401B2CD")]
		[FieldOffset(Offset = "0xC")]
		internal Action<bool> onVersionInfoLoaded;

		[Token(Token = "0x401B2CE")]
		[FieldOffset(Offset = "0x10")]
		internal DownloadVersionInfo _0024this;

		[Token(Token = "0x601A52C")]
		[Address(RVA = "0x329CE0C", Offset = "0x329CE0C", VA = "0x329CE0C")]
		public _003CLoadVersionInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601A52D")]
		[Address(RVA = "0x329CE14", Offset = "0x329CE14", VA = "0x329CE14")]
		internal void _003C_003Em__0(WWW www, ResWWWFileLoader loader)
		{
		}

		[Token(Token = "0x601A52E")]
		[Address(RVA = "0x329D28C", Offset = "0x329D28C", VA = "0x329D28C")]
		internal void _003C_003Em__1(ResErrorCode error, ResDownloadType type)
		{
		}
	}

	[Token(Token = "0x20040AF")]
	private sealed class _003CLoadFileInfo_003Ec__AnonStorey1
	{
		[Token(Token = "0x401B2CF")]
		[FieldOffset(Offset = "0x8")]
		internal ResUpdateDownloadContext downloadContext;

		[Token(Token = "0x401B2D0")]
		[FieldOffset(Offset = "0xC")]
		internal Action<bool> onFileInfoLoaded;

		[Token(Token = "0x401B2D1")]
		[FieldOffset(Offset = "0x10")]
		internal DownloadVersionInfo _0024this;

		[Token(Token = "0x601A52F")]
		[Address(RVA = "0x329C8A8", Offset = "0x329C8A8", VA = "0x329C8A8")]
		public _003CLoadFileInfo_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x601A530")]
		[Address(RVA = "0x329C8B0", Offset = "0x329C8B0", VA = "0x329C8B0")]
		internal void _003C_003Em__0(WWW www, ResWWWFileLoader loader)
		{
		}

		[Token(Token = "0x601A531")]
		[Address(RVA = "0x329CD84", Offset = "0x329CD84", VA = "0x329CD84")]
		internal void _003C_003Em__1(ResErrorCode error, ResDownloadType type)
		{
		}
	}

	[Token(Token = "0x401B2C4")]
	[FieldOffset(Offset = "0x8")]
	protected bool m_IsRemote;

	[Token(Token = "0x401B2C5")]
	[FieldOffset(Offset = "0x9")]
	public bool m_UsedOld;

	[Token(Token = "0x401B2C6")]
	[FieldOffset(Offset = "0xC")]
	public uint Version;

	[Token(Token = "0x401B2C7")]
	[FieldOffset(Offset = "0x10")]
	public HashSet<int> FileTypeList;

	[Token(Token = "0x401B2C8")]
	[FieldOffset(Offset = "0x14")]
	protected Dictionary<string, ResVersionInfo.FileInfo> m_FileInfos;

	[Token(Token = "0x401B2C9")]
	[FieldOffset(Offset = "0x18")]
	protected List<ResVersionInfo.FileInfo> m_NeedToSaveFileInfos;

	[Token(Token = "0x401B2CA")]
	[FieldOffset(Offset = "0x1C")]
	protected HashSet<string> m_DepFiles;

	[Token(Token = "0x401B2CB")]
	[FieldOffset(Offset = "0x20")]
	protected Dictionary<uint, List<ResVersionInfo.FileInfo>> m_TagFileInfoMap;

	[Token(Token = "0x601A511")]
	[Address(RVA = "0x308EB4C", Offset = "0x308EB4C", VA = "0x308EB4C")]
	public DownloadVersionInfo(bool isRemote, ResDownloadType download_type, bool isDynamicProduce = false)
	{
	}

	[Token(Token = "0x601A512")]
	[Address(RVA = "0x308EDB4", Offset = "0x308EDB4", VA = "0x308EDB4")]
	public void LoadVersionInfo(ResUpdateDownloadContext update_context, string versionInfoPath, Action<bool> onVersionInfoLoaded)
	{
	}

	[Token(Token = "0x601A513")]
	[Address(RVA = "0x308FAEC", Offset = "0x308FAEC", VA = "0x308FAEC")]
	public void LoadFromString(ResUpdateDownloadContext downloadContext, string version_string)
	{
	}

	[Token(Token = "0x601A514")]
	[Address(RVA = "0x308FBE0", Offset = "0x308FBE0", VA = "0x308FBE0")]
	protected bool ParseVersion(string content, ref uint _version)
	{
		return default(bool);
	}

	[Token(Token = "0x601A515")]
	[Address(RVA = "0x308FD54", Offset = "0x308FD54", VA = "0x308FD54")]
	public void LoadFileInfo(ResUpdateDownloadContext downloadContext, string fileInfoPath, Action<bool> onFileInfoLoaded)
	{
	}

	[Token(Token = "0x601A516")]
	[Address(RVA = "0x308FFF4", Offset = "0x308FFF4", VA = "0x308FFF4")]
	private bool LoadLocalFileInfo(ResUpdateDownloadContext downloadContext)
	{
		return default(bool);
	}

	[Token(Token = "0x601A517")]
	[Address(RVA = "0x30904BC", Offset = "0x30904BC", VA = "0x30904BC", Slot = "4")]
	protected virtual bool ParseFile(string content, bool from_local = false)
	{
		return default(bool);
	}

	[Token(Token = "0x601A518")]
	[Address(RVA = "0x3091038", Offset = "0x3091038", VA = "0x3091038")]
	public string GetVersionString()
	{
		return null;
	}

	[Token(Token = "0x601A519")]
	[Address(RVA = "0x3091044", Offset = "0x3091044", VA = "0x3091044")]
	public static bool HaveEnoughStorage()
	{
		return default(bool);
	}

	[Token(Token = "0x601A51A")]
	[Address(RVA = "0x30910D8", Offset = "0x30910D8", VA = "0x30910D8")]
	public Dictionary<string, ResVersionInfo.FileInfo> GetFileInfoList()
	{
		return null;
	}

	[Token(Token = "0x601A51B")]
	[Address(RVA = "0x30910E0", Offset = "0x30910E0", VA = "0x30910E0")]
	public HashSet<string> GetDepFileNames()
	{
		return null;
	}

	[Token(Token = "0x601A51C")]
	[Address(RVA = "0x30910E8", Offset = "0x30910E8", VA = "0x30910E8")]
	public List<ResVersionInfo.FileInfo> GetNeedDownloadFileInfo()
	{
		return null;
	}

	[Token(Token = "0x601A51D")]
	[Address(RVA = "0x30913EC", Offset = "0x30913EC", VA = "0x30913EC")]
	public void ClearVersion()
	{
	}

	[Token(Token = "0x601A51E")]
	[Address(RVA = "0x30913F8", Offset = "0x30913F8", VA = "0x30913F8", Slot = "5")]
	public virtual void ClearFileInfoList()
	{
	}

	[Token(Token = "0x601A51F")]
	[Address(RVA = "0x3091738", Offset = "0x3091738", VA = "0x3091738")]
	public void ClearFileInfoListByTag(uint tag, bool deleteRecommend = false, bool delete_downloading = true, uint downloading_tag = 0u)
	{
	}

	[Token(Token = "0x601A520")]
	[Address(RVA = "0x3091CD0", Offset = "0x3091CD0", VA = "0x3091CD0")]
	public void ResetFileState(string file_name)
	{
	}

	[Token(Token = "0x601A521")]
	[Address(RVA = "0x3091E5C", Offset = "0x3091E5C", VA = "0x3091E5C")]
	public void ClearDownloadFlag()
	{
	}

	[Token(Token = "0x601A522")]
	[Address(RVA = "0x3092014", Offset = "0x3092014", VA = "0x3092014")]
	public bool FindFileInfo(string fullName, out ResVersionInfo.FileInfo result)
	{
		return default(bool);
	}

	[Token(Token = "0x601A523")]
	[Address(RVA = "0x30920C4", Offset = "0x30920C4", VA = "0x30920C4")]
	public void AddFileInfo(ResVersionInfo.FileInfo fileInfo)
	{
	}

	[Token(Token = "0x601A524")]
	[Address(RVA = "0x3092344", Offset = "0x3092344", VA = "0x3092344")]
	public void AddTagFilePair(uint tag, List<ResVersionInfo.FileInfo> fileInfo_List)
	{
	}

	[Token(Token = "0x601A525")]
	[Address(RVA = "0x3092590", Offset = "0x3092590", VA = "0x3092590")]
	public void AddTagFilePair(uint tag, ResVersionInfo.FileInfo fileInfo)
	{
	}

	[Token(Token = "0x601A526")]
	[Address(RVA = "0x309277C", Offset = "0x309277C", VA = "0x309277C", Slot = "6")]
	public virtual ResErrorCode SaveFileInfo(ResUpdateDownloadContext context)
	{
		return default(ResErrorCode);
	}

	[Token(Token = "0x601A527")]
	[Address(RVA = "0x30934BC", Offset = "0x30934BC", VA = "0x30934BC", Slot = "7")]
	public virtual ResErrorCode SaveDesignatedFileInfo(ResUpdateDownloadContext context)
	{
		return default(ResErrorCode);
	}

	[Token(Token = "0x601A528")]
	[Address(RVA = "0x30941FC", Offset = "0x30941FC", VA = "0x30941FC")]
	public ResErrorCode SaveVersionInfo(ResUpdateDownloadContext context)
	{
		return default(ResErrorCode);
	}

	[Token(Token = "0x601A529")]
	[Address(RVA = "0x309458C", Offset = "0x309458C", VA = "0x309458C")]
	public ResErrorCode Save(ResUpdateDownloadContext context)
	{
		return default(ResErrorCode);
	}

	[Token(Token = "0x601A52A")]
	[Address(RVA = "0x30946AC", Offset = "0x30946AC", VA = "0x30946AC")]
	public void SetFileInfo(List<ResVersionInfo.FileInfo> fileInfoList)
	{
	}

	[Token(Token = "0x601A52B")]
	[Address(RVA = "0x3094854", Offset = "0x3094854", VA = "0x3094854")]
	public void SetNeedToSaveFileInfo(List<ResVersionInfo.FileInfo> fileInfoList)
	{
	}
}
