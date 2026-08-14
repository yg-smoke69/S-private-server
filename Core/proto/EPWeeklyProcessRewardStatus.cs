using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A87")]
public class EPWeeklyProcessRewardStatus
{
	[Token(Token = "0x400A61D")]
	[FieldOffset(Offset = "0x8")]
	public uint node_id;

	[Token(Token = "0x400A61E")]
	[FieldOffset(Offset = "0xC")]
	public EPProcess_Status status;

	[Token(Token = "0x60080E4")]
	[Address(RVA = "0x309F77C", Offset = "0x309F77C", VA = "0x309F77C")]
	public EPWeeklyProcessRewardStatus()
	{
	}
}
