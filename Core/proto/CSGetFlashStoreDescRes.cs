using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001731")]
public class CSGetFlashStoreDescRes
{
	[Token(Token = "0x4009981")]
	[FieldOffset(Offset = "0x8")]
	public FlashStoreDesc flash_store;

	[Token(Token = "0x4009982")]
	[FieldOffset(Offset = "0xC")]
	public List<FlashStoreGoodsDesc> flash_store_goods;

	[Token(Token = "0x6007D8B")]
	[Address(RVA = "0x3184EB8", Offset = "0x3184EB8", VA = "0x3184EB8")]
	public CSGetFlashStoreDescRes()
	{
	}
}
