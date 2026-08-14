using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003165")]
public class MatchResultRewardInfo
{
	[Token(Token = "0x4012C1B")]
	[FieldOffset(Offset = "0x8")]
	public BaseItemInfo info;

	[Token(Token = "0x4012C1C")]
	[FieldOffset(Offset = "0xC")]
	public uint cnt;

	[Token(Token = "0x4012C1D")]
	[FieldOffset(Offset = "0x10")]
	public uint debrisOwned;

	[Token(Token = "0x4012C1E")]
	[FieldOffset(Offset = "0x14")]
	public uint debrisMax;

	[Token(Token = "0x4012C1F")]
	[FieldOffset(Offset = "0x18")]
	public uint dailyObtain;

	[Token(Token = "0x4012C20")]
	[FieldOffset(Offset = "0x1C")]
	public uint dailyLimit;

	[Token(Token = "0x4012C21")]
	[FieldOffset(Offset = "0x20")]
	public bool reachAvatarMax;

	[Token(Token = "0x4012C22")]
	[FieldOffset(Offset = "0x24")]
	public MatchResultItemState RewardState;

	[Token(Token = "0x6014B74")]
	[Address(RVA = "0x154491C", Offset = "0x154491C", VA = "0x154491C")]
	public MatchResultRewardInfo()
	{
	}
}
