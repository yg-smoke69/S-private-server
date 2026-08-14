using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A71")]
public class RankAwardsDesc
{
	[Token(Token = "0x400A586")]
	[FieldOffset(Offset = "0x8")]
	public uint rank;

	[Token(Token = "0x400A587")]
	[FieldOffset(Offset = "0xC")]
	public List<AwardDesc> level_awards;

	[Token(Token = "0x400A588")]
	[FieldOffset(Offset = "0x10")]
	public uint rank_master_level;

	[Token(Token = "0x60080CE")]
	[Address(RVA = "0x33E07B4", Offset = "0x33E07B4", VA = "0x33E07B4")]
	public RankAwardsDesc()
	{
	}
}
