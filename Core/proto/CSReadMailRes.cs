using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200161C")]
public class CSReadMailRes
{
	[Token(Token = "0x4009533")]
	[FieldOffset(Offset = "0x8")]
	public AwardData rewards;

	[Token(Token = "0x4009534")]
	[FieldOffset(Offset = "0xC")]
	public List<ExchangedAward> exchangedAwards;

	[Token(Token = "0x6007C66")]
	[Address(RVA = "0x3098E48", Offset = "0x3098E48", VA = "0x3098E48")]
	public CSReadMailRes()
	{
	}
}
