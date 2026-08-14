using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000212")]
public class RecommendRoomData : CSVBaseData
{
	[Token(Token = "0x4000C49")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000C4A")]
	[FieldOffset(Offset = "0xC")]
	public uint[] NewRoomType;

	[Token(Token = "0x4000C4B")]
	[FieldOffset(Offset = "0x10")]
	public uint[] HotRoomType;

	[Token(Token = "0x4000C4C")]
	[FieldOffset(Offset = "0x14")]
	public uint[] NewGameMode;

	[Token(Token = "0x4000C4D")]
	[FieldOffset(Offset = "0x18")]
	public uint[] HotGameMode;

	[Token(Token = "0x6000A9F")]
	[Address(RVA = "0x1970C38", Offset = "0x1970C38", VA = "0x1970C38")]
	public RecommendRoomData()
	{
	}

	[Token(Token = "0x6000AA0")]
	[Address(RVA = "0x1970CBC", Offset = "0x1970CBC", VA = "0x1970CBC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000AA1")]
	[Address(RVA = "0x1970D20", Offset = "0x1970D20", VA = "0x1970D20", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
