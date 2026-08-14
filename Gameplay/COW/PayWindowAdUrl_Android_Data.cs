using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001E5")]
public class PayWindowAdUrl_Android_Data : CSVBaseData
{
	[Token(Token = "0x4000B5C")]
	[FieldOffset(Offset = "0x8")]
	public string RegionName;

	[Token(Token = "0x4000B5D")]
	[FieldOffset(Offset = "0xC")]
	public string Url;

	[Token(Token = "0x6000A00")]
	[Address(RVA = "0x2DDD520", Offset = "0x2DDD520", VA = "0x2DDD520")]
	public PayWindowAdUrl_Android_Data()
	{
	}

	[Token(Token = "0x6000A01")]
	[Address(RVA = "0x2DDD5A4", Offset = "0x2DDD5A4", VA = "0x2DDD5A4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A02")]
	[Address(RVA = "0x2DDD5FC", Offset = "0x2DDD5FC", VA = "0x2DDD5FC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
