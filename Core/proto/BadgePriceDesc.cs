using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A7E")]
public class BadgePriceDesc
{
	[Token(Token = "0x400A5D2")]
	[FieldOffset(Offset = "0x8")]
	public uint ep_event_id;

	[Token(Token = "0x400A5D3")]
	[FieldOffset(Offset = "0xC")]
	public string region;

	[Token(Token = "0x400A5D4")]
	[FieldOffset(Offset = "0x10")]
	public EInventory.CurrencyType cost_type;

	[Token(Token = "0x400A5D5")]
	[FieldOffset(Offset = "0x14")]
	public uint cost_value;

	[Token(Token = "0x400A5D6")]
	[FieldOffset(Offset = "0x18")]
	public uint discount_value1;

	[Token(Token = "0x400A5D7")]
	[FieldOffset(Offset = "0x1C")]
	public uint discount_value2;

	[Token(Token = "0x400A5D8")]
	[FieldOffset(Offset = "0x20")]
	public uint discount_value3;

	[Token(Token = "0x60080DB")]
	[Address(RVA = "0x317B66C", Offset = "0x317B66C", VA = "0x317B66C")]
	public BadgePriceDesc()
	{
	}
}
