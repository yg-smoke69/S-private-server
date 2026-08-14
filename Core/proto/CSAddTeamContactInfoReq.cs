using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001798")]
public class CSAddTeamContactInfoReq
{
	[Token(Token = "0x4009AAF")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x4009AB0")]
	[FieldOffset(Offset = "0x10")]
	public string contact_info;

	[Token(Token = "0x6007DF2")]
	[Address(RVA = "0x317DAA8", Offset = "0x317DAA8", VA = "0x317DAA8")]
	public CSAddTeamContactInfoReq()
	{
	}
}
