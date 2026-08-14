using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001587")]
public class CupTeamInvitationRes
{
	[Token(Token = "0x4009368")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009369")]
	[FieldOffset(Offset = "0x10")]
	public uint tier;

	[Token(Token = "0x400936A")]
	[FieldOffset(Offset = "0x18")]
	public ulong team_id;

	[Token(Token = "0x400936B")]
	[FieldOffset(Offset = "0x20")]
	public uint cup_type;

	[Token(Token = "0x400936C")]
	[FieldOffset(Offset = "0x24")]
	public uint cup_id;

	[Token(Token = "0x400936D")]
	[FieldOffset(Offset = "0x28")]
	public ulong inviter_id;

	[Token(Token = "0x400936E")]
	[FieldOffset(Offset = "0x30")]
	public ulong create_at;

	[Token(Token = "0x6007BCF")]
	[Address(RVA = "0x309DF90", Offset = "0x309DF90", VA = "0x309DF90")]
	public CupTeamInvitationRes()
	{
	}
}
