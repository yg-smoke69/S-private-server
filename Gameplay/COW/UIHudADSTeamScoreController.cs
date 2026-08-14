using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F9B")]
internal class UIHudADSTeamScoreController : UIHUDTeamBattleScoreBoardController<UIHudADSTeamScoreItemController>
{
	[Token(Token = "0x6009D55")]
	[Address(RVA = "0x16378C8", Offset = "0x16378C8", VA = "0x16378C8")]
	public UIHudADSTeamScoreController()
	{
	}

	[Token(Token = "0x6009D56")]
	[Address(RVA = "0x163792C", Offset = "0x163792C", VA = "0x163792C")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009D57")]
	[Address(RVA = "0x16379D4", Offset = "0x16379D4", VA = "0x16379D4", Slot = "33")]
	public override void RegisterUIEvent()
	{
	}

	[Token(Token = "0x6009D58")]
	[Address(RVA = "0x1637D14", Offset = "0x1637D14", VA = "0x1637D14", Slot = "34")]
	public override void UnRegisterUIEvent()
	{
	}

	[Token(Token = "0x6009D59")]
	[Address(RVA = "0x1638054", Offset = "0x1638054", VA = "0x1638054", Slot = "32")]
	protected override ResourceID GetTitileResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009D5A")]
	[Address(RVA = "0x1638104", Offset = "0x1638104", VA = "0x1638104", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009D5B")]
	[Address(RVA = "0x16381E8", Offset = "0x16381E8", VA = "0x16381E8", Slot = "31")]
	protected override void SetInfoType()
	{
	}

	[Token(Token = "0x6009D5C")]
	[Address(RVA = "0x1638398", Offset = "0x1638398", VA = "0x1638398")]
	protected void OnScoreChanged(object[] param)
	{
	}

	[Token(Token = "0x6009D5D")]
	[Address(RVA = "0x16384B0", Offset = "0x16384B0", VA = "0x16384B0")]
	private void OnTeamScoreChange(object[] data)
	{
	}

	[Token(Token = "0x6009D5E")]
	[Address(RVA = "0x16385D8", Offset = "0x16385D8", VA = "0x16385D8")]
	private void UpdateTeamScore(int teamIndex, int score)
	{
	}

	[Token(Token = "0x6009D5F")]
	[Address(RVA = "0x16386A8", Offset = "0x16386A8", VA = "0x16386A8")]
	private void Refresh1v1PlayerWin(object[] param)
	{
	}

	[Token(Token = "0x6009D60")]
	[Address(RVA = "0x1638A14", Offset = "0x1638A14", VA = "0x1638A14")]
	public void _003C_003EiFixBaseProxy_RegisterUIEvent()
	{
	}

	[Token(Token = "0x6009D61")]
	[Address(RVA = "0x1638A18", Offset = "0x1638A18", VA = "0x1638A18")]
	public void _003C_003EiFixBaseProxy_UnRegisterUIEvent()
	{
	}

	[Token(Token = "0x6009D62")]
	[Address(RVA = "0x1638A1C", Offset = "0x1638A1C", VA = "0x1638A1C")]
	public ResourceID _003C_003EiFixBaseProxy_GetTitileResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009D63")]
	[Address(RVA = "0x1638A20", Offset = "0x1638A20", VA = "0x1638A20")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009D64")]
	[Address(RVA = "0x1638A24", Offset = "0x1638A24", VA = "0x1638A24")]
	public void _003C_003EiFixBaseProxy_SetInfoType()
	{
	}
}
