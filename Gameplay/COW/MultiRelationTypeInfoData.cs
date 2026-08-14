using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001B1")]
public class MultiRelationTypeInfoData : CSVBaseData
{
	[Token(Token = "0x4000A72")]
	public const string PRIMARYKEY = "KEY";

	[Token(Token = "0x4000A73")]
	[FieldOffset(Offset = "0x8")]
	public string TrainingCampTitle;

	[Token(Token = "0x4000A74")]
	[FieldOffset(Offset = "0xC")]
	public string RelationType1;

	[Token(Token = "0x4000A75")]
	[FieldOffset(Offset = "0x10")]
	public string RelationType2;

	[Token(Token = "0x4000A76")]
	[FieldOffset(Offset = "0x14")]
	public string RelationBgUrl;

	[Token(Token = "0x4000A77")]
	[FieldOffset(Offset = "0x18")]
	public string RelationApplyUrl;

	[Token(Token = "0x6000945")]
	[Address(RVA = "0x2290098", Offset = "0x2290098", VA = "0x2290098")]
	public MultiRelationTypeInfoData()
	{
	}

	[Token(Token = "0x6000946")]
	[Address(RVA = "0x229011C", Offset = "0x229011C", VA = "0x229011C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000947")]
	[Address(RVA = "0x22901C0", Offset = "0x22901C0", VA = "0x22901C0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
