using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001985")]
public class CSGetBigEventDailyCheckInInfoRes
{
	[Token(Token = "0x400A003")]
	[FieldOffset(Offset = "0x8")]
	public uint accumulated_days;

	[Token(Token = "0x400A004")]
	[FieldOffset(Offset = "0xC")]
	public bool is_check_today;

	[Token(Token = "0x6007FDE")]
	[Address(RVA = "0x318225C", Offset = "0x318225C", VA = "0x318225C")]
	public CSGetBigEventDailyCheckInInfoRes()
	{
	}
}
