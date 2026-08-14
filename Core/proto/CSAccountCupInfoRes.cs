using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200156F")]
public class CSAccountCupInfoRes
{
	[Token(Token = "0x400931F")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009320")]
	[FieldOffset(Offset = "0x10")]
	public uint cup_type;

	[Token(Token = "0x4009321")]
	[FieldOffset(Offset = "0x14")]
	public uint cup_id;

	[Token(Token = "0x4009322")]
	[FieldOffset(Offset = "0x18")]
	public uint tier;

	[Token(Token = "0x4009323")]
	[FieldOffset(Offset = "0x1C")]
	public CupTeamInfo team_info;

	[Token(Token = "0x4009324")]
	[FieldOffset(Offset = "0x20")]
	public ulong team_id;

	[Token(Token = "0x4009325")]
	[FieldOffset(Offset = "0x28")]
	public bool award_claimed;

	[Token(Token = "0x4009326")]
	[FieldOffset(Offset = "0x29")]
	public bool use_ticket;

	[Token(Token = "0x4009327")]
	[FieldOffset(Offset = "0x2C")]
	public uint member_type;

	[Token(Token = "0x4009328")]
	[FieldOffset(Offset = "0x30")]
	public ulong join_at;

	[Token(Token = "0x6007BB7")]
	[Address(RVA = "0x317D7CC", Offset = "0x317D7CC", VA = "0x317D7CC")]
	public CSAccountCupInfoRes()
	{
	}
}
