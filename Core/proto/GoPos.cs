using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A56")]
public class GoPos
{
	[Token(Token = "0x400A4EF")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A4F0")]
	[FieldOffset(Offset = "0xC")]
	public string go_pos;

	[Token(Token = "0x400A4F1")]
	[FieldOffset(Offset = "0x10")]
	public string sub_pos;

	[Token(Token = "0x400A4F2")]
	[FieldOffset(Offset = "0x14")]
	public string go_pos2;

	[Token(Token = "0x400A4F3")]
	[FieldOffset(Offset = "0x18")]
	public string sub_pos2;

	[Token(Token = "0x400A4F4")]
	[FieldOffset(Offset = "0x1C")]
	public uint start_time_stamp;

	[Token(Token = "0x400A4F5")]
	[FieldOffset(Offset = "0x20")]
	public uint end_time_stamp;

	[Token(Token = "0x60080AE")]
	[Address(RVA = "0x30A281C", Offset = "0x30A281C", VA = "0x30A281C")]
	public GoPos()
	{
	}
}
