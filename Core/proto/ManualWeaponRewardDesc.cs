using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AF1")]
public class ManualWeaponRewardDesc
{
	[Token(Token = "0x400A956")]
	[FieldOffset(Offset = "0x8")]
	public uint quantity_period;

	[Token(Token = "0x400A957")]
	[FieldOffset(Offset = "0xC")]
	public List<AwardDesc> awards;

	[Token(Token = "0x600814C")]
	[Address(RVA = "0x30A78F4", Offset = "0x30A78F4", VA = "0x30A78F4")]
	public ManualWeaponRewardDesc()
	{
	}
}
