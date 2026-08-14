using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022DB")]
public class OptionalRewardRankInfoWndCfg : RewardWndCfg
{
	[Token(Token = "0x400D9BA")]
	[FieldOffset(Offset = "0x34")]
	public ELadderRankUpMatchType LadderRankUpMatchType;

	[Token(Token = "0x400D9BB")]
	[FieldOffset(Offset = "0x38")]
	public string rankName;

	[Token(Token = "0x400D9BC")]
	[FieldOffset(Offset = "0x3C")]
	public ResourceID BigIconRes;

	[Token(Token = "0x400D9BD")]
	[FieldOffset(Offset = "0x40")]
	public uint rank;

	[Token(Token = "0x600C008")]
	[Address(RVA = "0x28C94D8", Offset = "0x28C94D8", VA = "0x28C94D8")]
	public OptionalRewardRankInfoWndCfg()
	{
	}
}
