using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CB6")]
public class UIFrontEndPreviewHairStyleLevelRightController : UIFrontEndPreviewHairStyleLevelBaseController
{
	[Token(Token = "0x401111B")]
	[FieldOffset(Offset = "0x3C")]
	private UIFrontEndPreviewHairStyleLevelRightView m_UIView;

	[Token(Token = "0x6012B78")]
	[Address(RVA = "0x27FB704", Offset = "0x27FB704", VA = "0x27FB704")]
	public UIFrontEndPreviewHairStyleLevelRightController()
	{
	}

	[Token(Token = "0x6012B79")]
	[Address(RVA = "0x27FB708", Offset = "0x27FB708", VA = "0x27FB708")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012B7A")]
	[Address(RVA = "0x27FB7B0", Offset = "0x27FB7B0", VA = "0x27FB7B0", Slot = "31")]
	protected override void InitBaseUIView()
	{
	}

	[Token(Token = "0x6012B7B")]
	[Address(RVA = "0x27FB860", Offset = "0x27FB860", VA = "0x27FB860", Slot = "35")]
	protected override UIFrontEndPreviewHairStyleLevelBaseView InitBaseView()
	{
		return null;
	}
}
