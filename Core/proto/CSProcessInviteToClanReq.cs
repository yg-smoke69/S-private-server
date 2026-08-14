using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200162D")]
public class CSProcessInviteToClanReq
{
	[Token(Token = "0x4009554")]
	[FieldOffset(Offset = "0x8")]
	public ulong inviter_id;

	[Token(Token = "0x4009555")]
	[FieldOffset(Offset = "0x10")]
	public ulong clan_id;

	[Token(Token = "0x4009556")]
	[FieldOffset(Offset = "0x18")]
	public bool is_clan_war_recruit;

	[Token(Token = "0x6007C77")]
	[Address(RVA = "0x309887C", Offset = "0x309887C", VA = "0x309887C")]
	public CSProcessInviteToClanReq()
	{
	}
}
