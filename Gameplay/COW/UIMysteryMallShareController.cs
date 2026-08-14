using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20021FE")]
internal class UIMysteryMallShareController : UIPopupWindowController
{
	[Token(Token = "0x400D4C7")]
	[FieldOffset(Offset = "0x48")]
	private UIMysteryMallShareView m_View;

	[Token(Token = "0x400D4C8")]
	[FieldOffset(Offset = "0x4C")]
	private UIPopupWindowTopBtnController m_TopBtn;

	[Token(Token = "0x600B75C")]
	[Address(RVA = "0x1B2C48C", Offset = "0x1B2C48C", VA = "0x1B2C48C")]
	public UIMysteryMallShareController()
	{
	}

	[Token(Token = "0x600B75D")]
	[Address(RVA = "0x1B2C494", Offset = "0x1B2C494", VA = "0x1B2C494")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B75E")]
	[Address(RVA = "0x1B2C53C", Offset = "0x1B2C53C", VA = "0x1B2C53C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B75F")]
	[Address(RVA = "0x1B2CA50", Offset = "0x1B2CA50", VA = "0x1B2CA50", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600B760")]
	[Address(RVA = "0x1B2CAE8", Offset = "0x1B2CAE8", VA = "0x1B2CAE8")]
	public void SetViewData(string cdnUrl)
	{
	}

	[Token(Token = "0x600B761")]
	[Address(RVA = "0x1B2CC2C", Offset = "0x1B2CC2C", VA = "0x1B2CC2C")]
	private void OnBtnShareClick()
	{
	}

	[Token(Token = "0x600B762")]
	[Address(RVA = "0x1B2CD84", Offset = "0x1B2CD84", VA = "0x1B2CD84", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x600B763")]
	[Address(RVA = "0x1B2CF08", Offset = "0x1B2CF08", VA = "0x1B2CF08", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x600B764")]
	[Address(RVA = "0x1B2D08C", Offset = "0x1B2D08C", VA = "0x1B2D08C")]
	private void _003CSetViewData_003Em__0()
	{
	}

	[Token(Token = "0x600B765")]
	[Address(RVA = "0x1B2D0D0", Offset = "0x1B2D0D0", VA = "0x1B2D0D0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B766")]
	[Address(RVA = "0x1B2D0D8", Offset = "0x1B2D0D8", VA = "0x1B2D0D8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600B767")]
	[Address(RVA = "0x1B2D0E0", Offset = "0x1B2D0E0", VA = "0x1B2D0E0")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x600B768")]
	[Address(RVA = "0x1B2D0E8", Offset = "0x1B2D0E8", VA = "0x1B2D0E8")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
