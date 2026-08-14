using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200303C")]
public class RecentPlayerInfo : _Attribute
{
	[Token(Token = "0x4012646")]
	[FieldOffset(Offset = "0x8")]
	public ulong m_Time;

	[Token(Token = "0x4012647")]
	[FieldOffset(Offset = "0x10")]
	public ERecentPlayerType m_Type;

	[Token(Token = "0x4012648")]
	[FieldOffset(Offset = "0x14")]
	public FriendAccountInfo m_Info;

	[Token(Token = "0x601431B")]
	[Address(RVA = "0x1970A74", Offset = "0x1970A74", VA = "0x1970A74")]
	public RecentPlayerInfo()
	{
	}

	[Token(Token = "0x601431C")]
	[Address(RVA = "0x1970A7C", Offset = "0x1970A7C", VA = "0x1970A7C", Slot = "4")]
	public int CompareTo(RecentPlayerInfo other)
	{
		return default(int);
	}

	[Token(Token = "0x601431D")]
	[Address(RVA = "0x1970B48", Offset = "0x1970B48", VA = "0x1970B48")]
	public int ComparePresence(EPresence.AccountPresence presence)
	{
		return default(int);
	}
}
