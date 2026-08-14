using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A83")]
public class EPDailyProcessRewardDesc
{
	[Token(Token = "0x400A615")]
	[FieldOffset(Offset = "0x8")]
	public uint ep_event_id;

	[Token(Token = "0x400A616")]
	[FieldOffset(Offset = "0xC")]
	public uint node_id;

	[Token(Token = "0x400A617")]
	[FieldOffset(Offset = "0x10")]
	public uint challenge_num;

	[Token(Token = "0x400A618")]
	[FieldOffset(Offset = "0x14")]
	public List<AwardDesc> awards;

	[Token(Token = "0x60080E0")]
	[Address(RVA = "0x309F380", Offset = "0x309F380", VA = "0x309F380")]
	public EPDailyProcessRewardDesc()
	{
	}
}
