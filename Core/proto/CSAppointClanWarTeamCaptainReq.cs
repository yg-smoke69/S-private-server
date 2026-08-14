using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001659")]
public class CSAppointClanWarTeamCaptainReq
{
	[Token(Token = "0x40095FD")]
	[FieldOffset(Offset = "0x8")]
	public ulong appointee_id;

	[Token(Token = "0x40095FE")]
	[FieldOffset(Offset = "0x10")]
	public ulong clan_id;

	[Token(Token = "0x6007CA3")]
	[Address(RVA = "0x317DC7C", Offset = "0x317DC7C", VA = "0x317DC7C")]
	public CSAppointClanWarTeamCaptainReq()
	{
	}
}
