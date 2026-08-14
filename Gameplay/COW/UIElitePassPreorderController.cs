using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20025F1")]
public class UIElitePassPreorderController : UICGPlayableNavigationController, _Attribute
{
	[Token(Token = "0x400EA8B")]
	[FieldOffset(Offset = "0x80")]
	private UIElitePassPreorderView m_View;

	[Token(Token = "0x400EA8C")]
	[FieldOffset(Offset = "0x84")]
	private UIModelElitePass m_Model;

	[Token(Token = "0x400EA8D")]
	[FieldOffset(Offset = "0x88")]
	private EPPreorderData m_Data;

	[Token(Token = "0x400EA8E")]
	[FieldOffset(Offset = "0x8C")]
	private FullscreenCgDesc m_FullScreenCG;

	[Token(Token = "0x400EA8F")]
	[FieldOffset(Offset = "0x90")]
	private bool m_FullScreenCGReady;

	[Token(Token = "0x400EA90")]
	[FieldOffset(Offset = "0x94")]
	private ResourceID m_AnimResource;

	[Token(Token = "0x400EA91")]
	[FieldOffset(Offset = "0x98")]
	private UINewDownloadInfoController m_DownloadCtrl;

	[Token(Token = "0x400EA92")]
	[FieldOffset(Offset = "0x9C")]
	private float m_CGPlayTime;

	[Token(Token = "0x400EA93")]
	[FieldOffset(Offset = "0xA0")]
	private bool m_ShowingAnimationFlag;

	[Token(Token = "0x400EA94")]
	[FieldOffset(Offset = "0xA1")]
	private bool m_IsActive;

