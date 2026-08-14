using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026D5")]
internal class UIHudAOHTeamScoreController : UIHUDTeamBattleScoreBoardController<UIHUDTeamBattleScoreBoardItemController>
{
	[Token(Token = "0x600EAF1")]
	[Address(RVA = "0x163C1E0", Offset = "0x163C1E0", VA = "0x163C1E0")]
	public UIHudAOHTeamScoreController()
	{
	}

	[Token(Token = "0x600EAF2")]
	[Address(RVA = "0x163C244", Offset = "0x163C244", VA = "0x163C244")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EAF3")]
	[Address(RVA = "0x163C2EC", Offset = "0x163C2EC", VA = "0x163C2EC", Slot = "33")]
	public override void RegisterUIEvent()
	{
	}

	[Token(Token = "0x600EAF4")]
	[Address(RVA = "0x163C5C4", Offset = "0x163C5C4", VA = "0x163C5C4", Slot = "34")]
	public override void UnRegisterUIEvent()
	{
	}

	[Token(Token = "0x600EAF5")]
	[Address(RVA = "0x163C89C", Offset = "0x163C89C", VA = "0x163C89C", Slot = "32")]
	protected override ResourceID GetTitileResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EAF6")]
	[Address(RVA = "0x163C94C", Offset = "0x163C94C", VA = "0x163C94C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EAF7")]
	[Address(RVA = "0x163CA30", Offset = "0x163CA30", VA = "0x163CA30", Slot = "31")]
	protected override void SetInfoType()
	{
	}

	[Token(Token = "0x600EAF8")]
	[Address(RVA = "0x163CBE0", Offset = "0x163CBE0", VA = "0x163CBE0")]
	protected void OnScoreChanged(object[] param)
	{
	}

	[Token(Token = "0x600EAF9")]
	[Address(RVA = "0x163CCF8", Offset = "0x163CCF8", VA = "0x163CCF8")]
	private void OnTeamScoreChange(object[] data)
	{
	}

	[Token(Token = "0x600EAFA")]
	[Address(RVA = "0x163CE20", Offset = "0x163CE20", VA = "0x163CE20")]
	private void UpdateTeamScore(int teamIndex, int score)
	{
	}

	[Token(Token = "0x600EAFB")]
	[Address(RVA = "0x163CEF0", Offset = "0x163CEF0", VA = "0x163CEF0")]
	public void _003C_003EiFixBaseProxy_RegisterUIEvent()
	{
	}

	[Token(Token = "0x600EAFC")]
	[Address(RVA = "0x163CEF4", Offset = "0x163CEF4", VA = "0x163CEF4")]
	public void _003C_003EiFixBaseProxy_UnRegisterUIEvent()
	{
	}

	[Token(Token = "0x600EAFD")]
	[Address(RVA = "0x163CEF8", Offset = "0x163CEF8", VA = "0x163CEF8")]
	public ResourceID _003C_003EiFixBaseProxy_GetTitileResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EAFE")]
	[Address(RVA = "0x163CEFC", Offset = "0x163CEFC", VA = "0x163CEFC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EAFF")]
	[Address(RVA = "0x163CF00", Offset = "0x163CF00", VA = "0x163CF00")]
	public void _003C_003EiFixBaseProxy_SetInfoType()
	{
	}
}
