using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017F2")]
public class CSGetRampageRankRes
{
	[Token(Token = "0x4009BBE")]
	[FieldOffset(Offset = "0x8")]
	public List<RampageRankDesc> rampage_ranks;

	[Token(Token = "0x6007E4C")]
	[Address(RVA = "0x3094DC4", Offset = "0x3094DC4", VA = "0x3094DC4")]
	public CSGetRampageRankRes()
	{
	}
}
