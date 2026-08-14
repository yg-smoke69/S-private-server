using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001A7")]
public class MentorTitleData : CSVBaseData
{
	[Token(Token = "0x4000A3F")]
	[FieldOffset(Offset = "0x8")]
	public int GraduatedNum;

	[Token(Token = "0x4000A40")]
	[FieldOffset(Offset = "0xC")]
	public int TitleLevel;

	[Token(Token = "0x4000A41")]
	[FieldOffset(Offset = "0x10")]
	public string TitleContent;

	[Token(Token = "0x6000924")]
	[Address(RVA = "0x22745B8", Offset = "0x22745B8", VA = "0x22745B8")]
	public MentorTitleData()
	{
	}

	[Token(Token = "0x6000925")]
	[Address(RVA = "0x227463C", Offset = "0x227463C", VA = "0x227463C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000926")]
	[Address(RVA = "0x22746A0", Offset = "0x22746A0", VA = "0x22746A0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
