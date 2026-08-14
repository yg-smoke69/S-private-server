using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002020")]
public class UIChampionshipTeamInviteController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x2002021")]
	public enum InviteState
	{
		[Token(Token = "0x400C9C6")]
		Normal,
		[Token(Token = "0x400C9C7")]
		Inviting,
		[Token(Token = "0x400C9C8")]
		Invited
	}

	[Token(Token = "0x400C9BE")]
	[FieldOffset(Offset = "0x48")]
	private UIChampionshipTeamInviteView m_View;

	[Token(Token = "0x400C9BF")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelFriends m_ModelFriends;

	[Token(Token = "0x400C9C0")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<ulong, InviteState> m_InviteStates;

	[Token(Token = "0x400C9C1")]
	[FieldOffset(Offset = "0x54")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400C9C2")]
	[FieldOffset(Offset = "0x58")]
	private bool m_GettedFriendsData;

	[Token(Token = "0x400C9C3")]
	[FieldOffset(Offset = "0x59")]
	private bool m_GettedInvitedListData;

	[Token(Token = "0x400C9C4")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<FriendAccountInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600A2C1")]
	[Address(RVA = "0x2841D0C", Offset = "0x2841D0C", VA = "0x2841D0C")]
	public UIChampionshipTeamInviteController()
	{
	}

	[Token(Token = "0x600A2C2")]
	[Address(RVA = "0x2841D98", Offset = "0x2841D98", VA = "0x2841D98")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A2C3")]
	[Address(RVA = "0x2841E3C", Offset = "0x2841E3C", VA = "0x2841E3C", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600A2C4")]
	[Address(RVA = "0x2841EB8", Offset = "0x2841EB8", VA = "0x2841EB8", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600A2C5")]
	[Address(RVA = "0x2841FB0", Offset = "0x2841FB0", VA = "0x2841FB0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A2C6")]
	[Address(RVA = "0x28422E0", Offset = "0x28422E0", VA = "0x28422E0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A2C7")]
	[Address(RVA = "0x284238C", Offset = "0x284238C", VA = "0x284238C")]
	public InviteState GetInviteState(ulong id)
	{
		return default(InviteState);
	}

	[Token(Token = "0x600A2C8")]
	[Address(RVA = "0x2842498", Offset = "0x2842498", VA = "0x2842498")]
	public void SetInviteState(ulong id, InviteState state)
	{
	}

	[Token(Token = "0x600A2C9")]
	[Address(RVA = "0x284258C", Offset = "0x284258C", VA = "0x284258C")]
	private void Search()
	{
	}

	[Token(Token = "0x600A2CA")]
	[Address(RVA = "0x28428C4", Offset = "0x28428C4", VA = "0x28428C4")]
	public void ShowSearchResultView()
	{
	}

	[Token(Token = "0x600A2CB")]
	[Address(RVA = "0x2842B60", Offset = "0x2842B60", VA = "0x2842B60")]
	private void UpdateFriendListView()
	{
	}

	[Token(Token = "0x600A2CC")]
	[Address(RVA = "0x28429F0", Offset = "0x28429F0", VA = "0x28429F0")]
	private void RefreshEasyListView(List<FriendAccountInfo> data)
	{
	}

	[Token(Token = "0x600A2CD")]
	[Address(RVA = "0x2842D98", Offset = "0x2842D98", VA = "0x2842D98", Slot = "49")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A2CE")]
	[Address(RVA = "0x2842E3C", Offset = "0x2842E3C", VA = "0x2842E3C", Slot = "48")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A2CF")]
	[Address(RVA = "0x2842F68", Offset = "0x2842F68", VA = "0x2842F68")]
	private bool _003CUpdateFriendListView_003Em__0(FriendAccountInfo e)
	{
		return default(bool);
	}

	[Token(Token = "0x600A2D0")]
	[Address(RVA = "0x2842FA0", Offset = "0x2842FA0", VA = "0x2842FA0")]
	private static int _003CUpdateFriendListView_003Em__1(FriendAccountInfo e, FriendAccountInfo o)
	{
		return default(int);
	}

	[Token(Token = "0x600A2D1")]
	[Address(RVA = "0x2843010", Offset = "0x2843010", VA = "0x2843010")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A2D2")]
	[Address(RVA = "0x2843018", Offset = "0x2843018", VA = "0x2843018")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
