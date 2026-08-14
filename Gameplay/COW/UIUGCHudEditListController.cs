using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using GCommon.UGCUI;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002427")]
public class UIUGCHudEditListController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400E0FF")]
	[FieldOffset(Offset = "0x48")]
	private UIUGCHudEditListView m_View;

	[Token(Token = "0x400E100")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelUGCHudEdit m_Model;

	[Token(Token = "0x400E101")]
	[FieldOffset(Offset = "0x50")]
	private AONDOMHABOH m_CurrentHudData;

	[Token(Token = "0x400E102")]
	[FieldOffset(Offset = "0x54")]
	private List<AONDOMHABOH> m_Prefabs;

	[Token(Token = "0x400E103")]
	[FieldOffset(Offset = "0x58")]
	private UIUGCHudEditPopupMenuPanelController m_MenuPanel;

	[Token(Token = "0x400E104")]
	[FieldOffset(Offset = "0x5C")]
	private UIUGCHudEditPopupMenuPanelController.MenuItemData[] m_MenuItemDatas;

	[Token(Token = "0x400E105")]
	[FieldOffset(Offset = "0x60")]
	private UGCHudPrefabRoot m_PrefabPreview;

	[Token(Token = "0x400E106")]
	[FieldOffset(Offset = "0x64")]
	private int m_SelectedIndex;

	[Token(Token = "0x400E107")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<AONDOMHABOH> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600CCAF")]
	[Address(RVA = "0x2FE8A7C", Offset = "0x2FE8A7C", VA = "0x2FE8A7C")]
	public UIUGCHudEditListController()
	{
	}

	[Token(Token = "0x600CCB0")]
	[Address(RVA = "0x2FE8B10", Offset = "0x2FE8B10", VA = "0x2FE8B10")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CCB1")]
	[Address(RVA = "0x2FE8BB4", Offset = "0x2FE8BB4", VA = "0x2FE8BB4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CCB2")]
	[Address(RVA = "0x2FE9930", Offset = "0x2FE9930", VA = "0x2FE9930")]
	private void Start()
	{
	}

	[Token(Token = "0x600CCB3")]
	[Address(RVA = "0x2FE9AE4", Offset = "0x2FE9AE4", VA = "0x2FE9AE4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CCB4")]
	[Address(RVA = "0x2FE9B68", Offset = "0x2FE9B68", VA = "0x2FE9B68")]
	private AONDOMHABOH CreateEmptyHudPrefab()
	{
		return null;
	}

	[Token(Token = "0x600CCB5")]
	[Address(RVA = "0x2FE9640", Offset = "0x2FE9640", VA = "0x2FE9640")]
	private void RefreshHudList()
	{
	}

	[Token(Token = "0x600CCB6")]
	[Address(RVA = "0x2FE9D88", Offset = "0x2FE9D88", VA = "0x2FE9D88")]
	private void UpdateHudPrefabList()
	{
	}

	[Token(Token = "0x600CCB7")]
	[Address(RVA = "0x2FEA00C", Offset = "0x2FEA00C", VA = "0x2FEA00C")]
	private void RebuildPrefab()
	{
	}

	[Token(Token = "0x600CCB8")]
	[Address(RVA = "0x2FEA2C8", Offset = "0x2FEA2C8", VA = "0x2FEA2C8")]
	private void OnNewBtnClick()
	{
	}

	[Token(Token = "0x600CCB9")]
	[Address(RVA = "0x2FEA41C", Offset = "0x2FEA41C", VA = "0x2FEA41C")]
	private void OnClickEditPrefab()
	{
	}

	[Token(Token = "0x600CCBA")]
	[Address(RVA = "0x2FEA974", Offset = "0x2FEA974", VA = "0x2FEA974")]
	private void OnClickScript()
	{
	}

	[Token(Token = "0x600CCBB")]
	[Address(RVA = "0x2FEAB60", Offset = "0x2FEAB60", VA = "0x2FEAB60")]
	private void DoMenuRename()
	{
	}

	[Token(Token = "0x600CCBC")]
	[Address(RVA = "0x2FEAD14", Offset = "0x2FEAD14", VA = "0x2FEAD14")]
	private void DoMenuCopy()
	{
	}

	[Token(Token = "0x600CCBD")]
	[Address(RVA = "0x2FEB070", Offset = "0x2FEB070", VA = "0x2FEB070")]
	private void DoMenuDelete()
	{
	}

	[Token(Token = "0x600CCBE")]
	[Address(RVA = "0x2FE988C", Offset = "0x2FE988C", VA = "0x2FE988C")]
	private void ForceSelectItem(int index)
	{
	}

	[Token(Token = "0x600CCBF")]
	[Address(RVA = "0x2FEB370", Offset = "0x2FEB370", VA = "0x2FEB370")]
	private void SelectItem(int index)
	{
	}

	[Token(Token = "0x600CCC0")]
	[Address(RVA = "0x2FEB4A0", Offset = "0x2FEB4A0", VA = "0x2FEB4A0")]
	private void LongPressItem(int index, Vector3 position)
	{
	}

	[Token(Token = "0x600CCC1")]
	[Address(RVA = "0x2FEB700", Offset = "0x2FEB700", VA = "0x2FEB700", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600CCC2")]
	[Address(RVA = "0x2FEB8E8", Offset = "0x2FEB8E8", VA = "0x2FEB8E8", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600CCC3")]
	[Address(RVA = "0x2FEB964", Offset = "0x2FEB964", VA = "0x2FEB964")]
	private static int _003CUpdateHudPrefabList_003Em__0(AONDOMHABOH a, AONDOMHABOH b)
	{
		return default(int);
	}

	[Token(Token = "0x600CCC4")]
	[Address(RVA = "0x2FEB9D8", Offset = "0x2FEB9D8", VA = "0x2FEB9D8")]
	private void _003COnClickEditPrefab_003Em__1()
	{
	}

	[Token(Token = "0x600CCC5")]
	[Address(RVA = "0x2FEBA08", Offset = "0x2FEBA08", VA = "0x2FEBA08")]
	private void _003CDoMenuRename_003Em__2(string newName)
	{
	}

	[Token(Token = "0x600CCC6")]
	[Address(RVA = "0x2FEBC64", Offset = "0x2FEBC64", VA = "0x2FEBC64")]
	private void _003CDoMenuDelete_003Em__3()
	{
	}

	[Token(Token = "0x600CCC7")]
	[Address(RVA = "0x2FEBD18", Offset = "0x2FEBD18", VA = "0x2FEBD18")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CCC8")]
	[Address(RVA = "0x2FEBD20", Offset = "0x2FEBD20", VA = "0x2FEBD20")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
