using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AE8")]
public class ReturnPlayerConfigDesc
{
	[Token(Token = "0x400A92E")]
	[FieldOffset(Offset = "0x8")]
	public long return_player_time_secs;

	[Token(Token = "0x400A92F")]
	[FieldOffset(Offset = "0x10")]
	public long return_playerKeep_time_secs;

	[Token(Token = "0x6008143")]
	[Address(RVA = "0x33E1A00", Offset = "0x33E1A00", VA = "0x33E1A00")]
	public ReturnPlayerConfigDesc()
	{
	}
}
