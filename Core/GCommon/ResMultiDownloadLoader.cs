using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace GCommon;

[Token(Token = "0x20040BF")]
public class ResMultiDownloadLoader : ResWithTempFileLoader, _Attribute
{
	[Token(Token = "0x401B323")]
	[FieldOffset(Offset = "0x3C")]
	public ResDownloadType DownloadType;

	[Token(Token = "0x401B324")]
	[FieldOffset(Offset = "0x40")]
	public Action<UnityWebRequest, ResWithTempFileLoader> OnLoaded;

	[Token(Token = "0x401B325")]
	[FieldOffset(Offset = "0x44")]
	public bool NeedInitFileLength;

	[Token(Token = "0x401B326")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string ERR_CELL_DOWNLOAD_FAILED;

	[Token(Token = "0x401B327")]
	[FieldOffset(Offset = "0x48")]
	protected FileStream m_TempFileStream;

	[Token(Token = "0x401B328")]
	[FieldOffset(Offset = "0x50")]
	protected long m_TempFileLength;

	[Token(Token = "0x401B329")]
	[FieldOffset(Offset = "0x58")]
	protected long m_DownloadingSize;

	[Token(Token = "0x401B32A")]
	[FieldOffset(Offset = "0x60")]
	protected long m_LastDownloadedSize;

	[Token(Token = "0x401B32B")]
	[FieldOffset(Offset = "0x68")]
	protected SHA1CryptoServiceProvider m_HashWorker;

	[Token(Token = "0x401B32C")]
	[FieldOffset(Offset = "0x6C")]
	protected byte[] m_HashBuffer;

	[Token(Token = "0x401B32D")]
	[FieldOffset(Offset = "0x70")]
	protected bool m_NeedHashTemp;

	[Token(Token = "0x401B32E")]
	[FieldOffset(Offset = "0x74")]
	protected FileStream m_FlagStream;

	[Token(Token = "0x401B32F")]
	[FieldOffset(Offset = "0x78")]
	protected BitArrayRich m_TempFlag;

	[Token(Token = "0x401B330")]
	[FieldOffset(Offset = "0x7C")]
	protected BitArrayRich m_RunningFlag;

	[Token(Token = "0x401B331")]
	[FieldOffset(Offset = "0x80")]
	protected int m_MaxReqCount;

	[Token(Token = "0x401B332")]
	[FieldOffset(Offset = "0x84")]
	protected uint m_CellCount;

	[Token(Token = "0x401B333")]
	[FieldOffset(Offset = "0x88")]
	protected int m_CellDownloadRetryCount;

	[Token(Token = "0x401B334")]
	[FieldOffset(Offset = "0x8C")]
	private List<UnityWebRequest> m_RunningReq;

	[Token(Token = "0x401B335")]
	[FieldOffset(Offset = "0x90")]
	private List<UnityWebRequest> m_FinishedReq;

	[Token(Token = "0x401B336")]
	[FieldOffset(Offset = "0x94")]
	protected uint m_NextDownloadIndex;

	[Token(Token = "0x401B337")]
	[FieldOffset(Offset = "0x98")]
	protected bool m_Started;

	[Token(Token = "0x401B338")]
	protected const float REQ_TIMEOUT_SECOUNDS = 60f;

	[Token(Token = "0x401B339")]
	protected const float TIMEOUT_SECOUNDS = 90f;

	[Token(Token = "0x401B33A")]
	[FieldOffset(Offset = "0x9C")]
	protected float m_GCIndex;

	[Token(Token = "0x401B33B")]
	[FieldOffset(Offset = "0x4")]
	public static int Loader_Count;

	[Token(Token = "0x401B33C")]
	[FieldOffset(Offset = "0xA0")]
	protected bool m_ShouldReuseMemory;

	[Token(Token = "0x401B33D")]
	[FieldOffset(Offset = "0xA1")]
	protected bool m_ShouldOverrideWithFull;

	[Token(Token = "0x17001CD6")]
	public override long CELL_SIZE
	{
		[Token(Token = "0x601A5A1")]
		[Address(RVA = "0x32E8398", Offset = "0x32E8398", VA = "0x32E8398", Slot = "16")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x601A5A0")]
	[Address(RVA = "0x32E82B4", Offset = "0x32E82B4", VA = "0x32E82B4")]
	public ResMultiDownloadLoader(int mex_req_count, bool should_reuse_mem = false, bool should_override_with_full = false, int gc_index = 0)
	{
	}

	[Token(Token = "0x601A5A2")]
	[Address(RVA = "0x32E83A4", Offset = "0x32E83A4", VA = "0x32E83A4", Slot = "7")]
	protected override void OnStart(float time)
	{
	}

	[Token(Token = "0x601A5A3")]
	[Address(RVA = "0x32E90A8", Offset = "0x32E90A8", VA = "0x32E90A8", Slot = "18")]
	protected virtual void GetFileWithIndex(float time, uint cell_index)
	{
	}

	[Token(Token = "0x601A5A4")]
	[Address(RVA = "0x32E9714", Offset = "0x32E9714", VA = "0x32E9714")]
	protected void PrepareHashAndTempIndex()
	{
	}

	[Token(Token = "0x601A5A5")]
	[Address(RVA = "0x32E99A8", Offset = "0x32E99A8", VA = "0x32E99A8", Slot = "10")]
	public override bool HasStarted()
	{
		return default(bool);
	}

	[Token(Token = "0x601A5A6")]
	[Address(RVA = "0x32E99B0", Offset = "0x32E99B0", VA = "0x32E99B0", Slot = "6")]
	public override bool IsFinished()
	{
		return default(bool);
	}

	[Token(Token = "0x601A5A7")]
	[Address(RVA = "0x32E99E8", Offset = "0x32E99E8", VA = "0x32E99E8", Slot = "4")]
	public override long GetDownloadingSize()
	{
		return default(long);
	}

	[Token(Token = "0x601A5A8")]
	[Address(RVA = "0x32E9A04", Offset = "0x32E9A04", VA = "0x32E9A04", Slot = "8")]
	protected override void OnDispose()
	{
	}

	[Token(Token = "0x601A5A9")]
	[Address(RVA = "0x32EA0AC", Offset = "0x32EA0AC", VA = "0x32EA0AC", Slot = "11")]
	protected override void OnUpdate(float time)
	{
	}

	[Token(Token = "0x601A5AA")]
	[Address(RVA = "0x32EAE78", Offset = "0x32EAE78", VA = "0x32EAE78")]
	protected void SaveFlagFile()
	{
	}

	[Token(Token = "0x601A5AB")]
	[Address(RVA = "0x32EAF4C", Offset = "0x32EAF4C", VA = "0x32EAF4C")]
	protected void OnRequestComplete(byte[] buffer, uint index, int download_size)
	{
	}

	[Token(Token = "0x601A5AC")]
	[Address(RVA = "0x32EBBE0", Offset = "0x32EBBE0", VA = "0x32EBBE0")]
	protected void CollectDataAndClearFileStream()
	{
	}

	[Token(Token = "0x601A5AD")]
	[Address(RVA = "0x32E9D94", Offset = "0x32E9D94", VA = "0x32E9D94")]
	protected void ClearFileStream()
	{
	}

	[Token(Token = "0x601A5AE")]
	[Address(RVA = "0x32EA07C", Offset = "0x32EA07C", VA = "0x32EA07C")]
	protected void ClearHashWorker()
	{
	}

	[Token(Token = "0x601A5AF")]
	[Address(RVA = "0x32EBF34", Offset = "0x32EBF34", VA = "0x32EBF34")]
	protected void ClearFlagFile()
	{
	}

	[Token(Token = "0x601A5B0")]
	[Address(RVA = "0x32EC0C4", Offset = "0x32EC0C4", VA = "0x32EC0C4", Slot = "9")]
	protected override void OnNotify()
	{
	}

	[Token(Token = "0x601A5B1")]
	[Address(RVA = "0x32EC1D4", Offset = "0x32EC1D4", VA = "0x32EC1D4", Slot = "14")]
	public override long NeedDownloadSize()
	{
		return default(long);
	}

	[Token(Token = "0x601A5B2")]
	[Address(RVA = "0x32EC1DC", Offset = "0x32EC1DC", VA = "0x32EC1DC", Slot = "13")]
	public override void OnPause()
	{
	}

	[Token(Token = "0x601A5B3")]
	[Address(RVA = "0x32EC214", Offset = "0x32EC214", VA = "0x32EC214", Slot = "17")]
	public ResFileLoader CopyToBackGroundLoader()
	{
		return null;
	}
}
