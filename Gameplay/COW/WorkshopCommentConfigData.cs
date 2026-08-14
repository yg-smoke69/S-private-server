using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000271")]
public class WorkshopCommentConfigData : CSVBaseData
{
	[Token(Token = "0x4000EDD")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000EDE")]
	[FieldOffset(Offset = "0xC")]
	public uint Type;

	[Token(Token = "0x4000EDF")]
	[FieldOffset(Offset = "0x10")]
	public string Key;

	[Token(Token = "0x4000EE0")]
	[FieldOffset(Offset = "0x14")]
	public uint Group;

	[Token(Token = "0x4000EE1")]
	[FieldOffset(Offset = "0x18")]
	public uint Rank;

	[Token(Token = "0x6000BF7")]
	[Address(RVA = "0x21BDBB0", Offset = "0x21BDBB0", VA = "0x21BDBB0")]
	public WorkshopCommentConfigData()
	{
	}

	[Token(Token = "0x6000BF8")]
	[Address(RVA = "0x21BDC34", Offset = "0x21BDC34", VA = "0x21BDC34", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BF9")]
	[Address(RVA = "0x21BDC98", Offset = "0x21BDC98", VA = "0x21BDC98", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
