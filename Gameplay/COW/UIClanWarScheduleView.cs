using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003469")]
public class UIClanWarScheduleView : UIBaseView
{
	[Token(Token = "0x40145DA")]
	[FieldOffset(Offset = "0x14")]
	public UILabel SingleRewardCnt;

	[Token(Token = "0x40145DB")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SingleRewardTagVfx;

	[Token(Token = "0x40145DC")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton SingleBoxBtn;

	[Token(Token = "0x40145DD")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Received;

	[Token(Token = "0x40145DE")]
	[FieldOffset(Offset = "0x24")]
	public UILabel SingleRewardNum;

	[Token(Token = "0x40145DF")]
	[FieldOffset(Offset = "0x28")]
	public GameObject SingleBoxClaimed;

	[Token(Token = "0x40145E0")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject SingleBoxUnavailable;

	[Token(Token = "0x40145E1")]
	[FieldOffset(Offset = "0x30")]
	public GameObject SingleBoxAvailable;

	[Token(Token = "0x40145E2")]
	[FieldOffset(Offset = "0x34")]
	public GameObject SingleBoxAvailableTips;

	[Token(Token = "0x40145E3")]
	[FieldOffset(Offset = "0x38")]
	public UILabel TeamRewardCnt;

	[Token(Token = "0x40145E4")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite Progress1;

	[Token(Token = "0x40145E5")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ProgressEnd1;

	[Token(Token = "0x40145E6")]
	[FieldOffset(Offset = "0x44")]
	public GameObject TeamBoxPos1;

	[Token(Token = "0x40145E7")]
	[FieldOffset(Offset = "0x48")]
	public GameObject ProgressEnd2;

	[Token(Token = "0x40145E8")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite Progress2;

	[Token(Token = "0x40145E9")]
	[FieldOffset(Offset = "0x50")]
	public GameObject TeamBoxPos2;

	[Token(Token = "0x40145EA")]
	[FieldOffset(Offset = "0x54")]
	public UISprite Progress3;

	[Token(Token = "0x40145EB")]
	[FieldOffset(Offset = "0x58")]
	public GameObject ProgressEnd3;

	[Token(Token = "0x40145EC")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject TeamBoxPos3;

	[Token(Token = "0x40145ED")]
	[FieldOffset(Offset = "0x60")]
	public GameObject TeamBoxPos4;

	[Token(Token = "0x40145EE")]
	[FieldOffset(Offset = "0x64")]
	public UISprite Progress4;

	[Token(Token = "0x40145EF")]
	[FieldOffset(Offset = "0x68")]
	public GameObject ProgressEnd4;

	[Token(Token = "0x40145F0")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject TeamBoxBottom;

	[Token(Token = "0x40145F1")]
	[FieldOffset(Offset = "0x70")]
	public GameObject ClaimCountDownContainer;

	[Token(Token = "0x40145F2")]
	[FieldOffset(Offset = "0x74")]
	public UIButton TeamBoxRuleBtn;

	[Token(Token = "0x40145F3")]
	[FieldOffset(Offset = "0x78")]
	public UILabel RewardClaimLabel;

	[Token(Token = "0x40145F4")]
	[FieldOffset(Offset = "0x7C")]
	public UICountDownLabel RewardClaimCountDown;

	[Token(Token = "0x40145F5")]
	[FieldOffset(Offset = "0x80")]
	public GameObject MarchTeamContainer;

	[Token(Token = "0x40145F6")]
	[FieldOffset(Offset = "0x84")]
	public GameObject LeaderboardContainer;

	[Token(Token = "0x40145F7")]
	[FieldOffset(Offset = "0x88")]
	public GameObject TeamChatContainer;

	[Token(Token = "0x60160EF")]
	[Address(RVA = "0x290C300", Offset = "0x290C300", VA = "0x290C300")]
	public UIClanWarScheduleView()
	{
	}

	[Token(Token = "0x60160F0")]
	[Address(RVA = "0x290C308", Offset = "0x290C308", VA = "0x290C308", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160F1")]
	[Address(RVA = "0x290CEB8", Offset = "0x290CEB8", VA = "0x290CEB8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
