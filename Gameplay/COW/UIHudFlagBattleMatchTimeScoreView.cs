using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003655")]
public class UIHudFlagBattleMatchTimeScoreView : UIBaseView
{
	[Token(Token = "0x4015CD4")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnLeaderboard;

	[Token(Token = "0x4015CD5")]
	[FieldOffset(Offset = "0x18")]
	public UILabel time;

	[Token(Token = "0x4015CD6")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel targetScore;

	[Token(Token = "0x4015CD7")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LocalTeamScore;

	[Token(Token = "0x4015CD8")]
	[FieldOffset(Offset = "0x24")]
	public UIProgressBar LocalTeamScoreBar;

	[Token(Token = "0x4015CD9")]
	[FieldOffset(Offset = "0x28")]
	public UILabel OppTeamScore;

	[Token(Token = "0x4015CDA")]
	[FieldOffset(Offset = "0x2C")]
	public UIProgressBar OppTeamScoreBar;

	[Token(Token = "0x4015CDB")]
	[FieldOffset(Offset = "0x30")]
	public GameObject GetScoreVFX_Local;

	[Token(Token = "0x4015CDC")]
	[FieldOffset(Offset = "0x34")]
	public GameObject GetScoreVFX_Opp;

	[Token(Token = "0x4015CDD")]
	[FieldOffset(Offset = "0x38")]
	public GameObject MyTeamEnergyStone1;

	[Token(Token = "0x4015CDE")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject MyTeamEnergyStone2;

	[Token(Token = "0x4015CDF")]
	[FieldOffset(Offset = "0x40")]
	public GameObject OppoTeamEnergyStone1;

	[Token(Token = "0x4015CE0")]
	[FieldOffset(Offset = "0x44")]
	public GameObject OppoTeamEnergyStone2;

	[Token(Token = "0x4015CE1")]
	[FieldOffset(Offset = "0x48")]
	public UIWidget TutorialWidget;

	[Token(Token = "0x60166AC")]
	[Address(RVA = "0x1BB1918", Offset = "0x1BB1918", VA = "0x1BB1918")]
	public UIHudFlagBattleMatchTimeScoreView()
	{
	}

	[Token(Token = "0x60166AD")]
	[Address(RVA = "0x1BB1920", Offset = "0x1BB1920", VA = "0x1BB1920", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166AE")]
	[Address(RVA = "0x1BB1F60", Offset = "0x1BB1F60", VA = "0x1BB1F60")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
