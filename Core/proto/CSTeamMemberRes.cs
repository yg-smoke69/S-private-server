using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001797")]
public class CSTeamMemberRes
{
	[Token(Token = "0x4009AAA")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x4009AAB")]
	[FieldOffset(Offset = "0x10")]
	public ulong member_id;

	[Token(Token = "0x4009AAC")]
	[FieldOffset(Offset = "0x18")]
	public uint member_type;

	[Token(Token = "0x4009AAD")]
	[FieldOffset(Offset = "0x20")]
	public ulong join_at;

	[Token(Token = "0x4009AAE")]
	[FieldOffset(Offset = "0x28")]
	public bool is_not_in_team;

	[Token(Token = "0x6007DF1")]
	[Address(RVA = "0x309A3BC", Offset = "0x309A3BC", VA = "0x309A3BC")]
	public CSTeamMemberRes()
	{
	}
}
