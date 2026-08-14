using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002F3B")]
public class FastClanGroupInvite : FastMessage
{
	[Token(Token = "0x4012093")]
	[FieldOffset(Offset = "0xC")]
	public uint RequireCSRank;

	[Token(Token = "0x4012094")]
	[FieldOffset(Offset = "0x10")]
	public uint RequireBRRank;

	[Token(Token = "0x4012095")]
	[FieldOffset(Offset = "0x14")]
	public uint ClanBadgeID;

	[Token(Token = "0x4012096")]
	[FieldOffset(Offset = "0x18")]
	public string Name;

	[Token(Token = "0x4012097")]
	[FieldOffset(Offset = "0x1C")]
	public string MemberNum;

	[Token(Token = "0x4012098")]
	[FieldOffset(Offset = "0x20")]
	public ulong id;

	[Token(Token = "0x4012099")]
	[FieldOffset(Offset = "0x28")]
	public uint Level;

	[Token(Token = "0x401209A")]
	[FieldOffset(Offset = "0x2C")]
	public string GroupTag;

	[Token(Token = "0x6013C2D")]
	[Address(RVA = "0xDE4AAC", Offset = "0xDE4AAC", VA = "0xDE4AAC")]
	public FastClanGroupInvite()
	{
	}
}
