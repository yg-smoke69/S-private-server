using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AAA")]
public class ExchangeStoreDesc
{
	[Token(Token = "0x400A795")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x400A796")]
	[FieldOffset(Offset = "0xC")]
	public string store_name;

	[Token(Token = "0x400A797")]
	[FieldOffset(Offset = "0x10")]
	public string open_time;

	[Token(Token = "0x400A798")]
	[FieldOffset(Offset = "0x14")]
	public string close_time;

	[Token(Token = "0x400A799")]
	[FieldOffset(Offset = "0x18")]
	public uint open_time_stamp;

	[Token(Token = "0x400A79A")]
	[FieldOffset(Offset = "0x1C")]
	public uint close_time_stamp;

	[Token(Token = "0x400A79B")]
	[FieldOffset(Offset = "0x20")]
	public bool is_show_time;

	[Token(Token = "0x400A79C")]
	[FieldOffset(Offset = "0x21")]
	public bool check_bundle_switch;

	[Token(Token = "0x400A79D")]
	[FieldOffset(Offset = "0x22")]
	public bool need_clan;

	[Token(Token = "0x400A79E")]
	[FieldOffset(Offset = "0x24")]
	public string token_box;

	[Token(Token = "0x6008107")]
	[Address(RVA = "0x309FE98", Offset = "0x309FE98", VA = "0x309FE98")]
	public ExchangeStoreDesc()
	{
	}
}
