using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A88")]
public class EPDailyProcessStatus
{
	[Token(Token = "0x400A61F")]
	[FieldOffset(Offset = "0x8")]
	public List<EPDailyNodeProcessRewardStatus> daily_process_status;

	[Token(Token = "0x60080E5")]
	[Address(RVA = "0x309F414", Offset = "0x309F414", VA = "0x309F414")]
	public EPDailyProcessStatus()
	{
	}
}
