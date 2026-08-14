using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A82")]
public class EPWeeklyRewardDesc
{
	[Token(Token = "0x400A610")]
	[FieldOffset(Offset = "0x8")]
	public uint ep_event_id;

	[Token(Token = "0x400A611")]
	[FieldOffset(Offset = "0xC")]
	public uint week_id;

	[Token(Token = "0x400A612")]
	[FieldOffset(Offset = "0x10")]
	public uint node_id;

	[Token(Token = "0x400A613")]
	[FieldOffset(Offset = "0x14")]
	public uint challenge_num;

	[Token(Token = "0x400A614")]
	[FieldOffset(Offset = "0x18")]
	public List<AwardDesc> awards;

	[Token(Token = "0x60080DF")]
	[Address(RVA = "0x309F810", Offset = "0x309F810", VA = "0x309F810")]
	public EPWeeklyRewardDesc()
	{
	}
}
