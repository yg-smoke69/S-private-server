using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A7C")]
public class LoginQueueDesc
{
	[Token(Token = "0x400A5BC")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A5BD")]
	[FieldOffset(Offset = "0xC")]
	public uint capacity;

	[Token(Token = "0x400A5BE")]
	[FieldOffset(Offset = "0x10")]
	public uint rate;

	[Token(Token = "0x400A5BF")]
	[FieldOffset(Offset = "0x14")]
	public uint burst;

	[Token(Token = "0x400A5C0")]
	[FieldOffset(Offset = "0x18")]
	public uint ttl;

	[Token(Token = "0x400A5C1")]
	[FieldOffset(Offset = "0x1C")]
	public bool enable;

	[Token(Token = "0x400A5C2")]
	[FieldOffset(Offset = "0x20")]
	public uint scan_queue_interval;

	[Token(Token = "0x400A5C3")]
	[FieldOffset(Offset = "0x24")]
	public uint scan_cache_interval;

	[Token(Token = "0x400A5C4")]
	[FieldOffset(Offset = "0x28")]
	public uint process_cache_speed;

	[Token(Token = "0x400A5C5")]
	[FieldOffset(Offset = "0x2C")]
	public uint multiplier;

	[Token(Token = "0x400A5C6")]
	[FieldOffset(Offset = "0x30")]
	public bool force_update;

	[Token(Token = "0x60080D9")]
	[Address(RVA = "0x30A6860", Offset = "0x30A6860", VA = "0x30A6860")]
	public LoginQueueDesc()
	{
	}
}
