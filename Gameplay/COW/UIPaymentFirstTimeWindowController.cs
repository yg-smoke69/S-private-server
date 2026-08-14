using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A2B")]
public class UIPaymentFirstTimeWindowController : UIPopupWindowController
{
	[Token(Token = "0x401035E")]
	[FieldOffset(Offset = "0x48")]
	private UIPaymentFirstTimeWindowView m_View;

	[Token(Token = "0x60110EA")]
	[Address(RVA = "0x2888F68", Offset = "0x2888F68", VA = "0x2888F68")]
	public UIPaymentFirstTimeWindowController()
	{
	}

	[Token(Token = "0x60110EB")]
	[Address(RVA = "0x2888F70", Offset = "0x2888F70", VA = "0x2888F70")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60110EC")]
	[Address(RVA = "0x2889018", Offset = "0x2889018", VA = "0x2889018", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60110ED")]
	[Address(RVA = "0x2889690", Offset = "0x2889690", VA = "0x2889690")]
	private void OnGotoButtonClick()
	{
	}

	[Token(Token = "0x60110EE")]
	[Address(RVA = "0x28898C4", Offset = "0x28898C4", VA = "0x28898C4")]
	private void OnCloseButtonClick()
	{
	}

	[Token(Token = "0x60110EF")]
	[Address(RVA = "0x28891F0", Offset = "0x28891F0", VA = "0x28891F0")]
	private void UpdateNetworkTexture()
	{
	}

	[Token(Token = "0x60110F0")]
	[Address(RVA = "0x2889928", Offset = "0x2889928", VA = "0x2889928")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
