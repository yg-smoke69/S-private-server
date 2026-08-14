using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20021B9")]
public class UIExchangeMallPurchseController : UIMallPurchaseBaseController
{
	[Token(Token = "0x20021BA")]
	public enum EFromType
	{
		[Token(Token = "0x400D312")]
		NONE,
		[Token(Token = "0x400D313")]
		MALL,
		[Token(Token = "0x400D314")]
		EXCHANGE_POP
	}

	[Token(Token = "0x400D30F")]
	[FieldOffset(Offset = "0x70")]
	protected ExchangeStoreItemDesc m_ExchangeStoreItem;

	[Token(Token = "0x400D310")]
	[FieldOffset(Offset = "0x74")]
	private EFromType m_EntryFrom;

	[Token(Token = "0x17001029")]
	protected override int ItemCount
	{
		[Token(Token = "0x600B403")]
		[Address(RVA = "0x19DF68C", Offset = "0x19DF68C", VA = "0x19DF68C", Slot = "49")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600B404")]
		[Address(RVA = "0x19DEAEC", Offset = "0x19DEAEC", VA = "0x19DEAEC", Slot = "50")]
		set
		{
		}
	}

	[Token(Token = "0x600B400")]
	[Address(RVA = "0x19DE7FC", Offset = "0x19DE7FC", VA = "0x19DE7FC")]
	public UIExchangeMallPurchseController()
	{
	}

	[Token(Token = "0x600B401")]
	[Address(RVA = "0x19E9D64", Offset = "0x19E9D64", VA = "0x19E9D64")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B402")]
	[Address(RVA = "0x19DEDD8", Offset = "0x19DEDD8", VA = "0x19DEDD8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B405")]
	[Address(RVA = "0x19E9E08", Offset = "0x19E9E08", VA = "0x19E9E08")]
	protected void OnExchangeBtnClick()
	{
	}

	[Token(Token = "0x600B406")]
	[Address(RVA = "0x19DF124", Offset = "0x19DF124", VA = "0x19DF124", Slot = "51")]
	public virtual void RefreshData(ExchangeStoreItemDesc exchangeStoreItem, EFromType entryFrom = EFromType.MALL)
	{
	}

	[Token(Token = "0x600B407")]
	[Address(RVA = "0x19DF50C", Offset = "0x19DF50C", VA = "0x19DF50C")]
	protected void SetExchangeIcon(UISprite sprite)
	{
	}

	[Token(Token = "0x600B408")]
	[Address(RVA = "0x19E9F70", Offset = "0x19E9F70", VA = "0x19E9F70")]
	public void _003C_003EiFixBaseProxy_set_ItemCount(int P0)
	{
	}

	[Token(Token = "0x600B409")]
	[Address(RVA = "0x19E9F78", Offset = "0x19E9F78", VA = "0x19E9F78")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B40A")]
	[Address(RVA = "0x19E9F80", Offset = "0x19E9F80", VA = "0x19E9F80")]
	public int _003C_003EiFixBaseProxy_get_ItemCount()
	{
		return default(int);
	}
}
