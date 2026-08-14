using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A77")]
public class RankingBotPointIngameParam
{
	[Token(Token = "0x400A5A7")]
	[FieldOffset(Offset = "0x8")]
	public uint group_mode;

	[Token(Token = "0x400A5A8")]
	[FieldOffset(Offset = "0xC")]
	public uint rank_lower;

	[Token(Token = "0x400A5A9")]
	[FieldOffset(Offset = "0x10")]
	public uint rank_upper;

	[Token(Token = "0x400A5AA")]
	[FieldOffset(Offset = "0x14")]
	public uint survive_time_lower;

	[Token(Token = "0x400A5AB")]
	[FieldOffset(Offset = "0x18")]
	public uint survive_time_upper;

	[Token(Token = "0x400A5AC")]
	[FieldOffset(Offset = "0x1C")]
	public uint kills_lower;

	[Token(Token = "0x400A5AD")]
	[FieldOffset(Offset = "0x20")]
	public uint kills_upper;

	[Token(Token = "0x400A5AE")]
	[FieldOffset(Offset = "0x24")]
	public int ingame_param;

	[Token(Token = "0x400A5AF")]
	[FieldOffset(Offset = "0x28")]
	public bool is_reset;

	[Token(Token = "0x60080D4")]
	[Address(RVA = "0x33E0B98", Offset = "0x33E0B98", VA = "0x33E0B98")]
	public RankingBotPointIngameParam()
	{
	}
}
