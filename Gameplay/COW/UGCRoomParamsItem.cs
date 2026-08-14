using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2000865")]
public class UGCRoomParamsItem : CSVBaseData, _Attribute
{
	[Token(Token = "0x4005284")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4005285")]
	[FieldOffset(Offset = "0xC")]
	public string Name;

	[Token(Token = "0x4005286")]
	[FieldOffset(Offset = "0x10")]
	public OHAAMABDKEN Type;

	[Token(Token = "0x6003AC9")]
	[Address(RVA = "0x29F5798", Offset = "0x29F5798", VA = "0x29F5798")]
	public UGCRoomParamsItem()
	{
	}

	[Token(Token = "0x6003ACA")]
	[Address(RVA = "0x29F5824", Offset = "0x29F5824", VA = "0x29F5824", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x6003ACB")]
	[Address(RVA = "0x29F587C", Offset = "0x29F587C", VA = "0x29F587C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6003ACC")]
	[Address(RVA = "0x29F5920", Offset = "0x29F5920", VA = "0x29F5920", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
