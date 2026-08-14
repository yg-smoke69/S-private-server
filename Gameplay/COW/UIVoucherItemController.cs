using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C36")]
public abstract class UIVoucherItemController : UIEasyListItemController
{
	[Token(Token = "0x4010DD0")]
	[FieldOffset(Offset = "0x38")]
	protected EVoucherState m_State;

	[Token(Token = "0x4010DD1")]
	[FieldOffset(Offset = "0x3C")]
	protected VoucherData m_Data;

	[Token(Token = "0x4010DD2")]
	[FieldOffset(Offset = "0x40")]
	protected uint m_ItemPrice;

	[Token(Token = "0x4010DD3")]
	[FieldOffset(Offset = "0x44")]
	protected uint m_ItemGemsPrice;

	[Token(Token = "0x4010DD4")]
	[FieldOffset(Offset = "0x48")]
	protected uint m_ItemCoinsPrice;

	[Token(Token = "0x4010DD5")]
	[FieldOffset(Offset = "0x4C")]
	protected VoucherData m_SelectedVoucher;

	[Token(Token = "0x4010DD6")]
	protected const uint ITEM_GREY = 2139062271u;

	[Token(Token = "0x60126C9")]
	[Address(RVA = "0x1019DE4", Offset = "0x1019DE4", VA = "0x1019DE4")]
	protected UIVoucherItemController()
	{
	}

	[Token(Token = "0x60126CA")]
	[Address(RVA = "0x1019DEC", Offset = "0x1019DEC", VA = "0x1019DEC", Slot = "32")]
	public override void OnItemBtnClick()
	{
	}

	[Token(Token = "0x60126CB")]
	[Address(RVA = "0x101A14C", Offset = "0x101A14C", VA = "0x101A14C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x60126CC")]
	public abstract void RefreshView();

	[Token(Token = "0x60126CD")]
	[Address(RVA = "0x101A2D8", Offset = "0x101A2D8", VA = "0x101A2D8")]
	public void SetVoucherData(uint itemGemsPrice, uint itemCoinsPrice, VoucherData selectedVoucher)
	{
	}

	[Token(Token = "0x60126CE")]
	[Address(RVA = "0x101A360", Offset = "0x101A360", VA = "0x101A360")]
	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}
}
