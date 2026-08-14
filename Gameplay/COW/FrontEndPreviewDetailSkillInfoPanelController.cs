using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C9B")]
public class FrontEndPreviewDetailSkillInfoPanelController : FrontEndPreviewDetailSkillInfoPanelBaseController
{
	[Token(Token = "0x401108A")]
	[FieldOffset(Offset = "0x40")]
	private FrontEndPreviewDetailSkillInfoPanelView m_UIView;

	[Token(Token = "0x6012A46")]
	[Address(RVA = "0x104DC70", Offset = "0x104DC70", VA = "0x104DC70")]
	public FrontEndPreviewDetailSkillInfoPanelController()
	{
	}

	[Token(Token = "0x6012A47")]
	[Address(RVA = "0x104DC74", Offset = "0x104DC74", VA = "0x104DC74")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012A48")]
	[Address(RVA = "0x104DD1C", Offset = "0x104DD1C", VA = "0x104DD1C", Slot = "31")]
	protected override void InitBaseUIView()
	{
	}

	[Token(Token = "0x6012A49")]
	[Address(RVA = "0x104DDCC", Offset = "0x104DDCC", VA = "0x104DDCC", Slot = "35")]
	protected override FrontEndPreviewDetailSkillInfoPanelBaseView InitBaseView()
	{
		return null;
	}
}
