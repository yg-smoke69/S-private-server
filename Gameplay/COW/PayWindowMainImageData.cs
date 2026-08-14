using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001E6")]
public class PayWindowMainImageData : CSVBaseData
{
	[Token(Token = "0x4000B5E")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x4000B5F")]
	[FieldOffset(Offset = "0xC")]
	public string PaidCdnUrlKey;

	[Token(Token = "0x4000B60")]
	[FieldOffset(Offset = "0x10")]
	public string UnpaidCdnUrlKey;

	[Token(Token = "0x4000B61")]
	[FieldOffset(Offset = "0x14")]
	public string PaidResourceName;

	[Token(Token = "0x4000B62")]
	[FieldOffset(Offset = "0x18")]
	public string UnpaidResourceName;

	[Token(Token = "0x4000B63")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID PaidResourceId;

	[Token(Token = "0x4000B64")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID UnpaidResourceId;

	[Token(Token = "0x6000A03")]
	[Address(RVA = "0x2DDD7A4", Offset = "0x2DDD7A4", VA = "0x2DDD7A4")]
	public PayWindowMainImageData()
	{
	}

	[Token(Token = "0x6000A04")]
	[Address(RVA = "0x2DDD828", Offset = "0x2DDD828", VA = "0x2DDD828", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A05")]
	[Address(RVA = "0x2DDD88C", Offset = "0x2DDD88C", VA = "0x2DDD88C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
