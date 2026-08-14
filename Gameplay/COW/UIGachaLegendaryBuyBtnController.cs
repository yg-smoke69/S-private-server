using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200264D")]
public class UIGachaLegendaryBuyBtnController : UIGachaBuyBtnController
{
	[Token(Token = "0x400EC84")]
	[FieldOffset(Offset = "0x38")]
	private UIGachaLegendaryBuyBtnView m_LegendaryBuyBtnView;

	[Token(Token = "0x400EC85")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_GachaID;

	[Token(Token = "0x400EC86")]
	[FieldOffset(Offset = "0x40")]
	private GachaDesc m_Desc;

	[Token(Token = "0x600E48D")]
	[Address(RVA = "0x248C2C4", Offset = "0x248C2C4", VA = "0x248C2C4")]
	public UIGachaLegendaryBuyBtnController()
	{
	}

	[Token(Token = "0x600E48E")]
	[Address(RVA = "0x248C2CC", Offset = "0x248C2CC", VA = "0x248C2CC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E48F")]
	[Address(RVA = "0x248C370", Offset = "0x248C370", VA = "0x248C370", Slot = "31")]
	protected override void InitBuyBtnBaseView()
	{
	}

	[Token(Token = "0x600E490")]
	[Address(RVA = "0x248C3E4", Offset = "0x248C3E4", VA = "0x248C3E4")]
	public void RefreshPurchaseInfo(uint gachaID)
	{
	}

	[Token(Token = "0x600E491")]
	[Address(RVA = "0x248C470", Offset = "0x248C470", VA = "0x248C470", Slot = "32")]
	public override bool OnBeforeSingleBuy(bool isRepurchase)
	{
		return default(bool);
	}

	[Token(Token = "0x600E492")]
	[Address(RVA = "0x248C678", Offset = "0x248C678", VA = "0x248C678", Slot = "33")]
	public override bool OnBeforeMultiBuy(bool isRepurchase)
	{
		return default(bool);
	}

	[Token(Token = "0x600E493")]
	[Address(RVA = "0x248C880", Offset = "0x248C880", VA = "0x248C880", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E494")]
	[Address(RVA = "0x248C93C", Offset = "0x248C93C", VA = "0x248C93C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E495")]
	[Address(RVA = "0x248C9A0", Offset = "0x248C9A0", VA = "0x248C9A0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E496")]
	[Address(RVA = "0x248CA04", Offset = "0x248CA04", VA = "0x248CA04")]
	public bool _003C_003EiFixBaseProxy_OnBeforeSingleBuy(bool P0)
	{
		return default(bool);
	}

	[Token(Token = "0x600E497")]
	[Address(RVA = "0x248CA0C", Offset = "0x248CA0C", VA = "0x248CA0C")]
	public bool _003C_003EiFixBaseProxy_OnBeforeMultiBuy(bool P0)
	{
		return default(bool);
	}

	[Token(Token = "0x600E498")]
	[Address(RVA = "0x248CA14", Offset = "0x248CA14", VA = "0x248CA14")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E499")]
	[Address(RVA = "0x248CA1C", Offset = "0x248CA1C", VA = "0x248CA1C")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E49A")]
	[Address(RVA = "0x248CA24", Offset = "0x248CA24", VA = "0x248CA24")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
