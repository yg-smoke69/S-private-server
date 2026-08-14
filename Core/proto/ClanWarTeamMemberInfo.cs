using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013BF")]
public class ClanWarTeamMemberInfo
{
	[Token(Token = "0x4008AEF")]
	[FieldOffset(Offset = "0x8")]
	public ulong member_id;

	[Token(Token = "0x4008AF0")]
	[FieldOffset(Offset = "0x10")]
	public EClan.ClanWarMemberType member_type;

	[Token(Token = "0x4008AF1")]
	[FieldOffset(Offset = "0x14")]
	public bool has_prepared;

	[Token(Token = "0x6007AAA")]
	[Address(RVA = "0x309C464", Offset = "0x309C464", VA = "0x309C464")]
	public ClanWarTeamMemberInfo()
	{
	}
}
