using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032FE")]
internal class UIAOHGameScene : UITeamModeBaseGameScene
{
	[Token(Token = "0x4013601")]
	[FieldOffset(Offset = "0x2D8")]
	private UIHudAOHTeamScoreController m_UIHUDTeamScoreBoardController;

	[Token(Token = "0x4013602")]
	[FieldOffset(Offset = "0x2DC")]
	private UIHudGameShowInfoController m_ShowInfoCtrl;

	[Token(Token = "0x4013603")]
	[FieldOffset(Offset = "0x2E0")]
	private UIHudAOHLevelUpHintController m_LevelUpHint;

	[Token(Token = "0x60157F3")]
	[Address(RVA = "0x29FB930", Offset = "0x29FB930", VA = "0x29FB930")]
	public UIAOHGameScene()
	{
	}

	[Token(Token = "0x60157F4")]
	[Address(RVA = "0x29FB938", Offset = "0x29FB938", VA = "0x29FB938", Slot = "40")]
	protected override void OnOpenHudBeginFight()
	{
	}

	[Token(Token = "0x60157F5")]
	[Address(RVA = "0x29FB9C4", Offset = "0x29FB9C4", VA = "0x29FB9C4", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x60157F6")]
	[Address(RVA = "0x29FBC74", Offset = "0x29FBC74", VA = "0x29FBC74", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x60157F7")]
	[Address(RVA = "0x29FBDA8", Offset = "0x29FBDA8", VA = "0x29FBDA8", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x60157F8")]
	[Address(RVA = "0x29FBEDC", Offset = "0x29FBEDC", VA = "0x29FBEDC", Slot = "47")]
	protected override void ShowTeamScore(object[] data)
	{
	}

	[Token(Token = "0x60157F9")]
	[Address(RVA = "0x29FBFE8", Offset = "0x29FBFE8", VA = "0x29FBFE8")]
	private void OnShowEscortInfo(object[] param)
	{
	}

	[Token(Token = "0x60157FA")]
	[Address(RVA = "0x29FC2C4", Offset = "0x29FC2C4", VA = "0x29FC2C4", Slot = "20")]
	protected override Type GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x60157FB")]
	[Address(RVA = "0x29FC3A0", Offset = "0x29FC3A0", VA = "0x29FC3A0")]
	public void _003C_003EiFixBaseProxy_OnOpenHudBeginFight()
	{
	}

	[Token(Token = "0x60157FC")]
	[Address(RVA = "0x29FC3A8", Offset = "0x29FC3A8", VA = "0x29FC3A8")]
	public new void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x60157FD")]
	[Address(RVA = "0x29FC3B0", Offset = "0x29FC3B0", VA = "0x29FC3B0")]
	public new void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x60157FE")]
	[Address(RVA = "0x29FC3B8", Offset = "0x29FC3B8", VA = "0x29FC3B8")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x60157FF")]
	[Address(RVA = "0x29FC3C0", Offset = "0x29FC3C0", VA = "0x29FC3C0")]
	public void _003C_003EiFixBaseProxy_ShowTeamScore(object[] P0)
	{
	}

	[Token(Token = "0x6015800")]
	[Address(RVA = "0x29FC3C8", Offset = "0x29FC3C8", VA = "0x29FC3C8")]
	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}
