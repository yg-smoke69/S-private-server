using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001547")]
public class CSGetRankMasterLevelRes
{
	[Token(Token = "0x4009299")]
	[FieldOffset(Offset = "0x8")]
	public List<RankMasterLevel> levels;

	[Token(Token = "0x6007B8F")]
	[Address(RVA = "0x3094E58", Offset = "0x3094E58", VA = "0x3094E58")]
	public CSGetRankMasterLevelRes()
	{
	}
}
