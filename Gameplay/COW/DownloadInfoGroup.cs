using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20031AE")]
public class DownloadInfoGroup
{
	[Token(Token = "0x4012E50")]
	[FieldOffset(Offset = "0x8")]
	public uint optionalReDefTypeId;

	[Token(Token = "0x4012E51")]
	[FieldOffset(Offset = "0xC")]
	public EDownloadContextState ShowState;

	[Token(Token = "0x4012E52")]
	[FieldOffset(Offset = "0x10")]
	public List<TagDownloadInfo> downloadInfoList;

	[Token(Token = "0x4012E53")]
	[FieldOffset(Offset = "0x14")]
	public bool CotainRecommend;

	[Token(Token = "0x4012E54")]
	[FieldOffset(Offset = "0x18")]
	public float downloadedSize;

	[Token(Token = "0x4012E55")]
	[FieldOffset(Offset = "0x1C")]
	public float TotalSize;

	[Token(Token = "0x4012E56")]
	[FieldOffset(Offset = "0x20")]
	public float TotalZipSize;

	[Token(Token = "0x4012E57")]
	[FieldOffset(Offset = "0x24")]
	public int DownloadedCount;

	[Token(Token = "0x4012E58")]
	[FieldOffset(Offset = "0x28")]
	public int TotalCount;

	[Token(Token = "0x6014E31")]
	[Address(RVA = "0x1C9463C", Offset = "0x1C9463C", VA = "0x1C9463C")]
	public DownloadInfoGroup()
	{
	}

	[Token(Token = "0x6014E32")]
	[Address(RVA = "0x1C94644", Offset = "0x1C94644", VA = "0x1C94644")]
	public void InitData()
	{
	}

	[Token(Token = "0x6014E33")]
	[Address(RVA = "0x1C949B0", Offset = "0x1C949B0", VA = "0x1C949B0")]
	public float GetDownloadProcess()
	{
		return default(float);
	}

	[Token(Token = "0x6014E34")]
	[Address(RVA = "0x1C94A2C", Offset = "0x1C94A2C", VA = "0x1C94A2C")]
	public float GetDownloadedSize()
	{
		return default(float);
	}

	[Token(Token = "0x6014E35")]
	[Address(RVA = "0x1C94908", Offset = "0x1C94908", VA = "0x1C94908")]
	private EDownloadContextState GetShowPriorityState(EDownloadContextState currentState, EDownloadContextState itemState)
	{
		return default(EDownloadContextState);
	}
}
