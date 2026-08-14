using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001627")]
public class CSClanMemberListRes
{
	[Token(Token = "0x4009542")]
	[FieldOffset(Offset = "0x8")]
	public List<CSClanMemberRes> member_list;

	[Token(Token = "0x6007C71")]
	[Address(RVA = "0x317EC88", Offset = "0x317EC88", VA = "0x317EC88")]
	public CSClanMemberListRes()
	{
	}
}
