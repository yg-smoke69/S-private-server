using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x20031FF")]
public class RelationshipMessageInfo
{
	[Token(Token = "0x2003200")]
	private sealed class _003CSetMessageCountDown_003Ec__AnonStorey0
	{
		[Token(Token = "0x401308B")]
		[FieldOffset(Offset = "0x8")]
		internal UIRelationshipMsgType msgType;

		[Token(Token = "0x401308C")]
		[FieldOffset(Offset = "0xC")]
		internal RelationshipMessageInfo _0024this;

		[Token(Token = "0x6015194")]
		[Address(RVA = "0x1974368", Offset = "0x1974368", VA = "0x1974368")]
		public _003CSetMessageCountDown_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6015195")]
		[Address(RVA = "0x19749F0", Offset = "0x19749F0", VA = "0x19749F0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x4013085")]
	[FieldOffset(Offset = "0x8")]
	public ulong AccoutID;

	[Token(Token = "0x4013086")]
	[FieldOffset(Offset = "0x10")]
	public ulong SendTimeStamp;

	[Token(Token = "0x4013087")]
	[FieldOffset(Offset = "0x18")]
	public proto.EFriend.RelationType RelationType;

	[Token(Token = "0x4013088")]
	[FieldOffset(Offset = "0x1C")]
	public UIRelationshipMsgType MsgType;

	[Token(Token = "0x4013089")]
	[FieldOffset(Offset = "0x20")]
	public bool IsRead;

	[Token(Token = "0x401308A")]
	[FieldOffset(Offset = "0x24")]
	private uint m_DelayCall;

	[Token(Token = "0x1700163F")]
	public FriendAccountInfo SendMsgAccountInfo
	{
		[Token(Token = "0x601518C")]
		[Address(RVA = "0x1973F1C", Offset = "0x1973F1C", VA = "0x1973F1C")]
		get
		{
			return null;
		}
		[Token(Token = "0x601518D")]
		[Address(RVA = "0x1974058", Offset = "0x1974058", VA = "0x1974058")]
		private set
		{
		}
	}

	[Token(Token = "0x601518B")]
	[Address(RVA = "0x1973F14", Offset = "0x1973F14", VA = "0x1973F14")]
	public RelationshipMessageInfo()
	{
	}

	[Token(Token = "0x601518E")]
	[Address(RVA = "0x19740B4", Offset = "0x19740B4", VA = "0x19740B4", Slot = "1")]
	~RelationshipMessageInfo()
	{
	}

	[Token(Token = "0x601518F")]
	[Address(RVA = "0x19741BC", Offset = "0x19741BC", VA = "0x19741BC")]
	private void SetMessageCountDown(float validTime, UIRelationshipMsgType msgType)
	{
	}

	[Token(Token = "0x6015190")]
	[Address(RVA = "0x1974370", Offset = "0x1974370", VA = "0x1974370")]
	private void InitMessage()
	{
	}

	[Token(Token = "0x6015191")]
	[Address(RVA = "0x197455C", Offset = "0x197455C", VA = "0x197455C")]
	public void ChangeCurrentMsgType(UIRelationshipMsgType msgType)
	{
	}

	[Token(Token = "0x6015192")]
	[Address(RVA = "0x197471C", Offset = "0x197471C", VA = "0x197471C")]
	public static implicit operator RelationshipMessageInfo(SepcialFriendsAppsRes appsRes)
	{
		return null;
	}

	[Token(Token = "0x6015193")]
	[Address(RVA = "0x1974894", Offset = "0x1974894", VA = "0x1974894")]
	public static RelationshipMessageInfo CreateRelationshipMessageInfo(RelatedFriendRequestNtf appsRes, UIRelationshipMsgType msgType)
	{
		return null;
	}
}
