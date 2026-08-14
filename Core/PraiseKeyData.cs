using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x2000205")]
public class PraiseKeyData : CSVBaseData
{
	[Token(Token = "0x4000BFD")]
	[FieldOffset(Offset = "0x8")]
	public int Index;

	[Token(Token = "0x4000BFE")]
	[FieldOffset(Offset = "0xC")]
	public string Key;

	[Token(Token = "0x6000A73")]
	[Address(RVA = "0x1E286C8", Offset = "0x1E286C8", VA = "0x1E286C8")]
	public PraiseKeyData()
	{
	}

	[Token(Token = "0x6000A74")]
	[Address(RVA = "0x1E2874C", Offset = "0x1E2874C", VA = "0x1E2874C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A75")]
	[Address(RVA = "0x1E28758", Offset = "0x1E28758", VA = "0x1E28758", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
