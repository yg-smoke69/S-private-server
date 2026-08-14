using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001378")]
public class ChallengeIDs
{
	[Token(Token = "0x400899E")]
	[FieldOffset(Offset = "0x8")]
	public uint[] challengeIDs;

	[Token(Token = "0x400899F")]
	[FieldOffset(Offset = "0xC")]
	public uint daily_challenge_completed_cnt;

	[Token(Token = "0x40089A0")]
	[FieldOffset(Offset = "0x10")]
	public uint elite_challenge_completed_cnt;

	[Token(Token = "0x40089A1")]
	[FieldOffset(Offset = "0x14")]
	public uint veteran_challenge_completed_cnt;

	[Token(Token = "0x40089A2")]
	[FieldOffset(Offset = "0x18")]
	public uint[] weeklyIDs;

	[Token(Token = "0x6007A79")]
	[Address(RVA = "0x309AD60", Offset = "0x309AD60", VA = "0x309AD60")]
	public ChallengeIDs()
	{
	}
}
