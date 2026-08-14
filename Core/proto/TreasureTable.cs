using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A6B")]
public class TreasureTable
{
	[Token(Token = "0x400A561")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A562")]
	[FieldOffset(Offset = "0xC")]
	public uint id;

	[Token(Token = "0x400A563")]
	[FieldOffset(Offset = "0x10")]
	public uint item_id;

	[Token(Token = "0x400A564")]
	[FieldOffset(Offset = "0x14")]
	public string name;

	[Token(Token = "0x400A565")]
	[FieldOffset(Offset = "0x18")]
	public uint start_time;

	[Token(Token = "0x400A566")]
	[FieldOffset(Offset = "0x1C")]
	public uint end_time;

	[Token(Token = "0x400A567")]
	[FieldOffset(Offset = "0x20")]
	public uint quantity;

	[Token(Token = "0x400A568")]
	[FieldOffset(Offset = "0x24")]
	public uint daily_quantity;

	[Token(Token = "0x400A569")]
	[FieldOffset(Offset = "0x28")]
	public bool is_festival_item;

	[Token(Token = "0x60080C8")]
	[Address(RVA = "0x33E3D04", Offset = "0x33E3D04", VA = "0x33E3D04")]
	public TreasureTable()
	{
	}
}
