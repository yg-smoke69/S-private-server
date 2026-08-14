using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000263")]
public class VoucherData : CSVBaseData
{
	[Token(Token = "0x4000E89")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000E8A")]
	[FieldOffset(Offset = "0xC")]
	public uint VoucherType;

	[Token(Token = "0x4000E8B")]
	[FieldOffset(Offset = "0x10")]
	public uint DeductItemType;

	[Token(Token = "0x4000E8C")]
	[FieldOffset(Offset = "0x14")]
	public uint DeductItemID;

	[Token(Token = "0x4000E8D")]
	[FieldOffset(Offset = "0x18")]
	public uint Maxmount;

	[Token(Token = "0x4000E8E")]
	[FieldOffset(Offset = "0x1C")]
	public uint Deductmount;

	[Token(Token = "0x4000E8F")]
	[FieldOffset(Offset = "0x20")]
	public bool isUse;

	[Token(Token = "0x6000BCA")]
	[Address(RVA = "0x21A1634", Offset = "0x21A1634", VA = "0x21A1634")]
	public VoucherData()
	{
	}

	[Token(Token = "0x6000BCB")]
	[Address(RVA = "0x21A16B8", Offset = "0x21A16B8", VA = "0x21A16B8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BCC")]
	[Address(RVA = "0x21A171C", Offset = "0x21A171C", VA = "0x21A171C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
