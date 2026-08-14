using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002086")]
public class FriendAccountInfoWithCupTeamInfo
{
	[Token(Token = "0x400CBE9")]
	[FieldOffset(Offset = "0x8")]
	public FriendAccountInfo FriendAccountInfo;

	[Token(Token = "0x400CBEA")]
	[FieldOffset(Offset = "0xC")]
	public CupTeamInfo CupTeamInfo;

	[Token(Token = "0x400CBEB")]
	[FieldOffset(Offset = "0x10")]
	public uint FriendNumInSameCupTeam;

	[Token(Token = "0x600A740")]
	[Address(RVA = "0xDF1560", Offset = "0xDF1560", VA = "0xDF1560")]
	public FriendAccountInfoWithCupTeamInfo()
	{
	}
}
