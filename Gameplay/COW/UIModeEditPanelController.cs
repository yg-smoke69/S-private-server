using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20022F9")]
public class UIModeEditPanelController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x20022FA")]
	public class TabData
	{
		[Token(Token = "0x400DA4E")]
		[FieldOffset(Offset = "0x8")]
		public string Label;

		[Token(Token = "0x400DA4F")]
		[FieldOffset(Offset = "0xC")]
		public int Index;

		[Token(Token = "0x400DA50")]
		[FieldOffset(Offset = "0x10")]
		public bool enabled;

		[Token(Token = "0x600C11B")]
		[Address(RVA = "0x1312E50", Offset = "0x1312E50", VA = "0x1312E50")]
		public TabData()
		{
		}
	}

	[Token(Token = "0x20022FB")]
	private sealed class _003COnBtnSwitchModeClick_003Ec__AnonStorey0
	{
		[Token(Token = "0x400DA51")]
		[FieldOffset(Offset = "0x8")]
		internal UIModelSceneEdit model;

		[Token(Token = "0x600C11C")]
		[Address(RVA = "0x13140D4", Offset = "0x13140D4", VA = "0x13140D4")]
		public _003COnBtnSwitchModeClick_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600C11D")]
		[Address(RVA = "0x1314BDC", Offset = "0x1314BDC", VA = "0x1314BDC")]
		internal void _003C_003Em__0(WorkshopCreateNewConfigData value)
		{
		}

		[Token(Token = "0x600C11E")]
		[Address(RVA = "0x1315148", Offset = "0x1315148", VA = "0x1315148")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x400DA45")]
	[FieldOffset(Offset = "0x48")]
	private UIModeEditPanelView m_View;

	[Token(Token = "0x400DA46")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelUGCModeEdit m_Model;

	[Token(Token = "0x400DA47")]
	[FieldOffset(Offset = "0x50")]
	private List<UIBaseController> m_Components;

	[Token(Token = "0x400DA48")]
	[FieldOffset(Offset = "0x54")]
	private int m_CurrentComponentIndex;

	[Token(Token = "0x400DA49")]
	[FieldOffset(Offset = "0x58")]
	private List<TabData> m_TabData;

	[Token(Token = "0x400DA4A")]
	[FieldOffset(Offset = "0x5C")]
	private float m_Width;

	[Token(Token = "0x400DA4B")]
	[FieldOffset(Offset = "0x60")]
	public CFullScreenWindow_VTabsPanelData Data;

	[Token(Token = "0x400DA4C")]
	[FieldOffset(Offset = "0x64")]
	public ModeVariables Variables;

	[Token(Token = "0x400DA4D")]
	[FieldOffset(Offset = "0x68")]
	private uint m_CurrentSelectedModeWithTemplate;

	[Token(Token = "0x600C105")]
	[Address(RVA = "0x1312110", Offset = "0x1312110", VA = "0x1312110")]
	public UIModeEditPanelController()
	{
	}

	[Token(Token = "0x600C106")]
	[Address(RVA = "0x13121D0", Offset = "0x13121D0", VA = "0x13121D0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C107")]
	[Address(RVA = "0x1312278", Offset = "0x1312278", VA = "0x1312278", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C108")]
	[Address(RVA = "0x1312978", Offset = "0x1312978", VA = "0x1312978")]
	private void CalCurrentSelectedModeWithTemplate()
	{
	}

	[Token(Token = "0x600C109")]
	[Address(RVA = "0x1312C14", Offset = "0x1312C14", VA = "0x1312C14", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C10A")]
	[Address(RVA = "0x130F248", Offset = "0x130F248", VA = "0x130F248")]
	public void SetViewData(CFullScreenWindow_VTabsPanelData data, ModeVariables variables)
	{
	}

	[Token(Token = "0x600C10B")]
	[Address(RVA = "0x1313268", Offset = "0x1313268", VA = "0x1313268", Slot = "35")]
	public override int MinGroupDepth()
	{
		return default(int);
	}

	[Token(Token = "0x600C10C")]
	[Address(RVA = "0x1312E58", Offset = "0x1312E58", VA = "0x1312E58")]
	private void BuildChildComponent(Transform container, IModeEditComponentData data)
	{
	}

	[Token(Token = "0x600C10D")]
	[Address(RVA = "0x13132D0", Offset = "0x13132D0", VA = "0x13132D0")]
	private void OnSelectTab(object[] param)
	{
	}

	[Token(Token = "0x600C10E")]
	[Address(RVA = "0x13135A0", Offset = "0x13135A0", VA = "0x13135A0")]
	private void OnItemIndexChanged()
	{
	}

	[Token(Token = "0x600C10F")]
	[Address(RVA = "0x131387C", Offset = "0x131387C", VA = "0x131387C")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600C110")]
	[Address(RVA = "0x1313924", Offset = "0x1313924", VA = "0x1313924")]
	private void OnBtnResetClick()
	{
	}

	[Token(Token = "0x600C111")]
	[Address(RVA = "0x1313AF8", Offset = "0x1313AF8", VA = "0x1313AF8")]
	private void OnBtnHelpClick()
	{
	}

	[Token(Token = "0x600C112")]
	[Address(RVA = "0x1313D18", Offset = "0x1313D18", VA = "0x1313D18")]
	private void OnBtnSwitchModeClick()
	{
	}

	[Token(Token = "0x600C113")]
	[Address(RVA = "0x13140DC", Offset = "0x13140DC", VA = "0x13140DC")]
	private void OnBtnOKClick()
	{
	}

	[Token(Token = "0x600C114")]
	[Address(RVA = "0x1314198", Offset = "0x1314198", VA = "0x1314198")]
	private bool CheckFullCustomVariableValid()
	{
		return default(bool);
	}

	[Token(Token = "0x600C115")]
	[Address(RVA = "0x1314618", Offset = "0x1314618", VA = "0x1314618")]
	private void OnBtnBlockEdit()
	{
	}

	[Token(Token = "0x600C116")]
	[Address(RVA = "0x1314A50", Offset = "0x1314A50", VA = "0x1314A50", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600C117")]
	[Address(RVA = "0x1314B48", Offset = "0x1314B48", VA = "0x1314B48", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600C118")]
	[Address(RVA = "0x1314BC4", Offset = "0x1314BC4", VA = "0x1314BC4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C119")]
	[Address(RVA = "0x1314BCC", Offset = "0x1314BCC", VA = "0x1314BCC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600C11A")]
	[Address(RVA = "0x1314BD4", Offset = "0x1314BD4", VA = "0x1314BD4")]
	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return default(int);
	}
}
