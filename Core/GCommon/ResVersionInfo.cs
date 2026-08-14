using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x20040DE")]
public class ResVersionInfo
{
	[Token(Token = "0x20040DF")]
	public class FileInfo
	{
		[Token(Token = "0x20040E0")]
		public enum OpState
		{
			[Token(Token = "0x401B437")]
			Local,
			[Token(Token = "0x401B438")]
			Download,
			[Token(Token = "0x401B439")]
			Cache,
			[Token(Token = "0x401B43A")]
			CacheUnzipped
		}

		[Token(Token = "0x401B428")]
		[FieldOffset(Offset = "0x8")]
		public string FullName;

		[Token(Token = "0x401B429")]
		[FieldOffset(Offset = "0xC")]
		public string Hash;

		[Token(Token = "0x401B42A")]
		[FieldOffset(Offset = "0x10")]
		public string ZipHash;

		[Token(Token = "0x401B42B")]
		[FieldOffset(Offset = "0x18")]
		public long Size;

		[Token(Token = "0x401B42C")]
		[FieldOffset(Offset = "0x20")]
		public long ZipSize;

		[Token(Token = "0x401B42D")]
		[FieldOffset(Offset = "0x28")]
		public OpState State;

		[Token(Token = "0x401B42E")]
		[FieldOffset(Offset = "0x2C")]
		public bool IsCompressed;

		[Token(Token = "0x401B42F")]
		[FieldOffset(Offset = "0x30")]
		public ResFileType FileType;

		[Token(Token = "0x401B430")]
		[FieldOffset(Offset = "0x34")]
		public bool IsInSingleList;

		[Token(Token = "0x401B431")]
		[FieldOffset(Offset = "0x35")]
		public bool IsRecommendFile;

		[Token(Token = "0x401B432")]
		[FieldOffset(Offset = "0x38")]
		public List<uint> BelongTagList;

		[Token(Token = "0x401B433")]
		[FieldOffset(Offset = "0x3C")]
		public uint minTag;

		[Token(Token = "0x401B434")]
		[FieldOffset(Offset = "0x40")]
		private string m_CDNExt;

		[Token(Token = "0x401B435")]
		[FieldOffset(Offset = "0x44")]
		private string m_UnzipExt;

		[Token(Token = "0x601A70B")]
		[Address(RVA = "0x32FF4FC", Offset = "0x32FF4FC", VA = "0x32FF4FC")]
		public FileInfo()
		{
		}

		[Token(Token = "0x601A70C")]
		[Address(RVA = "0x33002DC", Offset = "0x33002DC", VA = "0x33002DC")]
		public string Print()
		{
			return null;
		}

		[Token(Token = "0x601A70D")]
		[Address(RVA = "0x32F6E88", Offset = "0x32F6E88", VA = "0x32F6E88")]
		public FileInfo Clone()
		{
			return null;
		}

		[Token(Token = "0x601A70E")]
		[Address(RVA = "0x32EF618", Offset = "0x32EF618", VA = "0x32EF618")]
		public string GetFullNameWithCDNExt(bool need_cache = true)
		{
			return null;
		}

		[Token(Token = "0x601A70F")]
		[Address(RVA = "0x32EF870", Offset = "0x32EF870", VA = "0x32EF870")]
		public string GetFullNameWithUnzipExt(bool need_cache = true)
		{
			return null;
		}

		[Token(Token = "0x601A710")]
		[Address(RVA = "0x32F8E78", Offset = "0x32F8E78", VA = "0x32F8E78")]
		public void AddFileBelongTag(uint tag)
		{
		}

		[Token(Token = "0x601A711")]
		[Address(RVA = "0x32FA21C", Offset = "0x32FA21C", VA = "0x32FA21C")]
		public void ClearTagTable(uint tag)
		{
		}

		[Token(Token = "0x601A712")]
		[Address(RVA = "0x33006EC", Offset = "0x33006EC", VA = "0x33006EC")]
		public bool IsDownloadFinished()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20040E1")]
	private sealed class _003CLoad_003Ec__AnonStorey0
	{
		[Token(Token = "0x401B43B")]
		[FieldOffset(Offset = "0x8")]
		internal ResHotUpdater updaterInst;

		[Token(Token = "0x401B43C")]
		[FieldOffset(Offset = "0xC")]
		internal DownloadContext download_context;

		[Token(Token = "0x401B43D")]
		[FieldOffset(Offset = "0x10")]
		internal Action<bool> onVersionInfoLoaded;

