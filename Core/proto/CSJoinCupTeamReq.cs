using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200157B")]
public class CSJoinCupTeamReq
{
	[Token(Token = "0x400934C")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x400934D")]
	[FieldOffset(Offset = "0x10")]
	public bool recruit_by_chat;

	[Token(Token = "0x400934E")]
	[FieldOffset(Offset = "0x14")]
	public uint applicant_tier;

	[Token(Token = "0x400934F")]
	[FieldOffset(Offset = "0x18")]
	public CupGroupMemberInfo group_member_info;

	[Token(Token = "0x6007BC3")]
	[Address(RVA = "0x30974DC", Offset = "0x30974DC", VA = "0x30974DC")]
	public CSJoinCupTeamReq()
	{
	}
}
