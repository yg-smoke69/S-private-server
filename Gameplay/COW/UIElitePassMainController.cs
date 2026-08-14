using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20025EE")]
public class UIElitePassMainController : UICGPlayableNavigationController, _Attribute, IConvertible
{
	[Token(Token = "0x20025EF")]
	private sealed class _003CRefreshAnimStatus_003Ec__AnonStorey0
	{
		[Token(Token = "0x400EA88")]
		[FieldOffset(Offset = "0x8")]
		internal ResourceID res_id;

		[Token(Token = "0x400EA89")]
		[FieldOffset(Offset = "0xC")]
		internal UIElitePassMainController _0024this;

		[Token(Token = "0x600DFF6")]
		[Address(RVA = "0x3050264", Offset = "0x3050264", VA = "0x3050264")]
		public _003CRefreshAnimStatus_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600DFF7")]
		[Address(RVA = "0x30593C0", Offset = "0x30593C0", VA = "0x30593C0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x20025F0")]
	private sealed class _003CShowRewardItemAnim_003Ec__AnonStorey1
	{
		[Token(Token = "0x400EA8A")]
		[FieldOffset(Offset = "0x8")]
		internal UIElitePassRewardItemController item;

		[Token(Token = "0x600DFF8")]
		[Address(RVA = "0x3055F8C", Offset = "0x3055F8C", VA = "0x3055F8C")]
		public _003CShowRewardItemAnim_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600DFF9")]
		[Address(RVA = "0x30597C0", Offset = "0x30597C0", VA = "0x30597C0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400EA6C")]
	[FieldOffset(Offset = "0x80")]
	private UIElitePassMainWindowView m_View;

	[Token(Token = "0x400EA6D")]
	[FieldOffset(Offset = "0x84")]
	private UIModelElitePass m_ModelEP;

	[Token(Token = "0x400EA6E")]
	[FieldOffset(Offset = "0x88")]
	private UIModelProfile m_ModelProfile;

	[Token(Token = "0x400EA6F")]
	[FieldOffset(Offset = "0x8C")]
	private UIModelOptionalDownload m_ModleOptional;

	[Token(Token = "0x400EA70")]
	[FieldOffset(Offset = "0x90")]
	private bool isDataReady;

	[Token(Token = "0x400EA71")]
	[FieldOffset(Offset = "0x91")]
	private bool isDataChanged;

	[Token(Token = "0x400EA72")]
	[FieldOffset(Offset = "0x94")]
	private string EPWebSiteUrl;

	[Token(Token = "0x400EA73")]
	[FieldOffset(Offset = "0x98")]
	private uint m_TmpPurchaseBadgeCnt;

	[Token(Token = "0x400EA74")]
	[FieldOffset(Offset = "0x9C")]
	private UINewDownloadInfoController m_DownloadCtrl;

	[Token(Token = "0x400EA75")]
	[FieldOffset(Offset = "0xA0")]
	private FullscreenCgDesc m_CurEPFullScreenCG;

	[Token(Token = "0x400EA76")]
	[FieldOffset(Offset = "0xA4")]
	private bool m_FullScreenCGReady;

	[Token(Token = "0x400EA77")]
	[FieldOffset(Offset = "0xA8")]
	private List<UIButton> m_BigAwardMarkCacheList;

	[Token(Token = "0x400EA78")]
	[FieldOffset(Offset = "0xAC")]
	private List<UIButton> m_CurrentBigAwardButtonList;

	[Token(Token = "0x400EA79")]
	[FieldOffset(Offset = "0xB0")]
	private ShowBoostAvatarParams m_ShowBoostAvatarParams;

	[Token(Token = "0x400EA7A")]
	[FieldOffset(Offset = "0xB4")]
	private UIGuideTipsController m_GuideTipsCtrl;

	[Token(Token = "0x400EA7B")]
	[FieldOffset(Offset = "0xB8")]
	private UICountDownController m_CDControler;

	[Token(Token = "0x400EA7C")]
	[FieldOffset(Offset = "0xBC")]
	private float m_CGPlayTime;

	[Token(Token = "0x400EA7D")]
	[FieldOffset(Offset = "0xC0")]
	private bool m_ShowingAnimationFlag;

	[Token(Token = "0x400EA7E")]
	[FieldOffset(Offset = "0xC1")]
	private bool m_IsActive;

	[Token(Token = "0x400EA7F")]
	[FieldOffset(Offset = "0xC4")]
	private int m_CurMaxRewardIndex;

	[Token(Token = "0x400EA80")]
	private const string HAS_SEEN_SUBSCRIPTION_PREF_KEY = "HasSeenElitePassSubscription";

