using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016F5")]
public class GetCardsAndIAPInfoRes
{
	[Token(Token = "0x4009809")]
	[FieldOffset(Offset = "0x8")]
	public CSGetCardsRes cards_res;

	[Token(Token = "0x400980A")]
	[FieldOffset(Offset = "0xC")]
	public CSGetAccountIAPInfoRes iap_info_res;

	[Token(Token = "0x6007D4F")]
	[Address(RVA = "0x30A1F44", Offset = "0x30A1F44", VA = "0x30A1F44")]
	public GetCardsAndIAPInfoRes()
	{
	}
}
