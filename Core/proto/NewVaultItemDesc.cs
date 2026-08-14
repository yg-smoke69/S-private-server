using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AC8")]
public class NewVaultItemDesc
{
	[Token(Token = "0x400A89D")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x400A89E")]
	[FieldOffset(Offset = "0xC")]
	public NewVaultShowType show_type;

	[Token(Token = "0x400A89F")]
	[FieldOffset(Offset = "0x10")]
	public uint tag;

	[Token(Token = "0x400A8A0")]
	[FieldOffset(Offset = "0x18")]
	public long start_timestamp;

	[Token(Token = "0x400A8A1")]
	[FieldOffset(Offset = "0x20")]
	public long end_timestamp;

	[Token(Token = "0x400A8A2")]
	[FieldOffset(Offset = "0x28")]
	public bool is_go_pos_used;

	[Token(Token = "0x400A8A3")]
	[FieldOffset(Offset = "0x2C")]
	public uint go_pos_type;

	[Token(Token = "0x400A8A4")]
	[FieldOffset(Offset = "0x30")]
	public uint go_pos;

	[Token(Token = "0x400A8A5")]
	[FieldOffset(Offset = "0x34")]
	public string sub_go_pos;

	[Token(Token = "0x400A8A6")]
	[FieldOffset(Offset = "0x38")]
	public string button_name;

	[Token(Token = "0x6008125")]
	[Address(RVA = "0x33DE7EC", Offset = "0x33DE7EC", VA = "0x33DE7EC")]
	public NewVaultItemDesc()
	{
	}
}
