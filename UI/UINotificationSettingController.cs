using System;
using System.Collections.Generic;
using COW;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x2002383")]
public class UINotificationSettingController : UISettingContentBase
{
	[Token(Token = "0x2002384")]
	private enum Block
	{
		[Token(Token = "0x400DD0F")]
		MessageBlock,
		[Token(Token = "0x400DD10")]
		QuickChatBlock,
		[Token(Token = "0x400DD11")]
		NotifyBlock
	}

	[Token(Token = "0x2002385")]
	private enum NotificationSettingKey
	{
		[Token(Token = "0x400DD13")]
		Stranger,
		[Token(Token = "0x400DD14")]
		Booking,
		[Token(Token = "0x400DD15")]
		AcceptInvite,
		[Token(Token = "0x400DD16")]
		FriendRecommend,
		[Token(Token = "0x400DD17")]
		NotificationFriendApply,
		[Token(Token = "0x400DD18")]
		ChatBubble,
		[Token(Token = "0x400DD19")]
		FreeGacha,
		[Token(Token = "0x400DD1A")]
		DiamondMembership,
		[Token(Token = "0x400DD1B")]
		CupInvite,
		[Token(Token = "0x400DD1C")]
		CupJoinTeam,
		[Token(Token = "0x400DD1D")]
		GameResultFriendRecommend,
		[Token(Token = "0x400DD1E")]
		GameResultInviteRecommend
	}

	[Token(Token = "0x400DCFF")]
	[FieldOffset(Offset = "0x2C")]
	private UINotificationsSettingView m_View;

	[Token(Token = "0x400DD00")]
	[FieldOffset(Offset = "0x30")]
	private List<UICommonSettingContentController> m_CtrlList;

	[Token(Token = "0x400DD01")]
	[FieldOffset(Offset = "0x34")]
	private List<CommonSettingContentData> m_DataList;

