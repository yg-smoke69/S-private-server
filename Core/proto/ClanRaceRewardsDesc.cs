using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A2A")]
public class ClanRaceRewardsDesc
{
	[Token(Token = "0x400A3E7")]
	[FieldOffset(Offset = "0x8")]
	public uint stage_id;

	[Token(Token = "0x400A3E8")]
	[FieldOffset(Offset = "0xC")]
	public uint min_race_point;

	[Token(Token = "0x400A3E9")]
	[FieldOffset(Offset = "0x10")]
	public uint race_point_cost;

	[Token(Token = "0x400A3EA")]
	[FieldOffset(Offset = "0x14")]
	public uint reward_honor;

	[Token(Token = "0x400A3EB")]
	[FieldOffset(Offset = "0x18")]
	public AwardDesc all_member_award;

	[Token(Token = "0x400A3EC")]
	[FieldOffset(Offset = "0x1C")]
	public AwardDesc unlock_award;

	[Token(Token = "0x6008082")]
	[Address(RVA = "0x309C088", Offset = "0x309C088", VA = "0x309C088")]
	public ClanRaceRewardsDesc()
	{
	}
}
