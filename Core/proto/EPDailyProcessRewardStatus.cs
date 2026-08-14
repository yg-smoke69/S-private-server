using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A85")]
public class EPDailyProcessRewardStatus
{
	[Token(Token = "0x400A61A")]
	[FieldOffset(Offset = "0x8")]
	public uint process_id;

	[Token(Token = "0x400A61B")]
	[FieldOffset(Offset = "0xC")]
	public EPProcess_Status status;

	[Token(Token = "0x60080E2")]
	[Address(RVA = "0x309F40C", Offset = "0x309F40C", VA = "0x309F40C")]
	public EPDailyProcessRewardStatus()
	{
	}
}
