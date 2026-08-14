using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A44")]
public class BotPointIngameParam
{
	[Token(Token = "0x400A479")]
	[FieldOffset(Offset = "0x8")]
	public uint group_mode;

	[Token(Token = "0x400A47A")]
	[FieldOffset(Offset = "0xC")]
	public uint rank_lower;

	[Token(Token = "0x400A47B")]
	[FieldOffset(Offset = "0x10")]
	public uint rank_upper;

	[Token(Token = "0x400A47C")]
	[FieldOffset(Offset = "0x14")]
	public uint survive_time_lower;

	[Token(Token = "0x400A47D")]
	[FieldOffset(Offset = "0x18")]
	public uint survive_time_upper;

	[Token(Token = "0x400A47E")]
	[FieldOffset(Offset = "0x1C")]
	public uint kills_lower;

	[Token(Token = "0x400A47F")]
	[FieldOffset(Offset = "0x20")]
	public uint kills_upper;

	[Token(Token = "0x400A480")]
	[FieldOffset(Offset = "0x24")]
	public int ingame_param;

	[Token(Token = "0x400A481")]
	[FieldOffset(Offset = "0x28")]
	public bool is_reset;

	[Token(Token = "0x600809C")]
	[Address(RVA = "0x317D008", Offset = "0x317D008", VA = "0x317D008")]
	public BotPointIngameParam()
	{
	}
}
