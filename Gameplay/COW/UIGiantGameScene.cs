using System;
using COW.GamePlay;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200331A")]
internal class UIGiantGameScene : UIInGameScene
{
	[Token(Token = "0x40136F1")]
	[FieldOffset(Offset = "0x2C8")]
	private UIHudGiantMatchInfoController m_GiantMatchInfoCtrl;

	[Token(Token = "0x40136F2")]
	[FieldOffset(Offset = "0x2CC")]
	private UIHudEscortVehicleInfoController m_VehicleInfoCtrl;

	[Token(Token = "0x40136F3")]
	[FieldOffset(Offset = "0x2D0")]
	private UIHudEscortBossNameController m_EscortBossNameCtrl;

	[Token(Token = "0x40136F4")]
	[FieldOffset(Offset = "0x2D4")]
	private UIHudEscortVehicleProgressController m_VehicleProgressCtrl;

	[Token(Token = "0x40136F5")]
	[FieldOffset(Offset = "0x2D8")]
	private UIHudEscortMaskController m_MaskCtrl;

	[Token(Token = "0x40136F6")]
	[FieldOffset(Offset = "0x2DC")]
	private UIHudGameShowInfoController m_ShowInfoCtrl;

	[Token(Token = "0x40136F7")]
	private const string Attack_StartGameKey = "T_23_GG_ESCORT_TUTORIAL_ATTACK_DES";

	[Token(Token = "0x40136F8")]
	private const string Denfence_StartGameKey = "T_23_GG_ESCORT_TUTORIAL_DEFENCE_DES";

	[Token(Token = "0x40136F9")]
	[FieldOffset(Offset = "0x2E0")]
	private UIHudEscortEquipSetSelectionController m_EquipCtrl;

	[Token(Token = "0x40136FA")]
	[FieldOffset(Offset = "0x2E4")]
	private UIHudFeedZoneController m_FeedCtrl;

	[Token(Token = "0x40136FB")]
	[FieldOffset(Offset = "0x2E8")]
	private UIHudEscortTipsController m_EscortTipCtrl;

	[Token(Token = "0x40136FC")]
	[FieldOffset(Offset = "0x2EC")]
	private uint m_DelayCallId;

	[Token(Token = "0x40136FD")]
	[FieldOffset(Offset = "0x2F0")]
	private bool m_IntroShowed;

	[Token(Token = "0x601590B")]
	[Address(RVA = "0x2194EE4", Offset = "0x2194EE4", VA = "0x2194EE4")]
	public UIGiantGameScene()
	{
	}

	[Token(Token = "0x601590C")]
	[Address(RVA = "0x2194F68", Offset = "0x2194F68", VA = "0x2194F68")]
	public bool JudgeOpenSelection()
	{
		return default(bool);
	}

	[Token(Token = "0x601590D")]
	[Address(RVA = "0x219503C", Offset = "0x219503C", VA = "0x219503C")]
	public void OpenEquipSetSelection()
	{
	}

	[Token(Token = "0x601590E")]
	[Address(RVA = "0x21957A0", Offset = "0x21957A0", VA = "0x21957A0")]
	public void OnCloseEquipSetSelection(object[] data)
	{
	}

	[Token(Token = "0x601590F")]
	[Address(RVA = "0x21958AC", Offset = "0x21958AC", VA = "0x21958AC", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x6015910")]
	[Address(RVA = "0x2195CC0", Offset = "0x2195CC0", VA = "0x2195CC0", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015911")]
	[Address(RVA = "0x2195F94", Offset = "0x2195F94", VA = "0x2195F94", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6015912")]
	[Address(RVA = "0x219634C", Offset = "0x219634C", VA = "0x219634C")]
	public void SetEscortTips(string content, IHAAMHPPLMG playerid)
	{
	}

	[Token(Token = "0x6015913")]
	[Address(RVA = "0x21965B8", Offset = "0x21965B8", VA = "0x21965B8", Slot = "16")]
	protected override void OnMaskClosed()
	{
	}

	[Token(Token = "0x6015914")]
	[Address(RVA = "0x2196624", Offset = "0x2196624", VA = "0x2196624")]
	public void OnEnterPregame()
	{
	}

	[Token(Token = "0x6015915")]
	[Address(RVA = "0x2196990", Offset = "0x2196990", VA = "0x2196990", Slot = "25")]
	protected override void OnPlayerGodBegin(object[] param)
	{
	}

	[Token(Token = "0x6015916")]
	[Address(RVA = "0x2196B6C", Offset = "0x2196B6C", VA = "0x2196B6C")]
	public void OnIntroEnd()
	{
	}

	[Token(Token = "0x6015917")]
	[Address(RVA = "0x2196D6C", Offset = "0x2196D6C", VA = "0x2196D6C")]
	private void OnShowEscortInfo(object[] param)
	{
	}

	[Token(Token = "0x6015918")]
	[Address(RVA = "0x2197048", Offset = "0x2197048", VA = "0x2197048")]
	private void OnShowEscortMask(object[] param)
	{
	}

	[Token(Token = "0x6015919")]
	[Address(RVA = "0x21971B4", Offset = "0x21971B4", VA = "0x21971B4")]
	private void OnNewPhaseStarted(object[] param)
	{
	}

	[Token(Token = "0x601591A")]
	[Address(RVA = "0x2197EA8", Offset = "0x2197EA8", VA = "0x2197EA8")]
	private void OnStartMatchEndShow(object[] data)
	{
	}

	[Token(Token = "0x601591B")]
	[Address(RVA = "0x2197F48", Offset = "0x2197F48", VA = "0x2197F48", Slot = "20")]
	protected override Type GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x601591C")]
	[Address(RVA = "0x2198024", Offset = "0x2198024", VA = "0x2198024")]
	private void _003COpenEquipSetSelection_003Em__0()
	{
	}

	[Token(Token = "0x601591D")]
	[Address(RVA = "0x21980F8", Offset = "0x21980F8", VA = "0x21980F8")]
	private void _003COnEnterPregame_003Em__1()
	{
	}

	[Token(Token = "0x601591E")]
	[Address(RVA = "0x21981BC", Offset = "0x21981BC", VA = "0x21981BC")]
	public void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x601591F")]
	[Address(RVA = "0x21981C4", Offset = "0x21981C4", VA = "0x21981C4")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015920")]
	[Address(RVA = "0x21981CC", Offset = "0x21981CC", VA = "0x21981CC")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x6015921")]
	[Address(RVA = "0x21981D4", Offset = "0x21981D4", VA = "0x21981D4")]
	public void _003C_003EiFixBaseProxy_OnMaskClosed()
	{
	}

	[Token(Token = "0x6015922")]
	[Address(RVA = "0x21981DC", Offset = "0x21981DC", VA = "0x21981DC")]
	public void _003C_003EiFixBaseProxy_OnPlayerGodBegin(object[] P0)
	{
	}

	[Token(Token = "0x6015923")]
	[Address(RVA = "0x21981E4", Offset = "0x21981E4", VA = "0x21981E4")]
	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}
