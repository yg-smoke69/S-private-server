using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A86")]
public class EPWeeklyProcessStatus
{
	[Token(Token = "0x400A61C")]
	[FieldOffset(Offset = "0x8")]
	public List<EPWeeklyProcessRewardStatus> weekly_process_status;

	[Token(Token = "0x60080E3")]
	[Address(RVA = "0x309F784", Offset = "0x309F784", VA = "0x309F784")]
	public EPWeeklyProcessStatus()
	{
	}
}
