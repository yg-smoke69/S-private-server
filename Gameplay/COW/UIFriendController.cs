using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200261F")]
public class UIFriendController : UINavigationController, _Attribute, IConvertible, IComparable<int>
{
	[Token(Token = "0x2002620")]
	private sealed class _003CSelectSpecifiedTab_003Ec__AnonStorey0
	{
		[Token(Token = "0x400EB76")]
		[FieldOffset(Offset = "0x8")]
		internal EFriendTabType friendTabType;

		[Token(Token = "0x600E21A")]
		[Address(RVA = "0x24FB860", Offset = "0x24FB860", VA = "0x24FB860")]
		public _003CSelectSpecifiedTab_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600E21B")]
		[Address(RVA = "0x24FF20C", Offset = "0x24FF20C", VA = "0x24FF20C")]
		internal bool _003C_003Em__0(StandardTabItemViewData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400EB58")]
	[FieldOffset(Offset = "0x68")]
	private UIFriendViewExt m_View;

	[Token(Token = "0x400EB59")]
	[FieldOffset(Offset = "0x6C")]
	private UIRelationshipController m_RelationShipController;

	[Token(Token = "0x400EB5A")]
	[FieldOffset(Offset = "0x70")]
	private UIModelShare m_ModelShare;

	[Token(Token = "0x400EB5B")]
	[FieldOffset(Offset = "0x74")]
	private List<StandardTabItemViewData> m_TabDataList;

	[Token(Token = "0x400EB5C")]
	[FieldOffset(Offset = "0x78")]
	private UIStandardTabController m_TabCtrl;

	[Token(Token = "0x400EB5D")]
	[FieldOffset(Offset = "0x7C")]
	private UIAddFriendController m_AddFriendController;

	[Token(Token = "0x400EB5E")]
	[FieldOffset(Offset = "0x80")]
	private EFriendTabType m_CurrentType;

	[Token(Token = "0x400EB5F")]
	private const string FACEBOOK_ICON_SPRITENAME = "FF_FaceBookIcon";

	[Token(Token = "0x400EB60")]
	private const string VK_ICON_SPRITENAME = "FF_VKIcon";

	[Token(Token = "0x400EB61")]
	private const string GPLUS_ICON_SPRITENAME = "";

	[Token(Token = "0x400EB62")]
	private const int MAX_FRIEND_REQUESTS = 100;

	[Token(Token = "0x400EB63")]
	[FieldOffset(Offset = "0x84")]
	private string m_InviterUIDFromLink;

	[Token(Token = "0x400EB64")]
	[FieldOffset(Offset = "0x88")]
	private bool m_IsFirstOpen;

	[Token(Token = "0x400EB65")]
	[FieldOffset(Offset = "0x89")]
	private bool m_IsFirstNavigationShow;

	[Token(Token = "0x400EB66")]
	[FieldOffset(Offset = "0x8C")]
	private int m_scrollWidth;

	[Token(Token = "0x400EB67")]
	[FieldOffset(Offset = "0x90")]
	private bool m_HasSearch;

	[Token(Token = "0x400EB68")]
	[FieldOffset(Offset = "0x94")]
	private uint m_WinkCall;

	[Token(Token = "0x400EB69")]
	[FieldOffset(Offset = "0x98")]
	private bool m_isFriendReunionDirty;

	[Token(Token = "0x400EB6A")]
	private const float REWARDBACKDARK = 0.4f;

	[Token(Token = "0x400EB6B")]
	private const float REWARDBACKLIGHT = 0.3f;

	[Token(Token = "0x400EB6C")]
	[FieldOffset(Offset = "0x9C")]
	private UICommonGuideController m_RelationshipGraphGuide;

	[Token(Token = "0x400EB6D")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<StandardTabItemViewData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400EB6E")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<StandardTabItemViewData> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400EB6F")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<StandardTabItemViewData> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400EB70")]
	[FieldOffset(Offset = "0xC")]
	private static Predicate<FriendAccountInfo> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x400EB71")]
	[FieldOffset(Offset = "0x10")]
	private static Predicate<FriendAccountInfo> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x400EB72")]
	[FieldOffset(Offset = "0x14")]
	private static Predicate<StandardTabItemViewData> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x400EB73")]
	[FieldOffset(Offset = "0x18")]
	private static Predicate<StandardTabItemViewData> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x400EB74")]
	[FieldOffset(Offset = "0x1C")]
	private static Predicate<StandardTabItemViewData> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x400EB75")]
	[FieldOffset(Offset = "0x20")]
	private static Predicate<StandardTabItemViewData> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x1700115D")]
	public EFriendTabType CurrentTabType
	{
		[Token(Token = "0x600E1E3")]
		[Address(RVA = "0x24F5A64", Offset = "0x24F5A64", VA = "0x24F5A64")]
		get
		{
			return default(EFriendTabType);
		}
		[Token(Token = "0x600E1E4")]
		[Address(RVA = "0x24F5ABC", Offset = "0x24F5ABC", VA = "0x24F5ABC")]
		private set
		{
		}
	}

	[Token(Token = "0x600E1E2")]
	[Address(RVA = "0x24F59A4", Offset = "0x24F59A4", VA = "0x24F59A4")]
	public UIFriendController()
	{
	}

	[Token(Token = "0x600E1E5")]
	[Address(RVA = "0x24F6424", Offset = "0x24F6424", VA = "0x24F6424")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E1E6")]
	[Address(RVA = "0x24F64C8", Offset = "0x24F64C8", VA = "0x24F64C8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E1E7")]
	[Address(RVA = "0x24F7D58", Offset = "0x24F7D58", VA = "0x24F7D58", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600E1E8")]
	[Address(RVA = "0x24F7764", Offset = "0x24F7764", VA = "0x24F7764")]
	private void InitToggles()
	{
	}

	[Token(Token = "0x600E1E9")]
	[Address(RVA = "0x24F7DBC", Offset = "0x24F7DBC", VA = "0x24F7DBC", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600E1EA")]
	[Address(RVA = "0x24F8688", Offset = "0x24F8688", VA = "0x24F8688", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x600E1EB")]
	[Address(RVA = "0x24F5EF8", Offset = "0x24F5EF8", VA = "0x24F5EF8")]
	private void UpdateShareUI()
	{
	}

	[Token(Token = "0x600E1EC")]
	[Address(RVA = "0x24F8874", Offset = "0x24F8874", VA = "0x24F8874", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600E1ED")]
	[Address(RVA = "0x24F8C20", Offset = "0x24F8C20", VA = "0x24F8C20")]
	private void OnWatchLiveBtnClick()
	{
	}

	[Token(Token = "0x600E1EE")]
	[Address(RVA = "0x24F8D08", Offset = "0x24F8D08", VA = "0x24F8D08")]
	private void OnFriendRelationshipBtnClick()
	{
	}

	[Token(Token = "0x600E1EF")]
	[Address(RVA = "0x24F8FEC", Offset = "0x24F8FEC", VA = "0x24F8FEC")]
	private void OnGotoPlatformFriends(object[] parameters)
	{
	}

	[Token(Token = "0x600E1F0")]
	[Address(RVA = "0x24F9170", Offset = "0x24F9170", VA = "0x24F9170")]
	private void OnSelectPlatformFriend()
	{
	}

	[Token(Token = "0x600E1F1")]
	[Address(RVA = "0x24FAF2C", Offset = "0x24FAF2C", VA = "0x24FAF2C")]
	private void OnSelectFriend()
	{
	}

	[Token(Token = "0x600E1F2")]
	[Address(RVA = "0x24FB16C", Offset = "0x24FB16C", VA = "0x24FB16C")]
	private void OnSelectAddFriend()
	{
	}

	[Token(Token = "0x600E1F3")]
	[Address(RVA = "0x24FB310", Offset = "0x24FB310", VA = "0x24FB310")]
	private void OnSelectShowRelationship()
	{
	}

	[Token(Token = "0x600E1F4")]
	[Address(RVA = "0x24FB550", Offset = "0x24FB550", VA = "0x24FB550")]
	private void OnSelectTrainingCamp()
	{
	}

	[Token(Token = "0x600E1F5")]
	[Address(RVA = "0x24F82E4", Offset = "0x24F82E4", VA = "0x24F82E4")]
	private void SelectTrainingCampTab()
	{
	}

	[Token(Token = "0x600E1F6")]
	[Address(RVA = "0x24F8174", Offset = "0x24F8174", VA = "0x24F8174")]
	private void SelectRelationshipTab()
	{
	}

	[Token(Token = "0x600E1F7")]
	[Address(RVA = "0x24F8454", Offset = "0x24F8454", VA = "0x24F8454")]
	private void SelectSpecifiedTab(EFriendTabType friendTabType)
	{
	}

	[Token(Token = "0x600E1F8")]
	[Address(RVA = "0x24FB868", Offset = "0x24FB868", VA = "0x24FB868")]
	private void HideItemController(UIFriendItemController item)
	{
	}

	[Token(Token = "0x600E1F9")]
	[Address(RVA = "0x24F7C1C", Offset = "0x24F7C1C", VA = "0x24F7C1C")]
	private void RefreshHint()
	{
	}

	[Token(Token = "0x600E1FA")]
	[Address(RVA = "0x24F93A0", Offset = "0x24F93A0", VA = "0x24F93A0")]
	private void RefreshList(List<FriendAccountInfo> accountList, bool keep_page = false)
	{
	}

	[Token(Token = "0x600E1FB")]
	[Address(RVA = "0x24F9700", Offset = "0x24F9700", VA = "0x24F9700")]
	private void RefreshViewInfo()
	{
	}

	[Token(Token = "0x600E1FC")]
	[Address(RVA = "0x24FBC30", Offset = "0x24FBC30", VA = "0x24FBC30")]
	private void RefreshFriendListEmptyAction(int totalCnt, EFriendTabType tabType)
	{
	}

	[Token(Token = "0x600E1FD")]
	[Address(RVA = "0x24FC664", Offset = "0x24FC664", VA = "0x24FC664")]
	private void GotoAddFriendTab()
	{
	}

	[Token(Token = "0x600E1FE")]
	[Address(RVA = "0x24FC7D4", Offset = "0x24FC7D4", VA = "0x24FC7D4")]
	private void ShowBindAccountWnd()
	{
	}

	[Token(Token = "0x600E1FF")]
	[Address(RVA = "0x24FC96C", Offset = "0x24FC96C", VA = "0x24FC96C", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E200")]
	[Address(RVA = "0x24FCA24", Offset = "0x24FCA24", VA = "0x24FCA24", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E201")]
	[Address(RVA = "0x24FD294", Offset = "0x24FD294", VA = "0x24FD294")]
	private void OnOtherClick()
	{
	}

	[Token(Token = "0x600E202")]
	[Address(RVA = "0x24FD580", Offset = "0x24FD580", VA = "0x24FD580")]
	private void OnCopyLink()
	{
	}

	[Token(Token = "0x600E203")]
	[Address(RVA = "0x24FD928", Offset = "0x24FD928", VA = "0x24FD928")]
	private void OnInviteClick()
	{
	}

	[Token(Token = "0x600E204")]
	[Address(RVA = "0x24FDAA4", Offset = "0x24FDAA4", VA = "0x24FDAA4")]
	private void OnLineClick()
	{
	}

	[Token(Token = "0x600E205")]
	[Address(RVA = "0x24FDF08", Offset = "0x24FDF08", VA = "0x24FDF08", Slot = "44")]
	private void COW_002EITipsDelegate_002EOnTipsDataChange(ETipsType type, int num)
	{
	}

	[Token(Token = "0x600E206")]
	[Address(RVA = "0x24FDF88", Offset = "0x24FDF88", VA = "0x24FDF88", Slot = "45")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600E207")]
	[Address(RVA = "0x24FE1E8", Offset = "0x24FE1E8", VA = "0x24FE1E8", Slot = "46")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600E208")]
	[Address(RVA = "0x24FE264", Offset = "0x24FE264", VA = "0x24FE264")]
	private void OnAddFriendsBtnClicked()
	{
	}

	[Token(Token = "0x600E209")]
	[Address(RVA = "0x24FE5B0", Offset = "0x24FE5B0", VA = "0x24FE5B0")]
	private void OnSearchFriendBtnClicked()
	{
	}

	[Token(Token = "0x600E20A")]
	[Address(RVA = "0x24FEB94", Offset = "0x24FEB94", VA = "0x24FEB94")]
	private void OnSearchInputGetFocus()
	{
	}

	[Token(Token = "0x600E20B")]
	[Address(RVA = "0x24FEC70", Offset = "0x24FEC70", VA = "0x24FEC70")]
	private void OnSearchInputChange()
	{
	}

	[Token(Token = "0x600E20C")]
	[Address(RVA = "0x24FEDF4", Offset = "0x24FEDF4", VA = "0x24FEDF4")]
	private static bool _003COnGotoPlatformFriends_003Em__0(StandardTabItemViewData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600E20D")]
	[Address(RVA = "0x24FEE74", Offset = "0x24FEE74", VA = "0x24FEE74")]
	private static bool _003CSelectTrainingCampTab_003Em__1(StandardTabItemViewData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600E20E")]
	[Address(RVA = "0x24FEEF8", Offset = "0x24FEEF8", VA = "0x24FEEF8")]
	private static bool _003CSelectRelationshipTab_003Em__2(StandardTabItemViewData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600E20F")]
	[Address(RVA = "0x24FEF7C", Offset = "0x24FEF7C", VA = "0x24FEF7C")]
	private static bool _003CRefreshViewInfo_003Em__3(FriendAccountInfo x)
	{
		return default(bool);
	}

	[Token(Token = "0x600E210")]
	[Address(RVA = "0x24FEFA8", Offset = "0x24FEFA8", VA = "0x24FEFA8")]
	private static bool _003CRefreshViewInfo_003Em__4(FriendAccountInfo x)
	{
		return default(bool);
	}

	[Token(Token = "0x600E211")]
	[Address(RVA = "0x24FEFD4", Offset = "0x24FEFD4", VA = "0x24FEFD4")]
	private static bool _003CGotoAddFriendTab_003Em__5(StandardTabItemViewData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600E212")]
	[Address(RVA = "0x24FF058", Offset = "0x24FF058", VA = "0x24FF058")]
	private static bool _003COnDataChanged_003Em__6(StandardTabItemViewData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600E213")]
	[Address(RVA = "0x24FF0DC", Offset = "0x24FF0DC", VA = "0x24FF0DC")]
	private static bool _003COnDataChanged_003Em__7(StandardTabItemViewData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600E214")]
	[Address(RVA = "0x24FF160", Offset = "0x24FF160", VA = "0x24FF160")]
	private static bool _003COnDataChanged_003Em__8(StandardTabItemViewData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600E215")]
	[Address(RVA = "0x24FF1E4", Offset = "0x24FF1E4", VA = "0x24FF1E4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E216")]
	[Address(RVA = "0x24FF1EC", Offset = "0x24FF1EC", VA = "0x24FF1EC")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600E217")]
	[Address(RVA = "0x24FF1F4", Offset = "0x24FF1F4", VA = "0x24FF1F4")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600E218")]
	[Address(RVA = "0x24FF1FC", Offset = "0x24FF1FC", VA = "0x24FF1FC")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x600E219")]
	[Address(RVA = "0x24FF204", Offset = "0x24FF204", VA = "0x24FF204")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
