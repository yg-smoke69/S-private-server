using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000A1")]
public class AudioEventMappingData : CSVBaseData
{
	[Token(Token = "0x4000388")]
	[FieldOffset(Offset = "0x8")]
	public string AudioResIDName;

	[Token(Token = "0x4000389")]
	[FieldOffset(Offset = "0xC")]
	public string EventResIDName;

	[Token(Token = "0x400038A")]
	[FieldOffset(Offset = "0x10")]
	public string LangSuffix;

	[Token(Token = "0x400038B")]
	[FieldOffset(Offset = "0x14")]
	public int ID;

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x14D219C", Offset = "0x14D219C", VA = "0x14D219C")]
	public AudioEventMappingData()
	{
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x14D2220", Offset = "0x14D2220", VA = "0x14D2220", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0x14D2284", Offset = "0x14D2284", VA = "0x14D2284", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
