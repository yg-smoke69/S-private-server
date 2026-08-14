using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002610")]
public class UIFastSendGiftController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x400EAF4")]
	[FieldOffset(Offset = "0x48")]
	private UIFastSendGiftView m_View;

	[Token(Token = "0x400EAF5")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelGift m_ModelGift;

	[Token(Token = "0x400EAF6")]
	[FieldOffset(Offset = "0x50")]
	private UIModelUser m_ModelUser;

	[Token(Token = "0x400EAF7")]
	[FieldOffset(Offset = "0x54")]
	private uint m_SelectedItemId;

	[Token(Token = "0x400EAF8")]
	[FieldOffset(Offset = "0x58")]
	private List<FriendInfo> m_ReceiversList;

	[Token(Token = "0x400EAF9")]
	[FieldOffset(Offset = "0x5C")]
	private List<FriendInfo> m_TeamMatesList;

	[Token(Token = "0x400EAFA")]
	[FieldOffset(Offset = "0x60")]
	private uint m_CoinsPrice;

	[Token(Token = "0x400EAFB")]
	[FieldOffset(Offset = "0x64")]
	private uint m_GemsPrice;

	[Token(Token = "0x400EAFC")]
	[FieldOffset(Offset = "0x68")]
	private bool m_HotItemClick;

	[Token(Token = "0x400EAFD")]
	[FieldOffset(Offset = "0x69")]
	private bool m_IsIngame;

	[Token(Token = "0x400EAFE")]
	[FieldOffset(Offset = "0x0")]
	private static Func<FriendInfo, ulong> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400EAFF")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<GiftItem> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600E11C")]
	[Address(RVA = "0x1DB5A60", Offset = "0x1DB5A60", VA = "0x1DB5A60")]
	public UIFastSendGiftController()
	{
	}

	[Token(Token = "0x600E11D")]
	[Address(RVA = "0x1DB5B04", Offset = "0x1DB5B04", VA = "0x1DB5B04")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E11E")]
	[Address(RVA = "0x1DB5BAC", Offset = "0x1DB5BAC", VA = "0x1DB5BAC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E11F")]
	[Address(RVA = "0x1DB6020", Offset = "0x1DB6020", VA = "0x1DB6020")]
	private void OnSendBtnClick()
	{
	}

	[Token(Token = "0x600E120")]
	[Address(RVA = "0x1DB690C", Offset = "0x1DB690C", VA = "0x1DB690C")]
	private void OnGiftItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600E121")]
	[Address(RVA = "0x1DB6C44", Offset = "0x1DB6C44", VA = "0x1DB6C44")]
	private void OnGiftFriendSelected(object[] data)
	{
	}

	[Token(Token = "0x600E122")]
	[Address(RVA = "0x1DB6DB4", Offset = "0x1DB6DB4", VA = "0x1DB6DB4")]
	private void RefreshFriendList(FriendInfo info, bool isSelected)
	{
	}

	[Token(Token = "0x600E123")]
	[Address(RVA = "0x1DB6F74", Offset = "0x1DB6F74", VA = "0x1DB6F74")]
	private void RefreshPrice()
	{
	}

	[Token(Token = "0x600E124")]
	[Address(RVA = "0x1DB69E8", Offset = "0x1DB69E8", VA = "0x1DB69E8")]
	private void RefreshItemView(uint commodityID)
	{
	}

	[Token(Token = "0x600E125")]
	[Address(RVA = "0x1DB718C", Offset = "0x1DB718C", VA = "0x1DB718C")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600E126")]
	[Address(RVA = "0x1DB71F0", Offset = "0x1DB71F0", VA = "0x1DB71F0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E127")]
	[Address(RVA = "0x1DB7408", Offset = "0x1DB7408", VA = "0x1DB7408")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600E128")]
	[Address(RVA = "0x1DB7478", Offset = "0x1DB7478", VA = "0x1DB7478")]
	private void RefreshHotGiftItem()
	{
	}

	[Token(Token = "0x600E129")]
	[Address(RVA = "0x1DB76F0", Offset = "0x1DB76F0", VA = "0x1DB76F0")]
	private void RefreshAllGiftItem()
	{
	}

	[Token(Token = "0x600E12A")]
	[Address(RVA = "0x1DB7C10", Offset = "0x1DB7C10", VA = "0x1DB7C10")]
	private void RefreshDataListView(List<GiftItem> dataList, bool isHotItem = false, bool needSort = true)
	{
	}

	[Token(Token = "0x600E12B")]
	[Address(RVA = "0x1DB78C0", Offset = "0x1DB78C0", VA = "0x1DB78C0")]
	private void RefreshTeamMateInfo()
	{
	}

	[Token(Token = "0x600E12C")]
	[Address(RVA = "0x1DB85A0", Offset = "0x1DB85A0", VA = "0x1DB85A0", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E12D")]
	[Address(RVA = "0x1DB8634", Offset = "0x1DB8634", VA = "0x1DB8634", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E12E")]
	[Address(RVA = "0x1DB8828", Offset = "0x1DB8828", VA = "0x1DB8828", Slot = "48")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600E12F")]
	[Address(RVA = "0x1DB8B54", Offset = "0x1DB8B54", VA = "0x1DB8B54", Slot = "49")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600E130")]
	[Address(RVA = "0x1DB7E14", Offset = "0x1DB7E14", VA = "0x1DB7E14")]
	private void CheckCondition(FriendInfo info)
	{
	}

	[Token(Token = "0x600E131")]
	[Address(RVA = "0x1DB8BD0", Offset = "0x1DB8BD0", VA = "0x1DB8BD0")]
	public void SetTeamMatesData(List<FriendInfo> teamMatesList)
	{
	}

	[Token(Token = "0x600E132")]
	[Address(RVA = "0x1DB8C5C", Offset = "0x1DB8C5C", VA = "0x1DB8C5C")]
	public void IsIngame(bool isInGame = false)
	{
	}

	[Token(Token = "0x600E133")]
	[Address(RVA = "0x1DB8CBC", Offset = "0x1DB8CBC", VA = "0x1DB8CBC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E134")]
	[Address(RVA = "0x1DB8E00", Offset = "0x1DB8E00", VA = "0x1DB8E00")]
	private static ulong _003COnSendBtnClick_003Em__0(FriendInfo a)
	{
		return default(ulong);
	}

	[Token(Token = "0x600E135")]
	[Address(RVA = "0x1DB8E24", Offset = "0x1DB8E24", VA = "0x1DB8E24")]
	private static bool _003CRefreshHotGiftItem_003Em__1(GiftItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x600E136")]
	[Address(RVA = "0x1DB8E48", Offset = "0x1DB8E48", VA = "0x1DB8E48")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E137")]
	[Address(RVA = "0x1DB8E50", Offset = "0x1DB8E50", VA = "0x1DB8E50")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600E138")]
	[Address(RVA = "0x1DB8E58", Offset = "0x1DB8E58", VA = "0x1DB8E58")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
