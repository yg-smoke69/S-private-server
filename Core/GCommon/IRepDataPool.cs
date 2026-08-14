using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004083")]
public interface IRepDataPool
{
	[Token(Token = "0x601A3C3")]
	bool AddData(uint varID, sbyte initValue, [Optional] DataChangedHanlder<sbyte> onChange);

	[Token(Token = "0x601A3C4")]
	bool AddData(uint varID, byte initValue, [Optional] DataChangedHanlder<byte> onChange);

	[Token(Token = "0x601A3C5")]
	bool AddData(uint varID, short initValue, [Optional] DataChangedHanlder<short> onChange);

	[Token(Token = "0x601A3C6")]
	bool AddData(uint varID, ushort initValue, [Optional] DataChangedHanlder<ushort> onChange);

	[Token(Token = "0x601A3C7")]
	bool AddData(uint varID, int initValue, [Optional] DataChangedHanlder<int> onChange);

	[Token(Token = "0x601A3C8")]
	bool AddData(uint varID, uint initValue, [Optional] DataChangedHanlder<uint> onChange);

	[Token(Token = "0x601A3C9")]
	bool AddData(uint varID, long initValue, [Optional] DataChangedHanlder<long> onChange);

	[Token(Token = "0x601A3CA")]
	bool AddData(uint varID, ulong initValue, [Optional] DataChangedHanlder<ulong> onChange);

	[Token(Token = "0x601A3CB")]
	bool AddData(uint varID, float initValue, [Optional] DataChangedHanlder<float> onChange);

	[Token(Token = "0x601A3CC")]
	bool AddData(uint varID, bool initValue, [Optional] DataChangedHanlder<bool> onChange);

	[Token(Token = "0x601A3CD")]
	sbyte GetDataInt8(uint varID);

	[Token(Token = "0x601A3CE")]
	byte GetDataUInt8(uint varID);

	[Token(Token = "0x601A3CF")]
	short GetDataInt16(uint varID);

	[Token(Token = "0x601A3D0")]
	ushort GetDataUInt16(uint varID);

	[Token(Token = "0x601A3D1")]
	int GetDataInt32(uint varID);

	[Token(Token = "0x601A3D2")]
	uint GetDataUInt32(uint varID);

	[Token(Token = "0x601A3D3")]
	long GetDataInt64(uint varID);

	[Token(Token = "0x601A3D4")]
	ulong GetDataUInt64(uint varID);

	[Token(Token = "0x601A3D5")]
	bool GetDataBool(uint varID);

	[Token(Token = "0x601A3D6")]
	float GetDataFloat32(uint varID);

	[Token(Token = "0x601A3D7")]
	bool SetData(uint varID, byte newValue);

	[Token(Token = "0x601A3D8")]
	bool SetData(uint varID, sbyte newValue);

	[Token(Token = "0x601A3D9")]
	bool SetData(uint varID, short newValue);

	[Token(Token = "0x601A3DA")]
	bool SetData(uint varID, ushort newValue);

	[Token(Token = "0x601A3DB")]
	bool SetData(uint varID, int newValue);

	[Token(Token = "0x601A3DC")]
	bool SetData(uint varID, uint newValue);

	[Token(Token = "0x601A3DD")]
	bool SetData(uint varID, long newValue);

	[Token(Token = "0x601A3DE")]
	bool SetData(uint varID, ulong newValue);

	[Token(Token = "0x601A3DF")]
	bool SetData(uint varID, bool newValue);

	[Token(Token = "0x601A3E0")]
	bool SetData(uint varID, float newValue);

	[Token(Token = "0x601A3E1")]
	void SyncReplicationData(FastBinaryReader reader);

	[Token(Token = "0x601A3E2")]
	void Clear();
}
