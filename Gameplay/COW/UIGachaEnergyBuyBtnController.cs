using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002638")]
public class UIGachaEnergyBuyBtnController : UIGachaBuyBtnController
{
	[Token(Token = "0x400EC02")]
	[FieldOffset(Offset = "0x38")]
	private UIGachaEnergyBuyBtnView m_EnergyView;

	[Token(Token = "0x600E39A")]
	[Address(RVA = "0x24734B0", Offset = "0x24734B0", VA = "0x24734B0")]
	public UIGachaEnergyBuyBtnController()
	{
	}

	[Token(Token = "0x600E39B")]
	[Address(RVA = "0x24734B8", Offset = "0x24734B8", VA = "0x24734B8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E39C")]
	[Address(RVA = "0x247355C", Offset = "0x247355C", VA = "0x247355C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E39D")]
	[Address(RVA = "0x2473618", Offset = "0x2473618", VA = "0x2473618", Slot = "31")]
	protected override void InitBuyBtnBaseView()
	{
	}

	[Token(Token = "0x600E39E")]
	[Address(RVA = "0x247368C", Offset = "0x247368C", VA = "0x247368C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
