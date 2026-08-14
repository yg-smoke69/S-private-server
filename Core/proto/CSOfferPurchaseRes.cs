using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015A8")]
public class CSOfferPurchaseRes
{
	[Token(Token = "0x40093D9")]
	[FieldOffset(Offset = "0x8")]
	public ExchangeChangeData data;

	[Token(Token = "0x40093DA")]
	[FieldOffset(Offset = "0xC")]
	public int gems;

	[Token(Token = "0x6007BF0")]
	[Address(RVA = "0x3098154", Offset = "0x3098154", VA = "0x3098154")]
	public CSOfferPurchaseRes()
	{
	}
}
