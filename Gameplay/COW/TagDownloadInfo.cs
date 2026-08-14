using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20031AF")]
public class TagDownloadInfo
{
	[Token(Token = "0x4012E59")]
	[FieldOffset(Offset = "0x8")]
	public uint OptionalReDefId;

	[Token(Token = "0x4012E5A")]
	[FieldOffset(Offset = "0xC")]
	public EDownloadContextState ShowState;

	[Token(Token = "0x4012E5B")]
	[FieldOffset(Offset = "0x10")]
	public bool IsShow;

	[Token(Token = "0x4012E5C")]
	[FieldOffset(Offset = "0x14")]
	public List<uint> resTypeList;

	[Token(Token = "0x4012E5D")]
	[FieldOffset(Offset = "0x18")]
	public List<ResVersionInfo.FileInfo> PackFileInfoList;

	[Token(Token = "0x4012E5E")]
	[FieldOffset(Offset = "0x1C")]
	public bool CotainRecommend;

	[Token(Token = "0x4012E5F")]
	[FieldOffset(Offset = "0x1D")]
	public bool isRecommend;

	[Token(Token = "0x4012E60")]
	[FieldOffset(Offset = "0x20")]
	public float DownloadedSize;

	[Token(Token = "0x4012E61")]
	[FieldOffset(Offset = "0x28")]
	public long TotalSize;

	[Token(Token = "0x4012E62")]
	[FieldOffset(Offset = "0x30")]
	public float TotalZipSize;

	[Token(Token = "0x4012E63")]
	[FieldOffset(Offset = "0x34")]
	public uint CategoryType;

	[Token(Token = "0x4012E64")]
	[FieldOffset(Offset = "0x38")]
	public bool HideAfterDownload;

	[Token(Token = "0x4012E65")]
	[FieldOffset(Offset = "0x39")]
	public bool HideInLogin;

	[Token(Token = "0x4012E66")]
	[FieldOffset(Offset = "0x3A")]
	public bool CanDownload;

	[Token(Token = "0x4012E67")]
	[FieldOffset(Offset = "0x3B")]
	public bool ForceDownload;

	[Token(Token = "0x4012E68")]
	[FieldOffset(Offset = "0x3C")]
	public EDownloadContextMode DownloadStateMode;

	[Token(Token = "0x4012E69")]
	[FieldOffset(Offset = "0x40")]
	public bool NeedAddToPendingAfterDownloadSingle;

	[Token(Token = "0x4012E6A")]
	[FieldOffset(Offset = "0x44")]
	private UIModelOptionalDownload m_Model;

	[Token(Token = "0x4012E6B")]
	[FieldOffset(Offset = "0x48")]
	public List<ResVersionInfo.FileInfo> Cur_DownloadingSingelFileInfos;

	[Token(Token = "0x6014E36")]
	[Address(RVA = "0x2893D9C", Offset = "0x2893D9C", VA = "0x2893D9C")]
	public TagDownloadInfo()
	{
	}

	[Token(Token = "0x6014E37")]
	[Address(RVA = "0x2893DA4", Offset = "0x2893DA4", VA = "0x2893DA4")]
	public void InitData()
	{
	}

	[Token(Token = "0x6014E38")]
	[Address(RVA = "0x2894148", Offset = "0x2894148", VA = "0x2894148")]
	public float GetDownloadedSize()
	{
		return default(float);
	}

	[Token(Token = "0x6014E39")]
	[Address(RVA = "0x28946AC", Offset = "0x28946AC", VA = "0x28946AC")]
	public bool DownloadSingleFileFinished()
	{
		return default(bool);
	}

	[Token(Token = "0x6014E3A")]
	[Address(RVA = "0x28943E4", Offset = "0x28943E4", VA = "0x28943E4")]
	public bool IsDownloadAll()
	{
		return default(bool);
	}

	[Token(Token = "0x6014E3B")]
	[Address(RVA = "0x28948A0", Offset = "0x28948A0", VA = "0x28948A0")]
	public long GetTotalRequireSize()
	{
		return default(long);
	}

	[Token(Token = "0x6014E3C")]
	[Address(RVA = "0x2894618", Offset = "0x2894618", VA = "0x2894618")]
	public float GetDownloadProcess()
	{
		return default(float);
	}

	[Token(Token = "0x6014E3D")]
	[Address(RVA = "0x2894AE4", Offset = "0x2894AE4", VA = "0x2894AE4")]
	public void AddCurDownloadingFileInfos(ResVersionInfo.FileInfo[] fileinfos)
	{
	}

	[Token(Token = "0x6014E3E")]
	[Address(RVA = "0x2894CC8", Offset = "0x2894CC8", VA = "0x2894CC8")]
	public void ClearCurDownloadingFileInfos()
	{
	}

	[Token(Token = "0x6014E3F")]
	[Address(RVA = "0x2894D84", Offset = "0x2894D84", VA = "0x2894D84")]
	public void AddFileInfoRange(List<ResVersionInfo.FileInfo> file_InfoList)
	{
	}
}
