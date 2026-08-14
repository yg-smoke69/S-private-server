using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000BC")]
public class MaterialDataList : CSVBaseData, _Attribute
{
	[Token(Token = "0x4000494")]
	[FieldOffset(Offset = "0x8")]
	public uint backpackID;

	[Token(Token = "0x4000495")]
	[FieldOffset(Offset = "0xC")]
	public uint[] refIDs;

	[Token(Token = "0x600054F")]
	[Address(RVA = "0x1546190", Offset = "0x1546190", VA = "0x1546190")]
	public MaterialDataList()
	{
	}

	[Token(Token = "0x6000550")]
	[Address(RVA = "0x1546230", Offset = "0x1546230", VA = "0x1546230", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000551")]
	[Address(RVA = "0x1546294", Offset = "0x1546294", VA = "0x1546294", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x6000552")]
	[Address(RVA = "0x15462EC", Offset = "0x15462EC", VA = "0x15462EC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
