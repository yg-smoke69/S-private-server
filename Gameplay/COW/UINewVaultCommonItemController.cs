using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029F2")]
public class UINewVaultCommonItemController : UIEasyListItemController
{
	[Token(Token = "0x40101FC")]
	[FieldOffset(Offset = "0x38")]
	protected UINewVaultCommonItemView m_View;

	[Token(Token = "0x40101FD")]
	[FieldOffset(Offset = "0x3C")]
	protected UINewVaultItemViewData m_data;

	[Token(Token = "0x40101FE")]
	[FieldOffset(Offset = "0x40")]
	protected UIStandardItemMAXBController m_standardItemCtrl;

	[Token(Token = "0x6010E7B")]
	[Address(RVA = "0x2C01A74", Offset = "0x2C01A74", VA = "0x2C01A74")]
	public UINewVaultCommonItemController()
	{
	}

	[Token(Token = "0x6010E7C")]
	[Address(RVA = "0x2C01A7C", Offset = "0x2C01A7C", VA = "0x2C01A7C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010E7D")]
	[Address(RVA = "0x2C01B24", Offset = "0x2C01B24", VA = "0x2C01B24")]
	protected bool IsClothItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6010E7E")]
	[Address(RVA = "0x2C01BB8", Offset = "0x2C01BB8", VA = "0x2C01BB8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010E7F")]
	[Address(RVA = "0x2C01EB4", Offset = "0x2C01EB4", VA = "0x2C01EB4", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x6010E80")]
	[Address(RVA = "0x2C01FFC", Offset = "0x2C01FFC", VA = "0x2C01FFC", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x6010E81")]
	[Address(RVA = "0x2C02084", Offset = "0x2C02084", VA = "0x2C02084", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6010E82")]
	[Address(RVA = "0x2C02850", Offset = "0x2C02850", VA = "0x2C02850")]
	public void RefreshABReady()
	{
	}

	[Token(Token = "0x6010E83")]
	[Address(RVA = "0x2C02510", Offset = "0x2C02510", VA = "0x2C02510")]
	private void SetRankingItemIcon()
	{
	}

	[Token(Token = "0x6010E84")]
	[Address(RVA = "0x2C029A4", Offset = "0x2C029A4", VA = "0x2C029A4", Slot = "37")]
	public virtual void RefreshEquipState()
	{
	}

	[Token(Token = "0x6010E85")]
	[Address(RVA = "0x2C02A74", Offset = "0x2C02A74", VA = "0x2C02A74")]
	public void RefreshNewGetState()
	{
	}

	[Token(Token = "0x6010E86")]
	[Address(RVA = "0x2C02BEC", Offset = "0x2C02BEC", VA = "0x2C02BEC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010E87")]
	[Address(RVA = "0x2C02BF4", Offset = "0x2C02BF4", VA = "0x2C02BF4")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x6010E88")]
	[Address(RVA = "0x2C02BFC", Offset = "0x2C02BFC", VA = "0x2C02BFC")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
