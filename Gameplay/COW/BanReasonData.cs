using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000BE")]
public class BanReasonData : CSVBaseData
{
	[Token(Token = "0x400049B")]
	[FieldOffset(Offset = "0x8")]
	public int ReasonId;

	[Token(Token = "0x400049C")]
	[FieldOffset(Offset = "0xC")]
	public string ReasonKey;

	[Token(Token = "0x400049D")]
	[FieldOffset(Offset = "0x10")]
	public bool TimeLimited;

	[Token(Token = "0x6000557")]
	[Address(RVA = "0x2E4F520", Offset = "0x2E4F520", VA = "0x2E4F520")]
	public BanReasonData()
	{
	}

	[Token(Token = "0x6000558")]
	[Address(RVA = "0x2E4F5A4", Offset = "0x2E4F5A4", VA = "0x2E4F5A4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000559")]
	[Address(RVA = "0x2E4F608", Offset = "0x2E4F608", VA = "0x2E4F608", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
