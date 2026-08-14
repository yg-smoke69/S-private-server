using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001995")]
public class MatchReplayReportInfo
{
	[Token(Token = "0x400A021")]
	[FieldOffset(Offset = "0x8")]
	public uint create_time;

	[Token(Token = "0x400A022")]
	[FieldOffset(Offset = "0xC")]
	public uint end_time;

	[Token(Token = "0x400A023")]
	[FieldOffset(Offset = "0x10")]
	public uint game_mode;

	[Token(Token = "0x400A024")]
	[FieldOffset(Offset = "0x14")]
	public uint group_mode;

	[Token(Token = "0x400A025")]
	[FieldOffset(Offset = "0x18")]
	public List<MatchReplayOffender> offenders;

	[Token(Token = "0x6007FF0")]
	[Address(RVA = "0x30A7CAC", Offset = "0x30A7CAC", VA = "0x30A7CAC")]
	public MatchReplayReportInfo()
	{
	}
}
