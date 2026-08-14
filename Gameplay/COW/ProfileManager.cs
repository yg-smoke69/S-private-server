using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002D35")]
public class ProfileManager : SingletonModule<ProfileManager>, _Attribute
{
	[Token(Token = "0x401145A")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<ulong, BaseProfileInfo> m_ProfileInfoDic;

	[Token(Token = "0x401145B")]
	[FieldOffset(Offset = "0x10")]
	private UIModelFriends m_FriendModel;

	[Token(Token = "0x401145C")]
	[FieldOffset(Offset = "0x14")]
	private UIModelClan m_ClanModel;

	[Token(Token = "0x401145D")]
	[FieldOffset(Offset = "0x18")]
	private UIModelGroup m_GroupModel;

	[Token(Token = "0x401145E")]
	[FieldOffset(Offset = "0x1C")]
	private UIModelCustomRoom m_CustomRoomModel;

	[Token(Token = "0x6012E8E")]
	[Address(RVA = "0x1968674", Offset = "0x1968674", VA = "0x1968674")]
	public ProfileManager()
	{
	}

	[Token(Token = "0x6012E8F")]
	[Address(RVA = "0x1968738", Offset = "0x1968738", VA = "0x1968738", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6012E90")]
	[Address(RVA = "0x1968888", Offset = "0x1968888", VA = "0x1968888", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6012E91")]
	[Address(RVA = "0x1968AE8", Offset = "0x1968AE8", VA = "0x1968AE8")]
	public BaseProfileInfo GetUserProfileInfo(ulong id)
	{
		return null;
	}

	[Token(Token = "0x6012E92")]
	[Address(RVA = "0x1968C18", Offset = "0x1968C18", VA = "0x1968C18")]
	public void AddUserProfileInfo(List<ClanMember> m_ClanMembers)
	{
	}

	[Token(Token = "0x6012E93")]
	[Address(RVA = "0x1968DBC", Offset = "0x1968DBC", VA = "0x1968DBC")]
	public void AddUserProfileInfo(ulong id, BaseProfileInfo profileinfo)
	{
	}

	[Token(Token = "0x6012E94")]
	[Address(RVA = "0x1968EB0", Offset = "0x1968EB0", VA = "0x1968EB0", Slot = "10")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6012E95")]
	[Address(RVA = "0x1969B7C", Offset = "0x1969B7C", VA = "0x1969B7C", Slot = "11")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}
}
