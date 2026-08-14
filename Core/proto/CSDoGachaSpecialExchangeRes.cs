using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016E4")]
public class CSDoGachaSpecialExchangeRes
{
	[Token(Token = "0x4009794")]
	[FieldOffset(Offset = "0x8")]
	public ExchangeChangeData data;

	[Token(Token = "0x4009795")]
	[FieldOffset(Offset = "0xC")]
	public uint purchase_times;

	[Token(Token = "0x6007D3E")]
	[Address(RVA = "0x317FA0C", Offset = "0x317FA0C", VA = "0x317FA0C")]
	public CSDoGachaSpecialExchangeRes()
	{
	}
}
