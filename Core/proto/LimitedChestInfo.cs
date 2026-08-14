using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200191C")]
public class LimitedChestInfo
{
	[Token(Token = "0x4009EC9")]
	[FieldOffset(Offset = "0x8")]
	public uint chest_id;

	[Token(Token = "0x4009ECA")]
	[FieldOffset(Offset = "0xC")]
	public List<LimitedChestGoods> limited_chest_goods;

	[Token(Token = "0x6007F75")]
	[Address(RVA = "0x30A48C0", Offset = "0x30A48C0", VA = "0x30A48C0")]
	public LimitedChestInfo()
	{
	}
}
