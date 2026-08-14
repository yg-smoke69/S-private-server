using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001785")]
public class CSTeamInfoBundleRes
{
	[Token(Token = "0x4009A7B")]
	[FieldOffset(Offset = "0x8")]
	public List<TeamInfo> infos;

	[Token(Token = "0x6007DDF")]
	[Address(RVA = "0x309A174", Offset = "0x309A174", VA = "0x309A174")]
	public CSTeamInfoBundleRes()
	{
	}
}
