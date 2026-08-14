using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018C2")]
public class MusicFestRewardsInfo
{
	[Token(Token = "0x4009DC5")]
	[FieldOffset(Offset = "0x8")]
	public uint[] claimed_progress_ids;

	[Token(Token = "0x4009DC6")]
	[FieldOffset(Offset = "0xC")]
	public uint[] claimed_range_ids;

	[Token(Token = "0x4009DC7")]
	[FieldOffset(Offset = "0x10")]
	public uint[] claimed_card_rewards;

	[Token(Token = "0x6007F1B")]
	[Address(RVA = "0x30A93A4", Offset = "0x30A93A4", VA = "0x30A93A4")]
	public MusicFestRewardsInfo()
	{
	}
}
