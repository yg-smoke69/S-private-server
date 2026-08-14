using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001CD")]
public class PartyDanceAnimData : CSVBaseData
{
	[Token(Token = "0x4000B00")]
	[FieldOffset(Offset = "0x8")]
	public float MusicTime;

	[Token(Token = "0x4000B01")]
	[FieldOffset(Offset = "0xC")]
	public uint[] NormalAnimList;

	[Token(Token = "0x4000B02")]
	[FieldOffset(Offset = "0x10")]
	public uint[] RareAnimList;

	[Token(Token = "0x4000B03")]
	[FieldOffset(Offset = "0x14")]
	public float Probability;

	[Token(Token = "0x60009A2")]
	[Address(RVA = "0x28CFDB8", Offset = "0x28CFDB8", VA = "0x28CFDB8")]
	public PartyDanceAnimData()
	{
	}

	[Token(Token = "0x60009A3")]
	[Address(RVA = "0x28CFE3C", Offset = "0x28CFE3C", VA = "0x28CFE3C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60009A4")]
	[Address(RVA = "0x28CFEA0", Offset = "0x28CFEA0", VA = "0x28CFEA0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
