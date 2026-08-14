using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002774")]
internal class UIHudGuildWarLeaderboardController : UIHUDTeamBattleScoreBoardController<UIHudCSLeaderboardItemController>
{
	[Token(Token = "0x400F390")]
	[FieldOffset(Offset = "0x41")]
	private bool m_IsLeftTeamClanInit;

	[Token(Token = "0x400F391")]
	[FieldOffset(Offset = "0x42")]
	private bool m_IsRightTeamClanInit;

	[Token(Token = "0x400F392")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<Transform> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600F17A")]
	[Address(RVA = "0x133C920", Offset = "0x133C920", VA = "0x133C920")]
	public UIHudGuildWarLeaderboardController()
	{
	}

	[Token(Token = "0x600F17B")]
	[Address(RVA = "0x133C984", Offset = "0x133C984", VA = "0x133C984")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F17C")]
	[Address(RVA = "0x133CA2C", Offset = "0x133CA2C", VA = "0x133CA2C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F17D")]
	[Address(RVA = "0x133CBF0", Offset = "0x133CBF0", VA = "0x133CBF0", Slot = "31")]
	protected override void SetInfoType()
	{
	}

	[Token(Token = "0x600F17E")]
	[Address(RVA = "0x133CDA0", Offset = "0x133CDA0", VA = "0x133CDA0", Slot = "33")]
	public override void RegisterUIEvent()
	{
	}

	[Token(Token = "0x600F17F")]
	[Address(RVA = "0x133D1B0", Offset = "0x133D1B0", VA = "0x133D1B0", Slot = "34")]
	public override void UnRegisterUIEvent()
	{
	}

	[Token(Token = "0x600F180")]
	[Address(RVA = "0x133D5C0", Offset = "0x133D5C0", VA = "0x133D5C0", Slot = "38")]
	protected override bool IsTeamOnLeft(IHAAMHPPLMG pId)
	{
		return default(bool);
	}

	[Token(Token = "0x600F181")]
	[Address(RVA = "0x133D7BC", Offset = "0x133D7BC", VA = "0x133D7BC")]
	private void Sort(IHAAMHPPLMG pId)
	{
	}

	[Token(Token = "0x600F182")]
	[Address(RVA = "0x133D9A0", Offset = "0x133D9A0", VA = "0x133D9A0", Slot = "41")]
	protected override void OnKillCountChanged(object[] param)
	{
	}

	[Token(Token = "0x600F183")]
	[Address(RVA = "0x133DAC8", Offset = "0x133DAC8", VA = "0x133DAC8")]
	protected void OnGuildWarItemChange(object[] param)
	{
	}

	[Token(Token = "0x600F184")]
	[Address(RVA = "0x133DBE0", Offset = "0x133DBE0", VA = "0x133DBE0", Slot = "42")]
	protected override void OnDeadCountChanged(object[] param)
	{
	}

	[Token(Token = "0x600F185")]
	[Address(RVA = "0x133DD08", Offset = "0x133DD08", VA = "0x133DD08", Slot = "43")]
	protected override void OnTotalDamageChanged(object[] param)
	{
	}

	[Token(Token = "0x600F186")]
	[Address(RVA = "0x133DE30", Offset = "0x133DE30", VA = "0x133DE30")]
	private void OnCSNewPhaseStarted(object[] param)
	{
	}

	[Token(Token = "0x600F187")]
	[Address(RVA = "0x133DF24", Offset = "0x133DF24", VA = "0x133DF24")]
	private void OnToggleRoundInfo(object[] parap)
	{
	}

	[Token(Token = "0x600F188")]
	[Address(RVA = "0x133DFD8", Offset = "0x133DFD8", VA = "0x133DFD8", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F189")]
	[Address(RVA = "0x133E0D0", Offset = "0x133E0D0", VA = "0x133E0D0")]
	private void OnTeamScoreChange(object[] data)
	{
	}

	[Token(Token = "0x600F18A")]
	[Address(RVA = "0x133E1F8", Offset = "0x133E1F8", VA = "0x133E1F8")]
	private void UpdateTeamScore(int teamIndex, int score)
	{
	}

	[Token(Token = "0x600F18B")]
	[Address(RVA = "0x133E2C8", Offset = "0x133E2C8", VA = "0x133E2C8")]
	private void OnPlayerJoin(object[] param)
	{
	}

	[Token(Token = "0x600F18C")]
	[Address(RVA = "0x133EB24", Offset = "0x133EB24", VA = "0x133EB24")]
	private static int _003CSort_003Em__0(Transform item2, Transform item1)
	{
		return default(int);
	}

	[Token(Token = "0x600F18D")]
	[Address(RVA = "0x133ED20", Offset = "0x133ED20", VA = "0x133ED20")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F18E")]
	[Address(RVA = "0x133ED24", Offset = "0x133ED24", VA = "0x133ED24")]
	public void _003C_003EiFixBaseProxy_SetInfoType()
	{
	}

	[Token(Token = "0x600F18F")]
	[Address(RVA = "0x133ED28", Offset = "0x133ED28", VA = "0x133ED28")]
	public void _003C_003EiFixBaseProxy_RegisterUIEvent()
	{
	}

	[Token(Token = "0x600F190")]
	[Address(RVA = "0x133ED2C", Offset = "0x133ED2C", VA = "0x133ED2C")]
	public void _003C_003EiFixBaseProxy_UnRegisterUIEvent()
	{
	}

	[Token(Token = "0x600F191")]
	[Address(RVA = "0x133ED30", Offset = "0x133ED30", VA = "0x133ED30")]
	public bool _003C_003EiFixBaseProxy_IsTeamOnLeft(IHAAMHPPLMG P0)
	{
		return default(bool);
	}

	[Token(Token = "0x600F192")]
	[Address(RVA = "0x133ED5C", Offset = "0x133ED5C", VA = "0x133ED5C")]
	public void _003C_003EiFixBaseProxy_OnKillCountChanged(object[] P0)
	{
	}

	[Token(Token = "0x600F193")]
	[Address(RVA = "0x133ED60", Offset = "0x133ED60", VA = "0x133ED60")]
	public void _003C_003EiFixBaseProxy_OnDeadCountChanged(object[] P0)
	{
	}

	[Token(Token = "0x600F194")]
	[Address(RVA = "0x133ED64", Offset = "0x133ED64", VA = "0x133ED64")]
	public void _003C_003EiFixBaseProxy_OnTotalDamageChanged(object[] P0)
	{
	}

	[Token(Token = "0x600F195")]
	[Address(RVA = "0x133ED68", Offset = "0x133ED68", VA = "0x133ED68")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
