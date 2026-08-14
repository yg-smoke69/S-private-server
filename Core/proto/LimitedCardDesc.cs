using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019A0")]
public class LimitedCardDesc
{
	[Token(Token = "0x400A0C3")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A0C4")]
	[FieldOffset(Offset = "0xC")]
	public EInventory.LimitedCardType card_type;

	[Token(Token = "0x400A0C5")]
	[FieldOffset(Offset = "0x10")]
	public uint effected_id;

	[Token(Token = "0x400A0C6")]
	[FieldOffset(Offset = "0x14")]
	public string name;

	[Token(Token = "0x400A0C7")]
	[FieldOffset(Offset = "0x18")]
	public uint expire_mins;

	[Token(Token = "0x400A0C8")]
	[FieldOffset(Offset = "0x1C")]
	public int left_use_times;

	[Token(Token = "0x400A0C9")]
	[FieldOffset(Offset = "0x20")]
	public uint discount;

	[Token(Token = "0x400A0CA")]
	[FieldOffset(Offset = "0x24")]
	public uint take_gift_count;

	[Token(Token = "0x6007FF7")]
	[Address(RVA = "0x30A4768", Offset = "0x30A4768", VA = "0x30A4768")]
	public LimitedCardDesc()
	{
	}
}
