using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001996")]
public class MatchReplayOffender
{
	[Token(Token = "0x400A026")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x400A027")]
	[FieldOffset(Offset = "0x10")]
	public string nickname;

	[Token(Token = "0x400A028")]
	[FieldOffset(Offset = "0x14")]
	public List<MatchReplayReporter> reporters;

	[Token(Token = "0x6007FF1")]
	[Address(RVA = "0x30A7BD8", Offset = "0x30A7BD8", VA = "0x30A7BD8")]
	public MatchReplayOffender()
	{
	}
}
