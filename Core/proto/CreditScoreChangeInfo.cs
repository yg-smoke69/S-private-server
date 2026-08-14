using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001942")]
public class CreditScoreChangeInfo
{
	[Token(Token = "0x4009F46")]
	[FieldOffset(Offset = "0x8")]
	public ulong change_time;

	[Token(Token = "0x4009F47")]
	[FieldOffset(Offset = "0x10")]
	public uint reason_id;

	[Token(Token = "0x4009F48")]
	[FieldOffset(Offset = "0x14")]
	public int credit_score_delta;

	[Token(Token = "0x4009F49")]
	[FieldOffset(Offset = "0x18")]
	public uint credit_score_after_change;

	[Token(Token = "0x6007F9B")]
	[Address(RVA = "0x309D910", Offset = "0x309D910", VA = "0x309D910")]
	public CreditScoreChangeInfo()
	{
	}
}
