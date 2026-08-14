using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000136")]
public class FourSymbolsAttributesInfoData : CSVBaseData
{
	[Token(Token = "0x40007E3")]
	[FieldOffset(Offset = "0x8")]
	public uint AttributeId;

	[Token(Token = "0x40007E4")]
	[FieldOffset(Offset = "0xC")]
	public string Desc;

	[Token(Token = "0x40007E5")]
	[FieldOffset(Offset = "0x10")]
	public uint Camp;

	[Token(Token = "0x6000788")]
	[Address(RVA = "0xDEBFD4", Offset = "0xDEBFD4", VA = "0xDEBFD4")]
	public FourSymbolsAttributesInfoData()
	{
	}

	[Token(Token = "0x6000789")]
	[Address(RVA = "0xDEF7C0", Offset = "0xDEF7C0", VA = "0xDEF7C0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600078A")]
	[Address(RVA = "0xDEF824", Offset = "0xDEF824", VA = "0xDEF824", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
