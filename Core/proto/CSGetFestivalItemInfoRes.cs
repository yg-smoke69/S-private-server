using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015FD")]
public class CSGetFestivalItemInfoRes
{
	[Token(Token = "0x40094BD")]
	[FieldOffset(Offset = "0x8")]
	public uint festival_item_id;

	[Token(Token = "0x40094BE")]
	[FieldOffset(Offset = "0xC")]
	public string act_text1;

	[Token(Token = "0x40094BF")]
	[FieldOffset(Offset = "0x10")]
	public string act_text2;

	[Token(Token = "0x40094C0")]
	[FieldOffset(Offset = "0x14")]
	public string act_text3;

	[Token(Token = "0x6007C47")]
	[Address(RVA = "0x3184CCC", Offset = "0x3184CCC", VA = "0x3184CCC")]
	public CSGetFestivalItemInfoRes()
	{
	}
}
