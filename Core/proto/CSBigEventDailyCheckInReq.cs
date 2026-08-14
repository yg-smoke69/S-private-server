using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001982")]
public class CSBigEventDailyCheckInReq
{
	[Token(Token = "0x4009FFE")]
	[FieldOffset(Offset = "0x8")]
	public uint event_id;

	[Token(Token = "0x4009FFF")]
	[FieldOffset(Offset = "0xC")]
	public uint serial_day;

	[Token(Token = "0x6007FDB")]
	[Address(RVA = "0x317DF0C", Offset = "0x317DF0C", VA = "0x317DF0C")]
	public CSBigEventDailyCheckInReq()
	{
	}
}
