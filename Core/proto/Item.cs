using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001357")]
public class Item
{
	[Token(Token = "0x40088A1")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x40088A2")]
	[FieldOffset(Offset = "0xC")]
	public uint cnt;

	[Token(Token = "0x40088A3")]
	[FieldOffset(Offset = "0x10")]
	public uint expire_time;

	[Token(Token = "0x40088A4")]
	[FieldOffset(Offset = "0x14")]
	public int left_use_times;

	[Token(Token = "0x40088A5")]
	[FieldOffset(Offset = "0x18")]
	public uint history_owned_cnt;

	[Token(Token = "0x40088A6")]
	[FieldOffset(Offset = "0x1C")]
	public uint left_expire_time;

	[Token(Token = "0x40088A7")]
	[FieldOffset(Offset = "0x20")]
	public EInventory.ItemStatus item_status;

	[Token(Token = "0x40088A8")]
	[FieldOffset(Offset = "0x24")]
	public EInventory.ItemType item_type;

	[Token(Token = "0x40088A9")]
	[FieldOffset(Offset = "0x28")]
	public EInventory.ItemSubType item_sub_type;

	[Token(Token = "0x40088AA")]
	[FieldOffset(Offset = "0x2C")]
	public EInventory.InstallmentStatus installment_status;

	[Token(Token = "0x40088AB")]
	[FieldOffset(Offset = "0x30")]
	public uint installment_term;

	[Token(Token = "0x40088AC")]
	[FieldOffset(Offset = "0x34")]
	public uint installment_create_time;

	[Token(Token = "0x40088AD")]
	[FieldOffset(Offset = "0x38")]
	public uint installment_next_pay_time;

	[Token(Token = "0x6007A58")]
	[Address(RVA = "0x30A3EFC", Offset = "0x30A3EFC", VA = "0x30A3EFC")]
	public Item()
	{
	}
}
