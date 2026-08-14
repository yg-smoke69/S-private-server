using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20028E3")]
public class UIInviteGroupBoxController : UIBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x20028E4")]
	private sealed class _003ConSearchBtnClick_003Ec__AnonStorey0
	{
		[Token(Token = "0x400FB7F")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x400FB80")]
		[FieldOffset(Offset = "0xC")]
		internal UIInviteGroupBoxController _0024this;

		[Token(Token = "0x6010257")]
		[Address(RVA = "0x1AD88FC", Offset = "0x1AD88FC", VA = "0x1AD88FC")]
		public _003ConSearchBtnClick_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6010258")]
		[Address(RVA = "0x1AD8904", Offset = "0x1AD8904", VA = "0x1AD8904")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6010259")]
		[Address(RVA = "0x1AD8978", Offset = "0x1AD8978", VA = "0x1AD8978")]
		internal bool _003C_003Em__1(FriendAccountInfo a)
		{
			return default(bool);
		}

		[Token(Token = "0x601025A")]
		[Address(RVA = "0x1AD89C4", Offset = "0x1AD89C4", VA = "0x1AD89C4")]
		internal bool _003C_003Em__2(ClanMember a)
		{
			return default(bool);
		}

		[Token(Token = "0x601025B")]
		[Address(RVA = "0x1AD8A24", Offset = "0x1AD8A24", VA = "0x1AD8A24")]
		internal bool _003C_003Em__3(TeamMemberWithAccountInfo a)
		{
			return default(bool);
		}

		[Token(Token = "0x601025C")]
		[Address(RVA = "0x1AD8A84", Offset = "0x1AD8A84", VA = "0x1AD8A84")]
		internal bool _003C_003Em__4(UIModelCupMatch.AccountInfoBasicWithCupInfo a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400FB6D")]
	[FieldOffset(Offset = "0x28")]
	protected UIInviteGroupBoxView m_View;

	[Token(Token = "0x400FB6E")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCall;

	[Token(Token = "0x400FB6F")]
	[FieldOffset(Offset = "0x30")]
	private string INVITE_FILTER;

	[Token(Token = "0x400FB70")]
	[FieldOffset(Offset = "0x34")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400FB71")]
	[FieldOffset(Offset = "0x38")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400FB72")]
	[FieldOffset(Offset = "0x3C")]
	private GroupInviteMemberType m_InviteType;

	[Token(Token = "0x400FB73")]
	[FieldOffset(Offset = "0x40")]
	private List<FriendAccountInfo> m_CachedFriends;

	[Token(Token = "0x400FB74")]
	[FieldOffset(Offset = "0x44")]
	private List<ClanMember> m_CachedOnlineClanMembers;

	[Token(Token = "0x400FB75")]
	[FieldOffset(Offset = "0x48")]
	private bool m_HastUpdateRecent;

	[Token(Token = "0x400FB76")]
	[FieldOffset(Offset = "0x50")]
	private ulong m_LastRefreshTime;

	[Token(Token = "0x400FB77")]
	[FieldOffset(Offset = "0x58")]
	private bool m_HasSearch;

	[Token(Token = "0x400FB78")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_WinkCall;

	[Token(Token = "0x400FB79")]
	[FieldOffset(Offset = "0x60")]
	private UICommonCodeInputWindowController m_CodeInputWindow;

	[Token(Token = "0x400FB7A")]
	[FieldOffset(Offset = "0x64")]
	private UIGroupInviteItemController.GroupInviteUI m_InviteUI;

	[Token(Token = "0x400FB7B")]
	[FieldOffset(Offset = "0x68")]
	private Action m_OnClose;

	[Token(Token = "0x400FB7C")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_ReuqestedChampionshipTeamMembersPresence;

	[Token(Token = "0x400FB7D")]
	[FieldOffset(Offset = "0x6D")]
	private bool m_RequestedCupTeamMembersPresence;

	[Token(Token = "0x400FB7E")]
	[FieldOffset(Offset = "0x70")]
	private UIModelGroup __ModelGroup;

	[Token(Token = "0x1700120C")]
	private UIModelGroup m_ModelGroup
	{
		[Token(Token = "0x6010225")]
		[Address(RVA = "0x129A518", Offset = "0x129A518", VA = "0x129A518")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6010224")]
	[Address(RVA = "0x129A418", Offset = "0x129A418", VA = "0x129A418")]
	public UIInviteGroupBoxController()
	{
	}

	[Token(Token = "0x6010226")]
	[Address(RVA = "0x129A628", Offset = "0x129A628", VA = "0x129A628")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010227")]
	[Address(RVA = "0x129A888", Offset = "0x129A888", VA = "0x129A888", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010228")]
	[Address(RVA = "0x129B530", Offset = "0x129B530", VA = "0x129B530")]
	private bool ShowInLeft()
	{
		return default(bool);
	}

	[Token(Token = "0x6010229")]
	[Address(RVA = "0x129B680", Offset = "0x129B680", VA = "0x129B680")]
	public void SetData([Optional] Action onOpen, [Optional] Action onClose)
	{
	}

	[Token(Token = "0x601022A")]
	[Address(RVA = "0x129B7EC", Offset = "0x129B7EC", VA = "0x129B7EC")]
	public void SetData(Vector3 worldPos, Vector3 scale, [Optional] Action onOpen, [Optional] Action onClose)
	{
	}

	[Token(Token = "0x601022B")]
	[Address(RVA = "0x129C98C", Offset = "0x129C98C", VA = "0x129C98C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601022C")]
	[Address(RVA = "0x129D084", Offset = "0x129D084", VA = "0x129D084")]
	public void OnClickAddFriend()
	{
	}

	[Token(Token = "0x601022D")]
	[Address(RVA = "0x129D16C", Offset = "0x129D16C", VA = "0x129D16C")]
	public void OnClickAddClan()
	{
	}

	[Token(Token = "0x601022E")]
	[Address(RVA = "0x129D278", Offset = "0x129D278", VA = "0x129D278")]
	private void OnGroupChangeNtf(object[] data)
	{
	}

	[Token(Token = "0x601022F")]
	[Address(RVA = "0x129D300", Offset = "0x129D300", VA = "0x129D300")]
	private void OnGroupUIEnter(object[] data)
	{
	}

	[Token(Token = "0x6010230")]
	[Address(RVA = "0x129BAC8", Offset = "0x129BAC8", VA = "0x129BAC8")]
	private void SetInviteType()
	{
	}

	[Token(Token = "0x6010231")]
	[Address(RVA = "0x129C8BC", Offset = "0x129C8BC", VA = "0x129C8BC")]
	private void UpdateRefreshState(bool inCD = false)
	{
	}

	[Token(Token = "0x6010232")]
	[Address(RVA = "0x129D404", Offset = "0x129D404", VA = "0x129D404")]
	private void OnRefreshBtnClick()
	{
	}

	[Token(Token = "0x6010233")]
	[Address(RVA = "0x129C1C8", Offset = "0x129C1C8", VA = "0x129C1C8")]
	private void RefreshFriendsList()
	{
	}

	[Token(Token = "0x6010234")]
	[Address(RVA = "0x129E7BC", Offset = "0x129E7BC", VA = "0x129E7BC")]
	private void PartialUpdateCachedClanMembersInfo()
	{
	}

	[Token(Token = "0x6010235")]
	[Address(RVA = "0x129ECEC", Offset = "0x129ECEC", VA = "0x129ECEC")]
	private void PartialUpdateCachedFriendsInfo()
	{
	}

	[Token(Token = "0x6010236")]
	[Address(RVA = "0x129F230", Offset = "0x129F230", VA = "0x129F230")]
	private void OnFriendToggleBtnClick()
	{
	}

	[Token(Token = "0x6010237")]
	[Address(RVA = "0x129F5A0", Offset = "0x129F5A0", VA = "0x129F5A0")]
	private void OnClanToggleBtnClick()
	{
	}

	[Token(Token = "0x6010238")]
	[Address(RVA = "0x129F5F4", Offset = "0x129F5F4", VA = "0x129F5F4")]
	private void OnRecentToggleClick()
	{
	}

	[Token(Token = "0x6010239")]
	[Address(RVA = "0x129F7C4", Offset = "0x129F7C4", VA = "0x129F7C4")]
	private void SetRecentUIData()
	{
	}

	[Token(Token = "0x601023A")]
	[Address(RVA = "0x129F970", Offset = "0x129F970", VA = "0x129F970")]
	private void SetClanUIData()
	{
	}

	[Token(Token = "0x601023B")]
	[Address(RVA = "0x129FB88", Offset = "0x129FB88", VA = "0x129FB88")]
	private void SetFriendUIData()
	{
	}

	[Token(Token = "0x601023C")]
	[Address(RVA = "0x129FDA0", Offset = "0x129FDA0", VA = "0x129FDA0")]
	private void SetTeamUIData()
	{
	}

	[Token(Token = "0x601023D")]
	[Address(RVA = "0x129FF40", Offset = "0x129FF40", VA = "0x129FF40")]
	private void SetCupUIData()
	{
	}

	[Token(Token = "0x601023E")]
	[Address(RVA = "0x129BD5C", Offset = "0x129BD5C", VA = "0x129BD5C")]
	private void RefreshInviteUI()
	{
	}

	[Token(Token = "0x601023F")]
	[Address(RVA = "0x12A0164", Offset = "0x12A0164", VA = "0x12A0164", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6010240")]
	[Address(RVA = "0x12A0260", Offset = "0x12A0260", VA = "0x12A0260")]
	private void onSearchBtnClick()
	{
	}

	[Token(Token = "0x6010241")]
	[Address(RVA = "0x12A0B14", Offset = "0x12A0B14", VA = "0x12A0B14")]
	private void RefreshScrollView()
	{
	}

	[Token(Token = "0x6010242")]
	[Address(RVA = "0x12A10B4", Offset = "0x12A10B4", VA = "0x12A10B4")]
	private void OnClickMask(object[] args)
	{
	}

	[Token(Token = "0x6010243")]
	[Address(RVA = "0x12A1468", Offset = "0x12A1468", VA = "0x12A1468")]
	private void OnTweenFinish()
	{
	}

	[Token(Token = "0x6010244")]
	[Address(RVA = "0x12A1588", Offset = "0x12A1588", VA = "0x12A1588")]
	private void OnMatchmakingShow(object[] args)
	{
	}

	[Token(Token = "0x6010245")]
	[Address(RVA = "0x12A15F0", Offset = "0x12A15F0", VA = "0x12A15F0")]
	private void OnSelectGameMode(object[] args)
	{
	}

	[Token(Token = "0x6010246")]
	[Address(RVA = "0x12A1330", Offset = "0x12A1330", VA = "0x12A1330")]
	public void OnClickClose()
	{
	}

	[Token(Token = "0x6010247")]
	[Address(RVA = "0x12A16E8", Offset = "0x12A16E8", VA = "0x12A16E8", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010248")]
	[Address(RVA = "0x12A17E8", Offset = "0x12A17E8", VA = "0x12A17E8", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010249")]
	[Address(RVA = "0x129DB34", Offset = "0x129DB34", VA = "0x129DB34")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x601024A")]
	[Address(RVA = "0x12A0E04", Offset = "0x12A0E04", VA = "0x12A0E04")]
	private void ResetClipPos()
	{
	}

	[Token(Token = "0x601024B")]
	[Address(RVA = "0x12A19AC", Offset = "0x12A19AC", VA = "0x12A19AC")]
	private void ResetSearchInput()
	{
	}

	[Token(Token = "0x601024C")]
	[Address(RVA = "0x12A1B5C", Offset = "0x12A1B5C", VA = "0x12A1B5C")]
	private void OnSearchInputGetFocus()
	{
	}

	[Token(Token = "0x601024D")]
	[Address(RVA = "0x12A1C58", Offset = "0x12A1C58", VA = "0x12A1C58")]
	private void OnSearchInputChange()
	{
	}

	[Token(Token = "0x601024E")]
	[Address(RVA = "0x12A1E18", Offset = "0x12A1E18", VA = "0x12A1E18")]
	private void OnClickCommunity()
	{
	}

	[Token(Token = "0x601024F")]
	[Address(RVA = "0x12A294C", Offset = "0x12A294C", VA = "0x12A294C")]
	private void OnQuickEnter()
	{
	}

	[Token(Token = "0x6010250")]
	[Address(RVA = "0x12A3148", Offset = "0x12A3148", VA = "0x12A3148")]
	private void OnGroupCodeEnter(object data)
	{
	}

	[Token(Token = "0x6010251")]
	[Address(RVA = "0x12A3368", Offset = "0x12A3368", VA = "0x12A3368", Slot = "33")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010252")]
	[Address(RVA = "0x12A34C0", Offset = "0x12A34C0", VA = "0x12A34C0", Slot = "34")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6010253")]
	[Address(RVA = "0x12A353C", Offset = "0x12A353C", VA = "0x12A353C")]
	private void _003COnRefreshBtnClick_003Em__0()
	{
	}

	[Token(Token = "0x6010254")]
	[Address(RVA = "0x12A3544", Offset = "0x12A3544", VA = "0x12A3544")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010255")]
	[Address(RVA = "0x12A354C", Offset = "0x12A354C", VA = "0x12A354C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6010256")]
	[Address(RVA = "0x12A3554", Offset = "0x12A3554", VA = "0x12A3554")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
