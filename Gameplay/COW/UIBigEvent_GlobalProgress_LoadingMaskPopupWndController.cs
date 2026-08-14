using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E96")]
public class UIBigEvent_GlobalProgress_LoadingMaskPopupWndController : UIPopupWindowController
{
	[Token(Token = "0x400C04F")]
	[FieldOffset(Offset = "0x48")]
	private UIBigEvent_GlobalProgress_LoadingMaskPopupWndView m_View;

	[Token(Token = "0x400C050")]
	[FieldOffset(Offset = "0x4C")]
	private List<int> m_ListNeedDownloadCdnConfigKey;

	[Token(Token = "0x400C051")]
	[FieldOffset(Offset = "0x50")]
	private int m_NeedDownloadCdnCount;

	[Token(Token = "0x400C052")]
	[FieldOffset(Offset = "0x54")]
	private int m_HaveDownloadedCdnCount;

	[Token(Token = "0x600937B")]
	[Address(RVA = "0x30284D0", Offset = "0x30284D0", VA = "0x30284D0")]
	public UIBigEvent_GlobalProgress_LoadingMaskPopupWndController()
	{
	}

	[Token(Token = "0x600937C")]
	[Address(RVA = "0x302861C", Offset = "0x302861C", VA = "0x302861C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600937D")]
	[Address(RVA = "0x30288A8", Offset = "0x30288A8", VA = "0x30288A8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600937E")]
	[Address(RVA = "0x30289D0", Offset = "0x30289D0", VA = "0x30289D0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600937F")]
	[Address(RVA = "0x3028A78", Offset = "0x3028A78", VA = "0x3028A78")]
	private void Update()
	{
	}

	[Token(Token = "0x6009380")]
	[Address(RVA = "0x3028848", Offset = "0x3028848", VA = "0x3028848")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x6009381")]
	[Address(RVA = "0x3028AEC", Offset = "0x3028AEC", VA = "0x3028AEC")]
	private void RefreshProgressBar()
	{
	}

	[Token(Token = "0x6009382")]
	[Address(RVA = "0x3028CF0", Offset = "0x3028CF0", VA = "0x3028CF0")]
	private void OnCdnDownloadCallback(object[] data)
	{
	}

	[Token(Token = "0x6009383")]
	[Address(RVA = "0x3028D64", Offset = "0x3028D64", VA = "0x3028D64")]
	private void OnClickBtnClose()
	{
	}

	[Token(Token = "0x6009384")]
	[Address(RVA = "0x3028E7C", Offset = "0x3028E7C", VA = "0x3028E7C", Slot = "41")]
	public override bool IgnoreEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x6009385")]
	[Address(RVA = "0x3028ED4", Offset = "0x3028ED4", VA = "0x3028ED4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009386")]
	[Address(RVA = "0x3028EDC", Offset = "0x3028EDC", VA = "0x3028EDC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x6009387")]
	[Address(RVA = "0x3028EE4", Offset = "0x3028EE4", VA = "0x3028EE4")]
	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return default(bool);
	}
}
