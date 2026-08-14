using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2002813")]
internal class UIHudPresetItemController : UIBaseController
{
	[Token(Token = "0x400F767")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPresetItemView m_View;

	[Token(Token = "0x400F768")]
	[FieldOffset(Offset = "0x2C")]
	private int m_Index;

	[Token(Token = "0x400F769")]
	[FieldOffset(Offset = "0x30")]
	private UIHudPresetController m_Parent;

	[Token(Token = "0x400F76A")]
	[FieldOffset(Offset = "0x34")]
	private List<UISprite> m_ItemViewList;

	[Token(Token = "0x600F97A")]
	[Address(RVA = "0x1FC4D14", Offset = "0x1FC4D14", VA = "0x1FC4D14")]
	public UIHudPresetItemController()
	{
	}

	[Token(Token = "0x600F97B")]
	[Address(RVA = "0x1FC4D98", Offset = "0x1FC4D98", VA = "0x1FC4D98")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F97C")]
	[Address(RVA = "0x1FC4E40", Offset = "0x1FC4E40", VA = "0x1FC4E40", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F97D")]
	[Address(RVA = "0x1FC5124", Offset = "0x1FC5124", VA = "0x1FC5124", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F97E")]
	[Address(RVA = "0x1FC5188", Offset = "0x1FC5188", VA = "0x1FC5188")]
	private void OnItemBtnClick()
	{
	}

	[Token(Token = "0x600F97F")]
	[Address(RVA = "0x1FC51FC", Offset = "0x1FC51FC", VA = "0x1FC51FC")]
	public void SetUIData(int idex, List<HOHACEOICHK> data, UIHudPresetController parent)
	{
	}

	[Token(Token = "0x600F980")]
	[Address(RVA = "0x1FC5CCC", Offset = "0x1FC5CCC", VA = "0x1FC5CCC")]
	public UIToggleButton GetUIToggleButton()
	{
		return null;
	}

	[Token(Token = "0x600F981")]
	[Address(RVA = "0x1FC5D3C", Offset = "0x1FC5D3C", VA = "0x1FC5D3C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F982")]
	[Address(RVA = "0x1FC5D44", Offset = "0x1FC5D44", VA = "0x1FC5D44")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
