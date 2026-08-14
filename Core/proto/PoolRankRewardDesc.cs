using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BA4")]
public class PoolRankRewardDesc
{
	[Token(Token = "0x400ADDE")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400ADDF")]
	[FieldOffset(Offset = "0xC")]
	public uint rank_upper;

	[Token(Token = "0x400ADE0")]
	[FieldOffset(Offset = "0x10")]
	public uint rank_lower;

	[Token(Token = "0x400ADE1")]
	[FieldOffset(Offset = "0x14")]
	public List<AwardDesc> awards;

	[Token(Token = "0x60081FF")]
	[Address(RVA = "0x33E0008", Offset = "0x33E0008", VA = "0x33E0008")]
	public PoolRankRewardDesc()
	{
	}
}
