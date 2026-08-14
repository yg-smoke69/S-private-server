using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CAE")]
public class UIFrontEndPreviewHackerStoreBundlePreviewController : UIFrontEndPreviewBundlePreviewBaseController
{
	[Token(Token = "0x4011104")]
	[FieldOffset(Offset = "0x54")]
	private UIFrontEndPreviewHackerStoreBundlePreviewView m_UIView;

	[Token(Token = "0x6012B4A")]
	[Address(RVA = "0x27F831C", Offset = "0x27F831C", VA = "0x27F831C")]
	public UIFrontEndPreviewHackerStoreBundlePreviewController()
	{
	}

	[Token(Token = "0x6012B4B")]
	[Address(RVA = "0x27F8320", Offset = "0x27F8320", VA = "0x27F8320")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012B4C")]
	[Address(RVA = "0x27F83C8", Offset = "0x27F83C8", VA = "0x27F83C8", Slot = "31")]
	protected override void InitBaseUIView()
	{
	}

	[Token(Token = "0x6012B4D")]
	[Address(RVA = "0x27F8478", Offset = "0x27F8478", VA = "0x27F8478", Slot = "35")]
	protected override UIFrontEndPreviewBundlePreviewBaseView InitBaseView()
	{
		return null;
	}
}
