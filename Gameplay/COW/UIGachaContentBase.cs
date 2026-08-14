using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002630")]
public abstract class UIGachaContentBase : UIBaseController, _Attribute
{
	[Token(Token = "0x2002631")]
	private sealed class _003CInitShowOptionalDownloadInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x400EBD4")]
		[FieldOffset(Offset = "0x8")]
		internal List<ResourceID> resList;

		[Token(Token = "0x400EBD5")]
		[FieldOffset(Offset = "0xC")]
		internal UIGachaContentBase _0024this;

		[Token(Token = "0x600E31A")]
		[Address(RVA = "0x266F1B0", Offset = "0x266F1B0", VA = "0x266F1B0")]
		public _003CInitShowOptionalDownloadInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600E31B")]
		[Address(RVA = "0x2671F24", Offset = "0x2671F24", VA = "0x2671F24")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002632")]
	private sealed class _003COpenCommonRewardWnd_003Ec__AnonStorey1
	{
		[Token(Token = "0x400EBD6")]
		[FieldOffset(Offset = "0x8")]
		internal List<ExchangedAward> allRewardList;

		[Token(Token = "0x400EBD7")]
		[FieldOffset(Offset = "0xC")]
		internal UIGachaContentBase _0024this;

		[Token(Token = "0x600E31C")]
		[Address(RVA = "0x2671494", Offset = "0x2671494", VA = "0x2671494")]
		public _003COpenCommonRewardWnd_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600E31D")]
		[Address(RVA = "0x267226C", Offset = "0x267226C", VA = "0x267226C")]
		internal bool _003C_003Em__0(ExchangedAward item)
		{
			return default(bool);
		}

		[Token(Token = "0x600E31E")]
		[Address(RVA = "0x26722C8", Offset = "0x26722C8", VA = "0x26722C8")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x400EBCC")]
	[FieldOffset(Offset = "0x28")]
	protected uint m_GachaID;

	[Token(Token = "0x400EBCD")]
	[FieldOffset(Offset = "0x2C")]
	protected UIGachaBuyBtnController m_GachaBuyBtnCtrl;

	[Token(Token = "0x400EBCE")]
	[FieldOffset(Offset = "0x30")]
	protected UIGachaContentViewSetting m_ContentViewSetting;

	[Token(Token = "0x400EBCF")]
	[FieldOffset(Offset = "0x34")]
	protected UIGachaSceneShowType m_CurrentShowType;

	[Token(Token = "0x400EBD0")]
	[FieldOffset(Offset = "0x38")]
	protected bool IsFirstEnter;

	[Token(Token = "0x400EBD1")]
	[FieldOffset(Offset = "0x3C")]
	protected FrontEndPreviewComponent_Gacha m_FrontEndPreviewComponent;

	[Token(Token = "0x400EBD2")]
	[FieldOffset(Offset = "0x40")]
	protected UINewDownloadInfoController m_AnimDownloadCtrl;

	[Token(Token = "0x400EBD3")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600E2E5")]
	[Address(RVA = "0x266E524", Offset = "0x266E524", VA = "0x266E524")]
	protected UIGachaContentBase()
	{
	}

	[Token(Token = "0x600E2E6")]
	protected abstract void InitGachaContentBuyBtn();

	[Token(Token = "0x600E2E7")]
	protected abstract void OnRefreshUIView();

	[Token(Token = "0x600E2E8")]
	[Address(RVA = "0x266E5A8", Offset = "0x266E5A8", VA = "0x266E5A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E2E9")]
	[Address(RVA = "0x266EAA8", Offset = "0x266EAA8", VA = "0x266EAA8", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E2EA")]
	[Address(RVA = "0x266EB0C", Offset = "0x266EB0C", VA = "0x266EB0C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E2EB")]
	[Address(RVA = "0x2664334", Offset = "0x2664334", VA = "0x2664334")]
	public void RefreshUIView(uint chestID)
	{
	}

	[Token(Token = "0x600E2EC")]
	[Address(RVA = "0x266ED34", Offset = "0x266ED34", VA = "0x266ED34")]
	public GachaDesc GetGachaDesc()
	{
		return null;
	}

	[Token(Token = "0x600E2ED")]
	[Address(RVA = "0x266EE5C", Offset = "0x266EE5C", VA = "0x266EE5C")]
	public void SetDefaultShowType(UIGachaSceneShowType curType)
	{
	}

	[Token(Token = "0x600E2EE")]
	[Address(RVA = "0x266EEBC", Offset = "0x266EEBC", VA = "0x266EEBC", Slot = "35")]
	public virtual void InitShowOptionalDownloadInfo(List<ResourceID> resList)
	{
	}

	[Token(Token = "0x600E2EF")]
	[Address(RVA = "0x2663DD0", Offset = "0x2663DD0", VA = "0x2663DD0")]
	public void HideAnimDownloadCtrl()
	{
	}

	[Token(Token = "0x600E2F0")]
	[Address(RVA = "0x266F1B8", Offset = "0x266F1B8", VA = "0x266F1B8")]
	public void HideAnimPlayBtn()
	{
	}

	[Token(Token = "0x600E2F1")]
	[Address(RVA = "0x2663F94", Offset = "0x2663F94", VA = "0x2663F94")]
	public void ShowAnimDownloadCtrl()
	{
	}

	[Token(Token = "0x600E2F2")]
	[Address(RVA = "0x2663D78", Offset = "0x2663D78", VA = "0x2663D78")]
	public UIGachaContentViewSetting GetGameViewSettig()
	{
		return null;
	}

	[Token(Token = "0x600E2F3")]
	[Address(RVA = "0x266F2C4", Offset = "0x266F2C4", VA = "0x266F2C4", Slot = "36")]
	public virtual void OnReplayFullScreenAnim()
	{
	}

	[Token(Token = "0x600E2F4")]
	[Address(RVA = "0x266F318", Offset = "0x266F318", VA = "0x266F318", Slot = "37")]
	public virtual uint GetCurrentExchangeItemID()
	{
		return default(uint);
	}

	[Token(Token = "0x600E2F5")]
	[Address(RVA = "0x266F370", Offset = "0x266F370", VA = "0x266F370", Slot = "38")]
	public virtual void OnHideContent()
	{
	}

	[Token(Token = "0x600E2F6")]
	[Address(RVA = "0x266F3C4", Offset = "0x266F3C4", VA = "0x266F3C4", Slot = "39")]
	public virtual void OnShowContent()
	{
	}

	[Token(Token = "0x600E2F7")]
	[Address(RVA = "0x266F418", Offset = "0x266F418", VA = "0x266F418", Slot = "40")]
	public virtual void RefreshBuyBtnState()
	{
	}

	[Token(Token = "0x600E2F8")]
	[Address(RVA = "0x266F51C", Offset = "0x266F51C", VA = "0x266F51C", Slot = "41")]
	public virtual void OnPurchaseResult(bool isSuccess)
	{
	}

	[Token(Token = "0x600E2F9")]
	[Address(RVA = "0x266F578", Offset = "0x266F578", VA = "0x266F578", Slot = "42")]
	public virtual void OnSkipAnim()
	{
	}

	[Token(Token = "0x600E2FA")]
	[Address(RVA = "0x266F5CC", Offset = "0x266F5CC", VA = "0x266F5CC", Slot = "43")]
	public virtual void OnSkipFullScreenAnim()
	{
	}

	[Token(Token = "0x600E2FB")]
	[Address(RVA = "0x266F620", Offset = "0x266F620", VA = "0x266F620", Slot = "44")]
	public virtual void OnFullScreenAnimOver()
	{
	}

	[Token(Token = "0x600E2FC")]
	[Address(RVA = "0x266F674", Offset = "0x266F674", VA = "0x266F674", Slot = "45")]
	public virtual void OnRewardPoolClose()
	{
	}

	[Token(Token = "0x600E2FD")]
	[Address(RVA = "0x266F6C8", Offset = "0x266F6C8", VA = "0x266F6C8", Slot = "46")]
	public virtual void OnRewardPoolOpen()
	{
	}

	[Token(Token = "0x600E2FE")]
	[Address(RVA = "0x266F71C", Offset = "0x266F71C", VA = "0x266F71C", Slot = "47")]
	public virtual void OnFullScreenAnimEnter()
	{
	}

	[Token(Token = "0x600E2FF")]
	[Address(RVA = "0x266F770", Offset = "0x266F770", VA = "0x266F770", Slot = "48")]
	public virtual void OnTutorialOpen()
	{
	}

	[Token(Token = "0x600E300")]
	[Address(RVA = "0x266F7C4", Offset = "0x266F7C4", VA = "0x266F7C4", Slot = "49")]
	public virtual void OnTutorialClose()
	{
	}

	[Token(Token = "0x600E301")]
	[Address(RVA = "0x266F818", Offset = "0x266F818", VA = "0x266F818", Slot = "50")]
	public virtual void OnSplashCDNOpen()
	{
	}

	[Token(Token = "0x600E302")]
	[Address(RVA = "0x266F86C", Offset = "0x266F86C", VA = "0x266F86C", Slot = "51")]
	public virtual void OnSplashCDNClose()
	{
	}

	[Token(Token = "0x600E303")]
	[Address(RVA = "0x266F8C0", Offset = "0x266F8C0", VA = "0x266F8C0", Slot = "52")]
	public virtual void OnRecoverPreview()
	{
	}

	[Token(Token = "0x600E304")]
	[Address(RVA = "0x266F914", Offset = "0x266F914", VA = "0x266F914", Slot = "53")]
	public virtual Vector3 GetAvatarPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600E305")]
	[Address(RVA = "0x266F9B4", Offset = "0x266F9B4", VA = "0x266F9B4", Slot = "54")]
	public virtual UIWidget GetPreviewSceneBorder(uint gachaID)
	{
		return null;
	}

	[Token(Token = "0x600E306")]
	[Address(RVA = "0x266FA18", Offset = "0x266FA18", VA = "0x266FA18", Slot = "55")]
	public virtual UIGachaCustomizedPreviewUIData GetCustomizedPreviewUIPosition()
	{
		return null;
	}

	[Token(Token = "0x600E307")]
	[Address(RVA = "0x266FA70", Offset = "0x266FA70", VA = "0x266FA70", Slot = "56")]
	public virtual FrontendPreviewType GetFrontendPreviewType(uint gachaID)
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600E308")]
	[Address(RVA = "0x266FAD4", Offset = "0x266FAD4", VA = "0x266FAD4")]
	protected void AdjustWidgtDimFullScreen(UIWidget widget)
	{
	}

	[Token(Token = "0x600E309")]
	[Address(RVA = "0x266FBFC", Offset = "0x266FBFC", VA = "0x266FBFC")]
	protected void OpenCommonRewardWnd(UICommonRewardWndController.WndStyleEnum style, UIModelGacha.GachaDrawType dType, UIGachaBuyBtnController.BuyBtnState state, bool enableAnim, uint constrepurchaseNum = 0u, string desc = "", bool useNewItem = false)
	{
	}

	[Token(Token = "0x600E30A")]
	[Address(RVA = "0x26715B4", Offset = "0x26715B4", VA = "0x26715B4")]
	private uint GetSecondGooldAwardID(List<ExchangedAward> allAwards)
	{
		return default(uint);
	}

	[Token(Token = "0x600E30B")]
	[Address(RVA = "0x26718A0", Offset = "0x26718A0", VA = "0x26718A0")]
	private void OnPreviewSceneShowTypeChange(object[] data)
	{
	}

	[Token(Token = "0x600E30C")]
	[Address(RVA = "0x267199C", Offset = "0x267199C", VA = "0x267199C", Slot = "57")]
	protected virtual void OnPreviewSceneShowTypeChange()
	{
	}

	[Token(Token = "0x600E30D")]
	[Address(RVA = "0x267149C", Offset = "0x267149C", VA = "0x267149C")]
	private void PlayPopResultSound()
	{
	}

	[Token(Token = "0x600E30E")]
	[Address(RVA = "0x26719F0", Offset = "0x26719F0", VA = "0x26719F0", Slot = "58")]
	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E30F")]
	[Address(RVA = "0x2671B1C", Offset = "0x2671B1C", VA = "0x2671B1C", Slot = "59")]
	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E310")]
	[Address(RVA = "0x2671BD4", Offset = "0x2671BD4", VA = "0x2671BD4", Slot = "60")]
	protected virtual void OnCloseRewardPanel()
	{
	}

	[Token(Token = "0x600E311")]
	[Address(RVA = "0x2671C28", Offset = "0x2671C28", VA = "0x2671C28", Slot = "61")]
	public virtual UIGachaPreviewController OpenPreviewPanel(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600E312")]
	public abstract string GetTutorialWndTitleKey();

	[Token(Token = "0x600E313")]
	[Address(RVA = "0x2671D20", Offset = "0x2671D20", VA = "0x2671D20", Slot = "63")]
	public virtual void OnGachaSceneShowTypeChange(UIGachaSceneShowType type)
	{
	}

	[Token(Token = "0x600E314")]
	[Address(RVA = "0x2671D7C", Offset = "0x2671D7C", VA = "0x2671D7C", Slot = "64")]
	public virtual void SetFrontendPreviewComponent(FrontEndPreviewComponent_Gacha frontEndPreviewComponent)
	{
	}

	[Token(Token = "0x600E315")]
	[Address(RVA = "0x2671DDC", Offset = "0x2671DDC", VA = "0x2671DDC")]
	private static CommonRewardItemInfo _003COpenCommonRewardWnd_003Em__0(ExchangedAward item)
	{
		return null;
	}

	[Token(Token = "0x600E316")]
	[Address(RVA = "0x2671DE4", Offset = "0x2671DE4", VA = "0x2671DE4")]
	private GachaShowItem _003CGetSecondGooldAwardID_003Em__1(ExchangedAward item)
	{
		return null;
	}

	[Token(Token = "0x600E317")]
	[Address(RVA = "0x2671F0C", Offset = "0x2671F0C", VA = "0x2671F0C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E318")]
	[Address(RVA = "0x2671F14", Offset = "0x2671F14", VA = "0x2671F14")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E319")]
	[Address(RVA = "0x2671F1C", Offset = "0x2671F1C", VA = "0x2671F1C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
