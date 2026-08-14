using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018A9")]
public class CSPoolLeaderboardClaimRewardRes
{
	[Token(Token = "0x4009D7B")]
	[FieldOffset(Offset = "0x8")]
	public ExchangeChangeData awards;

	[Token(Token = "0x4009D7C")]
	[FieldOffset(Offset = "0xC")]
	public uint position;

	[Token(Token = "0x6007F02")]
	[Address(RVA = "0x3098710", Offset = "0x3098710", VA = "0x3098710")]
	public CSPoolLeaderboardClaimRewardRes()
	{
	}
}
