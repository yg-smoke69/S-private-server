using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018A0")]
public class CSFFWS03StartMatchRes
{
	[Token(Token = "0x4009D65")]
	[FieldOffset(Offset = "0x8")]
	public uint match_id;

	[Token(Token = "0x4009D66")]
	[FieldOffset(Offset = "0xC")]
	public uint rank;

	[Token(Token = "0x4009D67")]
	[FieldOffset(Offset = "0x10")]
	public uint score;

	[Token(Token = "0x4009D68")]
	[FieldOffset(Offset = "0x14")]
	public uint kills;

	[Token(Token = "0x4009D69")]
	[FieldOffset(Offset = "0x18")]
	public uint match_score;

	[Token(Token = "0x4009D6A")]
	[FieldOffset(Offset = "0x1C")]
	public uint team_kills_count;

	[Token(Token = "0x4009D6B")]
	[FieldOffset(Offset = "0x20")]
	public uint booyah_count;

	[Token(Token = "0x4009D6C")]
	[FieldOffset(Offset = "0x24")]
	public uint match_count_per_day;

	[Token(Token = "0x4009D6D")]
	[FieldOffset(Offset = "0x28")]
	public List<FFWS03TeamCardsInfo> team_cards_info;

	[Token(Token = "0x4009D6E")]
	[FieldOffset(Offset = "0x2C")]
	public ExchangeChangeData rewards;

	[Token(Token = "0x4009D6F")]
	[FieldOffset(Offset = "0x30")]
	public uint curr_match_count;

	[Token(Token = "0x6007EF9")]
	[Address(RVA = "0x3180328", Offset = "0x3180328", VA = "0x3180328")]
	public CSFFWS03StartMatchRes()
	{
	}
}
