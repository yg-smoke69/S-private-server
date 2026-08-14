using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CCD")]
public class UIFrontEndPreviewVehicleSkinScorePropertyPanelController : UIFrontEndPreviewVehicleSkinScorePropertyPanelBaseController
{
	[Token(Token = "0x4011167")]
	[FieldOffset(Offset = "0x3C")]
	private UIFrontEndPreviewVehicleSkinScorePropertyPanelView m_UIView;

	[Token(Token = "0x6012C01")]
	[Address(RVA = "0xE90E9C", Offset = "0xE90E9C", VA = "0xE90E9C")]
	public UIFrontEndPreviewVehicleSkinScorePropertyPanelController()
	{
	}

	[Token(Token = "0x6012C02")]
	[Address(RVA = "0xE90EA0", Offset = "0xE90EA0", VA = "0xE90EA0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012C03")]
	[Address(RVA = "0xE90F48", Offset = "0xE90F48", VA = "0xE90F48", Slot = "31")]
	protected override void InitBaseUIView()
	{
	}

	[Token(Token = "0x6012C04")]
	[Address(RVA = "0xE90FF8", Offset = "0xE90FF8", VA = "0xE90FF8", Slot = "35")]
	protected override UIFrontEndPreviewVehicleSkinScorePropertyPanelBaseView InitBaseView()
	{
		return null;
	}
}
