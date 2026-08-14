using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002F63")]
public class ClanBadgeItemInfo
{
	[Token(Token = "0x4012127")]
	[FieldOffset(Offset = "0x8")]
	public uint IsDefault;

	[Token(Token = "0x4012128")]
	[FieldOffset(Offset = "0xC")]
	public uint UnLockCdt;

	[Token(Token = "0x4012129")]
	[FieldOffset(Offset = "0x10")]
	public uint BadgeID;

	[Token(Token = "0x401212A")]
	[FieldOffset(Offset = "0x14")]
	public uint UnlockCdtValue;

	[Token(Token = "0x401212B")]
	[FieldOffset(Offset = "0x18")]
	public ClanBadgeType BadgeType;

	[Token(Token = "0x401212C")]
	[FieldOffset(Offset = "0x1C")]
	public string BadgeName;

	[Token(Token = "0x401212D")]
	[FieldOffset(Offset = "0x20")]
	public string BadgeGetWay;

	[Token(Token = "0x401212E")]
	[FieldOffset(Offset = "0x24")]
	public string SpriteName;

	[Token(Token = "0x401212F")]
	[FieldOffset(Offset = "0x28")]
	public string IsShow;

	[Token(Token = "0x4012130")]
	[FieldOffset(Offset = "0x30")]
	public ulong expire_time;

	[Token(Token = "0x6013CD4")]
	[Address(RVA = "0x17271DC", Offset = "0x17271DC", VA = "0x17271DC")]
	public ClanBadgeItemInfo()
	{
	}

	[Token(Token = "0x6013CD5")]
	[Address(RVA = "0x17271E4", Offset = "0x17271E4", VA = "0x17271E4")]
	public static implicit operator ClanBadgeItemInfo(ClanBadgeInfoData data)
	{
		return null;
	}
}
