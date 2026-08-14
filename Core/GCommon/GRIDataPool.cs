using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004087")]
public class GRIDataPool : ReplicationDataPool, _Attribute, IConvertible
{
	[Token(Token = "0x601A410")]
	[Address(RVA = "0x32AEB18", Offset = "0x32AEB18", VA = "0x32AEB18")]
	public GRIDataPool(int maxVarCount)
	{
	}

	[Token(Token = "0x601A411")]
	[Address(RVA = "0x32AEB20", Offset = "0x32AEB20", VA = "0x32AEB20", Slot = "48")]
	public void Clear()
	{
	}

	[Token(Token = "0x601A412")]
	[Address(RVA = "0x32AEB24", Offset = "0x32AEB24", VA = "0x32AEB24", Slot = "17")]
	public bool AddData(uint varID, sbyte initValue, [Optional] DataChangedHanlder<sbyte> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A413")]
	[Address(RVA = "0x32AEBAC", Offset = "0x32AEBAC", VA = "0x32AEBAC", Slot = "18")]
	public bool AddData(uint varID, byte initValue, [Optional] DataChangedHanlder<byte> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A414")]
	[Address(RVA = "0x32AEC34", Offset = "0x32AEC34", VA = "0x32AEC34", Slot = "19")]
	public bool AddData(uint varID, short initValue, [Optional] DataChangedHanlder<short> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A415")]
	[Address(RVA = "0x32AECBC", Offset = "0x32AECBC", VA = "0x32AECBC", Slot = "20")]
	public bool AddData(uint varID, ushort initValue, [Optional] DataChangedHanlder<ushort> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A416")]
	[Address(RVA = "0x32AED44", Offset = "0x32AED44", VA = "0x32AED44", Slot = "21")]
	public bool AddData(uint varID, int initValue, [Optional] DataChangedHanlder<int> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A417")]
	[Address(RVA = "0x32AEDCC", Offset = "0x32AEDCC", VA = "0x32AEDCC", Slot = "22")]
	public bool AddData(uint varID, uint initValue, [Optional] DataChangedHanlder<uint> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A418")]
	[Address(RVA = "0x32AEE54", Offset = "0x32AEE54", VA = "0x32AEE54", Slot = "23")]
	public bool AddData(uint varID, long initValue, [Optional] DataChangedHanlder<long> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A419")]
	[Address(RVA = "0x32AEEE4", Offset = "0x32AEEE4", VA = "0x32AEEE4", Slot = "24")]
	public bool AddData(uint varID, ulong initValue, [Optional] DataChangedHanlder<ulong> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A41A")]
	[Address(RVA = "0x32AEF74", Offset = "0x32AEF74", VA = "0x32AEF74", Slot = "25")]
	public bool AddData(uint varID, float initValue, [Optional] DataChangedHanlder<float> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A41B")]
	[Address(RVA = "0x32AEFFC", Offset = "0x32AEFFC", VA = "0x32AEFFC", Slot = "26")]
	public bool AddData(uint varID, bool initValue, [Optional] DataChangedHanlder<bool> onChange)
	{
		return default(bool);
	}

	[Token(Token = "0x601A41C")]
	[Address(RVA = "0x32AF084", Offset = "0x32AF084", VA = "0x32AF084", Slot = "7")]
	public void RegisterDataChangedHandlerInt8(uint varID, DataChangedHanlder<sbyte> onChange)
	{
	}

	[Token(Token = "0x601A41D")]
	[Address(RVA = "0x32AF0F8", Offset = "0x32AF0F8", VA = "0x32AF0F8", Slot = "8")]
	public void RegisterDataChangedHandlerUInt8(uint varID, DataChangedHanlder<byte> onChange)
	{
	}

	[Token(Token = "0x601A41E")]
	[Address(RVA = "0x32AF16C", Offset = "0x32AF16C", VA = "0x32AF16C", Slot = "9")]
	public void RegisterDataChangedHandlerInt16(uint varID, DataChangedHanlder<short> onChange)
	{
	}

	[Token(Token = "0x601A41F")]
	[Address(RVA = "0x32AF1E0", Offset = "0x32AF1E0", VA = "0x32AF1E0", Slot = "10")]
	public void RegisterDataChangedHandlerUInt16(uint varID, DataChangedHanlder<ushort> onChange)
	{
	}

	[Token(Token = "0x601A420")]
	[Address(RVA = "0x32AF254", Offset = "0x32AF254", VA = "0x32AF254", Slot = "11")]
	public void RegisterDataChangedHandlerInt32(uint varID, DataChangedHanlder<int> onChange)
	{
	}

	[Token(Token = "0x601A421")]
	[Address(RVA = "0x32AF2C8", Offset = "0x32AF2C8", VA = "0x32AF2C8", Slot = "12")]
	public void RegisterDataChangedHandlerUInt32(uint varID, DataChangedHanlder<uint> onChange)
	{
	}

	[Token(Token = "0x601A422")]
	[Address(RVA = "0x32AF33C", Offset = "0x32AF33C", VA = "0x32AF33C", Slot = "13")]
	public void RegisterDataChangedHandlerInt64(uint varID, DataChangedHanlder<long> onChange)
	{
	}

	[Token(Token = "0x601A423")]
	[Address(RVA = "0x32AF3B0", Offset = "0x32AF3B0", VA = "0x32AF3B0", Slot = "14")]
	public void RegisterDataChangedHandlerUInt64(uint varID, DataChangedHanlder<ulong> onChange)
	{
	}

	[Token(Token = "0x601A424")]
	[Address(RVA = "0x32AF424", Offset = "0x32AF424", VA = "0x32AF424", Slot = "15")]
	public void RegisterDataChangedHandlerFloat32(uint varID, DataChangedHanlder<float> onChange)
	{
	}

	[Token(Token = "0x601A425")]
	[Address(RVA = "0x32AF498", Offset = "0x32AF498", VA = "0x32AF498", Slot = "16")]
	public void RegisterDataChangedHandlerBool(uint varID, DataChangedHanlder<bool> onChange)
	{
	}

	[Token(Token = "0x601A426")]
	[Address(RVA = "0x32AF50C", Offset = "0x32AF50C", VA = "0x32AF50C", Slot = "27")]
	public sbyte GetDataInt8(uint varID)
	{
		return default(sbyte);
	}

	[Token(Token = "0x601A427")]
	[Address(RVA = "0x32AF578", Offset = "0x32AF578", VA = "0x32AF578", Slot = "28")]
	public byte GetDataUInt8(uint varID)
	{
		return default(byte);
	}

	[Token(Token = "0x601A428")]
	[Address(RVA = "0x32AF5E4", Offset = "0x32AF5E4", VA = "0x32AF5E4", Slot = "29")]
	public short GetDataInt16(uint varID)
	{
		return default(short);
	}

	[Token(Token = "0x601A429")]
	[Address(RVA = "0x32AF650", Offset = "0x32AF650", VA = "0x32AF650", Slot = "30")]
	public ushort GetDataUInt16(uint varID)
	{
		return default(ushort);
	}

	[Token(Token = "0x601A42A")]
	[Address(RVA = "0x32AF6BC", Offset = "0x32AF6BC", VA = "0x32AF6BC", Slot = "31")]
	public int GetDataInt32(uint varID)
	{
		return default(int);
	}

	[Token(Token = "0x601A42B")]
	[Address(RVA = "0x32AF728", Offset = "0x32AF728", VA = "0x32AF728", Slot = "32")]
	public uint GetDataUInt32(uint varID)
	{
		return default(uint);
	}

	[Token(Token = "0x601A42C")]
	[Address(RVA = "0x32AF794", Offset = "0x32AF794", VA = "0x32AF794", Slot = "33")]
	public long GetDataInt64(uint varID)
	{
		return default(long);
	}

	[Token(Token = "0x601A42D")]
	[Address(RVA = "0x32AF800", Offset = "0x32AF800", VA = "0x32AF800", Slot = "34")]
	public ulong GetDataUInt64(uint varID)
	{
		return default(ulong);
	}

	[Token(Token = "0x601A42E")]
	[Address(RVA = "0x32AF86C", Offset = "0x32AF86C", VA = "0x32AF86C", Slot = "35")]
	public bool GetDataBool(uint varID)
	{
		return default(bool);
	}

	[Token(Token = "0x601A42F")]
	[Address(RVA = "0x32AF8D8", Offset = "0x32AF8D8", VA = "0x32AF8D8", Slot = "36")]
	public float GetDataFloat32(uint varID)
	{
		return default(float);
	}

	[Token(Token = "0x601A430")]
	[Address(RVA = "0x32AF944", Offset = "0x32AF944", VA = "0x32AF944", Slot = "37")]
	public bool SetData(uint varID, byte newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A431")]
	[Address(RVA = "0x32AF9B8", Offset = "0x32AF9B8", VA = "0x32AF9B8", Slot = "38")]
	public bool SetData(uint varID, sbyte newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A432")]
	[Address(RVA = "0x32AFA2C", Offset = "0x32AFA2C", VA = "0x32AFA2C", Slot = "39")]
	public bool SetData(uint varID, short newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A433")]
	[Address(RVA = "0x32AFAA0", Offset = "0x32AFAA0", VA = "0x32AFAA0", Slot = "40")]
	public bool SetData(uint varID, ushort newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A434")]
	[Address(RVA = "0x32AFB14", Offset = "0x32AFB14", VA = "0x32AFB14", Slot = "41")]
	public bool SetData(uint varID, int newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A435")]
	[Address(RVA = "0x32AFB88", Offset = "0x32AFB88", VA = "0x32AFB88", Slot = "42")]
	public bool SetData(uint varID, uint newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A436")]
	[Address(RVA = "0x32AFBFC", Offset = "0x32AFBFC", VA = "0x32AFBFC", Slot = "43")]
	public bool SetData(uint varID, long newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A437")]
	[Address(RVA = "0x32AFC84", Offset = "0x32AFC84", VA = "0x32AFC84", Slot = "44")]
	public bool SetData(uint varID, ulong newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A438")]
	[Address(RVA = "0x32AFD0C", Offset = "0x32AFD0C", VA = "0x32AFD0C", Slot = "45")]
	public bool SetData(uint varID, bool newValue)
	{
		return default(bool);
	}

	[Token(Token = "0x601A439")]
	[Address(RVA = "0x32AFD80", Offset = "0x32AFD80", VA = "0x32AFD80", Slot = "46")]
	public bool SetData(uint varID, float newValue)
	{
		return default(bool);
	}
}
