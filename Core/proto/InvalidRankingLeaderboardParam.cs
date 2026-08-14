using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A74")]
public class InvalidRankingLeaderboardParam
{
	[Token(Token = "0x400A592")]
	[FieldOffset(Offset = "0x8")]
	public uint games_played;

	[Token(Token = "0x400A593")]
	[FieldOffset(Offset = "0xC")]
	public float KD;

	[Token(Token = "0x400A594")]
	[FieldOffset(Offset = "0x10")]
	public float win_rate;

	[Token(Token = "0x400A595")]
	[FieldOffset(Offset = "0x14")]
	public uint min_games;

	[Token(Token = "0x400A596")]
	[FieldOffset(Offset = "0x18")]
	public float combine_KD;

	[Token(Token = "0x400A597")]
	[FieldOffset(Offset = "0x1C")]
	public float combine_Headshot;

	[Token(Token = "0x60080D1")]
	[Address(RVA = "0x30A3E68", Offset = "0x30A3E68", VA = "0x30A3E68")]
	public InvalidRankingLeaderboardParam()
	{
	}
}
