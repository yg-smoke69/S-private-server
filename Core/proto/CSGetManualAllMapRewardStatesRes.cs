using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001778")]
public class CSGetManualAllMapRewardStatesRes
{
	[Token(Token = "0x4009A57")]
	[FieldOffset(Offset = "0x8")]
	public List<ManualMapReward> map_rewards;

	[Token(Token = "0x6007DD2")]
	[Address(RVA = "0x31874A8", Offset = "0x31874A8", VA = "0x31874A8")]
	public CSGetManualAllMapRewardStatesRes()
	{
	}
}
