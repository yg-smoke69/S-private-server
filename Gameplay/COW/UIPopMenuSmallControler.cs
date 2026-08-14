using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002A74")]
public class UIPopMenuSmallControler : UIBaseController, _Attribute
{
	[Token(Token = "0x40104B2")]
	[FieldOffset(Offset = "0x28")]
	protected UIPopMenuSmallView m_View;

	[Token(Token = "0x40104B3")]
	[FieldOffset(Offset = "0x2C")]
	public Action DataInject;

	[Token(Token = "0x40104B4")]
	[FieldOffset(Offset = "0x30")]
	protected PopUpStyle m_Style;

	[Token(Token = "0x40104B5")]
	[FieldOffset(Offset = "0x34")]
	protected List<PopMenuData> m_DataList;

	[Token(Token = "0x40104B6")]
	[FieldOffset(Offset = "0x38")]
	protected List<UIPopMenuItemSmallController> m_UIPopMenuItemSmallControllerList;

	[Token(Token = "0x40104B7")]
	[FieldOffset(Offset = "0x3C")]
	protected bool isShowing;

	[Token(Token = "0x40104B8")]
	[FieldOffset(Offset = "0x40")]
	protected int m_CellWidth;

	[Token(Token = "0x40104B9")]
	[FieldOffset(Offset = "0x44")]
	protected float m_MaxShowCount;

	[Token(Token = "0x40104BA")]
	[FieldOffset(Offset = "0x48")]
	protected PopMenuData m_CurrentSelectData;

	[Token(Token = "0x40104BB")]
	[FieldOffset(Offset = "0x4C")]
	protected bool m_Enable;

	[Token(Token = "0x40104BC")]
	public const float SPLITLINE = 0.2f;

	[Token(Token = "0x40104BD")]
	public const int SMALLCELLHEIGHT = 38;

	[Token(Token = "0x40104BE")]
	public const int FIXEDSPACE = 2;

	[Token(Token = "0x40104BF")]
	[FieldOffset(Offset = "0x50")]
	protected UIClickMask m_UIClickMask;

	[Token(Token = "0x40104C0")]
	[FieldOffset(Offset = "0x54")]
	private Modifier m_Modifier;

	[Token(Token = "0x40104C1")]
	private const uint DefaultLabelColor = 707736063u;

	[Token(Token = "0x40104C2")]
	[FieldOffset(Offset = "0x58")]
	private bool m_HasSubMenu;

	[Token(Token = "0x40104C3")]
	[FieldOffset(Offset = "0x59")]
	private bool m_AnsweredBySubMenu;

	[Token(Token = "0x40104C4")]
	[FieldOffset(Offset = "0x5C")]
	private UIPopMenuSmallControler m_CascadeCtrl;

	[Token(Token = "0x40104C5")]
	[FieldOffset(Offset = "0x60")]
	private uint m_SubMenuSelected;

