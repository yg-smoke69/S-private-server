using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000127")]
public class EPUpdateData : CSVBaseData
{
	[Token(Token = "0x400078A")]
	[FieldOffset(Offset = "0x8")]
	public uint EpId;

	[Token(Token = "0x400078B")]
	[FieldOffset(Offset = "0xC")]
	public uint EpEntrance;

	[Token(Token = "0x400078C")]
	[FieldOffset(Offset = "0x10")]
	public uint EpQuest;

	[Token(Token = "0x400078D")]
	[FieldOffset(Offset = "0x14")]
	public uint EpBadge;

	[Token(Token = "0x400078E")]
	[FieldOffset(Offset = "0x18")]
	public uint EPDocument;

	[Token(Token = "0x6000730")]
	[Address(RVA = "0x251CBA8", Offset = "0x251CBA8", VA = "0x251CBA8")]
	public EPUpdateData()
	{
	}

	[Token(Token = "0x6000731")]
	[Address(RVA = "0x251CC2C", Offset = "0x251CC2C", VA = "0x251CC2C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000732")]
	[Address(RVA = "0x251CDEC", Offset = "0x251CDEC", VA = "0x251CDEC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000733")]
	[Address(RVA = "0x251CE50", Offset = "0x251CE50", VA = "0x251CE50")]
	public bool IsEntranceOpen(EEpEntrance type)
	{
		return default(bool);
	}
}
