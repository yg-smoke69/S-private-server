using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B5D")]
public class UISubscriptionPreviewWindowController : UIPopupWindowController
{
	[Token(Token = "0x2002B5E")]
	public enum DisplayType
	{
		[Token(Token = "0x40109C8")]
		None,
		[Token(Token = "0x40109C9")]
		RebateCard,
		[Token(Token = "0x40109CA")]
		ElitePass,
		[Token(Token = "0x40109CB")]
		Bundle
	}

	[Token(Token = "0x2002B5F")]
	public class DisplayInfo
	{
		[Token(Token = "0x40109CC")]
		[FieldOffset(Offset = "0x8")]
		public DisplayType Type;

		[Token(Token = "0x40109CD")]
		[FieldOffset(Offset = "0xC")]
		public RebateCardType? RebateCardType;

		[Token(Token = "0x40109CE")]
		[FieldOffset(Offset = "0x14")]
		public uint BundleID;

		[Token(Token = "0x6011DE7")]
		[Address(RVA = "0x2013774", Offset = "0x2013774", VA = "0x2013774")]
		public DisplayInfo()
		{
		}
	}

	[Token(Token = "0x40109C2")]
	[FieldOffset(Offset = "0x48")]
	private UISubscriptionPreviewWindowView m_View;

	[Token(Token = "0x40109C3")]
	[FieldOffset(Offset = "0x4C")]
	private DisplayInfo m_DisplayInfo;

	[Token(Token = "0x40109C4")]
	[FieldOffset(Offset = "0x50")]
	private UIModelPayment m_Payment;

	[Token(Token = "0x40109C5")]
	[FieldOffset(Offset = "0x54")]
	private UIModelRebateCard m_RebateCard;

	[Token(Token = "0x40109C6")]
	[FieldOffset(Offset = "0x58")]
	private UIModelElitePass m_ElitePass;

	[Token(Token = "0x6011DD5")]
	[Address(RVA = "0x20113F0", Offset = "0x20113F0", VA = "0x20113F0")]
	public UISubscriptionPreviewWindowController()
	{
	}

	[Token(Token = "0x6011DD6")]
	[Address(RVA = "0x20113F8", Offset = "0x20113F8", VA = "0x20113F8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011DD7")]
	[Address(RVA = "0x201149C", Offset = "0x201149C", VA = "0x201149C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011DD8")]
	[Address(RVA = "0x20117E0", Offset = "0x20117E0", VA = "0x20117E0")]
	private void SetLegalTexts()
	{
	}

	[Token(Token = "0x6011DD9")]
	[Address(RVA = "0x2011D00", Offset = "0x2011D00", VA = "0x2011D00")]
	public void SetDisplayInfo(DisplayInfo info)
	{
	}

	[Token(Token = "0x6011DDA")]
	[Address(RVA = "0x2011DC0", Offset = "0x2011DC0", VA = "0x2011DC0")]
	private void UpdateDescLabel()
	{
	}

	[Token(Token = "0x6011DDB")]
	[Address(RVA = "0x20120B0", Offset = "0x20120B0", VA = "0x20120B0")]
	private void UpdateIcon()
	{
	}

	[Token(Token = "0x6011DDC")]
	[Address(RVA = "0x2012500", Offset = "0x2012500", VA = "0x2012500")]
	private void UpdateBonus()
	{
	}

	[Token(Token = "0x6011DDD")]
	[Address(RVA = "0x2012D74", Offset = "0x2012D74", VA = "0x2012D74")]
	private void UpdatePeriodLabel(PayItemData csv, PayItemData sdk)
	{
	}

	[Token(Token = "0x6011DDE")]
	[Address(RVA = "0x20128D4", Offset = "0x20128D4", VA = "0x20128D4")]
	private void GetProduct(out PayItemData csv, out PayItemData sdk)
	{
	}

	[Token(Token = "0x6011DDF")]
	[Address(RVA = "0x2012BA4", Offset = "0x2012BA4", VA = "0x2012BA4")]
	private void UpdatePriceLabel(PayItemData csv, PayItemData sdk)
	{
	}

	[Token(Token = "0x6011DE0")]
	[Address(RVA = "0x2012FB4", Offset = "0x2012FB4", VA = "0x2012FB4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011DE1")]
	[Address(RVA = "0x2013024", Offset = "0x2013024", VA = "0x2013024")]
	private void OnBtnCloseClick()
	{
	}

	[Token(Token = "0x6011DE2")]
	[Address(RVA = "0x2013088", Offset = "0x2013088", VA = "0x2013088")]
	private void OnBtnSubscribeClick()
	{
	}

	[Token(Token = "0x6011DE3")]
	[Address(RVA = "0x20135D4", Offset = "0x20135D4", VA = "0x20135D4")]
	private void OnBtnTermsOfServiceClick()
	{
	}

	[Token(Token = "0x6011DE4")]
	[Address(RVA = "0x201369C", Offset = "0x201369C", VA = "0x201369C")]
	private void OnBtnPrivacyPolicyClick()
	{
	}

	[Token(Token = "0x6011DE5")]
	[Address(RVA = "0x2013764", Offset = "0x2013764", VA = "0x2013764")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011DE6")]
	[Address(RVA = "0x201376C", Offset = "0x201376C", VA = "0x201376C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