	[Token(Token = "0x400EA95")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<AdvertDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400EA96")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600DFFA")]
	[Address(RVA = "0x305B478", Offset = "0x305B478", VA = "0x305B478")]
	public UIElitePassPreorderController()
	{
	}

	[Token(Token = "0x600DFFB")]
	[Address(RVA = "0x305B520", Offset = "0x305B520", VA = "0x305B520")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DFFC")]
	[Address(RVA = "0x305B5C8", Offset = "0x305B5C8", VA = "0x305B5C8")]
	private void Update()
	{
	}

	[Token(Token = "0x600DFFD")]
	[Address(RVA = "0x305B650", Offset = "0x305B650", VA = "0x305B650", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DFFE")]
	[Address(RVA = "0x305C99C", Offset = "0x305C99C", VA = "0x305C99C", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600DFFF")]
	[Address(RVA = "0x305CBD0", Offset = "0x305CBD0", VA = "0x305CBD0")]
	private void RefreshAnimStatus(bool refresh_btn_visible = true)
	{
	}

	[Token(Token = "0x600E000")]
	[Address(RVA = "0x305CE8C", Offset = "0x305CE8C", VA = "0x305CE8C")]
	private void InitDownloadCtrlState()
	{
	}

	[Token(Token = "0x600E001")]
	[Address(RVA = "0x305C3C4", Offset = "0x305C3C4", VA = "0x305C3C4")]
	private void UpdatePreviewItems()
	{
	}

	[Token(Token = "0x600E002")]
	[Address(RVA = "0x305BAB4", Offset = "0x305BAB4", VA = "0x305BAB4")]
	private void UpdatePreorderUI()
	{
	}

	[Token(Token = "0x600E003")]
	[Address(RVA = "0x305C174", Offset = "0x305C174", VA = "0x305C174")]
	private void UpdateSubscriptionUI()
	{
	}

	[Token(Token = "0x600E004")]
	[Address(RVA = "0x305C704", Offset = "0x305C704", VA = "0x305C704")]
	private void UpdateFullScreenCG()
	{
	}

	[Token(Token = "0x600E005")]
	[Address(RVA = "0x305D228", Offset = "0x305D228", VA = "0x305D228")]
	private void OnClickAnimPlayBtn()
	{
	}

	[Token(Token = "0x600E006")]
	[Address(RVA = "0x305D3F8", Offset = "0x305D3F8", VA = "0x305D3F8")]
	private void ShowDownloadPopUp()
	{
	}

	[Token(Token = "0x600E007")]
	[Address(RVA = "0x305D2A8", Offset = "0x305D2A8", VA = "0x305D2A8")]
	private void ShowFullScreenCG()
	{
	}

	[Token(Token = "0x600E008")]
	[Address(RVA = "0x305CA30", Offset = "0x305CA30", VA = "0x305CA30")]
	private void AutoShowCG()
	{
	}

	[Token(Token = "0x600E009")]
	[Address(RVA = "0x305D6D4", Offset = "0x305D6D4", VA = "0x305D6D4")]
	private void OnPreorderSuccess(object[] data)
	{
	}

	[Token(Token = "0x600E00A")]
	[Address(RVA = "0x305DC00", Offset = "0x305DC00", VA = "0x305DC00", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E00B")]
	[Address(RVA = "0x305DE2C", Offset = "0x305DE2C", VA = "0x305DE2C")]
	private void OnPreviewStoryCGOver(object[] param)
	{
	}

	[Token(Token = "0x600E00C")]
	[Address(RVA = "0x305E060", Offset = "0x305E060", VA = "0x305E060")]
	private void OnPreorderBtnClick()
	{
	}

	[Token(Token = "0x600E00D")]
	[Address(RVA = "0x305E308", Offset = "0x305E308", VA = "0x305E308")]
	private void PreorderEP()
	{
	}

	[Token(Token = "0x600E00E")]
	[Address(RVA = "0x305E498", Offset = "0x305E498", VA = "0x305E498")]
	private void OnSubscribeBtnClick()
	{
	}

	[Token(Token = "0x600E00F")]
	[Address(RVA = "0x305E5C0", Offset = "0x305E5C0", VA = "0x305E5C0", Slot = "66")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600E010")]
	[Address(RVA = "0x305E67C", Offset = "0x305E67C", VA = "0x305E67C", Slot = "67")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E011")]
	[Address(RVA = "0x305DF24", Offset = "0x305DF24", VA = "0x305DF24")]
	public void LogEventTypeFullScreenAnimation(float animTime)
	{
	}

	[Token(Token = "0x600E012")]
	[Address(RVA = "0x305E710", Offset = "0x305E710", VA = "0x305E710", Slot = "64")]
	protected override UINavigationUtil.UINavigationPageType GetUINavigationPageType()
	{
		return default(UINavigationUtil.UINavigationPageType);
	}

	[Token(Token = "0x600E013")]
	[Address(RVA = "0x305E768", Offset = "0x305E768", VA = "0x305E768", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x600E014")]
	[Address(RVA = "0x305E7D8", Offset = "0x305E7D8", VA = "0x305E7D8", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600E015")]
	[Address(RVA = "0x305E830", Offset = "0x305E830", VA = "0x305E830")]
	private void _003CInitDownloadCtrlState_003Em__0()
	{
	}

	[Token(Token = "0x600E016")]
	[Address(RVA = "0x305EC08", Offset = "0x305EC08", VA = "0x305EC08")]
	private static bool _003CUpdatePreorderUI_003Em__1(AdvertDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x600E017")]
	[Address(RVA = "0x305EC38", Offset = "0x305EC38", VA = "0x305EC38")]
	private static void _003COnPreorderSuccess_003Em__2()
	{
	}

	[Token(Token = "0x600E018")]
	[Address(RVA = "0x305ED84", Offset = "0x305ED84", VA = "0x305ED84")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E019")]
	[Address(RVA = "0x305ED8C", Offset = "0x305ED8C", VA = "0x305ED8C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600E01A")]
	[Address(RVA = "0x305ED94", Offset = "0x305ED94", VA = "0x305ED94")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
