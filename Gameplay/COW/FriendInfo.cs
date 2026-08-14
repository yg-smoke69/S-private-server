using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x20021E6")]
public class FriendInfo : _Attribute, IConvertible
{
	[Token(Token = "0x400D415")]
	[FieldOffset(Offset = "0x8")]
	public ulong m_AccountId;

	[Token(Token = "0x400D416")]
	[FieldOffset(Offset = "0x10")]
	public uint m_Level;

	[Token(Token = "0x400D417")]
	[FieldOffset(Offset = "0x14")]
	public string m_Name;

	[Token(Token = "0x400D418")]
	[FieldOffset(Offset = "0x18")]
	public string m_PortraitUrl;

	[Token(Token = "0x400D419")]
	[FieldOffset(Offset = "0x1C")]
	public uint m_Banner;

	[Token(Token = "0x400D41A")]
	[FieldOffset(Offset = "0x20")]
	public uint m_HeadPic;

	[Token(Token = "0x400D41B")]
	[FieldOffset(Offset = "0x24")]
	public proto.EPresence.AccountPresence m_OnlineStatus;

	[Token(Token = "0x400D41C")]
	[FieldOffset(Offset = "0x28")]
	public bool m_IsSelected;

	[Token(Token = "0x400D41D")]
	[FieldOffset(Offset = "0x29")]
	public bool m_IsMeetCondition;

	[Token(Token = "0x400D41E")]
	[FieldOffset(Offset = "0x2A")]
	public bool m_IsFavor;

	[Token(Token = "0x400D41F")]
	[FieldOffset(Offset = "0x2B")]
	public bool m_IsConfidant;

	[Token(Token = "0x400D420")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggleButton m_UIToggleBtn;

	[Token(Token = "0x400D421")]
	[FieldOffset(Offset = "0x30")]
	public string m_Reason;

	[Token(Token = "0x400D422")]
	[FieldOffset(Offset = "0x34")]
	public EGiftStore_BuddyType m_BuddyType;

	[Token(Token = "0x400D423")]
	[FieldOffset(Offset = "0x38")]
	public string m_Region;

	[Token(Token = "0x600B631")]
	[Address(RVA = "0xDF1568", Offset = "0xDF1568", VA = "0xDF1568")]
	public FriendInfo()
	{
	}

	[Token(Token = "0x600B632")]
	[Address(RVA = "0xDF1570", Offset = "0xDF1570", VA = "0xDF1570")]
	public static implicit operator FriendInfo(FriendAccountInfo accountInfo)
	{
		return null;
	}

	[Token(Token = "0x600B633")]
	[Address(RVA = "0xDF179C", Offset = "0xDF179C", VA = "0xDF179C")]
	public static implicit operator FriendInfo(ClanMember memberInfo)
	{
		return null;
	}

	[Token(Token = "0x600B634")]
	[Address(RVA = "0xDF19B0", Offset = "0xDF19B0", VA = "0xDF19B0")]
	public static implicit operator FriendInfo(GroupMemberInfo memberInfo)
	{
		return null;
	}

	[Token(Token = "0x600B635")]
	[Address(RVA = "0xDF1BC4", Offset = "0xDF1BC4", VA = "0xDF1BC4")]
	public static implicit operator FriendInfo(TeammateStats memberInfo)
	{
		return null;
	}

	[Token(Token = "0x600B636")]
	[Address(RVA = "0xDF1DF4", Offset = "0xDF1DF4", VA = "0xDF1DF4", Slot = "4")]
	public int CompareTo(FriendInfo other)
	{
		return default(int);
	}

	[Token(Token = "0x600B637")]
	[Address(RVA = "0xDF1F94", Offset = "0xDF1F94", VA = "0xDF1F94", Slot = "5")]
	public bool Equals(FriendInfo x, FriendInfo y)
	{
		return default(bool);
	}

	[Token(Token = "0x600B638")]
	[Address(RVA = "0xDF2048", Offset = "0xDF2048", VA = "0xDF2048", Slot = "6")]
	public int GetHashCode(FriendInfo obj)
	{
		return default(int);
	}
}
