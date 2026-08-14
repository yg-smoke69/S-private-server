using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20024F6")]
public class UIBasePopMenuController<T> : UIPopupWindowController where T : UICommonPopMenuItemController
{
	[Token(Token = "0x400E56E")]
	[FieldOffset(Offset = "0x0")]
	protected int CellWidth;

	[Token(Token = "0x400E56F")]
	[FieldOffset(Offset = "0x0")]
	protected int CellHeight;

	[Token(Token = "0x400E570")]
	[FieldOffset(Offset = "0x0")]
	protected int CellWidthPadding;

	[Token(Token = "0x400E571")]
	[FieldOffset(Offset = "0x0")]
	protected int m_NewCellWidth;

	[Token(Token = "0x400E572")]
	[FieldOffset(Offset = "0x0")]
	private Vector2 m_showOffset;

	[Token(Token = "0x400E573")]
	[FieldOffset(Offset = "0x0")]
	private Vector2 m_clickPos;

	[Token(Token = "0x400E574")]
	[FieldOffset(Offset = "0x0")]
	private int m_offset;

	[Token(Token = "0x400E575")]
	[FieldOffset(Offset = "0x0")]
	private int m_activatedMenuWidth;

	[Token(Token = "0x400E576")]
	[FieldOffset(Offset = "0x0")]
	private int m_activatedMenuHeight;

	[Token(Token = "0x400E577")]
	[FieldOffset(Offset = "0x0")]
	private float m_scale;

	[Token(Token = "0x400E578")]
	[FieldOffset(Offset = "0x0")]
	private UIClickMask m_ClickMask;

	[Token(Token = "0x400E579")]
	[FieldOffset(Offset = "0x0")]
	private UICommonPopMenuView m_View;

	[Token(Token = "0x400E57A")]
	[FieldOffset(Offset = "0x0")]
	protected List<T> m_ItemControllerList;

	[Token(Token = "0x600D580")]
	public UIBasePopMenuController()
	{
	}

	[Token(Token = "0x600D581")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600D582")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D583")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D584")]
	public void UpdateMenuData(List<CommonPopMenuData> list)
	{
	}

	[Token(Token = "0x600D585")]
	public void SetClanWarBG(string BGName = "FF_roundness_bg", string BGBorderName = "UI_icon_BG", uint BGColor = 1095985663u, uint BGBorderColor = uint.MaxValue)
	{
	}

	[Token(Token = "0x600D586")]
	protected void CreateMenuData(List<CommonPopMenuData> list)
	{
	}

	[Token(Token = "0x600D587")]
	private void ResizeMenuWidth()
	{
	}

	[Token(Token = "0x600D588")]
	private void ComputePopPosition(int itemNum)
	{
	}

	[Token(Token = "0x600D589")]
	private void OnClickeMenuItem(object[] data)
	{
	}
}
