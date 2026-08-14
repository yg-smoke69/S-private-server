using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001638")]
public class CSGetClanWeekLeaderboardInfoRes
{
	[Token(Token = "0x4009572")]
	[FieldOffset(Offset = "0x8")]
	public long main_key;

	[Token(Token = "0x4009573")]
	[FieldOffset(Offset = "0x10")]
	public uint next_refresh_time;

	[Token(Token = "0x6007C82")]
	[Address(RVA = "0x3183320", Offset = "0x3183320", VA = "0x3183320")]
	public CSGetClanWeekLeaderboardInfoRes()
	{
	}
}
