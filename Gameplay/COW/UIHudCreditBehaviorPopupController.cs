using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002717")]
internal class UIHudCreditBehaviorPopupController : UIBaseController
{
	[Token(Token = "0x400F135")]
	[FieldOffset(Offset = "0x28")]
	private UIHudCreditBehavioPopupView m_View;

	[Token(Token = "0x400F136")]
	[FieldOffset(Offset = "0x2C")]
	private UIClickMask m_ClickMask;

	[Token(Token = "0x600ED99")]
	[Address(RVA = "0x1369128", Offset = "0x1369128", VA = "0x1369128")]
	public UIHudCreditBehaviorPopupController()
	{
	}

	[Token(Token = "0x600ED9A")]
	[Address(RVA = "0x13691AC", Offset = "0x13691AC", VA = "0x13691AC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ED9B")]
	[Address(RVA = "0x1369254", Offset = "0x1369254", VA = "0x1369254", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600ED9C")]
	[Address(RVA = "0x1369304", Offset = "0x1369304", VA = "0x1369304")]
	public void SetMessage(string message)
	{
	}

	[Token(Token = "0x600ED9D")]
	[Address(RVA = "0x1369444", Offset = "0x1369444", VA = "0x1369444")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
