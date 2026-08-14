using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001704")]
public class DailyQuestRewardsStatus
{
	[Token(Token = "0x4009837")]
	[FieldOffset(Offset = "0x8")]
	public uint process_id;

	[Token(Token = "0x4009838")]
	[FieldOffset(Offset = "0xC")]
	public EPTarget_Status status;

	[Token(Token = "0x6007D5E")]
	[Address(RVA = "0x309E558", Offset = "0x309E558", VA = "0x309E558")]
	public DailyQuestRewardsStatus()
	{
	}
}
