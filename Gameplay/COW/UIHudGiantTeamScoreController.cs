using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002118")]
internal class UIHudGiantTeamScoreController : UIHUDTeamBattleScoreBoardController<UIHudADSTeamScoreItemController>
{
	[Token(Token = "0x600AD32")]
	[Address(RVA = "0x18972A0", Offset = "0x18972A0", VA = "0x18972A0")]
	public UIHudGiantTeamScoreController()
	{
	}

	[Token(Token = "0x600AD33")]
	[Address(RVA = "0x1897304", Offset = "0x1897304", VA = "0x1897304")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AD34")]
	[Address(RVA = "0x18973AC", Offset = "0x18973AC", VA = "0x18973AC", Slot = "33")]
	public override void RegisterUIEvent()
	{
	}

	[Token(Token = "0x600AD35")]
	[Address(RVA = "0x18977B4", Offset = "0x18977B4", VA = "0x18977B4", Slot = "34")]
	public override void UnRegisterUIEvent()
	{
	}

	[Token(Token = "0x600AD36")]
	[Address(RVA = "0x1897BBC", Offset = "0x1897BBC", VA = "0x1897BBC", Slot = "32")]
	protected override ResourceID GetTitileResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AD37")]
	[Address(RVA = "0x1897C6C", Offset = "0x1897C6C", VA = "0x1897C6C", Slot = "44")]
	protected virtual void OnEscotTimeChanged(object[] param)
	{
	}

	[Token(Token = "0x600AD38")]
	[Address(RVA = "0x1897D84", Offset = "0x1897D84", VA = "0x1897D84", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AD39")]
	[Address(RVA = "0x1897E68", Offset = "0x1897E68", VA = "0x1897E68", Slot = "31")]
	protected override void SetInfoType()
	{
	}

	[Token(Token = "0x600AD3A")]
	[Address(RVA = "0x1898018", Offset = "0x1898018", VA = "0x1898018")]
	protected void OnScoreChanged(object[] param)
	{
	}

	[Token(Token = "0x600AD3B")]
	[Address(RVA = "0x1898130", Offset = "0x1898130", VA = "0x1898130")]
	private void OnTeamScoreChange(object[] data)
	{
	}

	[Token(Token = "0x600AD3C")]
	[Address(RVA = "0x1898328", Offset = "0x1898328", VA = "0x1898328")]
	private void OnCurrentMoveDistanceChanged(object[] data)
	{
	}

	[Token(Token = "0x600AD3D")]
	[Address(RVA = "0x18985AC", Offset = "0x18985AC", VA = "0x18985AC")]
	private void OnLastTeamScoreChanged(object[] data)
	{
	}

	[Token(Token = "0x600AD3E")]
	[Address(RVA = "0x1898258", Offset = "0x1898258", VA = "0x1898258")]
	private void UpdateTeamScore(int teamIndex, int score)
	{
	}

	[Token(Token = "0x600AD3F")]
	[Address(RVA = "0x1898830", Offset = "0x1898830", VA = "0x1898830")]
	private void Refresh1v1PlayerWin(object[] param)
	{
	}

	[Token(Token = "0x600AD40")]
	[Address(RVA = "0x1898A5C", Offset = "0x1898A5C", VA = "0x1898A5C")]
	public void _003C_003EiFixBaseProxy_RegisterUIEvent()
	{
	}

	[Token(Token = "0x600AD41")]
	[Address(RVA = "0x1898A60", Offset = "0x1898A60", VA = "0x1898A60")]
	public void _003C_003EiFixBaseProxy_UnRegisterUIEvent()
	{
	}

	[Token(Token = "0x600AD42")]
	[Address(RVA = "0x1898A64", Offset = "0x1898A64", VA = "0x1898A64")]
	public ResourceID _003C_003EiFixBaseProxy_GetTitileResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AD43")]
	[Address(RVA = "0x1898A68", Offset = "0x1898A68", VA = "0x1898A68")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AD44")]
	[Address(RVA = "0x1898A6C", Offset = "0x1898A6C", VA = "0x1898A6C")]
	public void _003C_003EiFixBaseProxy_SetInfoType()
	{
	}
}
