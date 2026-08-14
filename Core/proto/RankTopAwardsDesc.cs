using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A72")]
public class RankTopAwardsDesc
{
	[Token(Token = "0x400A589")]
	[FieldOffset(Offset = "0x8")]
	public uint rank;

	[Token(Token = "0x400A58A")]
	[FieldOffset(Offset = "0xC")]
	public List<AwardDesc> season_awards;

	[Token(Token = "0x400A58B")]
	[FieldOffset(Offset = "0x10")]
	public uint rank_master_level;

	[Token(Token = "0x60080CF")]
	[Address(RVA = "0x33E09B0", Offset = "0x33E09B0", VA = "0x33E09B0")]
	public RankTopAwardsDesc()
	{
	}
}
