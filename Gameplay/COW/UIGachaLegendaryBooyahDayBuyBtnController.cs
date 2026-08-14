using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002108")]
public class UIGachaLegendaryBooyahDayBuyBtnController : UIGachaBuyBtnController
{
	[Token(Token = "0x400CEAA")]
	[FieldOffset(Offset = "0x38")]
	private UIGachaLegendaryBooyahDayBuyBtnView m_LegendaryBuyBtnView;

	[Token(Token = "0x400CEAB")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_GachaID;

	[Token(Token = "0x400CEAC")]
	[FieldOffset(Offset = "0x40")]
	private GachaDesc m_Desc;

	[Token(Token = "0x600ABF9")]
	[Address(RVA = "0x248B60C", Offset = "0x248B60C", VA = "0x248B60C")]
	public UIGachaLegendaryBooyahDayBuyBtnController()
	{
	}

	[Token(Token = "0x600ABFA")]
	[Address(RVA = "0x248B614", Offset = "0x248B614", VA = "0x248B614")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ABFB")]
	[Address(RVA = "0x248B6B8", Offset = "0x248B6B8", VA = "0x248B6B8", Slot = "31")]
	protected override void InitBuyBtnBaseView()
	{
	}

	[Token(Token = "0x600ABFC")]
	[Address(RVA = "0x248B72C", Offset = "0x248B72C", VA = "0x248B72C")]
	public void RefreshPurchaseInfo(uint gachaID)
	{
	}

	[Token(Token = "0x600ABFD")]
	[Address(RVA = "0x248B7B8", Offset = "0x248B7B8", VA = "0x248B7B8", Slot = "32")]
	public override bool OnBeforeSingleBuy(bool isRepurchase)
	{
		return default(bool);
	}

	[Token(Token = "0x600ABFE")]
	[Address(RVA = "0x248B998", Offset = "0x248B998", VA = "0x248B998", Slot = "33")]
	public override bool OnBeforeMultiBuy(bool isRepurchase)
	{
		return default(bool);
	}

	[Token(Token = "0x600ABFF")]
	[Address(RVA = "0x248BB78", Offset = "0x248BB78", VA = "0x248BB78", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AC00")]
	[Address(RVA = "0x248BC34", Offset = "0x248BC34", VA = "0x248BC34", Slot = "39")]
	public override void PurchaseSingle(uint chestID, UIModelGacha.GachaDrawType type, bool isRepurchase = false)
	{
	}

	[Token(Token = "0x600AC01")]
	[Address(RVA = "0x248BE44", Offset = "0x248BE44", VA = "0x248BE44", Slot = "40")]
	public override void PurchaseMulti(uint chestID, UIModelGacha.GachaDrawType type, bool isRepurchase = false)
	{
	}

	[Token(Token = "0x600AC02")]
	[Address(RVA = "0x248C054", Offset = "0x248C054", VA = "0x248C054")]
	public bool _003C_003EiFixBaseProxy_OnBeforeSingleBuy(bool P0)
	{
		return default(bool);
	}

	[Token(Token = "0x600AC03")]
	[Address(RVA = "0x248C05C", Offset = "0x248C05C", VA = "0x248C05C")]
	public bool _003C_003EiFixBaseProxy_OnBeforeMultiBuy(bool P0)
	{
		return default(bool);
	}

	[Token(Token = "0x600AC04")]
	[Address(RVA = "0x248C064", Offset = "0x248C064", VA = "0x248C064")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AC05")]
	[Address(RVA = "0x248C06C", Offset = "0x248C06C", VA = "0x248C06C")]
	public void _003C_003EiFixBaseProxy_PurchaseSingle(uint P0, UIModelGacha.GachaDrawType P1, bool P2)
	{
	}

	[Token(Token = "0x600AC06")]
	[Address(RVA = "0x248C08C", Offset = "0x248C08C", VA = "0x248C08C")]
	public void _003C_003EiFixBaseProxy_PurchaseMulti(uint P0, UIModelGacha.GachaDrawType P1, bool P2)
	{
	}
}
