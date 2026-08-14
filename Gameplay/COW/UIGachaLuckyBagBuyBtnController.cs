using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002667")]
public class UIGachaLuckyBagBuyBtnController : UIGachaBuyBtnController
{
	[Token(Token = "0x400ED29")]
	[FieldOffset(Offset = "0x38")]
	private UIGachaLuckyBagBuyBtnView m_LuckyBagView;

	[Token(Token = "0x600E5B2")]
	[Address(RVA = "0x2A177FC", Offset = "0x2A177FC", VA = "0x2A177FC")]
	public UIGachaLuckyBagBuyBtnController()
	{
	}

	[Token(Token = "0x600E5B3")]
	[Address(RVA = "0x2A17804", Offset = "0x2A17804", VA = "0x2A17804")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E5B4")]
	[Address(RVA = "0x2A178A8", Offset = "0x2A178A8", VA = "0x2A178A8", Slot = "31")]
	protected override void InitBuyBtnBaseView()
	{
	}

	[Token(Token = "0x600E5B5")]
	[Address(RVA = "0x2A1791C", Offset = "0x2A1791C", VA = "0x2A1791C", Slot = "32")]
	public override bool OnBeforeSingleBuy(bool isRepurchase)
	{
		return default(bool);
	}

	[Token(Token = "0x600E5B6")]
	[Address(RVA = "0x2A17DE4", Offset = "0x2A17DE4", VA = "0x2A17DE4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E5B7")]
	[Address(RVA = "0x2A17EA0", Offset = "0x2A17EA0", VA = "0x2A17EA0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E5B8")]
	[Address(RVA = "0x2A17F04", Offset = "0x2A17F04", VA = "0x2A17F04", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E5B9")]
	[Address(RVA = "0x2A17AD0", Offset = "0x2A17AD0", VA = "0x2A17AD0")]
	private bool IsAllRewardsOwned()
	{
		return default(bool);
	}

	[Token(Token = "0x600E5BA")]
	[Address(RVA = "0x2A17F68", Offset = "0x2A17F68", VA = "0x2A17F68")]
	public bool _003C_003EiFixBaseProxy_OnBeforeSingleBuy(bool P0)
	{
		return default(bool);
	}

	[Token(Token = "0x600E5BB")]
	[Address(RVA = "0x2A17F70", Offset = "0x2A17F70", VA = "0x2A17F70")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E5BC")]
	[Address(RVA = "0x2A17F78", Offset = "0x2A17F78", VA = "0x2A17F78")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E5BD")]
	[Address(RVA = "0x2A17F80", Offset = "0x2A17F80", VA = "0x2A17F80")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
