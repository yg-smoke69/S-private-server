using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000152")]
public class HeroicMarkData : CSVBaseData
{
	[Token(Token = "0x400087E")]
	[FieldOffset(Offset = "0x8")]
	public uint Level;

	[Token(Token = "0x400087F")]
	[FieldOffset(Offset = "0xC")]
	public EHeroicMarkType MarkType;

	[Token(Token = "0x4000880")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID IconRes;

	[Token(Token = "0x4000881")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID BigIconRes;

	[Token(Token = "0x4000882")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID VfxRes;

	[Token(Token = "0x4000883")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID VfxResSmall;

	[Token(Token = "0x4000884")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID MasterICONRes;

	[Token(Token = "0x4000885")]
	[FieldOffset(Offset = "0x24")]
	public ResourceID MasterBigICONRes;

	[Token(Token = "0x4000886")]
	[FieldOffset(Offset = "0x28")]
	public ResourceID MasterVFXRes;

	[Token(Token = "0x4000887")]
	[FieldOffset(Offset = "0x2C")]
	public ResourceID MasterSmallVFXRes;

	[Token(Token = "0x60007E1")]
	[Address(RVA = "0x190CF10", Offset = "0x190CF10", VA = "0x190CF10")]
	public HeroicMarkData()
	{
	}

	[Token(Token = "0x60007E2")]
	[Address(RVA = "0x190CF94", Offset = "0x190CF94", VA = "0x190CF94", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60007E3")]
	[Address(RVA = "0x190D01C", Offset = "0x190D01C", VA = "0x190D01C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
