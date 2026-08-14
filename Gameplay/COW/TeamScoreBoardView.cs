using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003395")]
public class TeamScoreBoardView : UIBaseView
{
	[Token(Token = "0x4013ACD")]
	[FieldOffset(Offset = "0x14")]
	public Transform LeftRoot;

	[Token(Token = "0x4013ACE")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LeftTeamScore;

	[Token(Token = "0x4013ACF")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject LeftTeamDefaultIconOB;

	[Token(Token = "0x4013AD0")]
	[FieldOffset(Offset = "0x20")]
	public UISprite LeftTeamDefaultIcon;

	[Token(Token = "0x4013AD1")]
	[FieldOffset(Offset = "0x24")]
	public UISprite LeftTeamIcon;

	[Token(Token = "0x4013AD2")]
	[FieldOffset(Offset = "0x28")]
	public UISprite LeftTeamClanBadge;

	[Token(Token = "0x4013AD3")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LeftTeamName;

	[Token(Token = "0x4013AD4")]
	[FieldOffset(Offset = "0x30")]
	public UISprite LeftCustomIcon;

	[Token(Token = "0x4013AD5")]
	[FieldOffset(Offset = "0x34")]
	public UIScrollView LeftTeamInfoScrollView;

	[Token(Token = "0x4013AD6")]
	[FieldOffset(Offset = "0x38")]
	public UIGrid LeftTeammateGrid;

	[Token(Token = "0x4013AD7")]
	[FieldOffset(Offset = "0x3C")]
	public UIWidget LeftTeammateGridWgt;

	[Token(Token = "0x4013AD8")]
	[FieldOffset(Offset = "0x40")]
	public GameObject LeftDragScroll;

	[Token(Token = "0x4013AD9")]
	[FieldOffset(Offset = "0x44")]
	public GameObject LeftDownArrow;

	[Token(Token = "0x4013ADA")]
	[FieldOffset(Offset = "0x48")]
	public Transform RightRoot;

	[Token(Token = "0x4013ADB")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel RightTeamScore;

	[Token(Token = "0x4013ADC")]
	[FieldOffset(Offset = "0x50")]
	public GameObject RightTeamDefaultIconOB;

	[Token(Token = "0x4013ADD")]
	[FieldOffset(Offset = "0x54")]
	public UISprite RightTeamDefaultIcon;

	[Token(Token = "0x4013ADE")]
	[FieldOffset(Offset = "0x58")]
	public UISprite RightTeamIcon;

	[Token(Token = "0x4013ADF")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite RightTeamClanBadge;

	[Token(Token = "0x4013AE0")]
	[FieldOffset(Offset = "0x60")]
	public UILabel RightTeamName;

	[Token(Token = "0x4013AE1")]
	[FieldOffset(Offset = "0x64")]
	public UISprite RightCustomIcon;

	[Token(Token = "0x4013AE2")]
	[FieldOffset(Offset = "0x68")]
	public UIHudTeamBattleScoreTitle TeamScoreTitleRight;

	[Token(Token = "0x4013AE3")]
	[FieldOffset(Offset = "0x6C")]
	public UIScrollView RightTeamInfoScrollView;

	[Token(Token = "0x4013AE4")]
	[FieldOffset(Offset = "0x70")]
	public UIGrid RightTeammateGrid;

	[Token(Token = "0x4013AE5")]
	[FieldOffset(Offset = "0x74")]
	public UIWidget RightTeammateGridWgt;

	[Token(Token = "0x4013AE6")]
	[FieldOffset(Offset = "0x78")]
	public GameObject RightDragScroll;

	[Token(Token = "0x4013AE7")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject RighttDownArrow;

	[Token(Token = "0x4013AE8")]
	[FieldOffset(Offset = "0x80")]
	public UIButton BackMask;

	[Token(Token = "0x4013AE9")]
	[FieldOffset(Offset = "0x84")]
	public UIButton ReportBtn;

	[Token(Token = "0x4013AEA")]
	[FieldOffset(Offset = "0x88")]
	public UIHudTeamBattleScoreTitle TeamScoreTitleLeft;

	[Token(Token = "0x6015E75")]
	[Address(RVA = "0x28A0D8C", Offset = "0x28A0D8C", VA = "0x28A0D8C")]
	public TeamScoreBoardView()
	{
	}

	[Token(Token = "0x6015E76")]
	[Address(RVA = "0x28A0D94", Offset = "0x28A0D94", VA = "0x28A0D94", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E77")]
	[Address(RVA = "0x28A1984", Offset = "0x28A1984", VA = "0x28A1984")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
