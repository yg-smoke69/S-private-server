using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004082")]
public class ReplicationDataPool
{
	[Token(Token = "0x401B1F6")]
	[FieldOffset(Offset = "0x8")]
	protected ReplicationData[] m_Datas;

	[Token(Token = "0x401B1F7")]
	[FieldOffset(Offset = "0xC")]
	protected int m_MaxVarCount;

	[Token(Token = "0x401B1F8")]
	[FieldOffset(Offset = "0x10")]
	protected Dictionary<uint, Delegate> m_Handlers;

	[Token(Token = "0x401B1F9")]
	[FieldOffset(Offset = "0x14")]
	protected object[] m_TmpParams;

	[Token(Token = "0x601A3BB")]
	[Address(RVA = "0x332B5E4", Offset = "0x332B5E4", VA = "0x332B5E4")]
	public ReplicationDataPool(int maxVarCount)
	{
	}

	[Token(Token = "0x601A3BC")]
	[Address(RVA = "0x332B6B0", Offset = "0x332B6B0", VA = "0x332B6B0", Slot = "4")]
	public void AppendSize(int appendSize)
	{
	}

	[Token(Token = "0x601A3BD")]
	public void RegisterDataChangedHanlder<T>(uint varID, DataChangedHanlder<T> handler)
	{
	}

	[Token(Token = "0x601A3BE")]
	public bool AddData<T>(uint varID, T initValue, [Optional] DataChangedHanlder<T> handler)
	{
		return default(bool);
	}

	[Token(Token = "0x601A3BF")]
	[Address(RVA = "0x332B758", Offset = "0x332B758", VA = "0x332B758", Slot = "5")]
	public void SyncReplicationData(FastBinaryReader reader)
	{
	}

	[Token(Token = "0x601A3C0")]
	public T GetData<T>(uint varID)
	{
		return (T)null;
	}

	[Token(Token = "0x601A3C1")]
	public bool SetData<T>(uint varID, T value)
	{
		return default(bool);
	}

	[Token(Token = "0x601A3C2")]
	private bool CheckType<T>(T initValue, out EReplicationInfoGroup groupID)
	{
		return default(bool);
	}
}
