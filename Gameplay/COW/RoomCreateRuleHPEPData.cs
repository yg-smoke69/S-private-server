using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200021C")]
public class RoomCreateRuleHPEPData : CSVBaseData
{
	[Token(Token = "0x4000C8F")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000C90")]
	[FieldOffset(Offset = "0xC")]
	public uint Key;

	[Token(Token = "0x4000C91")]
	[FieldOffset(Offset = "0x10")]
	public string Loc;

	[Token(Token = "0x4000C92")]
	[FieldOffset(Offset = "0x14")]
	public uint Type;

	[Token(Token = "0x4000C93")]
	[FieldOffset(Offset = "0x18")]
	public string Value;

	[Token(Token = "0x6000AC2")]
	[Address(RVA = "0x241564C", Offset = "0x241564C", VA = "0x241564C")]
	public RoomCreateRuleHPEPData()
	{
	}

	[Token(Token = "0x6000AC3")]
	[Address(RVA = "0x24156D0", Offset = "0x24156D0", VA = "0x24156D0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000AC4")]
	[Address(RVA = "0x24158E4", Offset = "0x24158E4", VA = "0x24158E4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}
}
