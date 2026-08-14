using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001706")]
public class DailyProcess
{
	[Token(Token = "0x400983C")]
	[FieldOffset(Offset = "0x8")]
	public uint challenge_num;

	[Token(Token = "0x400983D")]
	[FieldOffset(Offset = "0xC")]
	public List<DailyProcessStatus> daily_process_status;

	[Token(Token = "0x6007D60")]
	[Address(RVA = "0x309E4C4", Offset = "0x309E4C4", VA = "0x309E4C4")]
	public DailyProcess()
	{
	}
}
