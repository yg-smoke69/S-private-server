using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x20000D6")]
public class ClanTagData : CSVBaseData
{
	[Token(Token = "0x400051A")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x400051B")]
	[FieldOffset(Offset = "0xC")]
	public string Tag;

	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x230E784", Offset = "0x230E784", VA = "0x230E784")]
	public ClanTagData()
	{
	}

	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x230E808", Offset = "0x230E808", VA = "0x230E808", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x230E814", Offset = "0x230E814", VA = "0x230E814", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
