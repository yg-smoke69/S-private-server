using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A39")]
public class UIPaymentSubscriptionGracePeriodReminderWindowController : UIPopupWindowController
{
	[Token(Token = "0x40103AC")]
	[FieldOffset(Offset = "0x48")]
	private UIPaymentSubscriptionGracePeriodReminderWindowView m_View;

	[Token(Token = "0x40103AD")]
	[FieldOffset(Offset = "0x4C")]
	private PayUtility.SubscriptionGracePeriodReminderInfo m_Info;

	[Token(Token = "0x60111C7")]
	[Address(RVA = "0x29E7650", Offset = "0x29E7650", VA = "0x29E7650")]
	public UIPaymentSubscriptionGracePeriodReminderWindowController()
	{
	}

	[Token(Token = "0x60111C8")]
	[Address(RVA = "0x29E7658", Offset = "0x29E7658", VA = "0x29E7658")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60111C9")]
	[Address(RVA = "0x29E7700", Offset = "0x29E7700", VA = "0x29E7700", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60111CA")]
	[Address(RVA = "0x29E78D0", Offset = "0x29E78D0", VA = "0x29E78D0")]
	public void SetData(PayUtility.SubscriptionGracePeriodReminderInfo info)
	{
	}

	[Token(Token = "0x60111CB")]
	[Address(RVA = "0x29E7930", Offset = "0x29E7930", VA = "0x29E7930")]
	private void OnConfirmButtonClick()
	{
	}

	[Token(Token = "0x60111CC")]
	[Address(RVA = "0x29E79FC", Offset = "0x29E79FC", VA = "0x29E79FC")]
	private void OnCancelButtonClick()
	{
	}

	[Token(Token = "0x60111CD")]
	[Address(RVA = "0x29E7AC8", Offset = "0x29E7AC8", VA = "0x29E7AC8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
