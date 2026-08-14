using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032FF")]
internal class UIArmsRaceGameScene : UIInGameScene
{
	[Token(Token = "0x4013604")]
	[FieldOffset(Offset = "0x2C8")]
	private UIHudArmsListController m_ArmsListWndCtrl;

	[Token(Token = "0x4013605")]
	[FieldOffset(Offset = "0x2CC")]
	private UIHUDArmsRaceMatchInfoController m_UIHUDArmsRaceMatchInfoController;

	[Token(Token = "0x4013606")]
	[FieldOffset(Offset = "0x2D0")]
	private UIHUDArmsRaceKillPointsController m_UIHUDArmsRaceKillPointsController;

	[Token(Token = "0x4013607")]
	[FieldOffset(Offset = "0x2D4")]
	private UIHUDArmsRaceTeamMatchInfoController m_UIHUDArmsRaceTeamMatchInfoController;

	[Token(Token = "0x4013608")]
	[FieldOffset(Offset = "0x2D8")]
	private UIHUDTeamArmsRaceScoreBoardController m_UIHUDTeamArmsRaceScoreBoardController;

	[Token(Token = "0x4013609")]
	[FieldOffset(Offset = "0x2DC")]
	private UIHUDArmsRaceBonusCardController m_BonusCardController;

	[Token(Token = "0x401360A")]
	[FieldOffset(Offset = "0x2E0")]
	private bool m_IntroInfoDone;

	[Token(Token = "0x6015801")]
	[Address(RVA = "0x1E7126C", Offset = "0x1E7126C", VA = "0x1E7126C")]
	public UIArmsRaceGameScene()
	{
	}

