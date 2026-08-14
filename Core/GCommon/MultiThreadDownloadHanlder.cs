using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace GCommon;

[Token(Token = "0x20040BE")]
public class MultiThreadDownloadHanlder : DownloadHandlerScript
{
	[Token(Token = "0x401B31B")]
	[FieldOffset(Offset = "0xC")]
	private Action<byte[], uint, int> m_OnComplete;

	[Token(Token = "0x401B31C")]
	[FieldOffset(Offset = "0x10")]
	public uint DataIndex;

	[Token(Token = "0x401B31D")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<int, MemoryStream> REUSED_MEM_MAP;

	[Token(Token = "0x401B31E")]
	[FieldOffset(Offset = "0x14")]
	private MemoryStream reused_download_data;

	[Token(Token = "0x401B31F")]
	[FieldOffset(Offset = "0x18")]
	private MemoryStream download_data;

	[Token(Token = "0x401B320")]
	[FieldOffset(Offset = "0x1C")]
	private int download_size;

	[Token(Token = "0x401B321")]
	[FieldOffset(Offset = "0x20")]
	private bool should_reused_mem;

	[Token(Token = "0x401B322")]
	[FieldOffset(Offset = "0x28")]
	private long m_CellSize;

	[Token(Token = "0x601A598")]
	[Address(RVA = "0x296C8E4", Offset = "0x296C8E4", VA = "0x296C8E4")]
	public MultiThreadDownloadHanlder(Action<byte[], uint, int> complete_callback, int download_type, uint index, bool should_reusememorydata, long cell_size)
	{
	}

	[Token(Token = "0x601A599")]
	[Address(RVA = "0x296CB00", Offset = "0x296CB00", VA = "0x296CB00")]
	private MemoryStream GetMemoryData()
	{
		return null;
	}

	[Token(Token = "0x601A59A")]
	[Address(RVA = "0x296CB18", Offset = "0x296CB18", VA = "0x296CB18")]
	private bool IsMemoryStreamValid()
	{
		return default(bool);
	}

	[Token(Token = "0x601A59B")]
	[Address(RVA = "0x296CB88", Offset = "0x296CB88", VA = "0x296CB88")]
	private void ClearMemoryData()
	{
	}

	[Token(Token = "0x601A59C")]
	[Address(RVA = "0x296CBE4", Offset = "0x296CBE4", VA = "0x296CBE4", Slot = "5")]
	protected override byte[] GetData()
	{
		return null;
	}

	[Token(Token = "0x601A59D")]
	[Address(RVA = "0x296CC28", Offset = "0x296CC28", VA = "0x296CC28", Slot = "7")]
	protected override bool ReceiveData(byte[] remote_data, int dataLength)
	{
		return default(bool);
	}

	[Token(Token = "0x601A59E")]
	[Address(RVA = "0x296CDE8", Offset = "0x296CDE8", VA = "0x296CDE8", Slot = "8")]
	protected override void CompleteContent()
	{
	}
}
