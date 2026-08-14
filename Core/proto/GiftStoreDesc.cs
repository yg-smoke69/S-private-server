using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AA6")]
public class GiftStoreDesc
{
	[Token(Token = "0x400A76A")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x400A76B")]
	[FieldOffset(Offset = "0xC")]
	public string open_time;

	[Token(Token = "0x400A76C")]
	[FieldOffset(Offset = "0x10")]
	public string close_time;

	[Token(Token = "0x400A76D")]
	[FieldOffset(Offset = "0x14")]
	public bool is_time_show;

	[Token(Token = "0x400A76E")]
	[FieldOffset(Offset = "0x18")]
	public uint giver_level;

	[Token(Token = "0x400A76F")]
	[FieldOffset(Offset = "0x1C")]
	public uint receiver_level;

	[Token(Token = "0x400A770")]
	[FieldOffset(Offset = "0x20")]
	public uint gift_time_limited;

	[Token(Token = "0x400A771")]
	[FieldOffset(Offset = "0x24")]
	public uint gift_num_limited;

	[Token(Token = "0x6008103")]
	[Address(RVA = "0x30A25F4", Offset = "0x30A25F4", VA = "0x30A25F4")]
	public GiftStoreDesc()
	{
	}
}
