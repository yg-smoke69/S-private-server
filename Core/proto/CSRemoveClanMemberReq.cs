using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001631")]
public class CSRemoveClanMemberReq
{
	[Token(Token = "0x400955B")]
	[FieldOffset(Offset = "0x8")]
	public ulong clan_id;

	[Token(Token = "0x400955C")]
	[FieldOffset(Offset = "0x10")]
	public ulong removee_id;

	[Token(Token = "0x6007C7B")]
	[Address(RVA = "0x30990F0", Offset = "0x30990F0", VA = "0x30990F0")]
	public CSRemoveClanMemberReq()
	{
	}
}
