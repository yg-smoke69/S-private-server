using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CBF")]
public class UIFrontEndPreviewItemDescController : UIFrontEndPreviewItemDescBaseController
{
	[Token(Token = "0x4011151")]
	[FieldOffset(Offset = "0xA0")]
	private UIFrontEndPreviewItemDescView m_UIView;

	[Token(Token = "0x6012BC4")]
	[Address(RVA = "0xE8E730", Offset = "0xE8E730", VA = "0xE8E730")]
	public UIFrontEndPreviewItemDescController()
	{
	}

	[Token(Token = "0x6012BC5")]
	[Address(RVA = "0xE8E7B0", Offset = "0xE8E7B0", VA = "0xE8E7B0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012BC6")]
	[Address(RVA = "0xE8E858", Offset = "0xE8E858", VA = "0xE8E858", Slot = "31")]
	protected override void InitBaseUIView()
	{
	}

	[Token(Token = "0x6012BC7")]
	[Address(RVA = "0xE8E908", Offset = "0xE8E908", VA = "0xE8E908", Slot = "35")]
	protected override UIFrontEndPreviewItemDescBaseView InitBaseView()
	{
		return null;
	}
}
