using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023F1")]
public class UITutorialIndicatorCharacterController : UIBaseController
{
	[Token(Token = "0x400E016")]
	[FieldOffset(Offset = "0x28")]
	private UITutorialIndicatorCharacterView m_View;

	[Token(Token = "0x600CACD")]
	[Address(RVA = "0x2B773D4", Offset = "0x2B773D4", VA = "0x2B773D4")]
	public UITutorialIndicatorCharacterController()
	{
	}

	[Token(Token = "0x600CACE")]
	[Address(RVA = "0x2B77458", Offset = "0x2B77458", VA = "0x2B77458", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CACF")]
	[Address(RVA = "0x2B77514", Offset = "0x2B77514", VA = "0x2B77514")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CAD0")]
	[Address(RVA = "0x2B775B8", Offset = "0x2B775B8", VA = "0x2B775B8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
