using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001897")]
public class CSFFWS03ChooseTeamCardsReq
{
	[Token(Token = "0x4009D53")]
	[FieldOffset(Offset = "0x8")]
	public uint[] choose_card_ids;

	[Token(Token = "0x4009D54")]
	[FieldOffset(Offset = "0xC")]
	public string name;

	[Token(Token = "0x4009D55")]
	[FieldOffset(Offset = "0x10")]
	public bool is_change_name;

	[Token(Token = "0x6007EF0")]
	[Address(RVA = "0x317FFF8", Offset = "0x317FFF8", VA = "0x317FFF8")]
	public CSFFWS03ChooseTeamCardsReq()
	{
	}
}