	[Token(Token = "0x40104C6")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<PopMenuData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6011467")]
	[Address(RVA = "0x2C570F0", Offset = "0x2C570F0", VA = "0x2C570F0")]
	public UIPopMenuSmallControler()
	{
	}

	[Token(Token = "0x6011468")]
	[Address(RVA = "0x2C60AA8", Offset = "0x2C60AA8", VA = "0x2C60AA8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011469")]
	[Address(RVA = "0x2C5731C", Offset = "0x2C5731C", VA = "0x2C5731C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601146A")]
	[Address(RVA = "0x2C604E4", Offset = "0x2C604E4", VA = "0x2C604E4", Slot = "32")]
	public virtual void InitPopMenu(Action injectDataListAction, ResourceID spriteRes, string Text, PopUpStyle style = PopUpStyle.Down, int cellWidth = 260, float maxShowCount = 4.5f, bool enable = true, string openBtnSpriteOverride = "", string arrUpSpriteOverride = "", string arrDownSpriteOverride = "", bool useOverrideColor = false, uint labelColor = 707736063u, Modifier modifier = 1)
	{
	}

	[Token(Token = "0x601146B")]
	[Address(RVA = "0x2C60B4C", Offset = "0x2C60B4C", VA = "0x2C60B4C", Slot = "33")]
	public virtual void SetPanelDepth(int depth)
	{
	}

	[Token(Token = "0x601146C")]
	[Address(RVA = "0x2C60C54", Offset = "0x2C60C54", VA = "0x2C60C54", Slot = "34")]
	public virtual int GetPanelDepth()
	{
		return default(int);
	}

	[Token(Token = "0x601146D")]
	[Address(RVA = "0x2C60CE0", Offset = "0x2C60CE0", VA = "0x2C60CE0", Slot = "35")]
	public virtual void SetEnable(bool enable)
	{
	}

	[Token(Token = "0x601146E")]
	[Address(RVA = "0x2C60EC8", Offset = "0x2C60EC8", VA = "0x2C60EC8", Slot = "36")]
	public virtual void UpdateSelectDataInfo(ResourceID spriteRes, string Text = "", string spritename = "")
	{
	}

	[Token(Token = "0x601146F")]
	[Address(RVA = "0x2C61608", Offset = "0x2C61608", VA = "0x2C61608", Slot = "37")]
	protected virtual void SetStyle(PopUpStyle style, int cellWidth = 260, string openBtnSpriteOverride = "", string arrUpSpriteOverride = "", string arrDownSpriteOverride = "", bool useOverrideColor = false, uint labelColor = 707736063u)
	{
	}

	[Token(Token = "0x6011470")]
	[Address(RVA = "0x2C61AB4", Offset = "0x2C61AB4", VA = "0x2C61AB4")]
	private void OverrideSprite(UISprite sprite, string name)
	{
	}

	[Token(Token = "0x6011471")]
	[Address(RVA = "0x2C59AF8", Offset = "0x2C59AF8", VA = "0x2C59AF8", Slot = "38")]
	protected virtual void AdjustScrollView()
	{
	}

	[Token(Token = "0x6011472")]
	[Address(RVA = "0x2C61DB0", Offset = "0x2C61DB0", VA = "0x2C61DB0", Slot = "39")]
	public virtual void SetPopViewData(List<PopMenuData> dataList)
	{
	}

	[Token(Token = "0x6011473")]
	[Address(RVA = "0x2C623A0", Offset = "0x2C623A0", VA = "0x2C623A0")]
	private void GenerateSubMenuData()
	{
	}

	[Token(Token = "0x6011474")]
	[Address(RVA = "0x2C62518", Offset = "0x2C62518", VA = "0x2C62518")]
	public UIWidget GetBGPanel()
	{
		return null;
	}

	[Token(Token = "0x6011475")]
	[Address(RVA = "0x2C62598", Offset = "0x2C62598", VA = "0x2C62598")]
	public void OnParentSelect(object obj)
	{
	}

	[Token(Token = "0x6011476")]
	[Address(RVA = "0x2C628FC", Offset = "0x2C628FC", VA = "0x2C628FC")]
	public void SetPosition(Vector3 itemPos)
	{
	}

	[Token(Token = "0x6011477")]
	[Address(RVA = "0x2C62310", Offset = "0x2C62310", VA = "0x2C62310")]
	public void HideMainPart()
	{
	}

	[Token(Token = "0x6011478")]
	[Address(RVA = "0x2C607A4", Offset = "0x2C607A4", VA = "0x2C607A4", Slot = "40")]
	protected virtual bool CallDataInject()
	{
		return default(bool);
	}

	[Token(Token = "0x6011479")]
	[Address(RVA = "0x2C59F8C", Offset = "0x2C59F8C", VA = "0x2C59F8C", Slot = "41")]
	public virtual void ShowPopUpItem()
	{
	}

	[Token(Token = "0x601147A")]
	[Address(RVA = "0x2C62A00", Offset = "0x2C62A00", VA = "0x2C62A00", Slot = "42")]
	public virtual void OnClickeMenuItem(PopMenuData data)
	{
	}

	[Token(Token = "0x601147B")]
	[Address(RVA = "0x2C62BB8", Offset = "0x2C62BB8", VA = "0x2C62BB8")]
	private void SetSelectedDataAndClose(object[] data)
	{
	}

	[Token(Token = "0x601147C")]
	[Address(RVA = "0x2C62DB0", Offset = "0x2C62DB0", VA = "0x2C62DB0")]
	private void SetSelectedParent(object[] data)
	{
	}

	[Token(Token = "0x601147D")]
	[Address(RVA = "0x2C62F94", Offset = "0x2C62F94", VA = "0x2C62F94", Slot = "43")]
	public virtual void SetCurrentSelectData(PopMenuData data)
	{
	}

	[Token(Token = "0x601147E")]
	[Address(RVA = "0x2C63064", Offset = "0x2C63064", VA = "0x2C63064")]
	public PopMenuData GetCurrentSelectData()
	{
		return null;
	}

	[Token(Token = "0x601147F")]
	[Address(RVA = "0x2C630BC", Offset = "0x2C630BC", VA = "0x2C630BC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011480")]
	[Address(RVA = "0x2C5B4B4", Offset = "0x2C5B4B4", VA = "0x2C5B4B4", Slot = "44")]
	protected virtual void OnPopMenuClose()
	{
	}

	[Token(Token = "0x6011481")]
	[Address(RVA = "0x2C63274", Offset = "0x2C63274", VA = "0x2C63274")]
	private static bool _003CSetPopViewData_003Em__0(PopMenuData item)
	{
		return default(bool);
	}

	[Token(Token = "0x6011482")]
	[Address(RVA = "0x2C63290", Offset = "0x2C63290", VA = "0x2C63290")]
	private bool _003CGenerateSubMenuData_003Em__1(PopMenuData temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6011483")]
	[Address(RVA = "0x2C6332C", Offset = "0x2C6332C", VA = "0x2C6332C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011484")]
	[Address(RVA = "0x2C63334", Offset = "0x2C63334", VA = "0x2C63334")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
