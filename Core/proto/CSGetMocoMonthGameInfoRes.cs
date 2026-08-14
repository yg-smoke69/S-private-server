using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018D0")]
public class CSGetMocoMonthGameInfoRes
{
	[Token(Token = "0x4009DE6")]
	[FieldOffset(Offset = "0x8")]
	public uint free_times_used;

	[Token(Token = "0x4009DE7")]
	[FieldOffset(Offset = "0x10")]
	public long last_free_play_time;

	[Token(Token = "0x6007F29")]
	[Address(RVA = "0x3187708", Offset = "0x3187708", VA = "0x3187708")]
	public CSGetMocoMonthGameInfoRes()
	{
	}
}
