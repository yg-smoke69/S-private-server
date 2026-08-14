using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001852")]
public class WinterFestStrategyHelpLog
{
	[Token(Token = "0x2001853")]
	public enum HelpType
	{
		[Token(Token = "0x4009CC0")]
		None,
		[Token(Token = "0x4009CC1")]
		Collect,
		[Token(Token = "0x4009CC2")]
		Order
	}

	[Token(Token = "0x4009CB8")]
	[FieldOffset(Offset = "0x8")]
	public HelpType type;

	[Token(Token = "0x4009CB9")]
	[FieldOffset(Offset = "0x10")]
	public ulong helper;

	[Token(Token = "0x4009CBA")]
	[FieldOffset(Offset = "0x18")]
	public ulong helpee;

	[Token(Token = "0x4009CBB")]
	[FieldOffset(Offset = "0x20")]
	public MiniGameItem helper_reward_minigame;

	[Token(Token = "0x4009CBC")]
	[FieldOffset(Offset = "0x24")]
	public MiniGameItem helpee_reward_minigame;

	[Token(Token = "0x4009CBD")]
	[FieldOffset(Offset = "0x28")]
	public Item helpee_reward;

	[Token(Token = "0x4009CBE")]
	[FieldOffset(Offset = "0x2C")]
	public uint devote_points;

	[Token(Token = "0x6007EAC")]
	[Address(RVA = "0x33E5C74", Offset = "0x33E5C74", VA = "0x33E5C74")]
	public WinterFestStrategyHelpLog()
	{
	}
}
