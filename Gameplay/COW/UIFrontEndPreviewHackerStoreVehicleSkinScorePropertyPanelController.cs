using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CB1")]
public class UIFrontEndPreviewHackerStoreVehicleSkinScorePropertyPanelController : UIFrontEndPreviewVehicleSkinScorePropertyPanelBaseController
{
	[Token(Token = "0x4011108")]
	[FieldOffset(Offset = "0x3C")]
	private UIFrontEndPreviewHackerStoreVehicleSkinScorePropertyPanelView m_UIView;

	[Token(Token = "0x6012B5C")]
	[Address(RVA = "0x27F9E58", Offset = "0x27F9E58", VA = "0x27F9E58")]
	public UIFrontEndPreviewHackerStoreVehicleSkinScorePropertyPanelController()
	{
	}

	[Token(Token = "0x6012B5D")]
	[Address(RVA = "0x27F9E60", Offset = "0x27F9E60", VA = "0x27F9E60")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012B5E")]
	[Address(RVA = "0x27F9F08", Offset = "0x27F9F08", VA = "0x27F9F08", Slot = "31")]
	protected override void InitBaseUIView()
	{
	}

	[Token(Token = "0x6012B5F")]
	[Address(RVA = "0x27F9FB8", Offset = "0x27F9FB8", VA = "0x27F9FB8", Slot = "35")]
	protected override UIFrontEndPreviewVehicleSkinScorePropertyPanelBaseView InitBaseView()
	{
		return null;
	}
}
