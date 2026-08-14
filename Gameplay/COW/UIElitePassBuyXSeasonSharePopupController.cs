using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20025E1")]
public class UIElitePassBuyXSeasonSharePopupController : UIPopupWindowController
{
	[Token(Token = "0x400EA1E")]
	[FieldOffset(Offset = "0x48")]
	private UIElitePassBuyXSeasonSharePopupView m_View;

	[Token(Token = "0x400EA1F")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelElitePass m_ElitePassModel;

	[Token(Token = "0x400EA20")]
	[FieldOffset(Offset = "0x50")]
	private UIPopupWindowTopBtnController m_TopBtn;

	[Token(Token = "0x400EA21")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<AdvertDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600DF1A")]
	[Address(RVA = "0x2A42120", Offset = "0x2A42120", VA = "0x2A42120")]
	public UIElitePassBuyXSeasonSharePopupController()
	{
	}

	[Token(Token = "0x600DF1B")]
	[Address(RVA = "0x2A42128", Offset = "0x2A42128", VA = "0x2A42128")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DF1C")]
	[Address(RVA = "0x2A421D0", Offset = "0x2A421D0", VA = "0x2A421D0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DF1D")]
	[Address(RVA = "0x2A429D0", Offset = "0x2A429D0", VA = "0x2A429D0")]
	private void RefreshUserInfo()
	{
	}

	[Token(Token = "0x600DF1E")]
	[Address(RVA = "0x2A426C8", Offset = "0x2A426C8", VA = "0x2A426C8")]
	private void UpdateUI()
	{
	}

	[Token(Token = "0x600DF1F")]
	[Address(RVA = "0x2A42D68", Offset = "0x2A42D68", VA = "0x2A42D68")]
	private void SetCDNTexture(object[] data)
	{
	}

	[Token(Token = "0x600DF20")]
	[Address(RVA = "0x2A4305C", Offset = "0x2A4305C", VA = "0x2A4305C")]
	public void OnSuccessfullyDownloadLogo()
	{
	}

	[Token(Token = "0x600DF21")]
	[Address(RVA = "0x2A431A0", Offset = "0x2A431A0", VA = "0x2A431A0")]
	private void OnCloseButtonClick()
	{
	}

	[Token(Token = "0x600DF22")]
	[Address(RVA = "0x2A43204", Offset = "0x2A43204", VA = "0x2A43204", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600DF23")]
	[Address(RVA = "0x2A433A8", Offset = "0x2A433A8", VA = "0x2A433A8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600DF24")]
	[Address(RVA = "0x2A43440", Offset = "0x2A43440", VA = "0x2A43440", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x600DF25")]
	[Address(RVA = "0x2A435C4", Offset = "0x2A435C4", VA = "0x2A435C4", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x600DF26")]
	[Address(RVA = "0x2A43748", Offset = "0x2A43748", VA = "0x2A43748")]
	private void OnShareButtonClick()
	{
	}

	[Token(Token = "0x600DF27")]
	[Address(RVA = "0x2A438A0", Offset = "0x2A438A0", VA = "0x2A438A0")]
	private static bool _003CSetCDNTexture_003Em__0(AdvertDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x600DF28")]
	[Address(RVA = "0x2A438D0", Offset = "0x2A438D0", VA = "0x2A438D0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DF29")]
	[Address(RVA = "0x2A438D8", Offset = "0x2A438D8", VA = "0x2A438D8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600DF2A")]
	[Address(RVA = "0x2A438E0", Offset = "0x2A438E0", VA = "0x2A438E0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600DF2B")]
	[Address(RVA = "0x2A438E8", Offset = "0x2A438E8", VA = "0x2A438E8")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x600DF2C")]
	[Address(RVA = "0x2A438F0", Offset = "0x2A438F0", VA = "0x2A438F0")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
