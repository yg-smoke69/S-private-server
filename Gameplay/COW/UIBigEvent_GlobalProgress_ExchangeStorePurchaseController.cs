using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001E95")]
public class UIBigEvent_GlobalProgress_ExchangeStorePurchaseController : UIMallPurchaseBaseController
{
	[Token(Token = "0x400C04D")]
	[FieldOffset(Offset = "0x70")]
	private CustomEventStoreCommodityDesc m_Data;

	[Token(Token = "0x400C04E")]
	[FieldOffset(Offset = "0x74")]
	private UIModelBigEventTemplate m_ModelBigEventTemplate;

	[Token(Token = "0x17000F37")]
	protected override int ItemCount
	{
		[Token(Token = "0x6009373")]
		[Address(RVA = "0x3026D48", Offset = "0x3026D48", VA = "0x3026D48", Slot = "49")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6009374")]
		[Address(RVA = "0x3026DA0", Offset = "0x3026DA0", VA = "0x3026DA0", Slot = "50")]
		set
		{
		}
	}

	[Token(Token = "0x6009370")]
	[Address(RVA = "0x3026AEC", Offset = "0x3026AEC", VA = "0x3026AEC")]
	public UIBigEvent_GlobalProgress_ExchangeStorePurchaseController()
	{
	}

	[Token(Token = "0x6009371")]
	[Address(RVA = "0x3026AF4", Offset = "0x3026AF4", VA = "0x3026AF4")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009372")]
	[Address(RVA = "0x3026B98", Offset = "0x3026B98", VA = "0x3026B98", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009375")]
	[Address(RVA = "0x3026EDC", Offset = "0x3026EDC", VA = "0x3026EDC")]
	private void OnExchangeBtnClick()
	{
	}

	[Token(Token = "0x6009376")]
	[Address(RVA = "0x3026F84", Offset = "0x3026F84", VA = "0x3026F84", Slot = "51")]
	public virtual void RefreshData(CustomEventStoreCommodityDesc data)
	{
	}

	[Token(Token = "0x6009377")]
	[Address(RVA = "0x30274EC", Offset = "0x30274EC", VA = "0x30274EC")]
	private void SetExchangeIcon(UISprite sprite)
	{
	}

	[Token(Token = "0x6009378")]
	[Address(RVA = "0x3027668", Offset = "0x3027668", VA = "0x3027668")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009379")]
	[Address(RVA = "0x3027670", Offset = "0x3027670", VA = "0x3027670")]
	public int _003C_003EiFixBaseProxy_get_ItemCount()
	{
		return default(int);
	}

	[Token(Token = "0x600937A")]
	[Address(RVA = "0x3027678", Offset = "0x3027678", VA = "0x3027678")]
	public void _003C_003EiFixBaseProxy_set_ItemCount(int P0)
	{
	}
}
