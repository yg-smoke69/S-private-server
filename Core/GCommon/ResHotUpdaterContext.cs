using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x20040C7")]
public class ResHotUpdaterContext
{
	[Token(Token = "0x401B36C")]
	[FieldOffset(Offset = "0x8")]
	public uint[] DownloadTypes;

	[Token(Token = "0x401B36D")]
	[FieldOffset(Offset = "0xC")]
	public string RemoteAddr;

	[Token(Token = "0x401B36E")]
	[FieldOffset(Offset = "0x10")]
	public string VersionInfoPath;

	[Token(Token = "0x401B36F")]
	[FieldOffset(Offset = "0x14")]
	public string FileInfoPath;

	[Token(Token = "0x401B370")]
	[FieldOffset(Offset = "0x18")]
	public string AssetBundlePrefix;

	[Token(Token = "0x401B371")]
	[FieldOffset(Offset = "0x1C")]
	public int MaxLoaderCountSimultaneously;

	[Token(Token = "0x401B372")]
	[FieldOffset(Offset = "0x20")]
	public int MaxOptionalDownloadThreadCount;

	[Token(Token = "0x401B373")]
	[FieldOffset(Offset = "0x24")]
	public bool EnableOverrideWithFullData;

	[Token(Token = "0x401B374")]
	[FieldOffset(Offset = "0x28")]
	public int MaxRetryCount;

	[Token(Token = "0x401B375")]
	[FieldOffset(Offset = "0x2C")]
	public MonoBehaviour CoroutineHolder;

	[Token(Token = "0x401B376")]
	[FieldOffset(Offset = "0x30")]
	public Action<ResHotUpdateResult> OnGetRemoteFileInfoFinished;

	[Token(Token = "0x401B377")]
	[FieldOffset(Offset = "0x34")]
	public Action<ResHotUpdateResult> OnGetLocalVerionFinished;

	[Token(Token = "0x401B378")]
	[FieldOffset(Offset = "0x38")]
	public Action<ResHotUpdateResult> OnStarted;

	[Token(Token = "0x401B379")]
	[FieldOffset(Offset = "0x3C")]
	public Action<ResErrorCode> OnHotUpdateFinished;

	[Token(Token = "0x401B37A")]
	[FieldOffset(Offset = "0x40")]
	public List<uint> PendingDownloadTypes;

	[Token(Token = "0x401B37B")]
	[FieldOffset(Offset = "0x44")]
	public Dictionary<uint, string> OptionalVersionMap;

	[Token(Token = "0x401B37C")]
	[FieldOffset(Offset = "0x48")]
	public string LocalAddr;

	[Token(Token = "0x401B37D")]
	[FieldOffset(Offset = "0x4C")]
	public string CacheAddr;

	[Token(Token = "0x401B37E")]
	[FieldOffset(Offset = "0x50")]
	public string OptionalCacheAddr;

	[Token(Token = "0x401B37F")]
	[FieldOffset(Offset = "0x54")]
	public string TempCacheAddr;

	[Token(Token = "0x401B380")]
	[FieldOffset(Offset = "0x58")]
	public bool NoResourceDownload;

	[Token(Token = "0x401B381")]
	[FieldOffset(Offset = "0x59")]
	public bool UseBigFileDownload;

	[Token(Token = "0x601A5D9")]
	[Address(RVA = "0x32E81EC", Offset = "0x32E81EC", VA = "0x32E81EC")]
	public ResHotUpdaterContext()
	{
	}

	[Token(Token = "0x601A5DA")]
	[Address(RVA = "0x32E829C", Offset = "0x32E829C", VA = "0x32E829C")]
	public void ClearContextActionReference()
	{
	}
}
