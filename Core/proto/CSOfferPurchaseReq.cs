using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015A7")]
public class CSOfferPurchaseReq
{
	[Token(Token = "0x40093D4")]
	[FieldOffset(Offset = "0x8")]
	public uint offer_id;

	[Token(Token = "0x40093D5")]
	[FieldOffset(Offset = "0xC")]
	public uint offer_goods_id;

	[Token(Token = "0x40093D6")]
	[FieldOffset(Offset = "0x10")]
	public uint cnt;

	[Token(Token = "0x40093D7")]
	[FieldOffset(Offset = "0x18")]
	public ulong trans_id;

	[Token(Token = "0x40093D8")]
	[FieldOffset(Offset = "0x20")]
	public uint price;

	[Token(Token = "0x6007BEF")]
	[Address(RVA = "0x309814C", Offset = "0x309814C", VA = "0x309814C")]
	public CSOfferPurchaseReq()
	{
	}
}
