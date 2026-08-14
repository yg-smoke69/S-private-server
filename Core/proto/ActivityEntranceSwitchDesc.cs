using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019D5")]
public class ActivityEntranceSwitchDesc
{
	[Token(Token = "0x400A20B")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A20C")]
	[FieldOffset(Offset = "0xC")]
	public string show_time;

	[Token(Token = "0x400A20D")]
	[FieldOffset(Offset = "0x10")]
	public string start_time;

	[Token(Token = "0x400A20E")]
	[FieldOffset(Offset = "0x14")]
	public string end_time;

	[Token(Token = "0x400A20F")]
	[FieldOffset(Offset = "0x18")]
	public string go_url;

	[Token(Token = "0x400A210")]
	[FieldOffset(Offset = "0x1C")]
	public uint go_pos;

	[Token(Token = "0x400A211")]
	[FieldOffset(Offset = "0x20")]
	public string cdn_url;

	[Token(Token = "0x400A212")]
	[FieldOffset(Offset = "0x24")]
	public string tip_cdn_url;

	[Token(Token = "0x600802D")]
	[Address(RVA = "0x317A2D0", Offset = "0x317A2D0", VA = "0x317A2D0")]
	public ActivityEntranceSwitchDesc()
	{
	}
}
