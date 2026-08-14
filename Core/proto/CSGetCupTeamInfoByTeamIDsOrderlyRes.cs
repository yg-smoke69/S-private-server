using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200158A")]
public class CSGetCupTeamInfoByTeamIDsOrderlyRes
{
	[Token(Token = "0x4009374")]
	[FieldOffset(Offset = "0x8")]
	public List<CupTeamInfo> infos;

	[Token(Token = "0x6007BD2")]
	[Address(RVA = "0x31836AC", Offset = "0x31836AC", VA = "0x31836AC")]
	public CSGetCupTeamInfoByTeamIDsOrderlyRes()
	{
	}
}
