using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002520")]
public class UICheckIsNewbieOrVeteranController : UIBaseController
{
	[Token(Token = "0x400E636")]
	[FieldOffset(Offset = "0x28")]
	private UICheckIsNewbieOrVeteranView m_View;

	[Token(Token = "0x400E637")]
	[FieldOffset(Offset = "0x2C")]
	private EAccount.NewbieChoice m_Choice;

	[Token(Token = "0x400E638")]
	private const string m_EnterAnimName = "FF_Newandveteran_Admission_ani";

	[Token(Token = "0x400E639")]
	private const string m_ExitAnimName = "FF_Newandveteran_Appearance_ani";

	[Token(Token = "0x400E63A")]
	private const int m_ChosenBtnSpriteWidth = 610;

	[Token(Token = "0x400E63B")]
	private const int m_UnchosenBtnSpriteWidth = 590;

	[Token(Token = "0x400E63C")]
	private const uint m_ChosenColor = 4290380031u;

	[Token(Token = "0x400E63D")]
	private const uint m_UnChosenColor = uint.MaxValue;

	[Token(Token = "0x400E63E")]
	private const uint m_UnChosenColorStripe = 1869574143u;

	[Token(Token = "0x600D7B6")]
	[Address(RVA = "0x2088C90", Offset = "0x2088C90", VA = "0x2088C90")]
	public UICheckIsNewbieOrVeteranController()
	{
	}

	[Token(Token = "0x600D7B7")]
	[Address(RVA = "0x2088D14", Offset = "0x2088D14", VA = "0x2088D14")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D7B8")]
	[Address(RVA = "0x2088DB8", Offset = "0x2088DB8", VA = "0x2088DB8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D7B9")]
	[Address(RVA = "0x2089630", Offset = "0x2089630", VA = "0x2089630", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600D7BA")]
	[Address(RVA = "0x2089694", Offset = "0x2089694", VA = "0x2089694", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D7BB")]
	[Address(RVA = "0x20896F8", Offset = "0x20896F8", VA = "0x20896F8")]
	public void PlayEnterAnim()
	{
	}

	[Token(Token = "0x600D7BC")]
	[Address(RVA = "0x2089814", Offset = "0x2089814", VA = "0x2089814")]
	public void PlayExitAnim()
	{
	}

	[Token(Token = "0x600D7BD")]
	[Address(RVA = "0x20898EC", Offset = "0x20898EC", VA = "0x20898EC")]
	private void OnChooseNewbie()
	{
	}

	[Token(Token = "0x600D7BE")]
	[Address(RVA = "0x2089950", Offset = "0x2089950", VA = "0x2089950")]
	private void OnChooseVeteran()
	{
	}

	[Token(Token = "0x600D7BF")]
	[Address(RVA = "0x20899B4", Offset = "0x20899B4", VA = "0x20899B4")]
	private void OnChooseMaster()
	{
	}

	[Token(Token = "0x600D7C0")]
	[Address(RVA = "0x2089A18", Offset = "0x2089A18", VA = "0x2089A18")]
	private void SetColorChosen(EAccount.NewbieChoice choice)
	{
	}

	[Token(Token = "0x600D7C1")]
	[Address(RVA = "0x208910C", Offset = "0x208910C", VA = "0x208910C")]
	private void OnChooseChange(EAccount.NewbieChoice choice)
	{
	}

	[Token(Token = "0x600D7C2")]
	[Address(RVA = "0x2089EB4", Offset = "0x2089EB4", VA = "0x2089EB4")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x600D7C3")]
	[Address(RVA = "0x208A064", Offset = "0x208A064", VA = "0x208A064", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600D7C4")]
	[Address(RVA = "0x208A148", Offset = "0x208A148", VA = "0x208A148", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600D7C5")]
	[Address(RVA = "0x208A22C", Offset = "0x208A22C", VA = "0x208A22C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D7C6")]
	[Address(RVA = "0x208A234", Offset = "0x208A234", VA = "0x208A234")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600D7C7")]
	[Address(RVA = "0x208A23C", Offset = "0x208A23C", VA = "0x208A23C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600D7C8")]
	[Address(RVA = "0x208A244", Offset = "0x208A244", VA = "0x208A244")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600D7C9")]
	[Address(RVA = "0x208A24C", Offset = "0x208A24C", VA = "0x208A24C")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
