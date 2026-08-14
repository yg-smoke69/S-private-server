using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001552")]
public class CSGetCSRankMasterLevelRes
{
	[Token(Token = "0x40092C0")]
	[FieldOffset(Offset = "0x8")]
	public List<RankMasterLevel> levels;

	[Token(Token = "0x6007B9A")]
	[Address(RVA = "0x3182C34", Offset = "0x3182C34", VA = "0x3182C34")]
	public CSGetCSRankMasterLevelRes()
	{
	}
}
