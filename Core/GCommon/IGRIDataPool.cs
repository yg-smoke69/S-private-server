using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004085")]
public interface IGRIDataPool : _Attribute
{
	[Token(Token = "0x601A3E4")]
	void AppendSize(int appendSize);

	[Token(Token = "0x601A3E5")]
	void RegisterDataChangedHandlerInt8(uint varID, DataChangedHanlder<sbyte> onChange);

	[Token(Token = "0x601A3E6")]
	void RegisterDataChangedHandlerUInt8(uint varID, DataChangedHanlder<byte> onChange);

	[Token(Token = "0x601A3E7")]
	void RegisterDataChangedHandlerInt16(uint varID, DataChangedHanlder<short> onChange);

	[Token(Token = "0x601A3E8")]
	void RegisterDataChangedHandlerUInt16(uint varID, DataChangedHanlder<ushort> onChange);

	[Token(Token = "0x601A3E9")]
	void RegisterDataChangedHandlerInt32(uint varID, DataChangedHanlder<int> onChange);

	[Token(Token = "0x601A3EA")]
	void RegisterDataChangedHandlerUInt32(uint varID, DataChangedHanlder<uint> onChange);

	[Token(Token = "0x601A3EB")]
	void RegisterDataChangedHandlerInt64(uint varID, DataChangedHanlder<long> onChange);

	[Token(Token = "0x601A3EC")]
	void RegisterDataChangedHandlerUInt64(uint varID, DataChangedHanlder<ulong> onChange);

	[Token(Token = "0x601A3ED")]
	void RegisterDataChangedHandlerFloat32(uint varID, DataChangedHanlder<float> onChange);

	[Token(Token = "0x601A3EE")]
	void RegisterDataChangedHandlerBool(uint varID, DataChangedHanlder<bool> onChange);
}
