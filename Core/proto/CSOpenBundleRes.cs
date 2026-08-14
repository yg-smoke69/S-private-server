using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015AA")]
public class CSOpenBundleRes
{
	[Token(Token = "0x40093DD")]
	[FieldOffset(Offset = "0x8")]
	public ExchangeChangeData data;

	[Token(Token = "0x40093DE")]
	[FieldOffset(Offset = "0xC")]
	public List<AwardDesc> transfer_to_items;

	[Token(Token = "0x6007BF2")]
	[Address(RVA = "0x3098164", Offset = "0x3098164", VA = "0x3098164")]
	public CSOpenBundleRes()
	{
	}
}
