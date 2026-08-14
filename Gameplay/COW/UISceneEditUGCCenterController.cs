using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002359")]
public class UISceneEditUGCCenterController : UINavigationController, _Attribute
{
	[Token(Token = "0x200235A")]
	public enum ETabIndex
	{
		[Token(Token = "0x400DC47")]
		ETabIndex_Recommendation,
		[Token(Token = "0x400DC48")]
		ETabIndex_Subscription,
		[Token(Token = "0x400DC49")]
		ETabIndex_History,
		[Token(Token = "0x400DC4A")]
		ETabIndex_Room,
		[Token(Token = "0x400DC4B")]
		ETabIndex_MyWorks
	}

	[Token(Token = "0x200235B")]
	private sealed class _003CShowFreeRoomCardGuide_003Ec__AnonStorey0
	{
		[Token(Token = "0x400DC4C")]
		[FieldOffset(Offset = "0x8")]
		internal string guideKey;

		[Token(Token = "0x600C53B")]
		[Address(RVA = "0x2DB6C24", Offset = "0x2DB6C24", VA = "0x2DB6C24")]
		public _003CShowFreeRoomCardGuide_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600C53C")]
		[Address(RVA = "0x2DBA280", Offset = "0x2DBA280", VA = "0x2DBA280")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x200235C")]
	private sealed class _003COnNavigationShowed_003Ec__AnonStorey1
	{
		[Token(Token = "0x400DC4D")]
		[FieldOffset(Offset = "0x8")]
		internal string url;

		[Token(Token = "0x600C53D")]
		[Address(RVA = "0x2DB83A0", Offset = "0x2DB83A0", VA = "0x2DB83A0")]
		public _003COnNavigationShowed_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600C53E")]
		[Address(RVA = "0x2DBA1F8", Offset = "0x2DBA1F8", VA = "0x2DBA1F8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400DC39")]
	[FieldOffset(Offset = "0x68")]
	private UISceneEditUGCCenterView m_View;

	[Token(Token = "0x400DC3A")]
	[FieldOffset(Offset = "0x6C")]
	protected UIStandardTabController m_TabCtrl;

	[Token(Token = "0x400DC3B")]
	[FieldOffset(Offset = "0x70")]
	protected UIRoomCardListController m_RoomCardCtrl;

	[Token(Token = "0x400DC3C")]
	[FieldOffset(Offset = "0x74")]
	protected UIUGCRecommendationController m_RecommendationCtrl;

	[Token(Token = "0x400DC3D")]
	[FieldOffset(Offset = "0x78")]
	protected UISceneEditRoomListController m_RoomListCtrl;

	[Token(Token = "0x400DC3E")]
	[FieldOffset(Offset = "0x7C")]
	protected UISceneEditHistoryInfoController m_HistoryInfoCtrl;

	[Token(Token = "0x400DC3F")]
	[FieldOffset(Offset = "0x80")]
	protected UISceneEditSubscriptionInfoController m_SubscriptionInfoCtrl;

	[Token(Token = "0x400DC40")]
	[FieldOffset(Offset = "0x84")]
	protected UIUGCMyWorksController m_MyWorksCtrl;

	[Token(Token = "0x400DC41")]
	[FieldOffset(Offset = "0x88")]
	protected UIModelSceneEdit m_ModelSceneEdit;

	[Token(Token = "0x400DC42")]
	[FieldOffset(Offset = "0x8C")]
	protected ETabIndex m_SelectedTab;

	[Token(Token = "0x400DC43")]
	[FieldOffset(Offset = "0x90")]
	private bool m_RequestFinished;

	[Token(Token = "0x400DC44")]
	[FieldOffset(Offset = "0x94")]
	private uint m_HideVFXDelayCall;

	[Token(Token = "0x400DC45")]
	[FieldOffset(Offset = "0x98")]
	private UIModelOptionalDownload m_ModelDownload;

	[Token(Token = "0x600C515")]
	[Address(RVA = "0x2DB46FC", Offset = "0x2DB46FC", VA = "0x2DB46FC")]
	public UISceneEditUGCCenterController()
	{
	}

	[Token(Token = "0x600C516")]
	[Address(RVA = "0x2DB4780", Offset = "0x2DB4780", VA = "0x2DB4780")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C517")]
	[Address(RVA = "0x2DB4824", Offset = "0x2DB4824", VA = "0x2DB4824", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C518")]
	[Address(RVA = "0x2DB53BC", Offset = "0x2DB53BC", VA = "0x2DB53BC")]
	private void RefreshRoomCard()
	{
	}

	[Token(Token = "0x600C519")]
	[Address(RVA = "0x2DB5778", Offset = "0x2DB5778", VA = "0x2DB5778")]
	private void ShowFreeRoomCardGuide()
	{
	}

	[Token(Token = "0x600C51A")]
	[Address(RVA = "0x2DB5C24", Offset = "0x2DB5C24", VA = "0x2DB5C24")]
	private void ShowFreeRoomCardRefreshTips()
	{
	}

	[Token(Token = "0x600C51B")]
	[Address(RVA = "0x2DB6C2C", Offset = "0x2DB6C2C", VA = "0x2DB6C2C")]
	private void OnUpdatePersonServer(object[] data)
	{
	}

	[Token(Token = "0x600C51C")]
	[Address(RVA = "0x2DB6D40", Offset = "0x2DB6D40", VA = "0x2DB6D40")]
	private void CheckLevelRankReward()
	{
	}

	[Token(Token = "0x600C51D")]
	[Address(RVA = "0x2DB6EE4", Offset = "0x2DB6EE4", VA = "0x2DB6EE4")]
	private void OnCloseRankRewardLevelUpView(object[] data)
	{
	}

	[Token(Token = "0x600C51E")]
	[Address(RVA = "0x2DB7360", Offset = "0x2DB7360", VA = "0x2DB7360")]
	private void OnRankRewardLevelUp(object[] data)
	{
	}

	[Token(Token = "0x600C51F")]
	[Address(RVA = "0x2DB7598", Offset = "0x2DB7598", VA = "0x2DB7598")]
	private void OnUpdatePersonInfo(object[] data)
	{
	}

	[Token(Token = "0x600C520")]
	[Address(RVA = "0x2DB6C9C", Offset = "0x2DB6C9C", VA = "0x2DB6C9C")]
	private void CheckOpenCreatorFeedbackWnd()
	{
	}

	[Token(Token = "0x600C521")]
	[Address(RVA = "0x2DB7C04", Offset = "0x2DB7C04", VA = "0x2DB7C04")]
	private void OnHelpBtnClick(object[] param)
	{
	}

	[Token(Token = "0x600C522")]
	[Address(RVA = "0x2DB7E2C", Offset = "0x2DB7E2C", VA = "0x2DB7E2C", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600C523")]
	[Address(RVA = "0x2DB8438", Offset = "0x2DB8438", VA = "0x2DB8438")]
	private void OnBtnSceneEditClick()
	{
	}

	[Token(Token = "0x600C524")]
	[Address(RVA = "0x2DB8A24", Offset = "0x2DB8A24", VA = "0x2DB8A24")]
	private void OnProfileProgressClick()
	{
	}

	[Token(Token = "0x600C525")]
	[Address(RVA = "0x2DB8BA8", Offset = "0x2DB8BA8", VA = "0x2DB8BA8")]
	private void OnUnActiveSceneEditBtnClick()
	{
	}

	[Token(Token = "0x600C526")]
	[Address(RVA = "0x2DB6744", Offset = "0x2DB6744", VA = "0x2DB6744")]
	private void UpdateSceneEditInfo()
	{
	}

	[Token(Token = "0x600C527")]
	[Address(RVA = "0x2DB8D38", Offset = "0x2DB8D38", VA = "0x2DB8D38", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600C528")]
	[Address(RVA = "0x2DB6140", Offset = "0x2DB6140", VA = "0x2DB6140")]
	private void InitStandardTabs()
	{
	}

	[Token(Token = "0x600C529")]
	[Address(RVA = "0x2DB8DC0", Offset = "0x2DB8DC0", VA = "0x2DB8DC0")]
	private void ShowTab()
	{
	}

	[Token(Token = "0x600C52A")]
	[Address(RVA = "0x2DB83A8", Offset = "0x2DB83A8", VA = "0x2DB83A8")]
	private void ShowMyWorksTab()
	{
	}

	[Token(Token = "0x600C52B")]
	[Address(RVA = "0x2DB90B4", Offset = "0x2DB90B4", VA = "0x2DB90B4")]
	private void SetSceneEditBtnSelectedState()
	{
	}

	[Token(Token = "0x600C52C")]
	[Address(RVA = "0x2DB9194", Offset = "0x2DB9194", VA = "0x2DB9194")]
	private void OnHandleReturnToLobby()
	{
	}

	[Token(Token = "0x600C52D")]
	[Address(RVA = "0x2DB946C", Offset = "0x2DB946C", VA = "0x2DB946C")]
	private void ShowGetFreeRoomCardMsgBox(uint reward_creator_times, uint remain_reward_count)
	{
	}

	[Token(Token = "0x600C52E")]
	[Address(RVA = "0x2DB9B50", Offset = "0x2DB9B50", VA = "0x2DB9B50")]
	private void ShowAuthorFreeVFX()
	{
	}

	[Token(Token = "0x600C52F")]
	[Address(RVA = "0x2DB9DE8", Offset = "0x2DB9DE8", VA = "0x2DB9DE8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C530")]
	[Address(RVA = "0x2DB9F04", Offset = "0x2DB9F04", VA = "0x2DB9F04", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600C531")]
	[Address(RVA = "0x2DBA0C0", Offset = "0x2DBA0C0", VA = "0x2DBA0C0", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600C532")]
	[Address(RVA = "0x2DBA158", Offset = "0x2DBA158", VA = "0x2DBA158")]
	private void _003CInitStandardTabs_003Em__0()
	{
	}

	[Token(Token = "0x600C533")]
	[Address(RVA = "0x2DBA164", Offset = "0x2DBA164", VA = "0x2DBA164")]
	private void _003CInitStandardTabs_003Em__1()
	{
	}

	[Token(Token = "0x600C534")]
	[Address(RVA = "0x2DBA170", Offset = "0x2DBA170", VA = "0x2DBA170")]
	private void _003CInitStandardTabs_003Em__2()
	{
	}

	[Token(Token = "0x600C535")]
	[Address(RVA = "0x2DBA17C", Offset = "0x2DBA17C", VA = "0x2DBA17C")]
	private void _003CInitStandardTabs_003Em__3()
	{
	}

	[Token(Token = "0x600C536")]
	[Address(RVA = "0x2DBA188", Offset = "0x2DBA188", VA = "0x2DBA188")]
	private void _003CShowAuthorFreeVFX_003Em__4()
	{
	}

	[Token(Token = "0x600C537")]
	[Address(RVA = "0x2DBA1D8", Offset = "0x2DBA1D8", VA = "0x2DBA1D8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C538")]
	[Address(RVA = "0x2DBA1E0", Offset = "0x2DBA1E0", VA = "0x2DBA1E0")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600C539")]
	[Address(RVA = "0x2DBA1E8", Offset = "0x2DBA1E8", VA = "0x2DBA1E8")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600C53A")]
	[Address(RVA = "0x2DBA1F0", Offset = "0x2DBA1F0", VA = "0x2DBA1F0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
