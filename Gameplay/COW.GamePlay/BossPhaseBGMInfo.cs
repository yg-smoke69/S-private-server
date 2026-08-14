using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW.GamePlay;

[Serializable]
[Token(Token = "0x2000A77")]
public class BossPhaseBGMInfo
{
	[Token(Token = "0x4005C4B")]
	[FieldOffset(Offset = "0x8")]
	public int phase;

	[Token(Token = "0x4005C4C")]
	[FieldOffset(Offset = "0xC")]
	public List<BossBGMInfo> BgmInfos;

	[Token(Token = "0x60050A6")]
	[Address(RVA = "0x13B69F4", Offset = "0x13B69F4", VA = "0x13B69F4")]
	public BossPhaseBGMInfo()
	{
	}
}
