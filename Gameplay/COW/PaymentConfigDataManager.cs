using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001E3")]
public class PaymentConfigDataManager : SingletonModule<PaymentConfigDataManager>
{
	[Token(Token = "0x4000B59")]
	[FieldOffset(Offset = "0xC")]
	private List<uint> m_PaymentButtonStylesSort;

	[Token(Token = "0x60009F8")]
	[Address(RVA = "0x2DDE3F4", Offset = "0x2DDE3F4", VA = "0x2DDE3F4")]
	public PaymentConfigDataManager()
	{
	}

	[Token(Token = "0x60009F9")]
	[Address(RVA = "0x2DDE550", Offset = "0x2DDE550", VA = "0x2DDE550", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60009FA")]
	[Address(RVA = "0x2DDE610", Offset = "0x2DDE610", VA = "0x2DDE610", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60009FB")]
	[Address(RVA = "0x2DDE910", Offset = "0x2DDE910", VA = "0x2DDE910")]
	private int SortByWeight(PaymentConfigData a, PaymentConfigData b)
	{
		return default(int);
	}

	[Token(Token = "0x60009FC")]
	[Address(RVA = "0x2DDE9BC", Offset = "0x2DDE9BC", VA = "0x2DDE9BC")]
	public UIModelPayment.PaymentButtonStyle GetStyleByID(int index)
	{
		return default(UIModelPayment.PaymentButtonStyle);
	}
}
