using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001983")]
public class CSBigEventDailyCheckInRes
{
	[Token(Token = "0x400A000")]
	[FieldOffset(Offset = "0x8")]
	public bool is_success;

	[Token(Token = "0x400A001")]
	[FieldOffset(Offset = "0x10")]
	public long check_time;

	[Token(Token = "0x6007FDC")]
	[Address(RVA = "0x317DF14", Offset = "0x317DF14", VA = "0x317DF14")]
	public CSBigEventDailyCheckInRes()
	{
	}
}
