using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001653")]
public class CSClanWarBasicInfoRes
{
	[Token(Token = "0x40095EE")]
	[FieldOffset(Offset = "0x8")]
	public ClanWarInfoDesc clan_war_info;

	[Token(Token = "0x40095EF")]
	[FieldOffset(Offset = "0xC")]
	public List<ClanWarOpeningInfoDesc> clan_war_opening_info;

	[Token(Token = "0x40095F0")]
	[FieldOffset(Offset = "0x10")]
	public List<ClanWarAwardDesc> clan_war_award;

	[Token(Token = "0x40095F1")]
	[FieldOffset(Offset = "0x14")]
	public ClanWarPersonalAwardDesc personal_awards;

	[Token(Token = "0x6007C9D")]
	[Address(RVA = "0x317EED4", Offset = "0x317EED4", VA = "0x317EED4")]
	public CSClanWarBasicInfoRes()
	{
	}
}
