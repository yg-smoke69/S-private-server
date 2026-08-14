using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002FCC")]
public class Report_SelfDetection
{
	[Token(Token = "0x4012321")]
	[FieldOffset(Offset = "0x8")]
	public List<PingResult> ping_results;

	[Token(Token = "0x4012322")]
	[FieldOffset(Offset = "0xC")]
	public List<TracerouteResult> trace_results;

	[Token(Token = "0x6013F8A")]
	[Address(RVA = "0x2406B20", Offset = "0x2406B20", VA = "0x2406B20")]
	public Report_SelfDetection()
	{
	}
}
