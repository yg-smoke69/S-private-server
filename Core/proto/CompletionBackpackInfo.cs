using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016EB")]
public class CompletionBackpackInfo
{
	[Token(Token = "0x40097F2")]
	[FieldOffset(Offset = "0x8")]
	public uint lottery_id;

	[Token(Token = "0x40097F3")]
	[FieldOffset(Offset = "0xC")]
	public List<CompletionItem> items;

	[Token(Token = "0x6007D45")]
	[Address(RVA = "0x309D68C", Offset = "0x309D68C", VA = "0x309D68C")]
	public CompletionBackpackInfo()
	{
	}
}
