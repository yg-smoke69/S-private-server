using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003465")]
public class UIClanWarNewsView : UIBaseView
{
	[Token(Token = "0x40145A2")]
	[FieldOffset(Offset = "0x14")]
	public UILabel SeasonTime;

	[Token(Token = "0x40145A3")]
	[FieldOffset(Offset = "0x18")]
	public GameObject MapsPanel;

	[Token(Token = "0x40145A4")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView MapScrollView;

	[Token(Token = "0x40145A5")]
	[FieldOffset(Offset = "0x20")]
	public UIWrapContent MapsContent;

	[Token(Token = "0x40145A6")]
	[FieldOffset(Offset = "0x24")]
	public UILabel MapInfo;

	[Token(Token = "0x40145A7")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ParticipantNum;

	[Token(Token = "0x40145A8")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton RuleGuideBtn;

	[Token(Token = "0x40145A9")]
	[FieldOffset(Offset = "0x30")]
	public UILabel RuleDescLabel1;

	[Token(Token = "0x40145AA")]
	[FieldOffset(Offset = "0x34")]
	public UILabel RuleDescLabel2;

	[Token(Token = "0x40145AB")]
	[FieldOffset(Offset = "0x38")]
	public UIButton RewardIndividualTip;

	[Token(Token = "0x40145AC")]
	[FieldOffset(Offset = "0x3C")]
	public UIScrollView RewardIndividualScrollView;

	[Token(Token = "0x40145AD")]
	[FieldOffset(Offset = "0x40")]
	public UIGrid RewardIndividualGrid;

	[Token(Token = "0x40145AE")]
	[FieldOffset(Offset = "0x44")]
	public UIScrollView RewardTeamScrollView;

	[Token(Token = "0x40145AF")]
	[FieldOffset(Offset = "0x48")]
	public UIGrid RewardTeamGrid;

	[Token(Token = "0x40145B0")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject BeforeStage;

	[Token(Token = "0x40145B1")]
	[FieldOffset(Offset = "0x50")]
	public UIButton LastSeasonBtn;

	[Token(Token = "0x40145B2")]
	[FieldOffset(Offset = "0x54")]
	public UICountDownLabel BeforeStageCountDown;

	[Token(Token = "0x40145B3")]
	[FieldOffset(Offset = "0x58")]
	public GameObject ProcessingStage;

	[Token(Token = "0x40145B4")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton ToMatchBtn;

	[Token(Token = "0x40145B5")]
	[FieldOffset(Offset = "0x60")]
	public UICountDownLabel ProcessStageCountDown;

	[Token(Token = "0x40145B6")]
	[FieldOffset(Offset = "0x64")]
	public GameObject AfterStage;

	[Token(Token = "0x40145B7")]
	[FieldOffset(Offset = "0x68")]
	public UIButton ToRewardBtn;

	[Token(Token = "0x40145B8")]
	[FieldOffset(Offset = "0x6C")]
	public UICountDownLabel AfterStageCountDown;

	[Token(Token = "0x40145B9")]
	[FieldOffset(Offset = "0x70")]
	public GameObject NoConfig;

	[Token(Token = "0x40145BA")]
	[FieldOffset(Offset = "0x74")]
	public GameObject UnavailableStage;

	[Token(Token = "0x40145BB")]
	[FieldOffset(Offset = "0x78")]
	public UILabel UnavailableLabel;

	[Token(Token = "0x60160E3")]
	[Address(RVA = "0x2903D0C", Offset = "0x2903D0C", VA = "0x2903D0C")]
	public UIClanWarNewsView()
	{
	}

	[Token(Token = "0x60160E4")]
	[Address(RVA = "0x2903D14", Offset = "0x2903D14", VA = "0x2903D14", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160E5")]
	[Address(RVA = "0x29047D4", Offset = "0x29047D4", VA = "0x29047D4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
