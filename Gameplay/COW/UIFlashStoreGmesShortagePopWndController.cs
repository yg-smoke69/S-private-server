using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20020F9")]
public class UIFlashStoreGmesShortagePopWndController : UIPopupWindowController
{
	[Token(Token = "0x400CE38")]
	private const string NAME = "ShortagePopWnd";

	[Token(Token = "0x400CE39")]
	protected const string FLASH_GEMS_ICON = "FF_UI_FlashStore_PurpleDiamond";

	[Token(Token = "0x400CE3A")]
	protected const string GEMS_ICON = "FF_UI_FlashStore_Diamond";

	[Token(Token = "0x400CE3B")]
	[FieldOffset(Offset = "0x48")]
	protected UIFlashStoreShortagePopWndView m_View;

	[Token(Token = "0x600AB1B")]
	[Address(RVA = "0x1DD0B9C", Offset = "0x1DD0B9C", VA = "0x1DD0B9C")]
	public UIFlashStoreGmesShortagePopWndController()
	{
	}

	[Token(Token = "0x600AB1C")]
	[Address(RVA = "0x1DD0BA4", Offset = "0x1DD0BA4", VA = "0x1DD0BA4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AB1D")]
	[Address(RVA = "0x1DD0C4C", Offset = "0x1DD0C4C", VA = "0x1DD0C4C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AB1E")]
	[Address(RVA = "0x1DD0E4C", Offset = "0x1DD0E4C", VA = "0x1DD0E4C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600AB1F")]
	[Address(RVA = "0x1DD0D10", Offset = "0x1DD0D10", VA = "0x1DD0D10")]
	private void InitViewData()
	{
	}

	[Token(Token = "0x600AB20")]
	[Address(RVA = "0x1DD102C", Offset = "0x1DD102C", VA = "0x1DD102C")]
	public void ShowFlashGemsAndGemsInsufficientData(uint flashGemsShortageCnt = 0u, uint gemsShortageCnt = 0u)
	{
	}

	[Token(Token = "0x600AB21")]
	[Address(RVA = "0x1DD160C", Offset = "0x1DD160C", VA = "0x1DD160C")]
	public void ShowFlashGemsInsufficientData(uint shortageCnt = 0u)
	{
	}

	[Token(Token = "0x600AB22")]
	[Address(RVA = "0x1DD1A14", Offset = "0x1DD1A14", VA = "0x1DD1A14")]
	public void ShowGemsInsufficientData(uint shortageCnt = 0u)
	{
	}

	[Token(Token = "0x600AB23")]
	[Address(RVA = "0x1DD1E1C", Offset = "0x1DD1E1C", VA = "0x1DD1E1C")]
	private void OnGemsObtainBtnClick()
	{
	}

	[Token(Token = "0x600AB24")]
	[Address(RVA = "0x1DD2050", Offset = "0x1DD2050", VA = "0x1DD2050")]
	private void OnPeriodicGemsObtainBtnClick()
	{
	}

	[Token(Token = "0x600AB25")]
	[Address(RVA = "0x1DD23D0", Offset = "0x1DD23D0", VA = "0x1DD23D0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AB26")]
	[Address(RVA = "0x1DD23D8", Offset = "0x1DD23D8", VA = "0x1DD23D8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
