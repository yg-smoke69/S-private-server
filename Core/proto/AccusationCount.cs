using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014A0")]
public class AccusationCount
{
	[Token(Token = "0x4008F14")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4008F15")]
	[FieldOffset(Offset = "0x10")]
	public uint accused_count;

	[Token(Token = "0x4008F16")]
	[FieldOffset(Offset = "0x14")]
	public string happen_time;

	[Token(Token = "0x6007B10")]
	[Address(RVA = "0x3179D9C", Offset = "0x3179D9C", VA = "0x3179D9C")]
	public AccusationCount()
	{
	}
}
