using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A12")]
public class FestivalAttendanceConfigDesc
{
	[Token(Token = "0x400A379")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A37A")]
	[FieldOffset(Offset = "0xC")]
	public string start_time;

	[Token(Token = "0x400A37B")]
	[FieldOffset(Offset = "0x10")]
	public string end_time;

	[Token(Token = "0x400A37C")]
	[FieldOffset(Offset = "0x14")]
	public string act_text1;

	[Token(Token = "0x400A37D")]
	[FieldOffset(Offset = "0x18")]
	public string act_text2;

	[Token(Token = "0x400A37E")]
	[FieldOffset(Offset = "0x1C")]
	public string act_text3;

	[Token(Token = "0x400A37F")]
	[FieldOffset(Offset = "0x20")]
	public uint festival_item_id1;

	[Token(Token = "0x400A380")]
	[FieldOffset(Offset = "0x24")]
	public uint festival_item_id2;

	[Token(Token = "0x600806A")]
	[Address(RVA = "0x30A0B7C", Offset = "0x30A0B7C", VA = "0x30A0B7C")]
	public FestivalAttendanceConfigDesc()
	{
	}
}
