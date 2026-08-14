using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200162B")]
public class CSProcessJoinClanReq
{
	[Token(Token = "0x4009551")]
	[FieldOffset(Offset = "0x8")]
	public ulong applicant_id;

	[Token(Token = "0x4009552")]
	[FieldOffset(Offset = "0x10")]
	public ulong clan_id;

	[Token(Token = "0x6007C75")]
	[Address(RVA = "0x3098924", Offset = "0x3098924", VA = "0x3098924")]
	public CSProcessJoinClanReq()
	{
	}
}
