using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20001B9")]
public class NewPlayerSevenDaysAwardData : CSVBaseData
{
	[Token(Token = "0x4000AA6")]
	[FieldOffset(Offset = "0x8")]
	public uint achievementId;

	[Token(Token = "0x4000AA7")]
	[FieldOffset(Offset = "0xC")]
	public uint mustDoTask;

	[Token(Token = "0x4000AA8")]
	[FieldOffset(Offset = "0x10")]
	public uint dayID;

	[Token(Token = "0x4000AA9")]
	[FieldOffset(Offset = "0x14")]
	public string dayTitleKey;

	[Token(Token = "0x4000AAA")]
	[FieldOffset(Offset = "0x18")]
	public int achievementCount;

	[Token(Token = "0x4000AAB")]
	[FieldOffset(Offset = "0x1C")]
	public uint[] achievementIDArray;

	[Token(Token = "0x4000AAC")]
	[FieldOffset(Offset = "0x20")]
	public AwardDesc award;

	[Token(Token = "0x6000959")]
	[Address(RVA = "0x28B31C4", Offset = "0x28B31C4", VA = "0x28B31C4")]
	public NewPlayerSevenDaysAwardData()
	{
	}

	[Token(Token = "0x600095A")]
	[Address(RVA = "0x28B3248", Offset = "0x28B3248", VA = "0x28B3248", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600095B")]
	[Address(RVA = "0x28B32AC", Offset = "0x28B32AC", VA = "0x28B32AC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
