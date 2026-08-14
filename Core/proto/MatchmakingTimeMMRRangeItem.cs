using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019DE")]
public class MatchmakingTimeMMRRangeItem
{
	[Token(Token = "0x400A264")]
	[FieldOffset(Offset = "0x8")]
	public uint time_sec;

	[Token(Token = "0x400A265")]
	[FieldOffset(Offset = "0xC")]
	public uint mmr_delta;

	[Token(Token = "0x400A266")]
	[FieldOffset(Offset = "0x10")]
	public uint mmr_delta_up;

	[Token(Token = "0x400A267")]
	[FieldOffset(Offset = "0x14")]
	public uint mmr_delta_down;

	[Token(Token = "0x6008036")]
	[Address(RVA = "0x30A86C4", Offset = "0x30A86C4", VA = "0x30A86C4")]
	public MatchmakingTimeMMRRangeItem()
	{
	}
}
