using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20021B2")]
public class UIExchangeMallClanPurchaseController : UIExchangeMallPurchseController
{
	[Token(Token = "0x17001028")]
	protected override int ItemCount
	{
		[Token(Token = "0x600B380")]
		[Address(RVA = "0x19DE8A8", Offset = "0x19DE8A8", VA = "0x19DE8A8", Slot = "49")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B381")]
		[Address(RVA = "0x19DE900", Offset = "0x19DE900", VA = "0x19DE900", Slot = "50")]
		set
		{
		}
	}

	[Token(Token = "0x600B37E")]
	[Address(RVA = "0x19DE7F4", Offset = "0x19DE7F4", VA = "0x19DE7F4")]
	public UIExchangeMallClanPurchaseController()
	{
	}

	[Token(Token = "0x600B37F")]
	[Address(RVA = "0x19DE804", Offset = "0x19DE804", VA = "0x19DE804")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B382")]
	[Address(RVA = "0x19DEC28", Offset = "0x19DEC28", VA = "0x19DEC28", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B383")]
	[Address(RVA = "0x19DEF18", Offset = "0x19DEF18", VA = "0x19DEF18", Slot = "51")]
	public override void RefreshData(ExchangeStoreItemDesc exchangeStoreItem, EFromType fromType = EFromType.NONE)
	{
	}

	[Token(Token = "0x600B384")]
	[Address(RVA = "0x19DF688", Offset = "0x19DF688", VA = "0x19DF688")]
	public new int _003C_003EiFixBaseProxy_get_ItemCount()
	{
		return default(int);
	}

	[Token(Token = "0x600B385")]
	[Address(RVA = "0x19DF6E4", Offset = "0x19DF6E4", VA = "0x19DF6E4")]
	public new void _003C_003EiFixBaseProxy_set_ItemCount(int P0)
	{
	}

	[Token(Token = "0x600B386")]
	[Address(RVA = "0x19DF6E8", Offset = "0x19DF6E8", VA = "0x19DF6E8")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B387")]
	[Address(RVA = "0x19DF6EC", Offset = "0x19DF6EC", VA = "0x19DF6EC")]
	public void _003C_003EiFixBaseProxy_RefreshData(ExchangeStoreItemDesc P0, EFromType P1)
	{
	}
}
