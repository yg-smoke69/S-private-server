using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002309")]
internal class UIRulePopmenuSettingV2Controller : UIBaseController
{
	[Token(Token = "0x400DA93")]
	[FieldOffset(Offset = "0x28")]
	private UIRulePopmenuSettingV2View m_View;

	[Token(Token = "0x400DA94")]
	[FieldOffset(Offset = "0x2C")]
	public CPopMenuData Data;

	[Token(Token = "0x400DA95")]
	[FieldOffset(Offset = "0x30")]
	public UIModeEditGeneralComponentHelper GeneralHelper;

	[Token(Token = "0x400DA96")]
	[FieldOffset(Offset = "0x34")]
	private UIPopMenuSmallControler m_PopMenu;

	[Token(Token = "0x400DA97")]
	[FieldOffset(Offset = "0x38")]
	private List<PopMenuData> m_PopMenuList;

	[Token(Token = "0x400DA98")]
	[FieldOffset(Offset = "0x3C")]
	private string m_CurrentSelection;

	[Token(Token = "0x600C18D")]
	[Address(RVA = "0x2BF8FF0", Offset = "0x2BF8FF0", VA = "0x2BF8FF0")]
	public UIRulePopmenuSettingV2Controller()
	{
	}

	[Token(Token = "0x600C18E")]
	[Address(RVA = "0x2BF90A8", Offset = "0x2BF90A8", VA = "0x2BF90A8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C18F")]
	[Address(RVA = "0x2BF9150", Offset = "0x2BF9150", VA = "0x2BF9150", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C190")]
	[Address(RVA = "0x2BF92A4", Offset = "0x2BF92A4", VA = "0x2BF92A4", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600C191")]
	[Address(RVA = "0x2BF9308", Offset = "0x2BF9308", VA = "0x2BF9308", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600C192")]
	[Address(RVA = "0x2BF936C", Offset = "0x2BF936C", VA = "0x2BF936C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C193")]
	[Address(RVA = "0x2BF95C4", Offset = "0x2BF95C4", VA = "0x2BF95C4")]
	public void SetViewData(CPopMenuData data, float width)
	{
	}

	[Token(Token = "0x600C194")]
	[Address(RVA = "0x2BFA114", Offset = "0x2BFA114", VA = "0x2BFA114")]
	private void GeneratePopList()
	{
	}

	[Token(Token = "0x600C195")]
	[Address(RVA = "0x2BFA4D8", Offset = "0x2BFA4D8", VA = "0x2BFA4D8")]
	private void SelectItemCallback(object data)
	{
	}

	[Token(Token = "0x600C196")]
	[Address(RVA = "0x2BFA5E0", Offset = "0x2BFA5E0", VA = "0x2BFA5E0")]
	private void SetValue(int newValue)
	{
	}

	[Token(Token = "0x600C197")]
	[Address(RVA = "0x2BFA6F8", Offset = "0x2BFA6F8", VA = "0x2BFA6F8")]
	private int GetValueAsIndex()
	{
		return default(int);
	}

	[Token(Token = "0x600C198")]
	[Address(RVA = "0x2BFA81C", Offset = "0x2BFA81C", VA = "0x2BFA81C")]
	private int CheckAndFixIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x600C199")]
	[Address(RVA = "0x2BF9F64", Offset = "0x2BF9F64", VA = "0x2BF9F64")]
	protected void OnValueChanged()
	{
	}

	[Token(Token = "0x600C19A")]
	[Address(RVA = "0x2BFA93C", Offset = "0x2BFA93C", VA = "0x2BFA93C")]
	protected void OnItemsChanged()
	{
	}

	[Token(Token = "0x600C19B")]
	[Address(RVA = "0x2BFABE4", Offset = "0x2BFABE4", VA = "0x2BFABE4")]
	private bool _003CGetValueAsIndex_003Em__0(CPopMenuData.PopMenuItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x600C19C")]
	[Address(RVA = "0x2BFAC6C", Offset = "0x2BFAC6C", VA = "0x2BFAC6C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C19D")]
	[Address(RVA = "0x2BFAC74", Offset = "0x2BFAC74", VA = "0x2BFAC74")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600C19E")]
	[Address(RVA = "0x2BFAC7C", Offset = "0x2BFAC7C", VA = "0x2BFAC7C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600C19F")]
	[Address(RVA = "0x2BFAC84", Offset = "0x2BFAC84", VA = "0x2BFAC84")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
