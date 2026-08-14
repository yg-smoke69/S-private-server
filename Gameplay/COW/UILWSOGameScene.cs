using System;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2003328")]
internal class UILWSOGameScene : UIInGameScene
{
	[Token(Token = "0x40137F0")]
	[FieldOffset(Offset = "0x2C8")]
	private UIHudLWSORoundResultController m_RoundResultController;

	[Token(Token = "0x40137F1")]
	[FieldOffset(Offset = "0x2CC")]
	private UIHudLWSORoundStartController m_RoundStartController;

	[Token(Token = "0x40137F2")]
	[FieldOffset(Offset = "0x2D0")]
	private UIHudCSShopEntryController m_LWSOShopEntryCtrl;

	[Token(Token = "0x40137F3")]
	[FieldOffset(Offset = "0x2D4")]
	private UIHudLWSOLeaderBoardController m_LeaderBoardCtrl;

	[Token(Token = "0x40137F4")]
	[FieldOffset(Offset = "0x2D8")]
	private UIHudLWSOBattleInfoController m_BattleInfoCtrl;

	[Token(Token = "0x40137F5")]
	[FieldOffset(Offset = "0x2DC")]
	private uint m_HideCSShopDelayCallID;

	[Token(Token = "0x40137F6")]
	[FieldOffset(Offset = "0x2E0")]
	private uint m_ShowRoundResultMaskDelayCall;

	[Token(Token = "0x40137F7")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6015AB0")]
	[Address(RVA = "0x1ADED1C", Offset = "0x1ADED1C", VA = "0x1ADED1C")]
	public UILWSOGameScene()
	{
	}

	[Token(Token = "0x6015AB1")]
	[Address(RVA = "0x1ADEDA0", Offset = "0x1ADEDA0", VA = "0x1ADEDA0", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x6015AB2")]
	[Address(RVA = "0x1ADF0EC", Offset = "0x1ADF0EC", VA = "0x1ADF0EC")]
	public void OnNewPhaseStarted(PKPHACPPBEK phase)
	{
	}

	[Token(Token = "0x6015AB3")]
	[Address(RVA = "0x1ADF5C8", Offset = "0x1ADF5C8", VA = "0x1ADF5C8")]
	private void OnMatchMakingPhaseStart(bool matchMaking, bool canWaitMatchEnd)
	{
	}

	[Token(Token = "0x6015AB4")]
	[Address(RVA = "0x1ADF724", Offset = "0x1ADF724", VA = "0x1ADF724")]
	public void OnMiniGameNewPhaseStarted(ELLNEIIPMOE phase)
	{
	}

	[Token(Token = "0x6015AB5")]
	[Address(RVA = "0x1ADFF04", Offset = "0x1ADFF04", VA = "0x1ADFF04")]
	private void HideShopEntry()
	{
	}

	[Token(Token = "0x6015AB6")]
	[Address(RVA = "0x1AE0110", Offset = "0x1AE0110", VA = "0x1AE0110", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015AB7")]
	[Address(RVA = "0x1AE0314", Offset = "0x1AE0314", VA = "0x1AE0314", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6015AB8")]
	[Address(RVA = "0x1AE0518", Offset = "0x1AE0518", VA = "0x1AE0518")]
	private void ShowLeaderBoard(object[] data)
	{
	}

	[Token(Token = "0x6015AB9")]
	[Address(RVA = "0x1AE008C", Offset = "0x1AE008C", VA = "0x1AE008C")]
	private void ShowRoundResult(bool show)
	{
	}

	[Token(Token = "0x6015ABA")]
	[Address(RVA = "0x1AE0008", Offset = "0x1AE0008", VA = "0x1AE0008")]
	private void ShowRoundStart(bool show)
	{
	}

	[Token(Token = "0x6015ABB")]
	[Address(RVA = "0x1AE06D4", Offset = "0x1AE06D4", VA = "0x1AE06D4")]
	public void OnSyncRoundResult(object[] data)
	{
	}

	[Token(Token = "0x6015ABC")]
	[Address(RVA = "0x1AE0858", Offset = "0x1AE0858", VA = "0x1AE0858", Slot = "29")]
	protected override bool IsNeedDirectionRuler()
	{
		return default(bool);
	}

	[Token(Token = "0x6015ABD")]
	[Address(RVA = "0x1AE08B0", Offset = "0x1AE08B0", VA = "0x1AE08B0", Slot = "34")]
	protected override bool IsNeedSafeZoneInfoController()
	{
		return default(bool);
	}

	[Token(Token = "0x6015ABE")]
	[Address(RVA = "0x1AE0908", Offset = "0x1AE0908", VA = "0x1AE0908")]
	protected void ShowShop(object[] data)
	{
	}

	[Token(Token = "0x6015ABF")]
	[Address(RVA = "0x1AE0B20", Offset = "0x1AE0B20", VA = "0x1AE0B20", Slot = "38")]
	protected override void OnOpenHudInPregame()
	{
	}

	[Token(Token = "0x6015AC0")]
	[Address(RVA = "0x1AE0E58", Offset = "0x1AE0E58", VA = "0x1AE0E58", Slot = "20")]
	protected override Type GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x6015AC1")]
	[Address(RVA = "0x1AE0F34", Offset = "0x1AE0F34", VA = "0x1AE0F34")]
	public void SyncLWSORoundResult()
	{
	}

	[Token(Token = "0x6015AC2")]
	[Address(RVA = "0x1AE1030", Offset = "0x1AE1030", VA = "0x1AE1030")]
	private static void _003COnMiniGameNewPhaseStarted_003Em__0()
	{
	}

	[Token(Token = "0x6015AC3")]
	[Address(RVA = "0x1AE10D8", Offset = "0x1AE10D8", VA = "0x1AE10D8")]
	private void _003COnOpenHudInPregame_003Em__1()
	{
	}

	[Token(Token = "0x6015AC4")]
	[Address(RVA = "0x1AE119C", Offset = "0x1AE119C", VA = "0x1AE119C")]
	public void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x6015AC5")]
	[Address(RVA = "0x1AE11A4", Offset = "0x1AE11A4", VA = "0x1AE11A4")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015AC6")]
	[Address(RVA = "0x1AE11AC", Offset = "0x1AE11AC", VA = "0x1AE11AC")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x6015AC7")]
	[Address(RVA = "0x1AE11B4", Offset = "0x1AE11B4", VA = "0x1AE11B4")]
	public bool _003C_003EiFixBaseProxy_IsNeedDirectionRuler()
	{
		return default(bool);
	}

	[Token(Token = "0x6015AC8")]
	[Address(RVA = "0x1AE11BC", Offset = "0x1AE11BC", VA = "0x1AE11BC")]
	public bool _003C_003EiFixBaseProxy_IsNeedSafeZoneInfoController()
	{
		return default(bool);
	}

	[Token(Token = "0x6015AC9")]
	[Address(RVA = "0x1AE11C4", Offset = "0x1AE11C4", VA = "0x1AE11C4")]
	public void _003C_003EiFixBaseProxy_OnOpenHudInPregame()
	{
	}

	[Token(Token = "0x6015ACA")]
	[Address(RVA = "0x1AE11CC", Offset = "0x1AE11CC", VA = "0x1AE11CC")]
	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}
