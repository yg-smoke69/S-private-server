using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002156")]
public class UIHeroicStarTipController : UIPopupWindowController
{
	[Token(Token = "0x400D15D")]
	[FieldOffset(Offset = "0x48")]
	private UIHeroicStarTipView m_View;

	[Token(Token = "0x600B002")]
	[Address(RVA = "0x162CAD8", Offset = "0x162CAD8", VA = "0x162CAD8")]
	public UIHeroicStarTipController()
	{
	}

	[Token(Token = "0x600B003")]
	[Address(RVA = "0x162CAE0", Offset = "0x162CAE0", VA = "0x162CAE0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B004")]
	[Address(RVA = "0x162CB88", Offset = "0x162CB88", VA = "0x162CB88", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B005")]
	[Address(RVA = "0x162CC44", Offset = "0x162CC44", VA = "0x162CC44")]
	public void SetViewData(int rank, bool isHeroic)
	{
	}

	[Token(Token = "0x600B006")]
	[Address(RVA = "0x162D2BC", Offset = "0x162D2BC", VA = "0x162D2BC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
