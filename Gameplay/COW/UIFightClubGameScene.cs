using System;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2003312")]
internal class UIFightClubGameScene : UIInGameScene
{
	[Token(Token = "0x401367C")]
	[FieldOffset(Offset = "0x2C8")]
	private uint m_HideCSShopDelayCallID;

	[Token(Token = "0x401367D")]
	[FieldOffset(Offset = "0x2CC")]
	private UIHudFightClubMatchInfoController m_MatchInfoInfoCtrl;

	[Token(Token = "0x401367E")]
	[FieldOffset(Offset = "0x2D0")]
	private UIHudFightClubRoundTransitionController m_RoundTransitionCtrl;

	[Token(Token = "0x401367F")]
	[FieldOffset(Offset = "0x2D4")]
	private NLGKDGCHAIB m_TakeTurnsShopState;

	[Token(Token = "0x4013680")]
	[FieldOffset(Offset = "0x2D8")]
	private EBDJJIHBALF m_ShopFlow;

	[Token(Token = "0x4013681")]
	[FieldOffset(Offset = "0x2DC")]
	private bool m_WaitingForTakeTurnsShopState;

	[Token(Token = "0x60158CD")]
	[Address(RVA = "0x1DBDA74", Offset = "0x1DBDA74", VA = "0x1DBDA74")]
	public UIFightClubGameScene()
	{
	}

	[Token(Token = "0x60158CE")]
	[Address(RVA = "0x1DBDAF8", Offset = "0x1DBDAF8", VA = "0x1DBDAF8", Slot = "20")]
	protected override Type GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x60158CF")]
	[Address(RVA = "0x1DBDBD4", Offset = "0x1DBDBD4", VA = "0x1DBDBD4", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x60158D0")]
	[Address(RVA = "0x1DBDF2C", Offset = "0x1DBDF2C", VA = "0x1DBDF2C", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x60158D1")]
	[Address(RVA = "0x1DBE198", Offset = "0x1DBE198", VA = "0x1DBE198", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x60158D2")]
	[Address(RVA = "0x1DBE404", Offset = "0x1DBE404", VA = "0x1DBE404")]
	private void OnCSNewPhaseStarted(object[] param)
	{
	}

	[Token(Token = "0x60158D3")]
	[Address(RVA = "0x1DBEA74", Offset = "0x1DBEA74", VA = "0x1DBEA74")]
	private void ShowRoundResult(object[] data)
	{
	}

	[Token(Token = "0x60158D4")]
	[Address(RVA = "0x1DBEC78", Offset = "0x1DBEC78", VA = "0x1DBEC78")]
	private void ShowShop(object[] data)
	{
	}

	[Token(Token = "0x60158D5")]
	[Address(RVA = "0x1DBEF24", Offset = "0x1DBEF24", VA = "0x1DBEF24")]
	private void ShowDefaultShop()
	{
	}

	[Token(Token = "0x60158D6")]
	[Address(RVA = "0x1DBF170", Offset = "0x1DBF170", VA = "0x1DBF170")]
	private void ShowTakeTurnsShop(NLGKDGCHAIB shopState, int curRound, int maxRound)
	{
	}

	[Token(Token = "0x60158D7")]
	[Address(RVA = "0x1DBF484", Offset = "0x1DBF484", VA = "0x1DBF484")]
	public bool WaitingForTakeTurnsShopState()
	{
		return default(bool);
	}

	[Token(Token = "0x60158D8")]
	[Address(RVA = "0x1DBF4DC", Offset = "0x1DBF4DC", VA = "0x1DBF4DC")]
	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x60158D9")]
	[Address(RVA = "0x1DBF4E4", Offset = "0x1DBF4E4", VA = "0x1DBF4E4")]
	public void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x60158DA")]
	[Address(RVA = "0x1DBF4EC", Offset = "0x1DBF4EC", VA = "0x1DBF4EC")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x60158DB")]
	[Address(RVA = "0x1DBF4F4", Offset = "0x1DBF4F4", VA = "0x1DBF4F4")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}
}
