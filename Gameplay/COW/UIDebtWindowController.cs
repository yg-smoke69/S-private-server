using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025C7")]
public class UIDebtWindowController : UIPopupWindowController
{
	[Token(Token = "0x400E9BD")]
	[FieldOffset(Offset = "0x48")]
	private UIDebtWindowView m_view;

	[Token(Token = "0x600DE01")]
	[Address(RVA = "0x11F5038", Offset = "0x11F5038", VA = "0x11F5038")]
	public UIDebtWindowController()
	{
	}

	[Token(Token = "0x600DE02")]
	[Address(RVA = "0x11F5040", Offset = "0x11F5040", VA = "0x11F5040")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DE03")]
	[Address(RVA = "0x11F50E8", Offset = "0x11F50E8", VA = "0x11F50E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DE04")]
	[Address(RVA = "0x11F5244", Offset = "0x11F5244", VA = "0x11F5244")]
	private void OnChargeBtn()
	{
	}

	[Token(Token = "0x600DE05")]
	[Address(RVA = "0x11F5398", Offset = "0x11F5398", VA = "0x11F5398")]
	public void SetDebtCount(int _gemsCount)
	{
	}

	[Token(Token = "0x600DE06")]
	[Address(RVA = "0x11F5334", Offset = "0x11F5334", VA = "0x11F5334")]
	public void CloseDebtWindows()
	{
	}

	[Token(Token = "0x600DE07")]
	[Address(RVA = "0x11F54C8", Offset = "0x11F54C8", VA = "0x11F54C8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
