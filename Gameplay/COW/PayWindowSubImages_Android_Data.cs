using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001E7")]
public class PayWindowSubImages_Android_Data : CSVBaseData
{
	[Token(Token = "0x4000B65")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x4000B66")]
	[FieldOffset(Offset = "0xC")]
	public string IAPCdnUrlKey;

	[Token(Token = "0x4000B67")]
	[FieldOffset(Offset = "0x10")]
	public string AdCdnUrlKey;

	[Token(Token = "0x4000B68")]
	[FieldOffset(Offset = "0x14")]
	public string IAPResourceName;

	[Token(Token = "0x4000B69")]
	[FieldOffset(Offset = "0x18")]
	public string AdResourceName;

	[Token(Token = "0x4000B6A")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID IAPResourceId;

	[Token(Token = "0x4000B6B")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID AdResourceId;

	[Token(Token = "0x6000A06")]
	[Address(RVA = "0x2DDDC90", Offset = "0x2DDDC90", VA = "0x2DDDC90")]
	public PayWindowSubImages_Android_Data()
	{
	}

	[Token(Token = "0x6000A07")]
	[Address(RVA = "0x2DDDD14", Offset = "0x2DDDD14", VA = "0x2DDDD14", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A08")]
	[Address(RVA = "0x2DDDD78", Offset = "0x2DDDD78", VA = "0x2DDDD78", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
