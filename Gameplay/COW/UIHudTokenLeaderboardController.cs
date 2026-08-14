using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023D7")]
internal class UIHudTokenLeaderboardController : UIHUDTeamBattleScoreBoardController<UIHUDTeamBattleScoreBoardItemController>
{
	[Token(Token = "0x20023D8")]
	public enum InfoType
	{
		[Token(Token = "0x400DEC9")]
		TokenCount,
		[Token(Token = "0x400DECA")]
		TotalScore
	}

	[Token(Token = "0x600CA2F")]
	[Address(RVA = "0x15823F8", Offset = "0x15823F8", VA = "0x15823F8")]
	public UIHudTokenLeaderboardController()
	{
	}

	[Token(Token = "0x600CA30")]
	[Address(RVA = "0x158245C", Offset = "0x158245C", VA = "0x158245C")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CA31")]
	[Address(RVA = "0x1582504", Offset = "0x1582504", VA = "0x1582504", Slot = "33")]
	public override void RegisterUIEvent()
	{
	}

	[Token(Token = "0x600CA32")]
	[Address(RVA = "0x158271C", Offset = "0x158271C", VA = "0x158271C", Slot = "34")]
	public override void UnRegisterUIEvent()
	{
	}

	[Token(Token = "0x600CA33")]
	[Address(RVA = "0x1582934", Offset = "0x1582934", VA = "0x1582934", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CA34")]
	[Address(RVA = "0x1582A18", Offset = "0x1582A18", VA = "0x1582A18", Slot = "31")]
	protected override void SetInfoType()
	{
	}

	[Token(Token = "0x600CA35")]
	[Address(RVA = "0x1582BC8", Offset = "0x1582BC8", VA = "0x1582BC8")]
	private void OnTokenPlayerInfoChanged(object[] param)
	{
	}

	[Token(Token = "0x600CA36")]
	[Address(RVA = "0x1582DD0", Offset = "0x1582DD0", VA = "0x1582DD0")]
	private void OnTeamScoreChange(object[] data)
	{
	}

	[Token(Token = "0x600CA37")]
	[Address(RVA = "0x1582EF8", Offset = "0x1582EF8", VA = "0x1582EF8")]
	private void UpdateTeamScore(int teamIndex, int score)
	{
	}

	[Token(Token = "0x600CA38")]
	[Address(RVA = "0x1582FC8", Offset = "0x1582FC8", VA = "0x1582FC8")]
	public void _003C_003EiFixBaseProxy_RegisterUIEvent()
	{
	}

	[Token(Token = "0x600CA39")]
	[Address(RVA = "0x1582FCC", Offset = "0x1582FCC", VA = "0x1582FCC")]
	public void _003C_003EiFixBaseProxy_UnRegisterUIEvent()
	{
	}

	[Token(Token = "0x600CA3A")]
	[Address(RVA = "0x1582FD0", Offset = "0x1582FD0", VA = "0x1582FD0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CA3B")]
	[Address(RVA = "0x1582FD4", Offset = "0x1582FD4", VA = "0x1582FD4")]
	public void _003C_003EiFixBaseProxy_SetInfoType()
	{
	}
}
