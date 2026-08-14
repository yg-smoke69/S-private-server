using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001576")]
public class CSGetCupTeamMemberByMemberIDReq
{
	[Token(Token = "0x4009345")]
	[FieldOffset(Offset = "0x8")]
	public uint cup_type;

	[Token(Token = "0x4009346")]
	[FieldOffset(Offset = "0xC")]
	public uint cup_id;

	[Token(Token = "0x6007BBE")]
	[Address(RVA = "0x3183748", Offset = "0x3183748", VA = "0x3183748")]
	public CSGetCupTeamMemberByMemberIDReq()
	{
	}
}
