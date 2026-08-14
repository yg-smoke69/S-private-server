using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002866")]
internal class UIHudTDMLeaderboardController : UIHUDTeamBattleScoreBoardController<UIHudCSLeaderboardItemController>
{
	[Token(Token = "0x400F926")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<Transform> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600FCF0")]
	[Address(RVA = "0x1FF392C", Offset = "0x1FF392C", VA = "0x1FF392C")]
	public UIHudTDMLeaderboardController()
	{
	}

	[Token(Token = "0x600FCF1")]
	[Address(RVA = "0x1FF3990", Offset = "0x1FF3990", VA = "0x1FF3990")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FCF2")]
	[Address(RVA = "0x1FF3A38", Offset = "0x1FF3A38", VA = "0x1FF3A38", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FCF3")]
	[Address(RVA = "0x1FF3B1C", Offset = "0x1FF3B1C", VA = "0x1FF3B1C", Slot = "31")]
	protected override void SetInfoType()
	{
	}

	[Token(Token = "0x600FCF4")]
	[Address(RVA = "0x1FF3CCC", Offset = "0x1FF3CCC", VA = "0x1FF3CCC", Slot = "33")]
	public override void RegisterUIEvent()
	{
	}

	[Token(Token = "0x600FCF5")]
	[Address(RVA = "0x1FF400C", Offset = "0x1FF400C", VA = "0x1FF400C", Slot = "34")]
	public override void UnRegisterUIEvent()
	{
	}

	[Token(Token = "0x600FCF6")]
	[Address(RVA = "0x1FF434C", Offset = "0x1FF434C", VA = "0x1FF434C", Slot = "38")]
	protected override bool IsTeamOnLeft(IHAAMHPPLMG pId)
	{
		return default(bool);
	}

	[Token(Token = "0x600FCF7")]
	[Address(RVA = "0x1FF4548", Offset = "0x1FF4548", VA = "0x1FF4548")]
	private void Sort(IHAAMHPPLMG pId)
	{
	}

	[Token(Token = "0x600FCF8")]
	[Address(RVA = "0x1FF472C", Offset = "0x1FF472C", VA = "0x1FF472C", Slot = "41")]
	protected override void OnKillCountChanged(object[] param)
	{
	}

	[Token(Token = "0x600FCF9")]
	[Address(RVA = "0x1FF4854", Offset = "0x1FF4854", VA = "0x1FF4854", Slot = "42")]
	protected override void OnDeadCountChanged(object[] param)
	{
	}

	[Token(Token = "0x600FCFA")]
	[Address(RVA = "0x1FF497C", Offset = "0x1FF497C", VA = "0x1FF497C", Slot = "43")]
	protected override void OnTotalDamageChanged(object[] param)
	{
	}

	[Token(Token = "0x600FCFB")]
	[Address(RVA = "0x1FF4AA4", Offset = "0x1FF4AA4", VA = "0x1FF4AA4")]
	private void OnCSNewPhaseStarted(object[] param)
	{
	}

	[Token(Token = "0x600FCFC")]
	[Address(RVA = "0x1FF4B98", Offset = "0x1FF4B98", VA = "0x1FF4B98")]
	private void OnToggleRoundInfo(object[] parap)
	{
	}

	[Token(Token = "0x600FCFD")]
	[Address(RVA = "0x1FF4C4C", Offset = "0x1FF4C4C", VA = "0x1FF4C4C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600FCFE")]
	[Address(RVA = "0x1FF4D44", Offset = "0x1FF4D44", VA = "0x1FF4D44")]
	private void OnTeamScoreChange(object[] data)
	{
	}

	[Token(Token = "0x600FCFF")]
	[Address(RVA = "0x1FF4E6C", Offset = "0x1FF4E6C", VA = "0x1FF4E6C")]
	private void UpdateTeamScore(int teamIndex, int score)
	{
	}

	[Token(Token = "0x600FD00")]
	[Address(RVA = "0x1FF4F3C", Offset = "0x1FF4F3C", VA = "0x1FF4F3C")]
	private static int _003CSort_003Em__0(Transform item2, Transform item1)
	{
		return default(int);
	}

	[Token(Token = "0x600FD01")]
	[Address(RVA = "0x1FF5190", Offset = "0x1FF5190", VA = "0x1FF5190")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FD02")]
	[Address(RVA = "0x1FF5194", Offset = "0x1FF5194", VA = "0x1FF5194")]
	public void _003C_003EiFixBaseProxy_SetInfoType()
	{
	}

	[Token(Token = "0x600FD03")]
	[Address(RVA = "0x1FF5198", Offset = "0x1FF5198", VA = "0x1FF5198")]
	public void _003C_003EiFixBaseProxy_RegisterUIEvent()
	{
	}

	[Token(Token = "0x600FD04")]
	[Address(RVA = "0x1FF519C", Offset = "0x1FF519C", VA = "0x1FF519C")]
	public void _003C_003EiFixBaseProxy_UnRegisterUIEvent()
	{
	}

	[Token(Token = "0x600FD05")]
	[Address(RVA = "0x1FF51A0", Offset = "0x1FF51A0", VA = "0x1FF51A0")]
	public bool _003C_003EiFixBaseProxy_IsTeamOnLeft(IHAAMHPPLMG P0)
	{
		return default(bool);
	}

	[Token(Token = "0x600FD06")]
	[Address(RVA = "0x1FF51CC", Offset = "0x1FF51CC", VA = "0x1FF51CC")]
	public void _003C_003EiFixBaseProxy_OnKillCountChanged(object[] P0)
	{
	}

	[Token(Token = "0x600FD07")]
	[Address(RVA = "0x1FF51D0", Offset = "0x1FF51D0", VA = "0x1FF51D0")]
	public void _003C_003EiFixBaseProxy_OnDeadCountChanged(object[] P0)
	{
	}

	[Token(Token = "0x600FD08")]
	[Address(RVA = "0x1FF51D4", Offset = "0x1FF51D4", VA = "0x1FF51D4")]
	public void _003C_003EiFixBaseProxy_OnTotalDamageChanged(object[] P0)
	{
	}

	[Token(Token = "0x600FD09")]
	[Address(RVA = "0x1FF51D8", Offset = "0x1FF51D8", VA = "0x1FF51D8")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
