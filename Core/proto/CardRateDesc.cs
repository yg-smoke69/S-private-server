using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AD6")]
public class CardRateDesc
{
	[Token(Token = "0x400A8DE")]
	[FieldOffset(Offset = "0x8")]
	public uint daily_times;

	[Token(Token = "0x400A8DF")]
	[FieldOffset(Offset = "0xC")]
	public uint initial_rate;

	[Token(Token = "0x400A8E0")]
	[FieldOffset(Offset = "0x10")]
	public uint increase_rate;

	[Token(Token = "0x400A8E1")]
	[FieldOffset(Offset = "0x14")]
	public uint daily_time_max;

	[Token(Token = "0x6008132")]
	[Address(RVA = "0x309AC50", Offset = "0x309AC50", VA = "0x309AC50")]
	public CardRateDesc()
	{
	}
}
