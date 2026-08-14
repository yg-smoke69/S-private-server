using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A5E")]
public class awakenTaskRefreshDesc
{
	[Token(Token = "0x400A516")]
	[FieldOffset(Offset = "0x8")]
	public uint original_avatar_id;

	[Token(Token = "0x400A517")]
	[FieldOffset(Offset = "0xC")]
	public uint[] re_cost_type;

	[Token(Token = "0x400A518")]
	[FieldOffset(Offset = "0x10")]
	public uint[] re_cost;

	[Token(Token = "0x400A519")]
	[FieldOffset(Offset = "0x14")]
	public uint re_times_limit;

	[Token(Token = "0x60080B6")]
	[Address(RVA = "0x33E6CC0", Offset = "0x33E6CC0", VA = "0x33E6CC0")]
	public awakenTaskRefreshDesc()
	{
	}
}
