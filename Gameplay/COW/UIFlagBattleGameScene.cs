using System;
using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003313")]
internal class UIFlagBattleGameScene : UITeamModeBaseGameScene
{
	[Token(Token = "0x4013682")]
	[FieldOffset(Offset = "0x2D8")]
	private Dictionary<uint, UIHudEnergyStoneBoxMarkController> m_EnergyStoneBoxMarks;

	[Token(Token = "0x4013683")]
	[FieldOffset(Offset = "0x2DC")]
	private List<UIHudEnergyStoneBoxMarkController> m_CacheEnergyStoneBoxList;

	[Token(Token = "0x4013684")]
	[FieldOffset(Offset = "0x2E0")]
	private Dictionary<IHAAMHPPLMG, UIHudEnergyStoneMarkController> m_EnergyStoneMarks;

	[Token(Token = "0x4013685")]
	[FieldOffset(Offset = "0x2E4")]
	private UIHudChokePointBuffDurationController m_ChokePointBuffDurationCtrl;

	[Token(Token = "0x4013686")]
	[FieldOffset(Offset = "0x2E8")]
	private UIHudGameShowInfoController m_ShowInfoStyle;

	[Token(Token = "0x4013687")]
	[FieldOffset(Offset = "0x2EC")]
	private uint m_TutorialDelayCallID;

	[Token(Token = "0x60158DC")]
	[Address(RVA = "0x1DC008C", Offset = "0x1DC008C", VA = "0x1DC008C")]
	public UIFlagBattleGameScene()
	{
	}

	[Token(Token = "0x60158DD")]
	[Address(RVA = "0x1DC0180", Offset = "0x1DC0180", VA = "0x1DC0180", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x60158DE")]
	[Address(RVA = "0x1DC047C", Offset = "0x1DC047C", VA = "0x1DC047C", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x60158DF")]
	[Address(RVA = "0x1DC08F0", Offset = "0x1DC08F0", VA = "0x1DC08F0", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x60158E0")]
	[Address(RVA = "0x1DC0DE0", Offset = "0x1DC0DE0", VA = "0x1DC0DE0")]
	private void OnShowInfoStyle(object[] param)
	{
	}

	[Token(Token = "0x60158E1")]
	[Address(RVA = "0x1DC1010", Offset = "0x1DC1010", VA = "0x1DC1010")]
	private void ShowControlLeaderboard(object[] data)
	{
	}

	[Token(Token = "0x60158E2")]
	[Address(RVA = "0x1DC111C", Offset = "0x1DC111C", VA = "0x1DC111C")]
	private void OnEnergyStoneBoxStateChange(object[] param)
	{
	}

	[Token(Token = "0x60158E3")]
	[Address(RVA = "0x1DC1614", Offset = "0x1DC1614", VA = "0x1DC1614")]
	private void OnPlayerOwnEnergyStoneStateChange(object[] param)
	{
	}

	[Token(Token = "0x60158E4")]
	[Address(RVA = "0x1DC19AC", Offset = "0x1DC19AC", VA = "0x1DC19AC")]
	private new void OnLocalPlayerRevive(object[] param)
	{
	}

	[Token(Token = "0x60158E5")]
	[Address(RVA = "0x1DC1B50", Offset = "0x1DC1B50", VA = "0x1DC1B50")]
	private void OnPlayerDie(object[] param)
	{
	}

	[Token(Token = "0x60158E6")]
	[Address(RVA = "0x1DC1E84", Offset = "0x1DC1E84", VA = "0x1DC1E84")]
	private void OnChokePointBuffCreate(object[] param)
	{
	}

	[Token(Token = "0x60158E7")]
	[Address(RVA = "0x1DC20B4", Offset = "0x1DC20B4", VA = "0x1DC20B4")]
	private void OnChokePointBuffEnd(object[] param)
	{
	}

	[Token(Token = "0x60158E8")]
	[Address(RVA = "0x1DC21B8", Offset = "0x1DC21B8", VA = "0x1DC21B8")]
	private void OnIntroInfoDone(object[] param)
	{
	}

	[Token(Token = "0x60158E9")]
	[Address(RVA = "0x1DC27FC", Offset = "0x1DC27FC", VA = "0x1DC27FC", Slot = "20")]
	protected override Type GetMatchResultType()
	{
		return null;
	}

	[Token(Token = "0x60158EA")]
	[Address(RVA = "0x1DC28D8", Offset = "0x1DC28D8", VA = "0x1DC28D8")]
	private void _003COnIntroInfoDone_003Em__0()
	{
	}

	[Token(Token = "0x60158EB")]
	[Address(RVA = "0x1DC29A4", Offset = "0x1DC29A4", VA = "0x1DC29A4")]
	public new void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x60158EC")]
	[Address(RVA = "0x1DC29AC", Offset = "0x1DC29AC", VA = "0x1DC29AC")]
	public new void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x60158ED")]
	[Address(RVA = "0x1DC29B4", Offset = "0x1DC29B4", VA = "0x1DC29B4")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x60158EE")]
	[Address(RVA = "0x1DC29BC", Offset = "0x1DC29BC", VA = "0x1DC29BC")]
	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}
