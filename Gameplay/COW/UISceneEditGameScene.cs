using System;
using COW.GamePlay;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200332F")]
internal class UISceneEditGameScene : UIInGameScene
{
	[Token(Token = "0x4013815")]
	[FieldOffset(Offset = "0x2C8")]
	private UIHudSceneEditConfirmWndController uiSceneEditConfirmWnd;

	[Token(Token = "0x4013816")]
	[FieldOffset(Offset = "0x2CC")]
	private JPPGAJBAAKK m_CurrentGame;

	[Token(Token = "0x4013817")]
	[FieldOffset(Offset = "0x2D0")]
	private UIHudBtnWorkshopPhotographController m_PhotoBtnCtrl;

	[Token(Token = "0x4013818")]
	[FieldOffset(Offset = "0x2D4")]
	private UIHudWorkshopPhotographModeController m_PhotoCtrl;

	[Token(Token = "0x4013819")]
	[FieldOffset(Offset = "0x2D8")]
	private UIHudSceneEditCameraHeightController m_CameraHeightCtrl;

	[Token(Token = "0x401381A")]
	[FieldOffset(Offset = "0x2DC")]
	private UIHudSceneEditFuncAttributeSettingController m_FuncAttributeSettingCtrl;

	[Token(Token = "0x401381B")]
	[FieldOffset(Offset = "0x2E0")]
	private UIHudEntityGetterController m_EntityGetter;

	[Token(Token = "0x401381C")]
	[FieldOffset(Offset = "0x2E4")]
	private UIHudSceneEditActionAttributeController m_AttributeController;

	[Token(Token = "0x401381D")]
	[FieldOffset(Offset = "0x2E8")]
	private UIHudSceneEditActionAttributeColorPanelController m_AttributeControllerColor;

	[Token(Token = "0x401381E")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6015B52")]
	[Address(RVA = "0x14ADAEC", Offset = "0x14ADAEC", VA = "0x14ADAEC")]
	public UISceneEditGameScene()
	{
	}

	[Token(Token = "0x6015B53")]
	[Address(RVA = "0x14ADB70", Offset = "0x14ADB70", VA = "0x14ADB70", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x6015B54")]
	[Address(RVA = "0x14AE758", Offset = "0x14AE758", VA = "0x14AE758", Slot = "11")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6015B55")]
	[Address(RVA = "0x14AE9C8", Offset = "0x14AE9C8", VA = "0x14AE9C8", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015B56")]
	[Address(RVA = "0x14AEF74", Offset = "0x14AEF74", VA = "0x14AEF74", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6015B57")]
	[Address(RVA = "0x14AF500", Offset = "0x14AF500", VA = "0x14AF500", Slot = "14")]
	protected override bool OnCheckInviteNtf()
	{
		return default(bool);
	}

	[Token(Token = "0x6015B58")]
	[Address(RVA = "0x14AF558", Offset = "0x14AF558", VA = "0x14AF558")]
	private bool OnEscapeClick()
	{
		return default(bool);
	}

	[Token(Token = "0x6015B59")]
	[Address(RVA = "0x14AF76C", Offset = "0x14AF76C", VA = "0x14AF76C")]
	private void OnHandleConfirmWnd(object[] args)
	{
	}

	[Token(Token = "0x6015B5A")]
	[Address(RVA = "0x14AFDBC", Offset = "0x14AFDBC", VA = "0x14AFDBC")]
	private void OnHandleHttpRequestError(object[] args)
	{
	}

	[Token(Token = "0x6015B5B")]
	[Address(RVA = "0x14B0024", Offset = "0x14B0024", VA = "0x14B0024")]
	private void OnTakingPhoto(object[] args)
	{
	}

	[Token(Token = "0x6015B5C")]
	[Address(RVA = "0x14B01C0", Offset = "0x14B01C0", VA = "0x14B01C0")]
	private void OnOpenTips(object[] data)
	{
	}

	[Token(Token = "0x6015B5D")]
	[Address(RVA = "0x14B0944", Offset = "0x14B0944", VA = "0x14B0944")]
	private void ShowAttributeController(bool isShow)
	{
	}

	[Token(Token = "0x6015B5E")]
	[Address(RVA = "0x14B0A64", Offset = "0x14B0A64", VA = "0x14B0A64")]
	private void OnShowObjectAttributeColorPanel(object[] data)
	{
	}

	[Token(Token = "0x6015B5F")]
	[Address(RVA = "0x14B0D58", Offset = "0x14B0D58", VA = "0x14B0D58")]
	private void OnShowObjectAttribute(object[] data)
	{
	}

	[Token(Token = "0x6015B60")]
	[Address(RVA = "0x14B14A4", Offset = "0x14B14A4", VA = "0x14B14A4")]
	private void OnShowFuncAttributeSettingUI(object[] data)
	{
	}

	[Token(Token = "0x6015B61")]
	[Address(RVA = "0x14B1604", Offset = "0x14B1604", VA = "0x14B1604")]
	private void OnEntityGetter(object[] data)
	{
	}

	[Token(Token = "0x6015B62")]
	[Address(RVA = "0x14B1B78", Offset = "0x14B1B78", VA = "0x14B1B78")]
	private static void _003COpenCommonHud_003Em__0()
	{
	}

	[Token(Token = "0x6015B63")]
	[Address(RVA = "0x14B1C38", Offset = "0x14B1C38", VA = "0x14B1C38")]
	public void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x6015B64")]
	[Address(RVA = "0x14B1C40", Offset = "0x14B1C40", VA = "0x14B1C40")]
	public new void _003C_003EiFixBaseProxy_OnInit()
	{
	}

	[Token(Token = "0x6015B65")]
	[Address(RVA = "0x14B1C48", Offset = "0x14B1C48", VA = "0x14B1C48")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015B66")]
	[Address(RVA = "0x14B1C50", Offset = "0x14B1C50", VA = "0x14B1C50")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x6015B67")]
	[Address(RVA = "0x14B1C58", Offset = "0x14B1C58", VA = "0x14B1C58")]
	public bool _003C_003EiFixBaseProxy_OnCheckInviteNtf()
	{
		return default(bool);
	}
}
