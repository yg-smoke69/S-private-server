using COW.GamePlay;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200332A")]
internal class UIPartyGameScene : UIInGameScene
{
	[Token(Token = "0x40137FC")]
	[FieldOffset(Offset = "0x2C8")]
	private UIHudTokenComboController m_ComboCtrl;

	[Token(Token = "0x40137FD")]
	[FieldOffset(Offset = "0x2CC")]
	private UIHudPartyGameMusicShootQuitController m_QuitShootCtrl;

	[Token(Token = "0x40137FE")]
	[FieldOffset(Offset = "0x2D0")]
	private UIHudPartyNPCInteractDialogController m_NPCInteractDialogCtrl;

	[Token(Token = "0x40137FF")]
	[FieldOffset(Offset = "0x2D4")]
	private UIHudPartyGameSoloDanceController m_SoloDanceCtrl;

	[Token(Token = "0x4013800")]
	[FieldOffset(Offset = "0x2D8")]
	private UIHudPartyGameSoloDanceInvitationController m_SoloDanceInvitationCtrl;

	[Token(Token = "0x4013801")]
	[FieldOffset(Offset = "0x2DC")]
	private UIHudPartyGameSoloDanceSettlementController m_SoloDanceSettlementCtrl;

	[Token(Token = "0x4013802")]
	[FieldOffset(Offset = "0x2E0")]
	private UIHudPartyGameSoloPosMarkController m_SoloDancePosMarkCtrl;

	[Token(Token = "0x4013803")]
	[FieldOffset(Offset = "0x2E4")]
	public uint CurrentPhotoingNPCID;

	[Token(Token = "0x4013804")]
	[FieldOffset(Offset = "0x2E8")]
	private uint m_DelayCallSoloDanceBattleStart;

	[Token(Token = "0x4013805")]
	[FieldOffset(Offset = "0x2EC")]
	private float m_SoloDanceLastInviteTime;

	[Token(Token = "0x6015AD5")]
	[Address(RVA = "0x15B14B8", Offset = "0x15B14B8", VA = "0x15B14B8")]
	public UIPartyGameScene()
	{
	}

	[Token(Token = "0x6015AD6")]
	[Address(RVA = "0x15B153C", Offset = "0x15B153C", VA = "0x15B153C", Slot = "11")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6015AD7")]
	[Address(RVA = "0x15B15A0", Offset = "0x15B15A0", VA = "0x15B15A0", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x6015AD8")]
	[Address(RVA = "0x15B1B7C", Offset = "0x15B1B7C", VA = "0x15B1B7C", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015AD9")]
	[Address(RVA = "0x15B21F8", Offset = "0x15B21F8", VA = "0x15B21F8", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6015ADA")]
	[Address(RVA = "0x15B2874", Offset = "0x15B2874", VA = "0x15B2874")]
	private void OnLocalPlayerAdd(object[] data)
	{
	}

	[Token(Token = "0x6015ADB")]
	[Address(RVA = "0x15B2900", Offset = "0x15B2900", VA = "0x15B2900")]
	private void OnShowMusicShoot(object[] data)
	{
	}

	[Token(Token = "0x6015ADC")]
	[Address(RVA = "0x15B2A60", Offset = "0x15B2A60", VA = "0x15B2A60")]
	private void OnShowCombo(object[] data)
	{
	}

	[Token(Token = "0x6015ADD")]
	[Address(RVA = "0x15B2E2C", Offset = "0x15B2E2C", VA = "0x15B2E2C")]
	private void OnPlayerInteractNPC(object[] data)
	{
	}

	[Token(Token = "0x6015ADE")]
	[Address(RVA = "0x15B36C4", Offset = "0x15B36C4", VA = "0x15B36C4")]
	private void OnEnterPhotographMode(object[] data)
	{
	}

	[Token(Token = "0x6015ADF")]
	[Address(RVA = "0x15B3730", Offset = "0x15B3730", VA = "0x15B3730")]
	private void OnExitPhotographMode(object[] data)
	{
	}

	[Token(Token = "0x6015AE0")]
	[Address(RVA = "0x15B337C", Offset = "0x15B337C", VA = "0x15B337C")]
	private void HideAllNPCName(bool hide)
	{
	}

	[Token(Token = "0x6015AE1")]
	[Address(RVA = "0x15B39F4", Offset = "0x15B39F4", VA = "0x15B39F4")]
	private void OnSoloDanceSendInvitation(object[] data)
	{
	}

	[Token(Token = "0x6015AE2")]
	[Address(RVA = "0x15B3B6C", Offset = "0x15B3B6C", VA = "0x15B3B6C")]
	public float GetSoloDanceInvitationCDAmount()
	{
		return default(float);
	}

	[Token(Token = "0x6015AE3")]
	[Address(RVA = "0x15B3DC8", Offset = "0x15B3DC8", VA = "0x15B3DC8")]
	public bool CheckCanSendInvitation()
	{
		return default(bool);
	}

	[Token(Token = "0x6015AE4")]
	[Address(RVA = "0x15B3F1C", Offset = "0x15B3F1C", VA = "0x15B3F1C")]
	private void OnShowSoloDanceHud(object[] data)
	{
	}

	[Token(Token = "0x6015AE5")]
	[Address(RVA = "0x15B4078", Offset = "0x15B4078", VA = "0x15B4078")]
	private void OnShowSoloDancePosMark(object[] data)
	{
	}

	[Token(Token = "0x6015AE6")]
	[Address(RVA = "0x15B4310", Offset = "0x15B4310", VA = "0x15B4310")]
	private void OnShowSoloDanceSettlement(object[] data)
	{
	}

	[Token(Token = "0x6015AE7")]
	[Address(RVA = "0x15B486C", Offset = "0x15B486C", VA = "0x15B486C")]
	private void OnEnterSoloDance(object[] data)
	{
	}

	[Token(Token = "0x6015AE8")]
	[Address(RVA = "0x15B4D1C", Offset = "0x15B4D1C", VA = "0x15B4D1C")]
	private void OnQuitSoloDance(object[] data)
	{
	}

	[Token(Token = "0x6015AE9")]
	[Address(RVA = "0x15B4FC4", Offset = "0x15B4FC4", VA = "0x15B4FC4")]
	private void OnMsgSoloDanceBattleStart(object[] data)
	{
	}

	[Token(Token = "0x6015AEA")]
	[Address(RVA = "0x15B54B8", Offset = "0x15B54B8", VA = "0x15B54B8")]
	private void OnMusicBeatStart(object[] data)
	{
	}

	[Token(Token = "0x6015AEB")]
	[Address(RVA = "0x15B57A8", Offset = "0x15B57A8", VA = "0x15B57A8")]
	private void SoloDanceBattleStart()
	{
	}

	[Token(Token = "0x6015AEC")]
	[Address(RVA = "0x15B5B74", Offset = "0x15B5B74", VA = "0x15B5B74")]
	public new void _003C_003EiFixBaseProxy_OnInit()
	{
	}

	[Token(Token = "0x6015AED")]
	[Address(RVA = "0x15B5B7C", Offset = "0x15B5B7C", VA = "0x15B5B7C")]
	public void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x6015AEE")]
	[Address(RVA = "0x15B5B84", Offset = "0x15B5B84", VA = "0x15B5B84")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015AEF")]
	[Address(RVA = "0x15B5B8C", Offset = "0x15B5B8C", VA = "0x15B5B8C")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}
}
