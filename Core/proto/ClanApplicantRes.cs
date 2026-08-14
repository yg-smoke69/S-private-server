using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200163C")]
public class ClanApplicantRes
{
	[Token(Token = "0x4009584")]
	[FieldOffset(Offset = "0x8")]
	public ulong applicant_id;

	[Token(Token = "0x4009585")]
	[FieldOffset(Offset = "0x10")]
	public ulong clan_id;

	[Token(Token = "0x4009586")]
	[FieldOffset(Offset = "0x18")]
	public ulong create_at;

	[Token(Token = "0x6007C86")]
	[Address(RVA = "0x309B828", Offset = "0x309B828", VA = "0x309B828")]
	public ClanApplicantRes()
	{
	}
}
