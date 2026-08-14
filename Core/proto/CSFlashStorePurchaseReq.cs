using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001735")]
public class CSFlashStorePurchaseReq
{
	[Token(Token = "0x4009989")]
	[FieldOffset(Offset = "0x8")]
	public uint flash_store_id;

	[Token(Token = "0x400998A")]
	[FieldOffset(Offset = "0xC")]
	public uint store_id;

	[Token(Token = "0x400998B")]
	[FieldOffset(Offset = "0x10")]
	public ulong trans_id;

	[Token(Token = "0x400998C")]
	[FieldOffset(Offset = "0x18")]
	public uint cnt;

	[Token(Token = "0x400998D")]
	[FieldOffset(Offset = "0x1C")]
	public uint flash_gem_price;

	[Token(Token = "0x400998E")]
	[FieldOffset(Offset = "0x20")]
	public uint gem_price;

	[Token(Token = "0x6007D8F")]
	[Address(RVA = "0x3180750", Offset = "0x3180750", VA = "0x3180750")]
	public CSFlashStorePurchaseReq()
	{
	}
}
