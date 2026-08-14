using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001947")]
public class CSMicMuteAccusationCountReq
{
	[Token(Token = "0x4009F58")]
	[FieldOffset(Offset = "0x8")]
	public List<MicMuteAccusationCount> accusation_counts;

	[Token(Token = "0x4009F59")]
	[FieldOffset(Offset = "0xC")]
	public string noti_region;

	[Token(Token = "0x6007FA0")]
	[Address(RVA = "0x3097A70", Offset = "0x3097A70", VA = "0x3097A70")]
	public CSMicMuteAccusationCountReq()
	{
	}
}
