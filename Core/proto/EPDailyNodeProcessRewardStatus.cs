using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A89")]
public class EPDailyNodeProcessRewardStatus
{
	[Token(Token = "0x400A620")]
	[FieldOffset(Offset = "0x8")]
	public uint node_id;

	[Token(Token = "0x400A621")]
	[FieldOffset(Offset = "0xC")]
	public EPProcess_Status status;

	[Token(Token = "0x60080E6")]
	[Address(RVA = "0x309F378", Offset = "0x309F378", VA = "0x309F378")]
	public EPDailyNodeProcessRewardStatus()
	{
	}
}
