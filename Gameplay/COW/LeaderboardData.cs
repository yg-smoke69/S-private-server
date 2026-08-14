using COW.GamePlay;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002051")]
internal class LeaderboardData
{
	[Token(Token = "0x400CA93")]
	[FieldOffset(Offset = "0x8")]
	public IHAAMHPPLMG mPlayerId;

	[Token(Token = "0x400CA94")]
	[FieldOffset(Offset = "0x20")]
	public bool mIsLocalPlayer;

	[Token(Token = "0x400CA95")]
	[FieldOffset(Offset = "0x24")]
	public string mName;

	[Token(Token = "0x400CA96")]
	[FieldOffset(Offset = "0x28")]
	public string mClan;

	[Token(Token = "0x400CA97")]
	[FieldOffset(Offset = "0x2C")]
	public int mKill;

	[Token(Token = "0x400CA98")]
	[FieldOffset(Offset = "0x30")]
	public int mDead;

	[Token(Token = "0x400CA99")]
	[FieldOffset(Offset = "0x34")]
	public int mAssist;

	[Token(Token = "0x400CA9A")]
	[FieldOffset(Offset = "0x38")]
	public int mTotalDamage;

	[Token(Token = "0x400CA9B")]
	[FieldOffset(Offset = "0x3C")]
	public int mTeamIndex;

	[Token(Token = "0x600A4D7")]
	[Address(RVA = "0x1EF9C6C", Offset = "0x1EF9C6C", VA = "0x1EF9C6C")]
	public LeaderboardData()
	{
	}
}
