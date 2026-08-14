using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014E3")]
public class LimitedEventEPRewards
{
	[Token(Token = "0x4009020")]
	[FieldOffset(Offset = "0x8")]
	public List<LimitedEventEPRewardStatus> rewards;

	[Token(Token = "0x6007B38")]
	[Address(RVA = "0x30A4A04", Offset = "0x30A4A04", VA = "0x30A4A04")]
	public LimitedEventEPRewards()
	{
	}
}
