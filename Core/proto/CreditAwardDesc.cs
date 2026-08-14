using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C05")]
public class CreditAwardDesc
{
	[Token(Token = "0x400B04B")]
	[FieldOffset(Offset = "0x8")]
	public uint index;

	[Token(Token = "0x400B04C")]
	[FieldOffset(Offset = "0xC")]
	public ECreditScore.AwardType award_type;

	[Token(Token = "0x400B04D")]
	[FieldOffset(Offset = "0x10")]
	public uint need_credit_score;

	[Token(Token = "0x400B04E")]
	[FieldOffset(Offset = "0x14")]
	public List<AwardDesc> rewards;

	[Token(Token = "0x6008260")]
	[Address(RVA = "0x309D85C", Offset = "0x309D85C", VA = "0x309D85C")]
	public CreditAwardDesc()
	{
	}
}
