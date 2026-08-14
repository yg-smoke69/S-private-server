using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B2D")]
public class CustomEventEntranceDesc
{
	[Token(Token = "0x400AAD2")]
	[FieldOffset(Offset = "0x8")]
	public uint custom_event_id;

	[Token(Token = "0x400AAD3")]
	[FieldOffset(Offset = "0xC")]
	public uint priority;

	[Token(Token = "0x400AAD4")]
	[FieldOffset(Offset = "0x10")]
	public uint entrance_type;

	[Token(Token = "0x400AAD5")]
	[FieldOffset(Offset = "0x14")]
	public uint start_timestamp;

	[Token(Token = "0x400AAD6")]
	[FieldOffset(Offset = "0x18")]
	public uint end_timestamp;

	[Token(Token = "0x400AAD7")]
	[FieldOffset(Offset = "0x1C")]
	public bool display;

	[Token(Token = "0x400AAD8")]
	[FieldOffset(Offset = "0x1D")]
	public bool is_open;

	[Token(Token = "0x400AAD9")]
	[FieldOffset(Offset = "0x20")]
	public uint cdn_id;

	[Token(Token = "0x400AADA")]
	[FieldOffset(Offset = "0x24")]
	public uint disable_cdn_id;

	[Token(Token = "0x400AADB")]
	[FieldOffset(Offset = "0x28")]
	public uint go_pos;

	[Token(Token = "0x400AADC")]
	[FieldOffset(Offset = "0x2C")]
	public string param;

	[Token(Token = "0x6008188")]
	[Address(RVA = "0x309E054", Offset = "0x309E054", VA = "0x309E054")]
	public CustomEventEntranceDesc()
	{
	}
}
