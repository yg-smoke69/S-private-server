using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001919")]
public class CSPurchaseLimitedChestRes
{
	[Token(Token = "0x4009EC0")]
	[FieldOffset(Offset = "0x8")]
	public List<ExchangedAward> chest_goods;

	[Token(Token = "0x4009EC1")]
	[FieldOffset(Offset = "0xC")]
	public bool has_big_reward;

	[Token(Token = "0x4009EC2")]
	[FieldOffset(Offset = "0x10")]
	public uint prize_id;

	[Token(Token = "0x6007F72")]
	[Address(RVA = "0x3098934", Offset = "0x3098934", VA = "0x3098934")]
	public CSPurchaseLimitedChestRes()
	{
	}
}
