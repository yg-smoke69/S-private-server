using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200233F")]
public class UIHudSceneEditOptionController : UIBaseController, _Attribute
{
	[Token(Token = "0x400DB94")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSceneEditOptionView m_View;

	[Token(Token = "0x400DB95")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelSceneEdit m_ModelSceneEdit;

	[Token(Token = "0x400DB96")]
	[FieldOffset(Offset = "0x30")]
	private UIHudSceneEditCodeSearchController m_SceneEditCodeSearchCtrl;

	[Token(Token = "0x400DB97")]
	private const string ResMgrIconActive = "UI_Customize_Resource-_icon01";

	[Token(Token = "0x400DB98")]
	private const string ResMgrIconInActive = "UI_Customize_Resource _icon";

	[Token(Token = "0x400DB99")]
	[FieldOffset(Offset = "0x34")]
	private float m_autoEnterEditTime;

	[Token(Token = "0x400DB9A")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 m_autoMovePlayerTo;

	[Token(Token = "0x400DB9B")]
	[FieldOffset(Offset = "0x44")]
	private bool m_isCollapseBtn;

	[Token(Token = "0x400DB9C")]
	[FieldOffset(Offset = "0x48")]
	private UIUGCDebuggerConsole m_debugConsoleWindow;

	[Token(Token = "0x400DB9D")]
	[FieldOffset(Offset = "0x4C")]
	private UIUGCDebuggerOpen m_debugOpenWindow;

	[Token(Token = "0x400DB9E")]
	[FieldOffset(Offset = "0x50")]
	private FFDCDKNGNDC m_curCameraMode;

	[Token(Token = "0x600C3EB")]
	[Address(RVA = "0x24E78A0", Offset = "0x24E78A0", VA = "0x24E78A0")]
	public UIHudSceneEditOptionController()
	{
	}

	[Token(Token = "0x600C3EC")]
	[Address(RVA = "0x24E7938", Offset = "0x24E7938", VA = "0x24E7938")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C3ED")]
	[Address(RVA = "0x24E79DC", Offset = "0x24E79DC", VA = "0x24E79DC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C3EE")]
	[Address(RVA = "0x24E9038", Offset = "0x24E9038", VA = "0x24E9038", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C3EF")]
	[Address(RVA = "0x24E9398", Offset = "0x24E9398", VA = "0x24E9398", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600C3F0")]
	[Address(RVA = "0x24E9634", Offset = "0x24E9634", VA = "0x24E9634", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600C3F1")]
	[Address(RVA = "0x24E96C8", Offset = "0x24E96C8", VA = "0x24E96C8")]
	private void Update()
	{
	}

	[Token(Token = "0x600C3F2")]
	[Address(RVA = "0x24E9D44", Offset = "0x24E9D44", VA = "0x24E9D44")]
	private void OnClickChangeLookBtn()
	{
	}

	[Token(Token = "0x600C3F3")]
	[Address(RVA = "0x24E9904", Offset = "0x24E9904", VA = "0x24E9904")]
	private void OnClickChangeEditBtn()
	{
	}

	[Token(Token = "0x600C3F4")]
	[Address(RVA = "0x24EA0FC", Offset = "0x24EA0FC", VA = "0x24EA0FC")]
	private void OnClickSaveSceneBtn()
	{
	}

	[Token(Token = "0x600C3F5")]
	[Address(RVA = "0x24EA594", Offset = "0x24EA594", VA = "0x24EA594")]
	private void OnClickResMgrBtn()
	{
	}

	[Token(Token = "0x600C3F6")]
	[Address(RVA = "0x24EA718", Offset = "0x24EA718", VA = "0x24EA718")]
	private void OnClickBackBtn()
	{
	}

	[Token(Token = "0x600C3F7")]
	[Address(RVA = "0x24EA928", Offset = "0x24EA928", VA = "0x24EA928")]
	private void OnQuitPreviewBtn()
	{
	}

	[Token(Token = "0x600C3F8")]
	[Address(RVA = "0x24EABE4", Offset = "0x24EABE4", VA = "0x24EABE4")]
	private void OnPreviewModeBtn()
	{
	}

	[Token(Token = "0x600C3F9")]
	[Address(RVA = "0x24EADAC", Offset = "0x24EADAC", VA = "0x24EADAC")]
	private void OnClickCollapseBtn()
	{
	}

	[Token(Token = "0x600C3FA")]
	[Address(RVA = "0x24EAE14", Offset = "0x24EAE14", VA = "0x24EAE14")]
	private void OnClickExpandBtn()
	{
	}

	[Token(Token = "0x600C3FB")]
	[Address(RVA = "0x24EAE7C", Offset = "0x24EAE7C", VA = "0x24EAE7C")]
	private void OnClickOpenConsoleBtn()
	{
	}

	[Token(Token = "0x600C3FC")]
	[Address(RVA = "0x24EB004", Offset = "0x24EB004", VA = "0x24EB004")]
	private void OnClickGoToMatchBtn()
	{
	}

	[Token(Token = "0x600C3FD")]
	[Address(RVA = "0x24EB18C", Offset = "0x24EB18C", VA = "0x24EB18C")]
	private void OnModeChanged(object[] data)
	{
	}

	[Token(Token = "0x600C3FE")]
	[Address(RVA = "0x24EB1F4", Offset = "0x24EB1F4", VA = "0x24EB1F4")]
	private void OnResMgrModeChanged(object[] data)
	{
	}

	[Token(Token = "0x600C3FF")]
	[Address(RVA = "0x24EB320", Offset = "0x24EB320", VA = "0x24EB320")]
	private void OnHandleChangeCamera(object[] data)
	{
	}

	[Token(Token = "0x600C400")]
	[Address(RVA = "0x24E84EC", Offset = "0x24E84EC", VA = "0x24E84EC")]
	private void RefreshButtonVisble()
	{
	}

	[Token(Token = "0x600C401")]
	[Address(RVA = "0x24EB400", Offset = "0x24EB400", VA = "0x24EB400")]
	private void OnEnterPreviewMode(object[] data)
	{
	}

	[Token(Token = "0x600C402")]
	[Address(RVA = "0x24EBACC", Offset = "0x24EBACC", VA = "0x24EBACC")]
	private void OnClickGMVerifyBtn()
	{
	}

	[Token(Token = "0x600C403")]
	[Address(RVA = "0x24EBB20", Offset = "0x24EBB20", VA = "0x24EBB20")]
	private void TutorialChangeEditBtn(object[] data)
	{
	}

	[Token(Token = "0x600C404")]
	[Address(RVA = "0x24EBD04", Offset = "0x24EBD04", VA = "0x24EBD04")]
	private void TutorialDebugOpenBtn(object[] data)
	{
	}

	[Token(Token = "0x600C405")]
	[Address(RVA = "0x24EBEE8", Offset = "0x24EBEE8", VA = "0x24EBEE8")]
	private void TutorialDebugConsoleBtn(object[] data)
	{
	}

	[Token(Token = "0x600C406")]
	[Address(RVA = "0x24EC0CC", Offset = "0x24EC0CC", VA = "0x24EC0CC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C407")]
	[Address(RVA = "0x24EC0D4", Offset = "0x24EC0D4", VA = "0x24EC0D4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
