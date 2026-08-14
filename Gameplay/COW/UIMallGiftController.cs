using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20021E7")]
public class UIMallGiftController : UIBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x20021E8")]
	private sealed class _003CCreatFriendInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D439")]
		[FieldOffset(Offset = "0x8")]
		internal EGiftStore_BuddyType buddyType;

		[Token(Token = "0x400D43A")]
		[FieldOffset(Offset = "0xC")]
		internal FriendInfo friendInfo;

		[Token(Token = "0x600B65F")]
		[Address(RVA = "0x2259450", Offset = "0x2259450", VA = "0x2259450")]
		public _003CCreatFriendInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600B660")]
		[Address(RVA = "0x225A8E4", Offset = "0x225A8E4", VA = "0x225A8E4")]
		internal bool _003C_003Em__0(FriendInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20021E9")]
	private sealed class _003COnSearchBtnClick_003Ec__AnonStorey1
	{
		[Token(Token = "0x400D43B")]
		[FieldOffset(Offset = "0x8")]
		internal string key;

		[Token(Token = "0x600B661")]
		[Address(RVA = "0x2259E40", Offset = "0x2259E40", VA = "0x2259E40")]
		public _003COnSearchBtnClick_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600B662")]
		[Address(RVA = "0x225A94C", Offset = "0x225A94C", VA = "0x225A94C")]
		internal bool _003C_003Em__0(FriendInfo a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400D424")]
	[FieldOffset(Offset = "0x28")]
	private UIMallGiftView m_View;

	[Token(Token = "0x400D425")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x400D426")]
	[FieldOffset(Offset = "0x30")]
	private UIModelFriends m_ModelFriends;

	[Token(Token = "0x400D427")]
	[FieldOffset(Offset = "0x34")]
	private UIModelGift m_ModelGift;

	[Token(Token = "0x400D428")]
	[FieldOffset(Offset = "0x38")]
	private UIModelUser m_ModelUser;

	[Token(Token = "0x400D429")]
	[FieldOffset(Offset = "0x3C")]
	private List<FriendInfo> m_FriendsList;

	[Token(Token = "0x400D42A")]
	[FieldOffset(Offset = "0x40")]
	private List<FriendInfo> m_ClanFriendsList;

	[Token(Token = "0x400D42B")]
	[FieldOffset(Offset = "0x44")]
	private List<FriendInfo> m_ReceiversList;

	[Token(Token = "0x400D42C")]
	[FieldOffset(Offset = "0x48")]
	private List<UIMallGiftReceiverCallsignController> m_ReceiversCallsignList;

	[Token(Token = "0x400D42D")]
	[FieldOffset(Offset = "0x4C")]
	private EGiftState m_GiftState;

	[Token(Token = "0x400D42E")]
	[FieldOffset(Offset = "0x50")]
	private EGiftStore_BuddyType m_FriendType;

	[Token(Token = "0x400D42F")]
	[FieldOffset(Offset = "0x54")]
	private Dictionary<uint, bool> m_AllSelectStateDict;

	[Token(Token = "0x400D430")]
	[FieldOffset(Offset = "0x58")]
	private GiftItem m_SelectedGift;

	[Token(Token = "0x400D431")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_IsSelectMax;

	[Token(Token = "0x400D432")]
	[FieldOffset(Offset = "0x60")]
	private string m_ReceiversName;

	[Token(Token = "0x400D433")]
	[FieldOffset(Offset = "0x64")]
	private int m_GetFriendNtfState;

	[Token(Token = "0x400D434")]
	[FieldOffset(Offset = "0x68")]
	private int m_GetClanFriendNtfState;

	[Token(Token = "0x400D435")]
	private const int GETFRIENDSLIST = 1;

	[Token(Token = "0x400D436")]
	private const int GETFRIENDSPRESENCE = 2;

	[Token(Token = "0x400D437")]
	[FieldOffset(Offset = "0x6C")]
	private EGiftStore_BuddyType m_LobbySelectFriendType;

	[Token(Token = "0x400D438")]
	[FieldOffset(Offset = "0x0")]
	private static Func<FriendInfo, ulong> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600B639")]
	[Address(RVA = "0x2253FD4", Offset = "0x2253FD4", VA = "0x2253FD4")]
	public UIMallGiftController()
	{
	}

	[Token(Token = "0x600B63A")]
	[Address(RVA = "0x2254138", Offset = "0x2254138", VA = "0x2254138")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B63B")]
	[Address(RVA = "0x22541DC", Offset = "0x22541DC", VA = "0x22541DC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B63C")]
	[Address(RVA = "0x2254B04", Offset = "0x2254B04", VA = "0x2254B04")]
	private void CloseReceiverListPanel(object[] data)
	{
	}

	[Token(Token = "0x600B63D")]
	[Address(RVA = "0x2254D38", Offset = "0x2254D38", VA = "0x2254D38")]
	public void SetGiftViewData(EGiftStore_BuddyType type, GiftItem giftItem)
	{
	}

	[Token(Token = "0x600B63E")]
	[Address(RVA = "0x22549C0", Offset = "0x22549C0", VA = "0x22549C0")]
	private void InitAllSelectBtnState()
	{
	}

	[Token(Token = "0x600B63F")]
	[Address(RVA = "0x22553E0", Offset = "0x22553E0", VA = "0x22553E0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B640")]
	[Address(RVA = "0x22555E8", Offset = "0x22555E8", VA = "0x22555E8")]
	private void OnFriendSelected(object[] data)
	{
	}

	[Token(Token = "0x600B641")]
	[Address(RVA = "0x2255798", Offset = "0x2255798", VA = "0x2255798")]
	private void RefreshFriendList(FriendInfo info, bool isSelected)
	{
	}

	[Token(Token = "0x600B642")]
	[Address(RVA = "0x2255310", Offset = "0x2255310", VA = "0x2255310")]
	private void GetFriendDataList()
	{
	}

	[Token(Token = "0x600B643")]
	[Address(RVA = "0x2255F98", Offset = "0x2255F98", VA = "0x2255F98")]
	public void OnMallBackClick()
	{
	}

	[Token(Token = "0x600B644")]
	[Address(RVA = "0x2255E6C", Offset = "0x2255E6C", VA = "0x2255E6C")]
	private int GetSelectNum()
	{
		return default(int);
	}

	[Token(Token = "0x600B645")]
	[Address(RVA = "0x2254FE8", Offset = "0x2254FE8", VA = "0x2254FE8")]
	private void RefreshSelectNum()
	{
	}

	[Token(Token = "0x600B646")]
	[Address(RVA = "0x2256370", Offset = "0x2256370", VA = "0x2256370", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600B647")]
	[Address(RVA = "0x22564F4", Offset = "0x22564F4", VA = "0x22564F4", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600B648")]
	[Address(RVA = "0x2256570", Offset = "0x2256570", VA = "0x2256570")]
	private void OnFriendBtnClick()
	{
	}

	[Token(Token = "0x600B649")]
	[Address(RVA = "0x2256940", Offset = "0x2256940", VA = "0x2256940")]
	private void OnClanFriendBtnClick()
	{
	}

	[Token(Token = "0x600B64A")]
	[Address(RVA = "0x22565D8", Offset = "0x22565D8", VA = "0x22565D8")]
	private void RefreshFriendListView()
	{
	}

	[Token(Token = "0x600B64B")]
	private void RefreshViewData<DataType>(List<DataType> dataList, bool needResort = true)
	{
	}

	[Token(Token = "0x600B64C")]
	[Address(RVA = "0x22569A8", Offset = "0x22569A8", VA = "0x22569A8")]
	private void OnNextBtnClick()
	{
	}

	[Token(Token = "0x600B64D")]
	[Address(RVA = "0x2256CF8", Offset = "0x2256CF8", VA = "0x2256CF8")]
	private void SetGivePanelData()
	{
	}

	[Token(Token = "0x600B64E")]
	[Address(RVA = "0x2256F44", Offset = "0x2256F44", VA = "0x2256F44")]
	private void SetGiveFriendsName()
	{
	}

	[Token(Token = "0x600B64F")]
	[Address(RVA = "0x225756C", Offset = "0x225756C", VA = "0x225756C")]
	private void RefreshReceiverCallsign(int i)
	{
	}

	[Token(Token = "0x600B650")]
	[Address(RVA = "0x2255D2C", Offset = "0x2255D2C", VA = "0x2255D2C")]
	private void SetAllSelectState(bool state)
	{
	}

	[Token(Token = "0x600B651")]
	[Address(RVA = "0x2257A20", Offset = "0x2257A20", VA = "0x2257A20")]
	private void OnAllSelectBtnClick()
	{
	}

	[Token(Token = "0x600B652")]
	[Address(RVA = "0x2257C20", Offset = "0x2257C20", VA = "0x2257C20")]
	private void OnNameBtnClick()
	{
	}

	[Token(Token = "0x600B653")]
	[Address(RVA = "0x2257D94", Offset = "0x2257D94", VA = "0x2257D94")]
	private void OnSendBtnClick()
	{
	}

	[Token(Token = "0x600B654")]
	[Address(RVA = "0x22585C4", Offset = "0x22585C4", VA = "0x22585C4", Slot = "34")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600B655")]
	[Address(RVA = "0x22586A0", Offset = "0x22586A0", VA = "0x22586A0", Slot = "33")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600B656")]
	[Address(RVA = "0x2258F58", Offset = "0x2258F58", VA = "0x2258F58")]
	private void CreatFriendInfo(FriendInfo friendInfo, EGiftStore_BuddyType buddyType, List<FriendInfo> list)
	{
	}

	[Token(Token = "0x600B657")]
	[Address(RVA = "0x2259458", Offset = "0x2259458", VA = "0x2259458")]
	private void CheckCondition(FriendInfo info)
	{
	}

	[Token(Token = "0x600B658")]
	[Address(RVA = "0x2259BE4", Offset = "0x2259BE4", VA = "0x2259BE4")]
	private void OnSearchBtnClick()
	{
	}

	[Token(Token = "0x600B659")]
	[Address(RVA = "0x2259E48", Offset = "0x2259E48", VA = "0x2259E48")]
	private void OnRuleBtnClick()
	{
	}

	[Token(Token = "0x600B65A")]
	[Address(RVA = "0x225A730", Offset = "0x225A730", VA = "0x225A730", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600B65B")]
	[Address(RVA = "0x225A8A8", Offset = "0x225A8A8", VA = "0x225A8A8")]
	private static ulong _003COnSendBtnClick_003Em__0(FriendInfo a)
	{
		return default(ulong);
	}

	[Token(Token = "0x600B65C")]
	[Address(RVA = "0x225A8CC", Offset = "0x225A8CC", VA = "0x225A8CC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B65D")]
	[Address(RVA = "0x225A8D4", Offset = "0x225A8D4", VA = "0x225A8D4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600B65E")]
	[Address(RVA = "0x225A8DC", Offset = "0x225A8DC", VA = "0x225A8DC")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
