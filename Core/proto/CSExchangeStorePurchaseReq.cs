using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200172E")]
public class CSExchangeStorePurchaseReq
{
	[Token(Token = "0x4009976")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x4009977")]
	[FieldOffset(Offset = "0xC")]
	public uint commodity_id;

	[Token(Token = "0x4009978")]
	[FieldOffset(Offset = "0x10")]
	public ulong trans_id;

	[Token(Token = "0x4009979")]
	[FieldOffset(Offset = "0x18")]
	public uint cnt;

	[Token(Token = "0x400997A")]
	[FieldOffset(Offset = "0x1C")]
	public uint currency_id;

	[Token(Token = "0x400997B")]
	[FieldOffset(Offset = "0x20")]
	public uint currency_price;

	[Token(Token = "0x400997C")]
	[FieldOffset(Offset = "0x24")]
	public uint gems_cost;

	[Token(Token = "0x400997D")]
	[FieldOffset(Offset = "0x28")]
	public uint entry_from;

	[Token(Token = "0x6007D88")]
	[Address(RVA = "0x317FF24", Offset = "0x317FF24", VA = "0x317FF24")]
	public CSExchangeStorePurchaseReq()
	{
	}
}
