using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200170D")]
public class GetBasicEPInfoRes
{
	[Token(Token = "0x400985B")]
	[FieldOffset(Offset = "0x8")]
	public bool owned_pass;

	[Token(Token = "0x400985C")]
	[FieldOffset(Offset = "0xC")]
	public uint ep_event_id;

	[Token(Token = "0x400985D")]
	[FieldOffset(Offset = "0x10")]
	public long start_time;

	[Token(Token = "0x400985E")]
	[FieldOffset(Offset = "0x18")]
	public long end_time;

	[Token(Token = "0x400985F")]
	[FieldOffset(Offset = "0x20")]
	public uint ep_badge;

	[Token(Token = "0x4009860")]
	[FieldOffset(Offset = "0x24")]
	public uint gold_limit_improved;

	[Token(Token = "0x4009861")]
	[FieldOffset(Offset = "0x28")]
	public bool owned_fp_challenge;

	[Token(Token = "0x4009862")]
	[FieldOffset(Offset = "0x2C")]
	public uint badge_cnt;

	[Token(Token = "0x4009863")]
	[FieldOffset(Offset = "0x30")]
	public TicketPriceDesc ep_price;

	[Token(Token = "0x6007D67")]
	[Address(RVA = "0x30A1E94", Offset = "0x30A1E94", VA = "0x30A1E94")]
	public GetBasicEPInfoRes()
	{
	}
}
