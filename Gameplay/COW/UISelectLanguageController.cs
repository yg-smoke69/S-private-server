using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B17")]
public class UISelectLanguageController : UIPopupWindowController
{
	[Token(Token = "0x401085A")]
	[FieldOffset(Offset = "0x48")]
	private UISelectLanguageView m_View;

	[Token(Token = "0x401085B")]
	[FieldOffset(Offset = "0x4C")]
	private LocLang m_SelectedLan;

	[Token(Token = "0x401085C")]
	[FieldOffset(Offset = "0x50")]
	private List<UISelectLangItemController> m_ToggleItemList;

	[Token(Token = "0x6011B60")]
	[Address(RVA = "0x1A51EEC", Offset = "0x1A51EEC", VA = "0x1A51EEC")]
	public UISelectLanguageController()
	{
	}

	[Token(Token = "0x6011B61")]
	[Address(RVA = "0x1A51F78", Offset = "0x1A51F78", VA = "0x1A51F78")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011B62")]
	[Address(RVA = "0x1A5201C", Offset = "0x1A5201C", VA = "0x1A5201C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011B63")]
	[Address(RVA = "0x1A521EC", Offset = "0x1A521EC", VA = "0x1A521EC")]
	public void HideBtnUI()
	{
	}

	[Token(Token = "0x6011B64")]
	[Address(RVA = "0x1A522F4", Offset = "0x1A522F4", VA = "0x1A522F4")]
	private void OnLocLanConfirm()
	{
	}

	[Token(Token = "0x6011B65")]
	[Address(RVA = "0x1A526EC", Offset = "0x1A526EC", VA = "0x1A526EC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6011B66")]
	[Address(RVA = "0x1A527B8", Offset = "0x1A527B8", VA = "0x1A527B8")]
	public void SetUnLimitedData(PopMenuData data, int GroupID)
	{
	}

	[Token(Token = "0x6011B67")]
	[Address(RVA = "0x1A52990", Offset = "0x1A52990", VA = "0x1A52990")]
	public void SetDatas(List<PopMenuData> dataList, int GroupID)
	{
	}

	[Token(Token = "0x6011B68")]
	[Address(RVA = "0x1A52BCC", Offset = "0x1A52BCC", VA = "0x1A52BCC")]
	private void ReFreshToggles()
	{
	}

	[Token(Token = "0x6011B69")]
	[Address(RVA = "0x1A52D00", Offset = "0x1A52D00", VA = "0x1A52D00")]
	public void SetLanSelect(LocLang lan)
	{
	}

	[Token(Token = "0x6011B6A")]
	[Address(RVA = "0x1A52D60", Offset = "0x1A52D60", VA = "0x1A52D60")]
	private void _003COnLocLanConfirm_003Em__0()
	{
	}

	[Token(Token = "0x6011B6B")]
	[Address(RVA = "0x1A52EBC", Offset = "0x1A52EBC", VA = "0x1A52EBC")]
	private void _003COnLocLanConfirm_003Em__1()
	{
	}

	[Token(Token = "0x6011B6C")]
	[Address(RVA = "0x1A52F48", Offset = "0x1A52F48", VA = "0x1A52F48")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011B6D")]
	[Address(RVA = "0x1A52F50", Offset = "0x1A52F50", VA = "0x1A52F50")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
