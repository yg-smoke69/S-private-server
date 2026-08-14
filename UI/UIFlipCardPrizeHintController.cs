using COW;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x2002615")]
public class UIFlipCardPrizeHintController : UIPopupWindowController
{
	[Token(Token = "0x400EB13")]
	[FieldOffset(Offset = "0x48")]
	private UIFlipCardPrizeHintView m_View;

	[Token(Token = "0x600E172")]
	[Address(RVA = "0x1473FE4", Offset = "0x1473FE4", VA = "0x1473FE4")]
	public UIFlipCardPrizeHintController()
	{
	}

	[Token(Token = "0x600E173")]
	[Address(RVA = "0x1473FEC", Offset = "0x1473FEC", VA = "0x1473FEC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E174")]
	[Address(RVA = "0x1474050", Offset = "0x1474050", VA = "0x1474050", Slot = "13")]
	protected override void OnUIInit()
	{
	}
}