	[Token(Token = "0x400EA81")]
	[FieldOffset(Offset = "0xC8")]
	private List<uint> m_AnimDelayCalls;

	[Token(Token = "0x400EA82")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<UIElitePassRewardItemController> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400EA83")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<AdvertDesc> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400EA84")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<AdvertDesc> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400EA85")]
	[FieldOffset(Offset = "0xC")]
	private static Predicate<AdvertDesc> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x400EA86")]
	[FieldOffset(Offset = "0x10")]
	private static Predicate<AdvertDesc> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x400EA87")]
	[FieldOffset(Offset = "0x14")]
	private static Action _003C_003Ef__am_0024cache5;

	[Token(Token = "0x600DF9E")]
	[Address(RVA = "0x304BF90", Offset = "0x304BF90", VA = "0x304BF90")]
	public UIElitePassMainController()
	{
	}

	[Token(Token = "0x600DF9F")]
	[Address(RVA = "0x304C0C0", Offset = "0x304C0C0", VA = "0x304C0C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DFA0")]
	[Address(RVA = "0x304C168", Offset = "0x304C168", VA = "0x304C168", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x600DFA1")]
	[Address(RVA = "0x304C1D8", Offset = "0x304C1D8", VA = "0x304C1D8", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600DFA2")]
	[Address(RVA = "0x304C230", Offset = "0x304C230", VA = "0x304C230", Slot = "64")]
	protected override UINavigationUtil.UINavigationPageType GetUINavigationPageType()
	{
		return default(UINavigationUtil.UINavigationPageType);
	}

	[Token(Token = "0x600DFA3")]
	[Address(RVA = "0x304C288", Offset = "0x304C288", VA = "0x304C288", Slot = "45")]
	protected override bool NeedRecoverPreviewOnNavigationShowed()
	{
		return default(bool);
	}

	[Token(Token = "0x600DFA4")]
	[Address(RVA = "0x304C2E0", Offset = "0x304C2E0", VA = "0x304C2E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DFA5")]
	[Address(RVA = "0x304E418", Offset = "0x304E418", VA = "0x304E418", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600DFA6")]
	[Address(RVA = "0x304CB50", Offset = "0x304CB50", VA = "0x304CB50")]
	private void RegisterEvent()
	{
	}

	[Token(Token = "0x600DFA7")]
	[Address(RVA = "0x304E484", Offset = "0x304E484", VA = "0x304E484")]
	private void UnRegisterEvent()
	{
	}

	[Token(Token = "0x600DFA8")]
	[Address(RVA = "0x304EAF8", Offset = "0x304EAF8", VA = "0x304EAF8")]
	private void Update()
	{
	}

	[Token(Token = "0x600DFA9")]
	[Address(RVA = "0x304EB80", Offset = "0x304EB80", VA = "0x304EB80", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600DFAA")]
	[Address(RVA = "0x304DE04", Offset = "0x304DE04", VA = "0x304DE04")]
	public void UpdateFullScreenCG()
	{
	}

	[Token(Token = "0x600DFAB")]
	[Address(RVA = "0x304FD04", Offset = "0x304FD04", VA = "0x304FD04")]
	private void RefreshAnimStatus(bool refresh_btn_visible = true)
	{
	}

	[Token(Token = "0x600DFAC")]
	[Address(RVA = "0x305026C", Offset = "0x305026C", VA = "0x305026C")]
	private void OnClickClaimAllBtn()
	{
	}

	[Token(Token = "0x600DFAD")]
	[Address(RVA = "0x30502E4", Offset = "0x30502E4", VA = "0x30502E4")]
	private void SetClaimAllBtn()
	{
	}

	[Token(Token = "0x600DFAE")]
	[Address(RVA = "0x30503B8", Offset = "0x30503B8", VA = "0x30503B8")]
	private void StopNewbieGuide(object[] args)
	{
	}

	[Token(Token = "0x600DFAF")]
	[Address(RVA = "0x30504C4", Offset = "0x30504C4", VA = "0x30504C4", Slot = "37")]
	protected override bool NeedWaitDataReady()
	{
		return default(bool);
	}

	[Token(Token = "0x600DFB0")]
	[Address(RVA = "0x305051C", Offset = "0x305051C", VA = "0x305051C")]
	private void CheckEliteAward(uint id)
	{
	}

	[Token(Token = "0x600DFB1")]
	[Address(RVA = "0x305087C", Offset = "0x305087C", VA = "0x305087C")]
	private void OnClickGetBadgeByChallengeButton()
	{
	}

	[Token(Token = "0x600DFB2")]
	[Address(RVA = "0x30509A4", Offset = "0x30509A4", VA = "0x30509A4")]
	private void OnClickGetBadgeByPurchaseButton()
	{
	}

	[Token(Token = "0x600DFB3")]
	[Address(RVA = "0x3050E6C", Offset = "0x3050E6C", VA = "0x3050E6C")]
	private void OnClickBadgeRankingButton()
	{
	}

	[Token(Token = "0x600DFB4")]
	[Address(RVA = "0x3050FCC", Offset = "0x3050FCC", VA = "0x3050FCC")]
	private void OnClickUpgradeEPButton()
	{
	}

	[Token(Token = "0x600DFB5")]
	[Address(RVA = "0x3051460", Offset = "0x3051460", VA = "0x3051460")]
	private void OnEPQuestBtn()
	{
	}

	[Token(Token = "0x600DFB6")]
	[Address(RVA = "0x30515F8", Offset = "0x30515F8", VA = "0x30515F8")]
	private void OnSubscribedInfoButton()
	{
	}

	[Token(Token = "0x600DFB7")]
	[Address(RVA = "0x3051708", Offset = "0x3051708", VA = "0x3051708")]
	private void OnDocumentButton()
	{
	}

	[Token(Token = "0x600DFB8")]
	[Address(RVA = "0x305193C", Offset = "0x305193C", VA = "0x305193C")]
	private void OnGetRewardItem(object[] param)
	{
	}

	[Token(Token = "0x600DFB9")]
	[Address(RVA = "0x3051A8C", Offset = "0x3051A8C", VA = "0x3051A8C")]
	private void OnEPDataReady(object[] param)
	{
	}

	[Token(Token = "0x600DFBA")]
	[Address(RVA = "0x30522C8", Offset = "0x30522C8", VA = "0x30522C8")]
	private void UpdateBigRewardMark()
	{
	}

	[Token(Token = "0x600DFBB")]
	[Address(RVA = "0x30547D4", Offset = "0x30547D4", VA = "0x30547D4")]
	private void CreateMarkBtn(Vector3 pos)
	{
	}

	[Token(Token = "0x600DFBC")]
	[Address(RVA = "0x3054B14", Offset = "0x3054B14", VA = "0x3054B14")]
	private void UpdateCurrentProgressMark()
	{
	}

	[Token(Token = "0x600DFBD")]
	[Address(RVA = "0x3054068", Offset = "0x3054068", VA = "0x3054068")]
	private Vector3 MarkPosInPanelCenterForItemIndex(int index, int maxCount, float yPos)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600DFBE")]
	[Address(RVA = "0x3053F14", Offset = "0x3053F14", VA = "0x3053F14")]
	private int maxScrollViewGridCount()
	{
		return default(int);
	}

	[Token(Token = "0x600DFBF")]
	[Address(RVA = "0x3052698", Offset = "0x3052698", VA = "0x3052698")]
	private void RefreshBtnState()
	{
	}

	[Token(Token = "0x600DFC0")]
	[Address(RVA = "0x304FB4C", Offset = "0x304FB4C", VA = "0x304FB4C")]
	private void ShowDiscountPopWndIfNeed()
	{
	}

	[Token(Token = "0x600DFC1")]
	[Address(RVA = "0x304E050", Offset = "0x304E050", VA = "0x304E050")]
	private void InitBtnState()
	{
	}

	[Token(Token = "0x600DFC2")]
	[Address(RVA = "0x3054E44", Offset = "0x3054E44", VA = "0x3054E44")]
	private void OnClickBigAwardMark()
	{
	}

	[Token(Token = "0x600DFC3")]
	[Address(RVA = "0x3052DB4", Offset = "0x3052DB4", VA = "0x3052DB4")]
	private void SetBadgeCount()
	{
	}

	[Token(Token = "0x600DFC4")]
	[Address(RVA = "0x3052FE8", Offset = "0x3052FE8", VA = "0x3052FE8")]
	private void SetPreorderBtn()
	{
	}

	[Token(Token = "0x600DFC5")]
	[Address(RVA = "0x3055410", Offset = "0x3055410", VA = "0x3055410")]
	private void UpdateSubscriptionBonus()
	{
	}

	[Token(Token = "0x600DFC6")]
	[Address(RVA = "0x3055624", Offset = "0x3055624", VA = "0x3055624", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600DFC7")]
	[Address(RVA = "0x3055A10", Offset = "0x3055A10", VA = "0x3055A10")]
	private void ShowRewardItemAnim()
	{
	}

	[Token(Token = "0x600DFC8")]
	[Address(RVA = "0x3055828", Offset = "0x3055828", VA = "0x3055828")]
	private void ClearDelayCalls()
	{
	}

	[Token(Token = "0x600DFC9")]
	[Address(RVA = "0x3055F94", Offset = "0x3055F94", VA = "0x3055F94")]
	private void OnEPUpdateReward(object[] param)
	{
	}

	[Token(Token = "0x600DFCA")]
	[Address(RVA = "0x3056000", Offset = "0x3056000", VA = "0x3056000")]
	private void OnEPBadgeChange(object[] param)
	{
	}

	[Token(Token = "0x600DFCB")]
	[Address(RVA = "0x304F4C8", Offset = "0x304F4C8", VA = "0x304F4C8")]
	private void RefreshEasyList(bool needScroll)
	{
	}

	[Token(Token = "0x600DFCC")]
	[Address(RVA = "0x3054C70", Offset = "0x3054C70", VA = "0x3054C70")]
	private int CurProgressIndex()
	{
		return default(int);
	}

	[Token(Token = "0x600DFCD")]
	[Address(RVA = "0x304EE1C", Offset = "0x304EE1C", VA = "0x304EE1C")]
	public void SetCDNTexture(object[] data)
	{
	}

	[Token(Token = "0x600DFCE")]
	[Address(RVA = "0x3053C48", Offset = "0x3053C48", VA = "0x3053C48")]
	public void ShowFullScreenCG()
	{
	}

	[Token(Token = "0x600DFCF")]
	[Address(RVA = "0x30564D4", Offset = "0x30564D4", VA = "0x30564D4")]
	private void ShowDownloadPopUp()
	{
	}

	[Token(Token = "0x600DFD0")]
	[Address(RVA = "0x3056078", Offset = "0x3056078", VA = "0x3056078")]
	private void OnPreviewItem(object[] param)
	{
	}

	[Token(Token = "0x600DFD1")]
	[Address(RVA = "0x3056F34", Offset = "0x3056F34", VA = "0x3056F34")]
	private void OnReviewMaxReward(object[] param)
	{
	}

	[Token(Token = "0x600DFD2")]
	[Address(RVA = "0x3056890", Offset = "0x3056890", VA = "0x3056890")]
	private void UpdateEPTipsStatus(int badgeCnt, bool isEP)
	{
	}

	[Token(Token = "0x600DFD3")]
	[Address(RVA = "0x3057320", Offset = "0x3057320", VA = "0x3057320")]
	private void OnClickPrivilegeBtn()
	{
	}

	[Token(Token = "0x600DFD4")]
	[Address(RVA = "0x3057430", Offset = "0x3057430", VA = "0x3057430")]
	private void OnClickPreorderBtn()
	{
	}

	[Token(Token = "0x600DFD5")]
	[Address(RVA = "0x3057558", Offset = "0x3057558", VA = "0x3057558")]
	private void OnClickAnimPlayBtn()
	{
	}

	[Token(Token = "0x600DFD6")]
	[Address(RVA = "0x30576BC", Offset = "0x30576BC", VA = "0x30576BC")]
	private void onClickVideoBtn()
	{
	}

	[Token(Token = "0x600DFD7")]
	[Address(RVA = "0x30579DC", Offset = "0x30579DC", VA = "0x30579DC", Slot = "66")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600DFD8")]
	[Address(RVA = "0x3057AD4", Offset = "0x3057AD4", VA = "0x3057AD4", Slot = "67")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600DFD9")]
	[Address(RVA = "0x3057B50", Offset = "0x3057B50", VA = "0x3057B50", Slot = "68")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600DFDA")]
	[Address(RVA = "0x3057FB8", Offset = "0x3057FB8", VA = "0x3057FB8", Slot = "69")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600DFDB")]
	[Address(RVA = "0x3058094", Offset = "0x3058094", VA = "0x3058094")]
	private void OnClickSubscribeEPBtn()
	{
	}

	[Token(Token = "0x600DFDC")]
	[Address(RVA = "0x30582BC", Offset = "0x30582BC", VA = "0x30582BC")]
	private void OnClickSubscribeHintBtn()
	{
	}

	[Token(Token = "0x600DFDD")]
	[Address(RVA = "0x305839C", Offset = "0x305839C", VA = "0x305839C")]
	private void OnClickBadgeIcon()
	{
	}

	[Token(Token = "0x600DFDE")]
	[Address(RVA = "0x30583F0", Offset = "0x30583F0", VA = "0x30583F0")]
	private void OnPreorderSuccess(object[] data)
	{
	}

	[Token(Token = "0x600DFDF")]
	[Address(RVA = "0x3058458", Offset = "0x3058458", VA = "0x3058458")]
	private void OnMaxRewardClaimed(object[] data)
	{
	}

	[Token(Token = "0x600DFE0")]
	[Address(RVA = "0x30584C4", Offset = "0x30584C4", VA = "0x30584C4")]
	private void GoToEPWebSite()
	{
	}

	[Token(Token = "0x600DFE1")]
	[Address(RVA = "0x30585E0", Offset = "0x30585E0", VA = "0x30585E0")]
	private void OnMapModeSelected(object[] param)
	{
	}

	[Token(Token = "0x600DFE2")]
	[Address(RVA = "0x30551E0", Offset = "0x30551E0", VA = "0x30551E0")]
	private void AutoShowEPPreorderNavi()
	{
	}

	[Token(Token = "0x600DFE3")]
	[Address(RVA = "0x30586DC", Offset = "0x30586DC", VA = "0x30586DC")]
	private void OnCgClose(object[] param)
	{
	}

	[Token(Token = "0x600DFE4")]
	[Address(RVA = "0x3058908", Offset = "0x3058908", VA = "0x3058908")]
	private void OnRefreshCustomizedDiscountLabel(object[] param)
	{
	}

	[Token(Token = "0x600DFE5")]
	[Address(RVA = "0x3058A6C", Offset = "0x3058A6C", VA = "0x3058A6C")]
	private void OnPreviewStoryCGOver(object[] param)
	{
	}

	[Token(Token = "0x600DFE6")]
	[Address(RVA = "0x3058CA0", Offset = "0x3058CA0", VA = "0x3058CA0")]
	private bool NeedAutoShowPreorderNavi()
	{
		return default(bool);
	}

	[Token(Token = "0x600DFE7")]
	[Address(RVA = "0x3058B64", Offset = "0x3058B64", VA = "0x3058B64")]
	public void LogEventTypeFullScreenAnimation(float animTime)
	{
	}

	[Token(Token = "0x600DFE8")]
	[Address(RVA = "0x3058F38", Offset = "0x3058F38", VA = "0x3058F38")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600DFE9")]
	[Address(RVA = "0x30590DC", Offset = "0x30590DC", VA = "0x30590DC")]
	private void _003COnVisibilityChanged_003Em__1()
	{
	}

	[Token(Token = "0x600DFEA")]
	[Address(RVA = "0x305918C", Offset = "0x305918C", VA = "0x305918C")]
	private static int _003CShowRewardItemAnim_003Em__2(UIElitePassRewardItemController x, UIElitePassRewardItemController y)
	{
		return default(int);
	}

	[Token(Token = "0x600DFEB")]
	[Address(RVA = "0x30591FC", Offset = "0x30591FC", VA = "0x30591FC")]
	private static bool _003CSetCDNTexture_003Em__3(AdvertDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x600DFEC")]
	[Address(RVA = "0x3059228", Offset = "0x3059228", VA = "0x3059228")]
	private static bool _003CSetCDNTexture_003Em__4(AdvertDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x600DFED")]
	[Address(RVA = "0x3059258", Offset = "0x3059258", VA = "0x3059258")]
	private static bool _003CSetCDNTexture_003Em__5(AdvertDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x600DFEE")]
	[Address(RVA = "0x3059288", Offset = "0x3059288", VA = "0x3059288")]
	private static bool _003CSetCDNTexture_003Em__6(AdvertDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x600DFEF")]
	[Address(RVA = "0x30592B8", Offset = "0x30592B8", VA = "0x30592B8")]
	private static void _003CAutoShowEPPreorderNavi_003Em__7()
	{
	}

	[Token(Token = "0x600DFF0")]
	[Address(RVA = "0x3059390", Offset = "0x3059390", VA = "0x3059390")]
	public bool _003C_003EiFixBaseProxy_NeedRecoverPreviewOnNavigationShowed()
	{
		return default(bool);
	}

	[Token(Token = "0x600DFF1")]
	[Address(RVA = "0x3059398", Offset = "0x3059398", VA = "0x3059398")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DFF2")]
	[Address(RVA = "0x30593A0", Offset = "0x30593A0", VA = "0x30593A0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600DFF3")]
	[Address(RVA = "0x30593A8", Offset = "0x30593A8", VA = "0x30593A8")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600DFF4")]
	[Address(RVA = "0x30593B0", Offset = "0x30593B0", VA = "0x30593B0")]
	public bool _003C_003EiFixBaseProxy_NeedWaitDataReady()
	{
		return default(bool);
	}

	[Token(Token = "0x600DFF5")]
	[Address(RVA = "0x30593B8", Offset = "0x30593B8", VA = "0x30593B8")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
