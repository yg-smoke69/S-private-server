using System;
using Il2CppDummyDll;

namespace COW.GamePlay;

[Serializable]
[Token(Token = "0x2000A76")]
public class BossBGMInfo
{
	[Token(Token = "0x4005C49")]
	[FieldOffset(Offset = "0x8")]
	public string BgmResIDStr;

	[Token(Token = "0x4005C4A")]
	[FieldOffset(Offset = "0xC")]
	public float Duration;

	[Token(Token = "0x60050A5")]
	[Address(RVA = "0x13B69EC", Offset = "0x13B69EC", VA = "0x13B69EC")]
	public BossBGMInfo()
	{
	}
}
