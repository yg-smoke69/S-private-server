using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002F3A")]
public class FastClanInvite : FastMessage
{
	[Token(Token = "0x4012089")]
	[FieldOffset(Offset = "0x10")]
	public ulong id;

	[Token(Token = "0x401208A")]
	[FieldOffset(Offset = "0x18")]
	public string Name;

	[Token(Token = "0x401208B")]
	[FieldOffset(Offset = "0x1C")]
	public uint Level;

	[Token(Token = "0x401208C")]
	[FieldOffset(Offset = "0x20")]
	public string MemberNum;

	[Token(Token = "0x401208D")]
	[FieldOffset(Offset = "0x24")]
	public uint Apply;

	[Token(Token = "0x401208E")]
	[FieldOffset(Offset = "0x28")]
	public string Declaration;

	[Token(Token = "0x401208F")]
	[FieldOffset(Offset = "0x2C")]
	public uint m_LimitLevel;

	[Token(Token = "0x4012090")]
	[FieldOffset(Offset = "0x30")]
	public uint m_LimitRank;

	[Token(Token = "0x4012091")]
	[FieldOffset(Offset = "0x34")]
	public uint m_LimitCSRank;

	[Token(Token = "0x4012092")]
	[FieldOffset(Offset = "0x38")]
	public uint m_ClanBadgeID;

	[Token(Token = "0x6013C2C")]
	[Address(RVA = "0xDE4B18", Offset = "0xDE4B18", VA = "0xDE4B18")]
	public FastClanInvite()
	{
	}
}
