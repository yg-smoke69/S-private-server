using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032A3")]
public class WorkshopModeTagData : CSVBaseData
{
	[Token(Token = "0x4013475")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4013476")]
	[FieldOffset(Offset = "0xC")]
	public string Comment;

	[Token(Token = "0x4013477")]
	[FieldOffset(Offset = "0x10")]
	public string TagKey;

	[Token(Token = "0x4013478")]
	[FieldOffset(Offset = "0x14")]
	public bool IsObsolete;

	[Token(Token = "0x4013479")]
	[FieldOffset(Offset = "0x18")]
	public int TagFilter;

	[Token(Token = "0x6015572")]
	[Address(RVA = "0x2303A44", Offset = "0x2303A44", VA = "0x2303A44")]
	public WorkshopModeTagData()
	{
	}

	[Token(Token = "0x6015573")]
	[Address(RVA = "0x2303AC8", Offset = "0x2303AC8", VA = "0x2303AC8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6015574")]
	[Address(RVA = "0x2303B2C", Offset = "0x2303B2C", VA = "0x2303B2C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
