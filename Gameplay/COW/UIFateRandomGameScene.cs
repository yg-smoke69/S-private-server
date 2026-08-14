using System;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2003311")]
internal class UIFateRandomGameScene : UIInGameScene
{
	[Token(Token = "0x4013678")]
	[FieldOffset(Offset = "0x2C8")]
	private UIFateRandomGameSubmode_Base m_subModeScene;

	[Token(Token = "0x4013679")]
	[FieldOffset(Offset = "0x2CC")]
	private DIEOGHJDNMJ m_subMode;

	[Token(Token = "0x401367A")]
	[FieldOffset(Offset = "0x2D0")]
	private bool m_isStartFight;

	[Token(Token = "0x401367B")]
	[FieldOffset(Offset = "0x2D4")]
	private UIHudPopupController m_waitTip;

	[Token(Token = "0x60158BF")]
	[Address(RVA = "0x1DBC488", Offset = "0x1DBC488", VA = "0x1DBC488")]
	public UIFateRandomGameScene()
	{
	}

	[Token(Token = "0x60158C0")]
	[Address(RVA = "0x1DBC50C", Offset = "0x1DBC50C", VA = "0x1DBC50C")]
	public void OnConfirmSubMode(DIEOGHJDNMJ msgModeId, bool isStartFight)
	{
	}

	[Token(Token = "0x60158C1")]
	[Address(RVA = "0x1DBC7FC", Offset = "0x1DBC7FC", VA = "0x1DBC7FC", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x60158C2")]
	[Address(RVA = "0x1DBC888", Offset = "0x1DBC888", VA = "0x1DBC888", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x60158C3")]
	[Address(RVA = "0x1DBCAB4", Offset = "0x1DBCAB4", VA = "0x1DBCAB4")]
	private void OnGameLoadingOver(object[] data)
	{
	}

	[Token(Token = "0x60158C4")]
	[Address(RVA = "0x1DBCBB8", Offset = "0x1DBCBB8", VA = "0x1DBCBB8")]
	private void ShowFateRandomTeamZone(object[] data)
	{
	}

	[Token(Token = "0x60158C5")]
	[Address(RVA = "0x1DBCD24", Offset = "0x1DBCD24", VA = "0x1DBCD24")]
	private void OnFateRandomStartFight(object[] data)
	{
	}

	[Token(Token = "0x60158C6")]
	[Address(RVA = "0x1DBCC20", Offset = "0x1DBCC20", VA = "0x1DBCC20")]
	private void CloseTip()
	{
	}

	[Token(Token = "0x60158C7")]
	[Address(RVA = "0x1DBCDA0", Offset = "0x1DBCDA0", VA = "0x1DBCDA0", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x60158C8")]
	[Address(RVA = "0x1DBCFC0", Offset = "0x1DBCFC0", VA = "0x1DBCFC0", Slot = "20")]
	protected override Type GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x60158C9")]
	[Address(RVA = "0x1DBD09C", Offset = "0x1DBD09C", VA = "0x1DBD09C")]
	public void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x60158CA")]
	[Address(RVA = "0x1DBD0A4", Offset = "0x1DBD0A4", VA = "0x1DBD0A4")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x60158CB")]
	[Address(RVA = "0x1DBD0AC", Offset = "0x1DBD0AC", VA = "0x1DBD0AC")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x60158CC")]
	[Address(RVA = "0x1DBD0B4", Offset = "0x1DBD0B4", VA = "0x1DBD0B4")]
	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}
