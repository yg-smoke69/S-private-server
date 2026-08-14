using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C28")]
public class VeteranBRBotPointDesc
{
	[Token(Token = "0x400B133")]
	[FieldOffset(Offset = "0x8")]
	public uint group_mode;

	[Token(Token = "0x400B134")]
	[FieldOffset(Offset = "0xC")]
	public uint rank_lower;

	[Token(Token = "0x400B135")]
	[FieldOffset(Offset = "0x10")]
	public uint rank_upper;

	[Token(Token = "0x400B136")]
	[FieldOffset(Offset = "0x14")]
	public uint survive_time_lower;

	[Token(Token = "0x400B137")]
	[FieldOffset(Offset = "0x18")]
	public uint survive_time_upper;

	[Token(Token = "0x400B138")]
	[FieldOffset(Offset = "0x1C")]
	public uint kills_lower;

	[Token(Token = "0x400B139")]
	[FieldOffset(Offset = "0x20")]
	public uint kills_upper;

	[Token(Token = "0x400B13A")]
	[FieldOffset(Offset = "0x24")]
	public int in_game_coef;

	[Token(Token = "0x600828C")]
	[Address(RVA = "0x33E43FC", Offset = "0x33E43FC", VA = "0x33E43FC")]
	public VeteranBRBotPointDesc()
	{
	}
}
