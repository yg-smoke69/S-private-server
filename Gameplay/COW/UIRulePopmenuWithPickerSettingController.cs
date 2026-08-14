using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200230A")]
internal class UIRulePopmenuWithPickerSettingController : UIBaseController
{
	[Token(Token = "0x400DA99")]
	[FieldOffset(Offset = "0x28")]
	private UIRulePopmenuWithPickerSettingV2View m_View;

	[Token(Token = "0x400DA9A")]
	[FieldOffset(Offset = "0x2C")]
	public CPopMenuData Data;

	[Token(Token = "0x400DA9B")]
	[FieldOffset(Offset = "0x30")]
	public UIModeEditGeneralComponentHelper GeneralHelper;

	[Token(Token = "0x400DA9C")]
	[FieldOffset(Offset = "0x34")]
	private UIPopMenuSmallControler m_PopMenu;

	[Token(Token = "0x400DA9D")]
	[FieldOffset(Offset = "0x38")]
	private List<PopMenuData> m_PopMenuList;

	[Token(Token = "0x400DA9E")]
	[FieldOffset(Offset = "0x3C")]
	private string m_CurrentSelection;

	[Token(Token = "0x600C1A0")]
	[Address(RVA = "0x2BFAFC4", Offset = "0x2BFAFC4", VA = "0x2BFAFC4")]
	public UIRulePopmenuWithPickerSettingController()
	{
	}

	[Token(Token = "0x600C1A1")]
	[Address(RVA = "0x2BFB07C", Offset = "0x2BFB07C", VA = "0x2BFB07C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C1A2")]
	[Address(RVA = "0x2BFB124", Offset = "0x2BFB124", VA = "0x2BFB124", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C1A3")]
	[Address(RVA = "0x2BFB318", Offset = "0x2BFB318", VA = "0x2BFB318", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C1A4")]
	[Address(RVA = "0x2BFB570", Offset = "0x2BFB570", VA = "0x2BFB570")]
	public void SetViewData(CPopMenuData data, float width)
	{
	}

	[Token(Token = "0x600C1A5")]
	[Address(RVA = "0x2BFC0EC", Offset = "0x2BFC0EC", VA = "0x2BFC0EC")]
	private void GeneratePopList()
	{
	}

	[Token(Token = "0x600C1A6")]
	[Address(RVA = "0x2BFC4B0", Offset = "0x2BFC4B0", VA = "0x2BFC4B0")]
	private void SelectItemCallback(object data)
	{
	}

	[Token(Token = "0x600C1A7")]
	[Address(RVA = "0x2BFC5B0", Offset = "0x2BFC5B0", VA = "0x2BFC5B0")]
	private void SetValue(int newValue)
	{
	}

	[Token(Token = "0x600C1A8")]
	[Address(RVA = "0x2BFC6C8", Offset = "0x2BFC6C8", VA = "0x2BFC6C8")]
	private int GetValueAsIndex()
	{
		return default(int);
	}

	[Token(Token = "0x600C1A9")]
	[Address(RVA = "0x2BFC7EC", Offset = "0x2BFC7EC", VA = "0x2BFC7EC")]
	private int CheckAndFixIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x600C1AA")]
	[Address(RVA = "0x2BFBDF0", Offset = "0x2BFBDF0", VA = "0x2BFBDF0")]
	protected void OnValueChanged()
	{
	}

	[Token(Token = "0x600C1AB")]
	[Address(RVA = "0x2BFC90C", Offset = "0x2BFC90C", VA = "0x2BFC90C")]
	protected void OnItemsChanged()
	{
	}

	[Token(Token = "0x600C1AC")]
	[Address(RVA = "0x2BFCD08", Offset = "0x2BFCD08", VA = "0x2BFCD08")]
	public void OnClickPickButton()
	{
	}

	[Token(Token = "0x600C1AD")]
	[Address(RVA = "0x2BFCFFC", Offset = "0x2BFCFFC", VA = "0x2BFCFFC")]
	public void OnGetEntityChange(SceneEditObjectBase obj)
	{
	}

	[Token(Token = "0x600C1AE")]
	[Address(RVA = "0x2BFD134", Offset = "0x2BFD134", VA = "0x2BFD134")]
	private bool _003CGetValueAsIndex_003Em__0(CPopMenuData.PopMenuItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x600C1AF")]
	[Address(RVA = "0x2BFD1BC", Offset = "0x2BFD1BC", VA = "0x2BFD1BC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C1B0")]
	[Address(RVA = "0x2BFD1C4", Offset = "0x2BFD1C4", VA = "0x2BFD1C4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
