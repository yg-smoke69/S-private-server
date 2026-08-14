using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F81")]
public class FastGoliathMsg : FastBigEventMsg
{
	[Token(Token = "0x400C5BF")]
	[FieldOffset(Offset = "0x10")]
	public ulong GroupID;

	[Token(Token = "0x400C5C0")]
	[FieldOffset(Offset = "0x18")]
	public string SelfNickname;

	[Token(Token = "0x400C5C1")]
	[FieldOffset(Offset = "0x1C")]
	public string CaptainNickname;

	[Token(Token = "0x400C5C2")]
	[FieldOffset(Offset = "0x20")]
	public uint MemberCnt;

	[Token(Token = "0x6009C83")]
	[Address(RVA = "0xDE4BF4", Offset = "0xDE4BF4", VA = "0xDE4BF4")]
	public FastGoliathMsg()
	{
	}

	[Token(Token = "0x6009C84")]
	[Address(RVA = "0xDE4BF8", Offset = "0xDE4BF8", VA = "0xDE4BF8")]
	public FastGoliathMsg(FastGoliathMsg template)
	{
	}
}
