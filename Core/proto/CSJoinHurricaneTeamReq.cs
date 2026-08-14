using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200194E")]
public class CSJoinHurricaneTeamReq
{
	[Token(Token = "0x4009F65")]
	[FieldOffset(Offset = "0x8")]
	public ulong inviter_id;

	[Token(Token = "0x4009F66")]
	[FieldOffset(Offset = "0x10")]
	public string inviter_nickname;

	[Token(Token = "0x6007FA7")]
	[Address(RVA = "0x30974F4", Offset = "0x30974F4", VA = "0x30974F4")]
	public CSJoinHurricaneTeamReq()
	{
	}
}
