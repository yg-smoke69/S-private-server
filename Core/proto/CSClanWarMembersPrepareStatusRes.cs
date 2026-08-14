using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200165B")]
public class CSClanWarMembersPrepareStatusRes
{
	[Token(Token = "0x4009603")]
	[FieldOffset(Offset = "0x8")]
	public List<ClanWarTeamMemberInfo> members_info;

	[Token(Token = "0x6007CA5")]
	[Address(RVA = "0x317EF94", Offset = "0x317EF94", VA = "0x317EF94")]
	public CSClanWarMembersPrepareStatusRes()
	{
	}
}
