using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016B7")]
public class CSGetIntimacyRankAwardInfoRes
{
	[Token(Token = "0x40096D1")]
	[FieldOffset(Offset = "0x8")]
	public List<SpecificIntimacyRankAwardInfo> award_info_lists;

	[Token(Token = "0x40096D2")]
	[FieldOffset(Offset = "0xC")]
	public List<IntimacyAwardDesc> intimacy_awards;

	[Token(Token = "0x6007D18")]
	[Address(RVA = "0x3186484", Offset = "0x3186484", VA = "0x3186484")]
	public CSGetIntimacyRankAwardInfoRes()
	{
	}
}
