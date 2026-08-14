using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200334E")]
internal class UIHudControlLeaderboardController : UIHUDTeamBattleScoreBoardController<UIHUDTeamBattleScoreBoardItemController>
{
	[Token(Token = "0x6015CE4")]
	[Address(RVA = "0x1360598", Offset = "0x1360598", VA = "0x1360598")]
	public UIHudControlLeaderboardController()
	{
	}

	[Token(Token = "0x6015CE5")]
	[Address(RVA = "0x13605FC", Offset = "0x13605FC", VA = "0x13605FC")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015CE6")]
	[Address(RVA = "0x13606A4", Offset = "0x13606A4", VA = "0x13606A4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6015CE7")]
	[Address(RVA = "0x1360788", Offset = "0x1360788", VA = "0x1360788", Slot = "31")]
	protected override void SetInfoType()
	{
	}

	[Token(Token = "0x6015CE8")]
	[Address(RVA = "0x1360938", Offset = "0x1360938", VA = "0x1360938", Slot = "33")]
	public override void RegisterUIEvent()
	{
	}

	[Token(Token = "0x6015CE9")]
	[Address(RVA = "0x1360C20", Offset = "0x1360C20", VA = "0x1360C20", Slot = "34")]
	public override void UnRegisterUIEvent()
	{
	}

	[Token(Token = "0x6015CEA")]
	[Address(RVA = "0x1360F08", Offset = "0x1360F08", VA = "0x1360F08")]
	private void OnSyncLeaderBoard(object[] data)
	{
	}

	[Token(Token = "0x6015CEB")]
	[Address(RVA = "0x1361398", Offset = "0x1361398", VA = "0x1361398")]
	private void OnCSNewPhaseStarted(object[] param)
	{
	}

	[Token(Token = "0x6015CEC")]
	[Address(RVA = "0x136148C", Offset = "0x136148C", VA = "0x136148C")]
	private void OnToggleRoundInfo(object[] parap)
	{
	}

	[Token(Token = "0x6015CED")]
	[Address(RVA = "0x1361540", Offset = "0x1361540", VA = "0x1361540")]
	private void OnTeamScoreChange(object[] data)
	{
	}

	[Token(Token = "0x6015CEE")]
	[Address(RVA = "0x1361668", Offset = "0x1361668", VA = "0x1361668")]
	private void UpdateTeamScore(int teamIndex, int score)
	{
	}

	[Token(Token = "0x6015CEF")]
	[Address(RVA = "0x1361738", Offset = "0x1361738", VA = "0x1361738")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6015CF0")]
	[Address(RVA = "0x136173C", Offset = "0x136173C", VA = "0x136173C")]
	public void _003C_003EiFixBaseProxy_SetInfoType()
	{
	}

	[Token(Token = "0x6015CF1")]
	[Address(RVA = "0x1361740", Offset = "0x1361740", VA = "0x1361740")]
	public void _003C_003EiFixBaseProxy_RegisterUIEvent()
	{
	}

	[Token(Token = "0x6015CF2")]
	[Address(RVA = "0x1361744", Offset = "0x1361744", VA = "0x1361744")]
	public void _003C_003EiFixBaseProxy_UnRegisterUIEvent()
	{
	}
}
