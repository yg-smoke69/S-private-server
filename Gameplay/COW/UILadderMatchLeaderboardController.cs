using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x200215E")]
internal class UILadderMatchLeaderboardController : UIBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x400D18E")]
	[FieldOffset(Offset = "0x28")]
	private LadderMatchLeaderboardView m_View;

	[Token(Token = "0x400D18F")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelLeaderBoard m_ModelBoard;

	[Token(Token = "0x400D190")]
	[FieldOffset(Offset = "0x30")]
	private UIModelCSLadderMatch m_ModelLadderCS;

	[Token(Token = "0x400D191")]
	[FieldOffset(Offset = "0x34")]
	private UIModelPeriodicLadderMatch m_ModelLadderPeriodic;

	[Token(Token = "0x400D192")]
	[FieldOffset(Offset = "0x38")]
	private uint m_BRFriendBoardType;

	[Token(Token = "0x400D193")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_BRRegionBoardType;

	[Token(Token = "0x400D194")]
	[FieldOffset(Offset = "0x40")]
	private int m_SeasonID;

	[Token(Token = "0x400D195")]
	[FieldOffset(Offset = "0x44")]
	private bool NeedResetListPos;

	[Token(Token = "0x400D196")]
	[FieldOffset(Offset = "0x45")]
	private bool m_IsShrink;

	[Token(Token = "0x400D197")]
	[FieldOffset(Offset = "0x48")]
	private DGNDKMLMLPM m_LadderMatchType;

	[Token(Token = "0x400D198")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_IsRegion;

	[Token(Token = "0x400D199")]
	[FieldOffset(Offset = "0x50")]
	private UILadderMatchLeaderboardItemController m_selfLeaderItem;

	[Token(Token = "0x400D19A")]
	[FieldOffset(Offset = "0x54")]
	private Vector4 m_BaseClipRegion;

	[Token(Token = "0x400D19B")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 m_MainWidgetOriginalPosition;

	[Token(Token = "0x400D19C")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 m_MainWidgetShrinkPosition;

	[Token(Token = "0x1700101D")]
	public DGNDKMLMLPM LadderMatchType
	{
		[Token(Token = "0x600B04C")]
		[Address(RVA = "0x1AEE934", Offset = "0x1AEE934", VA = "0x1AEE934")]
		get
		{
			return default(DGNDKMLMLPM);
		}
	}

	[Token(Token = "0x1700101E")]
	public bool IsShrink
	{
		[Token(Token = "0x600B04D")]
		[Address(RVA = "0x1AEE98C", Offset = "0x1AEE98C", VA = "0x1AEE98C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600B04E")]
		[Address(RVA = "0x1AEE9E4", Offset = "0x1AEE9E4", VA = "0x1AEE9E4")]
		set
		{
		}
	}

	[Token(Token = "0x600B04B")]
	[Address(RVA = "0x1AEE890", Offset = "0x1AEE890", VA = "0x1AEE890")]
	public UILadderMatchLeaderboardController()
	{
	}

	[Token(Token = "0x600B04F")]
	[Address(RVA = "0x1AEEA44", Offset = "0x1AEEA44", VA = "0x1AEEA44")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B050")]
	[Address(RVA = "0x1AEEAE8", Offset = "0x1AEEAE8", VA = "0x1AEEAE8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B051")]
	[Address(RVA = "0x1AEF0CC", Offset = "0x1AEF0CC", VA = "0x1AEF0CC")]
	public void SetViewData(DGNDKMLMLPM ladderMatchType)
	{
	}

	[Token(Token = "0x600B052")]
	[Address(RVA = "0x1AEF464", Offset = "0x1AEF464", VA = "0x1AEF464")]
	private void OnFriendTabClick()
	{
	}

	[Token(Token = "0x600B053")]
	[Address(RVA = "0x1AF0464", Offset = "0x1AF0464", VA = "0x1AF0464")]
	private void RefreshToggleBtnStateFriendsAndAll(bool isFriend)
	{
	}

	[Token(Token = "0x600B054")]
	[Address(RVA = "0x1AF059C", Offset = "0x1AF059C", VA = "0x1AF059C")]
	private void OnGlobalTabClick()
	{
	}

	[Token(Token = "0x600B055")]
	[Address(RVA = "0x1AF07F4", Offset = "0x1AF07F4", VA = "0x1AF07F4")]
	public void InitTweenBoard()
	{
	}

	[Token(Token = "0x600B056")]
	[Address(RVA = "0x1AF0A08", Offset = "0x1AF0A08", VA = "0x1AF0A08")]
	public void OnBtnHideClick()
	{
	}

	[Token(Token = "0x600B057")]
	[Address(RVA = "0x1AF0BC8", Offset = "0x1AF0BC8", VA = "0x1AF0BC8")]
	public void OnBtnCloseClick()
	{
	}

	[Token(Token = "0x600B058")]
	[Address(RVA = "0x1AEFAA0", Offset = "0x1AEFAA0", VA = "0x1AEFAA0")]
	private void RefreshSelfRank(List<LeaderBoardInfo> _list)
	{
	}

	[Token(Token = "0x600B059")]
	[Address(RVA = "0x1AF001C", Offset = "0x1AF001C", VA = "0x1AF001C")]
	private void RefreshSelfCSRank(bool isFriend = false)
	{
	}

	[Token(Token = "0x600B05A")]
	[Address(RVA = "0x1AF0250", Offset = "0x1AF0250", VA = "0x1AF0250")]
	private void RefreshSelfPeriodicRank(bool isFriend = false)
	{
	}

	[Token(Token = "0x600B05B")]
	[Address(RVA = "0x1AEF6C0", Offset = "0x1AEF6C0", VA = "0x1AEF6C0")]
	private void RefreshItemList(List<LeaderBoardInfo> _list)
	{
	}

	[Token(Token = "0x600B05C")]
	[Address(RVA = "0x1AF1330", Offset = "0x1AF1330", VA = "0x1AF1330", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600B05D")]
	[Address(RVA = "0x1AF148C", Offset = "0x1AF148C", VA = "0x1AF148C", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600B05E")]
	[Address(RVA = "0x1AF158C", Offset = "0x1AF158C", VA = "0x1AF158C", Slot = "33")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600B05F")]
	[Address(RVA = "0x1AF1684", Offset = "0x1AF1684", VA = "0x1AF1684", Slot = "34")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600B060")]
	[Address(RVA = "0x1AF1700", Offset = "0x1AF1700", VA = "0x1AF1700")]
	private void _003CInitTweenBoard_003Em__0()
	{
	}

	[Token(Token = "0x600B061")]
	[Address(RVA = "0x1AF1894", Offset = "0x1AF1894", VA = "0x1AF1894")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