	[Token(Token = "0x6015802")]
	[Address(RVA = "0x1E712F0", Offset = "0x1E712F0", VA = "0x1E712F0", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x6015803")]
	[Address(RVA = "0x1E71750", Offset = "0x1E71750", VA = "0x1E71750", Slot = "28")]
	protected override UIHudWeaponInfoController OpenCommonWeaponPanel()
	{
		return null;
	}

	[Token(Token = "0x6015804")]
	[Address(RVA = "0x1E71800", Offset = "0x1E71800", VA = "0x1E71800", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015805")]
	[Address(RVA = "0x1E71A6C", Offset = "0x1E71A6C", VA = "0x1E71A6C", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6015806")]
	[Address(RVA = "0x1E71CD8", Offset = "0x1E71CD8", VA = "0x1E71CD8", Slot = "21")]
	protected override void CloseAllUIs()
	{
	}

	[Token(Token = "0x6015807")]
	[Address(RVA = "0x1E71D44", Offset = "0x1E71D44", VA = "0x1E71D44")]
	public void OnArmsListDataReady(object[] data)
	{
	}

	[Token(Token = "0x6015808")]
	[Address(RVA = "0x1E7200C", Offset = "0x1E7200C", VA = "0x1E7200C")]
	public void OnIntroInfoDone(object[] data)
	{
	}

	[Token(Token = "0x6015809")]
	[Address(RVA = "0x1E71DAC", Offset = "0x1E71DAC", VA = "0x1E71DAC")]
	private void TryShowArmsList()
	{
	}

	[Token(Token = "0x601580A")]
	[Address(RVA = "0x1E7207C", Offset = "0x1E7207C", VA = "0x1E7207C", Slot = "29")]
	protected override bool IsNeedDirectionRuler()
	{
		return default(bool);
	}

	[Token(Token = "0x601580B")]
	[Address(RVA = "0x1E720D4", Offset = "0x1E720D4", VA = "0x1E720D4", Slot = "30")]
	protected override bool IsNeedQuickSwitchHUD()
	{
		return default(bool);
	}

	[Token(Token = "0x601580C")]
	[Address(RVA = "0x1E7212C", Offset = "0x1E7212C", VA = "0x1E7212C", Slot = "31")]
	protected override bool IsNeedMedkitController()
	{
		return default(bool);
	}

	[Token(Token = "0x601580D")]
	[Address(RVA = "0x1E72184", Offset = "0x1E72184", VA = "0x1E72184", Slot = "34")]
	protected override bool IsNeedSafeZoneInfoController()
	{
		return default(bool);
	}

	[Token(Token = "0x601580E")]
	[Address(RVA = "0x1E721DC", Offset = "0x1E721DC", VA = "0x1E721DC", Slot = "38")]
	protected override void OnOpenHudInPregame()
	{
	}

	[Token(Token = "0x601580F")]
	[Address(RVA = "0x1E72514", Offset = "0x1E72514", VA = "0x1E72514", Slot = "40")]
	protected override void OnOpenHudBeginFight()
	{
	}

	[Token(Token = "0x6015810")]
	[Address(RVA = "0x1E72704", Offset = "0x1E72704", VA = "0x1E72704")]
	public void OpenScoreBoard()
	{
	}

	[Token(Token = "0x6015811")]
	[Address(RVA = "0x1E72808", Offset = "0x1E72808", VA = "0x1E72808", Slot = "20")]
	protected override Type GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x6015812")]
	[Address(RVA = "0x1E7293C", Offset = "0x1E7293C", VA = "0x1E7293C")]
	private void OnBonusCardCome(object[] data)
	{
	}

	[Token(Token = "0x6015813")]
	[Address(RVA = "0x1E72AD8", Offset = "0x1E72AD8", VA = "0x1E72AD8")]
	private void OnStartMatchEndShow(object[] data)
	{
	}

	[Token(Token = "0x6015814")]
	[Address(RVA = "0x1E72C44", Offset = "0x1E72C44", VA = "0x1E72C44")]
	private void _003COnOpenHudInPregame_003Em__0()
	{
	}

	[Token(Token = "0x6015815")]
	[Address(RVA = "0x1E72D08", Offset = "0x1E72D08", VA = "0x1E72D08")]
	public void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x6015816")]
	[Address(RVA = "0x1E72D10", Offset = "0x1E72D10", VA = "0x1E72D10")]
	public UIHudWeaponInfoController _003C_003EiFixBaseProxy_OpenCommonWeaponPanel()
	{
		return null;
	}

	[Token(Token = "0x6015817")]
	[Address(RVA = "0x1E72D18", Offset = "0x1E72D18", VA = "0x1E72D18")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015818")]
	[Address(RVA = "0x1E72D20", Offset = "0x1E72D20", VA = "0x1E72D20")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x6015819")]
	[Address(RVA = "0x1E72D28", Offset = "0x1E72D28", VA = "0x1E72D28")]
	public void _003C_003EiFixBaseProxy_CloseAllUIs()
	{
	}

	[Token(Token = "0x601581A")]
	[Address(RVA = "0x1E72D30", Offset = "0x1E72D30", VA = "0x1E72D30")]
	public bool _003C_003EiFixBaseProxy_IsNeedDirectionRuler()
	{
		return default(bool);
	}

	[Token(Token = "0x601581B")]
	[Address(RVA = "0x1E72D38", Offset = "0x1E72D38", VA = "0x1E72D38")]
	public bool _003C_003EiFixBaseProxy_IsNeedQuickSwitchHUD()
	{
		return default(bool);
	}

	[Token(Token = "0x601581C")]
	[Address(RVA = "0x1E72D40", Offset = "0x1E72D40", VA = "0x1E72D40")]
	public bool _003C_003EiFixBaseProxy_IsNeedMedkitController()
	{
		return default(bool);
	}

	[Token(Token = "0x601581D")]
	[Address(RVA = "0x1E72D48", Offset = "0x1E72D48", VA = "0x1E72D48")]
	public bool _003C_003EiFixBaseProxy_IsNeedSafeZoneInfoController()
	{
		return default(bool);
	}

	[Token(Token = "0x601581E")]
	[Address(RVA = "0x1E72D50", Offset = "0x1E72D50", VA = "0x1E72D50")]
	public void _003C_003EiFixBaseProxy_OnOpenHudInPregame()
	{
	}

	[Token(Token = "0x601581F")]
	[Address(RVA = "0x1E72D58", Offset = "0x1E72D58", VA = "0x1E72D58")]
	public void _003C_003EiFixBaseProxy_OnOpenHudBeginFight()
	{
	}

	[Token(Token = "0x6015820")]
	[Address(RVA = "0x1E72D60", Offset = "0x1E72D60", VA = "0x1E72D60")]
	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}
