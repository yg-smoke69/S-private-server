using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.Gameplay.UGC;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002341")]
public class UIHudSceneEditResMgrPanelController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002342")]
	private enum EScriptFliterType
	{
		[Token(Token = "0x400DBB3")]
		All,
		[Token(Token = "0x400DBB4")]
		Scripted
	}

	[Token(Token = "0x400DBA6")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSceneEditResMgrPanelView m_View;

	[Token(Token = "0x400DBA7")]
	[FieldOffset(Offset = "0x2C")]
	private UIPopMenuSmallControler m_SceneObjTypeFliterPopMenuSmallCtrl;

	[Token(Token = "0x400DBA8")]
	[FieldOffset(Offset = "0x30")]
	private UIPopMenuSmallControler m_SceneObjScriptEditFliterPopMenuSmallCtrl;

	[Token(Token = "0x400DBA9")]
	[FieldOffset(Offset = "0x34")]
	private List<PopMenuData> m_SceneObjTypeFliterDataList;

	[Token(Token = "0x400DBAA")]
	[FieldOffset(Offset = "0x38")]
	private List<PopMenuData> m_SceneObjScriptEditFliterDataList;

	[Token(Token = "0x400DBAB")]
	[FieldOffset(Offset = "0x3C")]
	private List<int> m_ObjList;

	[Token(Token = "0x400DBAC")]
	private const string m_AllTypeKey = "T_32_XH_REPLAY_ALL";

	[Token(Token = "0x400DBAD")]
	private const string m_ScriptEditedKey = "T_34_M_WS_CARRYSCRIPT";

	[Token(Token = "0x400DBAE")]
	[FieldOffset(Offset = "0x40")]
	private uint m_CurrentSelctedTypeFliter;

	[Token(Token = "0x400DBAF")]
	[FieldOffset(Offset = "0x44")]
	private uint m_CurrentSelctedScriptedFliter;

	[Token(Token = "0x400DBB0")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsFolded;

	[Token(Token = "0x400DBB1")]
	[FieldOffset(Offset = "0x4C")]
	private EditorEntityData m_EntityData;

	[Token(Token = "0x600C419")]
	[Address(RVA = "0x24EE37C", Offset = "0x24EE37C", VA = "0x24EE37C")]
	public UIHudSceneEditResMgrPanelController()
	{
	}

	[Token(Token = "0x600C41A")]
	[Address(RVA = "0x24EE44C", Offset = "0x24EE44C", VA = "0x24EE44C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C41B")]
	[Address(RVA = "0x24EE4F0", Offset = "0x24EE4F0", VA = "0x24EE4F0", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600C41C")]
	[Address(RVA = "0x24EECCC", Offset = "0x24EECCC", VA = "0x24EECCC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C41D")]
	[Address(RVA = "0x24EF508", Offset = "0x24EF508", VA = "0x24EF508")]
	private void OnHandleConfirmWnd(object[] args)
	{
	}

	[Token(Token = "0x600C41E")]
	[Address(RVA = "0x24EF5F0", Offset = "0x24EF5F0", VA = "0x24EF5F0")]
	private void OnWorkShopSceneRefresh(object[] data)
	{
	}

	[Token(Token = "0x600C41F")]
	[Address(RVA = "0x24EF660", Offset = "0x24EF660", VA = "0x24EF660")]
	private void PanelToggleShow()
	{
	}

	[Token(Token = "0x600C420")]
	[Address(RVA = "0x24EF838", Offset = "0x24EF838", VA = "0x24EF838")]
	private void PanelToggleHide()
	{
	}

	[Token(Token = "0x600C421")]
	[Address(RVA = "0x24EFA10", Offset = "0x24EFA10", VA = "0x24EFA10")]
	private void ActionListToggleChanged(object[] data)
	{
	}

	[Token(Token = "0x600C422")]
	[Address(RVA = "0x24EFC74", Offset = "0x24EFC74", VA = "0x24EFC74")]
	private void ShowPanel(bool notifyshowActionListPanel)
	{
	}

	[Token(Token = "0x600C423")]
	[Address(RVA = "0x24EEB8C", Offset = "0x24EEB8C", VA = "0x24EEB8C")]
	private void UnSelectedResObj()
	{
	}

	[Token(Token = "0x600C424")]
	[Address(RVA = "0x24EFFD0", Offset = "0x24EFFD0", VA = "0x24EFFD0")]
	private void OnToggleBtnClick()
	{
	}

	[Token(Token = "0x600C425")]
	[Address(RVA = "0x24F0244", Offset = "0x24F0244", VA = "0x24F0244")]
	private void OnToggleBtnReverseClick()
	{
	}

	[Token(Token = "0x600C426")]
	[Address(RVA = "0x24F04B8", Offset = "0x24F04B8", VA = "0x24F04B8")]
	private void OnTweenFinished()
	{
	}

	[Token(Token = "0x600C427")]
	[Address(RVA = "0x24EE584", Offset = "0x24EE584", VA = "0x24EE584")]
	private void RefreshObjGridList()
	{
	}

	[Token(Token = "0x600C428")]
	[Address(RVA = "0x24EF158", Offset = "0x24EF158", VA = "0x24EF158")]
	private void InitPopMenus()
	{
	}

	[Token(Token = "0x600C429")]
	[Address(RVA = "0x24F0620", Offset = "0x24F0620", VA = "0x24F0620")]
	private void GenerateScriptFliterMenuData()
	{
	}

	[Token(Token = "0x600C42A")]
	[Address(RVA = "0x24F0A9C", Offset = "0x24F0A9C", VA = "0x24F0A9C")]
	private void GenerateTypeFliterMenuData()
	{
	}

	[Token(Token = "0x600C42B")]
	[Address(RVA = "0x24F11AC", Offset = "0x24F11AC", VA = "0x24F11AC")]
	private void OnScriptedFliterSelected(object obj)
	{
	}

	[Token(Token = "0x600C42C")]
	[Address(RVA = "0x24F1284", Offset = "0x24F1284", VA = "0x24F1284")]
	private void OnTypeFliterSelected(object obj)
	{
	}

	[Token(Token = "0x600C42D")]
	[Address(RVA = "0x24F135C", Offset = "0x24F135C", VA = "0x24F135C")]
	private void OnResMgrModeChanged(object[] data)
	{
	}

	[Token(Token = "0x600C42E")]
	[Address(RVA = "0x24F1678", Offset = "0x24F1678", VA = "0x24F1678", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C42F")]
	[Address(RVA = "0x24F16DC", Offset = "0x24F16DC", VA = "0x24F16DC", Slot = "31")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600C430")]
	[Address(RVA = "0x24F17D4", Offset = "0x24F17D4", VA = "0x24F17D4", Slot = "32")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600C431")]
	[Address(RVA = "0x24F1830", Offset = "0x24F1830", VA = "0x24F1830")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600C432")]
	[Address(RVA = "0x24F1838", Offset = "0x24F1838", VA = "0x24F1838")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C433")]
	[Address(RVA = "0x24F1840", Offset = "0x24F1840", VA = "0x24F1840")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
