using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C16")]
public class Rampage4BHyper
{
	[Token(Token = "0x400B0C3")]
	[FieldOffset(Offset = "0x8")]
	public uint hyper;

	[Token(Token = "0x400B0C4")]
	[FieldOffset(Offset = "0xC")]
	public uint hyper_level;

	[Token(Token = "0x400B0C5")]
	[FieldOffset(Offset = "0x10")]
	public uint phase_id;

	[Token(Token = "0x400B0C6")]
	[FieldOffset(Offset = "0x14")]
	public uint level;

	[Token(Token = "0x400B0C7")]
	[FieldOffset(Offset = "0x18")]
	public uint selection;

	[Token(Token = "0x400B0C8")]
	[FieldOffset(Offset = "0x1C")]
	public uint buff;

	[Token(Token = "0x400B0C9")]
	[FieldOffset(Offset = "0x20")]
	public long buff_timestamp;

	[Token(Token = "0x400B0CA")]
	[FieldOffset(Offset = "0x28")]
	public uint process_floor;

	[Token(Token = "0x400B0CB")]
	[FieldOffset(Offset = "0x2C")]
	public bool is_need_selection;

	[Token(Token = "0x400B0CC")]
	[FieldOffset(Offset = "0x2D")]
	public bool is_upper_limit;

	[Token(Token = "0x400B0CD")]
	[FieldOffset(Offset = "0x30")]
	public uint received_hyper_today;

	[Token(Token = "0x400B0CE")]
	[FieldOffset(Offset = "0x38")]
	public long last_hyper_add_time;

	[Token(Token = "0x6008270")]
	[Address(RVA = "0x33E03C4", Offset = "0x33E03C4", VA = "0x33E03C4")]
	public Rampage4BHyper()
	{
	}
}
