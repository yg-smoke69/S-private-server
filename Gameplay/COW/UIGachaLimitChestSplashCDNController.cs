using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002692")]
internal class UIGachaLimitChestSplashCDNController : UIPopupWindowController
{
	[Token(Token = "0x400EE03")]
	[FieldOffset(Offset = "0x48")]
	private UIGachaLimitChestSplashCDNView m_View;

	[Token(Token = "0x400EE04")]
	[FieldOffset(Offset = "0x4C")]
	private Action m_onHide;

	[Token(Token = "0x600E7E5")]
	[Address(RVA = "0x2E86B40", Offset = "0x2E86B40", VA = "0x2E86B40")]
	public UIGachaLimitChestSplashCDNController()
	{
	}

	[Token(Token = "0x600E7E6")]
	[Address(RVA = "0x2E86B48", Offset = "0x2E86B48", VA = "0x2E86B48")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E7E7")]
	[Address(RVA = "0x2E86BF0", Offset = "0x2E86BF0", VA = "0x2E86BF0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E7E8")]
	[Address(RVA = "0x2E86D40", Offset = "0x2E86D40", VA = "0x2E86D40", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600E7E9")]
	[Address(RVA = "0x2E86DA4", Offset = "0x2E86DA4", VA = "0x2E86DA4", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E7EA")]
	[Address(RVA = "0x2E86E08", Offset = "0x2E86E08", VA = "0x2E86E08", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600E7EB")]
	[Address(RVA = "0x2E86E6C", Offset = "0x2E86E6C", VA = "0x2E86E6C")]
	public void SetViewData(uint gachaID, Action onHide)
	{
	}

	[Token(Token = "0x600E7EC")]
	[Address(RVA = "0x2E87074", Offset = "0x2E87074", VA = "0x2E87074")]
	private void OnCloseClick()
	{
	}

	[Token(Token = "0x600E7ED")]
	[Address(RVA = "0x2E870F4", Offset = "0x2E870F4", VA = "0x2E870F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E7EE")]
	[Address(RVA = "0x2E870FC", Offset = "0x2E870FC", VA = "0x2E870FC")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600E7EF")]
	[Address(RVA = "0x2E87104", Offset = "0x2E87104", VA = "0x2E87104")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E7F0")]
	[Address(RVA = "0x2E8710C", Offset = "0x2E8710C", VA = "0x2E8710C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
