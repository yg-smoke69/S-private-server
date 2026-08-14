using System;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x200330F")]
internal class UICSStrikeOutGameScene : UIInGameScene
{
	[Token(Token = "0x4013670")]
	[FieldOffset(Offset = "0x2C8")]
	private UIHudCSShopEntryController m_CSSOShopEntryCtrl;

	[Token(Token = "0x4013671")]
	[FieldOffset(Offset = "0x2CC")]
	private UIHudCSSORoundResultController m_RoundResultController;

	[Token(Token = "0x4013672")]
	[FieldOffset(Offset = "0x2D0")]
	private UIHudCSSORoundStartController m_RoundStartController;

	[Token(Token = "0x4013673")]
	[FieldOffset(Offset = "0x2D4")]
	private UIHudCSSOLeaderboardController m_CSSOLeaderBoardCtrl;

	[Token(Token = "0x4013674")]
	[FieldOffset(Offset = "0x2D8")]
	private UIHudCSSOHoldController m_CSSOHoldCtrl;

	[Token(Token = "0x4013675")]
	[FieldOffset(Offset = "0x2DC")]
	private uint m_HideCSShopDelayCallID;

	[Token(Token = "0x4013676")]
	[FieldOffset(Offset = "0x2E0")]
	private uint m_ShowRoundResultMaskDelayCall;

	[Token(Token = "0x4013677")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6015899")]
	[Address(RVA = "0x1456BCC", Offset = "0x1456BCC", VA = "0x1456BCC")]
	public UICSStrikeOutGameScene()
	{
	}

	[Token(Token = "0x601589A")]
	[Address(RVA = "0x1456C50", Offset = "0x1456C50", VA = "0x1456C50", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x601589B")]
	[Address(RVA = "0x14570B8", Offset = "0x14570B8", VA = "0x14570B8")]
	public void OnNewPhaseStarted(BHLBBILAHHI phase)
	{
	}

	[Token(Token = "0x601589C")]
	[Address(RVA = "0x1457200", Offset = "0x1457200", VA = "0x1457200")]
	private void OnMatchMakingPhaseStart()
	{
	}

	[Token(Token = "0x601589D")]
	[Address(RVA = "0x14573A4", Offset = "0x14573A4", VA = "0x14573A4")]
	public void OnMiniGameNewPhaseStarted(JBAIBAGPHGM phase)
	{
	}

	[Token(Token = "0x601589E")]
	[Address(RVA = "0x1457CA8", Offset = "0x1457CA8", VA = "0x1457CA8")]
	public void OnMatchEnd()
	{
	}

	[Token(Token = "0x601589F")]
	[Address(RVA = "0x1457A9C", Offset = "0x1457A9C", VA = "0x1457A9C")]
	private void HideShopEntry()
	{
	}

	[Token(Token = "0x60158A0")]
	[Address(RVA = "0x1457DC4", Offset = "0x1457DC4", VA = "0x1457DC4", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x60158A1")]
	[Address(RVA = "0x1458038", Offset = "0x1458038", VA = "0x1458038", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x60158A2")]
	[Address(RVA = "0x14582AC", Offset = "0x14582AC", VA = "0x14582AC")]
	private void ShowLeaderBoard(object[] data)
	{
	}

	[Token(Token = "0x60158A3")]
	[Address(RVA = "0x1457C24", Offset = "0x1457C24", VA = "0x1457C24")]
	private void ShowRoundResult(bool show)
	{
	}

	[Token(Token = "0x60158A4")]
	[Address(RVA = "0x1457BA0", Offset = "0x1457BA0", VA = "0x1457BA0")]
	private void ShowRoundStart(bool show)
	{
	}

	[Token(Token = "0x60158A5")]
	[Address(RVA = "0x1458458", Offset = "0x1458458", VA = "0x1458458")]
	private void ShowHold(object[] data)
	{
	}

	[Token(Token = "0x60158A6")]
	[Address(RVA = "0x14584E0", Offset = "0x14584E0", VA = "0x14584E0")]
	public void OnSyncRoundResult(object[] data)
	{
	}

	[Token(Token = "0x60158A7")]
	[Address(RVA = "0x1458664", Offset = "0x1458664", VA = "0x1458664", Slot = "29")]
	protected override bool IsNeedDirectionRuler()
	{
		return default(bool);
	}

	[Token(Token = "0x60158A8")]
	[Address(RVA = "0x14586BC", Offset = "0x14586BC", VA = "0x14586BC", Slot = "34")]
	protected override bool IsNeedSafeZoneInfoController()
	{
		return default(bool);
	}

	[Token(Token = "0x60158A9")]
	[Address(RVA = "0x1458714", Offset = "0x1458714", VA = "0x1458714", Slot = "38")]
	protected override void OnOpenHudInPregame()
	{
	}

	[Token(Token = "0x60158AA")]
	[Address(RVA = "0x1458A4C", Offset = "0x1458A4C", VA = "0x1458A4C", Slot = "20")]
	protected override Type GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x60158AB")]
	[Address(RVA = "0x1458AA4", Offset = "0x1458AA4", VA = "0x1458AA4")]
	private static void _003COnMiniGameNewPhaseStarted_003Em__0()
	{
	}

	[Token(Token = "0x60158AC")]
	[Address(RVA = "0x1458B4C", Offset = "0x1458B4C", VA = "0x1458B4C")]
	private void _003COnOpenHudInPregame_003Em__1()
	{
	}

	[Token(Token = "0x60158AD")]
	[Address(RVA = "0x1458C10", Offset = "0x1458C10", VA = "0x1458C10")]
	public void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x60158AE")]
	[Address(RVA = "0x1458C18", Offset = "0x1458C18", VA = "0x1458C18")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x60158AF")]
	[Address(RVA = "0x1458C20", Offset = "0x1458C20", VA = "0x1458C20")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x60158B0")]
	[Address(RVA = "0x1458C28", Offset = "0x1458C28", VA = "0x1458C28")]
	public bool _003C_003EiFixBaseProxy_IsNeedDirectionRuler()
	{
		return default(bool);
	}

	[Token(Token = "0x60158B1")]
	[Address(RVA = "0x1458C30", Offset = "0x1458C30", VA = "0x1458C30")]
	public bool _003C_003EiFixBaseProxy_IsNeedSafeZoneInfoController()
	{
		return default(bool);
	}

	[Token(Token = "0x60158B2")]
	[Address(RVA = "0x1458C38", Offset = "0x1458C38", VA = "0x1458C38")]
	public void _003C_003EiFixBaseProxy_OnOpenHudInPregame()
	{
	}

	[Token(Token = "0x60158B3")]
	[Address(RVA = "0x1458C40", Offset = "0x1458C40", VA = "0x1458C40")]
	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}
