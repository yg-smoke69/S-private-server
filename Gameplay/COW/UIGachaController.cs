using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002634")]
public class UIGachaController : UIPreviewNavigationController, _Attribute
{
	[Token(Token = "0x2002635")]
	private sealed class _003CRefreshGachaScene_003Ec__AnonStorey0
	{
		[Token(Token = "0x400EBF9")]
		[FieldOffset(Offset = "0x8")]
		internal bool needShowAnim;

		[Token(Token = "0x400EBFA")]
		[FieldOffset(Offset = "0xC")]
		internal UIGachaController _0024this;

		[Token(Token = "0x600E37B")]
		[Address(RVA = "0x246E30C", Offset = "0x246E30C", VA = "0x246E30C")]
		public _003CRefreshGachaScene_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600E37C")]
		[Address(RVA = "0x246E314", Offset = "0x246E314", VA = "0x246E314")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400EBE0")]
	public const string SHOW_ANIM_KEY = "ShowAnim_Gacha_";

	[Token(Token = "0x400EBE1")]
	public const int MAXTABNUMINGRID = 6;

	[Token(Token = "0x400EBE2")]
	[FieldOffset(Offset = "0x7C")]
	private UIGachaView m_View;

	[Token(Token = "0x400EBE3")]
	[FieldOffset(Offset = "0x80")]
	private UIModelGacha m_ModelGacha;

	[Token(Token = "0x400EBE4")]
	[FieldOffset(Offset = "0x84")]
	private int m_SelectedTabIdx;

	[Token(Token = "0x400EBE5")]
	[FieldOffset(Offset = "0x88")]
	private int m_LastSelectedTabIdx;

	[Token(Token = "0x400EBE6")]
	[FieldOffset(Offset = "0x8C")]
	private List<UIGachaTabItemController> m_TabCtrlList;

	[Token(Token = "0x400EBE7")]
	[FieldOffset(Offset = "0x90")]
	private Dictionary<int, bool> m_FirstEnterFlagList;

	[Token(Token = "0x400EBE8")]
	[FieldOffset(Offset = "0x94")]
	private UIGachaNormalContent m_NormalContentCtrl;

	[Token(Token = "0x400EBE9")]
	[FieldOffset(Offset = "0x98")]
	private UIGachaTurntableContent m_TurntabelContentCtrl;

	[Token(Token = "0x400EBEA")]
	[FieldOffset(Offset = "0x9C")]
	private UIGachaLimitContent m_LimitContentCtrl;

	[Token(Token = "0x400EBEB")]
	[FieldOffset(Offset = "0xA0")]
	private UIGachaTokenContent m_TokenContentCtrl;

	[Token(Token = "0x400EBEC")]
	[FieldOffset(Offset = "0xA4")]
	private UIGachaLimitChestContentController m_limitChestContentCtrl;

	[Token(Token = "0x400EBED")]
	[FieldOffset(Offset = "0xA8")]
	private UIGachalegendaryNewContentController m_legendaryContentCtrl;

	[Token(Token = "0x400EBEE")]
	[FieldOffset(Offset = "0xAC")]
	private UIGachalegendaryRampage4CContentController m_legendaryRampage4CContentCtrl;

	[Token(Token = "0x400EBEF")]
	[FieldOffset(Offset = "0xB0")]
	private UIGachaContentBase m_CurContent;

	[Token(Token = "0x400EBF0")]
	[FieldOffset(Offset = "0xB4")]
	private uint m_RewardPoolJumpItmID;

	[Token(Token = "0x400EBF1")]
	[FieldOffset(Offset = "0xB8")]
	private uint m_RewardPoolSelectedItmID;

	[Token(Token = "0x400EBF2")]
	[FieldOffset(Offset = "0xBC")]
	private UIGachaPreviewController m_RewardPoolCtrl;

	[Token(Token = "0x400EBF3")]
	[FieldOffset(Offset = "0xC0")]
	public UIGachaPreviewManager GachaPreviewManager;

	[Token(Token = "0x400EBF4")]
	[FieldOffset(Offset = "0xC4")]
	private List<UIGachaCouponTipsController> m_CouponItemList;

	[Token(Token = "0x400EBF5")]
	[FieldOffset(Offset = "0xC8")]
	private int m_CurrentOwnedCouponTypeCnt;

	[Token(Token = "0x400EBF6")]
	[FieldOffset(Offset = "0xCC")]
	private float m_CGPlayTime;

	[Token(Token = "0x400EBF7")]
	[FieldOffset(Offset = "0xD0")]
	private bool m_IsActive;

	[Token(Token = "0x400EBF8")]
	[FieldOffset(Offset = "0xD4")]
	private FrontendPreviewType m_FrontendPreviewType;

	[Token(Token = "0x600E323")]
	[Address(RVA = "0x26725D4", Offset = "0x26725D4", VA = "0x26725D4")]
	public UIGachaController()
	{
	}

	[Token(Token = "0x600E324")]
	[Address(RVA = "0x26726DC", Offset = "0x26726DC", VA = "0x26726DC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E325")]
	[Address(RVA = "0x2672780", Offset = "0x2672780", VA = "0x2672780", Slot = "37")]
	protected override bool NeedWaitDataReady()
	{
		return default(bool);
	}

	[Token(Token = "0x600E326")]
	[Address(RVA = "0x26727D8", Offset = "0x26727D8", VA = "0x26727D8")]
	public void Update()
	{
	}

	[Token(Token = "0x600E327")]
	[Address(RVA = "0x267287C", Offset = "0x267287C", VA = "0x267287C", Slot = "65")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E328")]
	[Address(RVA = "0x267297C", Offset = "0x267297C", VA = "0x267297C", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x600E329")]
	[Address(RVA = "0x2672D38", Offset = "0x2672D38", VA = "0x2672D38", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600E32A")]
	[Address(RVA = "0x2674094", Offset = "0x2674094", VA = "0x2674094", Slot = "45")]
	protected override bool NeedRecoverPreviewOnNavigationShowed()
	{
		return default(bool);
	}

	[Token(Token = "0x600E32B")]
	[Address(RVA = "0x2674170", Offset = "0x2674170", VA = "0x2674170", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E32C")]
	[Address(RVA = "0x2675954", Offset = "0x2675954", VA = "0x2675954", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E32D")]
	[Address(RVA = "0x26759D8", Offset = "0x26759D8", VA = "0x26759D8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E32E")]
	[Address(RVA = "0x26764A0", Offset = "0x26764A0", VA = "0x26764A0", Slot = "64")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E32F")]
	[Address(RVA = "0x2678988", Offset = "0x2678988", VA = "0x2678988")]
	private void OnRuleClicked(object[] param)
	{
	}

	[Token(Token = "0x600E330")]
	[Address(RVA = "0x2678D74", Offset = "0x2678D74", VA = "0x2678D74")]
	private void OnExchangeActivityBtnClick(object[] param)
	{
	}

	[Token(Token = "0x600E331")]
	[Address(RVA = "0x2673564", Offset = "0x2673564", VA = "0x2673564")]
	private void SelectChooseTab()
	{
	}

	[Token(Token = "0x600E332")]
	[Address(RVA = "0x2678EF8", Offset = "0x2678EF8", VA = "0x2678EF8")]
	private void OnAnimPlayBtnClick(object[] param)
	{
	}

	[Token(Token = "0x600E333")]
	[Address(RVA = "0x2679264", Offset = "0x2679264", VA = "0x2679264")]
	private void OnCDNChangeBtnClick(object[] param)
	{
	}

	[Token(Token = "0x600E334")]
	[Address(RVA = "0x267A1F0", Offset = "0x267A1F0", VA = "0x267A1F0")]
	private void OnChangeLegendaryAvatar(object[] param)
	{
	}

	[Token(Token = "0x600E335")]
	[Address(RVA = "0x267A2FC", Offset = "0x267A2FC", VA = "0x267A2FC")]
	private void OnPropsClick(object[] param)
	{
	}

	[Token(Token = "0x600E336")]
	[Address(RVA = "0x267AB3C", Offset = "0x267AB3C", VA = "0x267AB3C")]
	private void OnPropsClose()
	{
	}

	[Token(Token = "0x600E337")]
	[Address(RVA = "0x267ABCC", Offset = "0x267ABCC", VA = "0x267ABCC")]
	private void OnInterfaceMackClick()
	{
	}

	[Token(Token = "0x600E338")]
	[Address(RVA = "0x267ACD0", Offset = "0x267ACD0", VA = "0x267ACD0")]
	private void OnInterfaceContentMaskClick()
	{
	}

	[Token(Token = "0x600E339")]
	[Address(RVA = "0x26734D8", Offset = "0x26734D8", VA = "0x26734D8")]
	private int GetDefTabIdx()
	{
		return default(int);
	}

	[Token(Token = "0x600E33A")]
	[Address(RVA = "0x2673458", Offset = "0x2673458", VA = "0x2673458")]
	private int ChestID2TabIdx(int chestID)
	{
		return default(int);
	}

	[Token(Token = "0x600E33B")]
	[Address(RVA = "0x26791D0", Offset = "0x26791D0", VA = "0x26791D0")]
	private uint TabIdx2ChestID(int tabIdx)
	{
		return default(uint);
	}

	[Token(Token = "0x600E33C")]
	[Address(RVA = "0x26775E8", Offset = "0x26775E8", VA = "0x26775E8")]
	private void OnGachaTabClick(object[] param)
	{
	}

	[Token(Token = "0x600E33D")]
	[Address(RVA = "0x267AF8C", Offset = "0x267AF8C", VA = "0x267AF8C")]
	private void RefreshTabBtnState(int selectedTabIdx)
	{
	}

	[Token(Token = "0x600E33E")]
	[Address(RVA = "0x267B214", Offset = "0x267B214", VA = "0x267B214")]
	public void RefreshAvatarPos()
	{
	}

	[Token(Token = "0x600E33F")]
	[Address(RVA = "0x267B2CC", Offset = "0x267B2CC", VA = "0x267B2CC")]
	public void OnlyResetPreviewItemPanelSize()
	{
	}

	[Token(Token = "0x600E340")]
	[Address(RVA = "0x26738DC", Offset = "0x26738DC", VA = "0x26738DC")]
	public void RefreshGachaScene()
	{
	}

	[Token(Token = "0x600E341")]
	[Address(RVA = "0x26794C8", Offset = "0x26794C8", VA = "0x26794C8")]
	private bool CheckNeedPlayAnimByDateAndOptionalAbs()
	{
		return default(bool);
	}

	[Token(Token = "0x600E342")]
	[Address(RVA = "0x267C5B8", Offset = "0x267C5B8", VA = "0x267C5B8")]
	private void RefreshUIScene()
	{
	}

	[Token(Token = "0x600E343")]
	[Address(RVA = "0x2676E18", Offset = "0x2676E18", VA = "0x2676E18")]
	private void RefreshGachaTabsView(object[] param)
	{
	}

	[Token(Token = "0x600E344")]
	[Address(RVA = "0x267C688", Offset = "0x267C688", VA = "0x267C688")]
	private void RefreshGachaBG()
	{
	}

	[Token(Token = "0x600E345")]
	[Address(RVA = "0x2678408", Offset = "0x2678408", VA = "0x2678408")]
	private void RefreshAnimPlayBtnView()
	{
	}

	[Token(Token = "0x600E346")]
	[Address(RVA = "0x267CABC", Offset = "0x267CABC", VA = "0x267CABC")]
	private void RefreshShowChangePlayBtnView()
	{
	}

	[Token(Token = "0x600E347")]
	[Address(RVA = "0x2677874", Offset = "0x2677874", VA = "0x2677874")]
	private void RefreshPropsView()
	{
	}

	[Token(Token = "0x600E348")]
	[Address(RVA = "0x267C938", Offset = "0x267C938", VA = "0x267C938")]
	private void RefreshContentView()
	{
	}

	[Token(Token = "0x600E349")]
	[Address(RVA = "0x267CCE8", Offset = "0x267CCE8", VA = "0x267CCE8", Slot = "22")]
	public override void Hide()
	{
	}

	[Token(Token = "0x600E34A")]
	[Address(RVA = "0x267CE14", Offset = "0x267CE14", VA = "0x267CE14", Slot = "21")]
	public override void Show()
	{
	}

	[Token(Token = "0x600E34B")]
	[Address(RVA = "0x267CF40", Offset = "0x267CF40", VA = "0x267CF40")]
	private void HideViewOnPlayAnimtion(object[] param)
	{
	}

	[Token(Token = "0x600E34C")]
	[Address(RVA = "0x267D220", Offset = "0x267D220", VA = "0x267D220")]
	private void ShowViewOnOverAnimtion(object[] param)
	{
	}

	[Token(Token = "0x600E34D")]
	[Address(RVA = "0x267B564", Offset = "0x267B564", VA = "0x267B564")]
	private UIGachaContentBase GetGachaContent(ELottery.Type type, uint gachaID)
	{
		return null;
	}

	[Token(Token = "0x600E34E")]
	[Address(RVA = "0x2676BF0", Offset = "0x2676BF0", VA = "0x2676BF0")]
	private void CheckGachaOpen()
	{
	}

	[Token(Token = "0x600E34F")]
	[Address(RVA = "0x26770D4", Offset = "0x26770D4", VA = "0x26770D4")]
	private void CheckAwardIsExist()
	{
	}

	[Token(Token = "0x600E350")]
	[Address(RVA = "0x26772A0", Offset = "0x26772A0", VA = "0x26772A0")]
	private void InitGachaTab()
	{
	}

	[Token(Token = "0x600E351")]
	[Address(RVA = "0x267BD20", Offset = "0x267BD20", VA = "0x267BD20")]
	private bool TryShowTutorialWnd([Optional] Action CloseCallBack)
	{
		return default(bool);
	}

	[Token(Token = "0x600E352")]
	[Address(RVA = "0x267D4E4", Offset = "0x267D4E4", VA = "0x267D4E4")]
	private void ShowSplash()
	{
	}

	[Token(Token = "0x600E353")]
	[Address(RVA = "0x267D790", Offset = "0x267D790", VA = "0x267D790")]
	private void OnWebViewClose()
	{
	}

	[Token(Token = "0x600E354")]
	[Address(RVA = "0x267DB0C", Offset = "0x267DB0C", VA = "0x267DB0C")]
	private void OnOpenRewardPanel(object[] data)
	{
	}

	[Token(Token = "0x600E355")]
	[Address(RVA = "0x267DB90", Offset = "0x267DB90", VA = "0x267DB90")]
	private void OnCloseRewardPanel(object[] data)
	{
	}

	[Token(Token = "0x600E356")]
	[Address(RVA = "0x267DD2C", Offset = "0x267DD2C", VA = "0x267DD2C")]
	private void OnGachaAnimSkip(object[] data)
	{
	}

	[Token(Token = "0x600E357")]
	[Address(RVA = "0x267D128", Offset = "0x267D128", VA = "0x267D128")]
	public void PlayShowAnim(bool isShow)
	{
	}

	[Token(Token = "0x600E358")]
	[Address(RVA = "0x2675304", Offset = "0x2675304", VA = "0x2675304")]
	public void SetInterfaceMaskEnable(object[] param)
	{
	}

	[Token(Token = "0x600E359")]
	[Address(RVA = "0x267DDAC", Offset = "0x267DDAC", VA = "0x267DDAC")]
	private void SetInterfaceMaskLabelEnable(bool v)
	{
	}

	[Token(Token = "0x600E35A")]
	[Address(RVA = "0x2675890", Offset = "0x2675890", VA = "0x2675890")]
	public void SetContentMaskEnable(bool v)
	{
	}

	[Token(Token = "0x600E35B")]
	[Address(RVA = "0x267DE64", Offset = "0x267DE64", VA = "0x267DE64")]
	public void SetContentMMaskLabelEnable(bool v)
	{
	}

	[Token(Token = "0x600E35C")]
	[Address(RVA = "0x267DF1C", Offset = "0x267DF1C", VA = "0x267DF1C", Slot = "38")]
	public override EFrontendBGMType GetBGMType()
	{
		return default(EFrontendBGMType);
	}

	[Token(Token = "0x600E35D")]
	[Address(RVA = "0x267DF74", Offset = "0x267DF74", VA = "0x267DF74")]
	private void OnRewardPoolClose(object[] data)
	{
	}

	[Token(Token = "0x600E35E")]
	[Address(RVA = "0x267E33C", Offset = "0x267E33C", VA = "0x267E33C")]
	private void ShowChangeSceneMask()
	{
	}

	[Token(Token = "0x600E35F")]
	[Address(RVA = "0x2672C34", Offset = "0x2672C34", VA = "0x2672C34")]
	private void CloseRewardPool()
	{
	}

	[Token(Token = "0x600E360")]
	[Address(RVA = "0x267E49C", Offset = "0x267E49C", VA = "0x267E49C")]
	private void OnRewardPoolItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600E361")]
	[Address(RVA = "0x267E5D0", Offset = "0x267E5D0", VA = "0x267E5D0")]
	private void OnAnimOver(object[] data)
	{
	}

	[Token(Token = "0x600E362")]
	[Address(RVA = "0x267E788", Offset = "0x267E788", VA = "0x267E788")]
	private void OnAvatarClear(object[] data)
	{
	}

	[Token(Token = "0x600E363")]
	[Address(RVA = "0x267E808", Offset = "0x267E808", VA = "0x267E808")]
	private void OnWeaponCgUIShow(object[] data)
	{
	}

	[Token(Token = "0x600E364")]
	[Address(RVA = "0x267E910", Offset = "0x267E910", VA = "0x267E910")]
	private void OnWeaponCgUIHide(object[] data)
	{
	}

	[Token(Token = "0x600E365")]
	[Address(RVA = "0x267E994", Offset = "0x267E994", VA = "0x267E994")]
	private void OnRewardPoolOpen(object[] data)
	{
	}

	[Token(Token = "0x600E366")]
	[Address(RVA = "0x2679BE8", Offset = "0x2679BE8", VA = "0x2679BE8")]
	private void CheckForPlayGachaAnimation()
	{
	}

	[Token(Token = "0x600E367")]
	[Address(RVA = "0x267EF88", Offset = "0x267EF88", VA = "0x267EF88")]
	private void ProcessAnimEvt(object[] data)
	{
	}

	[Token(Token = "0x600E368")]
	[Address(RVA = "0x267F0E8", Offset = "0x267F0E8", VA = "0x267F0E8")]
	private void OnExchangeExtraReward(object[] data)
	{
	}

	[Token(Token = "0x600E369")]
	[Address(RVA = "0x267F1A8", Offset = "0x267F1A8", VA = "0x267F1A8", Slot = "39")]
	public override List<string> GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	[Token(Token = "0x600E36A")]
	[Address(RVA = "0x267F2A8", Offset = "0x267F2A8", VA = "0x267F2A8", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x600E36B")]
	[Address(RVA = "0x267F318", Offset = "0x267F318", VA = "0x267F318", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600E36C")]
	[Address(RVA = "0x267F370", Offset = "0x267F370", VA = "0x267F370", Slot = "47")]
	protected override FrontEndPreviewComponent GetFrontEndPreviewComponent()
	{
		return null;
	}

	[Token(Token = "0x600E36D")]
	[Address(RVA = "0x267F428", Offset = "0x267F428", VA = "0x267F428")]
	private void _003CTryShowTutorialWnd_003Em__0()
	{
	}

	[Token(Token = "0x600E36E")]
	[Address(RVA = "0x267F4E4", Offset = "0x267F4E4", VA = "0x267F4E4")]
	private void _003CShowSplash_003Em__1()
	{
	}

	[Token(Token = "0x600E36F")]
	[Address(RVA = "0x267F5A0", Offset = "0x267F5A0", VA = "0x267F5A0")]
	public bool _003C_003EiFixBaseProxy_NeedWaitDataReady()
	{
		return default(bool);
	}

	[Token(Token = "0x600E370")]
	[Address(RVA = "0x267F5A8", Offset = "0x267F5A8", VA = "0x267F5A8")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x600E371")]
	[Address(RVA = "0x267F5B0", Offset = "0x267F5B0", VA = "0x267F5B0")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600E372")]
	[Address(RVA = "0x267F5B8", Offset = "0x267F5B8", VA = "0x267F5B8")]
	public bool _003C_003EiFixBaseProxy_NeedRecoverPreviewOnNavigationShowed()
	{
		return default(bool);
	}

	[Token(Token = "0x600E373")]
	[Address(RVA = "0x267F5C0", Offset = "0x267F5C0", VA = "0x267F5C0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E374")]
	[Address(RVA = "0x267F5C8", Offset = "0x267F5C8", VA = "0x267F5C8")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E375")]
	[Address(RVA = "0x267F5D0", Offset = "0x267F5D0", VA = "0x267F5D0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600E376")]
	[Address(RVA = "0x267F5D8", Offset = "0x267F5D8", VA = "0x267F5D8")]
	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	[Token(Token = "0x600E377")]
	[Address(RVA = "0x267F5E0", Offset = "0x267F5E0", VA = "0x267F5E0")]
	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	[Token(Token = "0x600E378")]
	[Address(RVA = "0x267F5E8", Offset = "0x267F5E8", VA = "0x267F5E8")]
	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return default(EFrontendBGMType);
	}

	[Token(Token = "0x600E379")]
	[Address(RVA = "0x267F5F0", Offset = "0x267F5F0", VA = "0x267F5F0")]
	public List<string> _003C_003EiFixBaseProxy_GetNeedShowUI3dObjectNames()
	{
		return null;
	}

	[Token(Token = "0x600E37A")]
	[Address(RVA = "0x267F5F8", Offset = "0x267F5F8", VA = "0x267F5F8")]
	public FrontEndPreviewComponent _003C_003EiFixBaseProxy_GetFrontEndPreviewComponent()
	{
		return null;
	}
}
