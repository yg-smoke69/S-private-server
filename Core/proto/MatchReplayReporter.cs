using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001997")]
public class MatchReplayReporter
{
	[Token(Token = "0x400A029")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x400A02A")]
	[FieldOffset(Offset = "0x10")]
	public string nickname;

	[Token(Token = "0x400A02B")]
	[FieldOffset(Offset = "0x14")]
	public ECreditScore.ReportType report_type;

	[Token(Token = "0x400A02C")]
	[FieldOffset(Offset = "0x18")]
	public uint reporter_time_ms;

	[Token(Token = "0x6007FF2")]
	[Address(RVA = "0x30A7D38", Offset = "0x30A7D38", VA = "0x30A7D38")]
	public MatchReplayReporter()
	{
	}
}
