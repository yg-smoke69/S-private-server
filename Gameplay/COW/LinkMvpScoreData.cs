using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000180")]
public class LinkMvpScoreData : CSVBaseData
{
	[Token(Token = "0x4000981")]
	[FieldOffset(Offset = "0x8")]
	public uint Id;

	[Token(Token = "0x4000982")]
	[FieldOffset(Offset = "0xC")]
	public int MinScore;

	[Token(Token = "0x4000983")]
	[FieldOffset(Offset = "0x10")]
	public int MaxScore;

	[Token(Token = "0x4000984")]
	[FieldOffset(Offset = "0x14")]
	public string Evaluation;

	[Token(Token = "0x60008A8")]
	[Address(RVA = "0xEC8724", Offset = "0xEC8724", VA = "0xEC8724")]
	public LinkMvpScoreData()
	{
	}

	[Token(Token = "0x60008A9")]
	[Address(RVA = "0xEC87A8", Offset = "0xEC87A8", VA = "0xEC87A8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60008AA")]
	[Address(RVA = "0xEC880C", Offset = "0xEC880C", VA = "0xEC880C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x60008AB")]
	[Address(RVA = "0xEC89A4", Offset = "0xEC89A4", VA = "0xEC89A4")]
	public static string GetEvaluation(int score)
	{
		return null;
	}
}
