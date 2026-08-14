using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001D4")]
public class PatchOptionalCategoryManagerData : CSVBaseData
{
	[Token(Token = "0x4000B22")]
	[FieldOffset(Offset = "0x8")]
	public uint OptionalReDefId;

	[Token(Token = "0x4000B23")]
	[FieldOffset(Offset = "0xC")]
	public uint Type;

	[Token(Token = "0x4000B24")]
	[FieldOffset(Offset = "0x10")]
	public uint SortId;

	[Token(Token = "0x4000B25")]
	[FieldOffset(Offset = "0x14")]
	public OptionalDownloadClientType ClientType;

	[Token(Token = "0x4000B26")]
	[FieldOffset(Offset = "0x18")]
	public uint ModelType;

	[Token(Token = "0x4000B27")]
	[FieldOffset(Offset = "0x1C")]
	public string OptionalResTitle;

	[Token(Token = "0x4000B28")]
	[FieldOffset(Offset = "0x20")]
	public string OptionalResTips;

	[Token(Token = "0x4000B29")]
	[FieldOffset(Offset = "0x24")]
	public string OptionalResCDN;

	[Token(Token = "0x4000B2A")]
	[FieldOffset(Offset = "0x28")]
	public string OptionalResIcon;

	[Token(Token = "0x4000B2B")]
	[FieldOffset(Offset = "0x2C")]
	public RecommendLevel Tag;

	[Token(Token = "0x60009C8")]
	[Address(RVA = "0x28D2C4C", Offset = "0x28D2C4C", VA = "0x28D2C4C")]
	public PatchOptionalCategoryManagerData()
	{
	}

	[Token(Token = "0x60009C9")]
	[Address(RVA = "0x28D2CD0", Offset = "0x28D2CD0", VA = "0x28D2CD0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60009CA")]
	[Address(RVA = "0x28D2D34", Offset = "0x28D2D34", VA = "0x28D2D34", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
