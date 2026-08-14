using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000F5")]
public class PinData : CSVBaseData, _Attribute
{
	[Token(Token = "0x4000639")]
	[FieldOffset(Offset = "0x8")]
	public uint iID;

	[Token(Token = "0x400063A")]
	[FieldOffset(Offset = "0xC")]
	public uint sortId;

	[Token(Token = "0x400063B")]
	[FieldOffset(Offset = "0x10")]
	public EPinSourceType sourceType;

	[Token(Token = "0x6000627")]
	[Address(RVA = "0x1C05990", Offset = "0x1C05990", VA = "0x1C05990")]
	public PinData()
	{
	}

	[Token(Token = "0x6000628")]
	[Address(RVA = "0x1C05A14", Offset = "0x1C05A14", VA = "0x1C05A14", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x6000629")]
	[Address(RVA = "0x1C05A6C", Offset = "0x1C05A6C", VA = "0x1C05A6C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600062A")]
	[Address(RVA = "0x1C05AD0", Offset = "0x1C05AD0", VA = "0x1C05AD0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
