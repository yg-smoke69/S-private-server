using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001A8")]
public class MetaTemplateConfigData : CSVBaseData
{
	[Token(Token = "0x4000A42")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000A43")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID PrefabResID;

	[Token(Token = "0x4000A44")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID SpawnSfxID;

	[Token(Token = "0x6000927")]
	[Address(RVA = "0x22766D0", Offset = "0x22766D0", VA = "0x22766D0")]
	public MetaTemplateConfigData()
	{
	}

	[Token(Token = "0x6000928")]
	[Address(RVA = "0x22767A8", Offset = "0x22767A8", VA = "0x22767A8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000929")]
	[Address(RVA = "0x227680C", Offset = "0x227680C", VA = "0x227680C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
