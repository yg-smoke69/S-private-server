using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015A5")]
public class CSPurchaseReq
{
	[Token(Token = "0x40093C6")]
	[FieldOffset(Offset = "0x8")]
	public uint store_item_id;

	[Token(Token = "0x40093C7")]
	[FieldOffset(Offset = "0x10")]
	public ulong trans_id;

	[Token(Token = "0x40093C8")]
	[FieldOffset(Offset = "0x18")]
	public uint cnt;

	[Token(Token = "0x40093C9")]
	[FieldOffset(Offset = "0x1C")]
	public uint currency_type;

	[Token(Token = "0x40093CA")]
	[FieldOffset(Offset = "0x20")]
	public uint price;

	[Token(Token = "0x40093CB")]
	[FieldOffset(Offset = "0x24")]
	public uint voucher_id;

	[Token(Token = "0x40093CC")]
	[FieldOffset(Offset = "0x28")]
	public EInventory.StorePromotionType promotion_type;

	[Token(Token = "0x40093CD")]
	[FieldOffset(Offset = "0x2C")]
	public bool is_offer;

	[Token(Token = "0x40093CE")]
	[FieldOffset(Offset = "0x30")]
	public ulong room_id;

	[Token(Token = "0x40093CF")]
	[FieldOffset(Offset = "0x38")]
	public bool is_quick_purchase;

	[Token(Token = "0x6007BED")]
	[Address(RVA = "0x30989D0", Offset = "0x30989D0", VA = "0x30989D0")]
	public CSPurchaseReq()
	{
	}
}
