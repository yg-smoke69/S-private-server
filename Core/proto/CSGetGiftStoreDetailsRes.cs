using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001729")]
public class CSGetGiftStoreDetailsRes
{
	[Token(Token = "0x4009965")]
	[FieldOffset(Offset = "0x8")]
	public uint store_id;

	[Token(Token = "0x4009966")]
	[FieldOffset(Offset = "0xC")]
	public List<GiftItem> items;

	[Token(Token = "0x4009967")]
	[FieldOffset(Offset = "0x10")]
	public uint send_gift_times_today;

	[Token(Token = "0x6007D83")]
	[Address(RVA = "0x3185A80", Offset = "0x3185A80", VA = "0x3185A80")]
	public CSGetGiftStoreDetailsRes()
	{
	}
}
