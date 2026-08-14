using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CB5")]
public class UIFrontEndPreviewHairStyleLevelLeftController : UIFrontEndPreviewHairStyleLevelBaseController
{
	[Token(Token = "0x401111A")]
	[FieldOffset(Offset = "0x3C")]
	private UIFrontEndPreviewHairStyleLevelLeftView m_UIView;

	[Token(Token = "0x6012B74")]
	[Address(RVA = "0x27FB380", Offset = "0x27FB380", VA = "0x27FB380")]
	public UIFrontEndPreviewHairStyleLevelLeftController()
	{
	}

	[Token(Token = "0x6012B75")]
	[Address(RVA = "0x27FB384", Offset = "0x27FB384", VA = "0x27FB384")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012B76")]
	[Address(RVA = "0x27FB42C", Offset = "0x27FB42C", VA = "0x27FB42C", Slot = "31")]
	protected override void InitBaseUIView()
	{
	}

	[Token(Token = "0x6012B77")]
	[Address(RVA = "0x27FB4DC", Offset = "0x27FB4DC", VA = "0x27FB4DC", Slot = "35")]
	protected override UIFrontEndPreviewHairStyleLevelBaseView InitBaseView()
	{
		return null;
	}
}