		[Token(Token = "0x401B43E")]
		[FieldOffset(Offset = "0x14")]
		internal ResVersionInfo _0024this;

		[Token(Token = "0x601A713")]
		[Address(RVA = "0x32FD7CC", Offset = "0x32FD7CC", VA = "0x32FD7CC")]
		public _003CLoad_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601A714")]
		[Address(RVA = "0x32FF8D8", Offset = "0x32FF8D8", VA = "0x32FF8D8")]
		internal void _003C_003Em__0(WWW www, ResWWWFileLoader loader)
		{
		}

		[Token(Token = "0x601A715")]
		[Address(RVA = "0x32FFD4C", Offset = "0x32FFD4C", VA = "0x32FFD4C")]
		internal void _003C_003Em__1(ResErrorCode error, ResDownloadType type)
		{
		}
	}

	[Token(Token = "0x20040E2")]
	private sealed class _003CLoadFileInfo_003Ec__AnonStorey1
	{
		[Token(Token = "0x401B43F")]
		[FieldOffset(Offset = "0x8")]
		internal ResHotUpdater updaterInst;

		[Token(Token = "0x401B440")]
		[FieldOffset(Offset = "0xC")]
		internal DownloadContext download_context;

		[Token(Token = "0x401B441")]
		[FieldOffset(Offset = "0x10")]
		internal Action<bool> onFileInfoLoaded;

		[Token(Token = "0x401B442")]
		[FieldOffset(Offset = "0x14")]
		internal ResVersionInfo _0024this;

		[Token(Token = "0x601A716")]
		[Address(RVA = "0x32FDBC8", Offset = "0x32FDBC8", VA = "0x32FDBC8")]
		public _003CLoadFileInfo_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x601A717")]
		[Address(RVA = "0x32FFDD4", Offset = "0x32FFDD4", VA = "0x32FFDD4")]
		internal void _003C_003Em__0(WWW www, ResWWWFileLoader loader)
		{
		}

		[Token(Token = "0x601A718")]
		[Address(RVA = "0x3300240", Offset = "0x3300240", VA = "0x3300240")]
		internal void _003C_003Em__1(ResErrorCode error, ResDownloadType type)
		{
		}
	}

	[Token(Token = "0x20040E3")]
	private sealed class _003CParseFile_003Ec__AnonStorey2
	{
		[Token(Token = "0x401B443")]
		[FieldOffset(Offset = "0x8")]
		internal ResFileType fileType;

		[Token(Token = "0x601A719")]
		[Address(RVA = "0x32FF4F4", Offset = "0x32FF4F4", VA = "0x32FF4F4")]
		public _003CParseFile_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x601A71A")]
		[Address(RVA = "0x33002C8", Offset = "0x33002C8", VA = "0x33002C8")]
		internal bool _003C_003Em__0(int element)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x401B41F")]
	[FieldOffset(Offset = "0x8")]
	public uint MajorVersion;

	[Token(Token = "0x401B420")]
	[FieldOffset(Offset = "0xC")]
	public uint MinorVersion;

	[Token(Token = "0x401B421")]
	[FieldOffset(Offset = "0x10")]
	public uint OptionalVersion;

	[Token(Token = "0x401B422")]
	[FieldOffset(Offset = "0x14")]
	private bool m_IsRemote;

	[Token(Token = "0x401B423")]
	[FieldOffset(Offset = "0x15")]
	private bool m_IsUsingEmbed;

	[Token(Token = "0x401B424")]
	[FieldOffset(Offset = "0x18")]
	private ResFileType m_MaxSkipType;

