using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B6E")]
public class BooyahDayLeaderboardRewardDesc
{
	[Token(Token = "0x400AC88")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AC89")]
	[FieldOffset(Offset = "0xC")]
	public uint rank_type;

	[Token(Token = "0x400AC8A")]
	[FieldOffset(Offset = "0x10")]
	public uint rank_lower;

	[Token(Token = "0x400AC8B")]
	[FieldOffset(Offset = "0x14")]
	public uint rank_upper;

	[Token(Token = "0x400AC8C")]
	[FieldOffset(Offset = "0x18")]
	public List<AwardDesc> awards;

	[Token(Token = "0x60081C9")]
	[Address(RVA = "0x317C97C", Offset = "0x317C97C", VA = "0x317C97C")]
	public BooyahDayLeaderboardRewardDesc()
	{
	}
}
