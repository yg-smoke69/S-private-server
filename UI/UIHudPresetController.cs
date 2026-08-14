using System.Collections.Generic;
using COW;
using GCommon;
using Il2CppDummyDll;
using message;

[Token(Token = "0x2002812")]
internal class UIHudPresetController : UIBaseController
{
	[Token(Token = "0x400F762")]
	[FieldOffset(Offset = "0x28")]
	public int IndexSelected;

	[Token(Token = "0x400F763")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudPresetView m_View;

	[Token(Token = "0x400F764")]
	[FieldOffset(Offset = "0x30")]
	private List<UIHudPresetItemController> m_ItemList;

	[Token(Token = "0x400F765")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<int, List<HOHACEOICHK>> m_DataList;

	[Token(Token = "0x400F766")]
	[FieldOffset(Offset = "0x38")]
	private bool m_Init;

	[Token(Token = "0x600F971")]
	[Address(RVA = "0x1486208", Offset = "0x1486208", VA = "0x1486208")]
	public UIHudPresetController()
	{
	}

	[Token(Token = "0x600F972")]
	[Address(RVA = "0x14862F4", Offset = "0x14862F4", VA = "0x14862F4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F973")]
	[Address(RVA = "0x148635C", Offset = "0x148635C", VA = "0x148635C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F974")]
	[Address(RVA = "0x1486618", Offset = "0x1486618", VA = "0x1486618", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600F975")]
	[Address(RVA = "0x1486620", Offset = "0x1486620", VA = "0x1486620")]
	public void SetViewData(JGCALMFCGOP data)
	{
	}

	[Token(Token = "0x600F976")]
	[Address(RVA = "0x1486EF8", Offset = "0x1486EF8", VA = "0x1486EF8")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600F977")]
	[Address(RVA = "0x1486EFC", Offset = "0x1486EFC", VA = "0x1486EFC")]
	private void OnConfirmBtnClick()
	{
	}

	[Token(Token = "0x600F978")]
	[Address(RVA = "0x14870F4", Offset = "0x14870F4", VA = "0x14870F4")]
	private void OnRefreshBtnClick()
	{
	}

	[Token(Token = "0x600F979")]
	[Address(RVA = "0x14871AC", Offset = "0x14871AC", VA = "0x14871AC")]
	private void OnShowPresetRefreshCount(object[] data)
	{
	}
}
