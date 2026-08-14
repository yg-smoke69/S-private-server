using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001B7")]
public class NewPlayerGuideData : CSVBaseData
{
	[Token(Token = "0x4000A8F")]
	[FieldOffset(Offset = "0x8")]
	public int Precdt1;

	[Token(Token = "0x4000A90")]
	[FieldOffset(Offset = "0xC")]
	public int Precdt_value1;

	[Token(Token = "0x4000A91")]
	[FieldOffset(Offset = "0x10")]
	public int Precdt2;

	[Token(Token = "0x4000A92")]
	[FieldOffset(Offset = "0x14")]
	public int Precdt_value2;

	[Token(Token = "0x4000A93")]
	[FieldOffset(Offset = "0x18")]
	public int Precdt3;

	[Token(Token = "0x4000A94")]
	[FieldOffset(Offset = "0x1C")]
	public int Precdt_value3;

	[Token(Token = "0x4000A95")]
	[FieldOffset(Offset = "0x20")]
	public int Precdt4;

	[Token(Token = "0x4000A96")]
	[FieldOffset(Offset = "0x24")]
	public int Precdt_value4;

	[Token(Token = "0x4000A97")]
	[FieldOffset(Offset = "0x28")]
	public int GuideId;

	[Token(Token = "0x4000A98")]
	[FieldOffset(Offset = "0x2C")]
	public string GuideIntroKey;

	[Token(Token = "0x6000953")]
	[Address(RVA = "0x28B1A88", Offset = "0x28B1A88", VA = "0x28B1A88")]
	public NewPlayerGuideData()
	{
	}

	[Token(Token = "0x6000954")]
	[Address(RVA = "0x28B1B0C", Offset = "0x28B1B0C", VA = "0x28B1B0C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000955")]
	[Address(RVA = "0x28B1BE4", Offset = "0x28B1BE4", VA = "0x28B1BE4", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
