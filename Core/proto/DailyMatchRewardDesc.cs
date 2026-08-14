using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A42")]
public class DailyMatchRewardDesc
{
	[Token(Token = "0x400A473")]
	[FieldOffset(Offset = "0x8")]
	public uint config_id;

	[Token(Token = "0x400A474")]
	[FieldOffset(Offset = "0xC")]
	public uint condition_value;

	[Token(Token = "0x400A475")]
	[FieldOffset(Offset = "0x10")]
	public uint reward_amount;

	[Token(Token = "0x600809A")]
	[Address(RVA = "0x309E4BC", Offset = "0x309E4BC", VA = "0x309E4BC")]
	public DailyMatchRewardDesc()
	{
	}
}
