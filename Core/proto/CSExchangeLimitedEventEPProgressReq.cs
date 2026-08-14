using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001869")]
public class CSExchangeLimitedEventEPProgressReq
{
	[Token(Token = "0x4009CF1")]
	[FieldOffset(Offset = "0x8")]
	public uint event_id;

	[Token(Token = "0x4009CF2")]
	[FieldOffset(Offset = "0xC")]
	public int cnt;

	[Token(Token = "0x6007EC2")]
	[Address(RVA = "0x317FF14", Offset = "0x317FF14", VA = "0x317FF14")]
	public CSExchangeLimitedEventEPProgressReq()
	{
	}
}
