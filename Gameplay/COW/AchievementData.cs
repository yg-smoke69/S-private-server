using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000094")]
public class AchievementData : CSVBaseData
{
	[Token(Token = "0x400034B")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x400034C")]
	[FieldOffset(Offset = "0xC")]
	public string Description;

	[Token(Token = "0x400034D")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID PictureRes;

	[Token(Token = "0x400034E")]
	[FieldOffset(Offset = "0x14")]
	public int Priority;

	[Token(Token = "0x400034F")]
	[FieldOffset(Offset = "0x18")]
	public int Param;

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x14B7F58", Offset = "0x14B7F58", VA = "0x14B7F58")]
	public AchievementData()
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x14B7FDC", Offset = "0x14B7FDC", VA = "0x14B7FDC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x14B8040", Offset = "0x14B8040", VA = "0x14B8040", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
