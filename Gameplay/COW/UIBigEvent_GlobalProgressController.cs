using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E9C")]
public class UIBigEvent_GlobalProgressController : UINavigationController, _Attribute
{
	[Token(Token = "0x400C061")]
	[FieldOffset(Offset = "0x68")]
	private UIBigEvent_GlobalProgressView m_View;

	[Token(Token = "0x400C062")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	[Token(Token = "0x400C063")]
	[FieldOffset(Offset = "0x70")]
	private UIModelBigEvent_GlobalProgress m_UIModelBigEvent_GlobalProgress;

	[Token(Token = "0x400C064")]
	[FieldOffset(Offset = "0x74")]
	private List<UIBigEvent_GlobalProgress_BtnItemController> m_LeftBtnControllers;

	[Token(Token = "0x400C065")]
	[FieldOffset(Offset = "0x78")]
	private List<UIBigEvent_GlobalProgress_BarItemController> m_BarRewardItemControllers;

	[Token(Token = "0x400C066")]
	[FieldOffset(Offset = "0x7C")]
	private UIStandardAdsController m_AdsCtrl;

	[Token(Token = "0x400C067")]
	private const int AdsDotWidth = 33;

	[Token(Token = "0x400C068")]
	private const int AdsDotHeight = 5;

	[Token(Token = "0x400C069")]
	private const int AdsGridCellWidth = 38;

	[Token(Token = "0x60093B3")]
	[Address(RVA = "0x301A1B4", Offset = "0x301A1B4", VA = "0x301A1B4")]
	public UIBigEvent_GlobalProgressController()
	{
	}

	[Token(Token = "0x60093B4")]
	[Address(RVA = "0x301A238", Offset = "0x301A238", VA = "0x301A238")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60093B5")]
	[Address(RVA = "0x301A2E0", Offset = "0x301A2E0", VA = "0x301A2E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60093B6")]
	[Address(RVA = "0x301B304", Offset = "0x301B304", VA = "0x301B304", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x60093B7")]
	[Address(RVA = "0x301B490", Offset = "0x301B490", VA = "0x301B490", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x60093B8")]
	[Address(RVA = "0x301C5AC", Offset = "0x301C5AC", VA = "0x301C5AC", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x60093B9")]
	[Address(RVA = "0x301C6EC", Offset = "0x301C6EC", VA = "0x301C6EC", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x60093BA")]
	[Address(RVA = "0x301C75C", Offset = "0x301C75C", VA = "0x301C75C", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60093BB")]
	[Address(RVA = "0x301C8C0", Offset = "0x301C8C0", VA = "0x301C8C0", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60093BC")]
	[Address(RVA = "0x301B160", Offset = "0x301B160", VA = "0x301B160")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x60093BD")]
	[Address(RVA = "0x301B52C", Offset = "0x301B52C", VA = "0x301B52C")]
	private void RefreshProgressBar()
	{
	}

	[Token(Token = "0x60093BE")]
	[Address(RVA = "0x301C028", Offset = "0x301C028", VA = "0x301C028")]
	private void RefreshGridLeftBtns()
	{
	}

	[Token(Token = "0x60093BF")]
	[Address(RVA = "0x301C978", Offset = "0x301C978", VA = "0x301C978")]
	private void RefreshAdPanel()
	{
	}

	[Token(Token = "0x60093C0")]
	[Address(RVA = "0x301CAA4", Offset = "0x301CAA4", VA = "0x301CAA4")]
	private void OnClickBtnRule()
	{
	}

	[Token(Token = "0x60093C1")]
	[Address(RVA = "0x301CBD8", Offset = "0x301CBD8", VA = "0x301CBD8")]
	private void OnClickBtnClose()
	{
	}

	[Token(Token = "0x60093C2")]
	[Address(RVA = "0x301CCE4", Offset = "0x301CCE4", VA = "0x301CCE4")]
	private void OnClickStandardAds(object[] data)
	{
	}

	[Token(Token = "0x60093C3")]
	[Address(RVA = "0x301D08C", Offset = "0x301D08C", VA = "0x301D08C")]
	private void OnClickBtnShare()
	{
	}

	[Token(Token = "0x60093C4")]
	[Address(RVA = "0x301C61C", Offset = "0x301C61C", VA = "0x301C61C")]
	private void SetShareBgView(bool show)
	{
	}

	[Token(Token = "0x60093C5")]
	[Address(RVA = "0x301D32C", Offset = "0x301D32C", VA = "0x301D32C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60093C6")]
	[Address(RVA = "0x301D334", Offset = "0x301D334", VA = "0x301D334")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x60093C7")]
	[Address(RVA = "0x301D33C", Offset = "0x301D33C", VA = "0x301D33C")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x60093C8")]
	[Address(RVA = "0x301D344", Offset = "0x301D344", VA = "0x301D344")]
	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x60093C9")]
	[Address(RVA = "0x301D34C", Offset = "0x301D34C", VA = "0x301D34C")]
	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
