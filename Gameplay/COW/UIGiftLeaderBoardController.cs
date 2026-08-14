using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20021BC")]
public class UIGiftLeaderBoardController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x400D318")]
	[FieldOffset(Offset = "0x48")]
	private UIGiftLeaderBoardView m_View;

	[Token(Token = "0x400D319")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelLeaderBoard m_ModelLeaderBoard;

	[Token(Token = "0x400D31A")]
	[FieldOffset(Offset = "0x50")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x400D31B")]
	[FieldOffset(Offset = "0x54")]
	private UIModelGift m_ModelGift;

	[Token(Token = "0x400D31C")]
	[FieldOffset(Offset = "0x58")]
	private EStore.GiftRankType m_LeaderBoardType;

	[Token(Token = "0x400D31D")]
	[FieldOffset(Offset = "0x5C")]
	private UIGiftLeaderBoardItemController m_SelfRankUI;

	[Token(Token = "0x400D31E")]
	[FieldOffset(Offset = "0x60")]
	private uint m_NextRewardCount;

	[Token(Token = "0x400D31F")]
	[FieldOffset(Offset = "0x64")]
	private int m_RewardListCount;

	[Token(Token = "0x400D320")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<GiftRewardDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x1700102A")]
	public EStore.GiftRankType LeaderBoardType
	{
		[Token(Token = "0x600B428")]
		[Address(RVA = "0x21986B4", Offset = "0x21986B4", VA = "0x21986B4")]
		get
		{
			return default(EStore.GiftRankType);
		}
	}

	[Token(Token = "0x600B427")]
	[Address(RVA = "0x21986A4", Offset = "0x21986A4", VA = "0x21986A4")]
	public UIGiftLeaderBoardController()
	{
	}

	[Token(Token = "0x600B429")]
	[Address(RVA = "0x219870C", Offset = "0x219870C", VA = "0x219870C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B42A")]
	[Address(RVA = "0x21987B4", Offset = "0x21987B4", VA = "0x21987B4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B42B")]
	[Address(RVA = "0x2198C68", Offset = "0x2198C68", VA = "0x2198C68")]
	private void OnGetGiftLeaderBoardReward(object[] data)
	{
	}

	[Token(Token = "0x600B42C")]
	[Address(RVA = "0x2198E50", Offset = "0x2198E50", VA = "0x2198E50")]
	private void OnReceiverToggleClick()
	{
	}

	[Token(Token = "0x600B42D")]
	[Address(RVA = "0x2199A30", Offset = "0x2199A30", VA = "0x2199A30")]
	private void OnGiverToggleClick()
	{
	}

	[Token(Token = "0x600B42E")]
	[Address(RVA = "0x2199AA0", Offset = "0x2199AA0", VA = "0x2199AA0")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600B42F")]
	[Address(RVA = "0x2199B04", Offset = "0x2199B04", VA = "0x2199B04", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B430")]
	[Address(RVA = "0x2199C80", Offset = "0x2199C80", VA = "0x2199C80")]
	private void RefreshLeaderBoardView(int propID)
	{
	}

	[Token(Token = "0x600B431")]
	[Address(RVA = "0x2199DC8", Offset = "0x2199DC8", VA = "0x2199DC8")]
	private void SetSelfInfo(int propID)
	{
	}

	[Token(Token = "0x600B432")]
	[Address(RVA = "0x2198EC0", Offset = "0x2198EC0", VA = "0x2198EC0")]
	private void RefreshRankInfoView()
	{
	}

	[Token(Token = "0x600B433")]
	[Address(RVA = "0x2199778", Offset = "0x2199778", VA = "0x2199778")]
	private void RefreshRewardsListView()
	{
	}

	[Token(Token = "0x600B434")]
	[Address(RVA = "0x219A0B0", Offset = "0x219A0B0", VA = "0x219A0B0", Slot = "48")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600B435")]
	[Address(RVA = "0x219A2D4", Offset = "0x219A2D4", VA = "0x219A2D4", Slot = "49")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600B436")]
	[Address(RVA = "0x219A390", Offset = "0x219A390", VA = "0x219A390", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600B437")]
	[Address(RVA = "0x219A58C", Offset = "0x219A58C", VA = "0x219A58C", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600B438")]
	[Address(RVA = "0x219A608", Offset = "0x219A608", VA = "0x219A608")]
	private void _003CRefreshRankInfoView_003Em__0()
	{
	}

	[Token(Token = "0x600B439")]
	[Address(RVA = "0x219A734", Offset = "0x219A734", VA = "0x219A734")]
	private static int _003CRefreshRewardsListView_003Em__1(GiftRewardDesc a, GiftRewardDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x600B43A")]
	[Address(RVA = "0x219A77C", Offset = "0x219A77C", VA = "0x219A77C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B43B")]
	[Address(RVA = "0x219A784", Offset = "0x219A784", VA = "0x219A784")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
