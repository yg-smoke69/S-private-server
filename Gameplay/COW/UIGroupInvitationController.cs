using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026B3")]
internal class UIGroupInvitationController : UIBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x20026B4")]
	private sealed class _003COnSearchBtnClick_003Ec__AnonStorey0
	{
		[Token(Token = "0x400EECC")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x600E966")]
		[Address(RVA = "0x1CF9968", Offset = "0x1CF9968", VA = "0x1CF9968")]
		public _003COnSearchBtnClick_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600E967")]
		[Address(RVA = "0x1CFA500", Offset = "0x1CFA500", VA = "0x1CFA500")]
		internal bool _003C_003Em__0(FriendAccountInfo a)
		{
			return default(bool);
		}

		[Token(Token = "0x600E968")]
		[Address(RVA = "0x1CFA54C", Offset = "0x1CFA54C", VA = "0x1CFA54C")]
		internal bool _003C_003Em__1(ClanMember a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400EEC8")]
	[FieldOffset(Offset = "0x28")]
	private UIGroupInvitationView m_View;

	[Token(Token = "0x400EEC9")]
	[FieldOffset(Offset = "0x2C")]
	private List<FriendAccountInfo> m_CachedFriends;

	[Token(Token = "0x400EECA")]
	[FieldOffset(Offset = "0x30")]
	private List<ClanMember> m_CachedOnlineClanMembers;

	[Token(Token = "0x400EECB")]
	[FieldOffset(Offset = "0x34")]
	private GroupInviteMemberType m_InviteType;

	[Token(Token = "0x600E951")]
	[Address(RVA = "0x1CF76A8", Offset = "0x1CF76A8", VA = "0x1CF76A8")]
	public UIGroupInvitationController()
	{
	}

	[Token(Token = "0x600E952")]
	[Address(RVA = "0x1CF7794", Offset = "0x1CF7794", VA = "0x1CF7794")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E953")]
	[Address(RVA = "0x1CF7838", Offset = "0x1CF7838", VA = "0x1CF7838", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E954")]
	[Address(RVA = "0x1CF7DCC", Offset = "0x1CF7DCC", VA = "0x1CF7DCC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E955")]
	[Address(RVA = "0x1CF7F60", Offset = "0x1CF7F60", VA = "0x1CF7F60", Slot = "21")]
	public override void Show()
	{
	}

	[Token(Token = "0x600E956")]
	[Address(RVA = "0x1CF8154", Offset = "0x1CF8154", VA = "0x1CF8154")]
	private void OnFriendToggleBtnClick()
	{
	}

	[Token(Token = "0x600E957")]
	[Address(RVA = "0x1CF85D0", Offset = "0x1CF85D0", VA = "0x1CF85D0")]
	private void OnClanToggleBtnClick()
	{
	}

	[Token(Token = "0x600E958")]
	[Address(RVA = "0x1CF8A58", Offset = "0x1CF8A58", VA = "0x1CF8A58")]
	private void SetClanUIData()
	{
	}

	[Token(Token = "0x600E959")]
	[Address(RVA = "0x1CF8D90", Offset = "0x1CF8D90", VA = "0x1CF8D90")]
	private void PartialUpdateCachedFriendsInfo()
	{
	}

	[Token(Token = "0x600E95A")]
	[Address(RVA = "0x1CF92B0", Offset = "0x1CF92B0", VA = "0x1CF92B0")]
	private void SetFriendUIData()
	{
	}

	[Token(Token = "0x600E95B")]
	[Address(RVA = "0x1CF95D8", Offset = "0x1CF95D8", VA = "0x1CF95D8")]
	private void OnSearchBtnClick()
	{
	}

	[Token(Token = "0x600E95C")]
	[Address(RVA = "0x1CF9970", Offset = "0x1CF9970", VA = "0x1CF9970")]
	private void PartialUpdateCachedClanMembersInfo()
	{
	}

	[Token(Token = "0x600E95D")]
	[Address(RVA = "0x1CF9ECC", Offset = "0x1CF9ECC", VA = "0x1CF9ECC")]
	private void OnRefreshBtnClick()
	{
	}

	[Token(Token = "0x600E95E")]
	[Address(RVA = "0x1CFA0BC", Offset = "0x1CFA0BC", VA = "0x1CFA0BC")]
	private void OnMaskClick()
	{
	}

	[Token(Token = "0x600E95F")]
	[Address(RVA = "0x1CFA128", Offset = "0x1CFA128", VA = "0x1CFA128", Slot = "33")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E960")]
	[Address(RVA = "0x1CFA238", Offset = "0x1CFA238", VA = "0x1CFA238", Slot = "34")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E961")]
	[Address(RVA = "0x1CFA2F0", Offset = "0x1CFA2F0", VA = "0x1CFA2F0", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600E962")]
	[Address(RVA = "0x1CFA46C", Offset = "0x1CFA46C", VA = "0x1CFA46C", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600E963")]
	[Address(RVA = "0x1CFA4E8", Offset = "0x1CFA4E8", VA = "0x1CFA4E8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E964")]
	[Address(RVA = "0x1CFA4F0", Offset = "0x1CFA4F0", VA = "0x1CFA4F0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600E965")]
	[Address(RVA = "0x1CFA4F8", Offset = "0x1CFA4F8", VA = "0x1CFA4F8")]
	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