	[Token(Token = "0x401B425")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<string, FileInfo> m_FileInfos;

	[Token(Token = "0x401B426")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<int, Dictionary<string, FileInfo>> m_FileInfoListMapWithType;

	[Token(Token = "0x401B427")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<int, long> m_StoredFileSizeMapWithType;

	[Token(Token = "0x601A6F9")]
	[Address(RVA = "0x32FC98C", Offset = "0x32FC98C", VA = "0x32FC98C")]
	public ResVersionInfo(bool isRemote)
	{
	}

	[Token(Token = "0x601A6FA")]
	[Address(RVA = "0x32FCA94", Offset = "0x32FCA94", VA = "0x32FCA94")]
	public void LoadFromString(DownloadContext downloadContext, ResHotUpdater updaterInst, string removeVersion)
	{
	}

	[Token(Token = "0x601A6FB")]
	[Address(RVA = "0x32FD440", Offset = "0x32FD440", VA = "0x32FD440")]
	public void Load(ResHotUpdater updaterInst, string versionInfoPath, Action<bool> onVersionInfoLoaded)
	{
	}

	[Token(Token = "0x601A6FC")]
	[Address(RVA = "0x32FD7D4", Offset = "0x32FD7D4", VA = "0x32FD7D4")]
	public void LoadFileInfo(ResHotUpdater updaterInst, string fileInfoPath, Action<bool> onFileInfoLoaded)
	{
	}

	[Token(Token = "0x601A6FD")]
	[Address(RVA = "0x32FDBD0", Offset = "0x32FDBD0", VA = "0x32FDBD0")]
	private bool LoadLocalFileInfo(ResHotUpdater updaterInst, [Optional] int[] targetFileType)
	{
		return default(bool);
	}

	[Token(Token = "0x601A6FE")]
	[Address(RVA = "0x32FE934", Offset = "0x32FE934", VA = "0x32FE934")]
	public string GetVersionString()
	{
		return null;
	}

	[Token(Token = "0x601A6FF")]
	[Address(RVA = "0x32FEA30", Offset = "0x32FEA30", VA = "0x32FEA30")]
	public string GetOptionVersionString()
	{
		return null;
	}

	[Token(Token = "0x601A700")]
	[Address(RVA = "0x32FEA3C", Offset = "0x32FEA3C", VA = "0x32FEA3C")]
	public Dictionary<string, FileInfo> GetFileInfoListWithType(ResFileType fileType)
	{
		return null;
	}

	[Token(Token = "0x601A701")]
	[Address(RVA = "0x32FEB90", Offset = "0x32FEB90", VA = "0x32FEB90")]
	public void AddFileInfo(FileInfo fileInfo)
	{
	}

	[Token(Token = "0x601A702")]
	[Address(RVA = "0x32FEC8C", Offset = "0x32FEC8C", VA = "0x32FEC8C")]
	public bool FindFileInfo(string fullName, out FileInfo result)
	{
		return default(bool);
	}

	[Token(Token = "0x601A703")]
	[Address(RVA = "0x32FEE74", Offset = "0x32FEE74", VA = "0x32FEE74")]
	private bool HaveEnoughStorage()
	{
		return default(bool);
	}

	[Token(Token = "0x601A704")]
	[Address(RVA = "0x32E5D94", Offset = "0x32E5D94", VA = "0x32E5D94")]
	public ResErrorCode SaveFileInfo(ResHotUpdaterContext context)
	{
		return default(ResErrorCode);
	}

	[Token(Token = "0x601A705")]
	[Address(RVA = "0x32FEF08", Offset = "0x32FEF08", VA = "0x32FEF08")]
	public ResErrorCode SaveVersionInfo(ResHotUpdaterContext context, ResDownloadType type = ResDownloadType.CompulsoryRes)
	{
		return default(ResErrorCode);
	}

	[Token(Token = "0x601A706")]
	[Address(RVA = "0x32FF3B4", Offset = "0x32FF3B4", VA = "0x32FF3B4")]
	public ResErrorCode Save(ResHotUpdater updaterInst, ResDownloadType type = ResDownloadType.CompulsoryRes)
	{
		return default(ResErrorCode);
	}

	[Token(Token = "0x601A707")]
	[Address(RVA = "0x32FD140", Offset = "0x32FD140", VA = "0x32FD140")]
	private bool ParseVersion(string content, ref uint majorVersion, ref uint minorVersion, ref uint optionalVersion)
	{
		return default(bool);
	}

	[Token(Token = "0x601A708")]
	[Address(RVA = "0x32FF4EC", Offset = "0x32FF4EC", VA = "0x32FF4EC")]
	public Dictionary<string, FileInfo> GetFileInfos()
	{
		return null;
	}

	[Token(Token = "0x601A709")]
	[Address(RVA = "0x32FE08C", Offset = "0x32FE08C", VA = "0x32FE08C")]
	private bool ParseFile(string content, [Optional] int[] targetFileTypes, bool from_local = false)
	{
		return default(bool);
	}

	[Token(Token = "0x601A70A")]
	[Address(RVA = "0x32FF588", Offset = "0x32FF588", VA = "0x32FF588")]
	public long GetStoredFileSize(ResFileType type)
	{
		return default(long);
	}
}
