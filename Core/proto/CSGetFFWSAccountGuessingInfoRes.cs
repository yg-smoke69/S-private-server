using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001882")]
public class CSGetFFWSAccountGuessingInfoRes
{
	[Token(Token = "0x4009D1E")]
	[FieldOffset(Offset = "0x8")]
	public List<FFWSTeamResultsDesc> team_results;

	[Token(Token = "0x4009D1F")]
	[FieldOffset(Offset = "0xC")]
	public uint[] ai_guess_results;

	[Token(Token = "0x4009D20")]
	[FieldOffset(Offset = "0x10")]
	public uint[] player_guess_results;

	[Token(Token = "0x4009D21")]
	[FieldOffset(Offset = "0x14")]
	public List<ELimitedEvent.FFWSGuessingAwardStatus> award_status;

	[Token(Token = "0x6007EDB")]
	[Address(RVA = "0x3184948", Offset = "0x3184948", VA = "0x3184948")]
	public CSGetFFWSAccountGuessingInfoRes()
	{
	}
}
