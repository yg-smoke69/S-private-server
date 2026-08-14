using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016F9")]
public class CSEPClaimRewardReq
{
	[Token(Token = "0x4009829")]
	[FieldOffset(Offset = "0x8")]
	public List<unlock> unlock_reward;

	[Token(Token = "0x400982A")]
	[FieldOffset(Offset = "0xC")]
	public string nickname;

	[Token(Token = "0x400982B")]
	[FieldOffset(Offset = "0x10")]
	public bool claim_max_reward;

	[Token(Token = "0x6007D53")]
	[Address(RVA = "0x317FB88", Offset = "0x317FB88", VA = "0x317FB88")]
	public CSEPClaimRewardReq()
	{
	}
}
