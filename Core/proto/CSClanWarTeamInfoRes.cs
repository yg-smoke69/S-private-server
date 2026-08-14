using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001654")]
public class CSClanWarTeamInfoRes
{
	[Token(Token = "0x40095F2")]
	[FieldOffset(Offset = "0x8")]
	public List<ClanWarTeamMemberInfo> members_info;

	[Token(Token = "0x40095F3")]
	[FieldOffset(Offset = "0xC")]
	public ClanWarMemberAwardStatus member_award_status;

	[Token(Token = "0x40095F4")]
	[FieldOffset(Offset = "0x10")]
	public ClanWarTeamAward team_award;

	[Token(Token = "0x40095F5")]
	[FieldOffset(Offset = "0x18")]
	public ulong team_id;

	[Token(Token = "0x6007C9E")]
	[Address(RVA = "0x317F020", Offset = "0x317F020", VA = "0x317F020")]
	public CSClanWarTeamInfoRes()
	{
	}
}
