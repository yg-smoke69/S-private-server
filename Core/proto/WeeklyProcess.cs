using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001705")]
public class WeeklyProcess
{
	[Token(Token = "0x4009839")]
	[FieldOffset(Offset = "0x8")]
	public uint week_id;

	[Token(Token = "0x400983A")]
	[FieldOffset(Offset = "0xC")]
	public uint challenge_num;

	[Token(Token = "0x400983B")]
	[FieldOffset(Offset = "0x10")]
	public List<WeeklyProcessStatus> weekly_process_status;

	[Token(Token = "0x6007D5F")]
	[Address(RVA = "0x33E5570", Offset = "0x33E5570", VA = "0x33E5570")]
	public WeeklyProcess()
	{
	}
}
