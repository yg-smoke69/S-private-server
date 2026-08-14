using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013D6")]
public class GetSpecialFriendListRes
{
	[Token(Token = "0x4008B44")]
	[FieldOffset(Offset = "0x8")]
	public List<IntimacyState> intimacy_state;

	[Token(Token = "0x6007AB9")]
	[Address(RVA = "0x30A22D4", Offset = "0x30A22D4", VA = "0x30A22D4")]
	public GetSpecialFriendListRes()
	{
	}
}
