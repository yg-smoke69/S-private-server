using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004089")]
public class ReplicationDataPoolUnsafe
{
	[Token(Token = "0x401B1FE")]
	[FieldOffset(Offset = "0x8")]
	protected ReplicationDataUnsafe[] m_Datas;

	[Token(Token = "0x401B1FF")]
	[FieldOffset(Offset = "0xC")]
	protected int m_MaxVarCount;

	[Token(Token = "0x401B200")]
	[FieldOffset(Offset = "0x10")]
	protected Dictionary<uint, DataChangedHanlder<sbyte>> m_Int8Handlers;

	[Token(Token = "0x401B201")]
	[FieldOffset(Offset = "0x14")]
	protected Dictionary<uint, DataChangedHanlder<byte>> m_UInt8Handlers;

	[Token(Token = "0x401B202")]
	[FieldOffset(Offset = "0x18")]
	protected Dictionary<uint, DataChangedHanlder<short>> m_Int16Handlers;

	[Token(Token = "0x401B203")]
	[FieldOffset(Offset = "0x1C")]
	protected Dictionary<uint, DataChangedHanlder<ushort>> m_UInt16Handlers;

	[Token(Token = "0x401B204")]
	[FieldOffset(Offset = "0x20")]
	protected Dictionary<uint, DataChangedHanlder<int>> m_Int32Handlers;

	[Token(Token = "0x401B205")]
	[FieldOffset(Offset = "0x24")]
	protected Dictionary<uint, DataChangedHanlder<uint>> m_UInt32Handlers;

	[Token(Token = "0x401B206")]
	[FieldOffset(Offset = "0x28")]
	protected Dictionary<uint, DataChangedHanlder<long>> m_Int64Handlers;

	[Token(Token = "0x401B207")]
	[FieldOffset(Offset = "0x2C")]
	protected Dictionary<uint, DataChangedHanlder<ulong>> m_UInt64Handlers;

	[Token(Token = "0x401B208")]
	[FieldOffset(Offset = "0x30")]
	protected Dictionary<uint, DataChangedHanlder<float>> m_Float32Handlers;

	[Token(Token = "0x401B209")]
	[FieldOffset(Offset = "0x34")]
	protected Dictionary<uint, DataChangedHanlder<bool>> m_BoolHandlers;

	[Token(Token = "0x601A43B")]
	[Address(RVA = "0x332BBF4", Offset = "0x332BBF4", VA = "0x332BBF4")]
	public ReplicationDataPoolUnsafe(int maxVarCount)
	{
	}

	[Token(Token = "0x601A43C")]
	[Address(RVA = "0x332BE78", Offset = "0x332BE78", VA = "0x332BE78", Slot = "4")]
	public void AppendSize(int appendSize)
	{
	}

	[Token(Token = "0x601A43D")]
	[Address(RVA = "0x332BF20", Offset = "0x332BF20", VA = "0x332BF20", Slot = "5")]
	public void Clear()
	{
	}

	[Token(Token = "0x601A43E")]
	[Address(RVA = "0x332C1EC", Offset = "0x332C1EC", VA = "0x332C1EC")]
	private bool CheckVarID(uint varID)
	{
		return default(bool);
	}

	[Token(Token = "0x601A43F")]
	[Address(RVA = "0x332C4C0", Offset = "0x332C4C0", VA = "0x332C4C0")]
	private bool CheckExistence(uint varID)
	{
		return default(bool);
	}

