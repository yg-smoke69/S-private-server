using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001737")]
public class IAPInfoItem
{
	[Token(Token = "0x4009992")]
	[FieldOffset(Offset = "0x8")]
	public uint pool_id;

	[Token(Token = "0x4009993")]
	[FieldOffset(Offset = "0xC")]
	public uint store_id;

	[Token(Token = "0x4009994")]
	[FieldOffset(Offset = "0x10")]
	public uint create_time;

	[Token(Token = "0x4009995")]
	[FieldOffset(Offset = "0x14")]
	public uint end_time;

	[Token(Token = "0x4009996")]
	[FieldOffset(Offset = "0x18")]
	public EStore.IapType iap_type;

	[Token(Token = "0x4009997")]
	[FieldOffset(Offset = "0x1C")]
	public EStore.RebateCardBillStatus status;

	[Token(Token = "0x4009998")]
	[FieldOffset(Offset = "0x20")]
	public string title;

	[Token(Token = "0x6007D91")]
	[Address(RVA = "0x30A38AC", Offset = "0x30A38AC", VA = "0x30A38AC")]
	public IAPInfoItem()
	{
	}
}
