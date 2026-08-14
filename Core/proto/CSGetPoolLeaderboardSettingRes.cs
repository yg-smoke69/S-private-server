using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018A2")]
public class CSGetPoolLeaderboardSettingRes
{
	[Token(Token = "0x4009D71")]
	[FieldOffset(Offset = "0x8")]
	public PoolRankSettingDesc setting;

	[Token(Token = "0x4009D72")]
	[FieldOffset(Offset = "0xC")]
	public List<PoolRankRewardDesc> reward;

	[Token(Token = "0x6007EFB")]
	[Address(RVA = "0x3094A4C", Offset = "0x3094A4C", VA = "0x3094A4C")]
	public CSGetPoolLeaderboardSettingRes()
	{
	}
}
