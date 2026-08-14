using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029CD")]
public class UIMonthCardPopupWindowController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x4010115")]
	private const uint REDEEM_BTN_DEFAULT_COLOR = 4290380031u;

	[Token(Token = "0x4010116")]
	private const uint REDEEM_BTN_GREY_COLOR = 2155905279u;

	[Token(Token = "0x4010117")]
	private const uint REDEEM_BTN_TITLE_GREY_COLOR = 757935615u;

	[Token(Token = "0x4010118")]
	private const uint REDEEM_BTN_TITLE_DEFAULT_COLOR = 2000686079u;

	[Token(Token = "0x4010119")]
	[FieldOffset(Offset = "0x48")]
	private UIMonthCardPopupWindowView m_View;

	[Token(Token = "0x401011A")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelRebateCard m_Model;

	[Token(Token = "0x6010D14")]
	[Address(RVA = "0x194C728", Offset = "0x194C728", VA = "0x194C728")]
	public UIMonthCardPopupWindowController()
	{
	}

	[Token(Token = "0x6010D15")]
	[Address(RVA = "0x194C730", Offset = "0x194C730", VA = "0x194C730")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010D16")]
	[Address(RVA = "0x194C7D4", Offset = "0x194C7D4", VA = "0x194C7D4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010D17")]
	[Address(RVA = "0x194D2D8", Offset = "0x194D2D8", VA = "0x194D2D8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010D18")]
	[Address(RVA = "0x194D354", Offset = "0x194D354", VA = "0x194D354")]
	private void OnBtnRedeemClick()
	{
	}

	[Token(Token = "0x6010D19")]
	[Address(RVA = "0x194D790", Offset = "0x194D790", VA = "0x194D790")]
	private void OnBtnPurchaseClick()
	{
	}

	[Token(Token = "0x6010D1A")]
	[Address(RVA = "0x194DA7C", Offset = "0x194DA7C", VA = "0x194DA7C")]
	private void RefreshViewData()
	{
	}

	[Token(Token = "0x6010D1B")]
	[Address(RVA = "0x194E954", Offset = "0x194E954", VA = "0x194E954")]
	private void OnTimeCountFinished()
	{
	}

	[Token(Token = "0x6010D1C")]
	[Address(RVA = "0x194EA74", Offset = "0x194EA74", VA = "0x194EA74", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010D1D")]
	[Address(RVA = "0x194EB08", Offset = "0x194EB08", VA = "0x194EB08", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010D1E")]
	[Address(RVA = "0x194EF84", Offset = "0x194EF84", VA = "0x194EF84")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010D1F")]
	[Address(RVA = "0x194EF8C", Offset = "0x194EF8C", VA = "0x194EF8C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
