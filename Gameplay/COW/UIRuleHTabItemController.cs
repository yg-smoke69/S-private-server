using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002304")]
internal class UIRuleHTabItemController : UIEasyListItemController
{
	[Token(Token = "0x400DA7C")]
	[FieldOffset(Offset = "0x38")]
	private UIRuleHTabItemView m_View;

	[Token(Token = "0x400DA7D")]
	[FieldOffset(Offset = "0x3C")]
	private UIRuleHTabsPanelController.TabData m_Data;

	[Token(Token = "0x600C159")]
	[Address(RVA = "0x2BF3BFC", Offset = "0x2BF3BFC", VA = "0x2BF3BFC")]
	public UIRuleHTabItemController()
	{
	}

	[Token(Token = "0x600C15A")]
	[Address(RVA = "0x2BF3C04", Offset = "0x2BF3C04", VA = "0x2BF3C04")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C15B")]
	[Address(RVA = "0x2BF3CAC", Offset = "0x2BF3CAC", VA = "0x2BF3CAC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C15C")]
	[Address(RVA = "0x2BF3E08", Offset = "0x2BF3E08", VA = "0x2BF3E08", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600C15D")]
	[Address(RVA = "0x2BF4054", Offset = "0x2BF4054", VA = "0x2BF4054", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600C15E")]
	[Address(RVA = "0x2BF4240", Offset = "0x2BF4240", VA = "0x2BF4240", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600C15F")]
	[Address(RVA = "0x2BF4314", Offset = "0x2BF4314", VA = "0x2BF4314")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C160")]
	[Address(RVA = "0x2BF431C", Offset = "0x2BF431C", VA = "0x2BF431C")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600C161")]
	[Address(RVA = "0x2BF4324", Offset = "0x2BF4324", VA = "0x2BF4324")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
