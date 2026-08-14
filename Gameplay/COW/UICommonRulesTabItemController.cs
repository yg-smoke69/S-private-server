using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002594")]
public class UICommonRulesTabItemController : UIEasyListItemController
{
	[Token(Token = "0x400E894")]
	[FieldOffset(Offset = "0x38")]
	private UICommonRulesTabItemView m_View;

	[Token(Token = "0x400E895")]
	[FieldOffset(Offset = "0x3C")]
	private RuleMapping m_Rule;

	[Token(Token = "0x600DC06")]
	[Address(RVA = "0x1EB29D0", Offset = "0x1EB29D0", VA = "0x1EB29D0")]
	public UICommonRulesTabItemController()
	{
	}

	[Token(Token = "0x600DC07")]
	[Address(RVA = "0x1EB29D8", Offset = "0x1EB29D8", VA = "0x1EB29D8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DC08")]
	[Address(RVA = "0x1EB2A7C", Offset = "0x1EB2A7C", VA = "0x1EB2A7C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DC09")]
	[Address(RVA = "0x1EB2BD8", Offset = "0x1EB2BD8", VA = "0x1EB2BD8", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600DC0A")]
	[Address(RVA = "0x1EB2E24", Offset = "0x1EB2E24", VA = "0x1EB2E24", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600DC0B")]
	[Address(RVA = "0x1EB3088", Offset = "0x1EB3088", VA = "0x1EB3088", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600DC0C")]
	[Address(RVA = "0x1EB31D4", Offset = "0x1EB31D4", VA = "0x1EB31D4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DC0D")]
	[Address(RVA = "0x1EB31DC", Offset = "0x1EB31DC", VA = "0x1EB31DC")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600DC0E")]
	[Address(RVA = "0x1EB31E4", Offset = "0x1EB31E4", VA = "0x1EB31E4")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
