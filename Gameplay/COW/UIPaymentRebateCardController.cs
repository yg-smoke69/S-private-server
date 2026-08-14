using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002A34")]
public class UIPaymentRebateCardController : UIPaymentController.PaymentTabContentController, _Attribute
{
	[Token(Token = "0x401038C")]
	[FieldOffset(Offset = "0x28")]
	private UIPaymentRebateCardView m_View;

	[Token(Token = "0x401038D")]
	private const uint REDEEM_BTN_DEFAULT_COLOR = 4290380031u;

	[Token(Token = "0x401038E")]
	private const uint REDEEM_BTN_GREY_COLOR = 2155905279u;

	[Token(Token = "0x401038F")]
	private const uint REDEEM_BTN_TITLE_GREY_COLOR = 757935615u;

	[Token(Token = "0x4010390")]
	private const uint REDEEM_BTN_TITLE_DEFAULT_COLOR = 2000686079u;

	[Token(Token = "0x4010391")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelRebateCard m_RebateCard;

	[Token(Token = "0x4010392")]
	[FieldOffset(Offset = "0x30")]
	private UIRebateCardItemController m_MonthCardItemController;

	[Token(Token = "0x4010393")]
	[FieldOffset(Offset = "0x34")]
	private UIRebateCardItemController m_WeekCardItemController;

	[Token(Token = "0x6011153")]
	[Address(RVA = "0x29DA61C", Offset = "0x29DA61C", VA = "0x29DA61C")]
	public UIPaymentRebateCardController()
	{
	}

	[Token(Token = "0x6011154")]
	[Address(RVA = "0x29DA624", Offset = "0x29DA624", VA = "0x29DA624")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011155")]
	[Address(RVA = "0x29DA6CC", Offset = "0x29DA6CC", VA = "0x29DA6CC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011156")]
	[Address(RVA = "0x29DAB68", Offset = "0x29DAB68", VA = "0x29DAB68")]
	private void OnGetCDNAD(object[] data)
	{
	}

	[Token(Token = "0x6011157")]
	[Address(RVA = "0x29DB20C", Offset = "0x29DB20C", VA = "0x29DB20C")]
	private void UpdateRebateCards()
	{
	}

	[Token(Token = "0x6011158")]
	[Address(RVA = "0x29DBBC0", Offset = "0x29DBBC0", VA = "0x29DBBC0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011159")]
	[Address(RVA = "0x29DBD00", Offset = "0x29DBD00", VA = "0x29DBD00")]
	private void OnNotifyCheckboxChange()
	{
	}

	[Token(Token = "0x601115A")]
	[Address(RVA = "0x29DBDB4", Offset = "0x29DBDB4", VA = "0x29DBDB4", Slot = "32")]
	public override void RefreshContent()
	{
	}

	[Token(Token = "0x601115B")]
	[Address(RVA = "0x29DBF68", Offset = "0x29DBF68", VA = "0x29DBF68", Slot = "35")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x601115C")]
	[Address(RVA = "0x29DBFFC", Offset = "0x29DBFFC", VA = "0x29DBFFC", Slot = "34")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601115D")]
	[Address(RVA = "0x29DC18C", Offset = "0x29DC18C", VA = "0x29DC18C")]
	private void _003COnGetCDNAD_003Em__0(Texture nt)
	{
	}

	[Token(Token = "0x601115E")]
	[Address(RVA = "0x29DC25C", Offset = "0x29DC25C", VA = "0x29DC25C")]
	private void _003COnGetCDNAD_003Em__1(Texture nt)
	{
	}

	[Token(Token = "0x601115F")]
	[Address(RVA = "0x29DC32C", Offset = "0x29DC32C", VA = "0x29DC32C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011160")]
	[Address(RVA = "0x29DC334", Offset = "0x29DC334", VA = "0x29DC334")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6011161")]
	[Address(RVA = "0x29DC33C", Offset = "0x29DC33C", VA = "0x29DC33C")]
	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}
}
