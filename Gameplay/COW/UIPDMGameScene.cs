using System;
using COW.GamePlay;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200332B")]
internal class UIPDMGameScene : UITeamModeBaseGameScene
{
	[Token(Token = "0x4013806")]
	[FieldOffset(Offset = "0x2D8")]
	private UIHudPDMTimeScoreInfoController m_TimeScoreInfoCtrl;

	[Token(Token = "0x4013807")]
	[FieldOffset(Offset = "0x2DC")]
	private UIHudTrainingDeadSummaryController m_DeadSummaryCtrl;

	[Token(Token = "0x6015AF0")]
	[Address(RVA = "0x15A098C", Offset = "0x15A098C", VA = "0x15A098C")]
	public UIPDMGameScene()
	{
	}

	[Token(Token = "0x6015AF1")]
	[Address(RVA = "0x15A0994", Offset = "0x15A0994", VA = "0x15A0994", Slot = "40")]
	protected override void OnOpenHudBeginFight()
	{
	}

	[Token(Token = "0x6015AF2")]
	[Address(RVA = "0x15A0A20", Offset = "0x15A0A20", VA = "0x15A0A20", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015AF3")]
	[Address(RVA = "0x15A0CF4", Offset = "0x15A0CF4", VA = "0x15A0CF4", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6015AF4")]
	[Address(RVA = "0x15A0FC8", Offset = "0x15A0FC8", VA = "0x15A0FC8", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x6015AF5")]
	[Address(RVA = "0x15A142C", Offset = "0x15A142C", VA = "0x15A142C", Slot = "20")]
	protected override Type GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x6015AF6")]
	[Address(RVA = "0x15A1508", Offset = "0x15A1508", VA = "0x15A1508", Slot = "29")]
	protected override bool IsNeedDirectionRuler()
	{
		return default(bool);
	}

	[Token(Token = "0x6015AF7")]
	[Address(RVA = "0x15A1560", Offset = "0x15A1560", VA = "0x15A1560", Slot = "45")]
	protected override bool ShowTeammateInfo()
	{
		return default(bool);
	}

	[Token(Token = "0x6015AF8")]
	[Address(RVA = "0x15A15B8", Offset = "0x15A15B8", VA = "0x15A15B8", Slot = "42")]
	protected override bool ShowChatBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x6015AF9")]
	[Address(RVA = "0x15A1610", Offset = "0x15A1610", VA = "0x15A1610", Slot = "43")]
	protected override bool ShowItemMarkBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x6015AFA")]
	[Address(RVA = "0x15A1668", Offset = "0x15A1668", VA = "0x15A1668", Slot = "48")]
	protected override bool CanAutoPopShop()
	{
		return default(bool);
	}

	[Token(Token = "0x6015AFB")]
	[Address(RVA = "0x15A17F4", Offset = "0x15A17F4", VA = "0x15A17F4", Slot = "46")]
	protected override void OnGameVoiceHudCreated()
	{
	}

	[Token(Token = "0x6015AFC")]
	[Address(RVA = "0x15A1858", Offset = "0x15A1858", VA = "0x15A1858", Slot = "38")]
	protected override void OnOpenHudInPregame()
	{
	}

	[Token(Token = "0x6015AFD")]
	[Address(RVA = "0x15A1B90", Offset = "0x15A1B90", VA = "0x15A1B90")]
	private void OnDeadSummaryShow(object[] data)
	{
	}

	[Token(Token = "0x6015AFE")]
	[Address(RVA = "0x15A1D84", Offset = "0x15A1D84", VA = "0x15A1D84")]
	private void OnDeadSummaryHide(object[] data)
	{
	}

	[Token(Token = "0x6015AFF")]
	[Address(RVA = "0x15A1E90", Offset = "0x15A1E90", VA = "0x15A1E90")]
	protected void OnKillCntChanged(object[] data)
	{
	}

	[Token(Token = "0x6015B00")]
	[Address(RVA = "0x15A2210", Offset = "0x15A2210", VA = "0x15A2210")]
	protected void OnLocalPlayerDead(object[] data)
	{
	}

	[Token(Token = "0x6015B01")]
	[Address(RVA = "0x15A23B4", Offset = "0x15A23B4", VA = "0x15A23B4")]
	private void _003COnOpenHudInPregame_003Em__0()
	{
	}

	[Token(Token = "0x6015B02")]
	[Address(RVA = "0x15A2478", Offset = "0x15A2478", VA = "0x15A2478")]
	public void _003C_003EiFixBaseProxy_OnOpenHudBeginFight()
	{
	}

	[Token(Token = "0x6015B03")]
	[Address(RVA = "0x15A2480", Offset = "0x15A2480", VA = "0x15A2480")]
	public new void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015B04")]
	[Address(RVA = "0x15A2488", Offset = "0x15A2488", VA = "0x15A2488")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x6015B05")]
	[Address(RVA = "0x15A2490", Offset = "0x15A2490", VA = "0x15A2490")]
	public new void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x6015B06")]
	[Address(RVA = "0x15A2498", Offset = "0x15A2498", VA = "0x15A2498")]
	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x6015B07")]
	[Address(RVA = "0x15A24A0", Offset = "0x15A24A0", VA = "0x15A24A0")]
	public bool _003C_003EiFixBaseProxy_IsNeedDirectionRuler()
	{
		return default(bool);
	}

	[Token(Token = "0x6015B08")]
	[Address(RVA = "0x15A24A8", Offset = "0x15A24A8", VA = "0x15A24A8")]
	public bool _003C_003EiFixBaseProxy_ShowTeammateInfo()
	{
		return default(bool);
	}

	[Token(Token = "0x6015B09")]
	[Address(RVA = "0x15A24B0", Offset = "0x15A24B0", VA = "0x15A24B0")]
	public bool _003C_003EiFixBaseProxy_ShowChatBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x6015B0A")]
	[Address(RVA = "0x15A24B8", Offset = "0x15A24B8", VA = "0x15A24B8")]
	public bool _003C_003EiFixBaseProxy_ShowItemMarkBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x6015B0B")]
	[Address(RVA = "0x15A24C0", Offset = "0x15A24C0", VA = "0x15A24C0")]
	public bool _003C_003EiFixBaseProxy_CanAutoPopShop()
	{
		return default(bool);
	}

	[Token(Token = "0x6015B0C")]
	[Address(RVA = "0x15A24C8", Offset = "0x15A24C8", VA = "0x15A24C8")]
	public void _003C_003EiFixBaseProxy_OnGameVoiceHudCreated()
	{
	}

	[Token(Token = "0x6015B0D")]
	[Address(RVA = "0x15A24D0", Offset = "0x15A24D0", VA = "0x15A24D0")]
	public new void _003C_003EiFixBaseProxy_OnOpenHudInPregame()
	{
	}
}
