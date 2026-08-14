using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002C33")]
public class UIVoucher : MonoBehaviour
{
	[Token(Token = "0x4010DC6")]
	[FieldOffset(Offset = "0xC")]
	private IVoucher m_Voucher;

	[Token(Token = "0x60126BE")]
	[Address(RVA = "0x1019954", Offset = "0x1019954", VA = "0x1019954")]
	public UIVoucher()
	{
	}

	[Token(Token = "0x60126BF")]
	[Address(RVA = "0x101995C", Offset = "0x101995C", VA = "0x101995C")]
	public void InitVoucher(IVoucher voucher, EInventory.CurrencyType currencyType, int totalPrice)
	{
	}

	[Token(Token = "0x60126C0")]
	[Address(RVA = "0x1019A18", Offset = "0x1019A18", VA = "0x1019A18")]
	public void InitVoucher(IVoucher voucher, int totalGemsPrice, int totalCoinsPrice)
	{
	}
}
