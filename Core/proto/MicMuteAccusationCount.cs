using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014D9")]
public class MicMuteAccusationCount
{
	[Token(Token = "0x400900B")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x400900C")]
	[FieldOffset(Offset = "0x10")]
	public uint accused_count;

	[Token(Token = "0x400900D")]
	[FieldOffset(Offset = "0x14")]
	public string happen_time;

	[Token(Token = "0x6007B2E")]
	[Address(RVA = "0x30A896C", Offset = "0x30A896C", VA = "0x30A896C")]
	public MicMuteAccusationCount()
	{
	}
}
