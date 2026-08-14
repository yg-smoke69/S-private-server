using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200015C")]
public class InGameItemMarkData : CSVBaseData
{
	[Token(Token = "0x40008CB")]
	[FieldOffset(Offset = "0x8")]
	public string LevelObjectType;

	[Token(Token = "0x40008CC")]
	[FieldOffset(Offset = "0xC")]
	public string MarkNameKey;

	[Token(Token = "0x40008CD")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID MarkIconRes;

	[Token(Token = "0x600083B")]
	[Address(RVA = "0x2C77318", Offset = "0x2C77318", VA = "0x2C77318")]
	public InGameItemMarkData()
	{
	}

	[Token(Token = "0x600083C")]
	[Address(RVA = "0x2C7739C", Offset = "0x2C7739C", VA = "0x2C7739C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600083D")]
	[Address(RVA = "0x2C773F4", Offset = "0x2C773F4", VA = "0x2C773F4", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