	[Token(Token = "0x601A440")]
	[Address(RVA = "0x332C60C", Offset = "0x332C60C", VA = "0x332C60C", Slot = "6")]
	public bool AddData(uint varID, sbyte initValue, [Optional] DataChangedHanlder<sbyte> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A441")]
	[Address(RVA = "0x332C7DC", Offset = "0x332C7DC", VA = "0x332C7DC", Slot = "7")]
	public bool AddData(uint varID, byte initValue, [Optional] DataChangedHanlder<byte> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A442")]
	[Address(RVA = "0x332C9A4", Offset = "0x332C9A4", VA = "0x332C9A4", Slot = "8")]
	public bool AddData(uint varID, short initValue, [Optional] DataChangedHanlder<short> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A443")]
	[Address(RVA = "0x332CB6C", Offset = "0x332CB6C", VA = "0x332CB6C", Slot = "9")]
	public bool AddData(uint varID, ushort initValue, [Optional] DataChangedHanlder<ushort> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A444")]
	[Address(RVA = "0x332CD30", Offset = "0x332CD30", VA = "0x332CD30", Slot = "10")]
	public bool AddData(uint varID, int initValue, [Optional] DataChangedHanlder<int> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A445")]
	[Address(RVA = "0x332CEF8", Offset = "0x332CEF8", VA = "0x332CEF8", Slot = "11")]
	public bool AddData(uint varID, uint initValue, [Optional] DataChangedHanlder<uint> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A446")]
	[Address(RVA = "0x332D0BC", Offset = "0x332D0BC", VA = "0x332D0BC", Slot = "12")]
	public bool AddData(uint varID, long initValue, [Optional] DataChangedHanlder<long> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A447")]
	[Address(RVA = "0x332D28C", Offset = "0x332D28C", VA = "0x332D28C", Slot = "13")]
	public bool AddData(uint varID, ulong initValue, [Optional] DataChangedHanlder<ulong> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A448")]
	[Address(RVA = "0x332D454", Offset = "0x332D454", VA = "0x332D454", Slot = "14")]
	public bool AddData(uint varID, float initValue, [Optional] DataChangedHanlder<float> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A449")]
	[Address(RVA = "0x332D624", Offset = "0x332D624", VA = "0x332D624", Slot = "15")]
	public bool AddData(uint varID, bool initValue, [Optional] DataChangedHanlder<bool> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A44A")]
	[Address(RVA = "0x332D7E8", Offset = "0x332D7E8", VA = "0x332D7E8", Slot = "16")]
	public void RegisterDataChangedHandlerInt8(uint varID, DataChangedHanlder<sbyte> onChange)
	{
	}

	[Token(Token = "0x601A44B")]
	[Address(RVA = "0x332D9B8", Offset = "0x332D9B8", VA = "0x332D9B8", Slot = "17")]
	public void RegisterDataChangedHandlerUInt8(uint varID, DataChangedHanlder<byte> onChange)
	{
	}

	[Token(Token = "0x601A44C")]
	[Address(RVA = "0x332DB88", Offset = "0x332DB88", VA = "0x332DB88", Slot = "18")]
	public void RegisterDataChangedHandlerInt16(uint varID, DataChangedHanlder<short> onChange)
	{
	}

	[Token(Token = "0x601A44D")]
	[Address(RVA = "0x332DD58", Offset = "0x332DD58", VA = "0x332DD58", Slot = "19")]
	public void RegisterDataChangedHandlerUInt16(uint varID, DataChangedHanlder<ushort> onChange)
	{
	}

	[Token(Token = "0x601A44E")]
	[Address(RVA = "0x332DF28", Offset = "0x332DF28", VA = "0x332DF28", Slot = "20")]
	public void RegisterDataChangedHandlerInt32(uint varID, DataChangedHanlder<int> onChange)
	{
	}

	[Token(Token = "0x601A44F")]
	[Address(RVA = "0x332E0F8", Offset = "0x332E0F8", VA = "0x332E0F8", Slot = "21")]
	public void RegisterDataChangedHandlerUInt32(uint varID, DataChangedHanlder<uint> onChange)
	{
	}

	[Token(Token = "0x601A450")]
	[Address(RVA = "0x332E2C8", Offset = "0x332E2C8", VA = "0x332E2C8", Slot = "22")]
	public void RegisterDataChangedHandlerInt64(uint varID, DataChangedHanlder<long> onChange)
	{
	}

	[Token(Token = "0x601A451")]
	[Address(RVA = "0x332E498", Offset = "0x332E498", VA = "0x332E498", Slot = "23")]
	public void RegisterDataChangedHandlerUInt64(uint varID, DataChangedHanlder<ulong> onChange)
	{
	}

	[Token(Token = "0x601A452")]
	[Address(RVA = "0x332E668", Offset = "0x332E668", VA = "0x332E668", Slot = "24")]
	public void RegisterDataChangedHandlerFloat32(uint varID, DataChangedHanlder<float> onChange)
	{
	}

	[Token(Token = "0x601A453")]
	[Address(RVA = "0x332E838", Offset = "0x332E838", VA = "0x332E838", Slot = "25")]
	public void RegisterDataChangedHandlerBool(uint varID, DataChangedHanlder<bool> onChange)
	{
	}

	[Token(Token = "0x601A454")]
	[Address(RVA = "0x332EA08", Offset = "0x332EA08", VA = "0x332EA08")]
	public unsafe void* GetData(uint varID)
	{
		//IL_0002: Expected I, but got O
		return (void*)unchecked((nint)null);
	}

	[Token(Token = "0x601A455")]
	[Address(RVA = "0x332EA70", Offset = "0x332EA70", VA = "0x332EA70", Slot = "26")]
	public sbyte GetDataInt8(uint varID)
	{
		return default(sbyte);
	}

	[Token(Token = "0x601A456")]
	[Address(RVA = "0x332EADC", Offset = "0x332EADC", VA = "0x332EADC", Slot = "27")]
	public byte GetDataUInt8(uint varID)
	{
		return default(byte);
	}

	[Token(Token = "0x601A457")]
	[Address(RVA = "0x332EB48", Offset = "0x332EB48", VA = "0x332EB48", Slot = "28")]
	public short GetDataInt16(uint varID)
	{
		return default(short);
	}

	[Token(Token = "0x601A458")]
	[Address(RVA = "0x332EBB4", Offset = "0x332EBB4", VA = "0x332EBB4", Slot = "29")]
	public ushort GetDataUInt16(uint varID)
	{
		return default(ushort);
	}

	[Token(Token = "0x601A459")]
	[Address(RVA = "0x332EC20", Offset = "0x332EC20", VA = "0x332EC20", Slot = "30")]
	public int GetDataInt32(uint varID)
	{
		return default(int);
	}

	[Token(Token = "0x601A45A")]
	[Address(RVA = "0x332EC8C", Offset = "0x332EC8C", VA = "0x332EC8C", Slot = "31")]
	public uint GetDataUInt32(uint varID)
	{
		return default(uint);
	}

	[Token(Token = "0x601A45B")]
	[Address(RVA = "0x332ECF8", Offset = "0x332ECF8", VA = "0x332ECF8", Slot = "32")]
	public long GetDataInt64(uint varID)
	{
		return default(long);
	}

	[Token(Token = "0x601A45C")]
	[Address(RVA = "0x332ED7C", Offset = "0x332ED7C", VA = "0x332ED7C", Slot = "33")]
	public ulong GetDataUInt64(uint varID)
	{
		return default(ulong);
	}

	[Token(Token = "0x601A45D")]
	[Address(RVA = "0x332EE00", Offset = "0x332EE00", VA = "0x332EE00", Slot = "34")]
	public bool GetDataBool(uint varID)
	{
		return default(bool);
	}

	[Token(Token = "0x601A45E")]
	[Address(RVA = "0x332EE78", Offset = "0x332EE78", VA = "0x332EE78", Slot = "35")]
	public float GetDataFloat32(uint varID)
	{
		return default(float);
	}

	[Token(Token = "0x601A45F")]
	[Address(RVA = "0x332EEF4", Offset = "0x332EEF4", VA = "0x332EEF4", Slot = "36")]
	public bool SetData(uint varID, byte newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A460")]
	[Address(RVA = "0x332F058", Offset = "0x332F058", VA = "0x332F058", Slot = "37")]
	public bool SetData(uint varID, sbyte newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A461")]
	[Address(RVA = "0x332F1C0", Offset = "0x332F1C0", VA = "0x332F1C0", Slot = "38")]
	public bool SetData(uint varID, short newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A462")]
	[Address(RVA = "0x332F328", Offset = "0x332F328", VA = "0x332F328", Slot = "39")]
	public bool SetData(uint varID, ushort newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A463")]
	[Address(RVA = "0x332F48C", Offset = "0x332F48C", VA = "0x332F48C", Slot = "40")]
	public bool SetData(uint varID, int newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A464")]
	[Address(RVA = "0x332F5F0", Offset = "0x332F5F0", VA = "0x332F5F0", Slot = "41")]
	public bool SetData(uint varID, uint newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A465")]
	[Address(RVA = "0x332F754", Offset = "0x332F754", VA = "0x332F754", Slot = "42")]
	public bool SetData(uint varID, long newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A466")]
	[Address(RVA = "0x332F8D8", Offset = "0x332F8D8", VA = "0x332F8D8", Slot = "43")]
	public bool SetData(uint varID, ulong newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A467")]
	[Address(RVA = "0x332FA5C", Offset = "0x332FA5C", VA = "0x332FA5C", Slot = "44")]
	public bool SetData(uint varID, bool newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A468")]
	[Address(RVA = "0x332FBD4", Offset = "0x332FBD4", VA = "0x332FBD4", Slot = "45")]
	public bool SetData(uint varID, float newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A469")]
	[Address(RVA = "0x332FD48", Offset = "0x332FD48", VA = "0x332FD48", Slot = "46")]
	public void SyncReplicationData(FastBinaryReader reader)
	{
	}
}
