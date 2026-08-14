using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F06")]
internal class UIDigitalUniverseBStoreAwardItemController : UIBaseController
{
	[Token(Token = "0x400C33E")]
	[FieldOffset(Offset = "0x28")]
	private UIDigitalUniverseBStoreAwardItemView m_View;

	[Token(Token = "0x400C33F")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelBigEvent m_ModelBigEvent;

	[Token(Token = "0x400C340")]
	[FieldOffset(Offset = "0x30")]
	private DigitaluniverseBStoreRecommendDesc m_StoreRecommendDesc;

	[Token(Token = "0x400C341")]
	[FieldOffset(Offset = "0x34")]
	private UIStandardItemMiniController m_SpecialAwardItem;

	[Token(Token = "0x60097DA")]
	[Address(RVA = "0x2D860CC", Offset = "0x2D860CC", VA = "0x2D860CC")]
	public UIDigitalUniverseBStoreAwardItemController()
	{
	}

	[Token(Token = "0x60097DB")]
	[Address(RVA = "0x2D86150", Offset = "0x2D86150", VA = "0x2D86150")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60097DC")]
	[Address(RVA = "0x2D861F8", Offset = "0x2D861F8", VA = "0x2D861F8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60097DD")]
	[Address(RVA = "0x2D863C4", Offset = "0x2D863C4", VA = "0x2D863C4")]
	public ELimitedEvent.EventID GetBigEventId()
	{
		return default(ELimitedEvent.EventID);
	}

	[Token(Token = "0x60097DE")]
	[Address(RVA = "0x2D8641C", Offset = "0x2D8641C", VA = "0x2D8641C")]
	public void SetData(DigitaluniverseBStoreRecommendDesc storeDesc)
	{
	}

	[Token(Token = "0x60097DF")]
	[Address(RVA = "0x2D86DA8", Offset = "0x2D86DA8", VA = "0x2D86DA8")]
	private void OnBtnGoToClick()
	{
	}

	[Token(Token = "0x60097E0")]
	[Address(RVA = "0x2D87054", Offset = "0x2D87054", VA = "0x2D87054")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
