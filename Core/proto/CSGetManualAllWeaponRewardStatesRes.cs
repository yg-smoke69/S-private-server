using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001777")]
public class CSGetManualAllWeaponRewardStatesRes
{
	[Token(Token = "0x4009A56")]
	[FieldOffset(Offset = "0x8")]
	public List<ManualWeaponReward> weapon_rewards;

	[Token(Token = "0x6007DD1")]
	[Address(RVA = "0x3187534", Offset = "0x3187534", VA = "0x3187534")]
	public CSGetManualAllWeaponRewardStatesRes()
	{
	}
}
