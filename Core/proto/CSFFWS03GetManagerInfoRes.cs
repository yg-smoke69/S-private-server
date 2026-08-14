using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001893")]
public class CSFFWS03GetManagerInfoRes
{
	[Token(Token = "0x4009D41")]
	[FieldOffset(Offset = "0x8")]
	public List<FFWS03TeamCardsInfo> team_cards_info;

	[Token(Token = "0x4009D42")]
	[FieldOffset(Offset = "0xC")]
	public bool check_in_today;

	[Token(Token = "0x4009D43")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x4009D44")]
	[FieldOffset(Offset = "0x14")]
	public uint match_score;

	[Token(Token = "0x4009D45")]
	[FieldOffset(Offset = "0x18")]
	public uint team_kills_count;

	[Token(Token = "0x4009D46")]
	[FieldOffset(Offset = "0x1C")]
	public uint booyah_count;

	[Token(Token = "0x4009D47")]
	[FieldOffset(Offset = "0x20")]
	public uint trained_count_per_day;

	[Token(Token = "0x4009D48")]
	[FieldOffset(Offset = "0x24")]
	public uint match_count_per_day;

	[Token(Token = "0x4009D49")]
	[FieldOffset(Offset = "0x28")]
	public List<FFWS03ClaimedMilestoneInfo> claimed_milestone_info;

	[Token(Token = "0x4009D4A")]
	[FieldOffset(Offset = "0x2C")]
	public uint curr_match_count;

	[Token(Token = "0x6007EEC")]
	[Address(RVA = "0x31801F8", Offset = "0x31801F8", VA = "0x31801F8")]
	public CSFFWS03GetManagerInfoRes()
	{
	}
}
