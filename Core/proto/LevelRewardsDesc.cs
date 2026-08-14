using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A51")]
public class LevelRewardsDesc
{
	[Token(Token = "0x400A4DD")]
	[FieldOffset(Offset = "0x8")]
	public uint target_level;

	[Token(Token = "0x400A4DE")]
	[FieldOffset(Offset = "0xC")]
	public List<AwardDesc> awards;

	[Token(Token = "0x60080A9")]
	[Address(RVA = "0x30A4500", Offset = "0x30A4500", VA = "0x30A4500")]
	public LevelRewardsDesc()
	{
	}
}
