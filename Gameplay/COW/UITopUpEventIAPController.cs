using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B70")]
public class UITopUpEventIAPController : UIPaymentController.PaymentTabContentController
{
	[Token(Token = "0x4010A22")]
	[FieldOffset(Offset = "0x28")]
	private UITopUpEventController m_UITopUpEventController;

	[Token(Token = "0x6011EAA")]
	[Address(RVA = "0x2AF6C34", Offset = "0x2AF6C34", VA = "0x2AF6C34")]
	public UITopUpEventIAPController()
	{
	}

	[Token(Token = "0x6011EAB")]
	[Address(RVA = "0x2AF6C3C", Offset = "0x2AF6C3C", VA = "0x2AF6C3C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011EAC")]
	[Address(RVA = "0x2AF6CE4", Offset = "0x2AF6CE4", VA = "0x2AF6CE4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011EAD")]
	[Address(RVA = "0x2AF6E14", Offset = "0x2AF6E14", VA = "0x2AF6E14", Slot = "32")]
	public override void RefreshContent()
	{
	}

	[Token(Token = "0x6011EAE")]
	[Address(RVA = "0x2AF6E94", Offset = "0x2AF6E94", VA = "0x2AF6E94", Slot = "31")]
	public override void GotoByParams(UIPaymentController.PaymentGotoParams parameters)
	{
	}

	[Token(Token = "0x6011EAF")]
	[Address(RVA = "0x2AF6F24", Offset = "0x2AF6F24", VA = "0x2AF6F24", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6011EB0")]
	[Address(RVA = "0x2AF6FC8", Offset = "0x2AF6FC8", VA = "0x2AF6FC8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011EB1")]
	[Address(RVA = "0x2AF6FD0", Offset = "0x2AF6FD0", VA = "0x2AF6FD0")]
	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}

	[Token(Token = "0x6011EB2")]
	[Address(RVA = "0x2AF6FD8", Offset = "0x2AF6FD8", VA = "0x2AF6FD8")]
	public void _003C_003EiFixBaseProxy_GotoByParams(UIPaymentController.PaymentGotoParams P0)
	{
	}

	[Token(Token = "0x6011EB3")]
	[Address(RVA = "0x2AF6FE0", Offset = "0x2AF6FE0", VA = "0x2AF6FE0")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
