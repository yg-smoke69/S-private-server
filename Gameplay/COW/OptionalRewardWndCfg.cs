using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20022D9")]
public class OptionalRewardWndCfg : RewardWndCfg
{
	[Token(Token = "0x400D9B4")]
	[FieldOffset(Offset = "0x34")]
	public List<OptionalBundleShowData> m_OptionalBundleList;

	[Token(Token = "0x600C007")]
	[Address(RVA = "0x28C94E0", Offset = "0x28C94E0", VA = "0x28C94E0")]
	public OptionalRewardWndCfg()
	{
	}
}
