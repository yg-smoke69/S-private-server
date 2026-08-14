using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A45")]
public class CSBotPointIngameParam
{
	[Token(Token = "0x400A482")]
	[FieldOffset(Offset = "0x8")]
	public uint round_lower;

	[Token(Token = "0x400A483")]
	[FieldOffset(Offset = "0xC")]
	public uint round_upper;

	[Token(Token = "0x400A484")]
	[FieldOffset(Offset = "0x10")]
	public uint kills_lower;

	[Token(Token = "0x400A485")]
	[FieldOffset(Offset = "0x14")]
	public uint kills_upper;

	[Token(Token = "0x400A486")]
	[FieldOffset(Offset = "0x18")]
	public uint death_lower;

	[Token(Token = "0x400A487")]
	[FieldOffset(Offset = "0x1C")]
	public uint death_upper;

	[Token(Token = "0x400A488")]
	[FieldOffset(Offset = "0x20")]
	public int ingame_param;

	[Token(Token = "0x400A489")]
	[FieldOffset(Offset = "0x24")]
	public bool is_reset;

	[Token(Token = "0x600809D")]
	[Address(RVA = "0x317DFDC", Offset = "0x317DFDC", VA = "0x317DFDC")]
	public CSBotPointIngameParam()
	{
	}
}
