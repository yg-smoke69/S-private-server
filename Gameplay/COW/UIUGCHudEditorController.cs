using System;
using System.Collections.Generic;
using GCommon;
using GCommon.UGCUI;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002429")]
public class UIUGCHudEditorController : UIPopupWindowController
{
	[Token(Token = "0x400E10E")]
	[FieldOffset(Offset = "0x48")]
	private UIUGCHudEditorView m_View;

	[Token(Token = "0x400E10F")]
	[FieldOffset(Offset = "0x4C")]
	private UGCEditPanel m_EditPanel;

	[Token(Token = "0x400E110")]
	[FieldOffset(Offset = "0x50")]
	private UIUGCHudWidgetSelectorController m_WidgetSelector;

	[Token(Token = "0x400E111")]
	[FieldOffset(Offset = "0x54")]
	private UIUGCHudWidgetInspectorController m_Inspector;

	[Token(Token = "0x400E112")]
	[FieldOffset(Offset = "0x58")]
	private UIUGCHudWidgetHierarchyController m_Hierarchy;

	[Token(Token = "0x400E113")]
	[FieldOffset(Offset = "0x5C")]
	private UIModelUGCHudEdit m_Model;

	[Token(Token = "0x400E114")]
	[FieldOffset(Offset = "0x60")]
	private List<UGCHudWidget> m_HudWidgetList;

	[Token(Token = "0x400E115")]
	[FieldOffset(Offset = "0x64")]
	private UGCHudPrefabRoot m_PrefabRoot;

	[Token(Token = "0x400E116")]
	[FieldOffset(Offset = "0x68")]
	private UGCHudWidget m_CurrentWidget;

	[Token(Token = "0x400E117")]
	[FieldOffset(Offset = "0x6C")]
	private Action m_CloseAction;

	[Token(Token = "0x400E118")]
	[FieldOffset(Offset = "0x70")]
	private int WIDGET_COUNT_LIMIT;

	[Token(Token = "0x400E119")]
	[FieldOffset(Offset = "0x74")]
	private float PANEL_MIN_ZOOM_RATIO;

	[Token(Token = "0x400E11A")]
	[FieldOffset(Offset = "0x78")]
	private float PANEL_MAX_ZOOM_RATIO;

	[Token(Token = "0x400E11B")]
	[FieldOffset(Offset = "0x7C")]
	private Color m_TransformDefaultColor;

	[Token(Token = "0x400E11C")]
	[FieldOffset(Offset = "0x8C")]
	private Color m_TransformChangeColor;

	[Token(Token = "0x400E11D")]
	[FieldOffset(Offset = "0x9C")]
	private uint m_DelayHideTransformInfoId;

	[Token(Token = "0x400E11E")]
	[FieldOffset(Offset = "0x0")]
	public static uint MaxHierarchy;

	[Token(Token = "0x600CCD6")]
	[Address(RVA = "0x2FEDF74", Offset = "0x2FEDF74", VA = "0x2FEDF74")]
	public UIUGCHudEditorController()
	{
	}

