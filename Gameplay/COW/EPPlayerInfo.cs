using COW.GamePlay;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2003161")]
internal class EPPlayerInfo
{
	[Token(Token = "0x4012C03")]
	[FieldOffset(Offset = "0x8")]
	public ulong userID;

	[Token(Token = "0x4012C04")]
	[FieldOffset(Offset = "0x10")]
	public IHAAMHPPLMG playerID;

	[Token(Token = "0x4012C05")]
	[FieldOffset(Offset = "0x28")]
	public string playerName;

	[Token(Token = "0x4012C06")]
	[FieldOffset(Offset = "0x2C")]
	public uint badgeCount;

	[Token(Token = "0x4012C07")]
	[FieldOffset(Offset = "0x30")]
	public uint badgeId;

	[Token(Token = "0x4012C08")]
	[FieldOffset(Offset = "0x34")]
	public bool isAI;

	[Token(Token = "0x4012C09")]
	[FieldOffset(Offset = "0x38")]
	public uint pinId;

	[Token(Token = "0x4012C0A")]
	[FieldOffset(Offset = "0x3C")]
	public AvatarManager.FJIGOOPIJJD avatarData;

	[Token(Token = "0x4012C0B")]
	[FieldOffset(Offset = "0x40")]
	public uint role;

	[Token(Token = "0x6014B6B")]
	[Address(RVA = "0x2518608", Offset = "0x2518608", VA = "0x2518608")]
	public EPPlayerInfo(ulong uID, IHAAMHPPLMG pID, bool isBot, GKBDLJFGGMI info)
	{
	}

	[Token(Token = "0x6014B6C")]
	[Address(RVA = "0x25189A8", Offset = "0x25189A8", VA = "0x25189A8")]
	public bool IsLocalPlayer()
	{
		return default(bool);
	}

	[Token(Token = "0x6014B6D")]
	[Address(RVA = "0x2518AB8", Offset = "0x2518AB8", VA = "0x2518AB8")]
	public bool IsCelebrity()
	{
		return default(bool);
	}

	[Token(Token = "0x6014B6E")]
	[Address(RVA = "0x2518BE0", Offset = "0x2518BE0", VA = "0x2518BE0")]
	public bool IsFemale()
	{
		return default(bool);
	}

	[Token(Token = "0x6014B6F")]
	[Address(RVA = "0x2518D64", Offset = "0x2518D64", VA = "0x2518D64", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B70")]
	[Address(RVA = "0x2518EC8", Offset = "0x2518EC8", VA = "0x2518EC8", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6014B71")]
	[Address(RVA = "0x2518F2C", Offset = "0x2518F2C", VA = "0x2518F2C")]
	public bool _003C_003EiFixBaseProxy_Equals(object P0)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B72")]
	[Address(RVA = "0x2518F34", Offset = "0x2518F34", VA = "0x2518F34")]
	public int _003C_003EiFixBaseProxy_GetHashCode()
	{
		return default(int);
	}
}
