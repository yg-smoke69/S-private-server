using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018AB")]
public class CSAccusationCountReq
{
	[Token(Token = "0x4009D7E")]
	[FieldOffset(Offset = "0x8")]
	public List<AccusationCount> accusation_counts;

	[Token(Token = "0x4009D7F")]
	[FieldOffset(Offset = "0xC")]
	public string noti_region;

	[Token(Token = "0x6007F04")]
	[Address(RVA = "0x317D878", Offset = "0x317D878", VA = "0x317D878")]
	public CSAccusationCountReq()
	{
	}
}
