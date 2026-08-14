using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015A6")]
public class CSPurchaseRes
{
	[Token(Token = "0x40093D0")]
	[FieldOffset(Offset = "0x8")]
	public ExchangeChangeData data;

	[Token(Token = "0x40093D1")]
	[FieldOffset(Offset = "0xC")]
	public uint coins;

	[Token(Token = "0x40093D2")]
	[FieldOffset(Offset = "0x10")]
	public int gems;

	[Token(Token = "0x40093D3")]
	[FieldOffset(Offset = "0x14")]
	public OfferGoodsDesc offer_goods;

	[Token(Token = "0x6007BEE")]
	[Address(RVA = "0x30989D8", Offset = "0x30989D8", VA = "0x30989D8")]
	public CSPurchaseRes()
	{
	}
}
