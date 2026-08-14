using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002636")]
internal class UIGachaCouponTipsController : UIEasyListItemController
{
	[Token(Token = "0x400EBFB")]
	[FieldOffset(Offset = "0x38")]
	private UIGachaCouponTipsView m_View;

	[Token(Token = "0x400EBFC")]
	[FieldOffset(Offset = "0x3C")]
	private UIStandardItemMAXBController m_ItemController;

	[Token(Token = "0x400EBFD")]
	[FieldOffset(Offset = "0x40")]
	private Item m_ItemData;

	[Token(Token = "0x600E37D")]
	[Address(RVA = "0x2470380", Offset = "0x2470380", VA = "0x2470380")]
	public UIGachaCouponTipsController()
	{
	}

	[Token(Token = "0x600E37E")]
	[Address(RVA = "0x2470388", Offset = "0x2470388", VA = "0x2470388")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E37F")]
	[Address(RVA = "0x247042C", Offset = "0x247042C", VA = "0x247042C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E380")]
	[Address(RVA = "0x2470520", Offset = "0x2470520", VA = "0x2470520")]
	public void Refresh()
	{
	}

	[Token(Token = "0x600E381")]
	[Address(RVA = "0x246F000", Offset = "0x246F000", VA = "0x246F000")]
	public void SetViewData(Item itemData, bool canChoose = true, bool staticTime = true)
	{
	}

	[Token(Token = "0x600E382")]
	[Address(RVA = "0x2470BEC", Offset = "0x2470BEC", VA = "0x2470BEC", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600E383")]
	[Address(RVA = "0x2470618", Offset = "0x2470618", VA = "0x2470618")]
	private void SetStaticTime()
	{
	}

	[Token(Token = "0x600E384")]
	[Address(RVA = "0x2470D08", Offset = "0x2470D08", VA = "0x2470D08", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600E385")]
	[Address(RVA = "0x2470DC8", Offset = "0x2470DC8", VA = "0x2470DC8", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600E386")]
	[Address(RVA = "0x247091C", Offset = "0x247091C", VA = "0x247091C")]
	private void SetDynamicTime()
	{
	}

	[Token(Token = "0x600E387")]
	[Address(RVA = "0x2470E88", Offset = "0x2470E88", VA = "0x2470E88")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E388")]
	[Address(RVA = "0x2470E90", Offset = "0x2470E90", VA = "0x2470E90")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600E389")]
	[Address(RVA = "0x2470E98", Offset = "0x2470E98", VA = "0x2470E98")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}
}
