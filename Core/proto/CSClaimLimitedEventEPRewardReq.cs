using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001868")]
public class CSClaimLimitedEventEPRewardReq
{
	[Token(Token = "0x4009CEF")]
	[FieldOffset(Offset = "0x8")]
	public uint event_id;

	[Token(Token = "0x4009CF0")]
	[FieldOffset(Offset = "0xC")]
	public List<unlock> unlock_reward;

	[Token(Token = "0x6007EC1")]
	[Address(RVA = "0x317E87C", Offset = "0x317E87C", VA = "0x317E87C")]
	public CSClaimLimitedEventEPRewardReq()
	{
	}
}
