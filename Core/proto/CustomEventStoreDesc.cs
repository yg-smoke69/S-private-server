using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C09")]
public class CustomEventStoreDesc
{
	[Token(Token = "0x400B05B")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x400B05C")]
	[FieldOffset(Offset = "0xC")]
	public uint event_id;

	[Token(Token = "0x400B05D")]
	[FieldOffset(Offset = "0x10")]
	public uint store_type;

	[Token(Token = "0x400B05E")]
	[FieldOffset(Offset = "0x18")]
	public long start_time;

	[Token(Token = "0x400B05F")]
	[FieldOffset(Offset = "0x20")]
	public long end_time;

	[Token(Token = "0x400B060")]
	[FieldOffset(Offset = "0x28")]
	public long start_show_time;

	[Token(Token = "0x400B061")]
	[FieldOffset(Offset = "0x30")]
	public long end_show_time;

	[Token(Token = "0x6008264")]
	[Address(RVA = "0x309E300", Offset = "0x309E300", VA = "0x309E300")]
	public CustomEventStoreDesc()
	{
	}
}
