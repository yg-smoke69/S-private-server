using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A81")]
public class UIPreviewTestController2 : UIPreviewNavigationController
{
	[Token(Token = "0x401051B")]
	[FieldOffset(Offset = "0x7C")]
	private UIPreviewTestView m_View;

	[Token(Token = "0x401051C")]
	[FieldOffset(Offset = "0x80")]
	private UIPopMenuSmallControler m_PopMenuCtrl;

	[Token(Token = "0x401051D")]
	[FieldOffset(Offset = "0x84")]
	private string m_SelectedCategory;

	[Token(Token = "0x401051E")]
	[FieldOffset(Offset = "0x88")]
	private List<PopMenuData> m_MenuDatas;

	[Token(Token = "0x401051F")]
	[FieldOffset(Offset = "0x8C")]
	private List<string> m_Categories;

	[Token(Token = "0x4010520")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map10;

	[Token(Token = "0x60114E9")]
	[Address(RVA = "0xF010AC", Offset = "0xF010AC", VA = "0xF010AC")]
	public UIPreviewTestController2()
	{
	}

	[Token(Token = "0x60114EA")]
	[Address(RVA = "0xF01560", Offset = "0xF01560", VA = "0xF01560", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x60114EB")]
	[Address(RVA = "0xF015D0", Offset = "0xF015D0", VA = "0xF015D0", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x60114EC")]
	[Address(RVA = "0xF01628", Offset = "0xF01628", VA = "0xF01628")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60114ED")]
	[Address(RVA = "0xF016CC", Offset = "0xF016CC", VA = "0xF016CC", Slot = "44")]
	protected override bool IsAutoCalculatePreviewPanelSize()
	{
		return default(bool);
	}

	[Token(Token = "0x60114EE")]
	[Address(RVA = "0xF01724", Offset = "0xF01724", VA = "0xF01724", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60114EF")]
	[Address(RVA = "0xF01C14", Offset = "0xF01C14", VA = "0xF01C14")]
	private void GenerateCategoryList()
	{
	}

	[Token(Token = "0x60114F0")]
	[Address(RVA = "0xF01F40", Offset = "0xF01F40", VA = "0xF01F40")]
	private void OnCategorySelect(object obj)
	{
	}

	[Token(Token = "0x60114F1")]
	[Address(RVA = "0xF02718", Offset = "0xF02718", VA = "0xF02718", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x60114F2")]
	[Address(RVA = "0xF027A0", Offset = "0xF027A0", VA = "0xF027A0")]
	private void OnButtonClick()
	{
	}

	[Token(Token = "0x60114F3")]
	[Address(RVA = "0xF0288C", Offset = "0xF0288C", VA = "0xF0288C")]
	private void OnNextPreviewButtonClick()
	{
	}

	[Token(Token = "0x60114F4")]
	[Address(RVA = "0xF028E0", Offset = "0xF028E0", VA = "0xF028E0")]
	private void OnLeftButtonClick()
	{
	}

	[Token(Token = "0x60114F5")]
	[Address(RVA = "0xF02950", Offset = "0xF02950", VA = "0xF02950")]
	private void OnRightButtonClick()
	{
	}

	[Token(Token = "0x60114F6")]
	[Address(RVA = "0xF02B3C", Offset = "0xF02B3C", VA = "0xF02B3C")]
	private void OnCenterButtonClick()
	{
	}

	[Token(Token = "0x60114F7")]
	[Address(RVA = "0xF02BAC", Offset = "0xF02BAC", VA = "0xF02BAC")]
	public bool _003C_003EiFixBaseProxy_IsAutoCalculatePreviewPanelSize()
	{
		return default(bool);
	}

	[Token(Token = "0x60114F8")]
	[Address(RVA = "0xF02BB0", Offset = "0xF02BB0", VA = "0xF02BB0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60114F9")]
	[Address(RVA = "0xF02BB4", Offset = "0xF02BB4", VA = "0xF02BB4")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}
