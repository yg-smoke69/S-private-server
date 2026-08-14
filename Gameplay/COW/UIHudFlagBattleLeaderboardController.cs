using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003350")]
internal class UIHudFlagBattleLeaderboardController : UIHUDTeamBattleScoreBoardController<UIHUDTeamBattleScoreBoardItemController>
{
	[Token(Token = "0x40138C2")]
	[FieldOffset(Offset = "0x44")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x6015D07")]
	[Address(RVA = "0x1BAF184", Offset = "0x1BAF184", VA = "0x1BAF184")]
	public UIHudFlagBattleLeaderboardController()
	{
	}

	[Token(Token = "0x6015D08")]
	[Address(RVA = "0x1BAF1E8", Offset = "0x1BAF1E8", VA = "0x1BAF1E8")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015D09")]
	[Address(RVA = "0x1BAF290", Offset = "0x1BAF290", VA = "0x1BAF290", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6015D0A")]
	[Address(RVA = "0x1BAF3E4", Offset = "0x1BAF3E4", VA = "0x1BAF3E4", Slot = "31")]
	protected override void SetInfoType()
	{
	}

	[Token(Token = "0x6015D0B")]
	[Address(RVA = "0x1BAF594", Offset = "0x1BAF594", VA = "0x1BAF594", Slot = "33")]
	public override void RegisterUIEvent()
	{
	}

	[Token(Token = "0x6015D0C")]
	[Address(RVA = "0x1BAF8D4", Offset = "0x1BAF8D4", VA = "0x1BAF8D4", Slot = "34")]
	public override void UnRegisterUIEvent()
	{
	}

	[Token(Token = "0x6015D0D")]
	[Address(RVA = "0x1BAFC14", Offset = "0x1BAFC14", VA = "0x1BAFC14")]
	private void OnToggleRoundInfo(object[] parap)
	{
	}

	[Token(Token = "0x6015D0E")]
	[Address(RVA = "0x1BAFCC8", Offset = "0x1BAFCC8", VA = "0x1BAFCC8")]
	private void OnTeamScoreChange(object[] data)
	{
	}

	[Token(Token = "0x6015D0F")]
	[Address(RVA = "0x1BAFDF0", Offset = "0x1BAFDF0", VA = "0x1BAFDF0")]
	private void UpdateTeamScore(int teamIndex, int score)
	{
	}

	[Token(Token = "0x6015D10")]
	[Address(RVA = "0x1BAFEE4", Offset = "0x1BAFEE4", VA = "0x1BAFEE4")]
	protected void OnScoreChanged(object[] param)
	{
	}

	[Token(Token = "0x6015D11")]
	[Address(RVA = "0x1BAFFFC", Offset = "0x1BAFFFC", VA = "0x1BAFFFC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6015D12")]
	[Address(RVA = "0x1BB0000", Offset = "0x1BB0000", VA = "0x1BB0000")]
	public void _003C_003EiFixBaseProxy_SetInfoType()
	{
	}

	[Token(Token = "0x6015D13")]
	[Address(RVA = "0x1BB0004", Offset = "0x1BB0004", VA = "0x1BB0004")]
	public void _003C_003EiFixBaseProxy_RegisterUIEvent()
	{
	}

	[Token(Token = "0x6015D14")]
	[Address(RVA = "0x1BB0008", Offset = "0x1BB0008", VA = "0x1BB0008")]
	public void _003C_003EiFixBaseProxy_UnRegisterUIEvent()
	{
	}
}
