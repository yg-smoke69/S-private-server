using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016B3")]
public class CSGetSpecialFriendsStateRes
{
	[Token(Token = "0x40096CA")]
	[FieldOffset(Offset = "0x8")]
	public List<IntimacyState> intimacy_state;

	[Token(Token = "0x6007D14")]
	[Address(RVA = "0x3095518", Offset = "0x3095518", VA = "0x3095518")]
	public CSGetSpecialFriendsStateRes()
	{
	}
}
