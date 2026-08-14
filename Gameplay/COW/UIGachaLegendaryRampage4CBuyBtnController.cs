using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200210F")]
internal class UIGachaLegendaryRampage4CBuyBtnController : UIGachaBuyBtnController
{
	[Token(Token = "0x400CEFE")]
	[FieldOffset(Offset = "0x38")]
	private UIGachaLegendaryRampage4CBuyBtnView m_LegendaryBuyBtnView;

	[Token(Token = "0x400CEFF")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_GachaID;

	[Token(Token = "0x400CF00")]
	[FieldOffset(Offset = "0x40")]
	private GachaDesc m_Desc;

	[Token(Token = "0x600AC83")]
	[Address(RVA = "0x248CC44", Offset = "0x248CC44", VA = "0x248CC44")]
	public UIGachaLegendaryRampage4CBuyBtnController()
	{
	}

	[Token(Token = "0x600AC84")]
	[Address(RVA = "0x248CC4C", Offset = "0x248CC4C", VA = "0x248CC4C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AC85")]
	[Address(RVA = "0x248CCF4", Offset = "0x248CCF4", VA = "0x248CCF4", Slot = "31")]
	protected override void InitBuyBtnBaseView()
	{
	}

	[Token(Token = "0x600AC86")]
	[Address(RVA = "0x248CD68", Offset = "0x248CD68", VA = "0x248CD68")]
	public void RefreshPurchaseInfo(uint gachaID)
	{
	}

	[Token(Token = "0x600AC87")]
	[Address(RVA = "0x248CDF4", Offset = "0x248CDF4", VA = "0x248CDF4", Slot = "32")]
	public override bool OnBeforeSingleBuy(bool isRepurchase)
	{
		return default(bool);
	}

	[Token(Token = "0x600AC88")]
	[Address(RVA = "0x248CFFC", Offset = "0x248CFFC", VA = "0x248CFFC", Slot = "33")]
	public override bool OnBeforeMultiBuy(bool isRepurchase)
	{
		return default(bool);
	}

	[Token(Token = "0x600AC89")]
	[Address(RVA = "0x248D204", Offset = "0x248D204", VA = "0x248D204", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AC8A")]
	[Address(RVA = "0x248D2C0", Offset = "0x248D2C0", VA = "0x248D2C0", Slot = "39")]
	public override void PurchaseSingle(uint chestID, UIModelGacha.GachaDrawType type, bool isRepurchase = false)
	{
	}

	[Token(Token = "0x600AC8B")]
	[Address(RVA = "0x248D4D0", Offset = "0x248D4D0", VA = "0x248D4D0", Slot = "40")]
	public override void PurchaseMulti(uint chestID, UIModelGacha.GachaDrawType type, bool isRepurchase = false)
	{
	}

	[Token(Token = "0x600AC8C")]
	[Address(RVA = "0x248D6E0", Offset = "0x248D6E0", VA = "0x248D6E0", Slot = "34")]
	protected override void ShowNormalPurchaseUI(GachaDesc desc, UIModelGacha.GachaDrawType type)
	{
	}

	[Token(Token = "0x600AC8D")]
	[Address(RVA = "0x248DA04", Offset = "0x248DA04", VA = "0x248DA04", Slot = "37")]
	protected override void ShowDiscountPurchaseUI(GachaDesc desc, UIModelGacha.GachaDrawType type)
	{
	}

	[Token(Token = "0x600AC8E")]
	[Address(RVA = "0x248E358", Offset = "0x248E358", VA = "0x248E358", Slot = "36")]
	protected override void ShowLimitPurchaseUI(GachaDesc desc, UIModelGacha.GachaDrawType type, uint chestID)
	{
	}

	[Token(Token = "0x600AC8F")]
	[Address(RVA = "0x248F5FC", Offset = "0x248F5FC", VA = "0x248F5FC")]
	public bool _003C_003EiFixBaseProxy_OnBeforeSingleBuy(bool P0)
	{
		return default(bool);
	}

	[Token(Token = "0x600AC90")]
	[Address(RVA = "0x248F604", Offset = "0x248F604", VA = "0x248F604")]
	public bool _003C_003EiFixBaseProxy_OnBeforeMultiBuy(bool P0)
	{
		return default(bool);
	}

	[Token(Token = "0x600AC91")]
	[Address(RVA = "0x248F60C", Offset = "0x248F60C", VA = "0x248F60C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AC92")]
	[Address(RVA = "0x248F614", Offset = "0x248F614", VA = "0x248F614")]
	public void _003C_003EiFixBaseProxy_PurchaseSingle(uint P0, UIModelGacha.GachaDrawType P1, bool P2)
	{
	}

	[Token(Token = "0x600AC93")]
	[Address(RVA = "0x248F634", Offset = "0x248F634", VA = "0x248F634")]
	public void _003C_003EiFixBaseProxy_PurchaseMulti(uint P0, UIModelGacha.GachaDrawType P1, bool P2)
	{
	}

	[Token(Token = "0x600AC94")]
	[Address(RVA = "0x248F654", Offset = "0x248F654", VA = "0x248F654")]
	public void _003C_003EiFixBaseProxy_ShowNormalPurchaseUI(GachaDesc P0, UIModelGacha.GachaDrawType P1)
	{
	}

	[Token(Token = "0x600AC95")]
	[Address(RVA = "0x248F65C", Offset = "0x248F65C", VA = "0x248F65C")]
	public void _003C_003EiFixBaseProxy_ShowDiscountPurchaseUI(GachaDesc P0, UIModelGacha.GachaDrawType P1)
	{
	}

	[Token(Token = "0x600AC96")]
	[Address(RVA = "0x248F664", Offset = "0x248F664", VA = "0x248F664")]
	public void _003C_003EiFixBaseProxy_ShowLimitPurchaseUI(GachaDesc P0, UIModelGacha.GachaDrawType P1, uint P2)
	{
	}
}
