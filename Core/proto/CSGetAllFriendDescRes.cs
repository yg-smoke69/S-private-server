using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016BB")]
public class CSGetAllFriendDescRes
{
	[Token(Token = "0x40096D8")]
	[FieldOffset(Offset = "0x8")]
	public List<RelationTypeInfoDesc> relation_type_info_desc;

	[Token(Token = "0x6007D1C")]
	[Address(RVA = "0x31817B4", Offset = "0x31817B4", VA = "0x31817B4")]
	public CSGetAllFriendDescRes()
	{
	}
}
