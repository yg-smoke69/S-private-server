using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002083")]
public class UICupMatchTeamInviteController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x2002084")]
	public enum InviteState
	{
		[Token(Token = "0x400CBE0")]
		Normal,
		[Token(Token = "0x400CBE1")]
		Inviting,
		[Token(Token = "0x400CBE2")]
		Invited
	}

	[Token(Token = "0x400CBD5")]
	[FieldOffset(Offset = "0x48")]
	private UICupMatchTeamInviteView m_View;

	[Token(Token = "0x400CBD6")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelFriends m_ModelFriends;

	[Token(Token = "0x400CBD7")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<ulong, InviteState> m_InviteStates;

	[Token(Token = "0x400CBD8")]
	[FieldOffset(Offset = "0x54")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CBD9")]
	[FieldOffset(Offset = "0x58")]
	private bool m_GettedFriendsData;

	[Token(Token = "0x400CBDA")]
	[FieldOffset(Offset = "0x59")]
	private bool m_GettedInvitedListData;

	[Token(Token = "0x400CBDB")]
	[FieldOffset(Offset = "0x5C")]
	private int m_CupMatchKey;

	[Token(Token = "0x400CBDC")]
	[FieldOffset(Offset = "0x60")]
	private bool m_HasSearch;

	[Token(Token = "0x400CBDD")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<FriendAccountInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400CBDE")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<FriendAccountInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600A71D")]
	[Address(RVA = "0x2ABC8CC", Offset = "0x2ABC8CC", VA = "0x2ABC8CC")]
	public UICupMatchTeamInviteController()
	{
	}

	[Token(Token = "0x600A71E")]
	[Address(RVA = "0x2ABC958", Offset = "0x2ABC958", VA = "0x2ABC958")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A71F")]
	[Address(RVA = "0x2ABCA00", Offset = "0x2ABCA00", VA = "0x2ABCA00", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600A720")]
	[Address(RVA = "0x2ABCA7C", Offset = "0x2ABCA7C", VA = "0x2ABCA7C", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600A721")]
	[Address(RVA = "0x2ABCBFC", Offset = "0x2ABCBFC", VA = "0x2ABCBFC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A722")]
	[Address(RVA = "0x2ABCFE4", Offset = "0x2ABCFE4", VA = "0x2ABCFE4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A723")]
	[Address(RVA = "0x2ABD090", Offset = "0x2ABD090", VA = "0x2ABD090")]
	public void SetCupMatchKey(int key)
	{
	}

	[Token(Token = "0x600A724")]
	[Address(RVA = "0x2ABD118", Offset = "0x2ABD118", VA = "0x2ABD118")]
	public InviteState GetInviteState(ulong id)
	{
		return default(InviteState);
	}

	[Token(Token = "0x600A725")]
	[Address(RVA = "0x2ABD224", Offset = "0x2ABD224", VA = "0x2ABD224")]
	public void SetInviteState(ulong id, InviteState state)
	{
	}

	[Token(Token = "0x600A726")]
	[Address(RVA = "0x2ABD318", Offset = "0x2ABD318", VA = "0x2ABD318")]
	private void Search()
	{
	}

	[Token(Token = "0x600A727")]
	[Address(RVA = "0x2ABD8A4", Offset = "0x2ABD8A4", VA = "0x2ABD8A4")]
	private void ResetSearch()
	{
	}

	[Token(Token = "0x600A728")]
	[Address(RVA = "0x2ABDCA8", Offset = "0x2ABDCA8", VA = "0x2ABDCA8")]
	private void OnSearchInputGetFocus()
	{
	}

	[Token(Token = "0x600A729")]
	[Address(RVA = "0x2ABDDC4", Offset = "0x2ABDDC4", VA = "0x2ABDDC4")]
	public void ShowSearchResultView()
	{
	}

	[Token(Token = "0x600A72A")]
	[Address(RVA = "0x2ABDA74", Offset = "0x2ABDA74", VA = "0x2ABDA74")]
	private void UpdateFriendListView()
	{
	}

	[Token(Token = "0x600A72B")]
	[Address(RVA = "0x2ABDFA8", Offset = "0x2ABDFA8", VA = "0x2ABDFA8")]
	private void RefreshEasyListView(List<FriendAccountInfo> data)
	{
	}

	[Token(Token = "0x600A72C")]
	[Address(RVA = "0x2ABE118", Offset = "0x2ABE118", VA = "0x2ABE118", Slot = "49")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A72D")]
	[Address(RVA = "0x2ABE1BC", Offset = "0x2ABE1BC", VA = "0x2ABE1BC", Slot = "48")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A72E")]
	[Address(RVA = "0x2ABE3F8", Offset = "0x2ABE3F8", VA = "0x2ABE3F8")]
	private static int _003CShowSearchResultView_003Em__0(FriendAccountInfo e, FriendAccountInfo o)
	{
		return default(int);
	}

	[Token(Token = "0x600A72F")]
	[Address(RVA = "0x2ABE440", Offset = "0x2ABE440", VA = "0x2ABE440")]
	private bool _003CUpdateFriendListView_003Em__1(FriendAccountInfo e)
	{
		return default(bool);
	}

	[Token(Token = "0x600A730")]
	[Address(RVA = "0x2ABE480", Offset = "0x2ABE480", VA = "0x2ABE480")]
	private static int _003CUpdateFriendListView_003Em__2(FriendAccountInfo e, FriendAccountInfo o)
	{
		return default(int);
	}

	[Token(Token = "0x600A731")]
	[Address(RVA = "0x2ABE5DC", Offset = "0x2ABE5DC", VA = "0x2ABE5DC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A732")]
	[Address(RVA = "0x2ABE5E4", Offset = "0x2ABE5E4", VA = "0x2ABE5E4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
