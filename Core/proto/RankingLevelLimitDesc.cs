using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019EB")]
public class RankingLevelLimitDesc
{
	[Token(Token = "0x400A2C5")]
	[FieldOffset(Offset = "0x8")]
	public uint match_mode;

	[Token(Token = "0x400A2C6")]
	[FieldOffset(Offset = "0xC")]
	public uint game_mode;

	[Token(Token = "0x400A2C7")]
	[FieldOffset(Offset = "0x10")]
	public uint guest_level;

	[Token(Token = "0x400A2C8")]
	[FieldOffset(Offset = "0x14")]
	public uint normal_level;

	[Token(Token = "0x400A2C9")]
	[FieldOffset(Offset = "0x18")]
	public uint guest_register_need_time;

	[Token(Token = "0x400A2CA")]
	[FieldOffset(Offset = "0x1C")]
	public uint normal_register_need_time;

	[Token(Token = "0x6008043")]
	[Address(RVA = "0x33E0BC0", Offset = "0x33E0BC0", VA = "0x33E0BC0")]
	public RankingLevelLimitDesc()
	{
	}
}
