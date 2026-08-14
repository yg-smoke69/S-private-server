using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023C4")]
public class UIStandardTabItemController : UIEasyListItemController
{
	[Token(Token = "0x400DE8A")]
	public const string CLICK_ANIM_NAME = "UIStandardTabItemRemake_Click";

	[Token(Token = "0x400DE8B")]
	[FieldOffset(Offset = "0x38")]
	protected UIStandardTabItemView m_View;

	[Token(Token = "0x400DE8C")]
	[FieldOffset(Offset = "0x3C")]
	protected StandardTabItemViewData m_Data;

	[Token(Token = "0x400DE8D")]
	[FieldOffset(Offset = "0x40")]
	protected List<UIStandardSubTabItemController> subTabList;

	[Token(Token = "0x400DE8E")]
	[FieldOffset(Offset = "0x44")]
	protected int curSubTabIndex;

	[Token(Token = "0x400DE8F")]
	[FieldOffset(Offset = "0x48")]
	protected int m_MainTabIndex;

	[Token(Token = "0x400DE90")]
	[FieldOffset(Offset = "0x4C")]
	public bool isDrawerOpen;

	[Token(Token = "0x400DE91")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_Selected;

	[Token(Token = "0x400DE92")]
	[FieldOffset(Offset = "0x54")]
	protected Color unselectArrowColor;

	[Token(Token = "0x400DE93")]
	[FieldOffset(Offset = "0x64")]
	protected Color selectAndFoldedArrowColor;

	[Token(Token = "0x400DE94")]
	[FieldOffset(Offset = "0x74")]
	protected Color selectAndUnfoldedArrowColor;

	[Token(Token = "0x600C994")]
	[Address(RVA = "0x2000160", Offset = "0x2000160", VA = "0x2000160")]
	public UIStandardTabItemController()
	{
	}

	[Token(Token = "0x600C995")]
	[Address(RVA = "0x2000250", Offset = "0x2000250", VA = "0x2000250")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C996")]
	[Address(RVA = "0x20002F8", Offset = "0x20002F8", VA = "0x20002F8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C997")]
	[Address(RVA = "0x20004AC", Offset = "0x20004AC", VA = "0x20004AC", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600C998")]
	[Address(RVA = "0x2000CEC", Offset = "0x2000CEC", VA = "0x2000CEC")]
	public void SetFixRectState(bool value)
	{
	}

	[Token(Token = "0x600C999")]
	[Address(RVA = "0x2000D84", Offset = "0x2000D84", VA = "0x2000D84", Slot = "37")]
	public virtual void CheckTagState()
	{
	}

	[Token(Token = "0x600C99A")]
	[Address(RVA = "0x2000BDC", Offset = "0x2000BDC", VA = "0x2000BDC")]
	protected void UpdateArrowState(bool value)
	{
	}

	[Token(Token = "0x600C99B")]
	[Address(RVA = "0x2001294", Offset = "0x2001294", VA = "0x2001294")]
	public void CreateSubTabByDataList(List<StandardSubTabItemViewData> subTabDataist, Transform subTabContainer)
	{
	}

	[Token(Token = "0x600C99C")]
	[Address(RVA = "0x20017EC", Offset = "0x20017EC", VA = "0x20017EC", Slot = "38")]
	protected virtual UIStandardSubTabItemController CreateSubTabItem(Transform container, bool isLastSubTab)
	{
		return null;
	}

	[Token(Token = "0x600C99D")]
	[Address(RVA = "0x200155C", Offset = "0x200155C", VA = "0x200155C")]
	private void UpdateSubTabState(bool value)
	{
	}

	[Token(Token = "0x600C99E")]
	[Address(RVA = "0x20018F0", Offset = "0x20018F0", VA = "0x20018F0", Slot = "39")]
	protected virtual void UpdateExtraSubTabView(bool value)
	{
	}

	[Token(Token = "0x600C99F")]
	[Address(RVA = "0x200194C", Offset = "0x200194C", VA = "0x200194C")]
	public void SelectSubTabByIndex(int index)
	{
	}

	[Token(Token = "0x600C9A0")]
	[Address(RVA = "0x2001B34", Offset = "0x2001B34", VA = "0x2001B34")]
	public UIStandardSubTabItemController GetSubTabItemController(int index)
	{
		return null;
	}

	[Token(Token = "0x600C9A1")]
	[Address(RVA = "0x2001C74", Offset = "0x2001C74", VA = "0x2001C74", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600C9A2")]
	[Address(RVA = "0x2001FAC", Offset = "0x2001FAC", VA = "0x2001FAC", Slot = "40")]
	public virtual void CheckTipButton()
	{
	}

	[Token(Token = "0x600C9A3")]
	[Address(RVA = "0x20020F8", Offset = "0x20020F8", VA = "0x20020F8", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600C9A4")]
	[Address(RVA = "0x20021D4", Offset = "0x20021D4", VA = "0x20021D4")]
	public UIButton GetButtonForGuide()
	{
		return null;
	}

	[Token(Token = "0x600C9A5")]
	[Address(RVA = "0x2002244", Offset = "0x2002244", VA = "0x2002244")]
	public UIWidget GetWidgetForGuide()
	{
		return null;
	}

	[Token(Token = "0x600C9A6")]
	[Address(RVA = "0x20022B4", Offset = "0x20022B4", VA = "0x20022B4")]
	public void InitDrawerTabItem()
	{
	}

	[Token(Token = "0x600C9A7")]
	[Address(RVA = "0x20024D0", Offset = "0x20024D0", VA = "0x20024D0")]
	public void UpdateSelectState(bool isSelect)
	{
	}

	[Token(Token = "0x600C9A8")]
	[Address(RVA = "0x2002834", Offset = "0x2002834", VA = "0x2002834")]
	public void ExecuteBtnTabItemClick()
	{
	}

	[Token(Token = "0x600C9A9")]
	[Address(RVA = "0x20028F4", Offset = "0x20028F4", VA = "0x20028F4")]
	private void SelectCurSubTabItem()
	{
	}

	[Token(Token = "0x600C9AA")]
	[Address(RVA = "0x2002964", Offset = "0x2002964", VA = "0x2002964")]
	private void OnDrawerTabItemSelect()
	{
	}

	[Token(Token = "0x600C9AB")]
	[Address(RVA = "0x2002AD0", Offset = "0x2002AD0", VA = "0x2002AD0")]
	public bool IsNoSubTabItem()
	{
		return default(bool);
	}

	[Token(Token = "0x600C9AC")]
	[Address(RVA = "0x2002B3C", Offset = "0x2002B3C", VA = "0x2002B3C")]
	public void RegisterSubTabTipEvent(ETipsType tipType)
	{
	}

	[Token(Token = "0x600C9AD")]
	[Address(RVA = "0x2002CE0", Offset = "0x2002CE0", VA = "0x2002CE0")]
	public int GetTabCount()
	{
		return default(int);
	}

	[Token(Token = "0x600C9AE")]
	[Address(RVA = "0x2002DF8", Offset = "0x2002DF8", VA = "0x2002DF8")]
	public void ChangeLabelFontSize(int size)
	{
	}

	[Token(Token = "0x600C9AF")]
	[Address(RVA = "0x2002F00", Offset = "0x2002F00", VA = "0x2002F00")]
	public void UpdateLabelText(string text)
	{
	}

	[Token(Token = "0x600C9B0")]
	[Address(RVA = "0x2003008", Offset = "0x2003008", VA = "0x2003008", Slot = "41")]
	protected virtual void PlayTabItemClickAnimation()
	{
	}

	[Token(Token = "0x600C9B1")]
	[Address(RVA = "0x20030FC", Offset = "0x20030FC", VA = "0x20030FC")]
	public void ResetTabItemClickAnimation()
	{
	}

	[Token(Token = "0x600C9B2")]
	[Address(RVA = "0x200320C", Offset = "0x200320C", VA = "0x200320C", Slot = "42")]
	protected virtual bool HasClickAnim()
	{
		return default(bool);
	}

	[Token(Token = "0x600C9B3")]
	[Address(RVA = "0x2003264", Offset = "0x2003264", VA = "0x2003264")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C9B4")]
	[Address(RVA = "0x200326C", Offset = "0x200326C", VA = "0x200326C")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600C9B5")]
	[Address(RVA = "0x2003274", Offset = "0x2003274", VA = "0x2003274")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
