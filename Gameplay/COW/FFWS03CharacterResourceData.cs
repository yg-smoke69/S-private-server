using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000131")]
public class FFWS03CharacterResourceData : CSVBaseData
{
	[Token(Token = "0x40007CD")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x40007CE")]
	[FieldOffset(Offset = "0xC")]
	public string Key;

	[Token(Token = "0x40007CF")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID Icon;

	[Token(Token = "0x600075D")]
	[Address(RVA = "0x2300FF4", Offset = "0x2300FF4", VA = "0x2300FF4")]
	public FFWS03CharacterResourceData()
	{
	}

	[Token(Token = "0x600075E")]
	[Address(RVA = "0x2301078", Offset = "0x2301078", VA = "0x2301078", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x600075F")]
	[Address(RVA = "0x2301230", Offset = "0x2301230", VA = "0x2301230", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}
}
