using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002F97")]
public class ClanInfo
{
	[Token(Token = "0x4012243")]
	[FieldOffset(Offset = "0x8")]
	public ulong m_ClanID;

	[Token(Token = "0x4012244")]
	[FieldOffset(Offset = "0x10")]
	public string m_ClanName;

	[Token(Token = "0x4012245")]
	[FieldOffset(Offset = "0x14")]
	public uint m_ClanLevel;

	[Token(Token = "0x4012246")]
	[FieldOffset(Offset = "0x18")]
	public uint m_ClanMemberNum;

	[Token(Token = "0x4012247")]
	[FieldOffset(Offset = "0x1C")]
	public uint m_ClanScale;

	[Token(Token = "0x4012248")]
	[FieldOffset(Offset = "0x20")]
	public uint m_ExtendTimes;

	[Token(Token = "0x4012249")]
	[FieldOffset(Offset = "0x24")]
	public string m_ClanSlogan;

	[Token(Token = "0x401224A")]
	[FieldOffset(Offset = "0x28")]
	public string m_ClanRegion;

	[Token(Token = "0x401224B")]
	[FieldOffset(Offset = "0x2C")]
	public uint m_LimitLevel;

	[Token(Token = "0x401224C")]
	[FieldOffset(Offset = "0x30")]
	public uint m_LimitRank;

	[Token(Token = "0x401224D")]
	[FieldOffset(Offset = "0x34")]
	public uint m_LimitCSRank;

	[Token(Token = "0x401224E")]
	[FieldOffset(Offset = "0x38")]
	public string m_CaptainName;

	[Token(Token = "0x401224F")]
	[FieldOffset(Offset = "0x3C")]
	public string m_ClanAnnouncement;

	[Token(Token = "0x4012250")]
	[FieldOffset(Offset = "0x40")]
	public ulong m_CreateDate;

	[Token(Token = "0x4012251")]
	[FieldOffset(Offset = "0x48")]
	public ulong CaptainID;

	[Token(Token = "0x4012252")]
	[FieldOffset(Offset = "0x50")]
	public ulong[] ViceCaptainID;

	[Token(Token = "0x4012253")]
	[FieldOffset(Offset = "0x54")]
	public uint m_HonorPoint;

	[Token(Token = "0x4012254")]
	[FieldOffset(Offset = "0x58")]
	public uint m_EntryType;

	[Token(Token = "0x4012255")]
	[FieldOffset(Offset = "0x5C")]
	public uint m_RacePoint;

	[Token(Token = "0x4012256")]
	[FieldOffset(Offset = "0x60")]
	public ulong m_ClaimRPAwardAt;

	[Token(Token = "0x4012257")]
	[FieldOffset(Offset = "0x68")]
	public uint m_AreaID;

	[Token(Token = "0x4012258")]
	[FieldOffset(Offset = "0x6C")]
	public uint m_PlayStyle;

	[Token(Token = "0x4012259")]
	[FieldOffset(Offset = "0x70")]
	public ulong m_DeputyCaptainID;

	[Token(Token = "0x401225A")]
	[FieldOffset(Offset = "0x78")]
	public uint m_ClanBadgeID;

	[Token(Token = "0x401225B")]
	[FieldOffset(Offset = "0x7C")]
	public List<UnlockedClanBadgeInfo> m_UnlockClanBadgeInfo;

	[Token(Token = "0x6013E52")]
	[Address(RVA = "0x172AA18", Offset = "0x172AA18", VA = "0x172AA18")]
	public ClanInfo()
	{
	}

	[Token(Token = "0x6013E53")]
	[Address(RVA = "0x172AA20", Offset = "0x172AA20", VA = "0x172AA20")]
	public static implicit operator ClanInfo(proto.ClanInfo data)
	{
		return null;
	}

	[Token(Token = "0x6013E54")]
	[Address(RVA = "0x172ADE4", Offset = "0x172ADE4", VA = "0x172ADE4")]
	private static uint GetExtendTimeFromMiscellaneous(string misc)
	{
		return default(uint);
	}
}