	[Token(Token = "0x600CCD7")]
	[Address(RVA = "0x2FEE0F4", Offset = "0x2FEE0F4", VA = "0x2FEE0F4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CCD8")]
	[Address(RVA = "0x2FEE198", Offset = "0x2FEE198", VA = "0x2FEE198", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CCD9")]
	[Address(RVA = "0x2FEF300", Offset = "0x2FEF300", VA = "0x2FEF300", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CCDA")]
	[Address(RVA = "0x2FEA608", Offset = "0x2FEA608", VA = "0x2FEA608")]
	public void SetData(AONDOMHABOH prefabData)
	{
	}

	[Token(Token = "0x600CCDB")]
	[Address(RVA = "0x2FEA914", Offset = "0x2FEA914", VA = "0x2FEA914")]
	public void SetCloseCallback(Action close)
	{
	}

	[Token(Token = "0x600CCDC")]
	[Address(RVA = "0x2FEFB00", Offset = "0x2FEFB00", VA = "0x2FEFB00")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600CCDD")]
	[Address(RVA = "0x2FEFB64", Offset = "0x2FEFB64", VA = "0x2FEFB64")]
	private void OnUndoClick()
	{
	}

	[Token(Token = "0x600CCDE")]
	[Address(RVA = "0x2FEFBDC", Offset = "0x2FEFBDC", VA = "0x2FEFBDC")]
	private void OnRedoClick()
	{
	}

	[Token(Token = "0x600CCDF")]
	[Address(RVA = "0x2FEFC54", Offset = "0x2FEFC54", VA = "0x2FEFC54")]
	private void OnInputBtnClick()
	{
	}

	[Token(Token = "0x600CCE0")]
	[Address(RVA = "0x2FF0090", Offset = "0x2FF0090", VA = "0x2FF0090")]
	private void OnLabelBtnClick()
	{
	}

	[Token(Token = "0x600CCE1")]
	[Address(RVA = "0x2FF00F4", Offset = "0x2FF00F4", VA = "0x2FF00F4")]
	private void OnImageBtnClick()
	{
	}

	[Token(Token = "0x600CCE2")]
	[Address(RVA = "0x2FF0158", Offset = "0x2FF0158", VA = "0x2FF0158")]
	private void OnButtonBtnClick()
	{
	}

	[Token(Token = "0x600CCE3")]
	[Address(RVA = "0x2FEFCB8", Offset = "0x2FEFCB8", VA = "0x2FEFCB8")]
	private UGCHudWidget CreateHudItem(UGCHudWidgetType hudType)
	{
		return null;
	}

	[Token(Token = "0x600CCE4")]
	[Address(RVA = "0x2FF01BC", Offset = "0x2FF01BC", VA = "0x2FF01BC")]
	private void OnPressHudItem(GameObject target, bool pressed)
	{
	}

	[Token(Token = "0x600CCE5")]
	[Address(RVA = "0x2FF030C", Offset = "0x2FF030C", VA = "0x2FF030C")]
	private void OnClickPanel()
	{
	}

	[Token(Token = "0x600CCE6")]
	[Address(RVA = "0x2FF0388", Offset = "0x2FF0388", VA = "0x2FF0388")]
	private void OnCurrentHudItemChanged(UGCHudWidget widget)
	{
	}

	[Token(Token = "0x600CCE7")]
	[Address(RVA = "0x2FF1F94", Offset = "0x2FF1F94", VA = "0x2FF1F94")]
	private void OnAddHudWidget(UGCHudWidget widget)
	{
	}

	[Token(Token = "0x600CCE8")]
	[Address(RVA = "0x2FF2230", Offset = "0x2FF2230", VA = "0x2FF2230")]
	private void OnRemoveHudWidget(UGCHudWidget widget)
	{
	}

	[Token(Token = "0x600CCE9")]
	[Address(RVA = "0x2FF24D4", Offset = "0x2FF24D4", VA = "0x2FF24D4")]
	private void OnPinchAndSpreadPanel(float start, float end)
	{
	}

	[Token(Token = "0x600CCEA")]
	[Address(RVA = "0x2FF0C10", Offset = "0x2FF0C10", VA = "0x2FF0C10")]
	private void InitWidgetTransformShow()
	{
	}

	[Token(Token = "0x600CCEB")]
	[Address(RVA = "0x2FF28E0", Offset = "0x2FF28E0", VA = "0x2FF28E0")]
	private void OnWidgetPositionChanged()
	{
	}

	[Token(Token = "0x600CCEC")]
	[Address(RVA = "0x2FF2D9C", Offset = "0x2FF2D9C", VA = "0x2FF2D9C")]
	private void OnWidgetSizeChanged()
	{
	}

	[Token(Token = "0x600CCED")]
	[Address(RVA = "0x2FF3200", Offset = "0x2FF3200", VA = "0x2FF3200")]
	private void OnWidgetRotationChanged()
	{
	}

	[Token(Token = "0x600CCEE")]
	[Address(RVA = "0x2FF26B0", Offset = "0x2FF26B0", VA = "0x2FF26B0")]
	private void SetTransformInfoColor(UIWidget widget, Color c)
	{
	}

	[Token(Token = "0x600CCEF")]
	[Address(RVA = "0x2FEF820", Offset = "0x2FEF820", VA = "0x2FEF820")]
	private void CancelDelayHideTransformInfo()
	{
	}

	[Token(Token = "0x600CCF1")]
	[Address(RVA = "0x2FF3570", Offset = "0x2FF3570", VA = "0x2FF3570")]
	private void _003COnCurrentHudItemChanged_003Em__0()
	{
	}

	[Token(Token = "0x600CCF2")]
	[Address(RVA = "0x2FF35B4", Offset = "0x2FF35B4", VA = "0x2FF35B4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CCF3")]
	[Address(RVA = "0x2FF35BC", Offset = "0x2FF35BC", VA = "0x2FF35BC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
