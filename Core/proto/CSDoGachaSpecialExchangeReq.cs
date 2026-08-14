using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016E2")]
public class CSDoGachaSpecialExchangeReq
{
	[Token(Token = "0x400978E")]
	[FieldOffset(Offset = "0x8")]
	public uint forge_tab_id;

	[Token(Token = "0x400978F")]
	[FieldOffset(Offset = "0xC")]
	public uint exchange_cnt;

	[Token(Token = "0x4009790")]
	[FieldOffset(Offset = "0x10")]
	public uint id;

	[Token(Token = "0x6007D3C")]
	[Address(RVA = "0x317FA04", Offset = "0x317FA04", VA = "0x317FA04")]
	public CSDoGachaSpecialExchangeReq()
	{
	}
}
