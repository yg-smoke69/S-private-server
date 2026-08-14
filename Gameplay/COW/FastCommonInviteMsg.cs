using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F82")]
public class FastCommonInviteMsg : FastBigEventMsg
{
	[Token(Token = "0x400C5C3")]
	[FieldOffset(Offset = "0x10")]
	public string CaptainNickname;

	[Token(Token = "0x400C5C4")]
	[FieldOffset(Offset = "0x14")]
	public int GroupMemberCount;

	[Token(Token = "0x400C5C5")]
	[FieldOffset(Offset = "0x18")]
	public int GroupMemberLimit;

	[Token(Token = "0x6009C85")]
	[Address(RVA = "0xDE4B84", Offset = "0xDE4B84", VA = "0xDE4B84")]
	public FastCommonInviteMsg()
	{
	}
}
