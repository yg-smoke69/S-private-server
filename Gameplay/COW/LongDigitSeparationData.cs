using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200018D")]
public class LongDigitSeparationData : CSVBaseData
{
	[Token(Token = "0x400099D")]
	[FieldOffset(Offset = "0x8")]
	public string Language;

	[Token(Token = "0x400099E")]
	[FieldOffset(Offset = "0xC")]
	public int Digit;

	[Token(Token = "0x400099F")]
	[FieldOffset(Offset = "0x10")]
	public string SeperationSign;

	[Token(Token = "0x60008D0")]
	[Address(RVA = "0x152D930", Offset = "0x152D930", VA = "0x152D930")]
	public LongDigitSeparationData()
	{
	}

	[Token(Token = "0x60008D1")]
	[Address(RVA = "0x152D9B4", Offset = "0x152D9B4", VA = "0x152D9B4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60008D2")]
	[Address(RVA = "0x152DA0C", Offset = "0x152DA0C", VA = "0x152DA0C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
