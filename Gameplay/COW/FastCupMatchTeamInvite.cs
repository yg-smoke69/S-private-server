using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002F3E")]
public class FastCupMatchTeamInvite : FastMessage
{
	[Token(Token = "0x40120A8")]
	[FieldOffset(Offset = "0x10")]
	public ulong TeamID;

	[Token(Token = "0x40120A9")]
	[FieldOffset(Offset = "0x18")]
	public uint CupMatchType;

	[Token(Token = "0x40120AA")]
	[FieldOffset(Offset = "0x1C")]
	public uint CupMatchID;

	[Token(Token = "0x40120AB")]
	[FieldOffset(Offset = "0x20")]
	public uint MemberNum;

	[Token(Token = "0x40120AC")]
	[FieldOffset(Offset = "0x24")]
	public uint TeamTier;

	[Token(Token = "0x6013C30")]
	[Address(RVA = "0xDE4B88", Offset = "0xDE4B88", VA = "0xDE4B88")]
	public FastCupMatchTeamInvite()
	{
	}
}
