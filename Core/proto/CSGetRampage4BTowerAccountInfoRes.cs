using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200197C")]
public class CSGetRampage4BTowerAccountInfoRes
{
	[Token(Token = "0x4009FE8")]
	[FieldOffset(Offset = "0x8")]
	public uint hyper;

	[Token(Token = "0x4009FE9")]
	[FieldOffset(Offset = "0xC")]
	public uint hyper_level;

	[Token(Token = "0x4009FEA")]
	[FieldOffset(Offset = "0x10")]
	public uint phase_id;

	[Token(Token = "0x4009FEB")]
	[FieldOffset(Offset = "0x14")]
	public uint level;

	[Token(Token = "0x4009FEC")]
	[FieldOffset(Offset = "0x18")]
	public uint selection;

	[Token(Token = "0x4009FED")]
	[FieldOffset(Offset = "0x1C")]
	public uint buff;

	[Token(Token = "0x4009FEE")]
	[FieldOffset(Offset = "0x20")]
	public long buff_timestamp;

	[Token(Token = "0x4009FEF")]
	[FieldOffset(Offset = "0x28")]
	public uint process_floor;

	[Token(Token = "0x4009FF0")]
	[FieldOffset(Offset = "0x2C")]
	public bool is_need_selection;

	[Token(Token = "0x4009FF1")]
	[FieldOffset(Offset = "0x2D")]
	public bool is_upper_limit;

	[Token(Token = "0x6007FD5")]
	[Address(RVA = "0x3094C8C", Offset = "0x3094C8C", VA = "0x3094C8C")]
	public CSGetRampage4BTowerAccountInfoRes()
	{
	}
}
