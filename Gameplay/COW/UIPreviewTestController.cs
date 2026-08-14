using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A80")]
public class UIPreviewTestController : UIPreviewNavigationController
{
	[Token(Token = "0x4010515")]
	[FieldOffset(Offset = "0x7C")]
	private UIPreviewTestView m_View;

	[Token(Token = "0x4010516")]
	[FieldOffset(Offset = "0x80")]
	private UIPopMenuSmallControler m_PopMenuCtrl;

	[Token(Token = "0x4010517")]
	[FieldOffset(Offset = "0x84")]
	private string m_SelectedCategory;

	[Token(Token = "0x4010518")]
	[FieldOffset(Offset = "0x88")]
	private List<PopMenuData> m_MenuDatas;

	[Token(Token = "0x4010519")]
	[FieldOffset(Offset = "0x8C")]
	private List<string> m_Categories;

	[Token(Token = "0x401051A")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024mapF;

	[Token(Token = "0x60114D8")]
	[Address(RVA = "0xEFECD4", Offset = "0xEFECD4", VA = "0xEFECD4")]
	public UIPreviewTestController()
	{
	}

	[Token(Token = "0x60114D9")]
	[Address(RVA = "0xEFF344", Offset = "0xEFF344", VA = "0xEFF344", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x60114DA")]
	[Address(RVA = "0xEFF3B4", Offset = "0xEFF3B4", VA = "0xEFF3B4", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x60114DB")]
	[Address(RVA = "0xEFF40C", Offset = "0xEFF40C", VA = "0xEFF40C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60114DC")]
	[Address(RVA = "0xEFF4B0", Offset = "0xEFF4B0", VA = "0xEFF4B0", Slot = "44")]
	protected override bool IsAutoCalculatePreviewPanelSize()
	{
		return default(bool);
	}

	[Token(Token = "0x60114DD")]
	[Address(RVA = "0xEFF508", Offset = "0xEFF508", VA = "0xEFF508", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60114DE")]
	[Address(RVA = "0xEFFA34", Offset = "0xEFFA34", VA = "0xEFFA34")]
	private void GenerateCategoryList()
	{
	}

	[Token(Token = "0x60114DF")]
	[Address(RVA = "0xEFFD60", Offset = "0xEFFD60", VA = "0xEFFD60")]
	private void OnCategorySelect(object obj)
	{
	}

	[Token(Token = "0x60114E0")]
	[Address(RVA = "0xF00B08", Offset = "0xF00B08", VA = "0xF00B08", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x60114E1")]
	[Address(RVA = "0xF00B90", Offset = "0xF00B90", VA = "0xF00B90")]
	private void OnButtonClick()
	{
	}

	[Token(Token = "0x60114E2")]
	[Address(RVA = "0xF00C7C", Offset = "0xF00C7C", VA = "0xF00C7C")]
	private void OnNextPreviewButtonClick()
	{
	}

	[Token(Token = "0x60114E3")]
	[Address(RVA = "0xF00DD4", Offset = "0xF00DD4", VA = "0xF00DD4")]
	private void OnLeftButtonClick()
	{
	}

	[Token(Token = "0x60114E4")]
	[Address(RVA = "0xF00E44", Offset = "0xF00E44", VA = "0xF00E44")]
	private void OnRightButtonClick()
	{
	}

	[Token(Token = "0x60114E5")]
	[Address(RVA = "0xF01030", Offset = "0xF01030", VA = "0xF01030")]
	private void OnCenterButtonClick()
	{
	}

	[Token(Token = "0x60114E6")]
	[Address(RVA = "0xF010A0", Offset = "0xF010A0", VA = "0xF010A0")]
	public bool _003C_003EiFixBaseProxy_IsAutoCalculatePreviewPanelSize()
	{
		return default(bool);
	}

	[Token(Token = "0x60114E7")]
	[Address(RVA = "0xF010A4", Offset = "0xF010A4", VA = "0xF010A4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60114E8")]
	[Address(RVA = "0xF010A8", Offset = "0xF010A8", VA = "0xF010A8")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}
