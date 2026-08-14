using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B5F")]
public class HoodedkillerBRewardDesc
{
	[Token(Token = "0x400AC3C")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AC3D")]
	[FieldOffset(Offset = "0xC")]
	public List<AwardDesc> awards;

	[Token(Token = "0x60081BA")]
	[Address(RVA = "0x30A3060", Offset = "0x30A3060", VA = "0x30A3060")]
	public HoodedkillerBRewardDesc()
	{
	}
}
