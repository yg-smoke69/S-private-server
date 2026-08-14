using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001976")]
public class CSCustomEventStorePurchaseRes
{
	[Token(Token = "0x4009FD9")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x4009FDA")]
	[FieldOffset(Offset = "0xC")]
	public uint item_amount;

	[Token(Token = "0x4009FDB")]
	[FieldOffset(Offset = "0x10")]
	public uint purchase_times;

	[Token(Token = "0x6007FCF")]
	[Address(RVA = "0x317F560", Offset = "0x317F560", VA = "0x317F560")]
	public CSCustomEventStorePurchaseRes()
	{
	}
}
