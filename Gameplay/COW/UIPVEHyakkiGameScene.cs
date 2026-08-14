using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200332C")]
internal class UIPVEHyakkiGameScene : UIInGameScene
{
	[Token(Token = "0x4013808")]
	[FieldOffset(Offset = "0x2C8")]
	private UIHudBuffListController m_BuffListCtrl;

	[Token(Token = "0x4013809")]
	[FieldOffset(Offset = "0x2CC")]
	private UIHUDPVEGameTargetController m_GameTargetController;

	[Token(Token = "0x401380A")]
	[FieldOffset(Offset = "0x2D0")]
	private UIHUDPVEBossSubtitleController m_BossSubtitleController;

	[Token(Token = "0x401380B")]
	[FieldOffset(Offset = "0x2D4")]
	private PVEMissionHUDManager m_PVEMissionHUDManager;

	[Token(Token = "0x401380C")]
	[FieldOffset(Offset = "0x2D8")]
	private PVECopywriting m_Copywriting;

	[Token(Token = "0x6015B0E")]
	[Address(RVA = "0x15A4EA4", Offset = "0x15A4EA4", VA = "0x15A4EA4")]
	public UIPVEHyakkiGameScene()
	{
	}

	[Token(Token = "0x6015B0F")]
	[Address(RVA = "0x15A4F28", Offset = "0x15A4F28", VA = "0x15A4F28", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x6015B10")]
	[Address(RVA = "0x15A53C4", Offset = "0x15A53C4", VA = "0x15A53C4", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015B11")]
	[Address(RVA = "0x15A5768", Offset = "0x15A5768", VA = "0x15A5768", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6015B12")]
	[Address(RVA = "0x15A5AA4", Offset = "0x15A5AA4", VA = "0x15A5AA4", Slot = "21")]
	protected override void CloseAllUIs()
	{
	}

	[Token(Token = "0x6015B13")]
	[Address(RVA = "0x15A5B18", Offset = "0x15A5B18", VA = "0x15A5B18")]
	private void OnPVEBuyReviveShow(object[] param)
	{
	}

	[Token(Token = "0x6015B14")]
	[Address(RVA = "0x15A6124", Offset = "0x15A6124", VA = "0x15A6124")]
	private void OnEPChanged(object[] data)
	{
	}

	[Token(Token = "0x6015B15")]
	[Address(RVA = "0x15A52EC", Offset = "0x15A52EC", VA = "0x15A52EC")]
	private void InitPVEMissionUIManager()
	{
	}

	[Token(Token = "0x6015B16")]
	[Address(RVA = "0x15A6428", Offset = "0x15A6428", VA = "0x15A6428")]
	private void OnRuleTipCome(object[] param)
	{
	}

	[Token(Token = "0x6015B17")]
	[Address(RVA = "0x15A667C", Offset = "0x15A667C", VA = "0x15A667C")]
	private void OnRoundTargetCome(object[] param)
	{
	}

	[Token(Token = "0x6015B18")]
	[Address(RVA = "0x15A6874", Offset = "0x15A6874", VA = "0x15A6874")]
	private void OnBossSkillSubtitleCome(object[] param)
	{
	}

	[Token(Token = "0x6015B19")]
	[Address(RVA = "0x15A69C4", Offset = "0x15A69C4", VA = "0x15A69C4")]
	private void OnBossRandomSubtitleCome(object[] missionInfo)
	{
	}

	[Token(Token = "0x6015B1A")]
	[Address(RVA = "0x15A6604", Offset = "0x15A6604", VA = "0x15A6604")]
	private void ProcessMissionTipCome(string content)
	{
	}

	[Token(Token = "0x6015B1B")]
	[Address(RVA = "0x15A6AD4", Offset = "0x15A6AD4", VA = "0x15A6AD4")]
	private void OnShowMatchOver(object[] param)
	{
	}

	[Token(Token = "0x6015B1C")]
	[Address(RVA = "0x15A6BE8", Offset = "0x15A6BE8", VA = "0x15A6BE8")]
	public void ShowPVEExitGameBtn(float exitCountDown, Action returnBtnCallBack)
	{
	}

	[Token(Token = "0x6015B1D")]
	[Address(RVA = "0x15A5ED8", Offset = "0x15A5ED8", VA = "0x15A5ED8")]
	private void UpdateSubtitle(SubtitleInfo info)
	{
	}

	[Token(Token = "0x6015B1E")]
	[Address(RVA = "0x15A6D34", Offset = "0x15A6D34", VA = "0x15A6D34")]
	public void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x6015B1F")]
	[Address(RVA = "0x15A6D3C", Offset = "0x15A6D3C", VA = "0x15A6D3C")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015B20")]
	[Address(RVA = "0x15A6D44", Offset = "0x15A6D44", VA = "0x15A6D44")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x6015B21")]
	[Address(RVA = "0x15A6D4C", Offset = "0x15A6D4C", VA = "0x15A6D4C")]
	public void _003C_003EiFixBaseProxy_CloseAllUIs()
	{
	}
}
