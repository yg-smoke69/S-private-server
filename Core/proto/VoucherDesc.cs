using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019B3")]
public class VoucherDesc
{
	[Token(Token = "0x400A10F")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x400A110")]
	[FieldOffset(Offset = "0xC")]
	public string name;

	[Token(Token = "0x400A111")]
	[FieldOffset(Offset = "0x10")]
	public EInventory.VoucherType voucher_type;

	[Token(Token = "0x400A112")]
	[FieldOffset(Offset = "0x14")]
	public EInventory.ItemType deduct_item_type;

	[Token(Token = "0x400A113")]
	[FieldOffset(Offset = "0x18")]
	public uint deduct_item_id;

	[Token(Token = "0x400A114")]
	[FieldOffset(Offset = "0x1C")]
	public uint max_mount;

	[Token(Token = "0x400A115")]
	[FieldOffset(Offset = "0x20")]
	public uint deduct_mount;

	[Token(Token = "0x600800A")]
	[Address(RVA = "0x33E4FD8", Offset = "0x33E4FD8", VA = "0x33E4FD8")]
	public VoucherDesc()
	{
	}
}
