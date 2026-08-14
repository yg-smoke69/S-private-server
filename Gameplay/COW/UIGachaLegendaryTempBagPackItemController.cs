using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002647")]
public class UIGachaLegendaryTempBagPackItemController : UIEasyListItemController
{
	[Token(Token = "0x400EC6D")]
	[FieldOffset(Offset = "0x38")]
	public bool QuickSelect;

	[Token(Token = "0x400EC6E")]
	[FieldOffset(Offset = "0x3C")]
	public int RealIndex;

	[Token(Token = "0x400EC6F")]
	[FieldOffset(Offset = "0x40")]
	public GachaShowItem Data;

	[Token(Token = "0x400EC70")]
	[FieldOffset(Offset = "0x44")]
	private UIGachaLegendaryTempBagPackItemView m_View;

	[Token(Token = "0x400EC71")]
	[FieldOffset(Offset = "0x48")]
	private UIGachaShowRewardItemController m_GachaShowRewardItem;

	[Token(Token = "0x600E459")]
	[Address(RVA = "0x2E69094", Offset = "0x2E69094", VA = "0x2E69094")]
	public UIGachaLegendaryTempBagPackItemController()
	{
	}

	[Token(Token = "0x600E45A")]
	[Address(RVA = "0x2E690A4", Offset = "0x2E690A4", VA = "0x2E690A4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E45B")]
	[Address(RVA = "0x2E69148", Offset = "0x2E69148", VA = "0x2E69148", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E45C")]
	[Address(RVA = "0x2E692A4", Offset = "0x2E692A4", VA = "0x2E692A4")]
	public void SetToggleValue(bool v)
	{
	}

	[Token(Token = "0x600E45D")]
	[Address(RVA = "0x2E6933C", Offset = "0x2E6933C", VA = "0x2E6933C")]
	public void OnRefreshToggleValue()
	{
	}

	[Token(Token = "0x600E45E")]
	[Address(RVA = "0x2E694C4", Offset = "0x2E694C4", VA = "0x2E694C4")]
	public void OnToggleSelected()
	{
	}

	[Token(Token = "0x600E45F")]
	[Address(RVA = "0x2E6A770", Offset = "0x2E6A770", VA = "0x2E6A770", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600E460")]
	[Address(RVA = "0x2E6AA2C", Offset = "0x2E6AA2C", VA = "0x2E6AA2C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
