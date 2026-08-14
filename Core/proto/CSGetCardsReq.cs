using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016EF")]
public class CSGetCardsReq
{
	[Token(Token = "0x40097FC")]
	[FieldOffset(Offset = "0x8")]
	public uint lottery_id;

	[Token(Token = "0x40097FD")]
	[FieldOffset(Offset = "0xC")]
	public uint[] id_list;

	[Token(Token = "0x6007D49")]
	[Address(RVA = "0x3182CC0", Offset = "0x3182CC0", VA = "0x3182CC0")]
	public CSGetCardsReq()
	{
	}
}
