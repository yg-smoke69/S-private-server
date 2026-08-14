using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CAF")]
public class UIFrontEndPreviewHackerStoreDetailSkillInfoPanelController : FrontEndPreviewDetailSkillInfoPanelBaseController
{
	[Token(Token = "0x4011105")]
	[FieldOffset(Offset = "0x40")]
	private UIFrontEndPreviewHackerStoreDetailSkillInfoPanelView m_UIView;

	[Token(Token = "0x6012B4E")]
	[Address(RVA = "0x27F86A0", Offset = "0x27F86A0", VA = "0x27F86A0")]
	public UIFrontEndPreviewHackerStoreDetailSkillInfoPanelController()
	{
	}

	[Token(Token = "0x6012B4F")]
	[Address(RVA = "0x27F86A8", Offset = "0x27F86A8", VA = "0x27F86A8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012B50")]
	[Address(RVA = "0x27F8750", Offset = "0x27F8750", VA = "0x27F8750", Slot = "31")]
	protected override void InitBaseUIView()
	{
	}

	[Token(Token = "0x6012B51")]
	[Address(RVA = "0x27F8800", Offset = "0x27F8800", VA = "0x27F8800", Slot = "35")]
	protected override FrontEndPreviewDetailSkillInfoPanelBaseView InitBaseView()
	{
		return null;
	}
}
