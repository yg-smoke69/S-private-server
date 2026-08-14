using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016B4")]
public class CSGetSpecialFriendListRes
{
	[Token(Token = "0x40096CB")]
	[FieldOffset(Offset = "0x8")]
	public List<IntimacyState> intimacy_state;

	[Token(Token = "0x6007D15")]
	[Address(RVA = "0x3095484", Offset = "0x3095484", VA = "0x3095484")]
	public CSGetSpecialFriendListRes()
	{
	}
}
