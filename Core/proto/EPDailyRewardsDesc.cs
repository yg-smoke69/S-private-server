using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A8A")]
public class EPDailyRewardsDesc
{
	[Token(Token = "0x400A622")]
	[FieldOffset(Offset = "0x8")]
	public uint ep_event_id;

	[Token(Token = "0x400A623")]
	[FieldOffset(Offset = "0xC")]
	public uint count_num;

	[Token(Token = "0x400A624")]
	[FieldOffset(Offset = "0x10")]
	public uint award_id;

	[Token(Token = "0x400A625")]
	[FieldOffset(Offset = "0x14")]
	public uint award_num;

	[Token(Token = "0x400A626")]
	[FieldOffset(Offset = "0x18")]
	public uint ep_award_num;

	[Token(Token = "0x60080E7")]
	[Address(RVA = "0x309F52C", Offset = "0x309F52C", VA = "0x309F52C")]
	public EPDailyRewardsDesc()
	{
	}
}
