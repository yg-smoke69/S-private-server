using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004086")]
public class PRIDataPool : ReplicationDataPool, _Attribute, IConvertible
{
	[Token(Token = "0x401B1FA")]
	[FieldOffset(Offset = "0x18")]
	protected ReplicationEntity m_Owner;

	[Token(Token = "0x401B1FB")]
	[FieldOffset(Offset = "0x1C")]
	protected uint m_ReplicationID;

	[Token(Token = "0x601A3EF")]
	[Address(RVA = "0x29810AC", Offset = "0x29810AC", VA = "0x29810AC")]
	public PRIDataPool(ReplicationEntity owner, uint repID, int maxVarCount)
	{
	}

	[Token(Token = "0x601A3F0")]
	[Address(RVA = "0x29810D8", Offset = "0x29810D8", VA = "0x29810D8", Slot = "6")]
	public uint GetReplicationID()
	{
		return default(uint);
	}

	[Token(Token = "0x601A3F1")]
	[Address(RVA = "0x29810E0", Offset = "0x29810E0", VA = "0x29810E0", Slot = "38")]
	public void Clear()
	{
	}

	[Token(Token = "0x601A3F2")]
	[Address(RVA = "0x29810E4", Offset = "0x29810E4", VA = "0x29810E4", Slot = "7")]
	public bool AddData(uint varID, sbyte initValue, [Optional] DataChangedHanlder<sbyte> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A3F3")]
	[Address(RVA = "0x298116C", Offset = "0x298116C", VA = "0x298116C", Slot = "8")]
	public bool AddData(uint varID, byte initValue, [Optional] DataChangedHanlder<byte> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A3F4")]
	[Address(RVA = "0x29811F4", Offset = "0x29811F4", VA = "0x29811F4", Slot = "9")]
	public bool AddData(uint varID, short initValue, [Optional] DataChangedHanlder<short> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A3F5")]
	[Address(RVA = "0x298127C", Offset = "0x298127C", VA = "0x298127C", Slot = "10")]
	public bool AddData(uint varID, ushort initValue, [Optional] DataChangedHanlder<ushort> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A3F6")]
	[Address(RVA = "0x2981304", Offset = "0x2981304", VA = "0x2981304", Slot = "11")]
	public bool AddData(uint varID, int initValue, [Optional] DataChangedHanlder<int> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A3F7")]
	[Address(RVA = "0x298138C", Offset = "0x298138C", VA = "0x298138C", Slot = "12")]
	public bool AddData(uint varID, uint initValue, [Optional] DataChangedHanlder<uint> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A3F8")]
	[Address(RVA = "0x2981414", Offset = "0x2981414", VA = "0x2981414", Slot = "13")]
	public bool AddData(uint varID, long initValue, [Optional] DataChangedHanlder<long> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A3F9")]
	[Address(RVA = "0x29814A4", Offset = "0x29814A4", VA = "0x29814A4", Slot = "14")]
	public bool AddData(uint varID, ulong initValue, [Optional] DataChangedHanlder<ulong> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A3FA")]
	[Address(RVA = "0x2981534", Offset = "0x2981534", VA = "0x2981534", Slot = "15")]
	public bool AddData(uint varID, float initValue, [Optional] DataChangedHanlder<float> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A3FB")]
	[Address(RVA = "0x29815BC", Offset = "0x29815BC", VA = "0x29815BC", Slot = "16")]
	public bool AddData(uint varID, bool initValue, [Optional] DataChangedHanlder<bool> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A3FC")]
	[Address(RVA = "0x2981644", Offset = "0x2981644", VA = "0x2981644", Slot = "17")]
	public sbyte GetDataInt8(uint varID)
	{
		return default(sbyte);
	}

	[Token(Token = "0x601A3FD")]
	[Address(RVA = "0x29816B0", Offset = "0x29816B0", VA = "0x29816B0", Slot = "18")]
	public byte GetDataUInt8(uint varID)
	{
		return default(byte);
	}

	[Token(Token = "0x601A3FE")]
	[Address(RVA = "0x298171C", Offset = "0x298171C", VA = "0x298171C", Slot = "19")]
	public short GetDataInt16(uint varID)
	{
		return default(short);
	}

	[Token(Token = "0x601A3FF")]
	[Address(RVA = "0x2981788", Offset = "0x2981788", VA = "0x2981788", Slot = "20")]
	public ushort GetDataUInt16(uint varID)
	{
		return default(ushort);
	}

	[Token(Token = "0x601A400")]
	[Address(RVA = "0x29817F4", Offset = "0x29817F4", VA = "0x29817F4", Slot = "21")]
	public int GetDataInt32(uint varID)
	{
		return default(int);
	}

	[Token(Token = "0x601A401")]
	[Address(RVA = "0x2981860", Offset = "0x2981860", VA = "0x2981860", Slot = "22")]
	public uint GetDataUInt32(uint varID)
	{
		return default(uint);
	}

	[Token(Token = "0x601A402")]
	[Address(RVA = "0x29818CC", Offset = "0x29818CC", VA = "0x29818CC", Slot = "23")]
	public long GetDataInt64(uint varID)
	{
		return default(long);
	}

	[Token(Token = "0x601A403")]
	[Address(RVA = "0x2981938", Offset = "0x2981938", VA = "0x2981938", Slot = "24")]
	public ulong GetDataUInt64(uint varID)
	{
		return default(ulong);
	}

	[Token(Token = "0x601A404")]
	[Address(RVA = "0x29819A4", Offset = "0x29819A4", VA = "0x29819A4", Slot = "25")]
	public bool GetDataBool(uint varID)
	{
		return default(bool);
	}

	[Token(Token = "0x601A405")]
	[Address(RVA = "0x2981A10", Offset = "0x2981A10", VA = "0x2981A10", Slot = "26")]
	public float GetDataFloat32(uint varID)
	{
		return default(float);
	}

	[Token(Token = "0x601A406")]
	[Address(RVA = "0x2981A7C", Offset = "0x2981A7C", VA = "0x2981A7C", Slot = "27")]
	public bool SetData(uint varID, byte newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A407")]
	[Address(RVA = "0x2981AF0", Offset = "0x2981AF0", VA = "0x2981AF0", Slot = "28")]
	public bool SetData(uint varID, sbyte newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A408")]
	[Address(RVA = "0x2981B64", Offset = "0x2981B64", VA = "0x2981B64", Slot = "29")]
	public bool SetData(uint varID, short newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A409")]
	[Address(RVA = "0x2981BD8", Offset = "0x2981BD8", VA = "0x2981BD8", Slot = "30")]
	public bool SetData(uint varID, ushort newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A40A")]
	[Address(RVA = "0x2981C4C", Offset = "0x2981C4C", VA = "0x2981C4C", Slot = "31")]
	public bool SetData(uint varID, int newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A40B")]
	[Address(RVA = "0x2981CC0", Offset = "0x2981CC0", VA = "0x2981CC0", Slot = "32")]
	public bool SetData(uint varID, uint newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A40C")]
	[Address(RVA = "0x2981D34", Offset = "0x2981D34", VA = "0x2981D34", Slot = "33")]
	public bool SetData(uint varID, long newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A40D")]
	[Address(RVA = "0x2981DBC", Offset = "0x2981DBC", VA = "0x2981DBC", Slot = "34")]
	public bool SetData(uint varID, ulong newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A40E")]
	[Address(RVA = "0x2981E44", Offset = "0x2981E44", VA = "0x2981E44", Slot = "35")]
	public bool SetData(uint varID, bool newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A40F")]
	[Address(RVA = "0x2981EB8", Offset = "0x2981EB8", VA = "0x2981EB8", Slot = "36")]
	public bool SetData(uint varID, float newValue)
	{
		return default(bool);
	}
}
