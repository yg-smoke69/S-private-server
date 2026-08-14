using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002C34")]
public abstract class UIVoucherController : UIBaseController
{
	[Token(Token = "0x4010DC7")]
	[FieldOffset(Offset = "0x28")]
	protected int m_TotalGemsPrice;

	[Token(Token = "0x4010DC8")]
	[FieldOffset(Offset = "0x2C")]
	protected int m_TotalCoinsPrice;

	[Token(Token = "0x4010DC9")]
	[FieldOffset(Offset = "0x30")]
	protected VoucherData m_SelectedVoucherData;

	[Token(Token = "0x4010DCA")]
	[FieldOffset(Offset = "0x34")]
	protected IVoucher m_Voucher;

	[Token(Token = "0x60126C1")]
	[Address(RVA = "0x1019BAC", Offset = "0x1019BAC", VA = "0x1019BAC")]
	protected UIVoucherController()
	{
	}

	[Token(Token = "0x60126C2")]
	public abstract void OnVoucherListClose(object[] data);

	[Token(Token = "0x60126C3")]
	public abstract void OnVoucherItemClick(object[] data);

	[Token(Token = "0x60126C4")]
	[Address(RVA = "0x1019C30", Offset = "0x1019C30", VA = "0x1019C30")]
	public void RefreshTotalPrice(EInventory.CurrencyType currencyType, int totalPrice)
	{
	}

	[Token(Token = "0x60126C5")]
	[Address(RVA = "0x1019CDC", Offset = "0x1019CDC", VA = "0x1019CDC")]
	public void RefreshTotalPrice(int totalGemsPrice, int totalCoinsPrice)
	{
	}

	[Token(Token = "0x60126C6")]
	public abstract void OnVoucherBtnClick();

	[Token(Token = "0x60126C7")]
	[Address(RVA = "0x1019D5C", Offset = "0x1019D5C", VA = "0x1019D5C", Slot = "34")]
	public virtual void RefreshVoucherData(int totalGemsPrice, int totalCoinsPrice, IVoucher voucher)
	{
	}

	[Token(Token = "0x60126C8")]
	public abstract void SetVoucher(uint gemsPrice, uint coinsPrice);
}
