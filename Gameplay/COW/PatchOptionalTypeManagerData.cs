using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001D2")]
public class PatchOptionalTypeManagerData : CSVBaseData
{
	[Token(Token = "0x4000B18")]
	[FieldOffset(Offset = "0x8")]
	public uint TypeId;

	[Token(Token = "0x4000B19")]
	[FieldOffset(Offset = "0xC")]
	public uint SortId;

	[Token(Token = "0x4000B1A")]
	[FieldOffset(Offset = "0x10")]
	public bool IsRecommend;

	[Token(Token = "0x4000B1B")]
	[FieldOffset(Offset = "0x14")]
	public string TypeKey;

	[Token(Token = "0x4000B1C")]
	[FieldOffset(Offset = "0x18")]
	public uint ShowModelType;

	[Token(Token = "0x60009C2")]
	[Address(RVA = "0x2DBD120", Offset = "0x2DBD120", VA = "0x2DBD120")]
	public PatchOptionalTypeManagerData()
	{
	}

	[Token(Token = "0x60009C3")]
	[Address(RVA = "0x2DBD1A4", Offset = "0x2DBD1A4", VA = "0x2DBD1A4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60009C4")]
	[Address(RVA = "0x2DBD208", Offset = "0x2DBD208", VA = "0x2DBD208", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
