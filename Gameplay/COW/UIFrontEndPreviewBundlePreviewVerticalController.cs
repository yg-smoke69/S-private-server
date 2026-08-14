using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CA5")]
public class UIFrontEndPreviewBundlePreviewVerticalController : UIFrontEndPreviewBundlePreviewBaseController
{
	[Token(Token = "0x40110AD")]
	[FieldOffset(Offset = "0x54")]
	private UIFrontEndPreviewBundlePreviewVerticalView m_UIView;

	[Token(Token = "0x6012A96")]
	[Address(RVA = "0x27E1AD4", Offset = "0x27E1AD4", VA = "0x27E1AD4")]
	public UIFrontEndPreviewBundlePreviewVerticalController()
	{
	}

	[Token(Token = "0x6012A97")]
	[Address(RVA = "0x27E1AD8", Offset = "0x27E1AD8", VA = "0x27E1AD8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012A98")]
	[Address(RVA = "0x27E1B80", Offset = "0x27E1B80", VA = "0x27E1B80", Slot = "31")]
	protected override void InitBaseUIView()
	{
	}

	[Token(Token = "0x6012A99")]
	[Address(RVA = "0x27E1C30", Offset = "0x27E1C30", VA = "0x27E1C30", Slot = "35")]
	protected override UIFrontEndPreviewBundlePreviewBaseView InitBaseView()
	{
		return null;
	}
}
