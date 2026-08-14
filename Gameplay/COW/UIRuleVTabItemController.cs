using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002319")]
internal class UIRuleVTabItemController : UIEasyListItemController
{
	[Token(Token = "0x400DAD9")]
	[FieldOffset(Offset = "0x38")]
	private UIRuleVTabItemView m_View;

	[Token(Token = "0x400DADA")]
	[FieldOffset(Offset = "0x3C")]
	private UIModeEditPanelController.TabData m_Data;

	[Token(Token = "0x600C24E")]
	[Address(RVA = "0x1429A18", Offset = "0x1429A18", VA = "0x1429A18")]
	public UIRuleVTabItemController()
	{
	}

	[Token(Token = "0x600C24F")]
	[Address(RVA = "0x1429A20", Offset = "0x1429A20", VA = "0x1429A20")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C250")]
	[Address(RVA = "0x1429AC8", Offset = "0x1429AC8", VA = "0x1429AC8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C251")]
	[Address(RVA = "0x1429C24", Offset = "0x1429C24", VA = "0x1429C24", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600C252")]
	[Address(RVA = "0x1429E70", Offset = "0x1429E70", VA = "0x1429E70", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600C253")]
	[Address(RVA = "0x142A0D4", Offset = "0x142A0D4", VA = "0x142A0D4", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600C254")]
	[Address(RVA = "0x142A220", Offset = "0x142A220", VA = "0x142A220")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C255")]
	[Address(RVA = "0x142A228", Offset = "0x142A228", VA = "0x142A228")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600C256")]
	[Address(RVA = "0x142A230", Offset = "0x142A230", VA = "0x142A230")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
