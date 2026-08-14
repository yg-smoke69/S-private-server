using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CA4")]
public class UIFrontEndPreviewBundlePreviewHorizontalController : UIFrontEndPreviewBundlePreviewBaseController
{
	[Token(Token = "0x40110AC")]
	[FieldOffset(Offset = "0x54")]
	private UIFrontEndPreviewBundlePreviewHorizontalView m_UIView;

	[Token(Token = "0x6012A92")]
	[Address(RVA = "0x27E1750", Offset = "0x27E1750", VA = "0x27E1750")]
	public UIFrontEndPreviewBundlePreviewHorizontalController()
	{
	}

	[Token(Token = "0x6012A93")]
	[Address(RVA = "0x27E1754", Offset = "0x27E1754", VA = "0x27E1754")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012A94")]
	[Address(RVA = "0x27E17FC", Offset = "0x27E17FC", VA = "0x27E17FC", Slot = "31")]
	protected override void InitBaseUIView()
	{
	}

	[Token(Token = "0x6012A95")]
	[Address(RVA = "0x27E18AC", Offset = "0x27E18AC", VA = "0x27E18AC", Slot = "35")]
	protected override UIFrontEndPreviewBundlePreviewBaseView InitBaseView()
	{
		return null;
	}
}
