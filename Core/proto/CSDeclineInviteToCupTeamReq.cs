using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001584")]
public class CSDeclineInviteToCupTeamReq
{
	[Token(Token = "0x4009362")]
	[FieldOffset(Offset = "0x8")]
	public ulong[] inviter_ids;

	[Token(Token = "0x4009363")]
	[FieldOffset(Offset = "0xC")]
	public uint cup_type;

	[Token(Token = "0x4009364")]
	[FieldOffset(Offset = "0x10")]
	public uint cup_id;

	[Token(Token = "0x6007BCC")]
	[Address(RVA = "0x317F578", Offset = "0x317F578", VA = "0x317F578")]
	public CSDeclineInviteToCupTeamReq()
	{
	}
}
