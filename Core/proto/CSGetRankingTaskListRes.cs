using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001991")]
public class CSGetRankingTaskListRes
{
	[Token(Token = "0x400A01C")]
	[FieldOffset(Offset = "0x8")]
	public List<RankingTaskInfo> tasks;

	[Token(Token = "0x6007FEC")]
	[Address(RVA = "0x3094F80", Offset = "0x3094F80", VA = "0x3094F80")]
	public CSGetRankingTaskListRes()
	{
	}
}
