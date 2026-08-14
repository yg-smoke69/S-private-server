using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002F3C")]
public class FastGroupInvite : FastMessage
{
	[Token(Token = "0x401209B")]
	[FieldOffset(Offset = "0x10")]
	public ulong GroupID;

	[Token(Token = "0x401209C")]
	[FieldOffset(Offset = "0x18")]
	public uint Group;

	[Token(Token = "0x401209D")]
	[FieldOffset(Offset = "0x1C")]
	public uint Map;

	[Token(Token = "0x401209E")]
	[FieldOffset(Offset = "0x20")]
	public uint Game;

	[Token(Token = "0x401209F")]
	[FieldOffset(Offset = "0x24")]
	public uint Match;

	[Token(Token = "0x40120A0")]
	[FieldOffset(Offset = "0x28")]
	public uint MemberNum;

	[Token(Token = "0x40120A1")]
	[FieldOffset(Offset = "0x2C")]
	public uint RequireRank;

	[Token(Token = "0x40120A2")]
	[FieldOffset(Offset = "0x30")]
	public string GroupTag;

	[Token(Token = "0x40120A3")]
	[FieldOffset(Offset = "0x34")]
	public string SecretCode;

	[Token(Token = "0x6013C2E")]
	[Address(RVA = "0xDE4CEC", Offset = "0xDE4CEC", VA = "0xDE4CEC")]
	public FastGroupInvite()
	{
	}
}
