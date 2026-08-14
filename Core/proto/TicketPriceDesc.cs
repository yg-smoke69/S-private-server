using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A8C")]
public class TicketPriceDesc
{
	[Token(Token = "0x400A62A")]
	[FieldOffset(Offset = "0x8")]
	public uint ep_event_id;

	[Token(Token = "0x400A62B")]
	[FieldOffset(Offset = "0xC")]
	public string region;

	[Token(Token = "0x400A62C")]
	[FieldOffset(Offset = "0x10")]
	public EInventory.CurrencyType cost_type;

	[Token(Token = "0x400A62D")]
	[FieldOffset(Offset = "0x14")]
	public uint cost_value;

	[Token(Token = "0x400A62E")]
	[FieldOffset(Offset = "0x18")]
	public uint bundle_value;

	[Token(Token = "0x400A62F")]
	[FieldOffset(Offset = "0x1C")]
	public uint bundle_badge;

	[Token(Token = "0x400A630")]
	[FieldOffset(Offset = "0x20")]
	public uint bundle_reward_item1;

	[Token(Token = "0x400A631")]
	[FieldOffset(Offset = "0x24")]
	public uint bundle_reward_num1;

	[Token(Token = "0x400A632")]
	[FieldOffset(Offset = "0x28")]
	public uint bundle_reward_time1;

	[Token(Token = "0x400A633")]
	[FieldOffset(Offset = "0x2C")]
	public bool is_customized;

	[Token(Token = "0x400A634")]
	[FieldOffset(Offset = "0x30")]
	public string customize_start_time;

	[Token(Token = "0x400A635")]
	[FieldOffset(Offset = "0x34")]
	public string customize_end_time;

	[Token(Token = "0x400A636")]
	[FieldOffset(Offset = "0x38")]
	public long customize_start_timestamp;

	[Token(Token = "0x400A637")]
	[FieldOffset(Offset = "0x40")]
	public long customize_end_timestamp;

	[Token(Token = "0x60080E9")]
	[Address(RVA = "0x33E38BC", Offset = "0x33E38BC", VA = "0x33E38BC")]
	public TicketPriceDesc()
	{
	}
}
