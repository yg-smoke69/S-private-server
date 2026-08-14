using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200168E")]
public class CSGetLinkProfileListRes
{
	[Token(Token = "0x400966A")]
	[FieldOffset(Offset = "0x8")]
	public List<LinkProfile> link_profile_list;

	[Token(Token = "0x6007CD8")]
	[Address(RVA = "0x3186DB4", Offset = "0x3186DB4", VA = "0x3186DB4")]
	public CSGetLinkProfileListRes()
	{
	}
}
