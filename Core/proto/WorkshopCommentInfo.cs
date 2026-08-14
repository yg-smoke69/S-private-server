using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014C0")]
public class WorkshopCommentInfo
{
	[Token(Token = "0x4008FB8")]
	[FieldOffset(Offset = "0x8")]
	public List<WorkshopCommentTag> comment_tags;

	[Token(Token = "0x6007B21")]
	[Address(RVA = "0x33E6180", Offset = "0x33E6180", VA = "0x33E6180")]
	public WorkshopCommentInfo()
	{
	}
}