	[Token(Token = "0x400DD02")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400DD03")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400DD04")]
	[FieldOffset(Offset = "0x8")]
	private static Func<int> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400DD05")]
	[FieldOffset(Offset = "0xC")]
	private static Action _003C_003Ef__am_0024cache3;

	[Token(Token = "0x400DD06")]
	[FieldOffset(Offset = "0x10")]
	private static Action _003C_003Ef__am_0024cache4;

	[Token(Token = "0x400DD07")]
	[FieldOffset(Offset = "0x14")]
	private static Func<int> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x400DD08")]
	[FieldOffset(Offset = "0x18")]
	private static Action _003C_003Ef__am_0024cache6;

	[Token(Token = "0x400DD09")]
	[FieldOffset(Offset = "0x1C")]
	private static Action _003C_003Ef__am_0024cache7;

	[Token(Token = "0x400DD0A")]
	[FieldOffset(Offset = "0x20")]
	private static Func<int> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x400DD0B")]
	[FieldOffset(Offset = "0x24")]
	private static Action _003C_003Ef__am_0024cache9;

	[Token(Token = "0x400DD0C")]
	[FieldOffset(Offset = "0x28")]
	private static Action _003C_003Ef__am_0024cacheA;

	[Token(Token = "0x400DD0D")]
	[FieldOffset(Offset = "0x2C")]
	private static Func<int> _003C_003Ef__am_0024cacheB;

	[Token(Token = "0x600C6E0")]
	[Address(RVA = "0x222E76C", Offset = "0x222E76C", VA = "0x222E76C")]
	public UINotificationSettingController()
	{
	}

	[Token(Token = "0x600C6E1")]
	[Address(RVA = "0x222E8AC", Offset = "0x222E8AC", VA = "0x222E8AC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C6E2")]
	[Address(RVA = "0x222E914", Offset = "0x222E914", VA = "0x222E914", Slot = "33")]
	public override void RefreshContent(object[] param)
	{
	}

	[Token(Token = "0x600C6E3")]
	[Address(RVA = "0x222EB38", Offset = "0x222EB38", VA = "0x222EB38", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C6E4")]
	[Address(RVA = "0x222F328", Offset = "0x222F328", VA = "0x222F328")]
	private void Start()
	{
	}

	[Token(Token = "0x600C6E5")]
	[Address(RVA = "0x222F15C", Offset = "0x222F15C", VA = "0x222F15C")]
	private void ResetScrollViewWidth()
	{
	}

	[Token(Token = "0x600C6E6")]
	[Address(RVA = "0x222F36C", Offset = "0x222F36C", VA = "0x222F36C")]
	private CommonSettingItemDataToggleBtns CreateStrangerData()
	{
		return null;
	}

	[Token(Token = "0x600C6E7")]
	[Address(RVA = "0x222F5EC", Offset = "0x222F5EC", VA = "0x222F5EC")]
	private CommonSettingItemDataToggleBtns CreateBookingData()
	{
		return null;
	}

	[Token(Token = "0x600C6E8")]
	[Address(RVA = "0x222F86C", Offset = "0x222F86C", VA = "0x222F86C")]
	private CommonSettingItemDataToggleBtns CreateAcceptInviteData()
	{
		return null;
	}

	[Token(Token = "0x600C6E9")]
	[Address(RVA = "0x222FAEC", Offset = "0x222FAEC", VA = "0x222FAEC")]
	private CommonSettingItemDataToggleBtns CreateFriendRecommendData()
	{
		return null;
	}

	[Token(Token = "0x600C6EA")]
	[Address(RVA = "0x222FD6C", Offset = "0x222FD6C", VA = "0x222FD6C")]
	private CommonSettingItemDataToggleBtns CreateChatBubbletData()
	{
		return null;
	}

	[Token(Token = "0x600C6EB")]
	[Address(RVA = "0x2230038", Offset = "0x2230038", VA = "0x2230038")]
	private CommonSettingItemDataToggleBtns CreateNotifyFriendApplyData()
	{
		return null;
	}

	[Token(Token = "0x600C6EC")]
	[Address(RVA = "0x222EE90", Offset = "0x222EE90", VA = "0x222EE90")]
	private CommonSettingContentData CreateBlock1Data()
	{
		return null;
	}

	[Token(Token = "0x600C6ED")]
	[Address(RVA = "0x2230618", Offset = "0x2230618", VA = "0x2230618")]
	private CommonSettingItemDataToggleBtns CreateGameResultInviteRecommendData()
	{
		return null;
	}

	[Token(Token = "0x600C6EE")]
	[Address(RVA = "0x22302FC", Offset = "0x22302FC", VA = "0x22302FC")]
	private CommonSettingItemDataToggleBtns CreateGameResultFriendRecommendData()
	{
		return null;
	}

	[Token(Token = "0x600C6EF")]
	[Address(RVA = "0x2230938", Offset = "0x2230938", VA = "0x2230938")]
	private CommonSettingItemDataToggleBtns CreateRequestJoinCupTeamData()
	{
		return null;
	}

	[Token(Token = "0x600C6F0")]
	[Address(RVA = "0x2230C54", Offset = "0x2230C54", VA = "0x2230C54")]
	private CommonSettingItemDataToggleBtns CreateCupInviteData()
	{
		return null;
	}

	[Token(Token = "0x600C6F1")]
	[Address(RVA = "0x2230F70", Offset = "0x2230F70", VA = "0x2230F70")]
	private void OnStrangerOn()
	{
	}

	[Token(Token = "0x600C6F2")]
	[Address(RVA = "0x2230FF0", Offset = "0x2230FF0", VA = "0x2230FF0")]
	private void OnStrangerOff()
	{
	}

	[Token(Token = "0x600C6F3")]
	[Address(RVA = "0x2231070", Offset = "0x2231070", VA = "0x2231070")]
	private void OnBookingOn()
	{
	}

	[Token(Token = "0x600C6F4")]
	[Address(RVA = "0x22310F0", Offset = "0x22310F0", VA = "0x22310F0")]
	private void OnBookingOff()
	{
	}

	[Token(Token = "0x600C6F5")]
	[Address(RVA = "0x2231170", Offset = "0x2231170", VA = "0x2231170")]
	private void OnAcceptInviteOn()
	{
	}

	[Token(Token = "0x600C6F6")]
	[Address(RVA = "0x22311F0", Offset = "0x22311F0", VA = "0x22311F0")]
	private void OnAcceptInviteOff()
	{
	}

	[Token(Token = "0x600C6F7")]
	[Address(RVA = "0x2231270", Offset = "0x2231270", VA = "0x2231270")]
	private void OnFriendRecommendOn()
	{
	}

	[Token(Token = "0x600C6F8")]
	[Address(RVA = "0x22312F0", Offset = "0x22312F0", VA = "0x22312F0")]
	private void OnFriendRecommendOff()
	{
	}

	[Token(Token = "0x600C6F9")]
	[Address(RVA = "0x2231370", Offset = "0x2231370", VA = "0x2231370")]
	private void OnChatBubbleOn()
	{
	}

	[Token(Token = "0x600C6FA")]
	[Address(RVA = "0x22313F0", Offset = "0x22313F0", VA = "0x22313F0")]
	private void OnChatBubbleOff()
	{
	}

	[Token(Token = "0x600C6FB")]
	[Address(RVA = "0x2231470", Offset = "0x2231470", VA = "0x2231470")]
	private void OnNotifyFriendApplyOn()
	{
	}

	[Token(Token = "0x600C6FC")]
	[Address(RVA = "0x22314F0", Offset = "0x22314F0", VA = "0x22314F0")]
	private void OnNotifyFriendApplyOff()
	{
	}

	[Token(Token = "0x600C6FD")]
	[Address(RVA = "0x2231570", Offset = "0x2231570", VA = "0x2231570")]
	private int GetStrangerSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C6FE")]
	[Address(RVA = "0x22315F0", Offset = "0x22315F0", VA = "0x22315F0")]
	private int GetBookingSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C6FF")]
	[Address(RVA = "0x2231670", Offset = "0x2231670", VA = "0x2231670")]
	private int GetAcceptInviteSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C700")]
	[Address(RVA = "0x22316F0", Offset = "0x22316F0", VA = "0x22316F0")]
	private int GetFriendRecommendSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C701")]
	[Address(RVA = "0x2231770", Offset = "0x2231770", VA = "0x2231770")]
	private int GetNotifyFriendApplySelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C702")]
	[Address(RVA = "0x22317F0", Offset = "0x22317F0", VA = "0x22317F0")]
	private int GetChatBubbleSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C703")]
	[Address(RVA = "0x2231870", Offset = "0x2231870", VA = "0x2231870")]
	private void OnNotifyFriendApplyTipClick()
	{
	}

	[Token(Token = "0x600C704")]
	[Address(RVA = "0x2231A80", Offset = "0x2231A80", VA = "0x2231A80")]
	private CommonSettingItemDataToggleBtns CreateDiamondMembershipData()
	{
		return null;
	}

	[Token(Token = "0x600C705")]
	[Address(RVA = "0x2231D00", Offset = "0x2231D00", VA = "0x2231D00")]
	private CommonSettingContentData CreateBlock3Data()
	{
		return null;
	}

	[Token(Token = "0x600C706")]
	[Address(RVA = "0x2231E48", Offset = "0x2231E48", VA = "0x2231E48")]
	private void OnDiamondMembershipOn()
	{
	}

	[Token(Token = "0x600C707")]
	[Address(RVA = "0x2231F20", Offset = "0x2231F20", VA = "0x2231F20")]
	private void OnDiamondMembershipOff()
	{
	}

	[Token(Token = "0x600C708")]
	[Address(RVA = "0x2231FF8", Offset = "0x2231FF8", VA = "0x2231FF8")]
	private int GetDiamondMembershipSelectBtn()
	{
		return default(int);
	}

	[Token(Token = "0x600C709")]
	[Address(RVA = "0x222E9A4", Offset = "0x222E9A4", VA = "0x222E9A4")]
	private void RefreshBtnsState(object[] param)
	{
	}

	[Token(Token = "0x600C70A")]
	[Address(RVA = "0x22320D0", Offset = "0x22320D0", VA = "0x22320D0")]
	private static void _003CCreateGameResultInviteRecommendData_003Em__0()
	{
	}

	[Token(Token = "0x600C70B")]
	[Address(RVA = "0x2232150", Offset = "0x2232150", VA = "0x2232150")]
	private static void _003CCreateGameResultInviteRecommendData_003Em__1()
	{
	}

	[Token(Token = "0x600C70C")]
	[Address(RVA = "0x22321D0", Offset = "0x22321D0", VA = "0x22321D0")]
	private static int _003CCreateGameResultInviteRecommendData_003Em__2()
	{
		return default(int);
	}

	[Token(Token = "0x600C70D")]
	[Address(RVA = "0x2232250", Offset = "0x2232250", VA = "0x2232250")]
	private static void _003CCreateGameResultFriendRecommendData_003Em__3()
	{
	}

	[Token(Token = "0x600C70E")]
	[Address(RVA = "0x22322D0", Offset = "0x22322D0", VA = "0x22322D0")]
	private static void _003CCreateGameResultFriendRecommendData_003Em__4()
	{
	}

	[Token(Token = "0x600C70F")]
	[Address(RVA = "0x2232350", Offset = "0x2232350", VA = "0x2232350")]
	private static int _003CCreateGameResultFriendRecommendData_003Em__5()
	{
		return default(int);
	}

	[Token(Token = "0x600C710")]
	[Address(RVA = "0x22323D0", Offset = "0x22323D0", VA = "0x22323D0")]
	private static void _003CCreateRequestJoinCupTeamData_003Em__6()
	{
	}

	[Token(Token = "0x600C711")]
	[Address(RVA = "0x2232450", Offset = "0x2232450", VA = "0x2232450")]
	private static void _003CCreateRequestJoinCupTeamData_003Em__7()
	{
	}

	[Token(Token = "0x600C712")]
	[Address(RVA = "0x22324D0", Offset = "0x22324D0", VA = "0x22324D0")]
	private static int _003CCreateRequestJoinCupTeamData_003Em__8()
	{
		return default(int);
	}

	[Token(Token = "0x600C713")]
	[Address(RVA = "0x2232550", Offset = "0x2232550", VA = "0x2232550")]
	private static void _003CCreateCupInviteData_003Em__9()
	{
	}

	[Token(Token = "0x600C714")]
	[Address(RVA = "0x22325D0", Offset = "0x22325D0", VA = "0x22325D0")]
	private static void _003CCreateCupInviteData_003Em__A()
	{
	}

	[Token(Token = "0x600C715")]
	[Address(RVA = "0x2232650", Offset = "0x2232650", VA = "0x2232650")]
	private static int _003CCreateCupInviteData_003Em__B()
	{
		return default(int);
	}
}
