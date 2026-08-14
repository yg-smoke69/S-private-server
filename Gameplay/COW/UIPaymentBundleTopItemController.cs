using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A1B")]
public class UIPaymentBundleTopItemController : UIBaseController
{
	[Token(Token = "0x40102E3")]
	[FieldOffset(Offset = "0x28")]
	private UIPaymentBundleTopItemView m_View;

	[Token(Token = "0x40102E4")]
	[FieldOffset(Offset = "0x2C")]
	private UIPaymentSpecialStoreItemData m_Data;

	[Token(Token = "0x40102E5")]
	[FieldOffset(Offset = "0x30")]
	private ETipsType m_type;

	[Token(Token = "0x40102E6")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<uint, string[]> m_Icons;

	[Token(Token = "0x601107C")]
	[Address(RVA = "0x287813C", Offset = "0x287813C", VA = "0x287813C")]
	public UIPaymentBundleTopItemController()
	{
	}

	[Token(Token = "0x601107D")]
	[Address(RVA = "0x287845C", Offset = "0x287845C", VA = "0x287845C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601107E")]
	[Address(RVA = "0x2878504", Offset = "0x2878504", VA = "0x2878504", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601107F")]
	[Address(RVA = "0x286C4AC", Offset = "0x286C4AC", VA = "0x286C4AC")]
	public void SetViewData(UIPaymentSpecialStoreItemData data)
	{
	}

	[Token(Token = "0x6011080")]
	[Address(RVA = "0x2878660", Offset = "0x2878660", VA = "0x2878660")]
	private void CheckTips()
	{
	}

	[Token(Token = "0x6011081")]
	[Address(RVA = "0x28787A0", Offset = "0x28787A0", VA = "0x28787A0")]
	public void OnButtonClick()
	{
	}

	[Token(Token = "0x6011082")]
	[Address(RVA = "0x286CDF4", Offset = "0x286CDF4", VA = "0x286CDF4")]
	public void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x6011083")]
	[Address(RVA = "0x286D584", Offset = "0x286D584", VA = "0x286D584")]
	public void OnItemUnSelect()
	{
	}

	[Token(Token = "0x6011084")]
	[Address(RVA = "0x28788AC", Offset = "0x28788AC", VA = "0x28788AC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
