using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002AC8")]
internal class UIRelationshipInvitePickWndController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x40106D8")]
	[FieldOffset(Offset = "0x48")]
	private UIRelationshipInvitePickWndView m_View;

	[Token(Token = "0x40106D9")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_HasSearch;

	[Token(Token = "0x40106DA")]
	[FieldOffset(Offset = "0x50")]
	private uint m_WinkCall;

	[Token(Token = "0x40106DB")]
	[FieldOffset(Offset = "0x54")]
	private List<FriendAccountInfo> m_CachedFriends;

	[Token(Token = "0x6011870")]
	[Address(RVA = "0x1E4C758", Offset = "0x1E4C758", VA = "0x1E4C758")]
	public UIRelationshipInvitePickWndController()
	{
	}

	[Token(Token = "0x6011871")]
	[Address(RVA = "0x1E4C7E4", Offset = "0x1E4C7E4", VA = "0x1E4C7E4", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6011872")]
	[Address(RVA = "0x1E4C848", Offset = "0x1E4C848", VA = "0x1E4C848", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011873")]
	[Address(RVA = "0x1E4CB48", Offset = "0x1E4CB48", VA = "0x1E4CB48", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011874")]
	[Address(RVA = "0x1E4CCAC", Offset = "0x1E4CCAC", VA = "0x1E4CCAC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011875")]
	[Address(RVA = "0x1E4CD50", Offset = "0x1E4CD50", VA = "0x1E4CD50", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6011876")]
	[Address(RVA = "0x1E4CDCC", Offset = "0x1E4CDCC", VA = "0x1E4CDCC", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6011877")]
	[Address(RVA = "0x1E4CEC4", Offset = "0x1E4CEC4", VA = "0x1E4CEC4")]
	public void SetUIData(List<FriendAccountInfo> needShowFriendList)
	{
	}

	[Token(Token = "0x6011878")]
	[Address(RVA = "0x1E4D1D0", Offset = "0x1E4D1D0", VA = "0x1E4D1D0")]
	private void ResetSearchInput()
	{
	}

	[Token(Token = "0x6011879")]
	[Address(RVA = "0x1E4D090", Offset = "0x1E4D090", VA = "0x1E4D090")]
	private void RefreshScrollView()
	{
	}

	[Token(Token = "0x601187A")]
	[Address(RVA = "0x1E4D380", Offset = "0x1E4D380", VA = "0x1E4D380")]
	private void OnSearchInputGetFocus()
	{
	}

	[Token(Token = "0x601187B")]
	[Address(RVA = "0x1E4D47C", Offset = "0x1E4D47C", VA = "0x1E4D47C")]
	private void OnSearchInputChange()
	{
	}

	[Token(Token = "0x601187C")]
	[Address(RVA = "0x1E4D590", Offset = "0x1E4D590", VA = "0x1E4D590")]
	private void OnSearchBtnClick()
	{
	}

	[Token(Token = "0x601187D")]
	[Address(RVA = "0x1E4DB74", Offset = "0x1E4DB74", VA = "0x1E4DB74")]
	private void _003COnSearchBtnClick_003Em__0()
	{
	}

	[Token(Token = "0x601187E")]
	[Address(RVA = "0x1E4DBBC", Offset = "0x1E4DBBC", VA = "0x1E4DBBC")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x601187F")]
	[Address(RVA = "0x1E4DBC4", Offset = "0x1E4DBC4", VA = "0x1E4DBC4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011880")]
	[Address(RVA = "0x1E4DBCC", Offset = "0x1E4DBCC", VA = "0x1E4DBCC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
