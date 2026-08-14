using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B5A")]
public class UISubscriptionConfirmWindowController : UIPopupWindowController
{
	[Token(Token = "0x2002B5B")]
	public enum ButtonStyle
	{
		[Token(Token = "0x40109B4")]
		None,
		[Token(Token = "0x40109B5")]
		OK,
		[Token(Token = "0x40109B6")]
		Confirm_Cancel
	}

	[Token(Token = "0x2002B5C")]
	public class SubscriptionConfirmDisplayInfo
	{
		[Token(Token = "0x40109B7")]
		[FieldOffset(Offset = "0x8")]
		public string Title;

		[Token(Token = "0x40109B8")]
		[FieldOffset(Offset = "0xC")]
		public string Desc_1;

		[Token(Token = "0x40109B9")]
		[FieldOffset(Offset = "0x10")]
		public string Desc_2;

		[Token(Token = "0x40109BA")]
		[FieldOffset(Offset = "0x14")]
		public string Desc_3;

		[Token(Token = "0x40109BB")]
		[FieldOffset(Offset = "0x18")]
		public string Desc;

		[Token(Token = "0x40109BC")]
		[FieldOffset(Offset = "0x1C")]
		public string SubscriptionProductIdentifier;

		[Token(Token = "0x40109BD")]
		[FieldOffset(Offset = "0x20")]
		public Action<string> OnOK;

		[Token(Token = "0x40109BE")]
		[FieldOffset(Offset = "0x24")]
		public bool ShowClose;

		[Token(Token = "0x40109BF")]
		[FieldOffset(Offset = "0x28")]
		public ButtonStyle ButtonStyle;

		[Token(Token = "0x40109C0")]
		[FieldOffset(Offset = "0x2C")]
		public RebateCardInfo RebateCard;

		[Token(Token = "0x40109C1")]
		[FieldOffset(Offset = "0x30")]
		public ClientMemberShipCardData MembershipCard;

		[Token(Token = "0x6011DD4")]
		[Address(RVA = "0x2010FF0", Offset = "0x2010FF0", VA = "0x2010FF0")]
		public SubscriptionConfirmDisplayInfo()
		{
		}
	}

	[Token(Token = "0x40109B1")]
	[FieldOffset(Offset = "0x48")]
	private UISubscriptionConfirmWindowView m_View;

	[Token(Token = "0x40109B2")]
	[FieldOffset(Offset = "0x4C")]
	private SubscriptionConfirmDisplayInfo m_Info;

	[Token(Token = "0x6011DCA")]
	[Address(RVA = "0x200FF48", Offset = "0x200FF48", VA = "0x200FF48")]
	public UISubscriptionConfirmWindowController()
	{
	}

	[Token(Token = "0x6011DCB")]
	[Address(RVA = "0x200FF50", Offset = "0x200FF50", VA = "0x200FF50")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011DCC")]
	[Address(RVA = "0x200FFF4", Offset = "0x200FFF4", VA = "0x200FFF4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011DCD")]
	[Address(RVA = "0x2010238", Offset = "0x2010238", VA = "0x2010238")]
	public void SetData(SubscriptionConfirmDisplayInfo info)
	{
	}

	[Token(Token = "0x6011DCE")]
	[Address(RVA = "0x201089C", Offset = "0x201089C", VA = "0x201089C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011DCF")]
	[Address(RVA = "0x2010900", Offset = "0x2010900", VA = "0x2010900")]
	private void OnBtnOKClick()
	{
	}

	[Token(Token = "0x6011DD0")]
	[Address(RVA = "0x2010A24", Offset = "0x2010A24", VA = "0x2010A24")]
	private void OnBtnConfirmClick()
	{
	}

	[Token(Token = "0x6011DD1")]
	[Address(RVA = "0x2010F7C", Offset = "0x2010F7C", VA = "0x2010F7C")]
	private void OnBtnCancelClick()
	{
	}

	[Token(Token = "0x6011DD2")]
	[Address(RVA = "0x2010FE0", Offset = "0x2010FE0", VA = "0x2010FE0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011DD3")]
	[Address(RVA = "0x2010FE8", Offset = "0x2010FE8", VA = "0x2010FE8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
